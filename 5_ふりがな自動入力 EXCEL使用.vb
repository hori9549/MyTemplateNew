
Public Class frmふりがな自動入力_EXCEL使用
    Private Sub ふりがな自動入力_EXCEL使用_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt変換元.Select()
    End Sub
    Private Sub KanjiToKana()

        Dim objExcel As New Microsoft.Office.Interop.Excel.Application



        Dim stKanji As String = txt変換元.Text

        Dim stKana As String



        stKana = objExcel.GetPhonetic(stKanji)
        txt結果.Text = stKana
        MessageBox.Show(stKana, "結果", MessageBoxButtons.OK)

    End Sub

    Private Sub btn変換_Click(sender As Object, e As EventArgs) Handles btn変換.Click
        Call KanjiToKana()
    End Sub
End Class