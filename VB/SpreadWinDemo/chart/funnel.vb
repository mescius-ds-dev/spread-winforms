Public Class funnel
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetArray(0, 0, New Object(,) {{"A", "B", "C", "D", "E"}})
        sheet.SetArray(1, 0, New Object(,) {{9, 7, 5, 3, 1}})

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.FunnelSeries()
        series1.SeriesName = "s1"
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$E$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$2:$E$2")

        ' プロット領域を作成
        Dim plotArea As New FarPoint.Win.Chart.YPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.8F, 0.8F)
        plotArea.XAxis.Reverse = True ' じょうご図では必須（FunnelSeriesを追加する前に設定します）
        plotArea.Vertical = False ' じょうご図では必須（FunnelSeriesを追加する前に設定します）
        plotArea.Series.Add(series1)

        ' チャートモデルに各情報を追加
        Dim model As New FarPoint.Win.Chart.ChartModel()
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
