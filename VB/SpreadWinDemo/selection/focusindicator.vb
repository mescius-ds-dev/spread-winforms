Public Class focusindicator

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
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
        If ComboBox1.Text = "選択範囲の外側にフォーカス枠を表示" Then
            FpSpread1.PaintSelectionBorder = True
        ElseIf ComboBox1.Text = "アクティブセルのみにフォーカス枠を表示" Then
            FpSpread1.PaintSelectionBorder = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "緑枠（デフォルト）" Then
            FpSpread1.ResetFocusRenderer()
        ElseIf ComboBox2.Text = "太さの変更" Then
            FpSpread1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        ElseIf ComboBox2.Text = "色の変更" Then
            FpSpread1.FocusRenderer = New FarPoint.Win.Spread.SolidFocusIndicatorRenderer(Color.Black, 2)
        ElseIf ComboBox2.Text = "アニメーション" Then
            FpSpread1.FocusRenderer = New FarPoint.Win.Spread.MarqueeFocusIndicatorRenderer(Color.FromArgb(33, 115, 70), 2)
        ElseIf ComboBox2.Text = "Ver 3.0J以前のスタイル" Then
            FpSpread1.FocusRenderer = New FarPoint.Win.Spread.DefaultFocusIndicatorRenderer()
        ElseIf ComboBox2.Text = "非表示" Then
            FpSpread1.FocusRenderer = New FarPoint.Win.Spread.DefaultFocusIndicatorRenderer(0)
        End If
    End Sub
End Class
