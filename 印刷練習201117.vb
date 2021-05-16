
Public Class 印刷練習201117
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f As New Font("ＭＳ 明朝", 64, FontStyle.Bold)
        e.Graphics.DrawString("こんにちは", f, Brushes.Red, 10, 10)
    End Sub

    Private Sub 印刷練習201117_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        ' 音声のテスト
        '
        ' Dim Computer As New SpeechLib.SpVoice

        ' Computer.Speak("Hello, こんにちは。I am " & Environment.UserName)
    End Sub
End Class

'参考page
'    http://rucio.o.oo7.jp/main/dotnet/shokyu/standard35.htm