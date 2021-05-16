<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 月カレンダー
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
        Me.dgvカレンダー = New System.Windows.Forms.DataGridView()
        CType(Me.dgvカレンダー, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvカレンダー
        '
        Me.dgvカレンダー.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvカレンダー.Location = New System.Drawing.Point(111, 12)
        Me.dgvカレンダー.Name = "dgvカレンダー"
        Me.dgvカレンダー.RowTemplate.Height = 21
        Me.dgvカレンダー.Size = New System.Drawing.Size(554, 426)
        Me.dgvカレンダー.TabIndex = 0
        '
        '月カレンダー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgvカレンダー)
        Me.Name = "月カレンダー"
        Me.Text = "月カレンダー"
        CType(Me.dgvカレンダー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvカレンダー As DataGridView
End Class
