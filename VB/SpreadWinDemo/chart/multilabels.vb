Imports FarPoint.Win.Chart

Public Class multilabels

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータ
        FpSpread1.ActiveSheet.Cells(1, 1).Value = "s1"
        FpSpread1.ActiveSheet.Cells(2, 1).Value = "s2"
        FpSpread1.ActiveSheet.Cells(3, 1).Value = "s3"
        FpSpread1.ActiveSheet.Cells(4, 1).Value = "s4"
        FpSpread1.ActiveSheet.Cells(5, 1).Value = "s5"
        FpSpread1.ActiveSheet.Cells(6, 1).Value = "s6"
        FpSpread1.ActiveSheet.Cells(1, 2).Value = 7
        FpSpread1.ActiveSheet.Cells(2, 2).Value = 8
        FpSpread1.ActiveSheet.Cells(3, 2).Value = 9
        FpSpread1.ActiveSheet.Cells(4, 2).Value = 10
        FpSpread1.ActiveSheet.Cells(5, 2).Value = 11
        FpSpread1.ActiveSheet.Cells(6, 2).Value = 12
        FpSpread1.ActiveSheet.Cells(1, 0).Value = "Category1"
        FpSpread1.ActiveSheet.Cells(3, 0).Value = "Category2"

        ' チャートの追加
        Dim range As New FarPoint.Win.Spread.Model.CellRange(1, 0, 6, 3)
        FpSpread1.ActiveSheet.AddChart(range, GetType(BarSeries), 300, 300, 250, 50, ChartViewType.View2D, False)

        ' コンテキストメニューを有効
        FpSpread1.ActiveSheet.Charts(0).ContextMenuStrip = New FarPoint.Win.Spread.Chart.SpreadChartContextMenuStrip()

        ' 複数レベルの項目軸ラベルを有効
        Dim PlotArea = CType((FpSpread1.Sheets(0).Charts(0).Model.PlotAreas(0)), YPlotArea)
        PlotArea.XAxis.MultiLevel = True
    End Sub
End Class
