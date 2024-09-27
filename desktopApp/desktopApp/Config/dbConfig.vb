Imports MySql.Data.MySqlClient

Public Class dbConfig
    Public Function setConnection(server As String, database As String, user As String, password As String) As MySqlConnection
        Dim connectionString As String = $"Server={server};Database={database};User ID={user};Password={password};"
        Return New MySqlConnection(connectionString)
    End Function
End Class
