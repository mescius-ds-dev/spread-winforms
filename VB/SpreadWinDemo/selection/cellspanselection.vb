Public Class cellspanselection
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 列ヘッダの結合
        sheet.ColumnHeader.RowCount = 3
        sheet.ColumnHeader.Cells(0, 0).ColumnSpan = 8
        sheet.ColumnHeader.Cells(1, 0).ColumnSpan = 2
        sheet.ColumnHeader.Cells(1, 2).ColumnSpan = 2
        sheet.ColumnHeader.Cells(1, 4).ColumnSpan = 2
        sheet.ColumnHeader.Cells(1, 6).ColumnSpan = 2

        ' 列ヘッダキャプションの設定
        sheet.ColumnHeader.Cells(0, 0).Value = "今年度（内訳）"
        sheet.ColumnHeader.Cells(1, 0).Value = "第１四半期"
        sheet.ColumnHeader.Cells(1, 2).Value = "第２四半期"
        sheet.ColumnHeader.Cells(1, 4).Value = "第３四半期"
        sheet.ColumnHeader.Cells(1, 6).Value = "第４四半期"
        sheet.ColumnHeader.Cells(2, 0).Value = "Ａ期間"
        sheet.ColumnHeader.Cells(2, 1).Value = "Ｂ期間"
        sheet.ColumnHeader.Cells(2, 2).Value = "Ａ期間"
        sheet.ColumnHeader.Cells(2, 3).Value = "Ｂ期間"
        sheet.ColumnHeader.Cells(2, 4).Value = "Ａ期間"
        sheet.ColumnHeader.Cells(2, 5).Value = "Ｂ期間"
        sheet.ColumnHeader.Cells(2, 6).Value = "Ａ期間"
        sheet.ColumnHeader.Cells(2, 7).Value = "Ｂ期間"
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' SPREADの準備が完了していない場合を除外
        If FpSpread1.Sheets.Count = 0 Then Return

        ' 選択範囲のクリア
        FpSpread1.Sheets(0).ClearSelection()

        ' 選択動作の設定
        If ComboBox1.Text = "既定値（従来バージョンと同じ動作）" Then
            FpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Default
        ElseIf ComboBox1.Text = "クリックされた列（行）のみを選択" Then
            FpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.IgnoreSpan
        ElseIf ComboBox1.Text = "ヘッダ領域に収まるセルだけを選択" Then
            FpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Contained
        ElseIf ComboBox1.Text = "ヘッダの領域に含まれるセルをすべて選択" Then
            FpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Intersected
        Else
            FpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Default
        End If
    End Sub
End Class
