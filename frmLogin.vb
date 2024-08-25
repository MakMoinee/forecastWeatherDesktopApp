Public Class frmLogin

    Private service As New UserService
    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUn.Text.Trim() = "" Or txtPw.Text.Trim() = "" Then
            MsgBox("Please Don't Leave Empty Fields", MsgBoxStyle.Critical, "Invalid Input")
        Else
            Dim u As New Users
            u.setUsername(txtUn.Text.Trim())
            u.setPassword(txtPw.Text.Trim())
            service.login(u, New UserLogin(Me))

        End If
    End Sub

    Public Sub clearFields()
        txtUn.Clear()
        txtPw.Clear()

    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Dim frmR As New frmRegister
        If frmR.ShowDialog = DialogResult.OK Then
            frmR.Hide()
            Me.Show()
        Else
            frmR.Hide()
            Me.Show()
        End If
    End Sub
End Class