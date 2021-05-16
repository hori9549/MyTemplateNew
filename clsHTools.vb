Public Class clsHTools
    ''------------------------------------------------
    ''    clsHTools　　の本体
    ''------------------------------------------------
    'プロパティ
    Dim Inhex As String
    Dim P1 As Byte
    Dim P2 As Byte
    Private P3 As Byte

    'メソッドの作成
    Public Sub DivRGB(ByVal inhex As String, ByRef P1 As Byte, ByRef P2 As Byte, ByRef P3 As Byte)
        Dim HexKasira As String = "&H"
        Select Case inhex.Length         'HexのLengthによる処理
            Case 1 To 2
                P3 = HexKasira & Mid(inhex, 1)
                P2 = "&H0"
                P1 = "&H0"
            Case 3
                P1 = "&H0"
                P2 = HexKasira & Mid(inhex, 1, 1)
                P3 = HexKasira & Mid(inhex, 2, 2)
            Case 4
                P1 = "&H0"
                P2 = HexKasira & Mid(inhex, 1, 2)
                P3 = HexKasira & Mid(inhex, 3, 2)
            Case 5
                P1 = HexKasira & Mid(inhex, 1, 1)
                P2 = HexKasira & Mid(inhex, 2, 2)
                P3 = HexKasira & Mid(inhex, 4, 2)
            Case 6
                P1 = HexKasira & Mid(inhex, 1, 2)
                P2 = HexKasira & Mid(inhex, 3, 2)
                P3 = HexKasira & Mid(inhex, 5, 2)
            Case Else
                P1 = "&Hff"
                P2 = "&Hff"
                P3 = "&Hff"
        End Select
    End Sub
End Class
