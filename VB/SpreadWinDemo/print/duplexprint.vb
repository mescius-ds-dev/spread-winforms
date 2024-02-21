Public Class duplexprint

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".data50.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 110
        sheet.Columns(2).Width = 110
        sheet.Columns(3).Width = 100
        sheet.Columns(4).Width = 50
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 50
        sheet.Columns(7).Width = 100
        sheet.Columns(8).Width = 240
    End Sub

    Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
        ' 両面印刷の指定
        FpSpread1.Sheets(0).PrintInfo.Duplex = System.Drawing.Printing.Duplex.Vertical
        ' 印刷
        FpSpread1.PrintSheet(FpSpread1.Sheets(0))
    End Sub
End Class
