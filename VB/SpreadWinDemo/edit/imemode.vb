Public Class imemode

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 行列数の設定
        sheet.RowCount = 10
        sheet.ColumnCount = 6

        ' 列幅の設定
        sheet.Columns.[Default].Width = 100

        ' IMEの設定
        sheet.ColumnHeader.Cells(0, 0).Value = "無効"
        sheet.Columns(0).ImeMode = System.Windows.Forms.ImeMode.Disable
        sheet.ColumnHeader.Cells(0, 1).Value = "ひらがな"
        sheet.Columns(1).ImeMode = System.Windows.Forms.ImeMode.Hiragana
        sheet.ColumnHeader.Cells(0, 2).Value = "全角カタカナ"
        sheet.Columns(2).ImeMode = System.Windows.Forms.ImeMode.Katakana
        sheet.ColumnHeader.Cells(0, 3).Value = "半角カタカナ"
        sheet.Columns(3).ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        sheet.ColumnHeader.Cells(0, 4).Value = "全角英数字"
        sheet.Columns(4).ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        sheet.ColumnHeader.Cells(0, 5).Value = "半角英数字"
        sheet.Columns(5).ImeMode = System.Windows.Forms.ImeMode.Alpha
    End Sub
End Class
