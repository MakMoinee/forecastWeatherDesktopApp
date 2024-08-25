<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualTrain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManualTrain))
        pbClose = New PictureBox()
        Label1 = New Label()
        dgData = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewComboBoxColumn()
        Column3 = New DataGridViewComboBoxColumn()
        Column5 = New DataGridViewComboBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        btnClear = New Button()
        btnUpload = New Button()
        dgSample = New DataGridView()
        Column4 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column20 = New DataGridViewTextBoxColumn()
        CType(pbClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgData, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgSample, ComponentModel.ISupportInitialize).BeginInit()
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
        pbClose.TabIndex = 6
        pbClose.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 50)
        Label1.TabIndex = 8
        Label1.Text = "Please Input Your Data Below:"
        ' 
        ' dgData
        ' 
        dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgData.BackgroundColor = Color.White
        dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgData.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5, Column6, Column7, Column8, Column9, Column10})
        dgData.Location = New Point(12, 95)
        dgData.Name = "dgData"
        dgData.RowHeadersVisible = False
        dgData.Size = New Size(729, 308)
        dgData.TabIndex = 9
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date (MM/DD/YYYY)"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Day"
        Column2.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Column2.Name = "Column2"
        Column2.Resizable = DataGridViewTriState.True
        Column2.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Weekday or Weekend"
        Column3.Items.AddRange(New Object() {"Weekday", "Weekend"})
        Column3.Name = "Column3"
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Type of Day"
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
        ' Column10
        ' 
        Column10.HeaderText = "Demand Load"
        Column10.Name = "Column10"
        ' 
        ' btnClear
        ' 
        btnClear.Cursor = Cursors.Hand
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Location = New Point(12, 409)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(109, 43)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnUpload
        ' 
        btnUpload.Cursor = Cursors.Hand
        btnUpload.FlatStyle = FlatStyle.Flat
        btnUpload.Location = New Point(164, 409)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(109, 43)
        btnUpload.TabIndex = 11
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = True
        ' 
        ' dgSample
        ' 
        dgSample.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSample.Columns.AddRange(New DataGridViewColumn() {Column4, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20})
        dgSample.Location = New Point(233, 208)
        dgSample.Name = "dgSample"
        dgSample.Size = New Size(240, 150)
        dgSample.TabIndex = 12
        dgSample.Visible = False
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Date Logs"
        Column4.Name = "Column4"
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Date"
        Column11.Name = "Column11"
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Month"
        Column12.Name = "Column12"
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Day"
        Column13.Name = "Column13"
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Weekday or Weekend"
        Column14.Name = "Column14"
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Type of Day"
        Column15.Name = "Column15"
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Mean Temperature (Degree Celsius)"
        Column16.Name = "Column16"
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "Rainfall(mm)"
        Column17.Name = "Column17"
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "Relative Humidity (%)"
        Column18.Name = "Column18"
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "Windspeed (m/s)"
        Column19.Name = "Column19"
        ' 
        ' Column20
        ' 
        Column20.HeaderText = "DemandLoad"
        Column20.Name = "Column20"
        ' 
        ' frmManualTrain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(770, 463)
        Controls.Add(btnUpload)
        Controls.Add(btnClear)
        Controls.Add(dgData)
        Controls.Add(Label1)
        Controls.Add(pbClose)
        Controls.Add(dgSample)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmManualTrain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmManualTrain"
        CType(pbClose, ComponentModel.ISupportInitialize).EndInit()
        CType(dgData, ComponentModel.ISupportInitialize).EndInit()
        CType(dgSample, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgData As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewComboBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents btnClear As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents dgSample As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
End Class
