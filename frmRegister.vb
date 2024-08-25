Public Class frmRegister

    Private service As New UserService
    Private Sub frmRegister_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = DialogResult.Abort
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        If txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Or txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Or txtConfirmPassword.Text.Trim() = "" Then
            MsgBox("Please Don't Leave Empty Fields", MsgBoxStyle.Critical, "Invalid Input")
        Else

            If txtPassword.Text.Trim().Equals(txtConfirmPassword.Text.Trim()) Then
                Dim u As New Users()
                u.setFirstName(txtFirstName.Text.Trim())
                u.setMiddleName(txtMiddleName.Text.Trim())
                u.setLastName(txtLastName.Text.Trim())
                u.setUsername(txtUsername.Text.Trim())
                u.setPassword(New HashService().HashPassword(txtPassword.Text.Trim()))
                u.setUserType("User")
                service.createAccount(u, New CreateUser(Me))
            Else
                MsgBox("Password Doesn't Match", MsgBoxStyle.Critical, "Invalid Input")
            End If




        End If
    End Sub
End Class