﻿Public Class doughnutchart

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetClipValue(0, 1, 1, 5, "S" & vbTab & "E" & vbTab & "W" & vbTab & "N" & vbTab & "NE")
        sheet.SetClipValue(1, 0, 1, 6, "S1" & vbTab & "50" & vbTab & "25" & vbTab & "85" & vbTab & "30" & vbTab & "26")
        sheet.SetClipValue(2, 0, 1, 6, "S2" & vbTab & "92" & vbTab & "14" & vbTab & "15" & vbTab & "24" & vbTab & "65")
        sheet.SetClipValue(3, 0, 1, 6, "S3" & vbTab & "65" & vbTab & "26" & vbTab & "70" & vbTab & "60" & vbTab & "43")
        sheet.SetClipValue(4, 0, 1, 6, "S4" & vbTab & "24" & vbTab & "80" & vbTab & "26" & vbTab & "11" & vbTab & "27")

        ' シリーズを作成
        Dim series As New FarPoint.Win.Chart.PieSeries()
        series.SeriesName = "Series 0"
        series.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$2:$F$2")

        ' プロット領域を作成します
        Dim plotArea As New FarPoint.Win.Chart.PiePlotArea()
        plotArea.HoleSize = 0.5F
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.7F, 0.8F)
        plotArea.Series.Add(series)

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
