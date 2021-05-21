Public Class clsTest
    Private str As String
    Private obj As Object

    Public Property test1() As String
        Get
            Return str
        End Get
        Set(ByVal Value As String)
            str = Value
        End Set
    End Property

    Public Property test2() As Object
        Get
            Return obj
        End Get
        Set(ByVal Value As Object)
            obj = Value
        End Set
    End Property

    Public Sub conWrite(ByVal str2 As String)
        Trace.WriteLine(str2)

    End Sub

End Class
