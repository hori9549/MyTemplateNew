'https://masagoroku.com/%E3%80%90vb-net%E3%80%91gmail%E3%81%B8%E3%83%A1%E3%83%BC%E3%83%AB%E3%82%92%E9%80%81%E4%BF%A1%E3%81%99%E3%82%8B%E3%81%AB%E3%81%AF%EF%BC%9F#i-2
Public Class Form2
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fromAdress As String = TextBox1.Text
        Dim toAdress As String = TextBox2.Text
        Dim subject As String = TextBox3.Text
        Dim body As String = TextBox4.Text
        Dim pass As String = "9459iroh"


        Try

            Dim message = New MimeKit.MimeMessage()

            message.From.Add(New MimeKit.MailboxAddress("Fromサンプル", fromAdress))
            message.To.Add(New MimeKit.MailboxAddress("Toサンプル", toAdress))
            message.Subject = subject

            Dim textPart = New MimeKit.TextPart(MimeKit.Text.TextFormat.Plain)
            textPart.Text = body
            message.Body = textPart

            Using client As New MailKit.Net.Smtp.SmtpClient()

                Await client.ConnectAsync("smtp.gmail.com", 587)
                Await client.AuthenticateAsync("hori9549@gmail.com", pass)
                Await client.SendAsync(message)
                Await client.DisconnectAsync(True)

            End Using

            Label1.Text = "送信しました。"

        Catch ex As Exception

            Label1.Text = Err.Description

        End Try

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'MailMessageの作成
        Dim msg As New System.Net.Mail.MailMessage()
        '宛先
        msg.To.Add("hori9549@gmail.com")
        '件名
        msg.Subject = "こんにちは"
        '本文
        msg.Body = "こんにちは。それではまた。"

        Dim sc As New System.Net.Mail.SmtpClient()
        'メッセージを送信する
        sc.Send(msg)

        '後始末
        msg.Dispose()
        '後始末（.NET Framework 4.0以降）
        sc.Dispose()
    End Sub
End Class