Public Class insertdialog

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        FpSpread1.Features.ExcelCompatibleKeyboardShortcuts = True
        FpSpread1.Features.RichClipboard = True
        Dim sheet1 As GrapeCity.Spreadsheet.IWorksheet = workbook.ActiveSheet
        For i As Integer = 0 To 5 - 1
            For j As Integer = 0 To 5 - 1
                sheet1.Cells(i, j).Value = i + j
            Next
        Next
    End Sub
End Class
