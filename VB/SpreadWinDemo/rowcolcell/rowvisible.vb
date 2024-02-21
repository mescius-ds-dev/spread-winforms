Public Class rowvisible

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

        '「乳製品」行の背景色を設定
        For i As Integer = 0 To sheet.RowCount - 1
            If sheet.Cells(i, 1).Text = "乳製品" Then
                sheet.Rows(i).BackColor = System.Drawing.Color.LavenderBlush
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            '「乳製品」行を非表示
            For i As Integer = 0 To FpSpread1.Sheets(0).RowCount - 1
                If FpSpread1.Sheets(0).Cells(i, 1).Text = "乳製品" Then
                    FpSpread1.Sheets(0).Rows(i).Visible = False
                End If
            Next
            CheckBox1.Text = "全行表示"
        Else
            ' 全行表示
            For i As Integer = 0 To FpSpread1.Sheets(0).RowCount - 1
                FpSpread1.Sheets(0).Rows(i).Visible = True
            Next
            CheckBox1.Text = "「乳製品」行を非表示"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ' 「計画」列を非表示
            For i As Integer = 0 To 11
                FpSpread1.Sheets(0).Columns(i * 2 + 3).Visible = False
            Next
            CheckBox2.Text = "全列表示"
        Else
            ' 全列表示
            For i As Integer = 0 To FpSpread1.Sheets(0).ColumnCount - 1
                FpSpread1.Sheets(0).Columns(i).Visible = True
            Next
            CheckBox2.Text = "「計画」列を非表示"
        End If
    End Sub
End Class
