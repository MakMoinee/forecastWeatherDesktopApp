Imports System.IO
Imports System.Net.Http
Imports System.Text.Json

Public Class frmForecast
    Dim frmL As New frmLoading

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerHome()
        End If
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerManualForecast()
        End If
    End Sub

    Private Async Function UploadCSVFile(filePath As String) As Task(Of String)

        Try
            ' Create an instance of HttpClient
            Using client As New HttpClient()
                ' Create a MultipartFormDataContent object
                Using form As New MultipartFormDataContent()
                    ' Read the file content
                    Dim fileContent As ByteArrayContent = New ByteArrayContent(File.ReadAllBytes(filePath))
                    fileContent.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("text/csv")

                    ' Add the file content to the form with the name "file"
                    form.Add(fileContent, "file", Path.GetFileName(filePath))

                    ' Send a POST request to the API endpoint
                    Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:5000/predict", form)

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

    Private Async Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        ' Create an OpenFileDialog to select the CSV file
        Dim openFileDialog As New OpenFileDialog()

        ' Set the dialog properties
        openFileDialog.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog.Title = "Open CSV File"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim filePath As String = openFileDialog.FileName

            systemAddLog(String.Format("{0}: imported csv for auto forecasting", CURRENT_USER), filePath, "")

            ' Create and show the loading form
            Dim frmL As New frmLoading
            frmL.Show()

            ' Disable the main form while the loading form is displayed
            Me.Enabled = False

            ' Call the async function to upload the selected CSV file
            Dim response As String = Await UploadCSVFile(filePath)

            ' Close the loading form after the task is complete
            frmL.Hide()

            ' Re-enable the main form
            Me.Enabled = True

            ' Show the response
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
                        Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
                        mdiParent.triggerResult(demandDataList)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error parsing JSON: " & ex.Message, "Parsing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No data received from the server.", "Upload Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No file selected.", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pbInfo_Click(sender As Object, e As EventArgs) Handles pbInfo.Click
        Dim frmInf As New frmInfo
        frmInf.isForTrain = False
        If frmInf.ShowDialog() = DialogResult.Cancel Then
            frmInf.Hide()
        Else
            frmInf.Hide()
        End If
    End Sub
End Class