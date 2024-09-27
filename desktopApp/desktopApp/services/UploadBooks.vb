Imports MySql.Data.MySqlClient

Module UploadBooks
    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")

    Public Function uploadBook(bookImage As String, bookName As String, bookDesc As String, bookAuthor As String, datePublished As String, bookGenre As String, initialQ As Integer) As Boolean
        Try
            utils.OpenConnection(Connection)


            Dim random As New Random()
            Dim randomNumber As Integer
            ' Generate a random integer between 0 and 100
            randomNumber = random.Next(0, 100000)


            Dim CheckQuery As String = "SELECT * FROM books_table WHERE book_unique_id = @bookID"

            Dim param As New Dictionary(Of String, Object) From {
                {"@bookID", randomNumber}
            }

            Dim reader As MySqlDataReader = utils.ExecuteSelectQueryWithParam(Connection, CheckQuery, param)
            If reader.HasRows Then
                randomNumber = random.Next(0, 100000)
            End If
            reader.Close()

            Dim query As String = "INSERT INTO books_table(book_unique_id, book_image, book_name, book_desc, author, date_published, genre, initial_quantity, total_quantity) 
                VALUES (@uniqueID,@bookImage,@bookName,@bookDesc,@bookAuthor,@datePublished,@bookGenre,@initialQ,@titalQ)"
            Dim insertparam As New Dictionary(Of String, Object) From {
                {"@uniqueID", randomNumber},
            {"@bookImage", "upload\" & bookImage},
            {"@bookName", bookName},
            {"@bookDesc", bookDesc},
            {"@bookAuthor", bookAuthor},
            {"@datePublished", datePublished},
            {"@bookGenre", bookGenre},
            {"@initialQ", initialQ},
            {"@titalQ", initialQ}
            }
            ' Retrieve the stored hashed password for the username

            Dim cmd = utils.ExecuteCommandQuery(Connection, query, insertparam)

            If cmd Then
                Return True
            Else
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
