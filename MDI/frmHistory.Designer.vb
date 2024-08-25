<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        pbClose = New PictureBox()
        dgData = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewLinkColumn()
        Column3 = New DataGridViewLinkColumn()
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
        pbClose.TabIndex = 6
        pbClose.TabStop = False
        ' 
        ' dgData
        ' 
        dgData.AllowUserToAddRows = False
        dgData.AllowUserToDeleteRows = False
        dgData.AllowUserToResizeColumns = False
        dgData.AllowUserToResizeRows = False
        dgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgData.BackgroundColor = Color.White
        dgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgData.Columns.AddRange(New DataGridViewColumn() {Column1, Column4, Column2, Column3})
        dgData.EditMode = DataGridViewEditMode.EditProgrammatically
        dgData.Location = New Point(12, 62)
        dgData.Name = "dgData"
        dgData.ReadOnly = True
        dgData.RowHeadersVisible = False
        dgData.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgData.Size = New Size(707, 373)
        dgData.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Date"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Description"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.HeaderText = "Input"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.True
        Column2.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Output"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Resizable = DataGridViewTriState.True
        Column3.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' frmHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(770, 463)
        Controls.Add(dgData)
        Controls.Add(pbClose)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmHistory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmHistory"
        CType(pbClose, ComponentModel.ISupportInitialize).EndInit()
        CType(dgData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbClose As PictureBox
    Friend WithEvents dgData As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewLinkColumn
    Friend WithEvents Column3 As DataGridViewLinkColumn
End Class
