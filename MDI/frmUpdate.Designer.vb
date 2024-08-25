<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        pbClose = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblDate = New Label()
        btnManual = New Button()
        pbInfo = New PictureBox()
        btnUpload = New Button()
        CType(pbClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbClose
        ' 
        pbClose.Cursor = Cursors.Hand
        pbClose.Image = CType(resources.GetObject("pbClose.Image"), Image)
        pbClose.Location = New Point(702, 12)
        pbClose.Name = "pbClose"
        pbClose.Size = New Size(29, 34)
        pbClose.SizeMode = PictureBoxSizeMode.Zoom
        pbClose.TabIndex = 5
        pbClose.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(92, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(488, 50)
        Label1.TabIndex = 7
        Label1.Text = "Energy Demand Forecaster"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(118, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(256, 37)
        Label2.TabIndex = 8
        Label2.Text = "model updated to:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.ForeColor = Color.Red
        lblDate.Location = New Point(380, 59)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(197, 37)
        lblDate.TabIndex = 9
        lblDate.Text = "DD/MM/YYYY"
        ' 
        ' btnManual
        ' 
        btnManual.Cursor = Cursors.Hand
        btnManual.FlatStyle = FlatStyle.Popup
        btnManual.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnManual.Location = New Point(200, 147)
        btnManual.Name = "btnManual"
        btnManual.Size = New Size(338, 71)
        btnManual.TabIndex = 10
        btnManual.Text = "Input Data Manually"
        btnManual.UseVisualStyleBackColor = True
        ' 
        ' pbInfo
        ' 
        pbInfo.Cursor = Cursors.Hand
        pbInfo.Image = CType(resources.GetObject("pbInfo.Image"), Image)
        pbInfo.Location = New Point(491, 252)
        pbInfo.Name = "pbInfo"
        pbInfo.Size = New Size(36, 34)
        pbInfo.SizeMode = PictureBoxSizeMode.Zoom
        pbInfo.TabIndex = 12
        pbInfo.TabStop = False
        pbInfo.Visible = False
        ' 
        ' btnUpload
        ' 
        btnUpload.Cursor = Cursors.Hand
        btnUpload.FlatStyle = FlatStyle.Popup
        btnUpload.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUpload.Location = New Point(200, 246)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(338, 71)
        btnUpload.TabIndex = 13
        btnUpload.Text = "Upload CSV File"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' frmUpdate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(770, 463)
        Controls.Add(pbInfo)
        Controls.Add(btnUpload)
        Controls.Add(btnManual)
        Controls.Add(lblDate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pbClose)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmUpdate"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmUpdate"
        CType(pbClose, ComponentModel.ISupportInitialize).EndInit()
        CType(pbInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnManual As Button
    Friend WithEvents pbInfo As PictureBox
    Friend WithEvents btnUpload As Button
End Class
