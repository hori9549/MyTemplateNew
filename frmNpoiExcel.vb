''NPOIを使うために必要
Imports NPOI.SS.UserModel
Public Class frmNpoiExcel
    Private Sub frmNpoiExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''読込み

        Dim WB As IWorkbook = WorkbookFactory.Create("sample.xlsx")
        Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得
        ''最終行まで読込み
        MsgBox(iLastRow.ToString)
        For iCount As Integer = 0 To iLastRow
            'Dim getRow As IRow = WS.GetRow(iCount)　''行取得
            'Dim getCell = getRow.GetCell(0)         ''取得した行のA列取得
            Dim str As String





            If WS.GetRow(iCount).GetCell(0) Is Nothing Then     'nullならErrorになる




                str = ""
            Else
                ''セルにデータがあればメッセージ表示

                str = WS.GetRow(iCount).GetCell(0).ToString
            End If
            MsgBox(str)

        Next



        'Dim rowIndex = 0
        'Dim columnIndex = 0
        '   WS.CreateRow(5).CreateCell(0).SetCellValue(1000)
        '  WS.GetRow(5).GetCell(0).SetCellValue(1000)



    End Sub

End Class