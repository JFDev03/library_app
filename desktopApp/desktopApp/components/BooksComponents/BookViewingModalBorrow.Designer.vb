<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookViewingModalBorrow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        book_picture = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        book_name = New Label()
        book_desc = New Label()
        author = New Label()
        date_published = New Label()
        genre = New Label()
        return_btn = New Button()
        close_btn = New Button()
        CType(book_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' book_picture
        ' 
        book_picture.Location = New Point(25, 32)
        book_picture.Name = "book_picture"
        book_picture.Size = New Size(271, 269)
        book_picture.SizeMode = PictureBoxSizeMode.StretchImage
        book_picture.TabIndex = 0
        book_picture.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(318, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 1
        Label1.Text = "Book_name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(318, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 2
        Label2.Text = "Book_description"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(318, 129)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 3
        Label3.Text = "Author"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(318, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 4
        Label4.Text = "date_published"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(318, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 5
        Label5.Text = "genre"
        ' 
        ' book_name
        ' 
        book_name.AutoSize = True
        book_name.Location = New Point(393, 32)
        book_name.Name = "book_name"
        book_name.Size = New Size(41, 15)
        book_name.TabIndex = 6
        book_name.Text = "Label6"
        ' 
        ' book_desc
        ' 
        book_desc.AutoSize = True
        book_desc.Location = New Point(422, 67)
        book_desc.Name = "book_desc"
        book_desc.Size = New Size(41, 15)
        book_desc.TabIndex = 7
        book_desc.Text = "Label6"
        ' 
        ' author
        ' 
        author.AutoSize = True
        author.Location = New Point(368, 129)
        author.Name = "author"
        author.Size = New Size(41, 15)
        author.TabIndex = 8
        author.Text = "Label6"
        ' 
        ' date_published
        ' 
        date_published.AutoSize = True
        date_published.Location = New Point(411, 171)
        date_published.Name = "date_published"
        date_published.Size = New Size(41, 15)
        date_published.TabIndex = 9
        date_published.Text = "Label6"
        ' 
        ' genre
        ' 
        genre.AutoSize = True
        genre.Location = New Point(361, 218)
        genre.Name = "genre"
        genre.Size = New Size(41, 15)
        genre.TabIndex = 10
        genre.Text = "Label6"
        ' 
        ' return_btn
        ' 
        return_btn.Location = New Point(470, 303)
        return_btn.Name = "return_btn"
        return_btn.Size = New Size(75, 23)
        return_btn.TabIndex = 11
        return_btn.Text = "return"
        return_btn.UseVisualStyleBackColor = True
        ' 
        ' close_btn
        ' 
        close_btn.Location = New Point(532, 6)
        close_btn.Name = "close_btn"
        close_btn.Size = New Size(27, 23)
        close_btn.TabIndex = 12
        close_btn.Text = "X"
        close_btn.UseVisualStyleBackColor = True
        ' 
        ' BookViewingModalBorrow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(566, 338)
        Controls.Add(close_btn)
        Controls.Add(return_btn)
        Controls.Add(genre)
        Controls.Add(date_published)
        Controls.Add(author)
        Controls.Add(book_desc)
        Controls.Add(book_name)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(book_picture)
        FormBorderStyle = FormBorderStyle.None
        Name = "BookViewingModalBorrow"
        StartPosition = FormStartPosition.CenterParent
        Text = "BookViewingModalBorrow"
        CType(book_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents book_picture As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents book_name As Label
    Friend WithEvents book_desc As Label
    Friend WithEvents author As Label
    Friend WithEvents date_published As Label
    Friend WithEvents genre As Label
    Friend WithEvents return_btn As Button
    Friend WithEvents close_btn As Button
End Class
