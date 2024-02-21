Public Class touchscroll

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ComboBox1.Text = "スクロール方向：水平、垂直および斜め方向"
        ComboBox2.Text = "バウンドの動作：固定領域（ヘッダ領域）以外"
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data50.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 100
        sheet.Columns(3).Width = 100
        sheet.Columns(4).Width = 50
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 80
        sheet.Columns(7).Width = 100
        sheet.Columns(8).Width = 200
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                FpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.None
                Exit Select
            Case 1
                FpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.HorizontalOnly
                Exit Select
            Case 2
                FpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.VerticalOnly
                Exit Select
            Case 3
                FpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.HorizontalOrVertical
                Exit Select
            Case 4
                FpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.Both
                Exit Select
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedIndex
            Case 0
                FpSpread1.BoundaryFeedbackMode = FarPoint.Win.Spread.BoundaryFeedbackMode.Standard
                Exit Select
            Case 1
                FpSpread1.BoundaryFeedbackMode = FarPoint.Win.Spread.BoundaryFeedbackMode.Split
                Exit Select
        End Select
    End Sub
End Class
