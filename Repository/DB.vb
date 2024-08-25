Imports MySql.Data.MySqlClient

Module DB
    Public Function getConnection() As MySqlConnection
        Return New MySqlConnection(CONNECTION_STRING)
    End Function

    Public Sub closeConnection()
        Dim conn = getConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function dbFind(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable()

        Using conn = getConnection()
            Using cmd As New MySqlCommand(query, conn)
                If parameters.Count > 0 Then
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                End If

                conn.Open()

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Public Function dbStore(query As String, parameters As Dictionary(Of String, Object)) As Boolean
        Try
            Using conn = getConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    For Each param In parameters
                        cmd.Parameters.AddWithValue(param.Key, param.Value)
                    Next
                    Dim noOfRowsAffected = cmd.ExecuteNonQuery()
                    If noOfRowsAffected > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Module
