Imports MySql.Data.MySqlClient

Public Class dashboard
    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")
    Dim Radius As New roundedForms()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Radius.RoundedPanel(total_booksPanel)
        Radius.RoundedPanel(Borrowed_booksPanel)
        Radius.RoundedPanel(returned_booksPanel)
    End Sub
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getData()
    End Sub

    Public Sub getData()
        Dim CountTotalBooks As String = "SELECT COUNT(*) as totalbooks FROM books_table"
        Dim CountTotalBorrowed As String = "SELECT COUNT(*) as totalborrow FROM borrow_table WHERE status = 'borrowed'"
        Dim CountTotalReturned As String = "SELECT Count(*) as totalreturn FROM borrow_table WHERE status = 'returned'"

        Try
            utils.OpenConnection(Connection)
            Dim reader1 As MySqlDataReader = utils.ExecuteSelectQuery(Connection, CountTotalBooks)
            While reader1.Read()
                totalBooks.Text = reader1("totalbooks")
            End While
            reader1.Close()
            Dim reader2 As MySqlDataReader = utils.ExecuteSelectQuery(Connection, CountTotalBorrowed)
            While reader2.Read()
                total_borrowed.Text = reader2("totalborrow")
            End While
            reader2.Close()
            Dim reader3 As MySqlDataReader = utils.ExecuteSelectQuery(Connection, CountTotalReturned)
            While reader3.Read()
                total_returned.Text = reader3("totalreturn")
            End While
            reader3.Close()
        Catch ex As Exception
        Finally
            utils.CloseConnection(Connection)
        End Try
    End Sub
End Class