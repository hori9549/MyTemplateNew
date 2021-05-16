'Imports System.Net.Mail

Public Class frmText全選択
    Private contNam As String
    Private sendSav As String
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt1.KeyPress, txt2.KeyPress, txt3.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.SelectNextControl(sender, True, True, True, True)
            e.Handled = True
        Else
            If e.KeyChar = Chr(Keys.Escape) Then

                Controls(contNam).Text = sendSav

                ActiveControl = Nothing
                ' Label1.Select()
                ' ActiveControl = txtDumy
            End If
        End If

    End Sub
    Private Sub Text全選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles txt1.MouseClick, txt2.MouseClick, txt3.MouseClick
        contNam = sender.name.ToString   'Control "Name"
        sendSav = sender.text
        sender.SelectAll()

    End Sub

    Private Sub btnメール_Click(sender As Object, e As EventArgs) Handles btnメール.Click
        '送信者
        Dim senderMail As String = "hori9549@gmail.com"
        '宛先
        Dim recipientMail As String = "hori9549@gmail.com"
        '件名
        Dim subject As String = "こんにちは"
        '本文
        Dim body As String = "こんにちは。" + vbCrLf + vbCrLf + "それではまた。"

        'SmtpClientオブジェクトを作成する
        Dim sc As New System.Net.Mail.SmtpClient()
        'SMTPサーバーを指定する
        sc.Host = "192.168.0.24"
        'ポート番号を指定する（既定値は25）
        sc.Port = 25
        'メールを送信する
        sc.Send(senderMail, recipientMail, subject, body)
        '後始末（.NET Framework 4.0以降）
        sc.Dispose()


        '    Dim urlContents As String = Await client.GetStringAsync()
    End Sub
    Async Sub SendMailAsync(userName As String, password As String)
        ' MimeMessageを作り、宛先やタイトルなどを設定する
        Dim message = New MimeKit.MimeMessage()
        message.From.Add(New MimeKit.MailboxAddress("MailKit ユーザー", "***@***.com"))
        message.To.Add(New MimeKit.MailboxAddress("MailKit 試験", "***@***.jp"))
        ' message.Cc.Add(……省略……)
        ' message.Bcc.Add(……省略……)
        message.Subject = "MailKit でメールを送信するテスト"

        ' 本文を作る
        Dim textPart = New MimeKit.TextPart(MimeKit.Text.TextFormat.Plain)
        textPart.Text = "MailKit を使ってメールを送ってみるテストです。"

        ' MimeMessageを完成させる
        message.Body = textPart

        ' SMTPサーバに接続してメールを送信する
        Using client = New MailKit.Net.Smtp.SmtpClient()
#If DEBUG Then
            ' 開発用のSMTPサーバが暗号化に対応していないときは、次の行を追加する
            ' client.ServerCertificateValidationCallback = Function(s, c, h, e) True
#End If

            Try
                Await client.ConnectAsync("smtp.***.com", 587)
                WriteLine("接続完了")

                ' SMTPサーバがユーザー認証を必要としない場合は、次の2行は不要
                Await client.AuthenticateAsync(userName, password)
                WriteLine("認証完了")

                Await client.SendAsync(message)
                WriteLine("送信完了")

                Await client.DisconnectAsync(True)
                WriteLine("切断")

            Catch ex As Exception
                WriteLine(ex.ToString())
            End Try
        End Using
    End Sub

    Private Sub btnメール２_Click(sender As Object, e As EventArgs) Handles btnメール２.Click
        'MailMessageの作成
        Dim msg As New System.Net.Mail.MailMessage(
            "hori9549@gmail.com", "hori9549@gmail.com", "題名", "本文")

        Dim sc As New System.Net.Mail.SmtpClient()
        'SMTPサーバーを指定する
        sc.Host = "smtp.gmail.com"
        'ポート番号を指定する（既定値は25）
        sc.Port = 587
        'SMTPサーバーに送信する設定にする（既定はNetwork）
        sc.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network
        'メッセージを送信する
        sc.Send(msg)

        '後始末
        msg.Dispose()
        '後始末（.NET Framework 4.0以降）
        sc.Dispose()
    End Sub

    Private Sub btnメール3_Click(sender As Object, e As EventArgs) Handles btnメール3.Click
    End Sub
    Public Function SendMail(ByVal strMailAdr() As String,
                            Optional ByVal strMailCC() As String = Nothing,
                            Optional ByVal strMailSubject As String = "",
                            Optional ByVal strBody As String = "",
                            Optional ByVal File_NAME As String = "") As Boolean
        Try
            Dim i As Integer
            ''【メールの送信】
            ''文字コード
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("UTF-8")
            ''メッセージの作成
            Dim msg As New System.Net.Mail.MailMessage()
            ''件名と本文の文字コードを指定する
            msg.SubjectEncoding = enc
            msg.BodyEncoding = enc
            ''送信者
            msg.From = New System.Net.Mail.MailAddress("order_send@nana.co.jp", "", enc)
            ''宛先
            For i = 0 To UBound(strMailAdr)
                If strMailAdr(i) <> "" Then
                    msg.To.Add(New System.Net.Mail.MailAddress(strMailAdr(i), "", enc))
                End If
            Next
            ''CC
            If Not IsNothing(strMailCC) Then
                For i = 0 To UBound(strMailCC)
                    If strMailCC(i) <> "" Then
                        msg.CC.Add(New System.Net.Mail.MailAddress(strMailCC(i), "", enc))
                    End If
                Next
            End If
            ''件名
            msg.Subject = strMailSubject
            ''本文
            msg.Body = strBody
            ''ファイルを添付する
            If File_NAME <> "" Then
                Dim attach1 As New System.Net.Mail.Attachment(File_NAME)
                msg.Attachments.Add(attach1)
            End If
            ''SMTPサーバーを指定する
            Dim sc As New System.Net.Mail.SmtpClient()
            sc.Host = "XXXXXX"
            sc.Credentials = New System.Net.NetworkCredential("XXXXX@XXXXX", "XXXXXXX")
            ''【メッセージを送信する】
            Try
                sc.Port = 587
                sc.Send(msg)
            Catch ex As Exception
                Throw ex
            Finally
                ''後始末
                msg.Dispose()
            End Try
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class