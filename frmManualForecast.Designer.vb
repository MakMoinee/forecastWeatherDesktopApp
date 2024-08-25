<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualForecast
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManualForecast))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pbClose = New PictureBox()
        dgData = New DataGridView()
        btnClear = New Button()
        btnUpload = New Button()
        Label1 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewComboBoxColumn()
        Column4 = New DataGridViewComboBoxColumn()
        Column5 = New DataGridViewComboBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        CType(pbClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgData, ComponentModel.ISupportInitialize).BeginInit()
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
        pbClose.TabIndex = 4
        pbClose.TabStop = False
        ' 
        ' dgData
        ' 
        dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgData.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column4, Column5, Column6, Column7, Column8, Column9})
        dgData.Location = New Point(4, 89)
        dgData.Name = "dgData"
        dgData.RowHeadersVisible = False
        dgData.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgData.Size = New Size(738, 264)
        dgData.TabIndex = 5
        ' 
        ' btnClear
        ' 
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(12, 369)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(108, 43)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Location = New Point(168, 369)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(108, 43)
        btnUpload.TabIndex = 7
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(4, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 50)
        Label1.TabIndex = 8
        Label1.Text = "Please Input Your Data Below:"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date (MM/DD/YYYY)"
        Column1.Name = "Column1"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Day"
        Column3.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Column3.Name = "Column3"
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Weekday or Weekend"
        Column4.Items.AddRange(New Object() {"Weekday", "Weekend"})
        Column4.Name = "Column4"
        Column4.Resizable = DataGridViewTriState.True
        Column4.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Type Of Day"
        Column5.Items.AddRange(New Object() {"Regular Holiday", "Normal Day", "Special Non-working Holiday"})
        Column5.Name = "Column5"
        Column5.Resizable = DataGridViewTriState.True
        Column5.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Mean Temperature"
        Column6.Name = "Column6"
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Rainfall"
        Column7.Name = "Column7"
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Relative Humidity"
        Column8.Name = "Column8"
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Windspeed"
        Column9.Name = "Column9"
        ' 
        ' frmManualForecast
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(770, 463)
        Controls.Add(Label1)
        Controls.Add(btnUpload)
        Controls.Add(btnClear)
        Controls.Add(dgData)
        Controls.Add(pbClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmManualForecast"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManualForecast"
        CType(pbClose, ComponentModel.ISupportInitialize).EndInit()
        CType(dgData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbClose As PictureBox
    Friend WithEvents dgData As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewComboBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
