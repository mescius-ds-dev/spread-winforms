Public Class enhancedborder

    Public Sub New()

        InitializeComponent()

        ' シート設定
        InitSpreadStyles(FpSpread1.Sheets(0))

        CheckBox1.Checked = True
    End Sub

    Private Sub InitSpreadStyles(ByVal sheet As FarPoint.Win.Spread.SheetView)
        ' 行列数の設定
        sheet.RowCount = 10
        sheet.ColumnCount = 5

        For r As Integer = 1 To 3
            For c As Integer = 1 To 3
                FpSpread1.AsWorkbook().ActiveSheet.Cells(r, c).Borders.LineStyle = GrapeCity.Spreadsheet.BorderLineStyle.Double
            Next
        Next

        For r As Integer = 5 To 7
            For c As Integer = 1 To 3
                FpSpread1.AsWorkbook().ActiveSheet.Cells(r, c).Borders.LineStyle = GrapeCity.Spreadsheet.BorderLineStyle.Thick
            Next
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' 拡張罫線を有効にする
            FpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Enhanced
        Else
            ' 拡張罫線を無効にする
            FpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Collapse
        End If
    End Sub
End Class
