<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrow
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
        textPage = New Label()
        prev_btn = New Button()
        next_btn = New Button()
        searchBox = New TextBox()
        borrowDGV = New DataGridView()
        Index = New DataGridViewTextBoxColumn()
        ID = New DataGridViewTextBoxColumn()
        Employee_id = New DataGridViewTextBoxColumn()
        book_unique_id = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        date_borrowed = New DataGridViewTextBoxColumn()
        date_returned = New DataGridViewTextBoxColumn()
        CType(borrowDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' textPage
        ' 
        textPage.Anchor = AnchorStyles.Bottom
        textPage.AutoSize = True
        textPage.Location = New Point(413, 410)
        textPage.Name = "textPage"
        textPage.Size = New Size(41, 15)
        textPage.TabIndex = 11
        textPage.Text = "Label1"
        ' 
        ' prev_btn
        ' 
        prev_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        prev_btn.Location = New Point(658, 403)
        prev_btn.Name = "prev_btn"
        prev_btn.Size = New Size(61, 24)
        prev_btn.TabIndex = 10
        prev_btn.Text = "Preview"
        prev_btn.UseVisualStyleBackColor = True
        ' 
        ' next_btn
        ' 
        next_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        next_btn.Location = New Point(725, 403)
        next_btn.Name = "next_btn"
        next_btn.Size = New Size(61, 24)
        next_btn.TabIndex = 9
        next_btn.Text = "Next"
        next_btn.UseVisualStyleBackColor = True
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(240, 6)
        searchBox.Name = "searchBox"
        searchBox.Size = New Size(145, 23)
        searchBox.TabIndex = 8
        ' 
        ' borrowDGV
        ' 
        borrowDGV.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        borrowDGV.BackgroundColor = SystemColors.ControlLightLight
        borrowDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        borrowDGV.Columns.AddRange(New DataGridViewColumn() {Index, ID, Employee_id, book_unique_id, Quantity, Status, date_borrowed, date_returned})
        borrowDGV.GridColor = SystemColors.ControlLightLight
        borrowDGV.Location = New Point(-2, 39)
        borrowDGV.Name = "borrowDGV"
        borrowDGV.RowTemplate.Height = 25
        borrowDGV.Size = New Size(804, 411)
        borrowDGV.TabIndex = 7
        ' 
        ' Index
        ' 
        Index.HeaderText = "No."
        Index.Name = "Index"
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.Visible = False
        ' 
        ' Employee_id
        ' 
        Employee_id.HeaderText = "Employee_id"
        Employee_id.Name = "Employee_id"
        ' 
        ' book_unique_id
        ' 
        book_unique_id.HeaderText = "book_unique_id"
        book_unique_id.Name = "book_unique_id"
        ' 
        ' Quantity
        ' 
        Quantity.HeaderText = "Quantity"
        Quantity.Name = "Quantity"
        ' 
        ' Status
        ' 
        Status.HeaderText = "Status"
        Status.Name = "Status"
        ' 
        ' date_borrowed
        ' 
        date_borrowed.HeaderText = "date_borrowed"
        date_borrowed.Name = "date_borrowed"
        ' 
        ' date_returned
        ' 
        date_returned.HeaderText = "date_returned"
        date_returned.Name = "date_returned"
        ' 
        ' borrow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(800, 450)
        Controls.Add(textPage)
        Controls.Add(prev_btn)
        Controls.Add(next_btn)
        Controls.Add(searchBox)
        Controls.Add(borrowDGV)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.None
        Name = "borrow"
        Text = "borrow"
        CType(borrowDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents textPage As Label
    Friend WithEvents prev_btn As Button
    Friend WithEvents next_btn As Button
    Friend WithEvents searchBox As TextBox
    Friend WithEvents borrowDGV As DataGridView
    Friend WithEvents Index As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Employee_id As DataGridViewTextBoxColumn
    Friend WithEvents book_unique_id As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents date_borrowed As DataGridViewTextBoxColumn
    Friend WithEvents date_returned As DataGridViewTextBoxColumn
End Class
