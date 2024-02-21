Public Class title

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シート設定
        InitSpreadStyles1(FpSpread1.Sheets(0))
        InitSpreadStyles2(FpSpread1.Sheets(1))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        spread.Sheets.Count = 2

        ' タイトルの設定
        spread.TitleInfo.Visible = True
        spread.TitleInfo.Text = "グレープ商事"
        spread.TitleInfo.Font = New Font("メイリオ", 16)
        spread.TitleInfo.Height = 40
    End Sub

    Private Sub InitSpreadStyles1(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datapln.xml"))
        sheet.DataSource = ds

        ' サブタイトルの設定
        sheet.TitleInfo.Visible = True
        sheet.TitleInfo.Text = "計画シート"
        sheet.TitleInfo.BackColor = System.Drawing.Color.Orange
        sheet.TitleInfo.Font = New Font("メイリオ", 12)

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next
    End Sub

    Private Sub InitSpreadStyles2(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datares.xml"))
        sheet.DataSource = ds

        ' サブタイトルの設定
        sheet.TitleInfo.Visible = True
        sheet.TitleInfo.Text = "実績シート"
        sheet.TitleInfo.BackColor = System.Drawing.Color.Silver
        sheet.TitleInfo.Font = New Font("メイリオ", 12)

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next
    End Sub
End Class
