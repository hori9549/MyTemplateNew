Public Class frmEx2_2
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Hello World!")
        Dim s1 As String = "foo"
        Dim s2 As String = "bar"
        Dim s3 As String = "baz"

        Console.WriteLine("Compare({0}, {1}) : {2}", s1, s2, String.Compare(s1, s2))
        Console.WriteLine("Compare({0}, {1}) : {2}", s1, s3, String.Compare(s1, s3))
        Console.WriteLine("Compare({0}, {1}) : {2}", s2, s3, String.Compare(s2, s3))
        Console.WriteLine("Compare({0}, {1}) : {2}", s2, s2, String.Compare(s2, s2))

        Console.WriteLine("Equals({0}, {1}) : {2}", s1, s2, String.Equals(s1, s2))
        Console.WriteLine("Equals({0}, {1}) : {2}", s1, s3, String.Equals(s1, s3))
        Console.WriteLine("Equals({0}, {1}) : {2}", s2, s3, String.Equals(s2, s3))
        Console.WriteLine("Equals({0}, {1}) : {2}", s2, s2, String.Equals(s2, s2))
    End Sub

    Private Sub btn閉じる_Click(sender As Object, e As EventArgs) Handles btn閉じる.Click
        Me.Close()
    End Sub
End Class