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
        If dataList.Count > 0 Then
            myChart.Series.Clear()
            myChart.ChartAreas.Clear()

            ' Add a new ChartArea
            Dim chartArea As New ChartArea("MainArea")
            myChart.ChartAreas.Add(chartArea)

            ' Configure X-axis
            With chartArea.AxisX
                .LabelStyle.Format = "yyyy-MM-dd"
                .IntervalAutoMode = IntervalAutoMode.VariableCount ' Adjust intervals dynamically
                .IsLabelAutoFit = True
                .LabelStyle.Angle = -45 ' Rotate labels for better readability
                .MajorGrid.LineColor = Color.LightGray ' Customize gridlines
                .ScaleView.Zoomable = True ' Allow zooming
            End With

            ' Enable scrolling and panning
            With chartArea
                .CursorX.IsUserEnabled = True
                .CursorX.IsUserSelectionEnabled = True
                .AxisX.ScrollBar.Enabled = True
                .AxisX.ScrollBar.Size = 10
                .AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll
            End With

            ' Configure Y-axis
            With chartArea.AxisY
                .Title = "Demand Load"
                .MajorGrid.LineColor = Color.LightGray
            End With

            ' Create a new series
            Dim series As New Series("Demand Load")
            series.ChartType = SeriesChartType.Line
            series.XValueType = ChartValueType.DateTime
            series.MarkerStyle = MarkerStyle.Circle ' Add markers to the points
            series.MarkerSize = 8 ' Adjust the size of the markers
            series.IsValueShownAsLabel = True ' Enable labels for points
            series.LabelForeColor = Color.Black ' Set label color

            ' Populate the series with data
            For Each data As DemandData In dataList
                Dim dateValue As DateTime
                If DateTime.TryParse(data.Date, dateValue) Then
                    Dim pointIndex As Integer = series.Points.AddXY(dateValue, data.Demand_Load)
                    ' Set the label for the point
                    series.Points(pointIndex).Label = data.Demand_Load.ToString()
                End If
            Next

            ' Add the series to the chart
            myChart.Series.Add(series)
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
End Class