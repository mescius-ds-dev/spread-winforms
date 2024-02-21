Public Class inputmap

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 36
        sheet.Columns(1).Width = 88
        sheet.Columns(2).Width = 91
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 181

        ' 非連結行を追加します。
        sheet.AddUnboundRows(sheet.RowCount, 2)
        sheet.FrozenTrailingRowCount = 2
        sheet.Cells(sheet.RowCount - 2, 0).Value = "[Enter]キーの動作："
        sheet.Cells(sheet.RowCount - 2, 0).ColumnSpan = 2
        sheet.Cells(sheet.RowCount - 1, 0).Value = "[Tab]キーの動作："
        sheet.Cells(sheet.RowCount - 1, 0).ColumnSpan = 2
        Dim multcellE As New FarPoint.Win.Spread.CellType.MultiOptionCellType()
        multcellE.Items = New [String]() {"次の行へ移動", "次の列へ移動"}
        multcellE.Orientation = FarPoint.Win.RadioOrientation.Horizontal
        sheet.Cells(sheet.RowCount - 2, 2).CellType = multcellE
        sheet.Cells(sheet.RowCount - 2, 2).ColumnSpan = 7
        Dim multcellT As New FarPoint.Win.Spread.CellType.MultiOptionCellType()
        multcellT.Items = New [String]() {"次の行へ移動", "次の列へ移動"}
        multcellT.Orientation = FarPoint.Win.RadioOrientation.Horizontal
        sheet.Cells(sheet.RowCount - 1, 2).CellType = multcellT
        sheet.Cells(sheet.RowCount - 1, 2).ColumnSpan = 7
    End Sub

    Private Sub FpSpread1_ButtonClicked(sender As Object, e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles FpSpread1.ButtonClicked
        If e.Row = FpSpread1.Sheets(0).RowCount - 2 And e.Column = 2 Then
            If CInt(FpSpread1.ActiveSheet.ActiveCell.Value) = 0 Then
                ' [Enter]キーの動作を「次の行へ移動」に設定
                Dim im As FarPoint.Win.Spread.InputMap
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
            Else
                ' [Enter]キーの動作を「次の列へ移動」に設定
                Dim im As FarPoint.Win.Spread.InputMap
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
            End If
        ElseIf e.Row = FpSpread1.Sheets(0).RowCount - 1 And e.Column = 2 Then
            If CInt(FpSpread1.ActiveSheet.ActiveCell.Value) = 0 Then
                ' [Enter]キーの動作を「次の行へ移動」に設定
                Dim im As FarPoint.Win.Spread.InputMap
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
            Else
                ' [Enter]キーの動作を「次の列へ移動」に設定
                Dim im As FarPoint.Win.Spread.InputMap
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
                im = FpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
                im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
            End If
        End If
    End Sub
End Class
