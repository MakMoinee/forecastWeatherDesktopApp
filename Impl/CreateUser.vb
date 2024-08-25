Public Class CreateUser
    Implements RequestListener

    Private previousFrame As frmRegister

    Public Sub New(ul As frmRegister)
        previousFrame = ul
    End Sub

    Public Sub OnSuccess(Of T)(any As T) Implements RequestListener.OnSuccess
        MsgBox("Successfully Created Account", MsgBoxStyle.Information, "Success")
        previousFrame.DialogResult = DialogResult.OK
    End Sub

    Public Sub OnError(e As Exception) Implements RequestListener.OnError
        MsgBox("Failed To Create Account, Please Try Again Later", MsgBoxStyle.Critical, "Failure")
    End Sub
End Class
