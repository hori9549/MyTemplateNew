''NPOIを使うために必要
Imports NPOI.SS.UserModel
Public Class frmNpoiExcel
    Private Sub frmNpoiExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        MsgBox("GAP約定通知を読んでみよう")

        ''excel ファイルを選んでもらう
        '
        'Dim sフォルダ As String = "newExcel"
        'Dim sファイル As String = sフォルダ & "A.xlsx"
        Dim SFD As New OpenFileDialog
        Dim sFname As String        'selected file name 
        'Dim di As New System.IO.DirectoryInfo(sフォルダ)
        'di.Create()
        With SFD
            .Filter = "excelファイル(*.xlsx,*.xlmx)|*.xlsx;*.xlmx"
            .Title = "excelファイルを選択してください"
            .RestoreDirectory = True
            .CheckFileExists = True
            .CheckPathExists = True

            '' dialog　ＯＫ が押されたら次へ
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then Exit Sub

            MsgBox(.FileName)
            Console.WriteLine(.FileName)
            sFname = .FileName
            '' 更新
            'If System.IO.File.Exists(sファイル) Then
            '    System.IO.File.Delete(sファイル)
            'End If

        End With

        ''読込み
        '' Dim WB As IWorkbook = WorkbookFactory.Create("sample.xlsx")
        ''  Dim WB As IWorkbook = WorkbookFactory.Create("excel\会員名簿.xlsx")
        'Dim WB As IWorkbook = WorkbookFactory.Create(sFname)

        'Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        'Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得
        '''最終行まで読込み
        'MsgBox(iLastRow.ToString)
        'For iCount As Integer = 0 To iLastRow
        '    Dim getRow As IRow = WS.GetRow(iCount)　''行取得
        '    Dim getCell = getRow.GetCell(0)         ''取得した行のA列取得
        '    Dim str As String

        '    If WS.GetRow(iCount).GetCell(2) Is Nothing Then     'nullならErrorになる

        '        str = ""
        '    Else
        '        ''セルにデータがあればメッセージ表示

        '        str = WS.GetRow(iCount).GetCell(2).ToString
        '    End If
        '    MsgBox(str)

        'Next

        'Dim rowIndex = 0
        'Dim columnIndex = 0
        '   WS.CreateRow(5).CreateCell(0).SetCellValue(1000)
        '  WS.GetRow(5).GetCell(0).SetCellValue(1000)


        Dim WB As IWorkbook = WorkbookFactory.Create(sFname)
        Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得

        ''最終行まで読込み
        ' For iCount As Integer = 0 To iLastRow - 1

        For iCount As Integer = 0 To 7



            ''/*****************空伯がでてくるまで読み続ける******************/
            'Dim r As Integer = 1

            Dim getRow As IRow = WS.GetRow(iCount) ''行取得


            If getRow.GetCell(0) IsNot Nothing Then   '空白がでてくるまで読み続ける

                Dim getCell約定日 = getRow.GetCell(3)         ''約定日
                Dim getCell取引名 = getRow.GetCell(6)         ''取引名
                Dim getCell銘柄名 = getRow.GetCell(9)         ''銘柄名

                ''セルにデータがあればメッセージ表示
                MsgBox($" {getCell約定日}, {getCell取引名}, {getCell銘柄名}")
                'If getCell IsNot Nothing Then
                '    Console.WriteLine(getCell.StringCellValue)
            Else



            End If
        Next
        WB.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class