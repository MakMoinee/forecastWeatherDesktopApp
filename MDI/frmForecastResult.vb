Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmForecastResult
    Public dataList As New List(Of DemandData)()
    Private Sub frmForecastResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dataList.Count > 0 Then
            For Each demandData In dataList
                dgPredictions.Rows.Add(demandData.Date, demandData.Demand_Load)
            Next
            dgPredictions.ClearSelection()
        End If
        generateChart()
    End Sub

    Private Sub generateChart()
        ' Ensure dataList has data
        If dataList.Count > 0 Then
            ' Setup chart area
            With myChart.ChartAreas(0)
                .AxisX.Title = "Date"
                .AxisX.MajorGrid.LineColor = Color.LightBlue
                .AxisX.LabelStyle.Format = "yyyy-MM-dd" ' Format as date
                .AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount ' Adjust intervals
                .AxisX.IsLabelAutoFit = True
                .AxisX.LabelStyle.Angle = -45 ' Rotate labels for better readability
                .AxisY.Title = "Energy Demand Forecast"
                .AxisY.MajorGrid.LineColor = Color.LightGray
                .AxisY.Minimum = 0
                .BackColor = Color.FloralWhite
                .BackSecondaryColor = Color.White
                .BackGradientStyle = GradientStyle.HorizontalCenter
                .BorderColor = Color.Blue
                .BorderDashStyle = ChartDashStyle.Solid
                .BorderWidth = 1
                .ShadowOffset = 2
            End With

            ' Clear existing series and add new one
            myChart.Series.Clear()
            myChart.Series.Add("Energy Demand")
            With myChart.Series("Energy Demand")
                .ChartType = DataVisualization.Charting.SeriesChartType.Line
                .BorderWidth = 1
                .Color = Color.Red
                .BorderDashStyle = ChartDashStyle.Dash
                .MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                .MarkerSize = 8
                .SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.None
                .SmartLabelStyle.Enabled = False
                .IsValueShownAsLabel = False ' Show value as a label
                .LabelForeColor = Color.Black ' Customize label color

                ' Add points to the series
                For Each data As DemandData In dataList
                    Dim dateValue As DateTime
                    If DateTime.TryParse(data.Date, dateValue) Then
                        Dim pointIndex As Integer = .Points.AddXY(dateValue, data.Demand_Load)
                        ' Set the label for the point
                        '.Points(pointIndex).Label = data.Demand_Load.ToString()
                    End If
                Next
            End With
        End If
    End Sub


    Private Async Sub btnCsv_Click(sender As Object, e As EventArgs) Handles btnCsv.Click
        If dataList.Count > 0 Then
            exportDataGridViewToCSV()
        End If
    End Sub
    Private Sub exportDataGridViewToCSV()
        Try
            ' Get the path to the bin\Data directory
            Dim downloadsDirectory As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")

            ' Create the Data directory if it doesn't exist
            If Not Directory.Exists(downloadsDirectory) Then
                Directory.CreateDirectory(downloadsDirectory)
            End If

            ' Generate a timestamp-based file name
            Dim timestamp As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
            Dim fileName As String = "predictions_" & timestamp & ".csv"
            Dim filePath As String = Path.Combine(downloadsDirectory, fileName)

            Dim sb As New StringBuilder()

            ' Add the header row
            Dim headerColumns As New List(Of String)()
            For Each column As DataGridViewColumn In dgPredictions.Columns
                headerColumns.Add(column.HeaderText)
            Next
            sb.AppendLine(String.Join(",", headerColumns))

            ' Add the data rows
            For Each row As DataGridViewRow In dgPredictions.Rows
                If Not row.IsNewRow Then
                    Dim cells As New List(Of String)()
                    For Each cell As DataGridViewCell In row.Cells
                        cells.Add(cell.Value?.ToString())
                    Next
                    sb.AppendLine(String.Join(",", cells))
                End If
            Next

            ' Write the content to the CSV file
            File.WriteAllText(filePath, sb.ToString())

            systemAddLog(String.Format("{0}: exported forecast results to csv", CURRENT_USER), "", filePath)

            MessageBox.Show("Data exported successfully to " & filePath, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        If Me.MdiParent IsNot Nothing AndAlso TypeOf Me.MdiParent Is frmMain Then
            Dim mdiParent As frmMain = CType(Me.MdiParent, frmMain)
            mdiParent.triggerHome()
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"
        saveFileDialog.Title = "Save Chart as PDF"
        saveFileDialog.FileName = "ChartExport.pdf"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName

            ' Save the chart as an image (e.g., PNG format)
            Dim chartImagePath As String = Path.Combine(Path.GetTempPath(), "chartImage.png")
            myChart.SaveImage(chartImagePath, DataVisualization.Charting.ChartImageFormat.Png)

            ' Create a new PDF document
            Dim pdfDoc As New iTextSharp.text.Document(PageSize.A4)
            Try
                ' Create a PdfWriter to write to the file
                Dim pdfWriter As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))

                ' Open the document to add content
                pdfDoc.Open()

                ' Add the chart image to the PDF document
                Dim chartImage As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(chartImagePath)
                chartImage.Alignment = Element.ALIGN_CENTER
                pdfDoc.Add(chartImage)

                ' Add a title and date (optional)
                pdfDoc.Add(New Paragraph("Energy Demand Forecast", FontFactory.GetFont(FontFactory.HELVETICA, 18)))
                pdfDoc.Add(New Paragraph("Date: " & DateTime.Now.ToString(), FontFactory.GetFont(FontFactory.HELVETICA, 12)))

            Finally
                ' Close the document
                pdfDoc.Close()
            End Try

            ' Delete the temporary image file
            If File.Exists(chartImagePath) Then
                File.Delete(chartImagePath)
            End If

            systemAddLog(String.Format("{0}: exported forecast chart", CURRENT_USER), "", filePath)

            ' Show a message when export is complete
            MessageBox.Show("Chart exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmForecastResult_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If dataList.Count > 0 Then
            dataList.Clear()
        End If
    End Sub

    Private Sub frmForecastResult_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If dgPredictions.Rows.Count > 0 Then
            dgPredictions.Rows.Clear()
        End If
        If dataList.Count > 0 Then
            For Each demandData In dataList
                dgPredictions.Rows.Add(demandData.Date, demandData.Demand_Load)
            Next
            dgPredictions.ClearSelection()
        End If
        generateChart()
    End Sub
End Class