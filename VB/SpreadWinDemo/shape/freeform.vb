Public Class freeform

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        FpSpread1.StopAnnotationMode()

        ' 図形
        FpSpread1.Features.EnhancedShapeEngine = True
        FpSpread1.StartAnnotationMode(FarPoint.Win.Spread.AnnotationMode.Freeform)
        FpSpread1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        FpSpread1.StopAnnotationMode()

        ' フリーハンド
        FpSpread1.Features.EnhancedShapeEngine = True
        FpSpread1.StartAnnotationMode(FarPoint.Win.Spread.AnnotationMode.Scribble)
    End Sub
End Class
