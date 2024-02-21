Imports GrapeCity.Spreadsheet

Public Class texttocolumns

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A1").Value = "Jacob Dev SpreadWin"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A2").Value = "Steve Dev Raykit"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A3").Value = "Serena Tester SpreadWin"
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A4").Value = "Keira Tester Raykit"
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' メソッドで設定
        FpSpread1.AsWorkbook().ActiveSheet.Cells("A1:A4").TextToColumns("A5", TextParsingType.Delimited, TextQualifier.None, False, False, False, False, True)
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' ダイアログで設定
        FarPoint.Win.Spread.Dialogs.BuiltInDialogs.TextToColumns(FpSpread1)?.Show(FpSpread1)
    End Sub
End Class
