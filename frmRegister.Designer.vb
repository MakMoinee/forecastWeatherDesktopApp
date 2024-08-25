<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Label1 = New Label()
        Label2 = New Label()
        txtFirstName = New TextBox()
        txtMiddleName = New TextBox()
        Label3 = New Label()
        txtLastName = New TextBox()
        Label4 = New Label()
        txtUsername = New TextBox()
        Label5 = New Label()
        txtPassword = New TextBox()
        Label6 = New Label()
        txtConfirmPassword = New TextBox()
        Label7 = New Label()
        btnCreateAccount = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 25)
        Label1.TabIndex = 0
        Label1.Text = "Register An Account"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.Location = New Point(7, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 1
        Label2.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 14.25F)
        txtFirstName.Location = New Point(12, 122)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(212, 33)
        txtFirstName.TabIndex = 2
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Segoe UI", 14.25F)
        txtMiddleName.Location = New Point(273, 122)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(212, 33)
        txtMiddleName.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.Location = New Point(268, 94)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 25)
        Label3.TabIndex = 3
        Label3.Text = "Middle Name:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 14.25F)
        txtLastName.Location = New Point(520, 122)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(212, 33)
        txtLastName.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F)
        Label4.Location = New Point(515, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 25)
        Label4.TabIndex = 5
        Label4.Text = "Last Name:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 14.25F)
        txtUsername.Location = New Point(12, 202)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(212, 33)
        txtUsername.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F)
        Label5.Location = New Point(7, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 25)
        Label5.TabIndex = 7
        Label5.Text = "Username:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 14.25F)
        txtPassword.Location = New Point(273, 202)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(212, 33)
        txtPassword.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F)
        Label6.Location = New Point(268, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 25)
        Label6.TabIndex = 9
        Label6.Text = "Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 14.25F)
        txtConfirmPassword.Location = New Point(520, 202)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(212, 33)
        txtConfirmPassword.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F)
        Label7.Location = New Point(515, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 25)
        Label7.TabIndex = 11
        Label7.Text = "Confirm Password:"
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnCreateAccount.FlatStyle = FlatStyle.Popup
        btnCreateAccount.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCreateAccount.Location = New Point(275, 277)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(210, 51)
        btnCreateAccount.TabIndex = 13
        btnCreateAccount.Text = "Create Account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' frmRegister
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(750, 354)
        Controls.Add(btnCreateAccount)
        Controls.Add(txtConfirmPassword)
        Controls.Add(Label7)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(txtUsername)
        Controls.Add(Label5)
        Controls.Add(txtLastName)
        Controls.Add(Label4)
        Controls.Add(txtMiddleName)
        Controls.Add(Label3)
        Controls.Add(txtFirstName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register Account"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCreateAccount As Button
End Class
