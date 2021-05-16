Imports System.Data
Imports System.Data.SqlClient
Imports System.CodeDom.Compiler
Imports System.Configuration
Public Class frmメインに返す
    Dim f1 As frmサブに渡す

    ' コンストラクタ
    Sub New(ByVal f As Form)
        f1 = f ' メイン・フォームへの参照を保存
        InitializeComponent()
    End Sub

    ' ボタンのClickイベント・ハンドラ
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Dim f1_label1 As Label = CType(frmサブに渡す.Controls("LBL_F2受渡"), Label)

        'f1_label1.Text = Me.TXT_Form2.Text

        'Dim f1Txt1 As TextBox = CType(frmサブに渡す.Controls("TXT_F2から"), TextBox)

        'f1Txt1.Text = Me.TXT_Form2.Text

        '' メイン・フォームのラベルのModifiersプロパティを
        '' Friendにした場合は次の1行でOK
        ''
        ''f1.Label1.Text = Me.TextBox1.Text
        'Me.Close()
        Dim ｆ1_Label1 As Label = CType(f1.Controls("Label1"), Label)

        ｆ1_Label1.Text = Me.TxbRtn.Text

        Dim f1_Txt1 As TextBox = CType(f1.Controls("txtRecive"), TextBox)

        f1_Txt1.Text = Me.TxbRtn.Text

        ' メイン・フォームのラベルのModifiersプロパティを
        ' Friendにした場合は次の1行でOK
        '
        'f1.Label1.Text = Me.TextBox1.Text
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ColorDialogクラスのインスタンスを作成
        Dim cd As New ColorDialog()

        'はじめに選択されている色を設定
        cd.Color = TextBox1.BackColor
        '色の作成部分を表示可能にする
        'デフォルトがTrueのため必要はない
        cd.AllowFullOpen = True
        '純色だけに制限しない
        'デフォルトがFalseのため必要はない
        cd.SolidColorOnly = False
        '[作成した色]に指定した色（RGB値）を表示する
        cd.CustomColors = New Integer() {&H33, &H66, &H99,
            &HCC, &H3300, &H3333, &H3366, &H3399, &H33CC,
            &H6600, &H6633, &H6666, &H6699, &H66CC,
            &H9900, &H9933}

        'ダイアログを表示する
        If cd.ShowDialog() = DialogResult.OK Then
            '選択された色の取得
            TextBox1.BackColor = cd.Color
        End If
    End Sub

End Class