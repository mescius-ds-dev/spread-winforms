Public Class outline

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum2.xml"))
        sheet.DataSource = ds

        ' シート設定
        sheet.FrozenRowCount = 2

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 141
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80
        sheet.Columns(6).Width = 80

        ' 列の追加
        sheet.AddColumns(sheet.ColumnCount, 1)
        sheet.Columns(sheet.ColumnCount - 1).Width = 80

        ' 行の追加
        sheet.AddUnboundRows(sheet.RowCount, 1)

        ' セル型の設定
        Dim currcell As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        sheet.Columns(3, sheet.ColumnCount - 1).CellType = currcell

        ' 合計行／列の設定
        sheet.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        sheet.ColumnHeader.Cells(0, sheet.ColumnCount - 1).Value = "合計"
        sheet.RowHeader.Cells(sheet.RowCount - 1, 0).Value = "合計"
        For row As Integer = 0 To sheet.RowCount - 2
            sheet.Cells(row, sheet.ColumnCount - 1).Formula = "SUM(RC[-4]:RC[-1])"
        Next
        For col As Integer = 3 To sheet.ColumnCount - 1
            sheet.Cells(sheet.RowCount - 1, col).Formula = "SUM(R[-11]C:R[-1]C)"
        Next

        ' アウトラインの設定
        sheet.AddRangeGroup(0, 12, True)
        sheet.AddRangeGroup(3, 4, False)
        Dim rgi As FarPoint.Win.Spread.RangeGroupInfo() = sheet.Columns.GetRangeGroupInfo(1)
        sheet.ExpandRangeGroup(rgi(0), False, False)
    End Sub
End Class
