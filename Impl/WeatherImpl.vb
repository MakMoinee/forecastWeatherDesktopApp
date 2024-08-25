Public Class WeatherImpl
    Implements RequestListener

    Public Sub OnSuccess(Of T)(any As T) Implements RequestListener.OnSuccess
        Throw New NotImplementedException()
    End Sub

    Public Sub OnError(e As Exception) Implements RequestListener.OnError
        Throw New NotImplementedException()
    End Sub
End Class
