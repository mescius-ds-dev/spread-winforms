Public Class gcnumber
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
        sheet.RowCount = 13

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
        sheet.Cells(0, 0).Text = "入力・表示書式"
        sheet.Cells(1, 0).Text = "漢数字"
        sheet.Cells(2, 0).Text = "リテラル文字"
        sheet.Cells(3, 0).Text = "未入力の代替テキスト"
        sheet.Cells(5, 0).Text = "入力候補値"
        sheet.Cells(6, 0).Text = "範囲指定\r\n（-9999～9999）"
        sheet.Cells(8, 0).Text = "自動フォーカス移動"
        sheet.Cells(9, 0).Text = "ドロップダウン電卓"
        sheet.Cells(10, 0).Text = "DeleteキーでNULL"
        sheet.Cells(11, 0).Text = "マイナス値の色と記号"
        sheet.Cells(12, 0).Text = "スピンボタン"

        sheet.Cells(0, 2).Text = "接頭辞・接尾辞を表示します"
        sheet.Cells(1, 2).Text = "アラビア数字で入力すると漢数字で表示されます"
        sheet.Cells(2, 2).Text = "リテラル文字を表示します"
        sheet.Cells(3, 2).Text = "値が0のときに代替テキストを表示します"
        sheet.Cells(4, 2).Text = "値がNULLのときに代替テキストを表示します"
        sheet.Cells(5, 2).Text = "(Ctrl)+(Enter)で候補として表示された値を確定します"
        sheet.Cells(6, 2).Text = "範囲外の値の場合は値がクリアされます"
        sheet.Cells(7, 2).Text = "範囲外の値の場合は値を最小値か最大値の近い方に設定します"
        sheet.Cells(8, 2).Text = "数字5桁入力すると自動的に右隣のセルにフォーカスが移動します"
        sheet.Cells(9, 2).Text = "サイドボタンでドロップダウン電卓を表示します"
        sheet.Cells(10, 2).Text = "(Delete)または(BackSpace)で0をクリアできます"
        sheet.Cells(11, 2).Text = "マイナス(-)を▲と表記します"
        sheet.Cells(12, 2).Text = "スピンボタンで値を変更できます"

        '【入力・表示書式】
        Dim gcnumber1 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber1.AlternateText.DisplayNull.Text = "¥__(税込)"
        gcnumber1.DisplayFields.Clear()
        gcnumber1.DisplayFields.AddRange("#,###,###,##0,¥,(税込),-,")
        gcnumber1.Fields.SetFields("#,###,###,##0,¥,(税込),-,")
        gcnumber1.SideButtons.Clear()
        sheet.Cells(0, 1).CellType = gcnumber1

        '【漢数字】
        Dim gcnumber2 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber2.DisplayFields.Clear()
        gcnumber2.DisplayFields.AddRange("[DBNum1]G,,,-,")
        gcnumber2.Fields.SetFields("#########0,,,-,")
        gcnumber2.SideButtons.Clear()
        sheet.Cells(1, 1).CellType = gcnumber2

        '【リテラル文字】
        Dim gcnumber3 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber3.AlternateText.DisplayNull.Text = "高さ__mm"
        gcnumber3.AlternateText.DisplayNull.ForeColor = Color.Gray
        gcnumber3.AlternateText.Null.Text = "高さ__mm"
        gcnumber3.AlternateText.Null.ForeColor = Color.Gray
        gcnumber3.Fields.SignPrefix.ForeColor = Color.Blue
        gcnumber3.Fields.SignPrefix.PositivePattern = ("高さ")
        gcnumber3.Fields.SignPrefix.NegativePattern = ("高さ▲")
        gcnumber3.Fields.SignSuffix.ForeColor = Color.Blue
        gcnumber3.Fields.SignSuffix.PositivePattern = ("mm")
        gcnumber3.Fields.SignSuffix.NegativePattern = ("mm")
        Dim signDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberSignDisplayFieldInfo("高さ ", "高さ ▲")
        Dim signDisp2 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberSignDisplayFieldInfo(" mm", " mm")
        Dim integerDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberIntegerPartDisplayFieldInfo()
        Dim separatorDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDecimalSeparatorDisplayFieldInfo()
        Dim DecimalPartDisplayField1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDecimalPartDisplayFieldInfo()
        signDisp1.ForeColor = Color.Blue
        signDisp2.ForeColor = Color.Blue
        gcnumber3.DisplayFields.Clear()
        gcnumber3.DisplayFields.AddRange(New GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDisplayFieldInfo() {signDisp1, integerDisp1, separatorDisp1, DecimalPartDisplayField1, signDisp2})
        gcnumber3.PaintByControl = True
        gcnumber3.SideButtons.Clear()
        sheet.Cells(2, 1).CellType = gcnumber3

        '【未入力の代替テキスト】
        Dim gcnumber4 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber4.AlternateText.DisplayZero.Text = "0円です"
        gcnumber4.AlternateText.DisplayZero.ForeColor = System.Drawing.Color.LightSeaGreen
        gcnumber4.AlternateText.Zero.Text = "0円は無効です"
        gcnumber4.AlternateText.Zero.ForeColor = System.Drawing.Color.LightPink
        gcnumber4.SideButtons.Clear()
        sheet.Cells(3, 1).CellType = gcnumber4
        sheet.Cells(3, 1).Value = 0

        Dim gcnumber5 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber5.AlternateText.DisplayNull.Text = "未入力です"
        gcnumber5.AlternateText.DisplayNull.ForeColor = System.Drawing.Color.LightSeaGreen
        gcnumber5.AlternateText.Null.Text = "税込で入力します"
        gcnumber5.AlternateText.Null.ForeColor = System.Drawing.Color.LightPink
        gcnumber5.SideButtons.Clear()
        sheet.Cells(4, 1).CellType = gcnumber5

        sheet.Cells(3, 0).RowSpan = 2
        sheet.Cells(3, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center

        '【入力候補値】
        Dim gcnumber6 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber6.RecommendedValue = 53000
        gcnumber6.ShowRecommendedValue = True
        gcnumber6.SideButtons.Clear()
        sheet.Cells(5, 1).CellType = gcnumber6

        '【範囲指定】
        Dim gcnumber7 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber7.MaxValue = 9999
        gcnumber7.MinValue = -9999
        gcnumber7.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.Clear
        gcnumber7.SideButtons.Clear()
        sheet.Cells(6, 1).CellType = gcnumber7

        Dim gcnumber8 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber8.MaxValue = 9999
        gcnumber8.MinValue = -9999
        gcnumber8.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.AdjustToMaxMin
        gcnumber8.SideButtons.Clear()
        sheet.Cells(7, 1).CellType = gcnumber8

        sheet.Cells(6, 0).CellType = New FarPoint.Win.Spread.CellType.GeneralCellType() With {.Multiline = True}
        sheet.Cells(6, 0).RowSpan = 2
        sheet.Cells(6, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center

        '【自動フォーカス移動】
        Dim gcnumber9 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber9.DisplayFields.Clear()
        gcnumber9.DisplayFields.AddRange("##,##0,,,-,")
        gcnumber9.Fields.SetFields("##,##0,,,-,")
        gcnumber9.ExitOnLastChar = True
        gcnumber9.SideButtons.Clear()
        sheet.Cells(8, 1).CellType = gcnumber9

        '【ドロップダウン電卓】
        Dim gcnumber10 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber10.DropDownCalculator.BackColor = Color.LightGoldenrodYellow
        gcnumber10.DropDownCalculator.BorderStyle = BorderStyle.None
        gcnumber10.DropDownCalculator.EditButtons.BackColor = Color.SlateBlue
        gcnumber10.DropDownCalculator.EditButtons.ForeColor = Color.White
        gcnumber10.DropDownCalculator.FlatStyle = FlatStyle.Flat
        gcnumber10.DropDownCalculator.MemoryButtons.BackColor = Color.Goldenrod
        gcnumber10.DropDownCalculator.MemoryButtons.ForeColor = Color.White
        gcnumber10.DropDownCalculator.MathButtons.BackColor = Color.DarkMagenta
        gcnumber10.DropDownCalculator.MathButtons.ForeColor = Color.White
        gcnumber10.DropDownCalculator.NumericButtons.BackColor = Color.Gray
        gcnumber10.DropDownCalculator.NumericButtons.ForeColor = Color.White
        gcnumber10.DropDownCalculator.Output.ForeColor = Color.DarkSlateBlue
        gcnumber10.DropDownCalculator.OutputHeight = 25
        gcnumber10.DropDownCalculator.ResetButtons.BackColor = Color.Salmon
        gcnumber10.DropDownCalculator.ResetButtons.ForeColor = Color.White
        sheet.Cells(9, 1).CellType = gcnumber10

        '【DeleteキーでNULL】
        Dim gcnumber11 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber11.AllowDeleteToNull = True
        gcnumber11.SideButtons.Clear()
        sheet.Cells(10, 1).CellType = gcnumber11
        sheet.Cells(10, 1).Value = 0

        '【マイナス値の色と記号】
        Dim gcnumber12 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber12.DisplayFields.Clear()
        gcnumber12.DisplayFields.AddRange("##########0,,,▲,")
        gcnumber12.Fields.SetFields("##########0,,,▲,")
        gcnumber12.NegativeColor = Color.Green
        gcnumber12.UseNegativeColor = True
        gcnumber12.SideButtons.Clear()
        sheet.Cells(11, 1).CellType = gcnumber12

        '【スピンボタン】
        Dim gcnumber13 As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        gcnumber13.SideButtons.Clear()
        gcnumber13.SideButtons.Add(New GrapeCity.Win.Spread.InputMan.CellType.SpinButtonInfo())
        gcnumber13.Spin.SpinOnKeys = True
        gcnumber13.Spin.SpinOnWheel = True
        sheet.Cells(12, 1).CellType = gcnumber13
        sheet.Cells(12, 1).Value = 0
    End Sub
End Class
