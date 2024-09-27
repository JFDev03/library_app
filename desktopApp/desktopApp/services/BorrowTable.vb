Imports MySql.Data.MySqlClient
Imports System.Data.Common

Public Class BorrowTable
    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")
    Public Sub DisplayTable(dgvlist As DataGridView, limit As Integer, page As Integer, search As String)
        Dim pageLimit As Integer = limit
        Dim currentPage As Integer = page
        Dim searchData As String = search

        Dim offset As Integer = (currentPage - 1) * pageLimit

        Try
            Dim liststr As String = "SELECT * FROM borrow_table
        WHERE employee_id LIKE @search 
           OR book_unique_id LIKE @search
        ORDER BY status
        LIMIT @offset, @limit
"
            utils.OpenConnection(Connection)
            Dim param As New Dictionary(Of String, Object) From {
            {"@search", "%" & searchData & "%"},
            {"@offset", offset},
            {"@limit", pageLimit}
            }
            Dim reader As MySqlDataReader = utils.ExecuteSelectQueryWithParam(Connection, liststr, param)
            dgvlist.Invoke(Sub() dgvlist.Rows.Clear())
            Dim rowIndex As Integer = offset + 1

            While reader.Read()
                dgvlist.Invoke(Sub()
                                   Dim index As Integer = dgvlist.Rows.Add()
                                   Dim row As DataGridViewRow = dgvlist.Rows(index)
                                   row.Cells(0).Value = rowIndex
                                   row.Cells(1).Value = reader("id")
                                   row.Cells(2).Value = reader("employee_id")
                                   row.Cells(3).Value = reader("book_unique_id")
                                   row.Cells(4).Value = reader("quantity")
                                   row.Cells(5).Value = reader("status")
                                   row.Cells(6).Value = reader("date_borrowed")
                                   row.Cells(7).Value = reader("date_returned")
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
        dgv.Columns.Add("Employee_id", "Employee_id")
        dgv.Columns.Add("book_unique_id", "book_unique_id")
        dgv.Columns.Add("Quantity", "Quantity")
        dgv.Columns.Add("status", "status")
        dgv.Columns.Add("date_borrowed", "date_borrowed")
        dgv.Columns.Add("date_returned", "date_returned")

        dgv.Columns("ID").Visible = False
        dgv.Columns("Index").Width = 50
        dgv.Columns("Employee_id").Width = 100
        dgv.Columns("book_unique_id").Width = 100
        dgv.Columns("Quantity").Width = 100
        dgv.Columns("status").Width = 100
        dgv.Columns("date_borrowed").Width = 100
        dgv.Columns("date_returned").Width = 100
    End Sub
End Class
