Imports System.IO

Public Class addBooksModal
    Dim uploadFileName As String = String.Empty
    Private Sub uploadBtn_Click(sender As Object, e As EventArgs) Handles uploadBtn.Click
        Dim openFileDialog As New OpenFileDialog With {
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*",
            .Title = "Select an Image File"
        }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim originalFileName As String = openFileDialog.SafeFileName
            picLabel.Text = originalFileName
            Try
                If IO.File.Exists(Path.Combine(getUploadDestinationPath, originalFileName)) Then
                    uploadFileName = GetUniqueFileName(originalFileName, getUploadDestinationPath())
                    Dim TempDestinationPath As String = Path.Combine(getUploadDestinationPath(), uploadFileName)
                    IO.File.Copy(filePath, TempDestinationPath, True)
                Else
                    uploadFileName = originalFileName
                    Dim TempDestinationPath As String = Path.Combine(getUploadDestinationPath(), originalFileName)
                    IO.File.Copy(filePath, TempDestinationPath, True)
                End If
                MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function GetUniqueFileName(originalFileName As String, destinationFolder As String) As String
        Dim uniqueFileName As String = originalFileName
        Dim counter As Integer = 1

        While IO.File.Exists(Path.Combine(destinationFolder, uniqueFileName))
            Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(originalFileName)
            Dim fileExtension As String = Path.GetExtension(originalFileName)
            uniqueFileName = $"{fileNameWithoutExtension}_{counter}{fileExtension}"
            counter += 1
        End While

        Return uniqueFileName
    End Function


    Private Async Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim quantity As Integer

        ' Try to parse the quantity from the text box
        If Integer.TryParse(book_quantity.Text, quantity) Then
            ' If successful, call the uploadBook method with the converted quantity
            Dim result As Boolean = uploadBook(uploadFileName, book_name.Text, book_desc.Text, book_author.Text, datePublished.Value, book_genre.Text, quantity)
            Select Case result
                Case True
                    MessageBox.Show("Book uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    books.displayData()
                    Me.Close()
                    clearInputs()
                Case False
                    MessageBox.Show("Error Book uploading!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        Else
            ' If parsing fails, display an error message
            MessageBox.Show("Please enter a valid integer for the quantity.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Sub clearInputs()
        uploadFileName = ""
        book_name.Text = ""
        book_desc.Text = ""
        book_author.Text = ""
        book_genre.Text = ""
        book_quantity.Text = ""
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Me.Close()
    End Sub

End Class