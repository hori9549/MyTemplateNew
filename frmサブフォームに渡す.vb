Imports System.Data.SqlClient
'Imports System.CodeDom.Compiler
'Imports System.Configuration
Public Class frmサブに渡す
    Private msSQL As String
    Private mCommand As SqlCommand
    Private mSDA As New SqlDataAdapter
    Private dtbl社員マスタ As New DataTable
    Private cDB As New clsDB

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '  「既定のインスタンス」を利用した場合
        Dim sfrm As New frmメインに返す(Me)  ' 自フォームへの参照を渡す
        sfrm.ShowDialog() ' サブ・フォームを表示
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MessageBox.Show("べた書きするとーー", DateTimePicker1.Text.Substring(0, 4) &
        DateTimePicker1.Text.Substring(5, 2) &
               DateTimePicker1.Text.Substring(8, 2))

        DateTimePicker2.Text = DateTimePicker1.Text.Substring(0, 4) + "/" &
                               DateTimePicker1.Text.Substring(5, 2) + "/" & "01"
        ' MsgBox("初日からの差は", DateTimePicker1.Text)
        MessageBox.Show("The day of the week is " +
   DateTimePicker1.Value.DayOfWeek.ToString())
        MessageBox.Show("Test Value is: " + DateTimePicker1.Value.TimeOfDay.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'メッセージボックスを表示する 
        Dim result As DialogResult = MessageBox.Show("YES,NOのTEST？",
                                                     "HTools TEST3",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Asterisk)


        '何が選択されたか調べる 
        If result = DialogResult.Yes Then
            '「はい」が選択された時 
            MsgBox("「はい」が選択されました")
        ElseIf result = DialogResult.No Then
            '「いいえ」が選択された時 
            MsgBox("「いいえ」が選択されました")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnDB読込.Click
        '表示
        msSQL = "select * from MST_区分 "
        msSQL += "order by ID"

        mCommand = cDB.getsqlComand(msSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(dtbl社員マスタ) ''データセット作成
        dgv社員マスタ.DataSource = dtbl社員マスタ



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt数字のみ.KeyPress
        If Not IsNumeric(e.KeyChar) Then


            e.Handled = True

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
