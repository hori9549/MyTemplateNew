<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx2_2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn閉じる = New System.Windows.Forms.Button()
        Me.btnConstructer = New System.Windows.Forms.Button()
        Me.btnConstractor2 = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.btnModuleCall = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(111, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "表示->ターミナルで" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "開発者用PowerShellを" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "開くとみれます" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btn閉じる
        '
        Me.btn閉じる.Location = New System.Drawing.Point(587, 379)
        Me.btn閉じる.Name = "btn閉じる"
        Me.btn閉じる.Size = New System.Drawing.Size(108, 42)
        Me.btn閉じる.TabIndex = 1
        Me.btn閉じる.Text = "もどる"
        Me.btn閉じる.UseVisualStyleBackColor = True
        '
        'btnConstructer
        '
        Me.btnConstructer.Location = New System.Drawing.Point(177, 108)
        Me.btnConstructer.Name = "btnConstructer"
        Me.btnConstructer.Size = New System.Drawing.Size(97, 62)
        Me.btnConstructer.TabIndex = 2
        Me.btnConstructer.Text = "コンストラクタ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "オーバーロード" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Integerの引数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "のTEST"
        Me.btnConstructer.UseVisualStyleBackColor = True
        '
        'btnConstractor2
        '
        Me.btnConstractor2.Location = New System.Drawing.Point(177, 199)
        Me.btnConstractor2.Name = "btnConstractor2"
        Me.btnConstractor2.Size = New System.Drawing.Size(97, 62)
        Me.btnConstractor2.TabIndex = 3
        Me.btnConstractor2.Text = "コンストラクタ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "オーバーロード" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Integerの引数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "のTEST"
        Me.btnConstractor2.UseVisualStyleBackColor = True
        '
        'btnClass
        '
        Me.btnClass.Location = New System.Drawing.Point(335, 108)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(97, 62)
        Me.btnClass.TabIndex = 4
        Me.btnClass.Text = "クラスを使う" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnClass.UseVisualStyleBackColor = True
        '
        'btnModuleCall
        '
        Me.btnModuleCall.Location = New System.Drawing.Point(10, 108)
        Me.btnModuleCall.Name = "btnModuleCall"
        Me.btnModuleCall.Size = New System.Drawing.Size(97, 62)
        Me.btnModuleCall.TabIndex = 5
        Me.btnModuleCall.Text = "Moduleの" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "テスト" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Irodukeを" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Module化"
        Me.btnModuleCall.UseVisualStyleBackColor = True
        '
        'frmEx2_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnModuleCall)
        Me.Controls.Add(Me.btnClass)
        Me.Controls.Add(Me.btnConstractor2)
        Me.Controls.Add(Me.btnConstructer)
        Me.Controls.Add(Me.btn閉じる)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEx2_2"
        Me.Text = "コンストラクタ。補間文字"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn閉じる As Button
    Friend WithEvents btnConstructer As Button
    Friend WithEvents btnConstractor2 As Button
    Friend WithEvents btnClass As Button
    Friend WithEvents btnModuleCall As Button
End Class
