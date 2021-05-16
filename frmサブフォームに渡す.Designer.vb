<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmサブに渡す
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblタイトル = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnDB読込 = New System.Windows.Forms.Button()
        Me.txtRecive = New System.Windows.Forms.TextBox()
        Me.dgv社員マスタ = New System.Windows.Forms.DataGridView()
        Me.txt数字のみ = New System.Windows.Forms.TextBox()
        Me.lbl数字のみ = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgv社員マスタ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(36, 85)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(38, 12)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Form2を開く"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblタイトル
        '
        Me.lblタイトル.AutoSize = True
        Me.lblタイトル.Location = New System.Drawing.Point(36, 28)
        Me.lblタイトル.Name = "lblタイトル"
        Me.lblタイトル.Size = New System.Drawing.Size(83, 36)
        Me.lblタイトル.TabIndex = 2
        Me.lblタイトル.Text = "Test1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Form　間で" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "値をやり取りする" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(163, 96)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 19)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 52)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Test2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "DATE TIME PICKER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Test" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLICK Here!!"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(163, 150)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 19)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 66)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Test3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "メッセージボックスのテスト" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "はい/いいえ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnDB読込
        '
        Me.btnDB読込.Location = New System.Drawing.Point(588, 54)
        Me.btnDB読込.Name = "btnDB読込"
        Me.btnDB読込.Size = New System.Drawing.Size(132, 76)
        Me.btnDB読込.TabIndex = 7
        Me.btnDB読込.Text = "Select  MST_区分" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDB読込.UseVisualStyleBackColor = True
        '
        'txtRecive
        '
        Me.txtRecive.Location = New System.Drawing.Point(38, 205)
        Me.txtRecive.Name = "txtRecive"
        Me.txtRecive.Size = New System.Drawing.Size(100, 19)
        Me.txtRecive.TabIndex = 9
        Me.txtRecive.Text = "Form2からMessage"
        '
        'dgv社員マスタ
        '
        Me.dgv社員マスタ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv社員マスタ.Location = New System.Drawing.Point(489, 150)
        Me.dgv社員マスタ.Name = "dgv社員マスタ"
        Me.dgv社員マスタ.RowTemplate.Height = 21
        Me.dgv社員マスタ.Size = New System.Drawing.Size(299, 99)
        Me.dgv社員マスタ.TabIndex = 10
        '
        'txt数字のみ
        '
        Me.txt数字のみ.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt数字のみ.Location = New System.Drawing.Point(198, 313)
        Me.txt数字のみ.Name = "txt数字のみ"
        Me.txt数字のみ.Size = New System.Drawing.Size(117, 19)
        Me.txt数字のみ.TabIndex = 12
        '
        'lbl数字のみ
        '
        Me.lbl数字のみ.Location = New System.Drawing.Point(196, 217)
        Me.lbl数字のみ.Name = "lbl数字のみ"
        Me.lbl数字のみ.Size = New System.Drawing.Size(145, 82)
        Me.lbl数字のみ.TabIndex = 13
        Me.lbl数字のみ.Text = "　　数字入力のみ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "　５桁まで入力可能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(プロパティでImeModeをDiaableに設定してある）"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(674, 394)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 39)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmサブに渡す
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 542)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lbl数字のみ)
        Me.Controls.Add(Me.txt数字のみ)
        Me.Controls.Add(Me.dgv社員マスタ)
        Me.Controls.Add(Me.txtRecive)
        Me.Controls.Add(Me.btnDB読込)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblタイトル)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.label1)
        Me.Name = "frmサブに渡す"
        Me.Text = "サブに渡す"
        CType(Me.dgv社員マスタ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblタイトル As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents btnDB読込 As Button
    Friend WithEvents txtRecive As TextBox
    Friend WithEvents dgv社員マスタ As DataGridView
    Friend WithEvents txt数字のみ As TextBox
    Friend WithEvents lbl数字のみ As Label
    Friend WithEvents btnClose As Button
End Class
