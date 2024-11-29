Imports System.IO
Imports System.Text
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Text.Json

Public Class frmManualForecast
    Dim frmL As New frmLoading

    Private Sub pbClose_Click_1(sender As Object, e As EventArgs) Handles pbClose.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerHome()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgData.ClearSelection()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If dgData.Rows.Count > 0 Then
            exportDataGridViewToCSV()
        Else
            MsgBox("Please populate your data first", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Async Sub exportDataGridViewToCSV()
        Try
            ' Get the path to the bin\Data directory
            Dim binDirectory As String = AppDomain.CurrentDomain.BaseDirectory
            Dim dataDirectory As String = Path.Combine(binDirectory, "Data")

            ' Create the Data directory if it doesn't exist
            If Not Directory.Exists(dataDirectory) Then
                Directory.CreateDirectory(dataDirectory)
            End If

            ' Generate a timestamp-based file name
            Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            Dim fileName As String = "DataGridViewData_" & timestamp & ".csv"
            Dim filePath As String = Path.Combine(dataDirectory, fileName)

            Dim sb As New StringBuilder()

            ' Add the header row
            Dim headerColumns As New List(Of String)()
            For Each column As DataGridViewColumn In dgData.Columns
                If column.HeaderText.Contains("Date") Then
                    headerColumns.Add("Date")
                Else
                    headerColumns.Add(column.HeaderText)
                End If

            Next
            sb.AppendLine(String.Join(",", headerColumns))

            ' Add the data rows
            For Each row As DataGridViewRow In dgData.Rows
                If Not row.IsNewRow Then
                    Dim cells As New List(Of String)()
                    For Each cell As DataGridViewCell In row.Cells
                        cells.Add(cell.Value?.ToString())
                    Next
                    sb.AppendLine(String.Join(",", cells))
                End If
            Next

            ' Write the content to the CSV file
            File.WriteAllText(filePath, sb.ToString())

            MessageBox.Show("Data exported successfully, Now Uploading ... ", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.Enabled = False
            Dim response = Await UploadCSVFile(filePath)
            frmL.Hide()
            mdiParent.Enabled = True

            If Not String.IsNullOrEmpty(response) Then

                Try
                    ' Deserialize JSON string to a list of dictionaries
                    Dim demandDataDictList As List(Of Dictionary(Of String, Double)) = JsonSerializer.Deserialize(Of List(Of Dictionary(Of String, Double)))(response)

                    ' Convert the list of dictionaries to a list of DemandData objects
                    Dim demandDataList As New List(Of DemandData)()

                    For Each dict In demandDataDictList
                        For Each kvp In dict
                            Dim demandData As New DemandData With {
                        .Date = kvp.Key,
                        .Demand_Load = kvp.Value
                    }
                            demandDataList.Add(demandData)
                        Next
                    Next

                    If demandDataList.Count > 0 Then
                        systemAddLog(String.Format("{0}: manual forecasting", CURRENT_USER), filePath, "")
                        Dim mdParent As frmMain = CType(Me.MdiParent, frmMain)
                        mdParent.triggerResult(demandDataList)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error parsing JSON: " & ex.Message, "Parsing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function UploadCSVFile(filePath As String) As Task(Of String)

        frmL.Show()
        Try
            ' Create an instance of HttpClient
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromMinutes(5)
                ' Create a MultipartFormDataContent object
                Using form As New MultipartFormDataContent()
                    ' Read the file content
                    Dim fileContent As ByteArrayContent = New ByteArrayContent(File.ReadAllBytes(filePath))
                    fileContent.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("text/csv")

                    ' Add the file content to the form with the name "file"
                    form.Add(fileContent, "file", Path.GetFileName(filePath))

                    ' Send a POST request to the API endpoint
                    Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:5000/manual/predict", form)

                    ' Ensure the request was successful
                    response.EnsureSuccessStatusCode()

                    ' Read the response content
                    Dim result As String = Await response.Content.ReadAsStringAsync()
                    Return result
                End Using
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during the upload
            MessageBox.Show("Error: " & ex.Message, "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Private Sub frmManualForecast_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If dgData.Rows.Count > 0 Then
            dgData.Rows.Clear()
        End If
    End Sub
End Class