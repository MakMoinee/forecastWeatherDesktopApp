Public Class UserLogin
    Implements RequestListener

    Private previosFrame As frmLogin
    Public Sub New(frmLogin As frmLogin)
        previosFrame = frmLogin
    End Sub

    Public Sub OnSuccess(Of T)(any As T) Implements RequestListener.OnSuccess
        MsgBox("Login Successfully", MsgBoxStyle.Information, "Success")
        previosFrame.Hide()
        Dim frmM As New frmMain
        If frmM.ShowDialog = DialogResult.OK Then
            frmM.Hide()
            previosFrame.clearFields()
            previosFrame.Show()
        Else
            frmM.Hide()
            previosFrame.clearFields()
            previosFrame.Show()
        End If
    End Sub

    Public Sub OnError(e As Exception) Implements RequestListener.OnError
        MsgBox("Wrong Username or Password", MsgBoxStyle.Critical, "Invalid Input")
    End Sub
End Class
