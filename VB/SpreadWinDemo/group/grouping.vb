Public Class grouping

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
        sheet.Columns(1).Width = 90
        sheet.Columns(2).Width = 94
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 50
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 60

        ' 行高の設定
        sheet.Rows.Default.Height = 26

        ' 列の非表示
        sheet.Columns(7).Visible = False
        sheet.Columns(8).Visible = False

        ' グループ化の設定
        sheet.FpSpread.AllowColumnMove = True
        sheet.AllowGroup = True
        sheet.GroupBarVisible = True
        sheet.GroupBarInfo.Text = "列ヘッダをここにドラッグしてグループ化します"
    End Sub
End Class
