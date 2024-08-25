Public Class frmInfo
    Public isForTrain As Boolean
    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim saveFileDialog As New SaveFileDialog()

        ' Set the initial directory and file name (optional)
        saveFileDialog.InitialDirectory = Application.StartupPath & "\Data"
        If isForTrain Then
            saveFileDialog.FileName = "train.csv"
        Else
            saveFileDialog.FileName = "input.csv"
        End If

        saveFileDialog.Filter = "All Files (*.*)|*.*" ' Set filter as per your file type (e.g., "Text Files (*.txt)|*.txt")

        ' Show the SaveFileDialog and check if the user clicked 'Save'
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Get the file path from the SaveFileDialog
                Dim filePath As String = saveFileDialog.FileName

                ' Define the source file path (in the Data directory)
                Dim sourceFilePath As String = ""
                If isForTrain Then
                    sourceFilePath = Application.StartupPath & "\Data\train.csv"
                Else
                    sourceFilePath = Application.StartupPath & "\Data\input.csv"
                End If


                ' Copy the file from source to destination
                System.IO.File.Copy(sourceFilePath, filePath, True) ' Overwrite if the file already exists

                MessageBox.Show("File downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
            Catch ex As Exception
                MessageBox.Show("An error occurred while downloading the file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub frmInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class