<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmText全選択
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txtDumy = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.btnメール = New System.Windows.Forms.Button()
        Me.btnメール２ = New System.Windows.Forms.Button()
        Me.btnメール3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(86, 73)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(115, 19)
        Me.txt1.TabIndex = 0
        Me.txt1.Text = "test1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(86, 139)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(193, 19)
        Me.txt2.TabIndex = 1
        Me.txt2.Text = "TextBox2"
        '
        'txtDumy
        '
        Me.txtDumy.Location = New System.Drawing.Point(171, 27)
        Me.txtDumy.Name = "txtDumy"
        Me.txtDumy.Size = New System.Drawing.Size(53, 19)
        Me.txtDumy.TabIndex = 4
        Me.txtDumy.Text = "dummy"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(94, 209)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(193, 19)
        Me.txt3.TabIndex = 2
        Me.txt3.Text = "TextBox3"
        '
        'btnメール
        '
        Me.btnメール.Location = New System.Drawing.Point(506, 73)
        Me.btnメール.Name = "btnメール"
        Me.btnメール.Size = New System.Drawing.Size(83, 49)
        Me.btnメール.TabIndex = 5
        Me.btnメール.Text = "メールを送る"
        Me.btnメール.UseVisualStyleBackColor = True
        '
        'btnメール２
        '
        Me.btnメール２.Location = New System.Drawing.Point(516, 150)
        Me.btnメール２.Name = "btnメール２"
        Me.btnメール２.Size = New System.Drawing.Size(83, 49)
        Me.btnメール２.TabIndex = 6
        Me.btnメール２.Text = "メールを送る 2"
        Me.btnメール２.UseVisualStyleBackColor = True
        '
        'btnメール3
        '
        Me.btnメール3.Location = New System.Drawing.Point(516, 243)
        Me.btnメール3.Name = "btnメール3"
        Me.btnメール3.Size = New System.Drawing.Size(83, 49)
        Me.btnメール3.TabIndex = 7
        Me.btnメール3.Text = "メールを送る 3"
        Me.btnメール3.UseVisualStyleBackColor = True
        '
        'frmText全選択
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnメール3)
        Me.Controls.Add(Me.btnメール２)
        Me.Controls.Add(Me.btnメール)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txtDumy)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1)
        Me.Name = "frmText全選択"
        Me.Text = "Text全選択"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txtDumy As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents btnメール As Button
    Friend WithEvents btnメール２ As Button
    Friend WithEvents btnメール3 As Button
End Class
