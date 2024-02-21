Public Class gettoprowcol

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data30.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 50
        sheet.Columns(2).Width = 90
        sheet.Columns(3).Width = 120
        sheet.Columns(4).Width = 150
        sheet.Columns(5).Width = 40
        sheet.Columns(6).Width = 80
        sheet.Columns(7).Width = 40
        sheet.Columns(8).Width = 70
        sheet.Columns(9).Width = 70
        sheet.Columns(10).Width = 280
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' 先頭行の取得
        Dim TopRow As Integer = FpSpread1.GetViewportTopRow(0)
        MessageBox.Show(TopRow.ToString())
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' 先頭列の取得
        Dim LeftCol As Integer = FpSpread1.GetViewportLeftColumn(0)
        MessageBox.Show(LeftCol.ToString())
    End Sub
End Class
