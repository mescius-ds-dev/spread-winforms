Public Class formulasparkline

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitSpread(ByVal spread As FarPoint.Win.Spread.FpSpread)
        spread.Features.EnhancedShapeEngine = True

        InitAreaSparkline(spread.ActiveSheet)
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9
    End Sub

    Private Sub InitAreaSparkline(ByVal sheetView As FarPoint.Win.Spread.SheetView)
        Dim worksheet = sheetView.AsWorksheet()
        worksheet.Name = "Area"
        worksheet.Cells("A1:E1").Merge()
        worksheet.Rows("1").RowHeight = 32

        worksheet.Cells("A1").Text = "Revenue by State"
        worksheet.Cells("A1").VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center
        worksheet.Cells("A1").Font.ApplyFont(New GrapeCity.Spreadsheet.Font() With {
            .Name = "Arial",
            .Size = 17
        })

        Dim table = worksheet.Tables.Add("A2:E6", GrapeCity.Spreadsheet.YesNoGuess.Guess, FarPoint.Win.Spread.TableStyle.TableStyleLight1)
        table.ShowAutoFilter = False

        worksheet.SetValue(1, 0, New Object(,) {
        {"State", 2018, 2019, 2020, "Diagram"},
        {"Idaho", 10000, -9000, 15000, Nothing},
        {"Montana", 1000, 9000, Nothing, Nothing},
        {"Oregon", 10000, 7000, 0, Nothing},
        {"Washington", 1000, 10000, 5000, Nothing},
        {"Utah", -5000, 5000, 12000, Nothing}})

        worksheet.Cells("B3:D7").CellType = New FarPoint.Win.Spread.CellType.CurrencyCellType() With {
            .DecimalPlaces = 0
        }
        worksheet.Cells("E3").Formula = "AREASPARKLINE(B3:D3,,,0,10000,""#82bc00"",""#f7a711"")"
        worksheet.Cells("E4").Formula = "AREASPARKLINE(B4:D4,,,0,10000,""#82bc00"",""#f7a711"")"
        worksheet.Cells("E5").Formula = "AREASPARKLINE(B5:D5,,,0,10000,""#82bc00"",""#f7a711"")"
        worksheet.Cells("E6").Formula = "AREASPARKLINE(B6:D6,,,0,10000,""#82bc00"",""#f7a711"")"
        worksheet.Cells("E7").Formula = "AREASPARKLINE(B7:D7,,,0,10000,""#82bc00"",""#f7a711"")"

        worksheet.Rows("1").RowHeight = 50
        worksheet.Rows("2").RowHeight = 25
        worksheet.Rows("3:7").RowHeight = 35

        worksheet.Columns("A").ColumnWidth = 100
        worksheet.Columns("B:D").ColumnWidth = 80
        worksheet.Columns("E").ColumnWidth = 200
    End Sub

End Class
