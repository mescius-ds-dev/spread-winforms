Public Class polarchart

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClipValue(0, 1, 1, 5, "0" & vbTab & "30" & vbTab & "60" & vbTab & "180" & vbTab & "270")
        sheet.SetClipValue(1, 0, 1, 6, "S1" & vbTab & "50" & vbTab & "24" & vbTab & "54" & vbTab & "85" & vbTab & "26")
        sheet.SetClipValue(2, 0, 1, 6, "S2" & vbTab & "92" & vbTab & "14" & vbTab & "15" & vbTab & "42" & vbTab & "65")
        sheet.SetClipValue(3, 0, 1, 6, "S3" & vbTab & "43" & vbTab & "35" & vbTab & "36" & vbTab & "61" & vbTab & "43")
        sheet.SetClipValue(4, 0, 1, 6, "S4" & vbTab & "24" & vbTab & "80" & vbTab & "37" & vbTab & "11" & vbTab & "27")

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.PolarLineSeries()
        series1.SeriesName = "s1"
        series1.PointMarker = New FarPoint.Win.Chart.NoMarker()
        series1.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.XValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1")
        series1.YValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$2:$F$2")

        Dim series2 As New FarPoint.Win.Chart.PolarLineSeries()
        series2.SeriesName = "s2"
        series2.PointMarker = New FarPoint.Win.Chart.NoMarker()
        series2.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$3:$A$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series2.XValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1")
        series2.YValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$3:$F$3")

        Dim series3 As New FarPoint.Win.Chart.PolarLineSeries()
        series3.SeriesName = "s3"
        series3.PointMarker = New FarPoint.Win.Chart.NoMarker()
        series3.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$4:$A$4", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series3.XValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1")
        series3.YValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$4:$F$4")

        Dim series4 As New FarPoint.Win.Chart.PolarLineSeries()
        series4.SeriesName = "s4"
        series4.PointMarker = New FarPoint.Win.Chart.NoMarker()
        series4.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$5:$A$5", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series4.XValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1")
        series4.YValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$5:$F$5")

        ' プロット領域を作成します
        Dim plotArea As New FarPoint.Win.Chart.PolarPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.7F, 0.8F)
        plotArea.XAxis.MajorGridVisible = True
        plotArea.Series.AddRange(New FarPoint.Win.Chart.Series() {series1, series2, series3, series4})

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
