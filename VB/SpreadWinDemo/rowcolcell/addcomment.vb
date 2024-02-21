Public Class addcomment

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitSheet(ByVal sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.[GetType]().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
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

        ' コメントの設定
        FpSpread1.Features.EnhancedShapeEngine = True
        Dim username As String = FpSpread1.AsWorkbook().WorkbookSet.UserName & ":"
        Dim richText As GrapeCity.Spreadsheet.RichText = New GrapeCity.Spreadsheet.RichText(username & vbCrLf & "新しいコメント")
        Dim font As GrapeCity.Spreadsheet.Font = GrapeCity.Spreadsheet.Font.Empty
        font.Bold = True
        richText.Format(0, username.Length, font)
        FpSpread1.AsWorkbook().ActiveSheet.Cells("B2").AddComment(richText)
        FpSpread1.AsWorkbook().ActiveSheet.Cells("B2").Comment.Visible = True
    End Sub
End Class
