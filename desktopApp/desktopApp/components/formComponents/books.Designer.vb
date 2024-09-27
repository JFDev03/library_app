<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class books
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
        bookDGV = New DataGridView()
        Index = New DataGridViewTextBoxColumn()
        ID = New DataGridViewTextBoxColumn()
        book_unique_id = New DataGridViewTextBoxColumn()
        book_image = New DataGridViewTextBoxColumn()
        book_name = New DataGridViewTextBoxColumn()
        book_desc = New DataGridViewTextBoxColumn()
        author = New DataGridViewTextBoxColumn()
        date_published = New DataGridViewTextBoxColumn()
        genre = New DataGridViewTextBoxColumn()
        initial_quantity = New DataGridViewTextBoxColumn()
        total_quantity = New DataGridViewTextBoxColumn()
        RoundedButtonDocker1 = New RoundedButtonDocker()
        searchBox = New TextBox()
        next_btn = New Button()
        prev_btn = New Button()
        textPage = New Label()
        CType(bookDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bookDGV
        ' 
        bookDGV.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        bookDGV.BackgroundColor = SystemColors.ControlLightLight
        bookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        bookDGV.Columns.AddRange(New DataGridViewColumn() {Index, ID, book_unique_id, book_image, book_name, book_desc, author, date_published, genre, initial_quantity, total_quantity})
        bookDGV.GridColor = SystemColors.ControlLightLight
        bookDGV.Location = New Point(0, 40)
        bookDGV.Name = "bookDGV"
        bookDGV.RowTemplate.Height = 25
        bookDGV.Size = New Size(804, 411)
        bookDGV.TabIndex = 0
        ' 
        ' Index
        ' 
        Index.HeaderText = "No"
        Index.Name = "Index"
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.Visible = False
        ' 
        ' book_unique_id
        ' 
        book_unique_id.HeaderText = "book_unique_id"
        book_unique_id.Name = "book_unique_id"
        ' 
        ' book_image
        ' 
        book_image.HeaderText = "book_image"
        book_image.Name = "book_image"
        book_image.Visible = False
        ' 
        ' book_name
        ' 
        book_name.HeaderText = "book_name"
        book_name.Name = "book_name"
        ' 
        ' book_desc
        ' 
        book_desc.HeaderText = "book_desc"
        book_desc.Name = "book_desc"
        ' 
        ' author
        ' 
        author.HeaderText = "author"
        author.Name = "author"
        ' 
        ' date_published
        ' 
        date_published.HeaderText = "date_published"
        date_published.Name = "date_published"
        ' 
        ' genre
        ' 
        genre.HeaderText = "genre"
        genre.Name = "genre"
        ' 
        ' initial_quantity
        ' 
        initial_quantity.HeaderText = "initial_quantity"
        initial_quantity.Name = "initial_quantity"
        ' 
        ' total_quantity
        ' 
        total_quantity.HeaderText = "total_quantity"
        total_quantity.Name = "total_quantity"
        ' 
        ' RoundedButtonDocker1
        ' 
        RoundedButtonDocker1.BackColor = Color.Teal
        RoundedButtonDocker1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        RoundedButtonDocker1.ForeColor = SystemColors.ControlLightLight
        RoundedButtonDocker1.Location = New Point(676, 5)
        RoundedButtonDocker1.Margin = New Padding(0)
        RoundedButtonDocker1.Name = "RoundedButtonDocker1"
        RoundedButtonDocker1.Size = New Size(112, 31)
        RoundedButtonDocker1.TabIndex = 2
        RoundedButtonDocker1.Text = "add books"
        RoundedButtonDocker1.UseVisualStyleBackColor = False
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(242, 7)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(145, 23)
        searchBox.TabIndex = 3
        ' 
        ' next_btn
        ' 
        next_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        next_btn.Location = New Point(727, 408)
        next_btn.Name = "next_btn"
        next_btn.Size = New Size(61, 24)
        next_btn.TabIndex = 4
        next_btn.Text = "Next"
        next_btn.UseVisualStyleBackColor = True
        ' 
        ' prev_btn
        ' 
        prev_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        prev_btn.Location = New Point(660, 408)
        prev_btn.Name = "prev_btn"
        prev_btn.Size = New Size(61, 24)
        prev_btn.TabIndex = 5
        prev_btn.Text = "Preview"
        prev_btn.UseVisualStyleBackColor = True
        ' 
        ' textPage
        ' 
        textPage.Anchor = AnchorStyles.Bottom
        textPage.AutoSize = True
        textPage.Location = New Point(415, 413)
        textPage.Name = "textPage"
        textPage.Size = New Size(41, 15)
        textPage.TabIndex = 6
        textPage.Text = "Label1"
        ' 
        ' books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(textPage)
        Controls.Add(prev_btn)
        Controls.Add(next_btn)
        Controls.Add(searchBox)
        Controls.Add(RoundedButtonDocker1)
        Controls.Add(bookDGV)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "books"
        Text = "books"
        CType(bookDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bookDGV As DataGridView
    Friend WithEvents RoundedButtonDocker1 As RoundedButtonDocker
    Friend WithEvents searchBox As TextBox
    Friend WithEvents next_btn As Button
    Friend WithEvents prev_btn As Button
    Friend WithEvents textPage As Label
    Friend WithEvents Index As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents book_unique_id As DataGridViewTextBoxColumn
    Friend WithEvents book_image As DataGridViewTextBoxColumn
    Friend WithEvents book_name As DataGridViewTextBoxColumn
    Friend WithEvents book_desc As DataGridViewTextBoxColumn
    Friend WithEvents author As DataGridViewTextBoxColumn
    Friend WithEvents date_published As DataGridViewTextBoxColumn
    Friend WithEvents genre As DataGridViewTextBoxColumn
    Friend WithEvents initial_quantity As DataGridViewTextBoxColumn
    Friend WithEvents total_quantity As DataGridViewTextBoxColumn
End Class
