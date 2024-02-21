Public Class scrollbarvisible

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ComboBox1.Text = "垂直スクロールバーを常に表示"
        ComboBox2.Text = "水平スクロールバーを常に表示"
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data30.xml"))
        sheet.DataSource = ds

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
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "垂直スクロールバーを表示しない" Then
            FpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        ElseIf ComboBox1.Text = "垂直スクロールバーを必要な場合のみ表示" Then
            FpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Else
            FpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Always
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "水平スクロールバーを表示しない" Then
            FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never
        ElseIf ComboBox2.Text = "水平スクロールバーを必要な場合のみ表示" Then
            FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        Else
            FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Always
        End If
    End Sub
End Class
