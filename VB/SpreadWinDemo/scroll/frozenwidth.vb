Public Class frozenwidth

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datascroll.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 100
        sheet.Columns(1).Width = 80
        sheet.Columns(2).Width = 80
        sheet.Columns(3).Width = 100
        sheet.Columns(4).Width = 100
        sheet.Columns(5).Width = 60
        sheet.Columns(6).Width = 100
        sheet.Columns(7).Width = 300
        sheet.Columns(8).Width = 80
        sheet.Columns(9).Width = 80
        sheet.Columns(10).Width = 140
        sheet.Columns(11).Width = 100
        sheet.Columns(12).Width = 60
        sheet.Columns(13).Width = 80
        sheet.Columns(14).Width = 60

        ' 行・列を固定
        sheet.FrozenRowCount = 1
        sheet.FrozenColumnCount = 3

        ' 固定線の太さ設定
        FpSpread1.ActiveSheet.AsWorksheet().Options.FrozenLineThickness = 10
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As System.EventArgs) Handles TrackBar1.Scroll
        FpSpread1.ActiveSheet.AsWorksheet().Options.FrozenLineThickness = TrackBar1.Value
        Label2.Text = TrackBar1.Value.ToString("#0")
    End Sub
End Class
