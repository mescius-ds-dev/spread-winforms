Public Class headerfooterformula

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum2.xml"))
        sheet.DataSource = ds
    End Sub

    Private Sub InitWorkbook(workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        ' 合計列追加
        workbook.ActiveSheet.InsertColumns(7, 1)
        workbook.ActiveSheet.ColumnHeader.Cells(0, 7).Text = "総合計"

        ' 列合計の算出
        workbook.ActiveSheet.ColumnFooter.Visible = True
        workbook.ActiveSheet.ColumnFooter.Cells(0, 3).Formula = "SUM(Sheet1!D:D)"
        workbook.ActiveSheet.ColumnFooter.Cells(0, 4).Formula = "SUM(Sheet1!E:E)"
        workbook.ActiveSheet.ColumnFooter.Cells(0, 5).Formula = "SUM(Sheet1!F:F)"
        workbook.ActiveSheet.ColumnFooter.Cells(0, 6).Formula = "SUM(Sheet1!G:G)"

        ' 総合計の算出
        workbook.ActiveSheet.ColumnFooter.Cells(0, 7).Formula = "SUM(Sheet1[[#集計],$D$1:$G$1])"

        ' 列幅の設定
        workbook.ActiveSheet.Columns(0).ColumnWidth = 45
        workbook.ActiveSheet.Columns(1).ColumnWidth = 85
        workbook.ActiveSheet.Columns(2).ColumnWidth = 135
        workbook.ActiveSheet.Columns(3).ColumnWidth = 65
        workbook.ActiveSheet.Columns(4).ColumnWidth = 65
        workbook.ActiveSheet.Columns(5).ColumnWidth = 65
        workbook.ActiveSheet.Columns(6).ColumnWidth = 65
        workbook.ActiveSheet.Columns(7).ColumnWidth = 103
    End Sub
End Class
