Public Class richclipboard

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1, FpSpread2)

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
        InitWorkbook(FpSpread2.AsWorkbook())
    End Sub

    Private Sub InitSpread(ByVal spread1 As FarPoint.Win.Spread.FpSpread, ByVal spread2 As FarPoint.Win.Spread.FpSpread)
        spread2.AsWorkbook().Name = "Book2"
        spread1.AsWorkbook().WorkbookSet.Workbooks.Add(spread2.AsWorkbook())

        spread1.Features.EnhancedShapeEngine = True
        spread2.Features.EnhancedShapeEngine = True
        spread1.Features.RichClipboard = True
        spread2.Features.RichClipboard = True

        spread1.AllowUserFormulas = True
        spread2.AllowUserFormulas = True
        spread1.AsWorkbook().ActiveSheet.Cells("A1").Value = 3
        spread1.AsWorkbook().ActiveSheet.Cells("B3").Formula = "Sheet1!A1"

        ' コメントの追加
        Dim cm As GrapeCity.Spreadsheet.IComment = FpSpread1.AsWorkbook().ActiveSheet.Cells("B6").AddComment("新しいコメント")
        cm.Visible = True
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9
    End Sub
End Class
