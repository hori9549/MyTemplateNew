Module Module1
	Sub Main()
		Dim a As Integer = 3
		print1(a)
		Console.WriteLine(a) '3と出力される
	End Sub
	Sub print1(ByVal a)
		a = a * a
		Console.WriteLine(a) '9と出力される
	End Sub
    Function rtnParameter(ByVal hexNum As String) As String()
        Dim P(2) As String
        Dim strTempColor As String
        Dim HexKasira As String = "&H"
        strTempColor = hexNum
        Select Case hexNum.Length         'HexのLengthによる処理
            Case 1 To 2
                P(0) = "&H0"
                P(1) = "&H0"
                P(2) = HexKasira & Mid(strTempColor, 1)
            Case 3
                P(0) = "&H0"
                P(1) = HexKasira & Mid(strTempColor, 1, 1)
                P(2) = HexKasira & Mid(strTempColor, 2, 2)
            Case 4
                P(0) = "&H0"
                P(1) = HexKasira & Mid(strTempColor, 1, 2)
                P(2) = HexKasira & Mid(strTempColor, 3, 2)
            Case 5
                P(0) = HexKasira & Mid(strTempColor, 1, 1)
                P(1) = HexKasira & Mid(strTempColor, 2, 2)
                P(2) = HexKasira & Mid(strTempColor, 4, 2)
            Case 6
                P(0) = HexKasira & Mid(strTempColor, 1, 2)
                P(1) = HexKasira & Mid(strTempColor, 3, 2)
                P(2) = HexKasira & Mid(strTempColor, 5, 2)
            Case Else
                P(0) = "&Hff"
                P(1) = "&Hff"
                P(2) = "&Hff"
        End Select

        Return P
    End Function
End Module