<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForecastResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForecastResult))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        pbClose = New PictureBox()
        Label1 = New Label()
        dgPredictions = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        btnCsv = New Button()
        myChart = New DataVisualization.Charting.Chart()
        btnExport = New Button()
        CType(pbClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgPredictions, ComponentModel.ISupportInitialize).BeginInit()
        CType(myChart, ComponentModel.ISupportInitialize).BeginInit()
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
        Label1.Location = New Point(85, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(488, 50)
        Label1.TabIndex = 6
        Label1.Text = "Energy Demand Forecaster"
        ' 
        ' dgPredictions
        ' 
        dgPredictions.AllowUserToAddRows = False
        dgPredictions.AllowUserToDeleteRows = False
        dgPredictions.AllowUserToResizeColumns = False
        dgPredictions.AllowUserToResizeRows = False
        dgPredictions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgPredictions.BackgroundColor = Color.White
        dgPredictions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPredictions.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        dgPredictions.EditMode = DataGridViewEditMode.EditProgrammatically
        dgPredictions.Location = New Point(17, 77)
        dgPredictions.Name = "dgPredictions"
        dgPredictions.RowHeadersVisible = False
        dgPredictions.Size = New Size(196, 311)
        dgPredictions.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Load (MW)"
        Column2.Name = "Column2"
        ' 
        ' btnCsv
        ' 
        btnCsv.Cursor = Cursors.Hand
        btnCsv.FlatStyle = FlatStyle.Popup
        btnCsv.Location = New Point(17, 405)
        btnCsv.Name = "btnCsv"
        btnCsv.Size = New Size(196, 46)
        btnCsv.TabIndex = 8
        btnCsv.Text = "Export To CSV"
        btnCsv.UseVisualStyleBackColor = True
        ' 
        ' myChart
        ' 
        ChartArea1.Name = "ChartArea1"
        myChart.ChartAreas.Add(ChartArea1)
        myChart.Location = New Point(233, 77)
        myChart.Name = "myChart"
        myChart.RightToLeft = RightToLeft.Yes
        myChart.Size = New Size(481, 311)
        myChart.TabIndex = 9
        myChart.Text = "Chart1"
        ' 
        ' btnExport
        ' 
        btnExport.Cursor = Cursors.Hand
        btnExport.FlatStyle = FlatStyle.Popup
        btnExport.Location = New Point(279, 405)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(452, 46)
        btnExport.TabIndex = 10
        btnExport.Text = "Export Chart To PDF"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' frmForecastResult
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(770, 463)
        Controls.Add(btnExport)
        Controls.Add(myChart)
        Controls.Add(btnCsv)
        Controls.Add(dgPredictions)
        Controls.Add(Label1)
        Controls.Add(pbClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmForecastResult"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmForecastResult"
        CType(pbClose, ComponentModel.ISupportInitialize).EndInit()
        CType(dgPredictions, ComponentModel.ISupportInitialize).EndInit()
        CType(myChart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgPredictions As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnCsv As Button
    Friend WithEvents myChart As DataVisualization.Charting.Chart
    Friend WithEvents btnExport As Button
End Class
