Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Module auth
    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")

    Public Function Login(employee_id As String, password As String) As Boolean
        Try
            utils.OpenConnection(Connection)

            ' Retrieve the stored hashed password for the username
            Dim query As String = "SELECT 
                a.id, 
                a.employee_id, 
                a.password, 
                a.role, 
                b.profile_picture, 
                CONCAT_WS(' ', COALESCE(b.firstname, ''), COALESCE(b.middlename, ''), COALESCE(b.lastname, '')) AS fullname, 
                b.position, 
                b.status 
            FROM 
                user_table a
            JOIN 
                user_info_table b ON a.employee_id = b.employee_id
            WHERE 
                a.employee_id = @employeeID"
            Dim param As New Dictionary(Of String, Object) From {
                {"@employeeID", employee_id}
            }

            Dim reader As MySqlDataReader = utils.ExecuteSelectQueryWithParam(Connection, query, param)

            Dim storedhashPass As String = ""
            Dim profile As String = ""
            Dim fname As String = ""
            Dim userrole As String = ""

            If reader.HasRows Then
                While reader.Read()
                    storedhashPass = reader("password").ToString()
                    profile = reader("profile_picture").ToString()
                    fname = reader("fullname").ToString()
                    userrole = reader("role").ToString()
                End While
            Else
                Return False
            End If

            reader.Close()

            ' Verify the password against the stored hash
            If BCrypt.Net.BCrypt.Verify(password, storedhashPass) Then
                ' Set the session with the ID and username
                setSessions(profile, fname, userrole)
                Return True
            Else
                MsgBox("Invalid password.", MsgBoxStyle.Critical, "Error")
                Return False
            End If

        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            utils.CloseConnection(Connection)
        End Try
    End Function
End Module
