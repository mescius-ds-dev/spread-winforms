Public Class unsortedrows

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data30.xml"))
        sheet.DataSource = ds

        ' シート設定
        sheet.FrozenRowCount = 2

        ' 列幅の設定
        sheet.Columns(0).Width = 70
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 80
        sheet.Columns(3).Width = 140
        sheet.Columns(4).Width = 140
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 80
        sheet.Columns(7).Width = 50
        sheet.Columns(8).Width = 60
        sheet.Columns(9).Width = 70
        sheet.Columns(10).Width = 300

        ' 列の非表示
        sheet.Columns(3).Visible = False
        sheet.Columns(4).Visible = False
        sheet.Columns(10).Visible = False

        ' 自動ソートを有効化
        For i As Integer = 0 To sheet.ColumnCount - 1
            sheet.Columns(i).AllowAutoSort = True
        Next
    End Sub

    Private Sub FpSpread1_AutoSortingColumn(sender As Object, e As FarPoint.Win.Spread.AutoSortingColumnEventArgs) Handles FpSpread1.AutoSortingColumn
        ' 固定行をソートしない
        e.SortFrozenRows = False
    End Sub
End Class
