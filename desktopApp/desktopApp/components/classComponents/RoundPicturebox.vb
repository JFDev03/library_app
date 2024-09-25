Imports System.Drawing.Drawing2D

Public Class RoundPicturebox
    Inherits PictureBox

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        Dim grpath As GraphicsPath = New GraphicsPath()
        grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        Me.Region = New Region(grpath)
        MyBase.OnPaint(pe)

    End Sub
End Class
