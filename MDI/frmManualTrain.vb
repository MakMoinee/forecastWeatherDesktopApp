Imports System.IO
Imports System.Net.Http
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json.Linq

Public Class frmManualTrain
    Dim frmL As New frmLoading
    Dim weatherList As New List(Of WeatherData)
    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerHome()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If dgData.Rows.Count > 0 Then
            dgData.Rows.Clear()
        End If
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
            Dim fileName As String = "TrainData_" & timestamp & ".csv"
            Dim filePath As String = Path.Combine(dataDirectory, fileName)

            Dim sb As New StringBuilder()

            ' Add the header row
            Dim headerColumns As New List(Of String)()
            For Each column As DataGridViewColumn In dgSample.Columns
                headerColumns.Add(column.HeaderText)
            Next
            sb.AppendLine(String.Join(",", headerColumns))

            If weatherList.Count > 0 Then
                For Each weather As WeatherData In weatherList
                    Dim cells As New List(Of String)
                    Dim dateParts = weather.dateLogs.Split("/")
                    cells.Add(weather.dateLogs)
                    cells.Add(dateParts(1).ToString)
                    cells.Add(getTextMonth(dateParts(0).ToString))
                    cells.Add(weather.day.ToString())
                    cells.Add(weather.weekdayOrWeekend)
                    cells.Add(weather.typeOfDay)
                    cells.Add(weather.meanTemperature.ToString())
                    cells.Add(weather.rainFall.ToString())
                    cells.Add(weather.relativeHumidity.ToString())
                    cells.Add(weather.windspeed.ToString())
                    cells.Add(weather.demandLoad.ToString())
                    sb.AppendLine(String.Join(",", cells))
                Next
            End If

            ' Add the data rows
            For Each row As DataGridViewRow In dgData.Rows
                If Not row.IsNewRow Then
                    Dim cells As New List(Of String)()
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.ColumnIndex = 0 Then
                            Dim dateParts = cell.Value?.ToString().Split("/")
                            cells.Add(cell.Value?.ToString())
                            cells.Add(dateParts(1).ToString())
                            cells.Add(getTextMonth(dateParts(0).ToString))
                        Else
                            cells.Add(cell.Value?.ToString())
                        End If

                    Next
                    sb.AppendLine(String.Join(",", cells))
                End If
            Next

            ' Write the content to the CSV file
            File.WriteAllText(filePath, sb.ToString())
            systemAddLog(String.Format("{0}: manual train", CURRENT_USER), filePath, "")
            MessageBox.Show("Data exported successfully, Now Uploading ... ", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.Enabled = False
            Dim response = Await GetTrainingStatusAsync(filePath)
            frmL.Hide()
            mdiParent.Enabled = True
            If response = "failed" Then
                MsgBox("Failed To Train, Please Try Again Later", MsgBoxStyle.Critical)
            Else

                'MsgBox("Waiting for the server to restart ...", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

                frmL = New frmLoading
                frmL.str = "Restarting Server ..."
                frmL.Show()
                Me.Enabled = False
                Thread.Sleep(5000)
                Dim healthResponse As String = Await GetHealthStatusAsync()
                frmL.Hide()
                If response = "failed" Then
                    MsgBox("Something Error Happen, Please Open Application Again", MsgBoxStyle.Critical)
                    Application.Exit()
                Else
                    Me.Enabled = True
                    MsgBox("Successfully Done Training", MsgBoxStyle.OkOnly, MsgBoxStyle.Information)

                End If
            End If



        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function GetHealthStatusAsync() As Task(Of String)
        Dim apiUrl As String = "http://127.0.0.1:5000/health"

        Try
            Using client As New HttpClient()
                ' Make the HTTP GET request
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                ' Ensure the request was successful
                response.EnsureSuccessStatusCode()

                ' Read the response content
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Parse the JSON response
                Dim jsonResponse As JObject = JObject.Parse(responseContent)

                ' Check for status or error in the response
                If response.IsSuccessStatusCode Then
                    Dim status As String = jsonResponse("status").ToString()
                    If status = "OK" Then
                        Return "success"
                    Else
                        Return "failed"
                    End If

                Else
                    'Dim errorMessage As String = jsonResponse("error").ToString()
                    Return "failed"
                End If
            End Using


        Catch ex As HttpRequestException
            Return "failed"
        Catch ex As Exception
            Return "failed"
        End Try
    End Function


    Private Async Function GetTrainingStatusAsync(filePath As String) As Task(Of String)
        Dim apiUrl As String = $"http://127.0.0.1:5000/full?filePath={filePath}"

        Try
            Using client As New HttpClient()
                ' Make the HTTP GET request
                Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl)

                ' Ensure the request was successful
                response.EnsureSuccessStatusCode()

                ' Read the response content
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Parse the JSON response
                Dim jsonResponse As JObject = JObject.Parse(responseContent)

                ' Check for status or error in the response
                If response.IsSuccessStatusCode Then
                    Dim status As String = jsonResponse("status").ToString()
                    Dim trainingTime As Double = jsonResponse("training_time").ToObject(Of Double)()
                    Return $"Status: {status}, Training Time: {trainingTime}"
                Else
                    'Dim errorMessage As String = jsonResponse("error").ToString()
                    Return "failed"
                End If
            End Using


        Catch ex As HttpRequestException
            Return "failed"
        Catch ex As Exception
            Return "failed"
        End Try
    End Function

    Private Sub frmManualTrain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmManualTrain_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        loadDatas()
    End Sub

    Private Sub loadDatas()
        Dim weatherService As New WeatherService
        weatherList = weatherService.getWeatherData()
    End Sub
End Class