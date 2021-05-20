Public Class frmEx2_2
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("string.Format を使って書くと...!")
        Dim Name As String = "堀内"
        Dim Hour As Integer = DateTime.Now.Hour
        Dim Message As String = String.Format("こんにちは、{0}さん。今は{1}時です。", Name, Hour)
        Console.WriteLine(Message)

        Console.WriteLine(" 文字列補間式 $ を使って書くと")
        Console.WriteLine(" 文字列の先頭に $ をつけるだけオーケー。_
                            字列の中に直接埋め込むことができます。")
        Console.WriteLine($"こんにちは、{Name}さん。 今は{Hour}時です。")


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

    Private Sub btnConstructer_Click(sender As Object, e As EventArgs) Handles btnConstructer.Click
        'VB.NET コンストラクタのサンプル
        'Integer型の引数のとき
        '  https://itsakura.com/vbnet-constructor

        Dim c1 As New Class1(1)
        Console.WriteLine(c1.ColorName) '赤
    End Sub

    Private Sub btnConstractor2_Click(sender As Object, e As EventArgs) Handles btnConstractor2.Click
        'VB.NET コンストラクタのサンプル
        'String型の引数のとき
        '  https://itsakura.com/vbnet-constructor

        Dim c1 As New Class1("Hanako")
        Console.WriteLine(c1.ColorName) '

    End Sub
End Class