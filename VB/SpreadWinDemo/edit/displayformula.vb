Public Class displayformula

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(ByVal sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.[GetType]().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum2.xml"))
        sheet.DataSource = ds

        ' 合計列追加
        sheet.AddColumns(7, 1)
        sheet.ColumnHeader.Cells(0, 7).Text = "合計"

        ' 数式設定
        For i As Integer = 0 To sheet.RowCount - 1
            Dim row As String = Convert.ToString(i + 1)
            sheet.Cells(i, 7).Formula = "SUM(D" & row & ":G" & row & ")"
        Next

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 0
        sheet.Columns(2).Width = 0
        sheet.Columns(3).Width = 60
        sheet.Columns(4).Width = 60
        sheet.Columns(5).Width = 60
        sheet.Columns(6).Width = 60
        sheet.Columns(7).Width = 103
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' 数式を表示する
            FpSpread1.AsWorkbook().ActiveSheet.View.DisplayFormulas = True
        Else
            ' 数式を表示しない
            FpSpread1.AsWorkbook().ActiveSheet.View.DisplayFormulas = False
        End If
    End Sub
End Class
