Imports System.Net
Imports System.Text

Public Class frmTcpClient

    '[Send]リック時イベント
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Me.btnSend.Enabled = False
        Try
            'サーバーのIPアドレス（または、ホスト名）とポート番号
            Dim strIpAddr As String = "localhost"
            Dim intPort As Integer = 60000

            'ソケット生成・指定したホストの指定したポートに接続
            Dim pTcpClient = New Sockets.TcpClient(strIpAddr, intPort)
            'ソケットストリーム取得
            Dim pNetStream As Sockets.NetworkStream = pTcpClient.GetStream()

            '送信文字列をバイト配列変換
            Dim enc As Encoding = Encoding.GetEncoding("SHIFT-JIS")
            '最後尾にCR
            Dim data As Byte() = enc.GetBytes(Me.TextBox1.Text.Trim & ControlChars.Cr)
            Me.TextBox1.Text = ""

            'ソケット送信
            pNetStream.Write(data, 0, data.Count)

            'サーバからの応答を受信
            Dim bytRead As Byte() = New Byte(255) {}
            Dim intBytes As Integer = pNetStream.Read(bytRead, 0, bytRead.Length)

            '受信したデータを文字列に変換
            Dim resMsg As String = enc.GetString(bytRead, 0, intBytes)
            '末尾の\rを削除し表示
            Me.TextBox2.Text = resMsg.TrimEnd(ControlChars.Cr)

            'ソケットクローズ
            pNetStream.Close()
            pTcpClient.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.btnSend.Enabled = True
    End Sub

End Class