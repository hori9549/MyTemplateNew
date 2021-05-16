Imports System.Net.Mail
Imports ClosedXML.Excel
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const ExcelFilePath As String = ".\\sample.xlsx"
        ' Excelファイルを作る
        Using workbook = New XLWorkbook()
            ' Dim workbook = New XLWorkbook

            ' ワークシートを追加する
            Dim worksheet As ClosedXML.Excel.IXLWorksheet = workbook.Worksheets.Add("Sheet1")
            ' セルに値や数式をセット
            worksheet.Cell("A1").Value = 10                                      'セルに表示する値方法①
            worksheet.Cell("A2").SetValue(20)                                   'セルに表示する値方法②
            worksheet.Cell("A3").FormulaA1 = "SUM(A1:A2)"            'セルに数式を設定する

            ' セルに書式設定
            With worksheet.Cell("A3").Style
                .Fill.BackgroundColor = XLColor.Pink                ' セルを 塗りつぶし
                .NumberFormat.Format = "#,##0.00"                        ' セルの表示フォーマットの書式
            End With
            ' ワークブックを保存する
            workbook.SaveAs(ExcelFilePath)
        End Using
        MessageBox.Show("Excelファイルを保存しました。")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        '
        'Gmailに送信
        'https://www.chuken-engineer.com/entry/2019/08/01/070754
        '

        MailSend("hori9549@gmail.com", "hori9549@gmail.com", "g9459irohe", "test", "テスト送信210124。")
    End Sub
    Private Sub MailSend(ByVal ToAddress As String,
                             ByVal FromAddress As String,
                             ByVal FromAddressPass As String,
                             ByVal SendSubject As String,
                             ByVal SendMessage As String)
        Dim msg As System.Net.Mail.MailMessage
        Try
            msg = New System.Net.Mail.MailMessage(FromAddress, ToAddress, SendSubject, SendMessage)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub

        End Try

        Dim sc As New System.Net.Mail.SmtpClient()
        Dim res As String
        'gmailのSMTPサーバの設定
        sc.Host = "smtp.gmail.com"
        sc.Port = 587
        sc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
        'ユーザー名,パスワード
        sc.Credentials = New System.Net.NetworkCredential(FromAddress, FromAddressPass)
        'SSL
        sc.EnableSsl = True
        sc.Timeout = 10000
        Try
            sc.Send(msg)
            res = "送信に成功しました。"
        Catch ex As SmtpException
            res = ex.Message
        End Try
        msg.Dispose()
        MsgBox(res)
    End Sub



End Class
