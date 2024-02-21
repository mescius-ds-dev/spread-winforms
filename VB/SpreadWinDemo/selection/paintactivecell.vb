Public Class paintactivecell

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        CheckBox1.Checked = True
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' アクティブセルの背景色を選択色と同じ色で塗りつぶす
        spread.PaintActiveCellInSelection = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 36
        sheet.Columns(1).Width = 88
        sheet.Columns(2).Width = 91
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 181

        ' 選択色の設定
        sheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        sheet.SelectionBackColor = Color.FromArgb(51, 153, 255)
        Dim ch As New FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer()
        ch.SelectedBackgroundColor = Color.FromArgb(140, 198, 255)
        ch.SelectedGridLineColor = Color.FromArgb(230, 230, 230)
        ch.ActiveBackgroundColor = Color.FromArgb(186, 234, 253)
        ch.BackColor = System.Drawing.SystemColors.Control
        ch.ForeColor = System.Drawing.SystemColors.ControlText
        ch.NormalGridLineColor = Color.FromArgb(230, 230, 230)
        ch.SelectedActiveBackgroundColor = Color.FromArgb(186, 234, 253)
        FpSpread1.ActiveSheet.ColumnHeader.DefaultStyle.Renderer = ch
        Dim rh As New FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer()
        rh.SelectedBackgroundColor = Color.FromArgb(140, 198, 255)
        rh.SelectedGridLineColor = Color.FromArgb(230, 230, 230)
        rh.ActiveBackgroundColor = Color.FromArgb(186, 234, 253)
        rh.BackColor = System.Drawing.SystemColors.Control
        rh.ForeColor = System.Drawing.SystemColors.ControlText
        rh.NormalGridLineColor = Color.FromArgb(230, 230, 230)
        rh.SelectedActiveBackgroundColor = Color.FromArgb(186, 234, 253)
        FpSpread1.ActiveSheet.RowHeader.DefaultStyle.Renderer = rh
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            FpSpread1.PaintActiveCellInSelection = True
        Else
            FpSpread1.PaintActiveCellInSelection = False
        End If
    End Sub
End Class
