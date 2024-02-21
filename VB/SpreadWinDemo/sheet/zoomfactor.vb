Public Class zoomfactor

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        CheckBox1.Checked = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 36
        sheet.Columns(1).Width = 88
        sheet.Columns(2).Width = 91
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 181
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            FpSpread1.AllowUserZoom = True
        Else
            FpSpread1.AllowUserZoom = False
        End If
    End Sub

    Private Sub FpSpread1_UserZooming(sender As Object, e As FarPoint.Win.Spread.ZoomEventArgs) Handles FpSpread1.UserZooming
        Label2.Text = e.NewZoomFactor.ToString("#0%")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As System.EventArgs) Handles TrackBar1.Scroll
        If Not CheckBox1.Checked Then
            Return
        End If

        Dim zf As Single = CSng(TrackBar1.Value) / 10
        FpSpread1.ZoomFactor = zf
        Label2.Text = Me.FpSpread1.ZoomFactor.ToString("#0%")
    End Sub
End Class
