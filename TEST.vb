Public Class frmCtrlSample
    Private Sub TEST_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim yb As Integer = 123456

        lblTEST1.Text = Format(yb, "000-00")
        lbltest2.Text = Format(yb, "#-#")
        lbltest3.Text = yb.ToString("c")
        lblTest4.Text = yb.ToString("d7")
        lblTest5.Text = yb.ToString("00000000")
        lblTest6.Text = yb.ToString("#,0")

        btnFlat.FlatStyle = FlatStyle.Flat
        btnPopup.FlatStyle = FlatStyle.Popup
        btnStandard.FlatStyle = FlatStyle.Standard
        btnSystem.FlatStyle = FlatStyle.System

        'カスタム書式指定文字列を用いて日付時刻を出力
        Dim strOutPut As String = Nothing
        Dim objDateTime As DateTime = DateTime.Now
        'yyyyMMdd形式
        strOutPut = objDateTime.ToString("yyyyMMdd")
        MessageBox.Show(strOutPut, "yyyyMMdd形式")
        txtDayTime.Text = objDateTime.ToString("yyyy/MM/dd")
        txtDt2.Text = objDateTime.ToString("yyyy/MM/dd (dddd)")
        txtDT3.Text = objDateTime.ToString("yy/MM/dd")

        btn見せる.Visible = False
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTest4.Click

    End Sub

    Private Sub btnかくす_Click(sender As Object, e As EventArgs) Handles btnかくす.Click
        grp覆い.Visible = False
        btn見せる.Visible = True

    End Sub



    Private Sub btn見せる_Click(sender As Object, e As EventArgs) Handles btn見せる.Click
        grp覆い.Visible = True
    End Sub

End Class