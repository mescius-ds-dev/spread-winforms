Public Class gctimespan
    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        FpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 列の設定
        sheet.ColumnCount = 3
        sheet.Columns(0).Width = 170
        sheet.Columns(1).Width = 125
        sheet.Columns(2).Width = 374
        sheet.Columns(0).CellPadding = New FarPoint.Win.Spread.CellPadding(0, 0, 4, 0)
        sheet.Columns(2).CellPadding = New FarPoint.Win.Spread.CellPadding(4, 0, 0, 0)

        ' 行の設定
        sheet.RowCount = 8

        ' 列ヘッダの設定
        sheet.ColumnHeader.Columns(0).Label = "機能"
        sheet.ColumnHeader.Columns(1).Label = "実行例"
        sheet.ColumnHeader.Columns(2).Label = "説明"

        ' プロテクトとロック（DefaultStyle）の設定
        sheet.Protect = True
        sheet.DefaultStyle.Locked = False
        sheet.RowHeader.DefaultStyle.Locked = False
        sheet.ColumnHeader.DefaultStyle.Locked = False

        ' 読み取り専用設定
        sheet.Columns(0).Locked = True
        sheet.Columns(2).Locked = True

        ' 背景色の設定
        sheet.Columns(0).BackColor = System.Drawing.SystemColors.Control

        ' 左揃え
        sheet.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

        ' アクティブセルの設定
        sheet.SetActiveCell(0, 1)

        ' 項目名と解説の設定
        sheet.Cells(0, 0).Text = "書式の設定"
        sheet.Cells(1, 0).Text = "入力範囲の指定"
        sheet.Cells(2, 0).Text = "マイナス入力"
        sheet.Cells(3, 0).Text = "未入力時の代替テキスト"
        sheet.Cells(4, 0).Text = "入力候補値"
        sheet.Cells(5, 0).Text = "自動フォーカス移動"
        sheet.Cells(6, 0).Text = "フィールドのスタイル"
        sheet.Cells(7, 0).Text = "サイドボタン"

        sheet.Cells(0, 2).Text = "入力用と表示用の時刻書式をそれぞれ設定します"
        sheet.Cells(1, 2).Text = "2時から25時までに入力範囲を制限します"
        sheet.Cells(2, 2).Text = "マイナス入力のみに限定して負値の文字色を赤色にします"
        sheet.Cells(3, 2).Text = "セルが未入力のときに代わりにテキストを表示します"
        sheet.Cells(4, 2).Text = "(Ctrl)+(Enter)で候補として表示された値を確定します"
        sheet.Cells(5, 2).Text = "入力が完了すると自動的に右のセルにフォーカスを移動します"
        sheet.Cells(6, 2).Text = "フィールドごとに入力時のスタイルを設定します"
        sheet.Cells(7, 2).Text = "スピンボタンを追加します"

        '【書式の設定】
        Dim gctimespan1 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan1.DisplayFields.Clear()
        gctimespan1.DisplayFields.AddRange("hh時間mm分ss秒,0,.,,,-,")
        gctimespan1.Fields.Clear()
        gctimespan1.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan1.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(0, 1).CellType = gctimespan1
        sheet.Cells(0, 1).Value = New TimeSpan(10, 20, 30)

        '【入力範囲の指定】
        Dim gctimespan2 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan2.DisplayFields.Clear()
        gctimespan2.DisplayFields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan2.Fields.Clear()
        gctimespan2.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan2.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gctimespan2.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.CancelInput
        gctimespan2.MaxValue = New TimeSpan(25, 59, 59)
        gctimespan2.MinValue = New TimeSpan(2, 0, 0)
        sheet.Cells(1, 1).CellType = gctimespan2
        sheet.Cells(1, 1).Value = New TimeSpan(25, 30, 45)

        '【マイナス入力】
        Dim gctimespan3 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan3.DisplayFields.Clear()
        gctimespan3.DisplayFields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan3.Fields.Clear()
        gctimespan3.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan3.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gctimespan3.ValueSign = GrapeCity.Win.Spread.InputMan.CellType.ValueSignControl.Negative
        gctimespan3.NegativeColor = Color.Red
        gctimespan3.UseNegativeColor = True
        sheet.Cells(2, 1).CellType = gctimespan3
        sheet.Cells(2, 1).Value = New TimeSpan(-10, -20, -30)

        '【未入力時の代替テキスト】
        Dim gctimespan4 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan4.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen
        gctimespan4.AlternateText.DisplayNull.Text = "＜時刻入力＞"
        gctimespan4.AlternateText.Null.ForeColor = Color.LightPink
        gctimespan4.AlternateText.Null.Text = "時刻を入力"
        gctimespan4.DisplayFields.Clear()
        gctimespan4.DisplayFields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan4.Fields.Clear()
        gctimespan4.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan4.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(3, 1).CellType = gctimespan4

        '【入力候補値】
        Dim gctimespan5 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan5.DisplayFields.Clear()
        gctimespan5.DisplayFields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan5.Fields.Clear()
        gctimespan5.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan5.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gctimespan5.ShowRecommendedValue = True
        gctimespan5.RecommendedValue = New TimeSpan(10, 20, 30)
        sheet.Cells(4, 1).CellType = gctimespan5

        '【自動フォーカス移動】
        Dim gctimespan6 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan6.DisplayFields.Clear()
        gctimespan6.DisplayFields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan6.ExitOnLastChar = True
        gctimespan6.Fields.Clear()
        gctimespan6.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan6.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(5, 1).CellType = gctimespan6

        '【フィールドのスタイル】
        Dim gctimespan7 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan7.DisplayFields.Clear()
        gctimespan7.DisplayFields.AddRange("hh時間mm分ss秒,0,.,,,-,")
        gctimespan7.Fields.Clear()
        gctimespan7.Fields.AddRange("hh時間mm分ss秒,0,.,,,-,")
        gctimespan7.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        For Each tsf As GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanFieldInfo In gctimespan7.Fields
            If TypeOf tsf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanHourFieldInfo OrElse
            TypeOf tsf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanMinuteFieldInfo OrElse
            TypeOf tsf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanSecondFieldInfo Then
                tsf.BackColor = Color.Violet
                tsf.ForeColor = Color.White
            End If
        Next
        For Each tsf As GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanDisplayFieldInfo In gctimespan7.DisplayFields
            If TypeOf tsf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanHourDisplayFieldInfo OrElse
            TypeOf tsf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanMinuteDisplayFieldInfo OrElse
            TypeOf tsf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.TimeSpanSecondDisplayFieldInfo Then
                tsf.BackColor = Color.Violet
                tsf.ForeColor = Color.White
            End If
        Next
        gctimespan7.PaintByControl = True
        sheet.Cells(6, 1).CellType = gctimespan7
        sheet.Cells(6, 1).Value = New TimeSpan(10, 20, 30)

        '【サイドボタン】
        Dim gctimespan8 As New GrapeCity.Win.Spread.InputMan.CellType.GcTimeSpanCellType()
        gctimespan8.DisplayFields.Clear()
        gctimespan8.DisplayFields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan8.Fields.Clear()
        gctimespan8.Fields.AddRange("hh:mm:ss,0,.,,,-,")
        gctimespan8.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gctimespan8.SideButtons.Add(New GrapeCity.Win.Spread.InputMan.CellType.SpinButtonInfo())
        gctimespan8.Spin.SpinOnKeys = True
        gctimespan8.Spin.SpinOnWheel = True
        sheet.Cells(7, 1).CellType = gctimespan8
        sheet.Cells(7, 1).Value = New TimeSpan(10, 20, 30)
    End Sub
End Class
