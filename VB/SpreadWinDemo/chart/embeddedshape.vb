Imports FarPoint.Win.Chart
Imports GrapeCity.Spreadsheet.Drawing

Public Class embeddedshape

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.Features.EnhancedShapeEngine = True

        FpSpread1.AsWorkbook().ActiveSheet.SetValue(1, 1, New Object(,) {{"data1", "data2", "data3", "data4", "data5", "data6"}, {1, 2, 3, 4, 5, 6}})
        Dim range As New FarPoint.Win.Spread.Model.CellRange(1, 1, 2, 6)
        sheet.AddChart(range, GetType(BarSeries), 400, 250, 100, 120, ChartViewType.View2D, False)

        ' シェイプを埋め込み
        FpSpread1.AsWorkbook().ActiveSheet.ChartObjects(0).Chart.Shapes.AddShape(AutoShapeType.RightArrow, 50, 50, 150, 50)
    End Sub
End Class
