Public Class WeatherService
    Public Sub New()
    End Sub

    Public Function getWeatherData() As List(Of WeatherData)
        Dim list As New List(Of WeatherData)()
        Dim dt = dbFind(SELECT_WEATHER_DATA_QUERY, New Dictionary(Of String, Object))
        If dt.Rows.Count > 0 Then
            For Each row As DataRow In dt.Rows
                Dim w As New WeatherData With {
                    .weatherID = Integer.Parse(row("weatherID").ToString().Trim()),
                    .dateLogs = row("dateLogs").ToString.Trim(),
                    .date = Integer.Parse(row("date").ToString.Trim()),
                    .day = row("day").ToString.Trim(),
                    .weekdayOrWeekend = row("weekdayOrWeekend").ToString.Trim(),
                    .typeOfDay = row("typeOfDay").ToString.Trim(),
                    .meanTemperature = Double.Parse(row("meanTemperature").ToString.Trim()),
                    .rainFall = Double.Parse(row("rainfall").ToString.Trim()),
                    .relativeHumidity = Double.Parse(row("relativeHumidity").ToString.Trim()),
                    .windspeed = Double.Parse(row("windspeed").ToString.Trim()),
                    .demandLoad = Decimal.Parse(row("demandLoad").ToString.Trim())
                }
                list.Add(w)
            Next
        End If
        Return list
    End Function
End Class
