Public Class gccombobox
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
        sheet.RowCount = 12

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
        sheet.Cells(1, 0).Text = "文字種の自動変換"
        sheet.Cells(2, 0).Text = "未入力時の代替テキスト"
        sheet.Cells(3, 0).Text = "入力候補値"
        sheet.Cells(4, 0).Text = "最大文字数"
        sheet.Cells(5, 0).Text = "自動フォーカス移動"
        sheet.Cells(6, 0).Text = "オートコンプリート"
        sheet.Cells(7, 0).Text = "オートフィルタ"
        sheet.Cells(8, 0).Text = "データソース接続"
        sheet.Cells(9, 0).Text = "項目スタイル"
        sheet.Cells(10, 0).Text = "項目ツールチップ"
        sheet.Cells(11, 0).Text = "サイドボタン"

        sheet.Cells(0, 2).Text = "入力可能な文字種をカタカナに限定します"
        sheet.Cells(1, 2).Text = "全角の文字を入力すると半角に変換されます"
        sheet.Cells(2, 2).Text = "セルが未入力のときに代わりにテキストを表示します"
        sheet.Cells(3, 2).Text = "(Ctrl)+(Enter)で候補として表示された値を確定します"
        sheet.Cells(4, 2).Text = "最大5文字までしか入力できません"
        sheet.Cells(5, 2).Text = "5文字入力すると自動的に右のセルにフォーカスを移動します"
        sheet.Cells(6, 2).Text = "入力した文字を含む候補リストを表示します"
        sheet.Cells(7, 2).Text = "入力した文字を含む項目からなるリストを表示します"
        sheet.Cells(8, 2).Text = "リスト項目をデータ連結で設定します"
        sheet.Cells(9, 2).Text = "リスト項目ごとにスタイルを設定します"
        sheet.Cells(10, 2).Text = "リスト項目ごとに任意のツールチップを設定します"
        sheet.Cells(11, 2).Text = "スピンボタンを追加します"

        '【書式の設定】
        Dim gccombo1 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo1.AutoConvert = False
        gccombo1.DropDown.AllowResize = False
        gccombo1.FormatString = "Ｋ"
        gccombo1.Items.AddRange(New String() {"アイウエオ", "カキクケコ", "サシスセソ", "タチツテト", "ナニヌネノ"})
        gccombo1.ListHeaderPane.Visible = False
        sheet.Cells(0, 1).CellType = gccombo1
        sheet.Cells(0, 1).Value = "アイウエオ"

        '【文字種の自動変換】
        Dim gccombo2 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo2.AutoConvert = True
        gccombo2.DropDown.AllowResize = False
        gccombo2.FormatString = "H"
        gccombo2.Items.AddRange(New String() {"ｱｲｳｴｵ", "12345", "ABCDE", "abcde", "."",'@"})
        gccombo2.ListHeaderPane.Visible = False
        sheet.Cells(1, 1).CellType = gccombo2
        sheet.Cells(1, 1).ImeMode = System.Windows.Forms.ImeMode.Hiragana
        sheet.Cells(1, 1).Value = "ｱｲｳｴｵ"

        '【未入力時の代替テキスト】
        Dim gccombo3 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo3.DropDown.AllowResize = False
        gccombo3.Items.AddRange(New String() {"項目１", "項目２", "項目３", "項目４", "項目５"})
        gccombo3.ListHeaderPane.Visible = False
        gccombo3.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen
        gccombo3.AlternateText.DisplayNull.Text = "＜入力項目＞"
        gccombo3.AlternateText.Null.ForeColor = Color.LightPink
        gccombo3.AlternateText.Null.Text = "入力してください"
        sheet.Cells(2, 1).CellType = gccombo3

        '【入力候補値】
        Dim gccombo4 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo4.DropDown.AllowResize = False
        gccombo4.Items.AddRange(New String() {"項目１", "項目２", "項目３", "項目４", "項目５"})
        gccombo4.ListHeaderPane.Visible = False
        gccombo4.ShowRecommendedValue = True
        gccombo4.RecommendedValue = "項目１"
        sheet.Cells(3, 1).CellType = gccombo4

        '【最大文字数】
        Dim gccombo5 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo5.DropDown.AllowResize = False
        gccombo5.Items.AddRange(New String() {"あいうえお", "ｱｲｳｴｵ", "12345", "ABCDE", "abcde"})
        gccombo5.ListHeaderPane.Visible = False
        gccombo5.MaxLength = 5
        gccombo5.MaxLengthUnit = GrapeCity.Win.Spread.InputMan.CellType.LengthUnit.Char
        sheet.Cells(4, 1).CellType = gccombo5

        '【自動フォーカス移動】
        Dim gccombo6 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo6.DropDown.AllowResize = False
        gccombo6.ExitOnLastChar = True
        gccombo6.Items.AddRange(New String() {"あいうえお", "ｱｲｳｴｵ", "12345", "ABCDE", "abcde"})
        gccombo6.ListHeaderPane.Visible = False
        gccombo6.MaxLength = 5
        gccombo6.MaxLengthUnit = GrapeCity.Win.Spread.InputMan.CellType.LengthUnit.Char
        sheet.Cells(5, 1).CellType = gccombo6

        '【オートコンプリート】
        Dim gccombo7 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo7.AutoComplete.MatchingMode = GrapeCity.Win.Spread.InputMan.CellType.AutoCompleteMatchingMode.MatchAll
        gccombo7.AutoComplete.HighlightMatchedText = True
        gccombo7.AutoComplete.HighlightStyle.BackColor = Color.LavenderBlush
        gccombo7.AutoComplete.HighlightStyle.ForeColor = Color.Red
        gccombo7.AutoCompleteMode = AutoCompleteMode.Suggest
        gccombo7.AutoCompleteSource = AutoCompleteSource.ListItems
        gccombo7.DropDown.AllowResize = False
        gccombo7.ListColumns.Add("Name")
        gccombo7.ListColumns.Add("Code")
        Dim item7 As GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo
        item7 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("abcde", Nothing, ContentAlignment.MiddleLeft, False, False))
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(100, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo7.Items.Add(item7)
        item7 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("bcdef", Nothing, ContentAlignment.MiddleLeft, False, False))
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(200, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo7.Items.Add(item7)
        item7 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("cdefg", Nothing, ContentAlignment.MiddleLeft, False, False))
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(300, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo7.Items.Add(item7)
        item7 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("12345", Nothing, ContentAlignment.MiddleLeft, False, False))
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(400, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo7.Items.Add(item7)
        item7 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("23456", Nothing, ContentAlignment.MiddleLeft, False, False))
        item7.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(500, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo7.Items.Add(item7)
        gccombo7.ListHeaderPane.Visible = False
        sheet.Cells(6, 1).CellType = gccombo7

        '【オートフィルタ】
        Dim gccombo8 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo8.AutoFilter.Enabled = True
        gccombo8.AutoFilter.Interval = 500
        gccombo8.AutoFilter.MaxFilteredItems = 5
        gccombo8.AutoFilter.MinimumPrefixLength = 1
        gccombo8.AutoFilter.MatchingMode = GrapeCity.Win.Spread.InputMan.CellType.AutoCompleteMatchingMode.MatchAll
        gccombo8.AutoFilter.MatchingSource = GrapeCity.Win.Spread.InputMan.CellType.FilterMatchingSource.AllSubItems
        gccombo8.DropDown.AllowResize = False
        gccombo8.DropDownStyle = ComboBoxStyle.DropDown
        gccombo8.ListColumns.Add("Name")
        gccombo8.ListColumns.Add("Code")
        Dim item8 As GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo
        item8 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("abcde", Nothing, ContentAlignment.MiddleLeft, False, False))
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(100, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo8.Items.Add(item8)
        item8 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("bcdef", Nothing, ContentAlignment.MiddleLeft, False, False))
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(200, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo8.Items.Add(item8)
        item8 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("cdefg", Nothing, ContentAlignment.MiddleLeft, False, False))
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(300, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo8.Items.Add(item8)
        item8 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("12345", Nothing, ContentAlignment.MiddleLeft, False, False))
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(400, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo8.Items.Add(item8)
        item8 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("23456", Nothing, ContentAlignment.MiddleLeft, False, False))
        item8.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(500, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo8.Items.Add(item8)
        gccombo8.ListHeaderPane.Visible = False
        sheet.Cells(7, 1).CellType = gccombo8

        '【データソース接続】
        ' データの作成
        Dim dt As New DataTable("ComboList")
        dt.Columns.Add("Image", GetType(Image))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Code", GetType(Int32))
        Dim image As Image
        image = image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".history.gif"))
        dt.Rows.Add(image, "歴史", 100)
        image = image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".music.gif"))
        dt.Rows.Add(image, "音楽", 200)
        image = image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".science.gif"))
        dt.Rows.Add(Image, "科学", 300)

        ' コンボボックス型セルの設定
        Dim gccombo9 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        '' 自動列生成機能を使わない場合
        'gccombo9.AutoGenerateColumns = False
        'gccombo9.ListColumns.Add(New GrapeCity.Win.Spread.InputMan.CellType.ListColumnInfo("Image") With {.DataDisplayType = GrapeCity.Win.Spread.InputMan.CellType.DataDisplayType.Image})
        'gccombo9.ListColumns.Add("Name")
        'gccombo9.ListColumns.Add("Code")
        'gccombo9.ListColumns(0).DataPropertyName = "Image"
        'gccombo9.ListColumns(1).DataPropertyName = "Name"
        'gccombo9.ListColumns(2).DataPropertyName = "Code"
        gccombo9.DataSource = dt
        gccombo9.DropDown.AutoWidth = True
        gccombo9.EditorValue = GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditorValue.Value
        gccombo9.TextSubItemIndex = 1
        gccombo9.ValueSubItemIndex = 2
        sheet.Cells(8, 1).CellType = gccombo9
        sheet.Cells(8, 1).Value = 100

        '【項目スタイル 】
        Dim gccombo10 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo10.DropDown.AllowResize = False
        gccombo10.EditorValue = GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditorValue.Value
        gccombo10.ExitOnLastChar = True
        gccombo10.ListColumns.Add("Name")
        gccombo10.ListColumns.Add("Code")
        Dim item10 As GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo
        item10 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目１", Nothing, ContentAlignment.MiddleLeft, False, False))
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(100, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo10.Items.Add(item10)
        item10 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目２", Nothing, ContentAlignment.MiddleLeft, False, False))
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(200, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo10.Items.Add(item10)
        item10 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目３", Nothing, ContentAlignment.MiddleLeft, False, False))
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(300, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo10.Items.Add(item10)
        item10 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目４", Nothing, ContentAlignment.MiddleLeft, False, False))
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(400, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo10.Items.Add(item10)
        item10 = New GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo()
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目５", Nothing, ContentAlignment.MiddleLeft, False, False))
        item10.SubItems.Add(New GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(500, Nothing, ContentAlignment.MiddleLeft, False, False))
        gccombo10.Items.Add(item10)
        gccombo10.ListHeaderPane.Visible = False
        Dim itemTemp1 As New GrapeCity.Win.Spread.InputMan.CellType.ItemTemplateInfo(0, Nothing, Color.Silver, Color.Black, -1, FpSpread1.Font, Nothing)
        Dim itemTemp2 As New GrapeCity.Win.Spread.InputMan.CellType.ItemTemplateInfo(0, Nothing, Color.Black, Color.White, -1, FpSpread1.Font, Nothing)
        gccombo10.ListItemTemplates.Add(itemTemp1)
        gccombo10.ListItemTemplates.Add(itemTemp2)
        gccombo10.TextSubItemIndex = 0
        gccombo10.ValueSubItemIndex = 1
        sheet.Cells(9, 1).CellType = gccombo10
        sheet.Cells(9, 1).Value = 100

        '【項目ツールチップ】
        Dim gccombo11 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo11.DropDown.AllowResize = False
        gccombo11.Items.AddRange(New String() {"項目１", "項目２", "項目３", "項目４", "項目５"})
        gccombo11.Items(0).ToolTipText = "ヒント１"
        gccombo11.Items(1).ToolTipText = "ヒント２"
        gccombo11.Items(2).ToolTipText = "ヒント３"
        gccombo11.Items(3).ToolTipText = "ヒント４"
        gccombo11.Items(4).ToolTipText = "ヒント５"
        gccombo11.ListHeaderPane.Visible = False
        gccombo11.ShowItemTip = True
        sheet.Cells(10, 1).CellType = gccombo11
        sheet.Cells(10, 1).Value = "項目１"

        '【サイドボタン】
        Dim gccombo12 As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        gccombo12.DropDown.AllowResize = False
        gccombo12.Items.AddRange(New String() {"項目１", "項目２", "項目３", "項目４", "項目５"})
        gccombo12.ListHeaderPane.Visible = False
        gccombo12.SideButtons.Insert(0, New GrapeCity.Win.Spread.InputMan.CellType.SpinButtonInfo())
        gccombo12.Spin.SpinOnKeys = True
        gccombo12.Spin.SpinOnWheel = True
        sheet.Cells(11, 1).CellType = gccombo12
        sheet.Cells(11, 1).Value = "項目１"
    End Sub

    Private Sub FpSpread1_EditModeOn(sender As Object, e As EventArgs) Handles FpSpread1.EditModeOn
        ' コンボボックス型セルの編集コントロールの文字位置の調節
        If TypeOf FpSpread1.EditingControl Is GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditingControl Then
            Dim combo As GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditingControl = DirectCast(FpSpread1.EditingControl, GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditingControl)
            combo.Padding = New Padding(0)
        End If
    End Sub
End Class
