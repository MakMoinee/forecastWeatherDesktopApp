Public Class HistoryImpl
    Implements RequestListener

    Public Sub New()
    End Sub

    Public Sub OnSuccess(Of T)(any As T) Implements RequestListener.OnSuccess

    End Sub

    Public Sub OnError(e As Exception) Implements RequestListener.OnError
        If e IsNot Nothing Then
            Console.WriteLine(e.Message.ToString())
        End If
    End Sub
End Class
