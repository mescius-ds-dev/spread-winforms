Public Class keepexcelsetting

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ファイル選択ダイアログ起動
        Dim fn As String = ""
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Excelファイル(*.xlsx;*.xlsm)|*.xlsx;*.xlsm"
            If ofd.ShowDialog() = DialogResult.OK Then
                fn = ofd.FileName
            Else
                Return
            End If
        End Using

        ' Excelファイルのインポート（Excelの情報を維持）
        FpSpread1.OpenExcel(fn, FarPoint.Excel.ExcelOpenFlags.DocumentCaching Or FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns)

        ' SPREADの値を変更
        FpSpread1.ActiveSheet.Cells(0, 0).Value = "test"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' ファイル保存ダイアログ起動
        Dim fn As String = ""
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excelファイル(*.xlsx;*.xlsm)|*.xlsx;*.xlsm"
            sfd.FileName = "SpreadClickOnceデモ2.xlsx"
            If sfd.ShowDialog() = DialogResult.OK Then
                fn = sfd.FileName
            Else
                Return
            End If
        End Using

        ' Excelファイルのエクスポート（Excelの情報を維持）
        FpSpread1.SaveExcel(fn, FarPoint.Excel.ExcelSaveFlags.DocumentCaching Or FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat)
    End Sub
End Class
