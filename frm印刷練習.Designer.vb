<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm印刷練習
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm印刷練習))
        Me.txtテキスト編集ボックス = New System.Windows.Forms.TextBox()
        Me.btnテキスト読込み = New System.Windows.Forms.Button()
        Me.btnテキスト保存 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnテキスト印刷プレビュー = New System.Windows.Forms.Button()
        Me.btnテキスト印刷ダイアログ = New System.Windows.Forms.Button()
        Me.btnテキストすぐ印刷 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewControl1 = New System.Windows.Forms.PrintPreviewControl()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnページ設定 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn画像印刷プレビュー = New System.Windows.Forms.Button()
        Me.btn画像印刷ダイアログ = New System.Windows.Forms.Button()
        Me.btn画像すぐ印刷 = New System.Windows.Forms.Button()
        Me.btn画像読込み = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtテキスト編集ボックス
        '
        Me.txtテキスト編集ボックス.Location = New System.Drawing.Point(8, 47)
        Me.txtテキスト編集ボックス.Multiline = True
        Me.txtテキスト編集ボックス.Name = "txtテキスト編集ボックス"
        Me.txtテキスト編集ボックス.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtテキスト編集ボックス.Size = New System.Drawing.Size(442, 452)
        Me.txtテキスト編集ボックス.TabIndex = 0
        '
        'btnテキスト読込み
        '
        Me.btnテキスト読込み.Location = New System.Drawing.Point(8, 19)
        Me.btnテキスト読込み.Name = "btnテキスト読込み"
        Me.btnテキスト読込み.Size = New System.Drawing.Size(69, 23)
        Me.btnテキスト読込み.TabIndex = 1
        Me.btnテキスト読込み.Text = "読込み"
        Me.btnテキスト読込み.UseVisualStyleBackColor = True
        '
        'btnテキスト保存
        '
        Me.btnテキスト保存.Location = New System.Drawing.Point(81, 19)
        Me.btnテキスト保存.Name = "btnテキスト保存"
        Me.btnテキスト保存.Size = New System.Drawing.Size(69, 23)
        Me.btnテキスト保存.TabIndex = 1
        Me.btnテキスト保存.Text = "保存"
        Me.btnテキスト保存.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "へなちょこテキスト"
        Me.SaveFileDialog1.Filter = "テキストファイル(*.txt)|*.txt"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnテキスト印刷プレビュー)
        Me.GroupBox1.Controls.Add(Me.btnテキスト印刷ダイアログ)
        Me.GroupBox1.Controls.Add(Me.btnテキストすぐ印刷)
        Me.GroupBox1.Controls.Add(Me.btnテキスト保存)
        Me.GroupBox1.Controls.Add(Me.btnテキスト読込み)
        Me.GroupBox1.Controls.Add(Me.txtテキスト編集ボックス)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 506)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "テキストデータの印刷"
        '
        'btnテキスト印刷プレビュー
        '
        Me.btnテキスト印刷プレビュー.Location = New System.Drawing.Point(156, 19)
        Me.btnテキスト印刷プレビュー.Name = "btnテキスト印刷プレビュー"
        Me.btnテキスト印刷プレビュー.Size = New System.Drawing.Size(89, 23)
        Me.btnテキスト印刷プレビュー.TabIndex = 1
        Me.btnテキスト印刷プレビュー.Text = "印刷プレビュー"
        Me.btnテキスト印刷プレビュー.UseVisualStyleBackColor = True
        '
        'btnテキスト印刷ダイアログ
        '
        Me.btnテキスト印刷ダイアログ.Location = New System.Drawing.Point(251, 19)
        Me.btnテキスト印刷ダイアログ.Name = "btnテキスト印刷ダイアログ"
        Me.btnテキスト印刷ダイアログ.Size = New System.Drawing.Size(89, 23)
        Me.btnテキスト印刷ダイアログ.TabIndex = 1
        Me.btnテキスト印刷ダイアログ.Text = "印刷ダイアログ"
        Me.btnテキスト印刷ダイアログ.UseVisualStyleBackColor = True
        '
        'btnテキストすぐ印刷
        '
        Me.btnテキストすぐ印刷.Location = New System.Drawing.Point(346, 19)
        Me.btnテキストすぐ印刷.Name = "btnテキストすぐ印刷"
        Me.btnテキストすぐ印刷.Size = New System.Drawing.Size(69, 23)
        Me.btnテキストすぐ印刷.TabIndex = 1
        Me.btnテキストすぐ印刷.Text = "すぐ印刷"
        Me.btnテキストすぐ印刷.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewControl1
        '
        Me.PrintPreviewControl1.Location = New System.Drawing.Point(8, 47)
        Me.PrintPreviewControl1.Name = "PrintPreviewControl1"
        Me.PrintPreviewControl1.Size = New System.Drawing.Size(443, 452)
        Me.PrintPreviewControl1.TabIndex = 3
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnページ設定
        '
        Me.btnページ設定.Location = New System.Drawing.Point(473, 24)
        Me.btnページ設定.Name = "btnページ設定"
        Me.btnページ設定.Size = New System.Drawing.Size(69, 23)
        Me.btnページ設定.TabIndex = 2
        Me.btnページ設定.Text = "ページ設定"
        Me.btnページ設定.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn画像印刷プレビュー)
        Me.GroupBox2.Controls.Add(Me.btn画像印刷ダイアログ)
        Me.GroupBox2.Controls.Add(Me.PrintPreviewControl1)
        Me.GroupBox2.Controls.Add(Me.btn画像すぐ印刷)
        Me.GroupBox2.Controls.Add(Me.btn画像読込み)
        Me.GroupBox2.Location = New System.Drawing.Point(548, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 506)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "画像データの印刷"
        '
        'btn画像印刷プレビュー
        '
        Me.btn画像印刷プレビュー.Location = New System.Drawing.Point(156, 19)
        Me.btn画像印刷プレビュー.Name = "btn画像印刷プレビュー"
        Me.btn画像印刷プレビュー.Size = New System.Drawing.Size(89, 23)
        Me.btn画像印刷プレビュー.TabIndex = 1
        Me.btn画像印刷プレビュー.Text = "印刷プレビュー"
        Me.btn画像印刷プレビュー.UseVisualStyleBackColor = True
        '
        'btn画像印刷ダイアログ
        '
        Me.btn画像印刷ダイアログ.Location = New System.Drawing.Point(251, 19)
        Me.btn画像印刷ダイアログ.Name = "btn画像印刷ダイアログ"
        Me.btn画像印刷ダイアログ.Size = New System.Drawing.Size(89, 23)
        Me.btn画像印刷ダイアログ.TabIndex = 1
        Me.btn画像印刷ダイアログ.Text = "印刷ダイアログ"
        Me.btn画像印刷ダイアログ.UseVisualStyleBackColor = True
        '
        'btn画像すぐ印刷
        '
        Me.btn画像すぐ印刷.Location = New System.Drawing.Point(346, 19)
        Me.btn画像すぐ印刷.Name = "btn画像すぐ印刷"
        Me.btn画像すぐ印刷.Size = New System.Drawing.Size(69, 23)
        Me.btn画像すぐ印刷.TabIndex = 1
        Me.btn画像すぐ印刷.Text = "すぐ印刷"
        Me.btn画像すぐ印刷.UseVisualStyleBackColor = True
        '
        'btn画像読込み
        '
        Me.btn画像読込み.Location = New System.Drawing.Point(8, 19)
        Me.btn画像読込み.Name = "btn画像読込み"
        Me.btn画像読込み.Size = New System.Drawing.Size(69, 23)
        Me.btn画像読込み.TabIndex = 1
        Me.btn画像読込み.Text = "読込み"
        Me.btn画像読込み.UseVisualStyleBackColor = True
        '
        'frm印刷練習
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 514)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnページ設定)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm印刷練習"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtテキスト編集ボックス As TextBox
    Friend WithEvents btnテキスト読込み As Button
    Friend WithEvents btnテキスト保存 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnテキスト印刷プレビュー As Button
    Friend WithEvents btnテキスト印刷ダイアログ As Button
    Friend WithEvents btnテキストすぐ印刷 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewControl1 As PrintPreviewControl
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnページ設定 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn画像印刷プレビュー As Button
    Friend WithEvents btn画像印刷ダイアログ As Button
    Friend WithEvents btn画像すぐ印刷 As Button
    Friend WithEvents btn画像読込み As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
