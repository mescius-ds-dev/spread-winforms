Public Class sheetvisible

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet1(FpSpread1.Sheets(0))
        InitSheet2(FpSpread1.Sheets(1))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' シート追加
        Dim sht As New FarPoint.Win.Spread.SheetView()
        spread.Sheets.Add(sht)

        ' シートタブを常に表示
        spread.TabStripPolicy = FarPoint.Win.Spread.TabStripPolicy.Always
    End Sub

    Private Sub InitSheet1(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datapln.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next

        ' シート名設定
        sheet.SheetName = "計画シート"
    End Sub

    Private Sub InitSheet2(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datares.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next

        ' シート名設定
        sheet.SheetName = "実績シート"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' 全シート表示
        For i As Integer = 0 To FpSpread1.Sheets.Count - 1
            FpSpread1.Sheets(i).Visible = True
        Next

        If ComboBox1.Text = "計画シート非表示" Then
            FpSpread1.Sheets(0).Visible = False
        ElseIf ComboBox1.Text = "実績シート非表示" Then
            FpSpread1.Sheets(1).Visible = False
        End If
    End Sub
End Class
