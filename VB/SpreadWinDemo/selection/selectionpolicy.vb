Public Class selectionpolicy

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ComboBox1.Text = "9.デフォルト"
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds

        '列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 120
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 50
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 65
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 140

        ' 選択スタイルの設定
        sheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        sheet.SelectionBackColor = System.Drawing.Color.Red
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' 選択のクリア
        FpSpread1.Sheets(0).Models.Selection.ClearSelection()

        Dim strCom As String() = ComboBox1.Text.Split("."c)

        Select Case Convert.ToInt32(strCom(0))
            Case 0
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.None
                Exit Select
            Case 1
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells
                Exit Select
            Case 2
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Rows
                Exit Select
            Case 3
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Rows Or FarPoint.Win.Spread.SelectionBlockOptions.Cells
                Exit Select
            Case 4
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns
                Exit Select
            Case 5
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns Or FarPoint.Win.Spread.SelectionBlockOptions.Cells
                Exit Select
            Case 6
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns Or FarPoint.Win.Spread.SelectionBlockOptions.Rows
                Exit Select
            Case 7
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns Or FarPoint.Win.Spread.SelectionBlockOptions.Rows Or FarPoint.Win.Spread.SelectionBlockOptions.Cells
                Exit Select
            Case 8
                FpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Sheet
                Exit Select
        End Select
    End Sub
End Class
