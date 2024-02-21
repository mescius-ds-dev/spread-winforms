Public Class autosort

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
        sheet.Columns(0).Width = 36
        sheet.Columns(1).Width = 88
        sheet.Columns(2).Width = 91
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 50
        sheet.Columns(5).Width = 60
        sheet.Columns(6).Width = 50
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 181

        ' 自動ソートを有効化
        For i As Integer = 0 To sheet.ColumnCount - 1
            sheet.Columns(i).AllowAutoSort = True
        Next
    End Sub
End Class
