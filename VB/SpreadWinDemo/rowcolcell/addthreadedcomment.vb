Public Class addthreadedcomment

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        ' 列幅の設定
        workbook.ActiveSheet.Columns(0).ColumnWidth = 36
        workbook.ActiveSheet.Columns(1).ColumnWidth = 88
        workbook.ActiveSheet.Columns(2).ColumnWidth = 91
        workbook.ActiveSheet.Columns(3).ColumnWidth = 80
        workbook.ActiveSheet.Columns(4).ColumnWidth = 36
        workbook.ActiveSheet.Columns(5).ColumnWidth = 46
        workbook.ActiveSheet.Columns(6).ColumnWidth = 49
        workbook.ActiveSheet.Columns(7).ColumnWidth = 80
        workbook.ActiveSheet.Columns(8).ColumnWidth = 181

        ' スレッド形式のコメント
        FpSpread1.Features.EnhancedShapeEngine = True
        FpSpread1.AsWorkbook().ActiveSheet.Cells("B2").AddCommentThreaded("スレッド形式のコメント").AddReply("最初の返信")
    End Sub
End Class
