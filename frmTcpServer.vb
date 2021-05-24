
Imports System.Net
Imports System.Threading
Imports System.Text

Public Class frmTcpServer

    'リッチテキストボックスにメッセージを表示する
    Public Sub DispMsg(ByVal message As String)
        RichTextBox1.AppendText(message & vbNewLine)
        RichTextBox1.SelectionStart = RichTextBox1.TextLength
        RichTextBox1.Refresh()
    End Sub

    '[Start]ボタンクリック
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'ボタン制御
        Me.btnStart.Enabled = False

        'ポート番号
        Dim pintPort As Integer = 60000
        'IPアドレス＆ポート番号設定
        Dim pEndPoint As New IPEndPoint(IPAddress.Any, pintPort)
        'ソケット・リスナー作成
        Dim pListener As New Sockets.TcpListener(pEndPoint)
        'リスナー開始
        pListener.Start()
        Call DispMsg("リスナー開始...")

        'クライアントから接続有りでこの処理を抜ける
        Dim pTcpClient As Sockets.TcpClient = pListener.AcceptTcpClient()
        Call DispMsg("クライアントから接続有り...")

        '送受信用ソケットストリーム取得
        Dim pNetStream As Sockets.NetworkStream = pTcpClient.GetStream()

        'バイト配列(取敢えず受信バッファとして256バイト)
        Dim bytRead As Byte() = New Byte(255) {}

        'ソケット受送信ループ
        While True
            'TCP受信(バッファ領域まで)
            Dim intBytes As Integer = pNetStream.Read(bytRead, 0, bytRead.Count)
            If intBytes = 0 Then
                Exit While
            End If

            '受信したデータを文字列に変換
            Dim enc As Encoding = Encoding.GetEncoding("SHIFT-JIS")
            Dim resMsg As String = enc.GetString(bytRead, 0, intBytes)
            '末尾の\rを削除
            resMsg = resMsg.TrimEnd(ControlChars.Cr)
            '表示
            Call DispMsg(resMsg)

            '正常受信の場合、送信データ作成
            Dim bytSend() As Byte = enc.GetBytes(resMsg & "...ACK" & ControlChars.Cr)
            'ソケット送信
            pNetStream.Write(bytSend, 0, bytSend.Length)
        End While

        'ソケットストリームクローズ
        pNetStream.Close()
        'クライアントクローズ
        pTcpClient.Close()
        'リスナー停止
        pListener.Stop()
        Call DispMsg("リスナー停止...")
        'ボタン制御
        Me.btnStart.Enabled = True
    End Sub

End Class