Public Class printsetting

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データの作成
        Dim dt As New DataTable()
        Dim cols As Integer = 20
        Dim rows As Integer = 65
        For i As Integer = 0 To cols - 1
            dt.Columns.Add(String.Format("列{0}", i + 1), GetType(String))
        Next
        For i As Integer = 0 To rows - 1
            Dim dr As DataRow = dt.NewRow()
            For j As Integer = 0 To cols - 1
                dr(j) = String.Format("R{0}C{1}", i, j)
            Next
            dt.Rows.Add(dr)
        Next
        dt.AcceptChanges()

        ' データ連結
        sheet.DataAutoCellTypes = False
        sheet.DataAutoSizeColumns = False
        sheet.DataSource = dt

        ' セルノートの設定
        sheet.Cells(1, 1).Note = "セルノートの表示"
        sheet.Cells(1, 1).NoteIndicatorSize = New Size(5, 5)
    End Sub

    Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
        ' マウスカーソルの一時変更
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        ' ページ設定ダイアログの表示
        Dim psDialog As New PrintSettingForm(FpSpread1)
        psDialog.ShowDialog()

        ' マウスカーソルの一時変更の解除
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
End Class
