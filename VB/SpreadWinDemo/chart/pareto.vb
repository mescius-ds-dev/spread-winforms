Public Class pareto
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetArray(0, 0, New Object(,) {{"項目A", "項目A", "項目A", "項目A", "項目B", "項目B", "項目B", "項目C", "項目C", "項目D", "項目D", "項目E"}})
        sheet.SetArray(1, 0, New Object(,) {{4.7, 3.9, 3.5, 3.4, 2.9, 2.8, 2.6, 2.3, 2.2, 1.2, 1.8, 0.7}})

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.ParetoSeries()
        series1.SeriesName = "s1"
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$L$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$2:$L$2")
        series1.BinOption.BinCount = 5
        series1.BinOption.BinType = FarPoint.Win.Chart.BinOption.HistogramBinType.ByCategory
        series1.Bar.YAxisId = 0
        series1.ParetoLine.YAxisId = 1

        ' プロット領域を作成
        Dim plotArea As New FarPoint.Win.Chart.YPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.8F, 0.8F)
        plotArea.YAxes.Add(New FarPoint.Win.Chart.ValueAxis() With {.AxisId = 1, .Location = FarPoint.Win.Chart.AxisLocation.Far})
        plotArea.YAxes(0).AutoMaximum = False
        plotArea.YAxes(0).AutoMajorUnit = False
        plotArea.YAxes(0).Maximum = 20
        plotArea.YAxes(0).MajorUnit = 4
        plotArea.YAxes(1).DisplayUnits = 0.01
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
