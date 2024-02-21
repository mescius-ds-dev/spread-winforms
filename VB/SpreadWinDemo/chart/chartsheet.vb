Imports FarPoint.Win.Chart

Public Class chartsheet

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.Features.EnhancedShapeEngine = True

        ' テストデータの設定
        sheet.SetClipValue(0, 1, 1, 5, "S" & vbTab & "E" & vbTab & "W" & vbTab & "N" & vbTab & "NE")
        sheet.SetClipValue(1, 0, 1, 6, "S1" & vbTab & "50" & vbTab & "25" & vbTab & "85" & vbTab & "30" & vbTab & "26")
        sheet.SetClipValue(2, 0, 1, 6, "S2" & vbTab & "92" & vbTab & "14" & vbTab & "15" & vbTab & "24" & vbTab & "65")
        sheet.SetClipValue(3, 0, 1, 6, "S3" & vbTab & "65" & vbTab & "26" & vbTab & "70" & vbTab & "60" & vbTab & "43")
        sheet.SetClipValue(4, 0, 1, 6, "S4" & vbTab & "24" & vbTab & "80" & vbTab & "26" & vbTab & "11" & vbTab & "27")

        ' チャートを追加
        FpSpread1.AsWorkbook().Charts.Add()
        FpSpread1.Sheets(0).Charts(0).DataFormula = "Sheet1!B2:F5"
        FpSpread1.Sheets(0).Charts(0).CategoryFormula = "Sheet1!A2:A5"
        FpSpread1.Sheets(0).Charts(0).SeriesNameFormula = "Sheet1!B1:F1"

        ' 3Dでレンダリング
        FpSpread1.Sheets(0).Charts(0).ViewType = ChartViewType.View3D
    End Sub
End Class
