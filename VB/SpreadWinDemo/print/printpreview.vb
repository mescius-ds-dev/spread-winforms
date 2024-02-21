Public Class printpreview

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".data50.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 110
        sheet.Columns(2).Width = 110
        sheet.Columns(3).Width = 100
        sheet.Columns(4).Width = 50
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 50
        sheet.Columns(7).Width = 100
        sheet.Columns(8).Width = 240
    End Sub

    Private Sub FpSpread1_PrintPreviewShowing(sender As Object, e As FarPoint.Win.Spread.PrintPreviewShowingEventArgs) Handles FpSpread1.PrintPreviewShowing
        ' 印刷プレビューダイアログ上のToolStripコントロールの取得
        Dim ts As ToolStrip = DirectCast(e.PreviewDialog.Controls(1), ToolStrip)
        Console.WriteLine("{0}", Me.ActiveControl.GetType().Name)
        ' クリックされたボタンコントロールの判別
        If button2.ContainsFocus Then
            ' ======================================
            ' 印刷プレビューダイアログのカスタマイズ
            ' ======================================

            ' ズームの自動調節
            Dim tssb As ToolStripSplitButton = DirectCast(ts.Items(1), ToolStripSplitButton)
            tssb.DropDownItems(0).PerformClick()

            ' 表示ページ数指定ボタンの非表示
            ts.Items(2).Visible = False
            ts.Items(3).Visible = False
            ts.Items(4).Visible = False
            ts.Items(5).Visible = False
            ts.Items(6).Visible = False
            ts.Items(7).Visible = False
            ts.Items(8).Visible = False
        Else
            ' ================================================
            ' 印刷プレビューダイアログのデフォルト設定への復元
            ' ================================================

            ' 表示ページ数指定ボタンの表示
            ts.Items(2).Visible = True
            ts.Items(3).Visible = True
            ts.Items(4).Visible = True
            ts.Items(5).Visible = True
            ts.Items(6).Visible = True
            ts.Items(7).Visible = True
            ts.Items(8).Visible = True
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
        ' 印刷プレビュー（デフォルト）の表示
        FpSpread1.Sheets(0).PrintInfo.Preview = True
        FpSpread1.PrintSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub button2_Click(sender As Object, e As System.EventArgs) Handles button2.Click
        ' 印刷プレビュー（カスタマイズ）の表示
        FpSpread1.Sheets(0).PrintInfo.Preview = True
        FpSpread1.PrintSheet(FpSpread1.Sheets(0))
    End Sub
End Class
