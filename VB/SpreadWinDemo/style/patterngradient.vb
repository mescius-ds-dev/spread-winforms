Public Class patterngradient

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        workbook.ActiveSheet.Rows(1, 5).RowHeight = 72

        ' グラデーション
        workbook.ActiveSheet.Cells(0, 0).Value = "グラデーション"
        workbook.ActiveSheet.Cells(0, 0).HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.Center
        workbook.ActiveSheet.Range("A1:D1").Merge()

        ' グラデーション 横
        workbook.ActiveSheet.Cells(1, 0).Value = "横"

        Dim cell11 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(1, 1)
        cell11.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell11.Interior.Gradient.Degree = 90
        cell11.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell11.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell12 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(1, 2)
        cell12.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell12.Interior.Gradient.Degree = 270
        cell12.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell12.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell13 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(1, 3)
        cell13.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell13.Interior.Gradient.Degree = 90
        cell13.Interior.Gradient.ColorStops.Add(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell13.Interior.Gradient.ColorStops.Add(0.5).ThemeColor = GrapeCity.Core.ThemeColors.Accent1
        cell13.Interior.Gradient.ColorStops.Add(1).ThemeColor = GrapeCity.Core.ThemeColors.Background1

        ' グラデーション 縦
        workbook.ActiveSheet.Cells(2, 0).Value = "縦"

        Dim cell21 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(2, 1)
        cell21.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell21.Interior.Gradient.Degree = 0
        cell21.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell21.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell22 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(2, 2)
        cell22.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell22.Interior.Gradient.Degree = 180
        cell22.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell22.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell23 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(2, 3)
        cell23.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell23.Interior.Gradient.Degree = 0
        cell23.Interior.Gradient.ColorStops.Add(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell23.Interior.Gradient.ColorStops.Add(0.5).ThemeColor = GrapeCity.Core.ThemeColors.Accent1
        cell23.Interior.Gradient.ColorStops.Add(1).ThemeColor = GrapeCity.Core.ThemeColors.Background1

        ' グラデーション 右上対角線
        workbook.ActiveSheet.Cells(3, 0).Value = "右上対角線"

        Dim cell31 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(3, 1)
        cell31.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell31.Interior.Gradient.Degree = 45
        cell31.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell31.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell32 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(3, 2)
        cell32.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell32.Interior.Gradient.Degree = 225
        cell32.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell32.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell33 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(3, 3)
        cell33.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell33.Interior.Gradient.Degree = 45
        cell33.Interior.Gradient.ColorStops.Add(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell33.Interior.Gradient.ColorStops.Add(0.5).ThemeColor = GrapeCity.Core.ThemeColors.Accent1
        cell33.Interior.Gradient.ColorStops.Add(1).ThemeColor = GrapeCity.Core.ThemeColors.Background1

        ' グラデーション 右下対角線
        workbook.ActiveSheet.Cells(4, 0).Value = "右下対角線"

        Dim cell41 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(4, 1)
        cell41.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell41.Interior.Gradient.Degree = 135
        cell41.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell41.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell42 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(4, 2)
        cell42.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell42.Interior.Gradient.Degree = 315
        cell42.Interior.Gradient.ColorStops(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell42.Interior.Gradient.ColorStops(1).ThemeColor = GrapeCity.Core.ThemeColors.Accent1

        Dim cell43 As GrapeCity.Spreadsheet.IRange = workbook.ActiveSheet.Cells(4, 3)
        cell43.Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LinearGradient
        cell43.Interior.Gradient.Degree = 135
        cell43.Interior.Gradient.ColorStops.Add(0).ThemeColor = GrapeCity.Core.ThemeColors.Background1
        cell43.Interior.Gradient.ColorStops.Add(0.5).ThemeColor = GrapeCity.Core.ThemeColors.Accent1
        cell43.Interior.Gradient.ColorStops.Add(1).ThemeColor = GrapeCity.Core.ThemeColors.Background1

        ' パターン
        workbook.ActiveSheet.Cells(0, 4).Value = "パターン"
        workbook.ActiveSheet.Cells(0, 4).HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.Center
        workbook.ActiveSheet.Range("E1:H1").Merge()

        ' パターン 75% 灰色
        workbook.ActiveSheet.Cells(1, 4).Value = "75% 灰色"
        workbook.ActiveSheet.Cells(1, 5).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.DarkGrid

        ' パターン 50% 灰色
        workbook.ActiveSheet.Cells(2, 4).Value = "50% 灰色"
        workbook.ActiveSheet.Cells(2, 5).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.MediumGray

        ' パターン 25% 灰色
        workbook.ActiveSheet.Cells(3, 4).Value = "25% 灰色"
        workbook.ActiveSheet.Cells(3, 5).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LightGray

        ' パターン 12.5% 灰色
        workbook.ActiveSheet.Cells(4, 4).Value = "12.5% 灰色"
        workbook.ActiveSheet.Cells(4, 5).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.Gray125

        ' パターン 6.25% 灰色
        workbook.ActiveSheet.Cells(1, 6).Value = "6.25% 灰色"
        workbook.ActiveSheet.Cells(1, 7).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.Gray0625

        ' パターン 横 縞
        workbook.ActiveSheet.Cells(2, 6).Value = "横 縞"
        workbook.ActiveSheet.Cells(2, 7).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.DarkHorizontal

        ' パターン 縦 縞
        workbook.ActiveSheet.Cells(3, 6).Value = "縦 縞"
        workbook.ActiveSheet.Cells(3, 7).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.DarkVertical

        ' パターン 実線 横 格子
        workbook.ActiveSheet.Cells(4, 6).Value = "実線 横 格子"
        workbook.ActiveSheet.Cells(4, 7).Interior.Pattern = GrapeCity.Spreadsheet.PatternType.LightGrid
    End Sub
End Class
