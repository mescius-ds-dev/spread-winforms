Public Class stylerowfilter

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

        ' メールアドレス非表示
        sheet.Columns(8).Visible = False

        ' 列幅の設定
        sheet.Columns(0).Width = 40
        sheet.Columns(1).Width = 90
        sheet.Columns(2).Width = 97
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 70
        sheet.Columns(5).Width = 70
        sheet.Columns(6).Width = 75
        sheet.Columns(7).Width = 80

        sheet.ColumnHeaderAutoTextIndex = 0
        sheet.ColumnHeader.RowCount = 2

        ' フィルタ用スタイル設定
        Dim instyle As New FarPoint.Win.Spread.NamedStyle()
        Dim outstyle As New FarPoint.Win.Spread.NamedStyle()

        instyle.BackColor = System.Drawing.Color.Orange
        instyle.ForeColor = System.Drawing.Color.Red

        outstyle.BackColor = System.Drawing.Color.WhiteSmoke

        ' フィルターを設定
        Dim styleRowFilter As New FarPoint.Win.Spread.StyleRowFilter(sheet, instyle, outstyle)
        styleRowFilter.AllString = "<すべて>"
        styleRowFilter.NonBlanksString = "<空白以外>"

        ' フィルターに列を追加
        Dim fcd As FarPoint.Win.Spread.FilterColumnDefinition
        fcd = New FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.Default)
        styleRowFilter.AddColumn(fcd)
        fcd = New FarPoint.Win.Spread.FilterColumnDefinition(5, FarPoint.Win.Spread.FilterListBehavior.Default)
        styleRowFilter.AddColumn(fcd)
        fcd = New FarPoint.Win.Spread.FilterColumnDefinition(6, FarPoint.Win.Spread.FilterListBehavior.Default)
        styleRowFilter.AddColumn(fcd)

        ' シートに対して設定
        sheet.RowFilter = styleRowFilter
        'フィルターを設定
        sheet.ColumnHeaderAutoFilterIndex = 1
    End Sub
End Class
