Public Class lockedcell

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum2.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 141
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80
        sheet.Columns(6).Width = 80

        ' プロテクトとロック（DefaultStyle）の設定
        sheet.Protect = True
        sheet.DefaultStyle.Locked = False
        sheet.RowHeader.DefaultStyle.Locked = False
        sheet.ColumnHeader.DefaultStyle.Locked = False

        ' 1～3列目をロック
        sheet.Columns(0).Locked = True
        sheet.Columns(1).Locked = True
        sheet.Columns(2).Locked = True
        sheet.LockBackColor = Color.DarkGray
        sheet.LockForeColor = Color.LightGray
    End Sub
End Class
