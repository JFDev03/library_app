<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        total_booksPanel = New Panel()
        Borrowed_booksPanel = New Panel()
        returned_booksPanel = New Panel()
        Label1 = New Label()
        totalBooks = New Label()
        total_borrowed = New Label()
        Label3 = New Label()
        total_returned = New Label()
        Label4 = New Label()
        total_booksPanel.SuspendLayout()
        Borrowed_booksPanel.SuspendLayout()
        returned_booksPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' total_booksPanel
        ' 
        total_booksPanel.BackColor = Color.SteelBlue
        total_booksPanel.Controls.Add(totalBooks)
        total_booksPanel.Controls.Add(Label1)
        total_booksPanel.Location = New Point(39, 34)
        total_booksPanel.Name = "total_booksPanel"
        total_booksPanel.Size = New Size(161, 100)
        total_booksPanel.TabIndex = 0
        ' 
        ' Borrowed_booksPanel
        ' 
        Borrowed_booksPanel.BackColor = Color.SteelBlue
        Borrowed_booksPanel.Controls.Add(total_borrowed)
        Borrowed_booksPanel.Controls.Add(Label3)
        Borrowed_booksPanel.Location = New Point(313, 34)
        Borrowed_booksPanel.Name = "Borrowed_booksPanel"
        Borrowed_booksPanel.Size = New Size(165, 100)
        Borrowed_booksPanel.TabIndex = 1
        ' 
        ' returned_booksPanel
        ' 
        returned_booksPanel.BackColor = Color.SteelBlue
        returned_booksPanel.Controls.Add(total_returned)
        returned_booksPanel.Controls.Add(Label4)
        returned_booksPanel.Location = New Point(596, 34)
        returned_booksPanel.Name = "returned_booksPanel"
        returned_booksPanel.Size = New Size(165, 100)
        returned_booksPanel.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(27, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 25)
        Label1.TabIndex = 0
        Label1.Text = "Total Books"
        ' 
        ' totalBooks
        ' 
        totalBooks.AutoSize = True
        totalBooks.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        totalBooks.ForeColor = SystemColors.ControlLightLight
        totalBooks.Location = New Point(44, 42)
        totalBooks.Name = "totalBooks"
        totalBooks.Size = New Size(70, 25)
        totalBooks.TabIndex = 1
        totalBooks.Text = "Label2"
        ' 
        ' total_borrowed
        ' 
        total_borrowed.AutoSize = True
        total_borrowed.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        total_borrowed.ForeColor = SystemColors.ControlLightLight
        total_borrowed.Location = New Point(42, 41)
        total_borrowed.Name = "total_borrowed"
        total_borrowed.Size = New Size(70, 25)
        total_borrowed.TabIndex = 3
        total_borrowed.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(12, 15)
        Label3.Name = "Label3"
        Label3.Size = New Size(149, 25)
        Label3.TabIndex = 2
        Label3.Text = "Total Borrowed"
        ' 
        ' total_returned
        ' 
        total_returned.AutoSize = True
        total_returned.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        total_returned.ForeColor = SystemColors.ControlLightLight
        total_returned.Location = New Point(43, 41)
        total_returned.Name = "total_returned"
        total_returned.Size = New Size(70, 25)
        total_returned.TabIndex = 5
        total_returned.Text = "Label2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(13, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 25)
        Label4.TabIndex = 4
        Label4.Text = "Total Returned"
        ' 
        ' dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(800, 450)
        Controls.Add(returned_booksPanel)
        Controls.Add(Borrowed_booksPanel)
        Controls.Add(total_booksPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "dashboard"
        Text = "dashboard"
        total_booksPanel.ResumeLayout(False)
        total_booksPanel.PerformLayout()
        Borrowed_booksPanel.ResumeLayout(False)
        Borrowed_booksPanel.PerformLayout()
        returned_booksPanel.ResumeLayout(False)
        returned_booksPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents total_booksPanel As Panel
    Friend WithEvents Borrowed_booksPanel As Panel
    Friend WithEvents returned_booksPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents totalBooks As Label
    Friend WithEvents total_borrowed As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents total_returned As Label
    Friend WithEvents Label4 As Label
End Class
