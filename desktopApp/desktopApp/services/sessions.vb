Module sessions
    Private profile_picture As String = ""
    Private fullname As String = ""
    Private role As String = ""

    Public Sub setSessions(profile As String, fname As String, userrole As String)
        profile_picture = profile
        fullname = fname
        role = userrole
    End Sub

    Public Function getProfile()
        Return profile_picture
    End Function

    Public Function getFUllname()
        Return fullname
    End Function

    Public Function getRole()
        Return role
    End Function

    Public Sub clearSessions()
        profile_picture = ""
        fullname = ""
        role = ""
    End Sub
End Module
