Imports MySql.Data.MySqlClient

Public Class dbConfig
    Public Function setConnection(server As String, database As String, username As String, password As String)
        Return "Server=" & server & ";Database=" & database & ";User ID=" & username & ";Password=" & password
    End Function
End Class
