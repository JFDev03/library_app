<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainLayout
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(mainLayout))
        TableLayoutPanel1 = New TableLayoutPanel()
        sidebar = New Panel()
        PictureBox5 = New PictureBox()
        signoutLink = New LinkLabel()
        PictureBox4 = New PictureBox()
        borrow_link = New LinkLabel()
        PictureBox3 = New PictureBox()
        books_link = New LinkLabel()
        PictureBox2 = New PictureBox()
        dashboard_link = New LinkLabel()
        logoPanel = New Panel()
        PictureBox1 = New PictureBox()
        mainPages = New Panel()
        navigationPanel = New Panel()
        username_label = New Label()
        profilePicture = New RoundPicturebox()
        Label1 = New Label()
        Panel5 = New Panel()
        NotifyIcon = New NotifyIcon(components)
        TableLayoutPanel1.SuspendLayout()
        sidebar.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        logoPanel.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        navigationPanel.SuspendLayout()
        CType(profilePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 0F))
        TableLayoutPanel1.Controls.Add(sidebar, 1, 3)
        TableLayoutPanel1.Controls.Add(logoPanel, 1, 1)
        TableLayoutPanel1.Controls.Add(mainPages, 3, 3)
        TableLayoutPanel1.Controls.Add(navigationPanel, 3, 1)
        TableLayoutPanel1.Controls.Add(Panel5, 2, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle())
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 0F))
        TableLayoutPanel1.Size = New Size(1212, 749)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' sidebar
        ' 
        sidebar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        sidebar.BackColor = SystemColors.ControlLightLight
        sidebar.Controls.Add(PictureBox5)
        sidebar.Controls.Add(signoutLink)
        sidebar.Controls.Add(PictureBox4)
        sidebar.Controls.Add(borrow_link)
        sidebar.Controls.Add(PictureBox3)
        sidebar.Controls.Add(books_link)
        sidebar.Controls.Add(PictureBox2)
        sidebar.Controls.Add(dashboard_link)
        sidebar.Location = New Point(20, 179)
        sidebar.Margin = New Padding(0)
        sidebar.Name = "sidebar"
        sidebar.Size = New Size(226, 545)
        sidebar.TabIndex = 0
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(2, 473)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 50)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 7
        PictureBox5.TabStop = False
        ' 
        ' signoutLink
        ' 
        signoutLink.ActiveLinkColor = Color.FromArgb(CByte(6), CByte(83), CByte(99))
        signoutLink.AutoSize = True
        signoutLink.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        signoutLink.LinkBehavior = LinkBehavior.NeverUnderline
        signoutLink.LinkColor = Color.FromArgb(CByte(123), CByte(36), CByte(28))
        signoutLink.Location = New Point(44, 474)
        signoutLink.Name = "signoutLink"
        signoutLink.Size = New Size(147, 45)
        signoutLink.TabIndex = 6
        signoutLink.TabStop = True
        signoutLink.Text = "Sign Out"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(5, 177)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 5
        PictureBox4.TabStop = False
        ' 
        ' borrow_link
        ' 
        borrow_link.ActiveLinkColor = Color.FromArgb(CByte(6), CByte(83), CByte(99))
        borrow_link.AutoSize = True
        borrow_link.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        borrow_link.LinkBehavior = LinkBehavior.NeverUnderline
        borrow_link.LinkColor = Color.Black
        borrow_link.Location = New Point(47, 178)
        borrow_link.Name = "borrow_link"
        borrow_link.Size = New Size(125, 45)
        borrow_link.TabIndex = 4
        borrow_link.TabStop = True
        borrow_link.Text = "Borrow"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(5, 98)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 50)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' books_link
        ' 
        books_link.ActiveLinkColor = Color.FromArgb(CByte(6), CByte(83), CByte(99))
        books_link.AutoSize = True
        books_link.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        books_link.LinkBehavior = LinkBehavior.NeverUnderline
        books_link.LinkColor = Color.Black
        books_link.Location = New Point(47, 99)
        books_link.Name = "books_link"
        books_link.Size = New Size(108, 45)
        books_link.TabIndex = 2
        books_link.TabStop = True
        books_link.Text = "Books"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' dashboard_link
        ' 
        dashboard_link.ActiveLinkColor = Color.FromArgb(CByte(6), CByte(83), CByte(99))
        dashboard_link.AutoSize = True
        dashboard_link.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point)
        dashboard_link.LinkBehavior = LinkBehavior.NeverUnderline
        dashboard_link.LinkColor = Color.Black
        dashboard_link.Location = New Point(47, 21)
        dashboard_link.Name = "dashboard_link"
        dashboard_link.Size = New Size(179, 45)
        dashboard_link.TabIndex = 0
        dashboard_link.TabStop = True
        dashboard_link.Text = "Dashboard"
        ' 
        ' logoPanel
        ' 
        logoPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        logoPanel.BackColor = SystemColors.ControlLightLight
        logoPanel.Controls.Add(PictureBox1)
        logoPanel.Location = New Point(20, 20)
        logoPanel.Margin = New Padding(0)
        logoPanel.Name = "logoPanel"
        logoPanel.Size = New Size(226, 139)
        logoPanel.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(15, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(197, 123)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' mainPages
        ' 
        mainPages.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        mainPages.BackColor = SystemColors.ControlLightLight
        mainPages.Location = New Point(266, 179)
        mainPages.Margin = New Padding(0)
        mainPages.Name = "mainPages"
        mainPages.Size = New Size(922, 545)
        mainPages.TabIndex = 2
        ' 
        ' navigationPanel
        ' 
        navigationPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        navigationPanel.BackColor = SystemColors.ControlLightLight
        navigationPanel.Controls.Add(username_label)
        navigationPanel.Controls.Add(profilePicture)
        navigationPanel.Controls.Add(Label1)
        navigationPanel.Location = New Point(266, 20)
        navigationPanel.Margin = New Padding(0)
        navigationPanel.Name = "navigationPanel"
        navigationPanel.Size = New Size(922, 139)
        navigationPanel.TabIndex = 3
        ' 
        ' username_label
        ' 
        username_label.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        username_label.AutoSize = True
        username_label.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        username_label.Location = New Point(814, 96)
        username_label.Name = "username_label"
        username_label.Size = New Size(76, 21)
        username_label.TabIndex = 2
        username_label.Text = "unknown"
        username_label.TextAlign = ContentAlignment.TopCenter
        ' 
        ' profilePicture
        ' 
        profilePicture.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        profilePicture.InitialImage = Nothing
        profilePicture.Location = New Point(819, 27)
        profilePicture.Name = "profilePicture"
        profilePicture.Size = New Size(64, 64)
        profilePicture.SizeMode = PictureBoxSizeMode.StretchImage
        profilePicture.TabIndex = 1
        profilePicture.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(6), CByte(83), CByte(99))
        Label1.Location = New Point(3, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(654, 84)
        Label1.TabIndex = 0
        Label1.Text = "Library System Admin"
        ' 
        ' Panel5
        ' 
        Panel5.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel5.BackColor = SystemColors.ControlLightLight
        Panel5.Location = New Point(246, 20)
        Panel5.Margin = New Padding(0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(20, 139)
        Panel5.TabIndex = 4
        ' 
        ' NotifyIcon
        ' 
        NotifyIcon.BalloonTipTitle = "New Notification"
        NotifyIcon.Text = "NotifyIcon1"
        NotifyIcon.Visible = True
        ' 
        ' mainLayout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.SteelBlue
        ClientSize = New Size(1212, 749)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "mainLayout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "mainLayout"
        TableLayoutPanel1.ResumeLayout(False)
        sidebar.ResumeLayout(False)
        sidebar.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        logoPanel.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        navigationPanel.ResumeLayout(False)
        navigationPanel.PerformLayout()
        CType(profilePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents sidebar As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents mainPages As Panel
    Friend WithEvents navigationPanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents profilePicture As RoundPicturebox
    Friend WithEvents Label1 As Label
    Friend WithEvents username_label As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dashboard_link As LinkLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents signoutLink As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents borrow_link As LinkLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents books_link As LinkLabel
    Friend WithEvents NotifyIcon As NotifyIcon
End Class
