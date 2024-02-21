Public Class openexcelfile

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim fn As String = ""
        ' ファイル選択ダイアログ起動
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Excelファイル(*.xls;*.xlsx)|*.xls;*.xlsx"
            If ofd.ShowDialog() = DialogResult.OK Then
                fn = ofd.FileName
            Else
                Return
            End If
        End Using

        ' excelファイル読込
        FpSpread1.OpenExcel(fn, FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns)
    End Sub
End Class
