Public Class treemap
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetArray(0, 0, New Object(,) {{"A", "", "", "", "B", "", "", "C", "", "D"}})
        sheet.SetArray(1, 0, New Object(,) {{"A-1", "", "", "A-2", "B-1", "B-2", "B-3", "C-1", "C-2", "D-1"}})
        sheet.SetArray(2, 0, New Object(,) {{"A-1-1", "A-1-2", "A-1-3", "", "", "", "", "", "", ""}})
        sheet.SetArray(3, 0, New Object(,) {{1, 2, 4, 8, 12, 1, 2, 4, 8, 12}})

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.TreemapSeries()
        series1.SeriesName = "s1"
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$J$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$4:$J$4")

        ' プロット領域を作成
        Dim plotArea As New FarPoint.Win.Chart.TreemapPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.7F, 0.8F)
        plotArea.Series.Add(series1)

        ' 凡例を設定
        Dim legend As New FarPoint.Win.Chart.LegendArea()
        legend.Location = New System.Drawing.PointF(0.95F, 0.5F)
        legend.AlignmentX = 1.0F
        legend.AlignmentY = 0.5F

        ' チャートモデルに各情報を追加
        Dim model As New FarPoint.Win.Chart.ChartModel()
        model.LegendAreas.Add(legend)
        model.PlotAreas.Add(plotArea)

        ' SPREADチャートにチャートモデルを設定
        Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
        chart.Size = New Size(450, 250)
        chart.Location = New Point(0, 120)
        chart.Model = model

        ' シートにSPREADチャートを追加
        sheet.Charts.Add(chart)
    End Sub
End Class
