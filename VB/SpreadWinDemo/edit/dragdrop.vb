Public Class dragdrop

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ' SPREADの設定
        InitSpread(FpSpread1, FpSpread2)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ' TextBoxの設定：ドロップを許可
        TextBox1.AllowDrop = True
    End Sub

    Private Sub InitSpread(spread1 As FarPoint.Win.Spread.FpSpread, spread2 As FarPoint.Win.Spread.FpSpread)
        ' ドロップを許可
        spread1.AllowDrop = True
        spread2.AllowDrop = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".data.xml"))
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

    Private Sub FpSpread1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles FpSpread1.MouseDown
        ' マウスの右ボタンが押下された場合
        If e.Button = MouseButtons.Right Then
            ' SPREADの取得
            Dim spread As FarPoint.Win.Spread.FpSpread = DirectCast(sender, FarPoint.Win.Spread.FpSpread)

            ' 選択範囲の取得
            Dim range As FarPoint.Win.Spread.Model.CellRange = spread.ActiveSheet.GetSelection(0)
            If range Is Nothing Then
                range = New FarPoint.Win.Spread.Model.CellRange(spread.ActiveSheet.ActiveRowIndex, spread.ActiveSheet.ActiveColumnIndex, 1, 1)
            End If
            If range.Column < 0 Then
                range = New FarPoint.Win.Spread.Model.CellRange(range.Row, 0, range.RowCount, spread.ActiveSheet.ColumnCount)
            End If
            If range.Row < 0 Then
                range = New FarPoint.Win.Spread.Model.CellRange(0, range.Column, spread.ActiveSheet.RowCount, range.ColumnCount)
            End If

            ' 選択範囲のデータの取得
            Dim data As String = spread.ActiveSheet.GetClip(range.Row, range.Column, range.RowCount, range.ColumnCount)

            ' ドラッグ＆ドロップの開始
            spread.DoDragDrop(Data, DragDropEffects.Move)
        End If
    End Sub

    Private Sub FpSpread1_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FpSpread1.DragOver
        ' ドラッグ＆ドロップ操作の指定
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub FpSpread2_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FpSpread2.DragEnter
        ' ドラッグ＆ドロップ操作の指定
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub FpSpread2_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FpSpread2.DragOver
        ' SPREADの取得
        Dim spread As FarPoint.Win.Spread.FpSpread = DirectCast(sender, FarPoint.Win.Spread.FpSpread)

        ' マウスポインタ位置の取得
        Dim pos As Point = spread.PointToClient(New Point(e.X, e.Y))
        Dim range As FarPoint.Win.Spread.Model.CellRange = spread.GetCellFromPixel(0, 0, pos.X, pos.Y)

        ' マウスポインタが通常セル上にある場合
        If range.ColumnCount > -1 AndAlso range.RowCount > -1 Then
            ' ドロップ対象範囲の明示
            spread.ActiveSheet.ClearSelection()
            Dim data As String = CStr(e.Data.GetData("Text"))
            Dim lines As String() = data.Split(New String() {vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
            Dim cells As String() = lines(0).Split(New String() {vbTab}, StringSplitOptions.RemoveEmptyEntries)
            spread.ActiveSheet.AddSelection(range.Row, range.Column, lines.Length, cells.Length)
        End If
    End Sub

    Private Sub FpSpread2_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FpSpread2.DragDrop
        ' SPREADの取得
        Dim spread As FarPoint.Win.Spread.FpSpread = DirectCast(sender, FarPoint.Win.Spread.FpSpread)

        ' ドロップ対象範囲の取得
        Dim range As FarPoint.Win.Spread.Model.CellRange = spread.ActiveSheet.GetSelection(0)

        ' ドロップ操作の実行
        spread.ActiveSheet.SetClip(range.Row, range.Column, range.RowCount, range.ColumnCount, CStr(e.Data.GetData("Text")))
    End Sub

    Private Sub TextBox1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragEnter
        ' ドラッグ＆ドロップ操作の指定
        If e.Data.GetDataPresent(DataFormats.Text) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    Private Sub TextBox1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop
        ' TextBoxの取得
        Dim tb As TextBox = DirectCast(sender, TextBox)

        ' ドロップ操作の実行
        tb.Text = CStr(e.Data.GetData("Text"))
    End Sub
End Class
