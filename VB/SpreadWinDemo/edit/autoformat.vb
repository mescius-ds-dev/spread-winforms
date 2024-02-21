Public Class autoformat

    Public Sub New()

        InitializeComponent()

        ' 数式のオートフォーマットを有効
        Dim workbook As GrapeCity.Spreadsheet.IWorkbook = FpSpread1.AsWorkbook()
        workbook.Features.AutoFormatting = True

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())

        CheckBox1.Checked = True
    End Sub

    Private Sub InitWorkbook(workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        workbook.ActiveSheet.Columns(0, 3).ColumnWidth = 150
        workbook.ActiveSheet.ColumnHeader.Cells(0, 0).Text = "書式"
        workbook.ActiveSheet.ColumnHeader.Cells(0, 1).Text = "関数"
        workbook.ActiveSheet.ColumnHeader.Cells(0, 2).Text = "表示"
        workbook.ActiveSheet.ColumnHeader.Cells(0, 3).Text = "参照用データ"

        ' 参照用データ
        workbook.ActiveSheet.Cells(4, 3).Value = 500
        workbook.ActiveSheet.Cells(5, 3).Value = 1000
        workbook.ActiveSheet.Cells(4, 3, 5, 3).NumberFormat = "¥#,##0;¥-#,##0"

        ' 日付書式
        FpSpread1.AsWorkbook().ActiveSheet.Cells(0, 0).Text = "日付書式"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(0, 0, 1, 0).Merge()
        FpSpread1.AsWorkbook().ActiveSheet.Cells(0, 1).Text = "Today()"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(0, 2).Formula = "Today()"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(1, 1).Text = "Date(2021, 1, 1)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(1, 2).Formula = "Date(2021, 1, 1)"

        ' 数値書式
        FpSpread1.AsWorkbook().ActiveSheet.Cells(2, 0).Text = "数値書式"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(2, 0, 3, 0).Merge()
        FpSpread1.AsWorkbook().ActiveSheet.Cells(2, 1).Text = "RATE(60,-5,150)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(2, 2).Formula = "RATE(60,-5,150)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(3, 1).Text = "DB(500000,5000,5,1,10)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(3, 2).Formula = "DB(500000,5000,5,1,10)"

        ' セル参照書式
        FpSpread1.AsWorkbook().ActiveSheet.Cells(4, 0).Text = "セル参照書式"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(4, 0, 5, 0).Merge()
        FpSpread1.AsWorkbook().ActiveSheet.Cells(4, 1).Text = "SUM(D5:D6)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(4, 2).Formula = "SUM(D5:D6)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(5, 1).Text = "AVERAGE(D5:D6)"
        FpSpread1.AsWorkbook().ActiveSheet.Cells(5, 2).Formula = "AVERAGE(D5:D6)"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim workbook As GrapeCity.Spreadsheet.IWorkbook = FpSpread1.AsWorkbook()
        If CheckBox1.Checked Then
            workbook.Features.AutoFormatting = True
        Else
            workbook.Features.AutoFormatting = False
        End If

        FpSpread1.ActiveSheet.Reset()
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub
End Class
