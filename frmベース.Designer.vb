<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmベース
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
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn閉じる
        '
        Me.btn閉じる.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn閉じる.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn閉じる.ForeColor = System.Drawing.Color.Red
        Me.btn閉じる.Location = New System.Drawing.Point(953, 676)
        Me.btn閉じる.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(217, 71)
        Me.btn閉じる.TabIndex = 101
        Me.btn閉じる.Text = "閉じる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'frmベース
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 761)
        Me.Controls.Add(Me.btn閉じる)
        Me.Font = New System.Drawing.Font("MS UI Gothic", 14.25!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmベース"
        Me.Text = "frmベース"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn閉じる As Button
End Class
