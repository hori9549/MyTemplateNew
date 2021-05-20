'VB.NET コンストラクタのサンプル
'  https://itsakura.com/vbnet-constructor
Public Class Class1
	Public ReadOnly Property ColorName As String
	Sub New(name As String)
		ColorName = name
	End Sub
	Sub New(num As Integer)
		ColorName = "赤"
	End Sub
End Class
