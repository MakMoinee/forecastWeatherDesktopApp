<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForecast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForecast))
        Label1 = New Label()
        btnManual = New Button()
        btnAuto = New Button()
        pbClose = New PictureBox()
        pbInfo = New PictureBox()
        CType(pbClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(89, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(488, 50)
        Label1.TabIndex = 0
        Label1.Text = "Energy Demand Forecaster"
        ' 
        ' btnManual
        ' 
        btnManual.Cursor = Cursors.Hand
        btnManual.FlatStyle = FlatStyle.Popup
        btnManual.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnManual.Location = New Point(175, 170)
        btnManual.Name = "btnManual"
        btnManual.Size = New Size(305, 71)
        btnManual.TabIndex = 1
        btnManual.Text = "Input Data Manually"
        btnManual.UseVisualStyleBackColor = True
        ' 
        ' btnAuto
        ' 
        btnAuto.Cursor = Cursors.Hand
        btnAuto.FlatStyle = FlatStyle.Popup
        btnAuto.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAuto.Location = New Point(175, 267)
        btnAuto.Name = "btnAuto"
        btnAuto.Size = New Size(305, 71)
        btnAuto.TabIndex = 2
        btnAuto.Text = "Upload CSV File"
        btnAuto.UseVisualStyleBackColor = True
        ' 
        ' pbClose
        ' 
        pbClose.Cursor = Cursors.Hand
        pbClose.Image = CType(resources.GetObject("pbClose.Image"), Image)
        pbClose.Location = New Point(702, 12)
        pbClose.Name = "pbClose"
        pbClose.Size = New Size(29, 34)
        pbClose.SizeMode = PictureBoxSizeMode.Zoom
        pbClose.TabIndex = 3
        pbClose.TabStop = False
        ' 
        ' pbInfo
        ' 
        pbInfo.Cursor = Cursors.Hand
        pbInfo.Image = CType(resources.GetObject("pbInfo.Image"), Image)
        pbInfo.Location = New Point(442, 271)
        pbInfo.Name = "pbInfo"
        pbInfo.Size = New Size(33, 31)
        pbInfo.SizeMode = PictureBoxSizeMode.Zoom
        pbInfo.TabIndex = 13
        pbInfo.TabStop = False
        ' 
        ' frmForecast
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(770, 463)
        Controls.Add(pbInfo)
        Controls.Add(pbClose)
        Controls.Add(btnAuto)
        Controls.Add(btnManual)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmForecast"
        Text = "frmForecast"
        CType(pbClose, ComponentModel.ISupportInitialize).EndInit()
        CType(pbInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnManual As Button
    Friend WithEvents btnAuto As Button
    Friend WithEvents pbClose As PictureBox
    Friend WithEvents pbInfo As PictureBox
End Class
