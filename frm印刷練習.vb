Imports System.IO
Imports System.Drawing.Printing

Public Class frm印刷練習
    Private StrPrint As String                'プリントアウトする文字列を保持するフィールド
    Private PageSetting As New PageSettings   'ページ設定の情報を保持するフィールド
    Dim img As Image                          '画像を読み込む

    Private Sub PrintDocument1_PrintPage(sender As Object,
                                         e As PrintPageEventArgs
                                         ) Handles PrintDocument1.PrintPage
        Dim fontSize As New Font("MS UI Gothic", 11)
        Dim numberChars As Integer
        Dim numberLines As Integer
        Dim printString As String
        Dim format As New StringFormat

        Dim rectSquare As New RectangleF(
            e.MarginBounds.Left,
            e.MarginBounds.Top,
            e.MarginBounds.Width,
            e.MarginBounds.Height
            )

        Dim squareSize As New SizeF(
            e.MarginBounds.Width,
            e.MarginBounds.Height - fontSize.GetHeight(e.Graphics))

        e.Graphics.MeasureString(
            StrPrint,
            fontSize,
            squareSize,
            format,
            numberChars,
            numberLines
            )

        printString = StrPrint.Substring(0, numberChars)

        e.Graphics.DrawString(
            printString,
            fontSize,
            Brushes.Black,
            rectSquare,
            format)

        If numberChars < StrPrint.Length Then
            StrPrint = StrPrint.Substring(numberChars)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            StrPrint = txtテキスト編集ボックス.Text
        End If
    End Sub


    Private Sub btnテキストファイル読込み_Click(sender As Object, e As EventArgs) Handles btnテキスト読込み.Click
        Dim fileName As String      '読み込み対象のテキストファイル名
        Dim fileNumber As Integer   'テキストファイルを操作するために自動的に割り当てられるファイル番号
        Dim buff As String          '読み込み対象のテキストファイルのテキストデータを保存 

        'ファイルオープンダイアログダイアログ（OpenFileDialog1）を表示する
        Select Case OpenFileDialog1.ShowDialog() = DialogResult.OK
            Case vbOK

                ' If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                'OpenFileDialog1でファイルを選択後、「開く」ボタンが押された場合
                'そのファイル名を、変数「fileName」に格納する。
                fileName = OpenFileDialog1.FileName
                MessageBox.Show(fileName + "が選択されました")
                ' Else
            Case Else
                'OpenFileDialog1で「キャンセル」ボタンが押された場合
                'このSubプロシージャの処理は　やーめた
                txtテキスト編集ボックス.Text = ""
                Exit Sub
        End Select
        '  End If
        '新しく読み込むファイルとごっちゃにならぬよう、
        '今表示されているテキストデータをクリアする
        txtテキスト編集ボックス.Text = ""

        'テキストファイルを操作するために自動的に割り当てられるファイル番号
        fileNumber = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Input)

        Do Until EOF(fileNumber)
            buff = LineInput(fileNumber)
            txtテキスト編集ボックス.Text = txtテキスト編集ボックス.Text & buff & vbCrLf
        Loop

        FileClose(fileNumber)
    End Sub

    Private Sub btnテキストファイル保存_Click(sender As Object, e As EventArgs) Handles btnテキスト保存.Click
        Dim fileName As String
        Dim fileNumber As Integer

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            fileName = SaveFileDialog1.FileName
        Else
            Exit Sub
        End If

        fileNumber = FreeFile()
        FileOpen(fileNumber, fileName, OpenMode.Output)
        PrintLine(fileNumber, txtテキスト編集ボックス.Text)
        FileClose()
    End Sub

    Private Sub btn印刷プレビュー_Click(sender As Object, e As EventArgs) Handles btnテキスト印刷プレビュー.Click
        PrintDocument1.DefaultPageSettings = PageSetting
        StrPrint = txtテキスト編集ボックス.Text
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btn印刷ダイアログ_Click(sender As Object, e As EventArgs) Handles btnテキスト印刷ダイアログ.Click
        PageSetting = PrintDocument1.DefaultPageSettings
        StrPrint = txtテキスト編集ボックス.Text
        PrintDialog1.Document = PrintDocument1

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnすぐ印刷_Click(sender As Object, e As EventArgs) Handles btnテキストすぐ印刷.Click
        PageSetting = PrintDocument1.DefaultPageSettings
        StrPrint = txtテキスト編集ボックス.Text
        PrintDialog1.Document = PrintDocument1

        PrintDocument1.Print()
    End Sub

    Private Sub btn画像読込み_Click(sender As Object, e As EventArgs) Handles btn画像読込み.Click
        Dim fileName As String      '読み込み対象の画像ファイル名

        'ファイルオープンダイアログダイアログ（OpenFileDialog1）を表示する
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'OpenFileDialog1でファイルを選択後、「開く」ボタンが押された場合
            'そのファイル名を、変数「fileName」に格納する。
            fileName = OpenFileDialog1.FileName
        Else
            'OpenFileDialog1で「キャンセル」ボタンが押された場合
            'このSubプロシージャの処理は　やーめた
            Exit Sub
        End If

        '画像を読み込む
        img = Image.FromFile(fileName)
        'PrintPreviewControl1
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object,
            ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'If img = VariantType.Null Then
        '    Exit Sub
        'End If
        '画像を描画する
        e.Graphics.DrawImage(img, e.MarginBounds)
        '次のページがないことを通知する
        e.HasMorePages = False
    End Sub

    Private Sub btn画像印刷プレビュー_Click(sender As Object, e As EventArgs) Handles btn画像印刷プレビュー.Click
        'PrintDocumentオブジェクトの作成
        Dim pd As New System.Drawing.Printing.PrintDocument
        'PrintPageイベントハンドラの追加
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        '印刷を開始する
        'pd.Print()
        PrintPreviewDialog1.Document = pd
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btn画像印刷ダイアログ_Click(sender As Object, e As EventArgs) Handles btn画像印刷ダイアログ.Click
        'PrintDocumentオブジェクトの作成
        Dim pd As New System.Drawing.Printing.PrintDocument
        'PrintPageイベントハンドラの追加
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        '印刷を開始する
        PageSetting = pd.DefaultPageSettings
        PrintDialog1.Document = pd

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            pd.Print()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn画像すぐ印刷_Click(sender As Object, e As EventArgs) Handles btn画像すぐ印刷.Click
        'PrintDocumentオブジェクトの作成
        Dim pd As New System.Drawing.Printing.PrintDocument
        'PrintPageイベントハンドラの追加
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        '印刷を開始する
        pd.Print()

    End Sub

    Private Sub btnページ設定_Click(sender As Object, e As EventArgs) Handles btnページ設定.Click
        PageSetupDialog1.PageSettings = PageSetting
        PageSetupDialog1.ShowDialog()
    End Sub
End Class