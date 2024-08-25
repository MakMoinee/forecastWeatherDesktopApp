<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Panel1 = New Panel()
        btnRegister = New Button()
        btnLogin = New Button()
        txtPw = New TextBox()
        Label3 = New Label()
        txtUn = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnRegister)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(txtPw)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtUn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(361, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(294, 392)
        Panel1.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.DarkTurquoise
        btnRegister.Cursor = Cursors.Hand
        btnRegister.FlatStyle = FlatStyle.Popup
        btnRegister.ForeColor = Color.Black
        btnRegister.Location = New Point(145, 276)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(122, 41)
        btnRegister.TabIndex = 6
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Lavender
        btnLogin.Cursor = Cursors.Hand
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Location = New Point(21, 276)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(118, 41)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPw
        ' 
        txtPw.Font = New Font("Segoe UI", 14.25F)
        txtPw.Location = New Point(21, 225)
        txtPw.Name = "txtPw"
        txtPw.PasswordChar = "*"c
        txtPw.Size = New Size(246, 33)
        txtPw.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.Location = New Point(15, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 25)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' txtUn
        ' 
        txtUn.Font = New Font("Segoe UI", 14.25F)
        txtUn.Location = New Point(21, 159)
        txtUn.Name = "txtUn"
        txtUn.Size = New Size(246, 33)
        txtUn.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.Location = New Point(15, 131)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 25)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 64)
        Label1.TabIndex = 0
        Label1.Text = "Energy Demand " & vbCrLf & "Forecaster"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(40, 85)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(251, 232)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(655, 392)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPw As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRegister As Button
End Class
