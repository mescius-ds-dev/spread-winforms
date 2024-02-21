Public Class PrintSettingForm

    Private spread As FarPoint.Win.Spread.FpSpread

    Public Sub New(ss As FarPoint.Win.Spread.FpSpread)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ' SPREADの取得
        spread = ss

        ' コントロールの初期化
        InitializeControls()
    End Sub

    Private Sub InitializeControls()
        ' デフォルトプリンタの用紙サイズの取得
        Dim dtPaperSize As New DataTable("PaperSize")
        dtPaperSize.Columns.Add("RawKind", GetType(Integer))
        dtPaperSize.Columns.Add("Name", GetType(String))
        dtPaperSize.Columns.Add("PaperSize", GetType(System.Drawing.Printing.PaperSize))
        dtPaperSize.PrimaryKey = New DataColumn() {dtPaperSize.Columns("RawKind")}
        Dim ps As New System.Drawing.Printing.PrinterSettings()
        For Each p As System.Drawing.Printing.PaperSize In ps.PaperSizes
            dtPaperSize.Rows.Add(New Object() {p.RawKind, p.PaperName, p})
        Next
        cmbPaperSize.DataSource = dtPaperSize
        cmbPaperSize.DisplayMember = "Name"
        cmbPaperSize.ValueMember = "PaperSize"
        cmbPaperSize.SelectedIndex = 0
        Try
            cmbPaperSize.SelectedValue = DirectCast(dtPaperSize.Rows.Find(System.Drawing.Printing.PaperKind.A4)("PaperSize"), System.Drawing.Printing.PaperSize)
        Catch ex As Exception
            Console.WriteLine(ex.ToString())
        End Try

        ' ヘッダ／フッタ用文字列の作成
        Dim dtHeader As New DataTable("HeaderFooter")
        dtHeader.Columns.Add("Name", GetType(String))
        dtHeader.Columns.Add("Command", GetType(String))
        dtHeader.Rows.Add("未設定", "")
        dtHeader.Rows.Add("ページ番号", "/c(/p///pc)")
        dtHeader.Rows.Add("日付", "/r/dl")
        dtHeader.Rows.Add("カラー文字", "/l/cl""0""カラー/cl""1""文字")
        dtHeader.Rows.Add("画像", "/c/g""0""")
        dtHeader.AcceptChanges()
        cmbHeader.DataSource = dtHeader
        cmbHeader.DisplayMember = "Name"
        cmbHeader.ValueMember = "Command"
        cmbFooter.DataSource = dtHeader.Copy()
        cmbFooter.DisplayMember = "Name"
        cmbFooter.ValueMember = "Command"

        ' セルノート設定用コンボボックスの設定
        cmbCellNote.Items.AddRange(New String() {"(なし)", "シートの末尾", "画面表示イメージ"})
        cmbCellNote.SelectedIndex = 0

        ' PrintInfoの初期化
        Dim pInfo As New FarPoint.Win.Spread.PrintInfo()
        pInfo.Colors = New Color() {Color.Blue, Color.Red}
        Dim image As Image = System.Drawing.Image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".science.gif"))
        pInfo.Images = New Image() {image}
        spread.Sheets(0).PrintInfo = pInfo
    End Sub

    Private Sub SetPrintSettings()
        Dim pInfo As FarPoint.Win.Spread.PrintInfo = spread.Sheets(0).PrintInfo

        ' ページ：印刷の向き
        If rdoAuto.Checked Then
            pInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Auto
        ElseIf (rdoDirectionV.Checked) Then
            pInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Portrait
        ElseIf (rdoDirectionH.Checked) Then
            pInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Landscape
        End If
        ' ページ：拡大縮小印刷
        If (rdoZoom.Checked) Then
            pInfo.ZoomFactor = numZoom.Value / 100
            pInfo.UseSmartPrint = False
        ElseIf rdoByPage.Checked Then
            pInfo.ZoomFactor = 1.0F
            pInfo.SmartPrintPagesTall = numByPageV.Value
            pInfo.SmartPrintPagesWide = numByPageH.Value
            pInfo.UseSmartPrint = True
        End If

        ' ページ：用紙サイズ
        pInfo.PaperSize = DirectCast(cmbPaperSize.SelectedValue, System.Drawing.Printing.PaperSize)

        ' ページ：先頭ページ番号
        pInfo.FirstPageNumber = numFirstPage.Value

        ' 余白：余白
        pInfo.Margin.Left = numMerginLeft.Value
        pInfo.Margin.Right = numMerginRight.Value
        pInfo.Margin.Top = numMerginTop.Value
        pInfo.Margin.Bottom = numMerginBottom.Value

        ' 余白：高さ
        pInfo.HeaderHeight = numHeaderHeight.Value
        pInfo.FooterHeight = numFooterHeight.Value

        ' 余白：ページ中央
        If ckbCenterH.Checked Then
            If ckbCenterV.Checked Then
                pInfo.Centering = FarPoint.Win.Spread.Centering.Both
            Else
                pInfo.Centering = FarPoint.Win.Spread.Centering.Horizontal
            End If
        Else
            If ckbCenterV.Checked Then
                pInfo.Centering = FarPoint.Win.Spread.Centering.Vertical
            Else
                pInfo.Centering = FarPoint.Win.Spread.Centering.None
            End If
        End If

        ' ヘッダ／フッタ：ヘッダ
        pInfo.Header = txtHeader.Text

        ' ヘッダ／フッタ：フッタ
        pInfo.Footer = txtFooter.Text

        ' シート：印刷範囲
        If numRangeTopRow.Value > -1 OrElse numRangeBottomRow.Value > -1 OrElse numRangeLeftCol.Value > -1 OrElse numRangeRightCol.Value > -1 Then
            pInfo.PrintType = FarPoint.Win.Spread.PrintType.CellRange
            pInfo.RowStart = numRangeTopRow.Value
            pInfo.RowEnd = numRangeBottomRow.Value
            pInfo.ColStart = numRangeLeftCol.Value
            pInfo.ColEnd = numRangeRightCol.Value
        Else
            pInfo.PrintType = FarPoint.Win.Spread.PrintType.All
        End If

        ' シート：印刷タイトル
        pInfo.RepeatRowStart = numRepeatTopRow.Value
        pInfo.RepeatRowEnd = numRepeatBottomRow.Value
        pInfo.RepeatColStart = numRepeatLeftCol.Value
        pInfo.RepeatColEnd = numRepeatRightCol.Value

        ' シート：印刷.枠線
        pInfo.ShowBorder = ckbBorder.Checked

        ' シート：印刷.グリッド線
        pInfo.ShowGrid = ckbGrid.Checked

        ' シート：印刷.行ヘッダ
        If (ckbRowHeader.Checked) Then
            pInfo.ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Show
        Else
            pInfo.ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Hide
        End If

        ' シート：印刷.列ヘッダ
        If (ckbColHeader.Checked) Then
            pInfo.ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Show
        Else
            pInfo.ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Hide
        End If

        ' シート：印刷.ページの方向
        If (rdoPageOrderAuto.Checked) Then
            pInfo.PageOrder = FarPoint.Win.Spread.PrintPageOrder.Auto
        ElseIf (rdoPageOrderLeftRight.Checked) Then
            pInfo.PageOrder = FarPoint.Win.Spread.PrintPageOrder.OverThenDown
        ElseIf (rdoPageOrderTopBottom.Checked) Then
            pInfo.PageOrder = FarPoint.Win.Spread.PrintPageOrder.DownThenOver
        End If

        ' シート：印刷.セルノート
        If cmbCellNote.SelectedIndex = 0 Then
            ' (なし)
            pInfo.PrintNotes = FarPoint.Win.Spread.PrintNotes.None
        ElseIf cmbCellNote.SelectedIndex = 1 Then
            ' シートの末尾
            pInfo.PrintNotes = FarPoint.Win.Spread.PrintNotes.AtEnd
        ElseIf cmbCellNote.SelectedIndex = 2 Then
            ' 画面表示イメージ：NoteStyleがStickyNoteの場合にのみ有効
            spread.Sheets(0).Cells(1, 1).NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote
            pInfo.PrintNotes = FarPoint.Win.Spread.PrintNotes.AsDisplayed
        End If
    End Sub

    Private Sub cmbHeader_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbHeader.SelectedIndexChanged
        ' ヘッダ文字列の設定
        If DirectCast(sender, ComboBox).SelectedValue.GetType() Is GetType(String) Then
            txtHeader.Text = CStr(DirectCast(sender, ComboBox).SelectedValue)
        End If

        ' ヘッダ高さの設定
        If Not String.IsNullOrEmpty(txtHeader.Text) Then
            numHeaderHeight.Value = 30
        Else
            numHeaderHeight.Value = 0
        End If
    End Sub

    Private Sub cmbFooter_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cmbFooter.SelectedIndexChanged
        ' フッタ文字列の設定
        If DirectCast(sender, ComboBox).SelectedValue.GetType() Is GetType(String) Then
            txtFooter.Text = CStr(DirectCast(sender, ComboBox).SelectedValue)
        End If

        ' ヘッダ高さの設定
        If Not String.IsNullOrEmpty(txtFooter.Text) Then
            numFooterHeight.Value = 30
        Else
            numFooterHeight.Value = 0
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As System.EventArgs) Handles btnPrint.Click
        ' 印刷の設定
        Me.SetPrintSettings()

        ' 印刷の実行
        spread.Sheets(0).PrintInfo.Preview = False
        spread.PrintSheet(0, False)

        ' シートのセルノート設定の初期化
        spread.Sheets(0).Cells(1, 1).NoteStyle = FarPoint.Win.Spread.NoteStyle.PopupNote

        ' ダイアログの終了
        Me.Close()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As System.EventArgs) Handles btnPreview.Click
        ' 印刷の設定
        Me.SetPrintSettings()

        ' 印刷プレビュー画面の表示
        spread.Sheets(0).PrintInfo.Preview = True
        spread.PrintSheet(spread.Sheets(0))

        ' シートのセルノート設定の初期化
        spread.Sheets(0).Cells(1, 1).NoteStyle = FarPoint.Win.Spread.NoteStyle.PopupNote
    End Sub
End Class