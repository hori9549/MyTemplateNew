<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm継承_6
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
        Me.btnTestMethod = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTestMethod
        '
        Me.btnTestMethod.Location = New System.Drawing.Point(164, 41)
        Me.btnTestMethod.Name = "btnTestMethod"
        Me.btnTestMethod.Size = New System.Drawing.Size(74, 42)
        Me.btnTestMethod.TabIndex = 0
        Me.btnTestMethod.Text = "1.TestMethod"
        Me.btnTestMethod.UseVisualStyleBackColor = True
        '
        'frm継承_6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTestMethod)
        Me.Name = "frm継承_6"
        Me.Text = "frm継承_6"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTestMethod As Button
End Class
