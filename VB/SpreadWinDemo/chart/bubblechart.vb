Public Class bubblechart

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClipValue(0, 1, 1, 5, "S" & vbTab & "E" & vbTab & "W" & vbTab & "N" & vbTab & "NE")
        sheet.SetClipValue(1, 0, 1, 6, "S1" & vbTab & "500" & vbTab & "246" & vbTab & "549" & vbTab & "300" & vbTab & "260")
        sheet.SetClipValue(2, 0, 1, 6, "S2" & vbTab & "926" & vbTab & "146" & vbTab & "1501" & vbTab & "240" & vbTab & "650")
        sheet.SetClipValue(3, 0, 1, 6, "S3" & vbTab & "650" & vbTab & "260" & vbTab & "700" & vbTab & "600" & vbTab & "428")
        sheet.SetClipValue(4, 0, 1, 6, "S4" & vbTab & "240" & vbTab & "80" & vbTab & "260" & vbTab & "1100" & vbTab & "268")

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.XYBubbleSeries()
        series1.SeriesName = "s1"
        series1.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.SizeValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$3:$F$3")
        series1.XValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.AutoIndex)
        series1.YValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$2:$F$2")

        Dim series2 As New FarPoint.Win.Chart.XYBubbleSeries()
        series2.SeriesName = "s3"
        series2.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$4:$A$4", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series2.SizeValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$5:$F$5")
        series2.XValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.AutoIndex)
        series2.YValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$4:$F$4")

        ' プロット領域を作成します
        Dim plotArea As New FarPoint.Win.Chart.XYPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.7F, 0.8F)
        plotArea.Series.AddRange(New FarPoint.Win.Chart.Series() {series1, series2})

        ' 凡例を設定
        Dim legend As New FarPoint.Win.Chart.LegendArea()
        legend.Location = New System.Drawing.PointF(0.995F, 0.5F)
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
