Public Class cellcontentfloat
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 行列数の設定
        sheet.RowCount = 50
        sheet.ColumnCount = 30

        ' 第１行のマージ設定
        sheet.Cells(0, 0, 0, 19).Value = "左右中央"
        sheet.Cells(0, 0, 0, 19).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        sheet.Rows(0).MergePolicy = FarPoint.Win.Spread.Model.MergePolicy.Always

        ' 第１列のマージ設定
        sheet.Cells(1, 0, 29, 0).Value = "上下中央"
        sheet.Cells(1, 0, 29, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        sheet.Columns(0).MergePolicy = FarPoint.Win.Spread.Model.MergePolicy.Always

        checkBox1.Checked = True
        FpSpread1.AllowCellContentFloat = checkBox1.Checked
    End Sub

    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
        ' テキスト位置の自動調整機能の切り替え
        FpSpread1.AllowCellContentFloat = checkBox1.Checked
    End Sub
End Class
