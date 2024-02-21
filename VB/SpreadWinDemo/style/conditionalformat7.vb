Public Class conditionalformat7

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".dataconditionalformat.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 120
        sheet.Columns(1).Width = 80
        sheet.Columns(2).Width = 80
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80

        ' 行の追加
        sheet.AddRows(sheet.RowCount, 1)
        sheet.Cells(sheet.RowCount - 1, 0).Value = "平均"
        sheet.Rows(sheet.RowCount - 1).BackColor = System.Drawing.Color.Khaki

        ' 数式の設定
        For i As Integer = 1 To sheet.ColumnCount - 1
            Dim col As String = Convert.ToString(ChrW(65 + i))
            sheet.Cells(sheet.RowCount - 1, i).Formula = "AVERAGE(" & col & "1:" & col & Convert.ToString(sheet.RowCount - 1) & ")"
        Next

        Dim cf As New FarPoint.Win.Spread.ConditionalFormatting(New FarPoint.Win.Spread.Model.CellRange(0, 1, sheet.RowCount - 1, sheet.ColumnCount))
        Dim rule As New FarPoint.Win.Spread.DatabarConditionalFormattingRule()
        rule.BorderColor = System.Drawing.Color.Silver
        rule.ShowBorder = True
        rule.Gradient = True
        rule.Minimum = New FarPoint.Win.Spread.ConditionalFormattingValue(0, FarPoint.Win.Spread.ConditionalFormattingValueType.Number)
        rule.Maximum = New FarPoint.Win.Spread.ConditionalFormattingValue(100, FarPoint.Win.Spread.ConditionalFormattingValueType.Max)
        cf.Add(rule)
        sheet.Models.ConditionalFormatting.Add(cf)

        Dim cf1 As New FarPoint.Win.Spread.ConditionalFormatting(New FarPoint.Win.Spread.Model.CellRange(sheet.RowCount - 1, 1, 1, sheet.ColumnCount))
        Dim rule1 As New FarPoint.Win.Spread.IconSetConditionalFormattingRule(FarPoint.Win.Spread.ConditionalFormattingIconSetStyle.ThreeFlags)
        cf1.Add(rule1)
        sheet.Models.ConditionalFormatting.Add(cf1)
    End Sub
End Class
