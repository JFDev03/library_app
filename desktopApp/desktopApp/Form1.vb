Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadingForm As New mainLoadingForm()
        loadingForm.ShowDialog() ' Show loading form modally

        ' After the loading form closes, continue with the initialization
        InitializeApp()
    End Sub

    Private Sub InitializeApp()
        ' Simulate a long-running process
        System.Threading.Thread.Sleep(3000) ' Simulate loading time (3 seconds)

        ' Here you can load data, initialize resources, etc.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim layout As New mainLayout() ' Create a new instance of mainLayout
        layout.Show() ' Show the mainLayout form
        Me.Hide() ' Hide Form1 instead of closing it
    End Sub
End Class
