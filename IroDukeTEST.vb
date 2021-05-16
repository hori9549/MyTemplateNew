Public Class IroDukeTEST
    Private IroDuke As New clsHTools

    ' ファンクション" IroDuke " 4つの引数が必要
    '------------------------------------------------
    '     色付け
    '------------------------------------------------
    Dim inhex As String       '色彩の16進コードを入れる
    Dim R As Byte             '戻値1　FromArgb(p1, p2, p3)のパラメーターになる
    Dim G As Byte             '戻値2　FromArgb(p1, p2, p3)のパラメーターになる
    Dim B As Byte             '戻値3　FromArgb(p1, p2, p3)のパラメーターになる

    '　以下は使用例

    Private Sub IroDuke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inhex = "AFEAFF"
        Call IroDuke.DivRGB(inhex, R, G, B)
        'R = IroDuke.P1    'ByLef?の受け取り
        'G = IroDuke.P2    'ByLef?の受け取り
        'B = IroDuke.P3    'ByLef?の受け取り

        Me.BackColor = Color.FromArgb(R, G, B)　　'結果を使う
    End Sub
    Private Sub Button1_MouseClick(sender As Object, e As MouseEventArgs) Handles Button1.MouseClick
        inhex = "FF0000"
        Call IroDuke.DivRGB(inhex, R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)
    End Sub
    Private Sub botton2_MouseClick(sender As Object, e As MouseEventArgs) Handles Button2.MouseClick
        inhex = "4169E1"

        Call IroDuke.DivRGB(inhex, R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)
    End Sub
    Private Sub Button3_MouseClick(sender As Object, e As MouseEventArgs) Handles Button3.MouseClick
        inhex = "FFFF00"
        Call IroDuke.DivRGB(inhex, R, G, B)
        Me.BackColor = Color.FromArgb(R, G, B)
    End Sub
    ''------------------------------------------------
    ''    IroDuke　　の本体
    ''------------------------------------------------
    'Sub IroDuke(ByVal InHex As String, ByRef P1 As Byte, ByRef P2 As Byte, ByRef P3 As Byte)
    '    Dim strTempColor As String
    '    Dim HexKasira As String = "&H"
    '    strTempColor = InHex

    '    Select Case InHex.Length         'HexのLengthによる処理
    '        Case 1 To 2
    '            P3 = HexKasira & Mid(strTempColor, 1)
    '            P2 = "&H0"
    '            P1 = "&H0"
    '        Case 3
    '            P1 = "&H0"
    '            P2 = HexKasira & Mid(strTempColor, 1, 1)
    '            P3 = HexKasira & Mid(strTempColor, 2, 2)
    '        Case 4
    '            P1 = "&H0"
    '            P2 = HexKasira & Mid(strTempColor, 1, 2)
    '            P3 = HexKasira & Mid(strTempColor, 3, 2)
    '        Case 5
    '            P1 = HexKasira & Mid(strTempColor, 1, 1)
    '            P2 = HexKasira & Mid(strTempColor, 2, 2)
    '            P3 = HexKasira & Mid(strTempColor, 4, 2)
    '        Case 6
    '            P1 = HexKasira & Mid(strTempColor, 1, 2)
    '            P2 = HexKasira & Mid(strTempColor, 3, 2)
    '            P3 = HexKasira & Mid(strTempColor, 5, 2)
    '        Case Else
    '            P1 = "&Hff"
    '            P2 = "&Hff"
    '            P3 = "&Hff"
    '    End Select

    'End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnPubShareFunc_Click(sender As Object, e As EventArgs) Handles btnPubShareFunc.Click
        Dim TestMsg As String
        TestMsg = H_TOOLS.getName()
        MsgBox("Fublic Shared Function を使う" & TestMsg)
        Dim R, G, B As String
        Dim P(3) As String

        P = H_TOOLS.rtnParameter("FF0000")
        R = P(0)
        G = P(1)
        B = P(2)
        btnPubShareFunc.BackColor = Color.FromArgb(R, G, B)
    End Sub

End Class