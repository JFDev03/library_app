<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBooksModal
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
        Label1 = New Label()
        previewPic = New PictureBox()
        picLabel = New TextBox()
        uploadBtn = New Button()
        book_name = New TextBox()
        book_author = New TextBox()
        datePublished = New DateTimePicker()
        book_genre = New TextBox()
        book_quantity = New TextBox()
        book_desc = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        saveBtn = New Button()
        cancelBtn = New Button()
        close_btn = New Button()
        CType(previewPic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(162, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 30)
        Label1.TabIndex = 0
        Label1.Text = "Add Books"
        ' 
        ' previewPic
        ' 
        previewPic.Location = New Point(163, 57)
        previewPic.Name = "previewPic"
        previewPic.Size = New Size(112, 84)
        previewPic.TabIndex = 1
        previewPic.TabStop = False
        ' 
        ' picLabel
        ' 
        picLabel.Location = New Point(49, 152)
        picLabel.Name = "picLabel"
        picLabel.Size = New Size(113, 23)
        picLabel.TabIndex = 2
        ' 
        ' uploadBtn
        ' 
        uploadBtn.Location = New Point(162, 153)
        uploadBtn.Name = "uploadBtn"
        uploadBtn.Size = New Size(59, 22)
        uploadBtn.TabIndex = 3
        uploadBtn.Text = "upload"
        uploadBtn.UseVisualStyleBackColor = True
        ' 
        ' book_name
        ' 
        book_name.Location = New Point(49, 193)
        book_name.Name = "book_name"
        book_name.Size = New Size(113, 23)
        book_name.TabIndex = 4
        ' 
        ' book_author
        ' 
        book_author.Location = New Point(50, 234)
        book_author.Name = "book_author"
        book_author.Size = New Size(112, 23)
        book_author.TabIndex = 5
        ' 
        ' datePublished
        ' 
        datePublished.Location = New Point(276, 153)
        datePublished.Name = "datePublished"
        datePublished.Size = New Size(112, 23)
        datePublished.TabIndex = 6
        ' 
        ' book_genre
        ' 
        book_genre.Location = New Point(276, 193)
        book_genre.Name = "book_genre"
        book_genre.Size = New Size(112, 23)
        book_genre.TabIndex = 7
        ' 
        ' book_quantity
        ' 
        book_quantity.Location = New Point(276, 234)
        book_quantity.Name = "book_quantity"
        book_quantity.Size = New Size(112, 23)
        book_quantity.TabIndex = 8
        ' 
        ' book_desc
        ' 
        book_desc.Location = New Point(144, 267)
        book_desc.Multiline = True
        book_desc.Name = "book_desc"
        book_desc.Size = New Size(151, 93)
        book_desc.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 10
        Label2.Text = "Book Image"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 11
        Label3.Text = "Book name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(50, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 12
        Label4.Text = "Book author"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(276, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 15)
        Label5.TabIndex = 13
        Label5.Text = "Book published"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(276, 178)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 14
        Label6.Text = "Book genre"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(277, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 15)
        Label7.TabIndex = 15
        Label7.Text = "Book Quantity"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(172, 249)
        Label8.Name = "Label8"
        Label8.Size = New Size(96, 15)
        Label8.TabIndex = 16
        Label8.Text = "Book description"
        ' 
        ' saveBtn
        ' 
        saveBtn.Location = New Point(32, 380)
        saveBtn.Name = "saveBtn"
        saveBtn.Size = New Size(114, 40)
        saveBtn.TabIndex = 17
        saveBtn.Text = "Save"
        saveBtn.UseVisualStyleBackColor = True
        ' 
        ' cancelBtn
        ' 
        cancelBtn.Location = New Point(314, 380)
        cancelBtn.Name = "cancelBtn"
        cancelBtn.Size = New Size(98, 40)
        cancelBtn.TabIndex = 18
        cancelBtn.Text = "Cancel"
        cancelBtn.UseVisualStyleBackColor = True
        ' 
        ' close_btn
        ' 
        close_btn.BackColor = SystemColors.ControlLightLight
        close_btn.Location = New Point(402, 6)
        close_btn.Margin = New Padding(0)
        close_btn.Name = "close_btn"
        close_btn.Size = New Size(29, 23)
        close_btn.TabIndex = 19
        close_btn.Text = "X"
        close_btn.UseVisualStyleBackColor = False
        ' 
        ' addBooksModal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 432)
        Controls.Add(close_btn)
        Controls.Add(cancelBtn)
        Controls.Add(saveBtn)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(book_desc)
        Controls.Add(book_quantity)
        Controls.Add(book_genre)
        Controls.Add(datePublished)
        Controls.Add(book_author)
        Controls.Add(book_name)
        Controls.Add(uploadBtn)
        Controls.Add(picLabel)
        Controls.Add(previewPic)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "addBooksModal"
        StartPosition = FormStartPosition.CenterParent
        Text = "addBooksModal"
        CType(previewPic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents previewPic As PictureBox
    Friend WithEvents picLabel As TextBox
    Friend WithEvents uploadBtn As Button
    Friend WithEvents book_name As TextBox
    Friend WithEvents book_author As TextBox
    Friend WithEvents datePublished As DateTimePicker
    Friend WithEvents book_genre As TextBox
    Friend WithEvents book_quantity As TextBox
    Friend WithEvents book_desc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents saveBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents close_btn As Button
End Class
