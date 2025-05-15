Public Class cellformat

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

        ' ヘッダの設定
        workbook.ActiveSheet.Columns(0, 2).ColumnWidth = 200
        workbook.ActiveSheet.ColumnHeader.Cells(0, 0).Value = "分類"
        workbook.ActiveSheet.ColumnHeader.Cells(0, 1).Value = "スタイル"
        workbook.ActiveSheet.ColumnHeader.Cells(0, 2).Value = "表示"

        ' 背景色の設定
        workbook.ActiveSheet.Columns(0, 1).Interior.Color = GrapeCity.Spreadsheet.Color.FromThemeColor(GrapeCity.Core.ThemeColors.Background2)

        ' 標準
        workbook.ActiveSheet.Cells(0, 0).Value = "標準"
        workbook.ActiveSheet.Cells(0, 2).NumberFormat = "G/標準"
        workbook.ActiveSheet.Cells(0, 2).Value = 12345

        ' 数値
        ' 桁区切り
        workbook.ActiveSheet.Cells(1, 0).Value = "数値"
        workbook.ActiveSheet.Cells(1, 1).Value = "桁区切り"
        workbook.ActiveSheet.Cells(1, 2).NumberFormat = "#,##0_ "
        workbook.ActiveSheet.Cells(1, 2).Value = 12345
        ' マイナス
        workbook.ActiveSheet.Range("A2:A3").Merge()
        workbook.ActiveSheet.Cells(2, 1).Value = "マイナスは赤で表示"
        workbook.ActiveSheet.Cells(2, 2).NumberFormat = "0_ ;[赤]-0 "
        workbook.ActiveSheet.Cells(2, 2).Value = -12345

        ' 通貨
        ' 桁区切り
        workbook.ActiveSheet.Cells(3, 0).Value = "通貨"
        workbook.ActiveSheet.Cells(3, 1).Value = "桁区切り"
        workbook.ActiveSheet.Cells(3, 2).NumberFormat = "¥#,##0;¥-#,##0"
        workbook.ActiveSheet.Cells(3, 2).Value = 12345
        ' マイナス
        workbook.ActiveSheet.Range("A4:A5").Merge()
        workbook.ActiveSheet.Cells(4, 1).Value = "マイナスは赤で表示"
        workbook.ActiveSheet.Cells(4, 2).NumberFormat = "¥#,##0;[赤]¥-#,##0"
        workbook.ActiveSheet.Cells(4, 2).Value = -12345

        ' 会計
        workbook.ActiveSheet.Cells(5, 0).Value = "会計"
        workbook.ActiveSheet.Cells(5, 2).NumberFormat = "_ ¥* #,##0_ ;_ ¥* -#,##0_ ;_ ¥* "" - ""_ ;_ @_ "
        workbook.ActiveSheet.Cells(5, 2).Value = -12345

        ' 日付
        ' 西暦
        workbook.ActiveSheet.Cells(6, 0).Value = "日付"
        workbook.ActiveSheet.Cells(6, 1).Value = "西暦"
        workbook.ActiveSheet.Cells(6, 2).NumberFormat = "yyyy""年""m""月""d""日"""
        workbook.ActiveSheet.Cells(6, 2).Value = DateTime.Now
        ' 和暦
        workbook.ActiveSheet.Range("A7:A8").Merge()
        workbook.ActiveSheet.Cells(7, 1).Value = "和暦"
        workbook.ActiveSheet.Cells(7, 2).NumberFormat = "[$-ja-JP]ggge""年""m""月""d""日"""
        workbook.ActiveSheet.Cells(7, 2).Value = DateTime.Now

        ' 時刻
        ' 24時間表記
        workbook.ActiveSheet.Cells(8, 0).Value = "時刻"
        workbook.ActiveSheet.Cells(8, 1).Value = "24時間表記"
        workbook.ActiveSheet.Cells(8, 2).NumberFormat = "h:mm:ss;@"
        workbook.ActiveSheet.Cells(8, 2).Value = DateTime.Now
        ' AM/PM表記
        workbook.ActiveSheet.Range("A9:A10").Merge()
        workbook.ActiveSheet.Cells(9, 1).Value = "AM/PM表記"
        workbook.ActiveSheet.Cells(9, 2).NumberFormat = "h:mm AM/PM;@"
        workbook.ActiveSheet.Cells(9, 2).Value = DateTime.Now

        ' パーセンテージ
        workbook.ActiveSheet.Cells(10, 0).Value = "パーセンテージ"
        workbook.ActiveSheet.Cells(10, 2).NumberFormat = "0%"
        workbook.ActiveSheet.Cells(10, 2).Value = 0.12

        ' 分数
        workbook.ActiveSheet.Cells(11, 0).Value = "分数"
        workbook.ActiveSheet.Cells(11, 2).NumberFormat = "# ?/?"
        workbook.ActiveSheet.Cells(11, 2).Value = 8.333

        ' 指数
        workbook.ActiveSheet.Cells(12, 0).Value = "指数"
        workbook.ActiveSheet.Cells(12, 2).NumberFormat = "0.E+00"
        workbook.ActiveSheet.Cells(12, 2).Value = 1234567890

        ' 文字列
        workbook.ActiveSheet.Cells(13, 0).Value = "文字列"
        workbook.ActiveSheet.Cells(13, 2).NumberFormat = "@"
        workbook.ActiveSheet.Cells(13, 2).Value = "12345"
    End Sub
End Class
