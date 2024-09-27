Module PathDir

    Private DestinationPath As String = "C:\Users\asjo\source\repos\LibrarySytem\assets\"
    Private UploadDestination As String = "C:\Users\asjo\source\repos\LibrarySytem\assets\upload"
    Public Function getDestinationPath()
        Return DestinationPath
    End Function
    Public Function getUploadDestinationPath()
        Return UploadDestination
    End Function
End Module
