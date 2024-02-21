Public Class dragfillmenu

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        spread.AllowDragFill = True
        spread.EnableDragFillMenu = True
        spread.DragFillDataOnly = False
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        sheet.RowCount = 20
        sheet.ColumnCount = 10
        sheet.Cells(0, 0).Value = 1
        sheet.Cells(1, 0).Value = 3
        sheet.Cells(2, 0).Value = 5
        sheet.Cells(3, 0).Value = 7
        sheet.Cells(4, 0).Value = 9
        sheet.Cells(0, 0, 4, 0).BackColor = Color.LightBlue
        Dim currcell As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        currcell.CurrencySymbol = "円"
        currcell.ShowSeparator = True
        currcell.PositiveFormat = FarPoint.Win.Spread.CellType.CurrencyPositiveFormat.CurrencySymbolAfter
        sheet.Columns(1).CellType = currcell
        sheet.Cells(0, 1).Value = 1000
        sheet.Cells(1, 1).Value = 1500
        sheet.Cells(0, 1, 1, 1).BackColor = Color.LightPink
        Dim datecell As New FarPoint.Win.Spread.CellType.DateTimeCellType()
        datecell.Calendar = New System.Globalization.JapaneseCalendar()
        datecell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined
        datecell.UserDefinedFormat = "gg yy年M月d日"
        sheet.Columns(2).CellType = datecell
        sheet.Columns(2).Width = 120
        sheet.Cells(0, 2).Value = New DateTime(2018, 2, 21)
        sheet.Cells(1, 2).Value = New DateTime(2018, 2, 22)
        sheet.Cells(0, 2, 1, 2).BackColor = Color.LightGreen
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                FpSpread1.DragFillDataOnly = False
                Exit Select
            Case 1
                FpSpread1.DragFillDataOnly = True
                Exit Select
        End Select
    End Sub
End Class
