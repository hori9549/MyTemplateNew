Imports System.Data.SqlClient

Public Class frmメニュー
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btnEX1.Click
        Dim sfrm As New frmサブに渡す
        sfrm.ShowDialog()

    End Sub

    Private Sub frmメニュー_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.cmbCMBテスト
    End Sub

    Private Sub btnEX2_Click(sender As Object, e As EventArgs) Handles btnEX2.Click
        Dim ex2 As New MoveMouse
        ex2.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHtools.Click
        Dim ex3 As New H_TOOLS()
        ex3.ShowDialog()

    End Sub

    Private Sub btnEX4_Click(sender As Object, e As EventArgs) Handles btnEX4色づけ.Click
        Dim ex4 As New IroDukeTEST
        ex4.ShowDialog()
    End Sub
    Private Sub btnEX5_Click(sender As Object, e As EventArgs) Handles btnEX5.Click
        Dim ex5 As New frmCtrlSample
        ex5.ShowDialog()

    End Sub

    Private Sub cmbCMBテスト_Click(sender As Object, e As EventArgs) Handles cmbCMBテスト.Click
        Call 区分コンボ(cmb区分CMB)
        MsgBox("CMBテスト終了")
        btnEX1.Focus()
    End Sub

    Sub 区分コンボ(ByVal setDDL As ComboBox)
        Dim cDB As New clsDB
        Dim getSQL As String
        Dim myTable As New DataTable
        Dim mCommand As SqlCommand
        Dim mSDA As New SqlDataAdapter
        ''検索SQL======================================================
        getSQL = "SELECT DISTINCT (区分名) as 表示,区分"
        getSQL += " FROM MST_区分"
        getSQL += " ORDER BY 区分,区分名"

        mCommand = cDB.getsqlComand(getSQL)
        mSDA.SelectCommand = mCommand

        Call mSDA.Fill(myTable)
        ''=============================================================

        ''空行追加-----------------------------------------------------
        Dim myRow As DataRow = myTable.NewRow
        myRow("区分") = "0"
        myRow("表示") = ""
        Call myTable.Rows.InsertAt(myRow, 0)

        With setDDL
            .DisplayMember = "表示"
            .ValueMember = "区分"

            ''グリッド表示
            .DataSource = myTable.DefaultView
            .SelectedValue = 0

        End With
    End Sub


    Private Sub cmb区分CMB_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb区分CMB.SelectedValueChanged
        '選択されていればSelectedValueに入っている
        If cmb区分CMB.SelectedIndex <> -1 Then
            'ラベルに表示
            txtSelectedID.Text = cmb区分CMB.SelectedValue.ToString()
        End If

    End Sub

    Private Sub btnEX6_Click(sender As Object, e As EventArgs) Handles btnEX6.Click
        Dim sfrm As New frm印刷練習
        sfrm.ShowDialog()
    End Sub

    Private Sub btn全選択_Click(sender As Object, e As EventArgs) Handles btn全選択.Click
        Dim SFRM As New frmText全選択
        SFRM.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfrm As New frmEnterNext
        sfrm.ShowDialog()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sfrm As New Form3
        sfrm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sfrm As New 月カレンダー
        sfrm.ShowDialog()
    End Sub

    Private Sub btnCintTest_Click(sender As Object, e As EventArgs) Handles btnCintTest.Click
        '16進数の文字列を整数に変換
        Dim num16 As Integer = CInt("&HFFFffF")
        MsgBox(num16)
    End Sub

    Private Sub btnNpoiExcel_Click(sender As Object, e As EventArgs) Handles btnNpoiExcel.Click
        'NPOIでExcelファイルを扱うfrmNpoiExcel
        Dim sfrm As New frmNpoiExcel
        sfrm.ShowDialog()

    End Sub

    Private Sub txtTab_Click(sender As Object, e As EventArgs) Handles txtTab.Click
        'TabControlのテスト
        Dim sfrm As New frmTabControl
        sfrm.ShowDialog()

    End Sub
    Private Sub btnex2_2_Click(sender As Object, e As EventArgs) Handles btnex2_2.Click
        '補間文字のテスト
        Dim sfrm As New frmEx2_2
        sfrm.ShowDialog()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnKannjiToHiragana_Click(sender As Object, e As EventArgs) Handles btnKannjiToHiragana.Click

    End Sub
End Class