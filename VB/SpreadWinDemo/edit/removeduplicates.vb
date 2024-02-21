Imports FarPoint.Win.Spread
Imports GrapeCity.Spreadsheet

Public Class removeduplicates

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        sheet.SetValue(0, 0, "Steve")
        sheet.SetValue(1, 0, "Steve")
        sheet.SetValue(2, 0, "Pete")
        sheet.SetValue(3, 0, "Mike")
        sheet.SetValue(4, 0, "Steve")
        sheet.SetValue(5, 0, "Emily")
        sheet.SetValue(6, 0, "Steve")

        sheet.SetValue(0, 1, 1)
        sheet.SetValue(1, 1, 1)
        sheet.SetValue(2, 1, 2)
        sheet.SetValue(3, 1, 3)
        sheet.SetValue(4, 1, 5)
        sheet.SetValue(5, 1, 8)
        sheet.SetValue(6, 1, 13)

        sheet.SetValue(0, 2, 1)
        sheet.SetValue(1, 2, 1)
        sheet.SetValue(2, 2, 2)
        sheet.SetValue(3, 2, 3)
        sheet.SetValue(4, 2, 5)
        sheet.SetValue(5, 2, 8)
        sheet.SetValue(6, 2, 13)

        sheet.SetValue(0, 3, 1)
        sheet.SetValue(1, 3, 1)
        sheet.SetValue(2, 3, 2)
        sheet.SetValue(3, 3, 3)
        sheet.SetValue(4, 3, 5)
        sheet.SetValue(5, 3, 8)
        sheet.SetValue(6, 3, 13)

        sheet.SetValue(0, 4, 1)
        sheet.SetValue(1, 4, 1)
        sheet.SetValue(2, 4, 2)
        sheet.SetValue(3, 4, 3)
        sheet.SetValue(4, 4, 5)
        sheet.SetValue(5, 4, 8)
        sheet.SetValue(6, 4, 13)
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' メソッドで重複データを削除
        Dim columns As Integer() = {1, 2}
        FpSpread1.AsWorkbook().ActiveSheet.Range("A1:E7").RemoveDuplicates(Columns, YesNoGuess.No)
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' ダイアログで重複データを削除
        FarPoint.Win.Spread.Dialogs.BuiltInDialogs.RemoveDuplicates(FpSpread1).ShowDialog(FpSpread1)
    End Sub
End Class
