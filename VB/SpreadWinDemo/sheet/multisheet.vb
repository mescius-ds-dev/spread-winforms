Public Class multisheet

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シート設定
        InitSpreadStyles1(FpSpread1.Sheets(0))
        InitSpreadStyles2(FpSpread1.Sheets(1))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' シート追加
        Dim sht As New FarPoint.Win.Spread.SheetView()
        spread.Sheets.Add(sht)
    End Sub

    Private Sub InitSpreadStyles1(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datapln.xml"))
        sheet.DataSource = ds
        sheet.SheetName = "計画シート"

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
        sheet.SheetName = "実績シート"

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next
    End Sub
End Class
