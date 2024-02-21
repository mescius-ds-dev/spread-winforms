Public Class enhancedfilter

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".dataexcelfilter.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 120
        sheet.Columns(2).Width = 80
        sheet.Columns(3).Width = 100
        sheet.Columns(4).Width = 80

        ' 背景色の設定
        For i As Integer = 0 To sheet.RowCount - 1
            If i Mod 5 = 0 Then
                sheet.Rows(i).BackColor = System.Drawing.Color.Azure
            ElseIf i Mod 5 = 1 Then
                sheet.Rows(i).BackColor = System.Drawing.Color.Beige
            ElseIf i Mod 5 = 2 Then
                sheet.Rows(i).BackColor = System.Drawing.Color.LavenderBlush
            ElseIf i Mod 5 = 3 Then
                sheet.Rows(i).BackColor = System.Drawing.Color.Silver
            ElseIf i Mod 5 = 4 Then
                sheet.Rows(i).BackColor = System.Drawing.Color.PaleVioletRed

            End If
        Next

        ' フィルタリングの設定
        sheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu
        Dim rowFilter As FarPoint.Win.Spread.IRowFilter = New FarPoint.Win.Spread.HideRowFilter(sheet)

        Dim fd1 As New FarPoint.Win.Spread.FilterColumnDefinition(1, FarPoint.Win.Spread.FilterListBehavior.[Default])
        Dim fd2 As New FarPoint.Win.Spread.FilterColumnDefinition(2, FarPoint.Win.Spread.FilterListBehavior.[Default])
        Dim fd3 As New FarPoint.Win.Spread.FilterColumnDefinition(3, FarPoint.Win.Spread.FilterListBehavior.[Default])
        Dim fd4 As New FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.[Default])
        rowFilter.ColumnDefinitions.Add(fd1)
        rowFilter.ColumnDefinitions.Add(fd2)
        rowFilter.ColumnDefinitions.Add(fd3)
        rowFilter.ColumnDefinitions.Add(fd4)

        sheet.RowFilter = rowFilter
    End Sub
End Class
