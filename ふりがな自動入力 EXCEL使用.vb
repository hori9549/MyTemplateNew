﻿''' <summary>
''' 210716 ふりがな自動入力(簡易版）_EXCEL使用
''' </summary>
Public Class frmふりがな自動入力_EXCEL使用
    Private Sub ふりがな自動入力_EXCEL使用_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txt変換元.Enter, AddressOf KanjiToKana
        txt変換元.Select()
    End Sub
    Private Sub KanjiToKana()

        Dim objExcel As New Microsoft.Office.Interop.Excel.Application



        Dim stKanji As String = txt変換元.Text

        Dim stKana As String



        stKana = objExcel.GetPhonetic(stKanji)
        txt結果.Text = stKana
        MessageBox.Show(stKana, "結果", MessageBoxButtons.OK)

    End Sub

    Private Sub btn変換_Click(sender As Object, e As EventArgs) Handles btn変換.Click
        Call KanjiToKana()
    End Sub



    ''' <summary>
    ''' イベントとプロシージャを結び付け
    ''' </summary>

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            AddHandler Button2.Click, AddressOf myclick
        End Sub
        Private Sub myclick(sender As Object, e As EventArgs)
            MsgBox(sender.name)
        End Sub

End Class