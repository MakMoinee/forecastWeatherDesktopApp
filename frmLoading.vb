Public Class frmLoading
    Public str As String = "Forecasting ..."
    Private Sub frmLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Label1.Text = str
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 10
        Else
            ProgressBar1.Value = 0
            ProgressBar1.Value = 10
        End If
    End Sub
End Class