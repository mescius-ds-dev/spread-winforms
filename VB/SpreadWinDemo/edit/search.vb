Public Class search

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
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 71
        sheet.Columns(8).Width = 181

        ' セルノート設定
        sheet.Cells(0, 0).Note = "人事異動予定"
        sheet.Cells(0, 0).NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote

        ' タグ設定
        sheet.Cells(1, 0).Tag = "退職予定"
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' 標準検索の実行
        FpSpread1.SearchWithDialog("人事部")
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' 高度な検索の実行
        FpSpread1.SearchWithDialogAdvanced("人事異動予定")
    End Sub
End Class
