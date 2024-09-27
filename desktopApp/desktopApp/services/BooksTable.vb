Imports MySql.Data.MySqlClient
Imports System.Data.Common

Module BooksTable

    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")
    Public Sub DisplayTable(dgvlist As DataGridView, limit As Integer, page As Integer, search As String)
        Dim pageLimit As Integer = limit
        Dim currentPage As Integer = page
        Dim searchData As String = search

        Dim offset As Integer = (currentPage - 1) * pageLimit

        Try
            Dim liststr As String = "SELECT * FROM books_table
        WHERE book_unique_id LIKE @search 
           OR book_name LIKE @search 
           OR author LIKE @search 
           OR genre LIKE @search 
        ORDER BY id DESC 
        LIMIT @offset, @limit
"
            utils.OpenConnection(Connection)
            Dim param As New Dictionary(Of String, Object) From {
            {"@search", "%" & searchData & "%"},
            {"@offset", offset},
            {"@limit", pageLimit}
            }
            Dim reader As MySqlDataReader = utils.ExecuteSelectQueryWithParam(Connection, liststr, param)
            If Not dgvlist.IsHandleCreated Then
                ' Handle not created, return or log
                Console.WriteLine("Handle not created yet.")
                Return
            End If
            ' Proceed with loading data...
            dgvlist.Invoke(Sub() dgvlist.Rows.Clear())
            Dim rowIndex As Integer = offset + 1

            While reader.Read()
                dgvlist.Invoke(Sub()
                                   Dim index As Integer = dgvlist.Rows.Add()
                                   Dim row As DataGridViewRow = dgvlist.Rows(index)
                                   row.Cells(0).Value = rowIndex
                                   row.Cells(1).Value = reader("id")
                                   row.Cells(2).Value = reader("book_unique_id")
                                   row.Cells(3).Value = reader("book_image")
                                   row.Cells(4).Value = reader("book_name")
                                   row.Cells(5).Value = reader("book_desc")
                                   row.Cells(6).Value = reader("author")
                                   row.Cells(7).Value = reader("date_published")
                                   row.Cells(8).Value = reader("genre")
                                   row.Cells(9).Value = reader("initial_quantity")
                                   row.Cells(10).Value = reader("total_quantity")
                               End Sub)
                rowIndex += 1
            End While
            Console.WriteLine(reader)
            MsgBox(reader)
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            utils.CloseConnection(Connection)
        End Try
    End Sub

    Public Sub SetupTable(dgv As DataGridView)
        dgv.Columns.Clear()
        dgv.AllowUserToAddRows = True
        ' Assuming you have 7 columns, adjust accordingly
        dgv.Columns.Add("Index", "No.")
        dgv.Columns.Add("ID", "ID")
        dgv.Columns.Add("book_unique_id", "book_unique_id")
        dgv.Columns.Add("book_image", "book_image")
        dgv.Columns.Add("Bookname", "Bookname")
        dgv.Columns.Add("Bookdesc", "bookdesc")
        dgv.Columns.Add("Author", "Author")
        dgv.Columns.Add("date_published", "date_published")
        dgv.Columns.Add("genre", "genre")
        dgv.Columns.Add("initial_quantity", "initial_quantity")
        dgv.Columns.Add("total_quantity", "total_quantity")

        dgv.Columns("ID").Visible = False
        dgv.Columns("book_image").Visible = False
        dgv.Columns("Index").Width = 50
        dgv.Columns("book_unique_id").Width = 100
        dgv.Columns("Bookname").Width = 100
        dgv.Columns("Bookdesc").Width = 100
        dgv.Columns("Author").Width = 100
        dgv.Columns("date_published").Width = 100
        dgv.Columns("genre").Width = 100
        dgv.Columns("initial_quantity").Width = 100
        dgv.Columns("total_quantity").Width = 100
    End Sub
End Module
