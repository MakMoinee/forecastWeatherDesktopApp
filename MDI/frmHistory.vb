Public Class frmHistory
    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerHome()
        End If
    End Sub

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loadData()
    End Sub

    Private Sub loadData()
        If dgData.Rows.Count > 0 Then
            dgData.Rows.Clear()
        End If

        Dim historyService As New HistoryService
        Dim dt = historyService.getLogsByUser()

        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                dgData.Rows.Add(row("date").ToString(), row("description").ToString(), row("input").ToString(), row("output").ToString())
            Next
            dgData.ClearSelection()
        Else
            MsgBox("here")
        End If
    End Sub

    Private Sub dgData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgData.CellContentClick
        If (e.ColumnIndex = 2 Or e.ColumnIndex = 3) AndAlso e.RowIndex >= 0 Then
            ' Get the file path from the clicked cell
            Dim relativeFilePath As String = dgData.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            ' Get the root directory of the project (two levels up from bin directory)
            Dim rootDirectory As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\")

            ' Combine the root directory with the relative file path to get the absolute file path
            Dim absoluteFilePath As String = System.IO.Path.Combine(rootDirectory, relativeFilePath)

            ' Check if the file exists before trying to open it
            If System.IO.File.Exists(absoluteFilePath) Then
                Try
                    ' Open the file using the default program associated with the file type
                    System.Diagnostics.Process.Start(New ProcessStartInfo(absoluteFilePath) With {.UseShellExecute = True})
                Catch ex As Exception
                    MessageBox.Show("Unable to open file: " & ex.Message)
                End Try
            Else
                MessageBox.Show("File not found: " & absoluteFilePath)
            End If
            dgData.ClearSelection()

        End If
    End Sub

    Private Sub frmHistory_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        loadData()
    End Sub
End Class