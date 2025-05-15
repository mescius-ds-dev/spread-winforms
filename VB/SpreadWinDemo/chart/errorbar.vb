Imports FarPoint.Win.Chart
Imports FarPoint.Win.Spread.Model

Public Class errorbar

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.ActiveSheet.SetClip(0, 1, 1, 5, "1.2" & vbTab & "0" & vbTab & "-12.5" & vbTab & "-5" & vbTab & "15")
        FpSpread1.ActiveSheet.SetClip(1, 0, 1, 6, "1" & vbTab & "-15.43" & vbTab & "-11" & vbTab & "16" & vbTab & "0" & vbTab & "17.5")
        FpSpread1.ActiveSheet.SetClip(2, 0, 1, 6, "2" & vbTab & "7" & vbTab & "12" & vbTab & "0" & vbTab & "-10" & vbTab & "10" & vbTab & "0")
        FpSpread1.ActiveSheet.AddChart(New CellRange(0, 0, 3, 6), GetType(FarPoint.Win.Chart.ClusteredBarSeries), 400, 250, 100, 100)

        Dim chart = FpSpread1.ActiveSheet.Charts(0)
        Dim plotArea = chart.Model.PlotAreas(0)
        Dim cluster = TryCast(plotArea.Series(0), FarPoint.Win.Chart.ClusteredBarSeries)

        If cluster IsNot Nothing Then
            For Each series As FarPoint.Win.Chart.BarSeries In cluster.Series
                ' 誤差範囲の設定
                Dim errorBar As FarPoint.Win.Chart.ErrorBars = series.SetErrorBarsVisible(True)
                errorBar.ValueType = FarPoint.Win.Chart.ErrorBarValueType.StandardError
                errorBar.Type = FarPoint.Win.Chart.ErrorBarType.Both
            Next
        End If
    End Sub
End Class
