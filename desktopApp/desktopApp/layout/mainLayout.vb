
Public Class mainLayout
    Dim Radius As New roundedForms()
    Private AForm As Form
    Private currentButton As Button
    Private isFirstLoad As Boolean = True
    Public connectionSOcket As Task

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Radius.RoundedPanel(sidebar)
        Radius.RoundedPanel(mainPages)
        Radius.RoundedLeftPanel(logoPanel, 20)
        Radius.RoundedRightPanel(navigationPanel, 20)
        currentButton = New Button()
    End Sub

    Private Sub invokeData()
        ' Check if Invoke is needed only if calling from another thread
        If Me.InvokeRequired Then
            username_label.Invoke(Sub()
                                      username_label.Text = getFUllname()
                                  End Sub)
            profilePicture.Invoke(Sub()
                                      profilePicture.ImageLocation = getDestinationPath() + getProfile()
                                  End Sub)
        Else
            ' Direct update without invoke
            username_label.Text = getFUllname()
            profilePicture.ImageLocation = getDestinationPath() + getProfile()
        End If
    End Sub

    Private Sub mainLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        invokeData()
    End Sub

    Private Sub mainLayout_Visibility(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        invokeData()
        If Me.Visible AndAlso isFirstLoad Then
            isFirstLoad = False ' Set the flag to false after the first load
            OpenChildForm(New dashboard(), dashboard_link) ' Load the dashboard form first
        End If
    End Sub

    Private Sub signoutLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signoutLink.LinkClicked
        clearSessions()
        Me.Close()
        Dim form As New Form1
        form.Show()
    End Sub

    Public Sub OpenChildForm(ByVal childForm As Form, ByVal sender As Object)
        ' Check if the form is already open and close it if necessary
        If AForm IsNot Nothing Then
            AForm.Close()
        End If

        ' Create a new instance of the child form to prevent accessing disposed objects
        If TypeOf sender Is LinkLabel Then
            If sender Is books_link Then
                childForm = New books()
            ElseIf sender Is borrow_link Then
                childForm = New borrow()
            ElseIf sender Is dashboard_link Then
                childForm = New dashboard()
            End If
        End If

        ' Activate the appropriate button or link label
        If TypeOf sender Is LinkLabel Then
            ActivateLinkLabel(sender)
        End If

        AForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.mainPages.Controls.Add(childForm)
        Me.mainPages.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub



    Public Sub ActivateLinkLabel(ByVal linkSender As Object)
        If linkSender IsNot Nothing AndAlso TypeOf linkSender Is LinkLabel Then
            Dim senderLink As LinkLabel = CType(linkSender, LinkLabel)
            ' Optional: Reset all other LinkLabels to default style
            ResetLinkLabelStyles()

            ' Style the active LinkLabel
            senderLink.LinkColor = Color.FromArgb(6, 83, 99)
            senderLink.BackColor = Color.White
            senderLink.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold = 0.9, System.Drawing.GraphicsUnit.Point, CByte(0))
        End If
    End Sub

    Private Sub ResetLinkLabelStyles()
        ' Iterate through all controls in sidebar and reset LinkLabel styles
        For Each ctrl As Control In sidebar.Controls
            ' Check if the control is a LinkLabel and not the signoutLink
            If TypeOf ctrl Is LinkLabel AndAlso Not ctrl.Equals(signoutLink) Then
                Dim link As LinkLabel = CType(ctrl, LinkLabel)
                link.LinkColor = Color.Black
                link.BackColor = Color.White
                link.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold = 0.9, GraphicsUnit.Point, CByte(0))
            End If
        Next
    End Sub




    Private Sub DisableButton()
        For Each previousBtn As Control In sidebar.Controls
            If previousBtn.[GetType]() = GetType(Button) Then
                previousBtn.ForeColor = Color.SteelBlue
                previousBtn.BackColor = Color.White
                previousBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            End If
        Next
    End Sub

    Private Sub books_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles books_link.LinkClicked
        OpenChildForm(New books(), sender)
    End Sub

    Private Sub borrow_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles borrow_link.LinkClicked
        OpenChildForm(New borrow(), sender)
    End Sub

    Private Sub dashboard_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles dashboard_link.LinkClicked
        OpenChildForm(New dashboard(), sender)
    End Sub
End Class
