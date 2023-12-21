Public Class basiccelltype

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' シート設定
        sheet.RowCount = 11
        sheet.ColumnCount = 4
        sheet.Columns(0).BackColor = System.Drawing.SystemColors.Control
        sheet.Columns(2).BackColor = System.Drawing.SystemColors.Control

        ' 列幅の設定
        sheet.Columns(0).Width = 100
        sheet.Columns(1).Width = 140
        sheet.Columns(2).Width = 180
        sheet.Columns(3).Width = 200

        ' 行の高さの設定
        sheet.Rows.Default.Height = 24
        sheet.Rows(5).Height = 60
        sheet.Rows(10).Height = 60

        ' プロテクトとロック（DefaultStyle）の設定
        sheet.Protect = True
        sheet.DefaultStyle.Locked = False
        sheet.RowHeader.DefaultStyle.Locked = False
        sheet.ColumnHeader.DefaultStyle.Locked = False

        ' 1列目のセルをロックしてユーザの編集を禁止
        sheet.Columns(0).Locked = True

        ' セル型の設定
        sheet.Cells(0, 0).Value = "通貨"
        sheet.Cells(0, 1).Value = 12345

        sheet.Cells(1, 0).Value = "日付時刻"
        sheet.Cells(1, 1).Value = DateTime.Now.ToOADate()

        sheet.Cells(2, 0).Value = "標準"
        sheet.Cells(2, 1).Value = 12345

        sheet.Cells(3, 0).Value = "マスク"
        sheet.Cells(3, 1).Value = "123-45-6789"

        sheet.Cells(4, 0).Value = "数値"
        sheet.Cells(4, 1).Value = 123.45

        sheet.Cells(5, 0).Value = "パーセント"
        sheet.Cells(5, 1).Value = 0.65

        sheet.Cells(6, 0).Value = "正規表現"
        sheet.Cells(6, 1).Value = "123-4567-8901"

        sheet.Cells(7, 0).Value = "テキスト"
        sheet.Cells(7, 1).Value = "テキスト"

        ' 通貨型セルの設定
        Dim currcell As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        sheet.Cells(0, 1).CellType = currcell

        ' 日付時刻型セルの設定
        Dim datecell As New FarPoint.Win.Spread.CellType.DateTimeCellType()
        sheet.Cells(1, 1).CellType = datecell

        ' 標準型セルの設定
        Dim gnrlcell As New FarPoint.Win.Spread.CellType.GeneralCellType()
        sheet.Cells(2, 1).CellType = gnrlcell

        ' マスク型セルの設定
        Dim maskcell As New FarPoint.Win.Spread.CellType.MaskCellType()
        maskcell.Mask = "###-##-####"
        maskcell.MaskChar = Convert.ToChar("_")
        sheet.Cells(3, 1).CellType = maskcell

        ' 数値型セルの設定
        Dim nmbrcell As New FarPoint.Win.Spread.CellType.NumberCellType()
        nmbrcell.DecimalPlaces = 2
        nmbrcell.SpinButton = True
        sheet.Cells(4, 1).CellType = nmbrcell

        ' パーセント型セルの設定
        Dim prctcell As New FarPoint.Win.Spread.CellType.PercentCellType()
        sheet.Cells(5, 1).CellType = prctcell

        ' 正規表現型セルの設定
        Dim regexcell As New FarPoint.Win.Spread.CellType.RegularExpressionCellType()
        regexcell.RegularExpression = "[0-9]{3}-[0-9]{4}-[0-9]{4}"
        sheet.Cells(6, 1).CellType = regexcell

        ' テキスト型セルの設定
        Dim tcell As New FarPoint.Win.Spread.CellType.TextCellType()
        tcell.Multiline = True
        sheet.Cells(7, 1).CellType = tcell

        ' 3列目のセルをロックしてユーザの編集を禁止
        sheet.Columns(2).Locked = True

        ' セル型の設定
        sheet.Cells(0, 2).Text = "コマンドボタン"

        sheet.Cells(1, 2).Text = "チェックボックス"
        sheet.Cells(1, 3).Value = True

        sheet.Cells(2, 2).Text = "コンボボックス"

        sheet.Cells(3, 2).Text = "ハイパーリンク"

        sheet.Cells(4, 2).Text = "イメージ"

        sheet.Cells(5, 2).Text = "リストボックス"

        sheet.Cells(6, 2).Text = "マルチカラムコンボボックス"

        sheet.Cells(7, 2).Text = "マルチオプション"

        sheet.Cells(8, 2).Text = "プログレス"
        sheet.Cells(8, 3).Value = 44

        sheet.Cells(9, 2).Text = "スライダー"
        sheet.Cells(9, 3).Value = 44

        sheet.Cells(10, 2).Text = "リッチテキスト"

        ' コマンドボタン型セルの設定
        Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()
        bttncell.Text = "コマンドボタン"
        sheet.Cells(0, 3).CellType = bttncell

        ' チェックボックス型セルの設定
        Dim ckbxcell As New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        ckbxcell.TextTrue = "チェック"
        ckbxcell.TextFalse = "未チェック"
        sheet.Cells(1, 3).CellType = ckbxcell

        ' コンボボックス型セルの設定
        Dim cmbocell As New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        Dim iList As New ImageList()
        iList.Images.Add(System.Drawing.Image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".music.gif")))
        iList.Images.Add(System.Drawing.Image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".science.gif")))
        iList.Images.Add(System.Drawing.Image.FromStream(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".history.gif")))
        Dim c As New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        cmbocell.Items = New [String]() {"歴史", "音楽", "科学"}
        cmbocell.ImageList = iList
        sheet.Cells(2, 3).CellType = cmbocell

        ' ハイパーリンク型セルの設定
        Dim hlnkcell As New FarPoint.Win.Spread.CellType.HyperLinkCellType()
        hlnkcell.Text = "MESCIUS Webサイトはこちら"
        hlnkcell.Link = "https://developer.mescius.jp/"
        hlnkcell.LinkArea = New LinkArea(15, 3)
        sheet.Cells(3, 3).CellType = hlnkcell

        ' イメージ型セルの設定
        Dim imgct As New FarPoint.Win.Spread.CellType.ImageCellType()
        Dim image1 As System.Drawing.Image = System.Drawing.Image.FromStream(Me.[GetType]().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".science.gif"))
        sheet.Cells(4, 3).CellType = imgct
        sheet.Cells(4, 3).Value = image1

        ' リストボックス型セルの設定
        Dim listcell As New FarPoint.Win.Spread.CellType.ListBoxCellType()
        listcell.Items = New String() {"赤色", "緑色", "青色"}
        sheet.Cells(5, 3).CellType = listcell

        ' マルチカラムコンボボックス型セルの設定
        Dim ds As New DataSet()
        ds.ReadXml(Me.[GetType]().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        Dim mcb As New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType()
        mcb.DataSourceList = ds
        mcb.ColumnEditName = "氏名"
        mcb.DataColumnName = "ID"
        mcb.ListResizeColumns = FarPoint.Win.Spread.CellType.ListResizeColumns.FitWidestItem
        mcb.ListWidth = 400
        mcb.ListAlignment = FarPoint.Win.ListAlignment.Right
        sheet.Cells(6, 3).CellType = mcb

        ' マルチオプション型セルの設定
        Dim multcell As New FarPoint.Win.Spread.CellType.MultiOptionCellType()
        multcell.Items = New [String]() {"赤色", "緑色", "青色"}
        multcell.Orientation = FarPoint.Win.RadioOrientation.Horizontal
        sheet.Cells(7, 3).CellType = multcell

        ' プログレス型セルの設定
        Dim progcell As New FarPoint.Win.Spread.CellType.ProgressCellType()
        sheet.Cells(8, 3).CellType = progcell

        ' スライダー型セルの設定
        Dim slider As New FarPoint.Win.Spread.CellType.SliderCellType()
        slider.TrackColor = Color.Red
        slider.Minimum = 5
        slider.Maximum = 95
        slider.TickSpacing = 3
        slider.KnobColor = Color.FromArgb(57, 0, 0, 255)
        sheet.Cells(9, 3).CellType = slider

        ' リッチテキスト型セルの設定
        Dim rtfType As New FarPoint.Win.Spread.CellType.RichTextCellType()
        rtfType.Multiline = True
        sheet.Cells(10, 3).CellType = rtfType
        ' リッチテキスト文字列の作成
        Dim rtfText As [String] = Nothing
        Using temp As New RichTextBox()
            temp.Text = "ABC" & vbCr & vbLf & "DEF" & vbCr & vbLf & "GHI"
            temp.SelectionStart = 0
            temp.SelectionLength = 3
            temp.SelectionColor = Color.Red
            temp.SelectionFont = New Font("MS UI Gothic", 9)
            temp.SelectionStart = 4
            temp.SelectionLength = 3
            temp.SelectionColor = Color.Blue
            temp.SelectionFont = New Font("MS UI Gothic", 12)
            temp.SelectionStart = 8
            temp.SelectionLength = 3
            temp.SelectionColor = Color.Green
            temp.SelectionFont = New Font("MS UI Gothic", 15)
            temp.SelectionStart = 0
            temp.SelectionLength = 12
            temp.SelectionAlignment = HorizontalAlignment.Center
            rtfText = temp.Rtf
        End Using
        sheet.Cells(10, 3).Value = rtfText
    End Sub

    Private Sub FpSpread1_EditChange(sender As Object, e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles FpSpread1.EditChange
        ' スライダ型セルのデータをプログレス型セルに反映
        If e.Row = 9 And e.Column = 3 Then
            FpSpread1.ActiveSheet.Cells(8, 3).Value = FpSpread1.ActiveSheet.Cells(9, 3).Value
        End If
    End Sub

    Private Sub FpSpread1_EditModeOn(sender As Object, e As System.EventArgs) Handles FpSpread1.EditModeOn
        ' アクティブセルのセル型を判断
        Dim row As Integer = FpSpread1.ActiveSheet.ActiveRowIndex
        Dim col As Integer = FpSpread1.ActiveSheet.ActiveColumnIndex
        If TypeOf FpSpread1.ActiveSheet.GetCellType(row, col) Is FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType Then
            ' ドロップダウンリストのオブジェクトの取得
            Dim cmbSpread As FarPoint.Win.Spread.FpSpread = DirectCast(DirectCast(FpSpread1.EditingControl, FarPoint.Win.Spread.CellType.GeneralEditor).SubEditor, FarPoint.Win.Spread.FpSpread)

            ' 列幅の設定
            cmbSpread.ActiveSheet.Columns(4).Width = 50
            cmbSpread.ActiveSheet.Columns(5).Width = 50
        End If
    End Sub
End Class
