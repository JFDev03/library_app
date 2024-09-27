Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports System.Reactive.Subjects
Imports System.Reactive.Linq
Public Class books
    Dim searchData As String
    Dim totalCount As Integer
    Dim totalPages As Integer
    Dim limit As Integer = 10
    Dim page As Integer = 1
    Dim Config As New dbConfig
    Dim utils As New utils
    Dim Connection As MySqlConnection = Config.setConnection("localhost", "library_system_db", "root", "")
    Private dataWorker As BackgroundWorker
    Private inputSubject As New Subject(Of String)()

    Public Sub New()
        InitializeComponent()
        inputSubject _
            .Throttle(TimeSpan.FromMilliseconds(1000)) _
            .Subscribe(AddressOf ProcessInput)

        ' Example of attaching the input event
        AddHandler searchBox.TextChanged, AddressOf searchBox_TextChanged
        AddHandler addBooksModal.VisibleChanged, AddressOf AddBooksModal_VisibleChanged
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs)
        inputSubject.OnNext(searchBox.Text)
    End Sub
    Private Sub books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        invokeData()
    End Sub
    Private Sub AddBooksModal_VisibleChanged(sender As Object, e As EventArgs)
        If Me.IsDisposed Then
            Return
        End If
        If addBooksModal.Visible Then
        Else
            invokeData()
        End If
    End Sub


    Public Sub invokeData()
        If Me.IsDisposed Then
            Return
        End If

        If Me.IsHandleCreated Then
            Me.Invoke(Sub()
                          displayData()
                      End Sub)
        Else
            Me.CreateHandle()
            invokeData()
        End If
    End Sub


    Public Sub displayData()
        If Me.IsDisposed Then
            Return
        End If
        searchData = searchBox.Text
        getPagination(searchData)

        If totalPages < page Then
            page = 1
        End If
        If Me.IsHandleCreated Then
            Me.Invoke(Sub()
                          DisplayTable(bookDGV, limit, page, searchData)
                          next_btn.Enabled = (page < totalPages)
                          prev_btn.Enabled = (page > 1)
                          textPage.Text = "Total Records: " & totalCount & " Showing Page " & page & " of " & totalPages
                      End Sub)
        Else
            Me.CreateHandle()
            displayData()
        End If
    End Sub


    Private Sub ProcessInput(input As String)
        getPagination(input)
        displayData()
    End Sub

    Public Sub getPagination(input As String)
        Dim countQuery As String = "SELECT COUNT(*) As Count FROM books_table
        WHERE book_unique_id LIKE @search 
           OR book_name LIKE @search 
           OR author LIKE @search 
           OR genre LIKE @search"

        Try
            utils.OpenConnection(Connection)
            Dim param As New Dictionary(Of String, Object) From {
            {"@search", "%" & input & "%"}
            }
            Dim reader As MySqlDataReader = utils.ExecuteSelectQueryWithParam(Connection, countQuery, param)
            While reader.Read()
                totalCount = reader("Count")
            End While

            If totalCount > 0 Then
                totalPages = Math.Ceiling(totalCount / limit)
            Else
                totalPages = 1
            End If
        Catch ex As Exception
            Console.WriteLine("error:" & ex.Message)
        Finally
            utils.CloseConnection(Connection)
        End Try
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If page < totalPages Then
            page += 1
            DisplayTable(bookDGV, limit, page, searchData)
            textPage.Text = "Total Records: " & totalCount & " Showing Page " & page & " of " & totalPages
        End If

        next_btn.Enabled = (page < totalPages)
        prev_btn.Enabled = (page > 1)
    End Sub

    Private Sub Prev_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        If page > 1 Then
            page -= 1
            DisplayTable(bookDGV, limit, page, searchData)
            textPage.Text = "Total Records: " & totalCount & " Showing Page " & page & " of " & totalPages
        End If

        prev_btn.Enabled = (page > 1)
        next_btn.Enabled = (page < totalPages)
    End Sub

    Private Sub RoundedButtonDocker1_Click(sender As Object, e As EventArgs) Handles RoundedButtonDocker1.Click
        addBooksModal.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        displayData()
    End Sub

    Private Sub bookDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bookDGV.CellContentClick
        setBookParam(bookDGV.CurrentRow.Cells(2).Value, bookDGV.CurrentRow.Cells(3).Value, bookDGV.CurrentRow.Cells(4).Value, bookDGV.CurrentRow.Cells(5).Value, bookDGV.CurrentRow.Cells(6).Value, bookDGV.CurrentRow.Cells(7).Value, bookDGV.CurrentRow.Cells(8).Value, bookDGV.CurrentRow.Cells(9).Value, bookDGV.CurrentRow.Cells(10).Value)
        BookView.ShowDialog()
    End Sub
End Class
