Public Class operationmode

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ComboBox1.Text = "標準モード（標準的な操作）"
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' 選択範囲のクリア
        FpSpread1.Sheets(0).ClearSelection()

        If ComboBox1.Text = "読み取り専用モード（一切の変更を禁止）" Then
            FpSpread1.Sheets(0).OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly
        ElseIf ComboBox1.Text = "行モード（セル編集可能な行選択モード）" Then
            FpSpread1.Sheets(0).OperationMode = FarPoint.Win.Spread.OperationMode.RowMode
        ElseIf ComboBox1.Text = "単一選択モード（1つの行のみ選択）" Then
            FpSpread1.Sheets(0).OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        ElseIf ComboBox1.Text = "複数選択モード（複数の行の選択）" Then
            FpSpread1.Sheets(0).OperationMode = FarPoint.Win.Spread.OperationMode.MultiSelect
        ElseIf ComboBox1.Text = "拡張選択モード（[Ctrl]+クリック／[Shift]+方向キーで複数行選択）" Then
            FpSpread1.Sheets(0).OperationMode = FarPoint.Win.Spread.OperationMode.ExtendedSelect
        Else
            FpSpread1.Sheets(0).OperationMode = FarPoint.Win.Spread.OperationMode.Normal
        End If
    End Sub
End Class
