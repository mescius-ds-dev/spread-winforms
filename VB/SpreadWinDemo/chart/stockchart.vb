Public Class stockchart

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClipValue(0, 1, 1, 5, "8/1" & vbTab & "8/2" & vbTab & "8/3" & vbTab & "8/4" & vbTab & "8/5")
        sheet.SetClipValue(1, 0, 1, 6, "Open" & vbTab & "864" & vbTab & "279" & vbTab & "825" & vbTab & "360" & vbTab & "384")
        sheet.SetClipValue(2, 0, 1, 6, "High" & vbTab & "926" & vbTab & "614" & vbTab & "865" & vbTab & "562" & vbTab & "650")
        sheet.SetClipValue(3, 0, 1, 6, "Low" & vbTab & "500" & vbTab & "146" & vbTab & "501" & vbTab & "310" & vbTab & "260")
        sheet.SetClipValue(4, 0, 1, 6, "Close" & vbTab & "650" & vbTab & "560" & vbTab & "786" & vbTab & "486" & vbTab & "428")

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.CandlestickSeries()
        series1.SeriesName = "Series 1"
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.CloseValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue3", "Sheet1!$B$5:$F$5")
        series1.HighValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$3:$F$3")
        series1.LowValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue2", "Sheet1!$B$4:$F$4")
        series1.OpenValues.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$2:$F$2")

        ' プロット領域を作成します
        Dim plotArea As New FarPoint.Win.Chart.YPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.7F, 0.8F)
        plotArea.XAxis.MajorGridVisible = True
        plotArea.Series.AddRange(New FarPoint.Win.Chart.Series() {series1})

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
