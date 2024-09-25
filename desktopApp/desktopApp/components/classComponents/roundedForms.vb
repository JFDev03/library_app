Imports System.Drawing.Drawing2D

Public Class roundedForms

    Private Function GetRoundedRectangle(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        path.StartFigure()

        'top left corner
        path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90)
        path.AddLine(rect.Left + radius, rect.Top, rect.Right - radius, rect.Top)

        'top right corner
        path.AddArc(rect.Right - 2 * radius, rect.Top, radius * 2, radius * 2, 270, 90)
        path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius)

        'bottom right corner
        path.AddArc(rect.Right - 2 * radius, rect.Bottom - 2 * radius, radius * 2, radius * 2, 0, 90)
        path.AddLine(rect.Right - radius, rect.Bottom, rect.Left + radius, rect.Bottom)

        'bottom left corner
        path.AddArc(rect.Left, rect.Bottom - 2 * radius, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()

        Return path
    End Function

    Public Sub RoundedLeftPanel(obj As Panel, radius As Integer)
        Dim rect As Rectangle = obj.ClientRectangle
        Dim path As New GraphicsPath()
        path.StartFigure()

        ' Top left corner
        path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90)

        ' Line across the top
        path.AddLine(rect.Left + radius, rect.Top, rect.Right, rect.Top)

        ' Line down the left side
        path.AddLine(rect.Left, rect.Top + radius, rect.Left, rect.Bottom - radius)

        ' Bottom left corner
        path.AddArc(rect.Left, rect.Bottom - 2 * radius, radius * 2, radius * 2, 90, 90)

        ' Line across the bottom to the right side
        path.AddLine(rect.Left + radius, rect.Bottom, rect.Right, rect.Bottom)

        ' Line up the right side (no arc, just a straight line)
        path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Top)

        path.CloseFigure()

        obj.Region = New Region(path)
    End Sub


    Public Sub RoundedRightPanel(obj As Panel, radius As Integer)
        Dim rect As Rectangle = obj.ClientRectangle
        Dim path As New GraphicsPath()
        path.StartFigure()

        ' Top right corner
        path.AddArc(rect.Right - 2 * radius, rect.Top, radius * 2, radius * 2, 270, 90)

        ' Line down the right side
        path.AddLine(rect.Right, rect.Top + radius, rect.Right, rect.Bottom - radius)

        ' Bottom right corner
        path.AddArc(rect.Right - 2 * radius, rect.Bottom - 2 * radius, radius * 2, radius * 2, 0, 90)

        ' Line across the bottom to the left side
        path.AddLine(rect.Right - radius, rect.Bottom, rect.Left, rect.Bottom)

        ' Line up the left side (no arc, just a straight line)
        path.AddLine(rect.Left, rect.Bottom, rect.Left, rect.Top)

        path.CloseFigure()

        obj.Region = New Region(path)
    End Sub





    Public Sub RoundedForms(obj As Form)
            Dim path As GraphicsPath = GetRoundedRectangle(obj.ClientRectangle, 20)
            obj.Region = New Region(path)
        End Sub

        Public Sub RoundedFormsDocker(obj As Form)
            Dim path As GraphicsPath = GetRoundedRectangle(obj.ClientRectangle, 10)
            obj.Region = New Region(path)
        End Sub


        Public Sub RoundedPanel(obj As Panel)
            Dim path As GraphicsPath = GetRoundedRectangle(obj.ClientRectangle, 20)
            obj.Region = New Region(path)
        End Sub

        Public Sub RoundDataGridView(obj As DataGridView)
            Dim path As GraphicsPath = GetRoundedRectangle(obj.ClientRectangle, 20)
            obj.Region = New Region(path)
        End Sub

    Public Sub RoundedPanelModuleName(obj As Panel)
        Dim path As GraphicsPath = GetRoundedRectangle(obj.ClientRectangle, 10)
        obj.Region = New Region(path)
    End Sub
End Class
