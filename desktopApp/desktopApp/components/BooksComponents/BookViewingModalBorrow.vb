Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class BookViewingModalBorrow
    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")
    Dim bookInitialQuantity As Integer = 0
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BookViewingModalBorrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDataBookBorrowed()
    End Sub
    Private Sub getDataBookBorrowed()
        Try
            Dim liststr As String = "SELECT * FROM books_table
        WHERE book_unique_id  = @bookID Limit 1
"
            utils.OpenConnection(Connection)
            Dim param As New Dictionary(Of String, Object) From {
            {"@bookId", getBookID()}
            }
            Dim reader As MySqlDataReader = utils.ExecuteSelectQueryWithParam(Connection, liststr, param)
            While reader.Read()
                book_picture.ImageLocation = getDestinationPath() + reader("book_image")
                book_name.Text = reader("book_name")
                book_desc.Text = reader("book_desc")
                author.Text = reader("author")
                date_published.Text = reader("date_published")
                genre.Text = reader("genre")
                bookInitialQuantity = reader("initial_quantity")
            End While
            If getStat() = "borrowed" Then
                return_btn.Enabled = True
            Else
                return_btn.Enabled = False
            End If
            Console.WriteLine(reader)
            MsgBox(reader)
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            utils.CloseConnection(Connection)
        End Try
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

    Private Sub return_btn_Click(sender As Object, e As EventArgs) Handles return_btn.Click
        Dim result As Boolean = returnTheBook()
        Select Case result
            Case True
                MessageBox.Show("Book Returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                borrow.displayData()
                Me.Close()
            Case False
                MessageBox.Show("Error Book Returning!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Function returnTheBook() As Boolean
        Dim updateBookQuery As String = "UPDATE books_table SET initial_quantity = @addQuant WHERE book_unique_id = @bookID
            "
        Try
            utils.OpenConnection(Connection)
            Dim newQuan As Integer = bookInitialQuantity + getQuan()
            Dim param As New Dictionary(Of String, Object) From {
                {"@addQuant", newQuan},
                {"@bookID", getBookID()}
    }
            Dim cmd = utils.ExecuteCommandQuery(Connection, updateBookQuery, param)

            If cmd Then
                Dim updateBorrowedQuery As String = "UPDATE borrow_table SET status = 'returned',date_returned = NOW() WHERE employee_id = @emplID AND book_unique_id = @bookID"
                Dim newParam As New Dictionary(Of String, Object) From {
                {"@emplID", getEmpID()},
                {"@bookID", getBookID()}
    }
                Dim newCmd = utils.ExecuteCommandQuery(Connection, updateBorrowedQuery, newParam)
                If newCmd Then
                    Return True
                Else
                    Return False
                End If
            Else
                Return False
            End If

        Catch ex As Exception
            Console.WriteLine("error:" & ex.Message)
            Return False
        Finally
            utils.CloseConnection(Connection)
        End Try
    End Function
End Class