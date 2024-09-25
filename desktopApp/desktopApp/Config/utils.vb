Imports MySql.Data.MySqlClient

Public Class utils
    Public Function NewConnection(connString As String) As MySqlConnection
        Dim connection As New MySqlConnection(connString)
        Return connection
    End Function

    Public Function ExecuteSelectQuery(con As MySqlConnection, query As String) As MySqlDataReader
        Dim command As New MySqlCommand(query, con) ' Corrected the constructor usage
        Dim read As MySqlDataReader = command.ExecuteReader() ' Execute the query and return the reader
        Return read
    End Function
    Public Function ExecuteCommandQuery(con As MySqlConnection, query As String, parameters As Dictionary(Of String, Object)) As Integer

        Using command As New MySqlCommand(query, con) ' Create the command with the query and connection
            ' Add parameters to the command
            For Each param In parameters
                command.Parameters.AddWithValue(param.Key, param.Value)
            Next
            Dim newCommand = command.ExecuteNonQuery()

            Return newCommand ' Execute the non-query and return the number of affected rows
        End Using
    End Function
    Public Function ExecuteNonQueryWithLastInsertedId(con As MySqlConnection, query As String, parameters As Dictionary(Of String, Object)) As Long
        Using command As New MySqlCommand(query, con)
            ' Add parameters to the command
            For Each param In parameters
                command.Parameters.AddWithValue(param.Key, param.Value)
            Next

            command.ExecuteNonQuery() ' Execute the non-query

            ' Get the last inserted ID
            Dim lastInsertedId As Long = command.LastInsertedId
            Return lastInsertedId ' Return the last inserted ID
        End Using

    End Function
    Public Function ExecuteSelectQueryWithParam(con As MySqlConnection, query As String, parameters As Dictionary(Of String, Object)) As MySqlDataReader
        Dim command As New MySqlCommand(query, con) ' Corrected the constructor usage
        For Each param In parameters
            command.Parameters.AddWithValue(param.Key, param.Value)
        Next
        Dim reader As MySqlDataReader = command.ExecuteReader() ' Execute the query and return the reader
        Return reader
    End Function

    Public Sub CloseConnection(con As MySqlConnection)
        If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Sub OpenConnection(con As MySqlConnection)
        If con IsNot Nothing AndAlso con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
End Class
