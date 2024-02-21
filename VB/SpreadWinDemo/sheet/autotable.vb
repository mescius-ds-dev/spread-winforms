Public Class autotable

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSpread(ByVal spread As FarPoint.Win.Spread.FpSpread)
        ' ユーザーに数式の入力を許可
        spread.AllowUserFormulas = True
    End Sub

    Private Sub InitSheet(ByVal sheet As FarPoint.Win.Spread.SheetView)
        sheet.RowCount = 60
        sheet.ColumnCount = 11

        FpSpread1.Features.AutoExpandTable = True
        FpSpread1.Features.AutoCreateCalculatedTableColumns = True
        Dim workBook As GrapeCity.Spreadsheet.IWorkbook = FpSpread1.AsWorkbook()
        Dim sheet1 As GrapeCity.Spreadsheet.IWorksheet = workBook.Worksheets(0)
        Dim table1 As GrapeCity.Spreadsheet.ITable = sheet1.Cells("B2:E7").CreateTable(True)
        sheet1.SetValue(1, 1, New Object(,) {
        {"ID", "Qty", "Price"},
        {1, 10, 9.5},
        {2, 15, 7.25},
        {3, 8, 16.0},
        {4, 12, 8.2},
        {5, 22, 11.52}})
        sheet1.Cells("E2").Value = "合計"
        table1.TableColumns(2).DataBodyRange.NumberFormat = "$0.00"
        table1.TableColumns(3).DataBodyRange.NumberFormat = "$0.00"
    End Sub
End Class
