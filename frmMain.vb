Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports iTextSharp.text

Public Class frmMain
    Private filePath As String
    Dim frmH As New frmHome
    Dim frmF As New frmForecast
    Dim frmM As New frmManualForecast
    Dim frmU As New frmUpdate
    Dim frmR As New frmForecastResult
    Dim frmHis As New frmHistory
    Dim frmMT As New frmManualTrain


    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        triggerHome()

    End Sub

    Public Sub triggerHome()
        frmF.Hide()
        frmM.Hide()
        frmU.Hide()
        frmR.Hide()
        frmMT.Hide()
        frmHis.Hide()
        frmH.MdiParent = Me
        frmH.Dock = DockStyle.Fill
        frmH.StartPosition = FormStartPosition.Manual
        frmH.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmH.Show()
    End Sub

    Public Sub triggerUpdate()
        frmF.Hide()
        frmM.Hide()
        frmH.Hide()
        frmR.Hide()
        frmMT.Hide()
        frmHis.Hide()
        frmU.MdiParent = Me
        frmU.Dock = DockStyle.Fill
        frmU.StartPosition = FormStartPosition.Manual
        frmU.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmU.Show()
    End Sub

    Public Sub triggerResult(list As List(Of DemandData))
        frmF.Hide()
        frmM.Hide()
        frmH.Hide()
        frmMT.Hide()
        frmU.Hide()
        frmHis.Hide()
        frmR.MdiParent = Me
        If frmR.dgPredictions.Rows.Count > 0 Then
            frmR.dgPredictions.Rows.Clear()
        End If
        If frmR.dataList.Count > 0 Then
            frmR.dataList.Clear()
        End If
        frmR.dataList = list
        frmR.Dock = DockStyle.Fill
        frmR.StartPosition = FormStartPosition.Manual
        frmR.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmR.Show()
    End Sub

    Public Sub triggerHistory()
        frmF.Hide()
        frmM.Hide()
        frmH.Hide()
        frmMT.Hide()
        frmU.Hide()
        frmR.Hide()
        frmHis.MdiParent = Me
        frmHis.Dock = DockStyle.Fill
        frmHis.StartPosition = FormStartPosition.Manual
        frmHis.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmHis.Show()
    End Sub
    Public Sub triggerManualForecast()
        frmF.Hide()
        frmM.Hide()
        frmH.Hide()
        frmU.Hide()
        frmR.Hide()
        frmHis.Hide()
        frmM.MdiParent = Me
        frmM.Dock = DockStyle.Fill
        frmM.StartPosition = FormStartPosition.Manual
        frmM.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmM.Show()
    End Sub

    Public Sub triggerManualTrain()
        frmF.Hide()
        frmM.Hide()
        frmH.Hide()
        frmU.Hide()
        frmR.Hide()
        frmHis.Hide()
        frmMT.MdiParent = Me
        frmMT.Dock = DockStyle.Fill
        frmMT.StartPosition = FormStartPosition.Manual
        frmMT.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmMT.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmF.Hide()
        frmM.Hide()
        frmH.Hide()
        frmU.Hide()
        frmR.Hide()
        frmHis.Hide()
        frmF.MdiParent = Me
        frmF.Dock = DockStyle.Fill
        frmF.StartPosition = FormStartPosition.Manual
        frmF.Location = New Point((Me.ClientSize.Width - frmH.Width) \ 2, (Me.ClientSize.Height - frmH.Height) \ 2)
        frmF.FormBorderStyle = FormBorderStyle.None
        frmF.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        triggerUpdate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        triggerHistory()
    End Sub
End Class
