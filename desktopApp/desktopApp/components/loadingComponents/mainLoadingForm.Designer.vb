<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainLoadingForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(mainLoadingForm))
        background_worker = New ComponentModel.BackgroundWorker()
        progressbar = New ProgressBar()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' background_worker
        ' 
        ' 
        ' progressbar
        ' 
        progressbar.Location = New Point(0, 173)
        progressbar.Name = "progressbar"
        progressbar.Size = New Size(365, 20)
        progressbar.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(61, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 25)
        Label1.TabIndex = 1
        Label1.Text = "Opening the Application..."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(70, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(232, 134)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' mainLoadingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(365, 192)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(progressbar)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "mainLoadingForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "mainLoadingForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents background_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents progressbar As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
