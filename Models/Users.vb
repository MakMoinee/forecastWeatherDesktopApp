Public Class Users

    Private userID As Int64
    Private firstName As String
    Private middleName As String
    Private lastName As String
    Private username As String
    Private password As String
    Private userType As String

    Public Sub New()
    End Sub

    Public Function getFirstName()
        Return firstName
    End Function

    Public Sub setFirstName(fn As String)
        firstName = fn
    End Sub

    Public Function getMiddleName()
        Return middleName
    End Function

    Public Sub setMiddleName(mn As String)
        middleName = mn
    End Sub

    Public Function getLastName()
        Return lastName
    End Function

    Public Sub setLastName(ln As String)
        lastName = ln
    End Sub

    Public Function getPassword()
        Return password
    End Function

    Public Sub setPassword(pw As String)
        password = pw
    End Sub

    Public Function getUsername()
        Return username
    End Function

    Public Sub setUsername(un As String)
        username = un
    End Sub

    Public Function getUserType()
        Return userType
    End Function

    Public Sub setUserType(ut As String)
        userType = ut
    End Sub

    Public Function getUserID()
        Return userID
    End Function

    Public Sub setUserID(uid As String)
        userID = uid
    End Sub




End Class
