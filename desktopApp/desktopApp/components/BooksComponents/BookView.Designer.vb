<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookView
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
        close_btn = New Button()
        genre = New Label()
        date_published = New Label()
        author = New Label()
        book_desc = New Label()
        book_name = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        book_picture = New PictureBox()
        CType(book_picture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' close_btn
        ' 
        close_btn.Location = New Point(519, 12)
        close_btn.Name = "close_btn"
        close_btn.Size = New Size(27, 23)
        close_btn.TabIndex = 24
        close_btn.Text = "X"
        close_btn.UseVisualStyleBackColor = True
        ' 
        ' genre
        ' 
        genre.AutoSize = True
        genre.Location = New Point(348, 220)
        genre.Name = "genre"
        genre.Size = New Size(41, 15)
        genre.TabIndex = 23
        genre.Text = "Label6"
        ' 
        ' date_published
        ' 
        date_published.AutoSize = True
        date_published.Location = New Point(398, 173)
        date_published.Name = "date_published"
        date_published.Size = New Size(41, 15)
        date_published.TabIndex = 22
        date_published.Text = "Label6"
        ' 
        ' author
        ' 
        author.AutoSize = True
        author.Location = New Point(355, 131)
        author.Name = "author"
        author.Size = New Size(41, 15)
        author.TabIndex = 21
        author.Text = "Label6"
        ' 
        ' book_desc
        ' 
        book_desc.AutoSize = True
        book_desc.Location = New Point(409, 69)
        book_desc.Name = "book_desc"
        book_desc.Size = New Size(41, 15)
        book_desc.TabIndex = 20
        book_desc.Text = "Label6"
        ' 
        ' book_name
        ' 
        book_name.AutoSize = True
        book_name.Location = New Point(380, 34)
        book_name.Name = "book_name"
        book_name.Size = New Size(41, 15)
        book_name.TabIndex = 19
        book_name.Text = "Label6"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(305, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 15)
        Label5.TabIndex = 18
        Label5.Text = "genre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(305, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 17
        Label4.Text = "date_published"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(305, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 16
        Label3.Text = "Author"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(305, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 15)
        Label2.TabIndex = 15
        Label2.Text = "Book_description"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(305, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 14
        Label1.Text = "Book_name"
        ' 
        ' book_picture
        ' 
        book_picture.Location = New Point(12, 34)
        book_picture.Name = "book_picture"
        book_picture.Size = New Size(271, 269)
        book_picture.SizeMode = PictureBoxSizeMode.StretchImage
        book_picture.TabIndex = 13
        book_picture.TabStop = False
        ' 
        ' BookView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(566, 338)
        Controls.Add(close_btn)
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
        Name = "BookView"
        StartPosition = FormStartPosition.CenterParent
        Text = "BookView"
        CType(book_picture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents close_btn As Button
    Friend WithEvents genre As Label
    Friend WithEvents date_published As Label
    Friend WithEvents author As Label
    Friend WithEvents book_desc As Label
    Friend WithEvents book_name As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents book_picture As PictureBox
End Class
