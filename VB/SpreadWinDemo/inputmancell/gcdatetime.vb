Public Class gcdatetime
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
        sheet.RowCount = 14

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
        sheet.Cells(0, 0).Text = "西暦入力／和暦表示"
        sheet.Cells(1, 0).Text = "時刻の入力書式と表示書式"
        sheet.Cells(2, 0).Text = "リテラル文字"
        sheet.Cells(3, 0).Text = "未入力の代替テキスト"
        sheet.Cells(4, 0).Text = "入力候補値"
        sheet.Cells(5, 0).Text = "範囲指定\r\n（2016/1/1～2016/12/31）"
        sheet.Cells(7, 0).Text = "自動フォーカス移動"
        sheet.Cells(8, 0).Text = "スピンボタン"
        sheet.Cells(9, 0).Text = "ドロップダウンカレンダー"
        sheet.Cells(10, 0).Text = "年月表示カレンダー"
        sheet.Cells(11, 0).Text = "カレンダーの祝日"
        sheet.Cells(12, 0).Text = "カレンダーの複数表示"
        sheet.Cells(13, 0).Text = "ドロップダウン日付ピッカー"

        sheet.Cells(0, 2).Text = "西暦で入力すると和暦で表示されます"
        sheet.Cells(1, 2).Text = "24時間制時刻で入力すると12時間制時刻で表示されます"
        sheet.Cells(2, 2).Text = "リテラル文字を表示します"
        sheet.Cells(3, 2).Text = "セルが未入力のときに代わりにテキストを表示します"
        sheet.Cells(4, 2).Text = "(Ctrl)+(Enter)で候補として表示された値を確定します"
        sheet.Cells(5, 2).Text = "範囲外の日付の場合は値をクリアします"
        sheet.Cells(6, 2).Text = "範囲外の日付の場合は値を最小値か最大値の近い方に設定します"
        sheet.Cells(7, 2).Text = "年月日を入力すると自動的に右のセルにフォーカスを移動します"
        sheet.Cells(8, 2).Text = "スピンボタンで日付を変更します"
        sheet.Cells(9, 2).Text = "ドロップダウンボタンでドロップダウンカレンダーを表示します"
        sheet.Cells(10, 2).Text = "年月表示のドロップダウンカレンダーを表示します"
        sheet.Cells(11, 2).Text = "ドロップダウンカレンダーで祝日のスタイルを設定します"
        sheet.Cells(12, 2).Text = "一度に6か月分のカレンダーを表示します"
        sheet.Cells(13, 2).Text = "ドロップダウンボタンで日付ピッカーを表示します"

        '【西暦入力／和暦表示】
        Dim gcdatetime1 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime1.DisplayFields.Clear()
        gcdatetime1.DisplayFields.AddRange("ggg e年M月d日")
        gcdatetime1.Fields.Clear()
        gcdatetime1.Fields.AddRange("yyyy年M月d日")
        gcdatetime1.FieldsEditMode = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditMode.Unfixed
        gcdatetime1.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime1.SideButtons.Clear()
        sheet.Cells(0, 1).CellType = gcdatetime1

        '【時刻の入力書式と表示書式】
        Dim gcdatetime2 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime2.DisplayFields.Clear()
        gcdatetime2.DisplayFields.AddRange("tthh時mm分ss秒")
        gcdatetime2.Fields.Clear()
        gcdatetime2.Fields.AddRange("HH:mm:ss")
        gcdatetime2.FieldsEditMode = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditMode.Unfixed
        gcdatetime2.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime2.SideButtons.Clear()
        sheet.Cells(1, 1).CellType = gcdatetime2

        '【リテラル文字】
        Dim gcdatetime3 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        Dim yearDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateYearDisplayFieldInfo()
        Dim monthDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateMonthDisplayFieldInfo()
        Dim dayDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateDayDisplayFieldInfo()
        Dim literalDisp1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateLiteralDisplayFieldInfo("ねん")
        Dim literalDisp2 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateLiteralDisplayFieldInfo("ガツ")
        Dim literalDisp3 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateLiteralDisplayFieldInfo("日")
        literalDisp1.ForeColor = Color.Red
        literalDisp2.ForeColor = Color.Green
        literalDisp3.ForeColor = Color.Blue
        gcdatetime3.DisplayFields.Clear()
        gcdatetime3.DisplayFields.AddRange(New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateDisplayFieldInfo() {yearDisp1, literalDisp1, monthDisp1, literalDisp2, dayDisp1, literalDisp3})
        Dim year1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateYearFieldInfo()
        Dim month1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateMonthFieldInfo()
        Dim day1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateDayFieldInfo()
        Dim literal1 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateLiteralFieldInfo("年")
        Dim literal2 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateLiteralFieldInfo("月")
        Dim literal3 As New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateLiteralFieldInfo("日")
        literal1.ForeColor = Color.Red
        literal2.ForeColor = Color.Green
        literal3.ForeColor = Color.Blue
        gcdatetime3.Fields.Clear()
        gcdatetime3.Fields.AddRange(New GrapeCity.Win.Spread.InputMan.CellType.Fields.DateFieldInfo() {year1, literal1, month1, literal2, day1, literal3})
        gcdatetime3.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime3.PaintByControl = True
        gcdatetime3.SideButtons.Clear()
        sheet.Cells(2, 1).CellType = gcdatetime3

        '【未入力の代替テキスト】
        Dim gcdatetime4 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime4.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen
        gcdatetime4.AlternateText.DisplayNull.Text = "＜入力項目＞"
        gcdatetime4.AlternateText.Null.ForeColor = Color.LightPink
        gcdatetime4.AlternateText.Null.Text = "西暦/月/日を入力"
        gcdatetime4.DisplayFields.Clear()
        gcdatetime4.DisplayFields.AddRange("yyyy年M月d日")
        gcdatetime4.Fields.Clear()
        gcdatetime4.Fields.AddRange("yyyy年M月d日")
        gcdatetime4.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime4.SideButtons.Clear()
        sheet.Cells(3, 1).CellType = gcdatetime4

        '【入力候補値】
        Dim gcdatetime5 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime5.DisplayFields.Clear()
        gcdatetime5.DisplayFields.AddRange("yyyy年M月d日")
        gcdatetime5.Fields.Clear()
        gcdatetime5.Fields.AddRange("yyyy年M月d日")
        gcdatetime5.RecommendedValue = DateTime.Today
        gcdatetime5.ShowRecommendedValue = True
        gcdatetime5.SideButtons.Clear()
        sheet.Cells(4, 1).CellType = gcdatetime5

        '【範囲指定】
        Dim gcdatetime6 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime6.DisplayFields.Clear()
        gcdatetime6.DisplayFields.AddRange("yyyy/MM/dd")
        gcdatetime6.Fields.Clear()
        gcdatetime6.Fields.AddRange("yyyy/MM/dd")
        gcdatetime6.FieldsEditMode = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditMode.Unfixed
        gcdatetime6.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime6.MaxDate = DateTime.Parse("2016/12/31")
        gcdatetime6.MinDate = DateTime.Parse("2016/01/01")
        gcdatetime6.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.Clear
        gcdatetime6.SideButtons.Clear()
        sheet.Cells(5, 1).CellType = gcdatetime6

        Dim gcdatetime7 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime7.DisplayFields.Clear()
        gcdatetime7.DisplayFields.AddRange("yyyy/MM/dd")
        gcdatetime7.Fields.Clear()
        gcdatetime7.Fields.AddRange("yyyy/MM/dd")
        gcdatetime7.FieldsEditMode = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditMode.Unfixed
        gcdatetime7.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime7.MaxDate = DateTime.Parse("2016/12/31")
        gcdatetime7.MinDate = DateTime.Parse("2016/01/01")
        gcdatetime7.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.AdjustToMaxMin
        gcdatetime7.SideButtons.Clear()
        sheet.Cells(6, 1).CellType = gcdatetime7

        sheet.Cells(5, 0).CellType = New FarPoint.Win.Spread.CellType.GeneralCellType() With {.Multiline = True}
        sheet.Cells(5, 0).RowSpan = 2
        sheet.Cells(5, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center

        '【自動フォーカス移動】
        Dim gcdatetime8 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime8.DisplayFields.Clear()
        gcdatetime8.DisplayFields.AddRange("yyyy/MM/dd")
        gcdatetime8.ExitOnLastChar = True
        gcdatetime8.Fields.Clear()
        gcdatetime8.Fields.AddRange("yyyy/MM/dd")
        gcdatetime8.FieldsEditMode = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditMode.Unfixed
        gcdatetime8.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime8.SideButtons.Clear()
        sheet.Cells(7, 1).CellType = gcdatetime8

        '【スピンボタン】
        Dim gcdatetime9 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime9.DisplayFields.Clear()
        gcdatetime9.DisplayFields.AddRange("yyyy/MM/dd")
        gcdatetime9.ExitOnLastChar = True
        gcdatetime9.Fields.Clear()
        gcdatetime9.Fields.AddRange("yyyy/MM/dd")
        gcdatetime9.FieldsEditMode = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditMode.Unfixed
        gcdatetime9.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcdatetime9.SideButtons.Clear()
        gcdatetime9.SideButtons.Add(New GrapeCity.Win.Spread.InputMan.CellType.SpinButtonInfo())
        gcdatetime9.Spin.SpinOnKeys = True
        gcdatetime9.Spin.SpinOnWheel = True
        sheet.Cells(8, 1).CellType = gcdatetime9
        sheet.Cells(8, 1).Value = DateTime.Today

        '【ドロップダウンカレンダー】
        Dim gcdatetime10 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime10.AlternateText.DisplayEmptyEra.Text = "和暦表示に未対応"
        gcdatetime10.AlternateText.EmptyEra.Text = "和暦表示に未対応"
        gcdatetime10.DisplayFields.Clear()
        gcdatetime10.DisplayFields.AddRange("gggee年MM月dd日")
        gcdatetime10.DropDownCalendar.BackColor = Color.Ivory
        gcdatetime10.DropDownCalendar.FlatStyle = FlatStyle.Flat
        gcdatetime10.DropDownCalendar.HeaderFormat = ("gggee年MM月")
        gcdatetime10.DropDownCalendar.HeaderStyle = New GrapeCity.Win.Spread.InputMan.CellType.Style(Color.Lavender, Color.Blue)
        gcdatetime10.DropDownCalendar.NavigatorOrientation = GrapeCity.Win.Spread.InputMan.CellType.NavigatorOrientation.Bottom
        gcdatetime10.DropDownCalendar.ShowNavigator = GrapeCity.Win.Spread.InputMan.CellType.CalendarNavigators.ScrollBar
        gcdatetime10.DropDownCalendar.UseHeaderFormat = True
        gcdatetime10.Fields.Clear()
        gcdatetime10.Fields.AddRange("gggee年MM月dd日")
        sheet.Cells(9, 1).CellType = gcdatetime10
        sheet.Cells(9, 1).Value = DateTime.Today

        '【年月表示カレンダー】
        Dim gcdatetime11 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime11.DropDownCalendar.CalendarType = GrapeCity.Win.Spread.InputMan.CellType.CalendarType.YearMonth
        gcdatetime11.DisplayFields.Clear()
        gcdatetime11.DisplayFields.AddRange("yyyy年MM月")
        gcdatetime11.Fields.Clear()
        gcdatetime11.Fields.AddRange("yyyy年MM月")
        sheet.Cells(10, 1).CellType = gcdatetime11
        sheet.Cells(10, 1).Value = DateTime.Today

        '【カレンダーの祝日】
        Dim gcdatetime12 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        Using ms As System.IO.UnmanagedMemoryStream = DirectCast(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".Holiday.xml"), System.IO.UnmanagedMemoryStream)
            Dim temp As Byte() = New Byte(ms.Length) {}
            ms.Read(temp, 0, ms.Length)
            System.IO.File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + "temp.xml", temp)
            gcdatetime12.DropDownCalendar.HolidayStyles = GrapeCity.Win.Spread.InputMan.CellType.HolidayStyleCollection.Load(AppDomain.CurrentDomain.BaseDirectory + "temp.xml")
            System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + "temp.xml")
        End Using
        gcdatetime12.DropDownCalendar.ActiveHolidayStyles = New String() {"NationalHoliday"}
        gcdatetime12.DisplayFields.Clear()
        gcdatetime12.DisplayFields.AddRange("yyyy年MM月dd日")
        gcdatetime12.Fields.Clear()
        gcdatetime12.Fields.AddRange("yyyy年MM月dd日")
        sheet.Cells(11, 1).CellType = gcdatetime12
        sheet.Cells(11, 1).Value = DateTime.Today

        '【カレンダーの複数表示】
        Dim gcdatetime13 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime13.DropDownCalendar.CalendarDimensions = New Size(3, 2)
        gcdatetime13.DisplayFields.Clear()
        gcdatetime13.DisplayFields.AddRange("yyyy年MM月dd日")
        gcdatetime13.Fields.Clear()
        gcdatetime13.Fields.AddRange("yyyy年MM月dd日")
        sheet.Cells(12, 1).CellType = gcdatetime13
        sheet.Cells(12, 1).Value = DateTime.Today

        '【ドロップダウン日付ピッカー】
        Dim gcdatetime14 As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatetime14.DropDown.DropDownType = GrapeCity.Win.Spread.InputMan.CellType.DateDropDownType.Picker
        gcdatetime14.DropDownPicker.BackColor = Color.LemonChiffon
        gcdatetime14.DropDownPicker.HeaderBackColor = Color.Ivory
        gcdatetime14.DropDownPicker.SelectedBackColor = Color.Pink
        gcdatetime14.DropDownPicker.SelectedForeColor = Color.Navy
        gcdatetime14.DropDownPicker.SelectionRenderMode = GrapeCity.Win.Spread.InputMan.CellType.SelectionRenderMode.Fill
        gcdatetime14.DropDownPicker.DateTabText = "Date"
        gcdatetime14.DropDownPicker.TimeTabText = "Time"
        gcdatetime14.DisplayFields.Clear()
        gcdatetime14.DisplayFields.AddRange("yyyy/MM/dd HH:mm")
        gcdatetime14.Fields.Clear()
        gcdatetime14.Fields.AddRange("yyyy/MM/dd HH:mm")
        sheet.Cells(13, 1).CellType = gcdatetime14
        sheet.Cells(13, 1).Value = DateTime.Now
    End Sub
End Class
