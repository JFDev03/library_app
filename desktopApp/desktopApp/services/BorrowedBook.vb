Module BorrowedBook
    Private Book_unique_id As String = ""
    Private employee_id As String = ""
    Private status As String = ""
    Private quantiy As Integer = 0

    Public Sub setBorrowedBook(empID As String, BookID As String, stat As String, Quan As Integer)
        Book_unique_id = BookID
        employee_id = empID
        status = stat
        quantiy = Quan
    End Sub

    Public Function getBookID()
        Return Book_unique_id
    End Function
    Public Function getEmpID()
        Return employee_id
    End Function
    Public Function getStat()
        Return status
    End Function
    Public Function getQuan()
        Return quantiy
    End Function

End Module
