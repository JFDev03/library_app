Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim assignEmployeeID As String
    Dim assignPassword As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadingForm As New mainLoadingForm()
        loadingForm.ShowDialog() ' Show loading form modally

        ' After the loading form closes, continue with the initialization
        InitializeApp()
    End Sub

    Private Sub InitializeApp()
        ' Simulate a long-running process
        System.Threading.Thread.Sleep(3000) ' Simulate loading time (3 seconds)
        clearSessions()
        AddHandler employeeIDInput.KeyUp, AddressOf TextBox_KeyUp
        AddHandler passwordInput.KeyUp, AddressOf TextBox_KeyUp
        ' Here you can load data, initialize resources, etc.
    End Sub


    Private Sub Username_GotFocus(sender As Object, e As EventArgs) Handles employeeIDInput.GotFocus
        employeeIDInput.Text = ""
        employeeIDInput.ForeColor = Color.Black
    End Sub

    Private Sub Username_LostFocus(sender As Object, e As EventArgs) Handles employeeIDInput.LostFocus
        employeeIDInput.ForeColor = Color.Black
        If employeeIDInput.Text = "" Then
            employeeIDInput.Text = "Enter your username"
        End If
    End Sub
    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles employeeIDInput.TextChanged
        assignEmployeeID = employeeIDInput.Text
    End Sub
    Private Sub Password_TextChanged_1(sender As Object, e As EventArgs) Handles passwordInput.TextChanged
        assignPassword = passwordInput.Text
    End Sub
    Private Sub Password_GotFocus(sender As Object, e As EventArgs) Handles passwordInput.GotFocus
        passwordInput.Text = ""
        passwordInput.PasswordChar = "*"
        passwordInput.ForeColor = Color.Black
    End Sub
    Private Sub Password_LostFocus(sender As Object, e As EventArgs) Handles passwordInput.LostFocus
        passwordInput.ForeColor = Color.Black
        If passwordInput.Text = "" Then
            passwordInput.PasswordChar = ""
            passwordInput.Text = "Enter your password"
        End If
    End Sub



    Private Sub TextBox_KeyUp(sender As Object, e As KeyEventArgs)
        ' Check if the Enter key is pressed
        If e.KeyCode = Keys.Enter Then
            submitData_Click(sender, e) ' Call the Button click event
        End If
    End Sub

    Private Sub Form1_Blank(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        clearSessions()
    End Sub

    Public Sub clearInputs()
        employeeIDInput.Text = ""
        passwordInput.Text = ""
    End Sub

    Private Sub submitData_Click(sender As Object, e As EventArgs) Handles submitData.Click
        Me.UseWaitCursor = True
        Dim result As Boolean = Login(assignEmployeeID, assignPassword)
        Thread.Sleep(1000)
        Dim layout As New mainLayout() ' Create a new instance of mainLayout
        Me.UseWaitCursor = False
        If result = True Then

            Dim role As String = getRole()
            Select Case role
                Case "user"
                    MsgBox("Error User is not fit to sign in", MsgBoxStyle.Information, "Error")
                Case "admin"
                    clearInputs()
                    MsgBox("Login successful!", MsgBoxStyle.Information, "Success")
                    layout.Show()
                    Me.Hide()

            End Select
        End If
    End Sub
End Class
