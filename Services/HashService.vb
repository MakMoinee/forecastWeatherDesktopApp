Imports System.Security.Cryptography
Imports System.Text
Public Class HashService
    Private hashPass As String

    Public Sub New()
    End Sub

    Public Function HashPassword(password As String) As String
        Dim saltBytes(15) As Byte
        Using rng As New RNGCryptoServiceProvider()
            rng.GetBytes(saltBytes)
        End Using

        Dim salt = Convert.ToBase64String(saltBytes)
        Dim pbkdf2 = New Rfc2898DeriveBytes(password, saltBytes, 10000)
        Dim hash = pbkdf2.GetBytes(20)

        Return $"{salt}:{Convert.ToBase64String(hash)}"
    End Function

    Public Function VerifyPassword(storedHash As String, password As String) As Boolean
        Dim parts = storedHash.Split(":"c)
        Dim salt = Convert.FromBase64String(parts(0))
        Dim storedPasswordHash = Convert.FromBase64String(parts(1))

        Dim pbkdf2 = New Rfc2898DeriveBytes(password, salt, 10000)
        Dim passwordHash = pbkdf2.GetBytes(20)

        For i As Integer = 0 To storedPasswordHash.Length - 1
            If storedPasswordHash(i) <> passwordHash(i) Then
                Return False
            End If
        Next

        Return True
    End Function

End Class
