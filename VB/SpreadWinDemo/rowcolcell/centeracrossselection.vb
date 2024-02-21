Public Class centeracrossselection

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        ' セルのオーバーフローを有効
        FpSpread1.AllowCellOverflow = True
        ' 拡張罫線を有効
        FpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Enhanced

        FpSpread1.AsWorkbook().ActiveSheet.Cells("C2").Text = "SPREAD for Windows Forms"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("C2:K2").HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection
        FpSpread1.AsWorkbook().ActiveSheet.Cells("C3").Text = "SPREAD for Windows Forms"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("C3").HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection
        FpSpread1.AsWorkbook().ActiveSheet.Cells("C4").Text = "SPREAD for Windows Forms"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("C4:D4").HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection
        FpSpread1.AsWorkbook().ActiveSheet.Cells("C5").Text = "SPREAD for Windows Forms"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("B5:C5").HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection
    End Sub
End Class
