Imports System.Drawing.Drawing2D

Public Class RoundedButtonDocker
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        Dim path As New GraphicsPath()
        Dim radius As Integer = CInt(Math.Min(Me.Width, Me.Height) * 0.15)


        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90)
        path.AddArc(Me.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90)
        path.AddArc(Me.Width - (radius * 2), Me.Height - (radius * 2), radius * 2, radius * 2, 0, 90)
        path.AddArc(0, Me.Height - (radius * 2), radius * 2, radius * 2, 90, 90)
        path.CloseFigure()


        Me.Region = New Region(path)


        Dim borderPen As New Pen(Me.FlatAppearance.BorderColor, 2)
        pevent.Graphics.DrawPath(borderPen, path)
    End Sub
End Class
