Imports System.Net.Http
Imports System.Threading
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class frmUpdate
    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerHome()
        End If
    End Sub


    Private Sub pbInfo_Click(sender As Object, e As EventArgs) Handles pbInfo.Click
        Dim frmInf As New frmInfo
        frmInf.isForTrain = True
        If frmInf.ShowDialog() = DialogResult.Cancel Then
            frmInf.Hide()
        Else
            frmInf.Hide()
        End If
    End Sub

    Private Async Function GetTrainingStatusAsync(filePath As String) As Task(Of String)
        Dim apiUrl As String = $"http://127.0.0.1:5000/full?isFull=True&filePath={filePath}"

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

    Private Async Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        ' Create an OpenFileDialog to select the CSV file
        Dim openFileDialog As New OpenFileDialog()

        ' Set the dialog properties
        openFileDialog.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog.Title = "Open CSV File"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim filePath As String = openFileDialog.FileName

            systemAddLog(String.Format("{0}: imported csv for training", CURRENT_USER), filePath, "")

            ' Create and show the loading form
            Dim frmL As New frmLoading
            frmL.str = "Training ..."
            frmL.Show()

            ' Disable the main form while the loading form is displayed
            Me.Enabled = False

            ' Call the async function to upload the selected CSV file
            Dim response As String = Await GetTrainingStatusAsync(filePath)
            frmL.Hide()
            Me.Enabled = True
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
                    updateDate()

                End If
            End If



        Else
            MessageBox.Show("No file selected.", "Operation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub updateDate()
        Dim dt = dbFind(SELECT_TOP_DATE_QUERY, New Dictionary(Of String, Object))
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                lblDate.Text = row("date").ToString().Trim()
            Next
        End If
    End Sub

    Private Sub frmUpdate_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If CURRENTY_USER_TYPE = "Admin" Then
            btnUpload.Visible = True
            pbInfo.Visible = True
        End If
        updateDate()
    End Sub

    Private Sub btnManual_Click(sender As Object, e As EventArgs) Handles btnManual.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerManualTrain()
        End If
    End Sub
End Class