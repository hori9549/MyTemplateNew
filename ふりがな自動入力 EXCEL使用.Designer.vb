<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmふりがな自動入力_EXCEL使用
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
        Me.漢字 = New System.Windows.Forms.Label()
        Me.txt変換元 = New System.Windows.Forms.TextBox()
        Me.txt結果 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn変換 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '漢字
        '
        Me.漢字.AutoSize = True
        Me.漢字.Location = New System.Drawing.Point(68, 225)
        Me.漢字.Name = "漢字"
        Me.漢字.Size = New System.Drawing.Size(191, 12)
        Me.漢字.TabIndex = 0
        Me.漢字.Text = "Test2 イベントとプロシージャを結び付け"
        '
        'txt変換元
        '
        Me.txt変換元.Location = New System.Drawing.Point(110, 87)
        Me.txt変換元.Name = "txt変換元"
        Me.txt変換元.Size = New System.Drawing.Size(100, 19)
        Me.txt変換元.TabIndex = 1
        '
        'txt結果
        '
        Me.txt結果.Location = New System.Drawing.Point(434, 83)
        Me.txt結果.Name = "txt結果"
        Me.txt結果.Size = New System.Drawing.Size(116, 19)
        Me.txt結果.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(397, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "読み"
        '
        'btn変換
        '
        Me.btn変換.Location = New System.Drawing.Point(261, 85)
        Me.btn変換.Name = "btn変換"
        Me.btn変換.Size = New System.Drawing.Size(75, 23)
        Me.btn変換.TabIndex = 4
        Me.btn変換.Text = "変換"
        Me.btn変換.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "↑"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ここに漢字を入れて。。。"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ここを押すと。。。"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(287, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "↑"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(446, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ここに変換されます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（小学生いかのがくりょくしかありません）"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(474, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "↑"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 263)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(70, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(108, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 12)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Test1 ふりがな自動入力_EXCEL使用"
        '
        'frmふりがな自動入力_EXCEL使用
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn変換)
        Me.Controls.Add(Me.txt結果)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt変換元)
        Me.Controls.Add(Me.漢字)
        Me.Name = "frmふりがな自動入力_EXCEL使用"
        Me.Text = "ふりがな自動入力_EXCEL使用"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 漢字 As Label
    Friend WithEvents txt変換元 As TextBox
    Friend WithEvents txt結果 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn変換 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
End Class
