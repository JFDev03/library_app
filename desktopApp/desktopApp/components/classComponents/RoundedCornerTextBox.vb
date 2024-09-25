Imports System.Runtime.InteropServices

Public Class RoundedCornerTextBox
    Inherits TextBox

    Private _padding As New Padding(10)

    Public Overloads Property Padding As Padding
        Get
            Return _padding
        End Get
        Set(value As Padding)
            _padding = value
            UpdateRegion()
        End Set
    End Property

    Private Sub UpdateRegion()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(Padding.Left, Padding.Top, Me.Width - Padding.Right, Me.Height - Padding.Bottom, 15, 15))
    End Sub

    <DllImport("gdi32.dll", SetLastError:=True)>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr
    End Function

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Me.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, Me.Width, Me.Height, 15, 15))
    End Sub
End Class
