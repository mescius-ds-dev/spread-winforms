Public Class movenextcontrol
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 列数と行数の設定
        sheet.ColumnCount = 3
        sheet.RowCount = 3

        ' 入力マップの設定
        Dim im As FarPoint.Win.Spread.InputMap
        im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
        im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextCellThenControl)
        im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousCellThenControl)

        '' 常時入力モードの場合
        'FpSpread1.EditModePermanent = True
        'im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)
        'im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextCellThenControl)
        'im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousCellThenControl)
    End Sub
End Class
