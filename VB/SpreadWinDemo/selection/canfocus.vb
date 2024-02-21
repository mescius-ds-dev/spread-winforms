Public Class canfocus

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".databind.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 140

        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next

        '「計画」列の背景色を設定
        For i As Integer = 0 To 11
            sheet.Columns(i * 2 + 3).BackColor = System.Drawing.Color.LavenderBlush
        Next

        '「計画」列をスキップ
        For i As Integer = 0 To 11
            sheet.Columns(i * 2 + 3).CanFocus = False
        Next
    End Sub
End Class
