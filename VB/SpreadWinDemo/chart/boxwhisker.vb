Public Class boxwhisker
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.SetArray(0, 0, New Object(,) {{"項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A",
                                           "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A",
                                           "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A",
                                           "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A", "項目A",
                                           "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B",
                                           "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B",
                                           "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B",
                                           "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B", "項目B",
                                           "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C",
                                           "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C",
                                           "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C",
                                           "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C", "項目C"}})
        sheet.SetArray(1, 0, New Object(,) {{65, 62, 88, 62, 8, 42, 93, 50, 64, 65,
                                           31, 48, 12, 43, 67, 28, 60, 95, 8, 37,
                                           50, 64, 19, 10, 27, 2, 8, 42, 28, 3,
                                           2, 69, 85, 64, 65, 38, 23, 28, 83, 80,
                                           242, 272, 229, 222, 257, 256, 255, 272, 206, 293,
                                           298, 239, 221, 258, 202, 242, 278, 286, 294, 210,
                                           225, 282, 266, 279, 254, 257, 224, 239, 279, 225,
                                           298, 294, 204, 267, 218, 283, 203, 279, 271, 297,
                                           160, 152, 122, 137, 193, 172, 172, 113, 192, 104,
                                           103, 129, 146, 151, 185, 166, 128, 189, 161, 126,
                                           129, 146, 190, 143, 187, 128, 167, 186, 114, 129,
                                           183, 180, 121, 166, 175, 173, 108, 114, 154, 123}})

        ' シリーズを作成
        Dim series1 As New FarPoint.Win.Chart.BoxWhiskerSeries()
        series1.SeriesName = "s1"
        series1.CategoryNames.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$DP$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text)
        series1.Values.DataSource = New FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$2:$DP$2")
        series1.QuartileMethod = FarPoint.Win.Chart.QuartileMethodType.Inclusive
        series1.ShowInnerPoints = True
        series1.ShowMeanLine = True
        series1.ShowMeanMarkers = True
        series1.ShowOutlierPoints = True

        ' プロット領域を作成
        Dim plotArea As New FarPoint.Win.Chart.YPlotArea()
        plotArea.Location = New System.Drawing.PointF(0.1F, 0.1F)
        plotArea.Size = New System.Drawing.SizeF(0.8F, 0.8F)
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
