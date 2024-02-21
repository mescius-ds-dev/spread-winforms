Imports FarPoint.Win.Spread

Public Class enhancedcamerashape

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())

        ' SPREADの設定
        InitSpread(FpSpread1)
    End Sub

    Private Sub InitSpread(ByVal spread As FarPoint.Win.Spread.FpSpread)
        spread.Features.EnhancedShapeEngine = True
        spread.Features.RichClipboard = True
        spread.Sheets.Count = 4
        AddHandler spread.ComboSelChange, AddressOf fpSpread1_ComboSelChange

        InitAreaSparkline(spread.Sheets(3))
        InitPieSparkline(spread.Sheets(2))
        InitParetoSparkline(spread.Sheets(1))
        InitCameraShape(spread.Sheets(0))
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9
    End Sub

    Private Sub InitCameraShape(ByVal sheetView As FarPoint.Win.Spread.SheetView)
        Dim worksheet = sheetView.AsWorksheet()
        Dim workbook = worksheet.Workbook
        worksheet.Name = "CameraShape"

        worksheet.SetValue(1, 0, "Select :")
        worksheet.Cells("B2").CellType = New FarPoint.Win.Spread.CellType.ComboBoxCellType() With {
            .Items = New String() {"Late Arrivals By Reported Cause", "My Assets", "Revenue By State"},
            .EditorValue = FarPoint.Win.Spread.CellType.EditorValue.Index,
            .StopEditingAfterDropDownItemSelected = True
        }
        worksheet.Cells("B2").Value = 0
        workbook.Names.Add("SelectedRange", "=IF(CameraShape!$B$2=0,Pareto!$A$1:$E$8,IF(CameraShape!$B$2=1,Pie!$A$1:$D$8,Area!$A$1:$D$7))")
        worksheet.Columns("A:B").AutoFit()

        workbook.Worksheets(1).Cells("$A$1:$E$8").Copy(True)
        worksheet.Activate()
        worksheet.Pictures.Paste("A4", True)
        Clipboard.Clear()
    End Sub

    Private Sub InitParetoSparkline(ByVal sheetView As SheetView)
        Dim worksheet = sheetView.AsWorksheet()
        worksheet.Name = "Pareto"

        worksheet.SetValue(1, 0, New Object(,) {
        {"Reason", "Cases", "Color", "Bar Size", "Diagram"},
        {"Traffic", 20, "#CCCCCC", 0.1, Nothing},
        {"Child care", 15, "#82BC00", 0.3, Nothing},
        {"Public transportation", 13, "#F7A711", 0.5, Nothing},
        {"Weather", 6, "#00C2D6", 0.7, Nothing},
        {"Overslept", 4, "#FFE7BA", 0.8, Nothing},
        {"Emergency", 1, "#000000", 1, Nothing}})

        worksheet.Cells("A11:I11").Merge()
        worksheet.Cells("A11").Value = "*Result: By the sparkline above can draw a conclusion that the reasons For 80% Of the employees be late are ""traffic"", ""child care"" and ""public transportation""."

        For index As Integer = 2 To 8 - 1
            worksheet.Cells($"E{index + 1}").Formula2 = "PARETOSPARKLINE($B$3:$B$8,ROW()-2,$C$3:$C$8,0.5,0.8,0,2,false,""gray"",""orange"",$C$3:$C$8,$D$3:$D$8)"
        Next

        For i As Integer = 1 To 4 - 1
            worksheet.Columns($"{ChrW((i + 65))}").ColumnWidth = 80
        Next

        worksheet.Columns("E").ColumnWidth = 340
        worksheet.Columns("A").ColumnWidth = 140
        worksheet.Rows("1").RowHeight = 35
        worksheet.Cells("A1:E1").Merge()

        worksheet.Cells("A1").Value = "Late Arrivals by Reported Cause"
        worksheet.Cells("A1").VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center
        worksheet.Cells("A1").Font.ApplyFont(New GrapeCity.Spreadsheet.Font() With {
            .Name = "Arial",
            .Size = 10,
            .Bold = True
        })
        sheetView.Cells("A1").BackColor = System.Drawing.Color.Gray
        sheetView.Cells("A1").ForeColor = System.Drawing.Color.White

        worksheet.Cells("A2: d8").HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.Left
        worksheet.Cells("A2: E2").Font.ApplyFont(New GrapeCity.Spreadsheet.Font() With {
            .Name = "Arial",
            .Size = 10,
            .Bold = True
        })
        worksheet.Cells("A2: E2").Borders.ApplyBorder(New GrapeCity.Spreadsheet.Border() With {
            .Bottom = New GrapeCity.Spreadsheet.BorderLine(GrapeCity.Spreadsheet.BorderLineStyle.Thin, GrapeCity.Spreadsheet.Color.FromKnownColor(GrapeCity.Core.KnownColor.Black))
        })
    End Sub

    Private Sub InitPieSparkline(ByVal sheetView As FarPoint.Win.Spread.SheetView)
        Dim worksheet = sheetView.AsWorksheet()
        worksheet.Name = "Pie"

        worksheet.Cells("A1: d1").Merge()

        Dim range = worksheet.Cells("A1")
        range.Value = "My Assets"
        range.Font.ApplyFont(New GrapeCity.Spreadsheet.Font() With {
            .Name = "Arial",
            .Size = 17
        })
        range.VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center

        For i As Integer = 65 To 69 - 1
            sheetView.Cells($"{Convert.ToChar(i)}2").BackColor = ColorTranslator.FromHtml("#E3E3E3")
        Next

        worksheet.SetValue(1, 0, New Object(,) {
        {"Asset Type", "Amount", "Diagram", "Note"},
        {"House", 120000, Nothing, Nothing},
        {"401k", 78000, Nothing, Nothing},
        {"Savings", 25000, Nothing, Nothing},
        {"Bonds", 15000, Nothing, Nothing},
        {"Stocks", 9000, Nothing, Nothing},
        {"Car", 7500, Nothing, Nothing}})

        worksheet.Cells("C3:C8").Merge()
        worksheet.Cells("C3").Formula2 = "PIESPARKLINE(B3:b8, ""#82bc00"",""#96c63f"", ""#aacf62"", ""#bcd983"", ""#cee3a3"", ""#dfecc3"")"

        sheetView.Cells("D3").BackColor = ColorTranslator.FromHtml("#82bc00")
        worksheet.Cells("D3").Formula = "B3/SUM(B3:b8)"
        sheetView.Cells("D4").BackColor = ColorTranslator.FromHtml("#96c63f")
        worksheet.Cells("D4").Formula = "B4/SUM(B3:b8)"
        sheetView.Cells("D5").BackColor = ColorTranslator.FromHtml("#aacf62")
        worksheet.Cells("D5").Formula = "B5/SUM(B3:b8)"
        sheetView.Cells("D6").BackColor = ColorTranslator.FromHtml("#bcd983")
        worksheet.Cells("D6").Formula = "B6/SUM(B3:b8)"
        sheetView.Cells("D7").BackColor = ColorTranslator.FromHtml("#cee3a3")
        worksheet.Cells("D7").Formula = "B7/SUM(B3:b8)"
        sheetView.Cells("D8").BackColor = ColorTranslator.FromHtml("#dfecc3")
        worksheet.Cells("D8").Formula = "B8/SUM(B3:b8)"

        worksheet.Cells("D3:d8").CellType = New FarPoint.Win.Spread.CellType.PercentCellType() With {
            .DecimalPlaces = 2
        }
        worksheet.Cells("B3: b8").CellType = New FarPoint.Win.Spread.CellType.CurrencyCellType() With {
            .ShowCurrencySymbol = True,
            .DecimalPlaces = 0,
            .ShowSeparator = True,
            .CurrencySymbol = "$"
        }

        worksheet.Rows("1").RowHeight = 30
        worksheet.Rows("2:8").RowHeight = 25
        worksheet.Columns("A").ColumnWidth = 100
        worksheet.Columns("B").ColumnWidth = 100
        worksheet.Columns("C").ColumnWidth = 200
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

    Private Sub fpSpread1_ComboSelChange(sender As Object, e As EventArgs)
        FpSpread1.AsWorkbook().ActiveSheet.Shapes(0).Formula = "SelectedRange"
    End Sub
End Class
