Public Class filterbar

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 100
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 100
        sheet.Columns(3).Width = 120
        sheet.Columns(4).Width = 100
        sheet.Columns(5).Width = 100
        sheet.Columns(6).Width = 100
        sheet.Columns(7).Width = 130
        sheet.Columns(8).Width = 190

        ' フィルタリングの設定
        sheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.FilterBar

        Dim ct1 As New FarPoint.Win.Spread.CellType.FilterBarCellType()
        ct1.ContextMenuType = FarPoint.Win.Spread.CellType.FilterBarContextMenuType.Number
        Dim nc As New FarPoint.Win.Spread.CellType.NumberCellType()
        sheet.FilterBar.Cells(0).CellType = ct1
        nc.DecimalPlaces = 0
        sheet.Columns(0).CellType = nc
        sheet.FilterBar.Cells(3).CellType = ct1

        Dim ct2 As New FarPoint.Win.Spread.CellType.FilterBarCellType()
        ct2.FormatString = "yyyy/MM/dd"
        ct2.ContextMenuType = FarPoint.Win.Spread.CellType.FilterBarContextMenuType.DateTime

        sheet.FilterBar.Cells(3).CellType = ct2
        sheet.FilterBar.Cells(3).BackColor = System.Drawing.Color.Yellow

        sheet.FilterBar.Cells(7).CellType = ct2
        sheet.FilterBar.Cells(7).BackColor = System.Drawing.Color.Tomato
    End Sub
End Class
