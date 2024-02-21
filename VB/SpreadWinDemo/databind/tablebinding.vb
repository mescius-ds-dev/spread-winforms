Public Class tablebinding

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(ByVal workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        ' テストデータの設定
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))

        ' テーブルの追加
        Dim table As GrapeCity.Spreadsheet.ITable = workbook.ActiveSheet.Tables.Add("B2:J14", GrapeCity.Spreadsheet.YesNoGuess.Yes)
        ' テーブルと連結
        table.DataSource = ds
    End Sub
End Class
