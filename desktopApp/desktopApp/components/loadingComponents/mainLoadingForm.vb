Imports System.ComponentModel

Public Class mainLoadingForm
    Public Sub New()
        InitializeComponent()
        background_worker.WorkerReportsProgress = True ' Enable progress reporting
    End Sub

    Private Sub mainLoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        background_worker.RunWorkerAsync()
    End Sub

    Private Sub background_worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles background_worker.DoWork
        For i As Integer = 1 To 100
            ' Simulate a long-running task
            System.Threading.Thread.Sleep(50) ' Simulating work
            background_worker.ReportProgress(i) ' Report progress
        Next
    End Sub

    Private Sub background_worker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles background_worker.ProgressChanged
        progressbar.Value = e.ProgressPercentage
    End Sub

    Private Sub background_worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles background_worker.RunWorkerCompleted
        Me.Close()
    End Sub
End Class
