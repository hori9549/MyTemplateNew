Public Class frmTabControl
    Private Sub btnP2_Click(sender As Object, e As EventArgs) Handles btnP2.Click
        MsgBox("２ページが選択されました")
    End Sub

    Private Sub btnP1_Click(sender As Object, e As EventArgs) Handles btnP1.Click
        MsgBox("１ページが選択されました")

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Me.Close()
    End Sub
End Class