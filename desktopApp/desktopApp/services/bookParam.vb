Module bookParam
    Private paramBookUID As String = ""
    Private paramBookName As String = ""
    Private paramBookimage As String = ""
    Private paramBookdesc As String = ""
    Private paramBookauthor As String = ""
    Private paramBookdate_publ As String = ""
    Private paramBookgenre As String = ""
    Private paramBookIquantity As Integer = 0
    Private paramBookTquantity As Integer = 0
    Public Sub setBookParam(BUID As String, BIM As String, BN As String, BDes As String, BAuth As String, BDat As String, BGen As String, IQ As Integer, TQ As Integer)
        paramBookUID = BUID
        paramBookName = BN
        paramBookimage = BIM
        paramBookdesc = BDes
        paramBookauthor = BAuth
        paramBookdate_publ = BDat
        paramBookgenre = BGen
        paramBookIquantity = IQ
        paramBookTquantity = TQ
    End Sub
    Public Function getBUID()
        Return paramBookUID
    End Function
    Public Function getBName()
        Return paramBookName
    End Function
    Public Function getBImage()
        Return paramBookimage
    End Function
    Public Function getBDesc()
        Return paramBookdesc
    End Function
    Public Function getBAuth()
        Return paramBookauthor
    End Function
    Public Function getBDateD()
        Return paramBookdate_publ
    End Function
    Public Function getBGen()
        Return paramBookgenre
    End Function
    Public Function getBIquan()
        Return paramBookIquantity
    End Function
    Public Function getBTquan()
        Return paramBookTquantity
    End Function
End Module
