Public Class chartcontrol
    Public Sub New()

        InitializeComponent()

        ' チャートコントロールの設定
        InitChart(FpChart1)
    End Sub

    Private Sub InitChart(chart As FarPoint.Win.Chart.FpChart)
        ' チャートコントロールの初期化
        chart.Model.LabelAreas.Clear()
        chart.Model.LegendAreas.Clear()
        chart.Model.PlotAreas.Clear()

        ' テストデータの設定
        Dim collection1 As New FarPoint.Win.Chart.StringCollectionItem()
        Dim testName As String() = New String() {"A", "B", "C", "D", "E"}
        Dim testData1 As Double() = New Double() {2, 5, 8, 7, 4}
        Dim testData2 As Double() = New Double() {7, 3, 2, 4, 9}

        ' 棒グラフ用シリーズの作成
        Dim series1 As New FarPoint.Win.Chart.BarSeries()
        series1.SeriesName = "シリーズ１"
        series1.BarBorder = New FarPoint.Win.Chart.SolidLine(Color.Black)
        series1.BarFill = New FarPoint.Win.Chart.SolidFill(Color.Blue)
        series1.CategoryNames.AddRange(testName)
        series1.Values.AddRange(testData1)

        ' 折れ線グラフ用シリーズの作成
        Dim series2 As New FarPoint.Win.Chart.LineSeries()
        series2.SeriesName = "シリーズ２"
        series2.LineBorder = New FarPoint.Win.Chart.SolidLine(Color.Red, 3.0F)
        series2.PointBorder = New FarPoint.Win.Chart.SolidLine(Color.Black)
        series2.PointFill = New FarPoint.Win.Chart.SolidFill(Color.Red)
        series2.PointMarker = New FarPoint.Win.Chart.BuiltinMarker(FarPoint.Win.Chart.MarkerShape.Circle, 10.0F)
        series2.CategoryNames.AddRange(testName)
        series2.Values.AddRange(testData2)
        series2.YAxisId = 1

        ' プロット領域の作成
        Dim area1 As New FarPoint.Win.Chart.YPlotArea()
        area1.YAxes.Add(New FarPoint.Win.Chart.ValueAxis())
        area1.YAxes(0).AutoMaximum = False
        area1.YAxes(0).AutoMinimum = False
        area1.YAxes(0).Maximum = 10
        area1.YAxes(0).Minimum = 0
        area1.YAxes(1).AutoMaximum = False
        area1.YAxes(1).AutoMinimum = False
        area1.YAxes(1).Maximum = 10
        area1.YAxes(1).Minimum = 0
        area1.YAxes(1).AxisId = 1
        area1.YAxes(1).Location = FarPoint.Win.Chart.AxisLocation.Far
        area1.Series.Add(series1)
        area1.Series.Add(series2)

        ' チャートモデルに各情報を追加
        chart.Model.PlotAreas.Add(area1)
        chart.Model.LabelAreas.Add(New FarPoint.Win.Chart.LabelArea() With {.Text = "縦棒グラフと折れ線グラフ", .Location = New PointF(0.3F, 0.04F)})
        chart.Model.LegendAreas.Add(New FarPoint.Win.Chart.LegendArea())
    End Sub
End Class
