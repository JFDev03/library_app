Public Class mainLayout
    Dim Radius As New roundedForms()
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Radius.RoundedPanel(sidebar)
        Radius.RoundedPanel(mainPages)
        Radius.RoundedLeftPanel(logoPanel, 20)
        Radius.RoundedRightPanel(navigationPanel, 20)

    End Sub
End Class