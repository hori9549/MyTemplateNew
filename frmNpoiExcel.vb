''NPOIを使うために必要
Imports NPOI.SS.UserModel
Public Class frmNpoiExcel
    Private Sub frmNpoiExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''読込み

        Dim WB As IWorkbook = WorkbookFactory.Create(".\\sample.xlsx")
        Dim WS As ISheet = WB.GetSheetAt(0)         ''最初のシート取得
        Dim iLastRow As Integer = WS.LastRowNum   ''シートの最終行数取得
        ''最終行まで読込み
        MsgBox(iLastRow.ToString)
        For iCount As Integer = 0 To iLastRow
            Dim getRow As IRow = WS.GetRow(iCount)　''行取得
            Dim getCell = getRow.GetCell(0)         ''取得した行のA列取得

            ''セルにデータがあればメッセージ表示
            If getCell IsNot Nothing Then
                Dim dt As String = getCell.ToString
                MsgBox(dt)
            End If
        Next



        'Dim rowIndex = 0
        'Dim columnIndex = 0
        '   WS.CreateRow(5).CreateCell(0).SetCellValue(1000)
        '  WS.GetRow(5).GetCell(0).SetCellValue(1000)



    End Sub

End Class