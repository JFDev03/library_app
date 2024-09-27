Public Class BookView
    Private Sub BookView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        book_picture.ImageLocation = getDestinationPath() + getBImage()
        book_name.Text = getBName()
        book_desc.Text = getBDesc()
        author.Text = getBAuth()
        date_published.Text = getBDateD()
        genre.Text = getBGen()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub
End Class