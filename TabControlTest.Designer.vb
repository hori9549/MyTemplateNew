<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabControl
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
        Me.tabTabTest = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.btnP1 = New System.Windows.Forms.Button()
        Me.btnP2 = New System.Windows.Forms.Button()
        Me.btn = New System.Windows.Forms.Button()
        Me.tabTabTest.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabTabTest
        '
        Me.tabTabTest.Controls.Add(Me.tabPage1)
        Me.tabTabTest.Controls.Add(Me.tabPage2)
        Me.tabTabTest.Location = New System.Drawing.Point(172, 115)
        Me.tabTabTest.Name = "tabTabTest"
        Me.tabTabTest.SelectedIndex = 0
        Me.tabTabTest.Size = New System.Drawing.Size(300, 220)
        Me.tabTabTest.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.btnP1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(292, 194)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "ページ１"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.btnP2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(292, 194)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "ページ２"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'btnP1
        '
        Me.btnP1.Location = New System.Drawing.Point(53, 67)
        Me.btnP1.Name = "btnP1"
        Me.btnP1.Size = New System.Drawing.Size(65, 36)
        Me.btnP1.TabIndex = 0
        Me.btnP1.Text = "メッセージを出すP1"
        Me.btnP1.UseVisualStyleBackColor = True
        '
        'btnP2
        '
        Me.btnP2.Location = New System.Drawing.Point(114, 79)
        Me.btnP2.Name = "btnP2"
        Me.btnP2.Size = New System.Drawing.Size(65, 36)
        Me.btnP2.TabIndex = 1
        Me.btnP2.Text = "メッセージを出す P2"
        Me.btnP2.UseVisualStyleBackColor = True
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(655, 359)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(114, 50)
        Me.btn.TabIndex = 1
        Me.btn.Text = "もどる"
        Me.btn.UseVisualStyleBackColor = True
        '
        'frmTabControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.tabTabTest)
        Me.Name = "frmTabControl"
        Me.Text = "TabControlTest"
        Me.tabTabTest.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabTabTest As TabControl
    Friend WithEvents tabPage1 As TabPage
    Friend WithEvents tabPage2 As TabPage
    Friend WithEvents btnP1 As Button
    Friend WithEvents btnP2 As Button
    Friend WithEvents btn As Button
End Class
