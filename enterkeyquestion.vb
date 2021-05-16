
Imports System.IO   ''CSV ファイル操作用
Imports System.Text ''CSV エンコード時使用


'                '[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す

Public Class frmEnterNext
    Private dtbl社員マスタ As New DataTable

    Private Sub frmEnterNext_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'フォームがすべてのキー イベントを受け取る
        Me.KeyPreview = True
    End Sub
    ''' <summary>
    ''' フォームKeyDownイベント
    ''' </summary>
    Private Sub frmEnterNext_KeyDown(ByVal sender As Object,
                                     ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                '[Enter]キーで次の TabIndex があるコントロールへフォーカスを移す
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' フォームKeyPressイベント
    ''' </summary>
    Private Sub frmEnterNext_KeyPress(ByVal sender As Object,
                                      ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            '[Enter]キーで音が出るので、キーイベントが処理されたことにして音を消す
            e.Handled = True
        End If
    End Sub

    '' <summary>
    '' フォームロードイベント
    '' </summary>



    Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click

        'getデータ 未完成  カシオパイア参照

        Dim SFD As New SaveFileDialog
        With SFD
            .FileName = "fileA.csv"
            .Filter = "csv|*.csv"
            .Title = "ファイル名を入力してください。"
            .RestoreDirectory = True
            .CheckPathExists = True
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                'Console.WriteLine(.FileName)
                Try
                    System.IO.File.Delete(.FileName)


                Catch ex As Exception
                    MessageBox.Show(.FileName & "は開かれています")
                    Exit Sub

                End Try

                '
                'データー書き出し
                '
                Dim sCSV As String = ""
                Dim sヘッダ As String = ""
                Dim sデータ As String = ""
                ''ヘッダ作成
                'For i As Integer = 0 To get行.ItemArray.Length - 1
                '    If sデータ <> "" Then sデータ += "," ''カンマを付加
                '    sデータ += """" + get行(i).ToString + """"
                'Next
                'sCSV += sデータ & vbCrLf
                'Next
                Dim SW As New StreamWriter(SFD.FileName, True, Encoding.Default)
                Call SW.WriteLine(sCSV)  ''データ書き込み
                Call SW.Close()


            Else
                Exit Sub
            End If
        End With


    End Sub
    Public Sub bCSV出力(ByVal CSVファイル名 As String, ByVal setテーブル As DataTable)
        Dim sCSV As String = ""
        Dim sヘッダ As String = ""
        Dim sデータ As String = ""
        ''ヘッダ作成
        For i_Col As Integer = 0 To setテーブル.Columns.Count - 1
            If sヘッダ <> "" Then sヘッダ += "," ''カンマを付加
            sヘッダ += """" + setテーブル.Columns(i_Col).ColumnName + """"
        Next
        sCSV = sヘッダ + vbCrLf
        ''データ作成
        For Each get行 As DataRow In setテーブル.Rows
            sデータ = ""
            For i As Integer = 0 To get行.ItemArray.Length - 1
                If sデータ <> "" Then sデータ += "," ''カンマを付加
                sデータ += """" + get行(i).ToString + """"
            Next
            sCSV += sデータ & vbCrLf
        Next
        Dim SW As New StreamWriter(CSVファイル名, False, Encoding.Default)
        Call SW.WriteLine(sCSV)  ''データ書き込み
        Call SW.Close()
    End Sub








End Class