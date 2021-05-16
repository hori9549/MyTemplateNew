Public Class btn自動生成
    Private Button1 As System.Windows.Forms.Button

    'フォームのLoadイベントハンドラ
    Private Sub Form1_Load(ByVal sender As Object,
            ByVal e As EventArgs) Handles MyBase.Load
        'Buttonクラスのインスタンスを作成する
        Me.Button1 = New System.Windows.Forms.Button()

        'Buttonコントロールのプロパティを設定する
        Me.Button1.Name = "Button1"
        Me.Button1.Text = "押してね"
        'サイズと位置を設定する
        Me.Button1.Location = New Point(10, 10)
        Me.Button1.Size = New System.Drawing.Size(80, 20)

        'Clickイベントハンドラを追加する
        AddHandler Me.Button1.Click, AddressOf Button1_Click

        'フォームに配置する
        Me.Controls.Add(Me.Button1)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object,
            ByVal e As EventArgs)
        Console.WriteLine("Button1がクリックされました")
    End Sub
End Class