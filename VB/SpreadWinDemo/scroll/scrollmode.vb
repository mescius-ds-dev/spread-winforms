Public Class scrollmode

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ComboBox1.Text = "行方向スクロール単位：ピクセル"
        ComboBox2.Text = "列方向スクロール単位：ピクセル"
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' スクロールの設定
        spread.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both
        spread.VerticalScrollBarMode = FarPoint.Win.VerticalScrollMode.Pixel
        spread.HorizontalScrollBarMode = FarPoint.Win.HorizontalScrollMode.Pixel
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 行／列数の設定
        sheet.RowCount = 10
        sheet.ColumnCount = 4

        ' 行高／列幅の設定
        sheet.Rows.Default.Height = 80
        sheet.Columns(0).Width = 100
        sheet.Columns(1).Width = 240
        sheet.Columns(2).Width = 1000
        sheet.Columns(3).Width = 120

        ' テストデータの設定
        sheet.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        sheet.ColumnHeader.Cells(0, 0).Value = "得意先コード"
        sheet.ColumnHeader.Cells(0, 1).Value = "得意先名"
        sheet.ColumnHeader.Cells(0, 2).Value = "備考"
        sheet.ColumnHeader.Cells(0, 3).Value = "エリア"

        sheet.Cells(0, 0).Value = "A002"
        sheet.Cells(0, 1).Value = "相原産業　株式会社"
        sheet.Cells(0, 2).Value = "【XXXY年04月30日】弊社窓口：MJさまが新部署に異動されました。後任人事は追って連絡くださるとのことです。" & System.Environment.NewLine & "【XXXY年06月03日】新事務所開設に向けて準備されています。関東近郊で300人程度収容可能な物件を検討中とのことです。"
        sheet.Cells(0, 3).Value = "関東"

        sheet.Cells(1, 0).Value = "F002"
        sheet.Cells(1, 1).Value = "有限会社　福山商店"
        sheet.Cells(1, 3).Value = "山陽"

        sheet.Cells(2, 0).Value = "G001"
        sheet.Cells(2, 1).Value = "御殿場リビング"
        sheet.Cells(2, 3).Value = "中部"

        sheet.Cells(3, 0).Value = "M002"
        sheet.Cells(3, 1).Value = "有限会社　ミナミ"
        sheet.Cells(3, 2).Value = "【XXXY年05月11日】弊社発送の不備で到着予定に遅延が発生しました。次回発送時、交通状況の事前確認を徹底してください。"
        sheet.Cells(3, 3).Value = "関西"

        sheet.Cells(4, 0).Value = "T999"
        sheet.Cells(4, 1).Value = "店頭販売"
        sheet.Cells(4, 2).Value = "【XXXY年03月04日】担当：SJさまが定期異動の予定。新担当は現時点で未定だそうです。"

        sheet.Cells(5, 0).Value = "F001"
        sheet.Cells(5, 1).Value = "有限会社　ふじた"
        sheet.Cells(5, 3).Value = "東北"

        sheet.Cells(6, 0).Value = "K002"
        sheet.Cells(6, 1).Value = "有限会社　北山ホーム"
        sheet.Cells(6, 3).Value = "関東"""

        sheet.Cells(7, 0).Value = "P010"
        sheet.Cells(7, 1).Value = "株式会社　グレープ商事"
        sheet.Cells(7, 3).Value = "北海道"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "行方向スクロール単位：行" Then
            FpSpread1.VerticalScrollBarMode = FarPoint.Win.VerticalScrollMode.Row
        ElseIf ComboBox1.Text = "行方向スクロール単位：行（スクロール中はピクセル）" Then
            FpSpread1.VerticalScrollBarMode = FarPoint.Win.VerticalScrollMode.PixelAndRow
        ElseIf ComboBox1.Text = "行方向スクロール単位：ピクセル" Then
            FpSpread1.VerticalScrollBarMode = FarPoint.Win.VerticalScrollMode.Pixel
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "列方向スクロール単位：列" Then
            FpSpread1.HorizontalScrollBarMode = FarPoint.Win.HorizontalScrollMode.Column
        ElseIf ComboBox2.Text = "列方向スクロール単位：列（スクロール中はピクセル）" Then
            FpSpread1.HorizontalScrollBarMode = FarPoint.Win.HorizontalScrollMode.PixelAndColumn
        ElseIf ComboBox2.Text = "列方向スクロール単位：ピクセル" Then
            FpSpread1.HorizontalScrollBarMode = FarPoint.Win.HorizontalScrollMode.Pixel
        End If
    End Sub
End Class
