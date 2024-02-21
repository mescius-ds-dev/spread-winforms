Public Class arrayformula

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 合計列追加
        sheet.SetText(0, 0, "配列数式")

        ' ヘッダを設定
        sheet.SetText(1, 1, "品名")
        sheet.SetText(1, 2, "単価")
        sheet.SetText(1, 3, "数量")
        sheet.SetText(1, 4, "合計")
        sheet.Cells(1, 1, 1, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center

        ' 品名を設定
        sheet.SetText(2, 1, "みかん")
        sheet.SetText(3, 1, "リンゴ")
        sheet.SetText(4, 1, "パイナップル")
        sheet.SetText(5, 1, "メロン")
        sheet.SetText(6, 1, "ぶどう")

        ' 合計
        sheet.SetText(7, 3, "合計")

        ' 数量を設定
        sheet.SetValue(2, 2, 50)
        sheet.SetValue(3, 2, 80)
        sheet.SetValue(4, 2, 100)
        sheet.SetValue(5, 2, 120)
        sheet.SetValue(6, 2, 200)

        ' 単価を設定
        sheet.SetValue(2, 3, 20)
        sheet.SetValue(3, 3, 50)
        sheet.SetValue(4, 3, 6)
        sheet.SetValue(5, 3, 2)
        sheet.SetValue(6, 3, 3)

        ' 列幅の設定
        sheet.Columns(0, 5).Width = 100

        ' 罫線の設定
        Dim lBorder As New FarPoint.Win.LineBorder(Color.Black)
        sheet.Cells(1, 1, 6, 4).Border = lBorder
        FpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Collapse

        ' 数式の入力を許可
        FpSpread1.AllowUserFormulas = True
        ' 配列数式を設定
        sheet.Cells(7, 4).FormulaArray = "SUM(C3:C7*D3:D7)"
    End Sub
End Class
