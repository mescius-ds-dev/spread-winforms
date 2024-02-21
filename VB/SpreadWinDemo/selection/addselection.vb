Public Class addselection

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ' 選択リスト設定
        InitList()
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
    End Sub

    Private Sub InitList()
        For i As Integer = 0 To fpSpread1.Sheets(0).RowCount - 1
            comboBox1.Items.Add(Convert.ToString(i))
        Next

        For i As Integer = 1 To fpSpread1.Sheets(0).RowCount
            comboBox3.Items.Add(Convert.ToString(i))
        Next

        For i As Integer = 0 To fpSpread1.Sheets(0).ColumnCount - 1
            comboBox2.Items.Add(Convert.ToString(i))
        Next
        For i As Integer = 1 To fpSpread1.Sheets(0).ColumnCount
            comboBox4.Items.Add(Convert.ToString(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim rowidx As Integer = 0
        If Not Integer.TryParse(ComboBox1.Text, rowidx) Then
            MessageBox.Show(ComboBox1.Text + "を選択してください。")
            Return
        End If

        Dim colidx As Integer = 0
        If Not Integer.TryParse(ComboBox2.Text, colidx) Then
            MessageBox.Show(ComboBox2.Text + "を選択してください。")
            Return
        End If

        Dim rowcnt As Integer = 0
        If Not Integer.TryParse(ComboBox3.Text, rowcnt) Then
            MessageBox.Show(ComboBox3.Text + "を選択してください。")
            Return
        End If

        Dim colcnt As Integer = 0
        If Not Integer.TryParse(ComboBox4.Text, colcnt) Then
            MessageBox.Show(ComboBox4.Text + "を選択してください。")
            Return
        End If

        ' 選択範囲作成
        FpSpread1.Sheets(0).SetActiveCell(rowidx, colidx)
        FpSpread1.Sheets(0).Models.Selection.SetSelection(rowidx, colidx, rowcnt, colcnt)
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' 全選択
        FpSpread1.Sheets(0).Models.Selection.SetSelection(-1, -1, -1, -1)
    End Sub
End Class
