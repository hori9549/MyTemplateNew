Public Class 月カレンダー
    Private Sub 月カレンダー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim YYYYMM As Date = Now.Date

        ' Dim iDays As Integer = DateTime.DaysInMonth(2021, 3)
        Dim iDays As Integer = 31
        Dim dtblカレンダー As New DataTable

        dgvカレンダー.DataSource = dtblカレンダー

        dtblカレンダー.Columns.Add("ID")
        dtblカレンダー.Columns.Add("年月日")
        dtblカレンダー.Columns.Add("曜日")

        For i = 1 To iDays
            Dim row追加 As DataRow

            row追加 = dtblカレンダー.NewRow
            row追加("ID") = i
            row追加("年月日") = CType(YYYYMM, String)

            '曜日の数字を短い日本語に直す
            With YYYYMM.DayOfWeek
                Select Case YYYYMM.DayOfWeek
                    Case 0
                        row追加("曜日") = "日"
                    Case 1
                        row追加("曜日") = "月"
                    Case 2
                        row追加("曜日") = "火"
                    Case 3
                        row追加("曜日") = "水"
                    Case 4
                        row追加("曜日") = "木"
                    Case 5
                        row追加("曜日") = "金"
                    Case 6
                        row追加("曜日") = "土"
                End Select
            End With

            dtblカレンダー.Rows.Add(row追加)
            YYYYMM = DateAdd(DateInterval.Day, 1, YYYYMM)
        Next

    End Sub
End Class