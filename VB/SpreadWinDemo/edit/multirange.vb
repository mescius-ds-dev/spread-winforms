Public Class multirange

    Public Sub New()

        InitializeComponent()

        FpSpread1.Features.RichClipboard = True

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        FpSpread1.Sheets.Count = 2
        FpSpread1.Sheets(0).SheetName = "単一から複数"
        FpSpread1.Sheets(0).Cells("B2").Value = 1
        FpSpread1.Sheets(0).Cells("B3").Value = 2
        FpSpread1.Sheets(0).Cells("C2").Value = 3
        FpSpread1.Sheets(0).Cells("C3").Value = 4
        FpSpread1.Sheets(0).Cells("B10").Value = "単一のセル範囲をコピーして複数のセル範囲にペースト"
        FpSpread1.Sheets(0).Cells("B11").Value = "1.セルB2からC3を選択します"
        FpSpread1.Sheets(0).Cells("B12").Value = "2.［Ctrl］+［C］をタイプしてコピーします"
        FpSpread1.Sheets(0).Cells("B13").Value = "3.セルB5をクリックし［Ctrl］を押下しながらセルB8をクリックします"
        FpSpread1.Sheets(0).Cells("B14").Value = "4.［Ctrl］+［V］でペーストします"
        FpSpread1.Sheets(0).Cells("B10").ColumnSpan = 6
        FpSpread1.Sheets(0).Cells("B11").ColumnSpan = 6
        FpSpread1.Sheets(0).Cells("B12").ColumnSpan = 6
        FpSpread1.Sheets(0).Cells("B13").ColumnSpan = 6
        FpSpread1.Sheets(0).Cells("B14").ColumnSpan = 6

        FpSpread1.Sheets(1).SheetName = "複数から単一"
        FpSpread1.Sheets(1).Cells("B2").Value = 1
        FpSpread1.Sheets(1).Cells("B3").Value = 2
        FpSpread1.Sheets(1).Cells("B4").Value = 3
        FpSpread1.Sheets(1).Cells("B5").Value = 4
        FpSpread1.Sheets(1).Cells("B7").Value = "1.セルB2をクリックし［Ctrl］を押下しながらセルB4とB5をクリックします"
        FpSpread1.Sheets(1).Cells("B8").Value = "2.［Ctrl］+［C］をタイプしてコピーします"
        FpSpread1.Sheets(1).Cells("B9").Value = "3.セルD2をクリックし［Ctrl］+［V］でペーストします"
        FpSpread1.Sheets(1).Cells("B7").ColumnSpan = 6
        FpSpread1.Sheets(1).Cells("B8").ColumnSpan = 6
        FpSpread1.Sheets(1).Cells("B9").ColumnSpan = 6
    End Sub
End Class
