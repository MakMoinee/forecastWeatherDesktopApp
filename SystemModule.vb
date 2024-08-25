Module SystemModule
    Public responseContent As String = ""
    Public CURRENT_USER As String = ""
    Public CURRENT_USER_ID As Integer = 0
    Public CURRENTY_USER_TYPE As String = ""


    Public Sub systemAddLog(description As String, input As String, output As String)
        Dim historyService As New HistoryService
        Dim historyListener As New HistoryImpl
        Dim h As New History
        h.UserID = CURRENT_USER_ID
        h.Description = description
        h.Input = input
        h.Output = output
        historyService.addLog(h, historyListener)
    End Sub

    Public Function getTextMonth(month As Integer) As String
        Select Case month
            Case 1
                Return "January"
            Case 2
                Return "February"
            Case 3
                Return "March"
            Case 4
                Return "April"
            Case 5
                Return "May"
            Case 6
                Return "June"
            Case 7
                Return "July"
            Case 8
                Return "August"
            Case 9
                Return "September"
            Case 10
                Return "October"
            Case 11
                Return "November"
            Case 12
                Return "December"
            Case Else
                Return "error"
        End Select
    End Function
End Module
