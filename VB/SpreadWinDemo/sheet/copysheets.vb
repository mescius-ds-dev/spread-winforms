Imports GrapeCity.Spreadsheet

Public Class copysheets

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.TabStrip.Editable = True
        FpSpread1.AllowUserFormulas = True

        ' Sheet2にテストデータを設定
        Dim sheet2 As IWorksheet = FpSpread1.AsWorkbook().Worksheets.Add()
        sheet2.Cells("A1").Value = 1
        sheet2.Cells("A2").Value = 2
        sheet2.Cells("A3").Value = 3

        ' Sheet1に数式を設定
        FpSpread1.AsWorkbook().ActiveSheet.Cells(0, 0).Formula = "SUM(Sheet2!A1:A3)"
        FpSpread1.AsWorkbook().ActiveSheet.Columns(0).ColumnWidth = 200
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' Sheet1とSheet2をコピー
        FpSpread1.AsWorkbook().Worksheets(0, 1).Copy(0)
    End Sub
End Class
