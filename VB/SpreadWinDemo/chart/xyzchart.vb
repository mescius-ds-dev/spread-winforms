Public Class xyzchart

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClipValue(1, 0, 1, 6, "S1" & vbTab & "500" & vbTab & "246" & vbTab & "549" & vbTab & "300" & vbTab & "260")
        sheet.SetClipValue(2, 1, 1, 5, "926" & vbTab & "146" & vbTab & "1501" & vbTab & "240" & vbTab & "650")
        sheet.SetClipValue(3, 1, 1, 5, "650" & vbTab & "260" & vbTab & "700" & vbTab & "600" & vbTab & "428")
        sheet.SetClipValue(4, 1, 1, 5, "240" & vbTab & "80" & vbTab & "260" & vbTab & "1100" & vbTab & "268")

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.XYZSurfaceSeries()
        series1.SeriesName = "s1"

        Dim doubleCollection1 As New FarPoint.Win.Chart.DoubleCollection()
        Dim doubleCollection2 As New FarPoint.Win.Chart.DoubleCollection()
        Dim doubleCollection3 As New FarPoint.Win.Chart.DoubleCollection()
        Dim doubleCollection4 As New FarPoint.Win.Chart.DoubleCollection()
        series1.SeriesNameDataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text, New FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, False))
        doubleCollection1.DataField = ""
        doubleCollection1.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$2:$F$2", FarPoint.Win.Spread.Chart.SegmentDataType.Number, New FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, False))
        series1.Values.Add(doubleCollection1)
        doubleCollection2.DataField = ""
        doubleCollection2.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$3:$F$3", FarPoint.Win.Spread.Chart.SegmentDataType.Number, New FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, False))
        series1.Values.Add(doubleCollection2)
        doubleCollection3.DataField = ""
        doubleCollection3.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue2", "Sheet1!$B$4:$F$4", FarPoint.Win.Spread.Chart.SegmentDataType.Number, New FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, False))
        series1.Values.Add(doubleCollection3)
        doubleCollection4.DataField = ""
        doubleCollection4.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue3", "Sheet1!$B$5:$F$5", FarPoint.Win.Spread.Chart.SegmentDataType.Number, New FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, False))
        series1.Values.Add(doubleCollection4)

        ' プロット領域を作成します
        Dim plotArea As New FarPoint.Win.Chart.XYZPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.2F, 0.2F)
        plotArea.Size = New System.Drawing.SizeF(0.5F, 0.5F)
        plotArea.Elevation = 18
        plotArea.Rotation = -24
        plotArea.Series.AddRange(New FarPoint.Win.Chart.Series() {series1})

        ' チャートモデルに各情報を追加
        Dim model As New FarPoint.Win.Chart.ChartModel()
        model.PlotAreas.Add(plotArea)

        ' SPREADチャートにチャートモデルを設定
        Dim chart As New FarPoint.Win.Spread.Chart.SpreadChart()
        chart.Size = New Size(450, 250)
        chart.Location = New Point(0, 120)
        chart.ViewType = FarPoint.Win.Chart.ChartViewType.View3D
        chart.Model = model

        ' シートにSPREADチャートを追加
        sheet.Charts.Add(chart)
    End Sub
End Class
