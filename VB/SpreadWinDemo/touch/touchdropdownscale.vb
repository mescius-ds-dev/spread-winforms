Public Class touchdropdownscale

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        NumericUpDown1.DecimalPlaces = 1
        NumericUpDown1.Increment = 0.1
        NumericUpDown1.Maximum = 4.0
        NumericUpDown1.Minimum = 1
        NumericUpDown1.Value = 1.5
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        sheet.RowCount = 10
        sheet.ColumnCount = 5

        ' 列の右端とインジケータの間隔を指定
        sheet.FpSpread.HeaderIndicatorPositionAdjusting = 4

        ' テストデータの設定
        For i As Integer = 0 To sheet.RowCount - 1
            sheet.Cells(i, 0).Value = i Mod 5
        Next

        ' 自動フィルタリング機能を有効
        sheet.Columns(0).AllowAutoFilter = True
        sheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu

        ' 列幅の設定
        sheet.Columns(1).Width = 160
        sheet.Columns(2).Width = 140
        sheet.Columns(3).Width = 120
        sheet.Columns(4).Width = 120

        ' コンボボックス型セルの設定
        Dim cmbocell As New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        cmbocell.Items = (New [String]() {"1月", "2月", "3月", "4月", "5月", "6月"})
        sheet.Cells(1, 1).CellType = cmbocell
        sheet.Cells(0, 1).Value = "コンボボックス型セル"
        sheet.Cells(1, 1).Value = "1月"

        ' 日付時刻型セルの設定
        Dim datecell As New FarPoint.Win.Spread.CellType.DateTimeCellType()
        datecell.DropDownButton = True
        sheet.Cells(1, 2).CellType = datecell
        sheet.Cells(0, 2).Value = "日付時刻型セル"
        sheet.Cells(1, 2).Value = DateTime.Today

        ' GcComboBox型セルの設定
        Dim gccmbcell As New GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType()
        Dim emp As New DataTable()
        emp.Columns.Add("氏名")
        emp.Columns.Add("所属")
        emp.Rows.Add(New [Object]() {"葡萄 花子", "営業部"})
        emp.Rows.Add(New [Object]() {"仙台 一郎", "開発部"})
        gccmbcell.DataSource = emp
        gccmbcell.TextFormat = "[0] 所属：[1]"
        sheet.Cells(4, 1).CellType = gccmbcell
        sheet.Cells(3, 1).Value = "GcComboBox型セル"
        sheet.Cells(4, 1).Value = "葡萄 花子 所属：営業部"

        ' GcDateTime型セルの設定
        Dim gcdatecell As New GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType()
        gcdatecell.Fields.Clear()
        gcdatecell.DisplayFields.Clear()
        gcdatecell.Fields.AddRange("yyyy年 MM月 dd日")
        gcdatecell.DisplayFields.AddRange("ggg ee年 M月 d日")
        sheet.Cells(4, 2).CellType = gcdatecell
        sheet.Cells(3, 2).Value = "GcDateTime型セル"
        sheet.Cells(4, 2).Value = DateTime.Today

        ' GcNumber型セルの設定
        Dim gcnumcell As New GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType()
        sheet.Cells(4, 3).CellType = gcnumcell
        sheet.Cells(3, 3).Value = "GcNumber型セル"
        sheet.Cells(4, 3).Value = 100

        ' GcTextBox型セルの設定
        Dim gctxtcell As New GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType()
        Dim MyDropDownButton As New GrapeCity.Win.Spread.InputMan.CellType.DropDownButtonInfo()
        MyDropDownButton.IsDefaultBehavior = True
        gctxtcell.SideButtons.Add(MyDropDownButton)
        sheet.Cells(4, 4).CellType = gctxtcell
        sheet.Cells(3, 4).Value = "GcTextBox型セル"
        sheet.Cells(4, 4).Value = "GcTextBox型セルの設定"
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        FpSpread1.TouchDropDownScale = CSng(Me.NumericUpDown1.Value)
    End Sub
End Class
