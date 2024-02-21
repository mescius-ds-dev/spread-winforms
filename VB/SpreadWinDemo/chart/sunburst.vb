Public Class sunburst
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetArray(0, 0, New Object(,) {{"A", "", "", "", "B", "", "", "C", "", "D"}})
        sheet.SetArray(1, 0, New Object(,) {{"A1", "", "A2", "A3", "B1", "B2", "", "C1", "C2", "D1"}})
        sheet.SetArray(2, 0, New Object(,) {{"A1a", "A1b", "", "", "", "B2a", "B2b", "", "", ""}})
        sheet.SetArray(3, 0, New Object(,) {{1, 2, 3, 4, 5, 2, 2, 3, 4, 5}})

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.SunburstSeries()
        series1.SeriesName = "s1"
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$J$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$4:$J$4")

        ' プロット領域を作成
        Dim plotArea As New FarPoint.Win.Chart.SunburstPlotArea()
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
