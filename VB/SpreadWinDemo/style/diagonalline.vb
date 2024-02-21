Public Class diagonalline

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum4.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 140
        sheet.Columns(3).Width = 40
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80
        sheet.Columns(6).Width = 80
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 80
        sheet.Columns(9).Width = 80

        ' ３列目を非表示
        sheet.Columns(3).Visible = False

        ' 斜め罫線の設定
        Dim diagonalborder As New FarPoint.Win.ComplexBorderSide(Color.Black, 1, System.Drawing.Drawing2D.DashStyle.Solid)
        For i As Integer = 0 To sheet.RowCount - 1
            For j As Integer = 0 To sheet.ColumnCount - 1
                If sheet.Cells(i, j).Value Is Nothing Then
                    sheet.Cells(i, j).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, Nothing, Nothing, diagonalborder, False, True)
                End If
            Next
        Next
    End Sub
End Class
