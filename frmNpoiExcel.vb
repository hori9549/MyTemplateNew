''NPOIを使うために必要
Imports NPOI.SS.UserModel
Public Class frmNpoiExcel
    Private Sub frmNpoiExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click

        ''読込み
        ' Dim WB As IWorkbook = WorkbookFactory.Create("sample.xlsx")
        Dim WB As IWorkbook = WorkbookFactory.Create("excel\会員名簿.xlsx")
        Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得
        ''最終行まで読込み
        MsgBox(iLastRow.ToString)
        For iCount As Integer = 8 To iLastRow
            'Dim getRow As IRow = WS.GetRow(iCount)　''行取得
            'Dim getCell = getRow.GetCell(0)         ''取得した行のA列取得
            Dim str As String





            If WS.GetRow(iCount).GetCell(2) Is Nothing Then     'nullならErrorになる




                str = ""
            Else
                ''セルにデータがあればメッセージ表示

                str = WS.GetRow(iCount).GetCell(2).ToString
            End If
            MsgBox(str)

        Next



        'Dim rowIndex = 0
        'Dim columnIndex = 0
        '   WS.CreateRow(5).CreateCell(0).SetCellValue(1000)
        '  WS.GetRow(5).GetCell(0).SetCellValue(1000)



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


End Class