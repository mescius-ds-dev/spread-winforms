Public Class excelprint

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A1").Value = "Page1"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A60").Value = "Page2"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A100").Value = "Page3"

        ' 先頭ページのヘッダ設定
        sheet.PrintInfo.DifferentFirstPageHeaderFooter = True
        sheet.PrintInfo.FirstHeader = "/l先頭ページ"

        ' 偶数ページのヘッダ設定
        sheet.PrintInfo.OddAndEvenPagesHeaderFooter = True
        sheet.PrintInfo.EvenHeader = "/l偶数ページ"

        ' 奇数ページのヘッダ設定
        sheet.PrintInfo.Header = "/l奇数ページ"

        sheet.PrintInfo.Preview = True
        sheet.PrintInfo.EnhancePreview = True
        sheet.PrintInfo.Margin.Top = 50

        ' Excel互換印刷
        FpSpread1.Features.ExcelCompatiblePrinting = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        FpSpread1.PrintSheet(0)
    End Sub
End Class
