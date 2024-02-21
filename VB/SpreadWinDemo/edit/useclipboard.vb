Public Class useclipboard

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        CheckBox1.Checked = True
        CheckBox2.Checked = True
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
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 181
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        FpSpread1.AutoClipboard = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            FpSpread1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.AllHeaders
        Else
            FpSpread1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        End If
    End Sub
End Class
