Imports System.Text.Json.Nodes

Public Class frmResults
    Private DataResult As JsonNode
    Private Sub frmResults_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If responseContent = "" Then
            MsgBox("Empty Result")
            Me.DialogResult = DialogResult.Cancel
        Else
            DataResult = JsonObject.Parse(responseContent)
            MsgBox(responseContent)
        End If
    End Sub
End Class