Public Class HistoryService
    Public Sub New()
    End Sub

    Public Sub addLog(history As History, listener As RequestListener)
        If history IsNot Nothing Then
            Dim parameters As New Dictionary(Of String, Object)()
            parameters.Add("@id", history.UserID)
            parameters.Add("@desc", history.Description)
            parameters.Add("@in", history.Input)
            parameters.Add("@out", history.Output)
            Dim isSaved = dbStore(CREATE_HISTORY_QUERY, parameters)
            If isSaved Then
                listener.OnSuccess("success")
            Else
                listener.OnError(New Exception("error adding history log"))
            End If
        Else
            listener.OnError(New Exception("history is empty"))
        End If
    End Sub

    Public Function getLogsByUser() As DataTable
        Dim list As New DataTable
        Dim parameters As New Dictionary(Of String, Object)()
        parameters.Add("@userID", CURRENT_USER_ID)
        If CURRENTY_USER_TYPE = "Admin" Then
            list = dbFind(SELECT_HISTORY_ADMIN_QUERY, New Dictionary(Of String, Object))
        Else
            list = dbFind(SELECT_HISTORY_USER_QUERY, parameters)
        End If

        Return list
    End Function
End Class
