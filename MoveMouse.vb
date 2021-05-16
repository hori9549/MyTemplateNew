Public Class MoveMouse

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim g As Graphics = sender.CreateGraphics()

        g.FillEllipse(Brushes.Red, e.X, e.Y, 10, 10)

    End Sub
End Class