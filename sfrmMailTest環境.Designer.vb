<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sfrmMailTest環境
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.llblTest環境 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'llblTest環境
        '
        Me.llblTest環境.AutoSize = True
        Me.llblTest環境.Location = New System.Drawing.Point(143, 67)
        Me.llblTest環境.Name = "llblTest環境"
        Me.llblTest環境.Size = New System.Drawing.Size(211, 12)
        Me.llblTest環境.TabIndex = 0
        Me.llblTest環境.TabStop = True
        Me.llblTest環境.Text = " https: //myaccount.google.com/?tab=kk"
        '
        'sfrmMailTest環境
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 306)
        Me.Controls.Add(Me.llblTest環境)
        Me.Name = "sfrmMailTest環境"
        Me.Text = "sfrmMailTest環境"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents llblTest環境 As LinkLabel
End Class
