<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Label1 = New Label()
        btnDownload = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 50)
        Label1.TabIndex = 0
        Label1.Text = "Uploading A File Follows A Template." & vbCrLf & "Download Template Here:"
        ' 
        ' btnDownload
        ' 
        btnDownload.BackColor = Color.White
        btnDownload.FlatStyle = FlatStyle.Popup
        btnDownload.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDownload.Location = New Point(84, 134)
        btnDownload.Name = "btnDownload"
        btnDownload.Size = New Size(223, 58)
        btnDownload.TabIndex = 1
        btnDownload.Text = "Download"
        btnDownload.UseVisualStyleBackColor = False
        ' 
        ' frmInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(405, 234)
        Controls.Add(btnDownload)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmInfo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDownload As Button
End Class
