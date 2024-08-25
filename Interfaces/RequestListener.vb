Imports Mysqlx

Public Interface RequestListener
    Sub OnSuccess(Of T)(any As T)
    Sub OnError(e As Exception)
End Interface
