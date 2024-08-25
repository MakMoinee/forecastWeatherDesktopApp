
Public Class UserService

    Private hash As New HashService
    Public Sub New()
    End Sub

    Public Sub login(users As Users, listener As RequestListener)
        If users IsNot Nothing Then
            Dim parameters As New Dictionary(Of String, Object)()
            parameters.Add("@username", users.getUsername())
            Dim dt = dbFind(LOGIN_QUERY, parameters)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    Dim pw = row("password").ToString()
                    Dim isValid = hash.VerifyPassword(pw, users.getPassword())
                    If isValid Then
                        CURRENT_USER = row("username").ToString()
                        CURRENT_USER_ID = Integer.Parse(row("userID").ToString())
                        CURRENTY_USER_TYPE = row("userType").ToString()
                        listener.OnSuccess("valid")
                    Else
                        listener.OnError(New Exception("wrong username or password"))
                    End If
                Next
            Else
                listener.OnError(New Exception("wrong username or password"))
            End If
        End If
    End Sub

    Public Sub createAccount(users As Users, listener As RequestListener)
        If users IsNot Nothing Then
            Dim parameters As New Dictionary(Of String, Object)()

            parameters.Add("@username", users.getUsername())

            Dim dt = dbFind(LOGIN_QUERY, parameters)
            If dt.Rows.Count > 0 Then
                listener.OnError(New Exception("data exist"))
            Else
                closeConnection()
                parameters.Add("@firstName", users.getFirstName())
                parameters.Add("@middleName", users.getMiddleName())
                parameters.Add("@lastName", users.getLastName())
                parameters.Add("@password", users.getPassword())
                parameters.Add("@userType", users.getUserType())

                Dim isSaved = dbStore(CREATE_ACCOUNT_QUERY, parameters)
                If isSaved Then
                    listener.OnSuccess("success")
                Else
                    listener.OnError(New Exception("failed"))
                End If
            End If




        End If
    End Sub
End Class
