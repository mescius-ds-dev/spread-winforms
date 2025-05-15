Public Class tableautoupdate

    Public Sub New()

        InitializeComponent()

        ' ワークブックの設定
        InitWorkbook(FpSpread1.AsWorkbook())

        CheckBox1.Checked = True
    End Sub

    Private ds As DataSet
    Private Sub InitWorkbook(workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' フォントの設定
        Dim normalStyle As GrapeCity.Spreadsheet.IStyle = workbook.Styles(GrapeCity.Spreadsheet.BuiltInStyle.Normal)
        normalStyle.Font.Name = "メイリオ"
        normalStyle.Font.Size = 9

        ' テーブルの自動更新を有効
        workbook.ActiveSheet.AutoUpdateFilter = True

        ' テストデータの設定
        ds = New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))

        ' テーブルの追加
        Dim table As GrapeCity.Spreadsheet.ITable = workbook.ActiveSheet.Tables.Add("B2:J14", GrapeCity.Spreadsheet.YesNoGuess.Yes)
        ' テーブルと連結
        table.DataSource = ds
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        ' SPREADの準備が完了していない場合を除外
        If FpSpread1.Sheets.Count = 0 Then Return

        Dim workbook As GrapeCity.Spreadsheet.IWorkbook = FpSpread1.AsWorkbook()
        Dim table As GrapeCity.Spreadsheet.ITable = workbook.ActiveSheet.Tables(0)

        ' テーブルフィルタの自動更新の切り替え
        table.AutoFilter.AutoUpdate = CheckBox1.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' データソースの変更
        ds.Tables(0).Rows(6)(0) = "1001"
    End Sub
End Class
