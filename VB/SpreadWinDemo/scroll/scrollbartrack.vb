Public Class scrollbartrack

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        CheckBox1.Checked = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
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
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            FpSpread1.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Off
        Else
            FpSpread1.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            FpSpread1.ScrollTipPolicy = FarPoint.Win.Spread.ScrollTipPolicy.Both
        Else
            FpSpread1.ScrollTipPolicy = FarPoint.Win.Spread.ScrollTipPolicy.Off
        End If
    End Sub
End Class
