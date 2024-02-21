Public Class hiderowfilter

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

        ' フィルターを設定
        Dim hideRowFilter As New FarPoint.Win.Spread.HideRowFilter(sheet)
        hideRowFilter.AllString = "<すべて>"
        hideRowFilter.NonBlanksString = "<空白以外>"
        sheet.RowFilter = hideRowFilter
        'フィルターを設定
        sheet.ColumnHeaderAutoFilterIndex = 1

        ' フィルターに列を追加
        Dim fcd As FarPoint.Win.Spread.FilterColumnDefinition
        fcd = New FarPoint.Win.Spread.FilterColumnDefinition(4)
        hideRowFilter.AddColumn(fcd)
        fcd = New FarPoint.Win.Spread.FilterColumnDefinition(5)
        hideRowFilter.AddColumn(fcd)
        fcd = New FarPoint.Win.Spread.FilterColumnDefinition(6)
        hideRowFilter.AddColumn(fcd)
    End Sub
End Class
