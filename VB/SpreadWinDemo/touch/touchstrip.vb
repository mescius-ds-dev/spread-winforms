Public Class touchstrip

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        RadioButton2.Checked = True
    End Sub

    Private touchStripwithoutcut As FarPoint.Win.Spread.CellTouchStrip
    Private touchStripwithautofill As FarPoint.Win.Spread.CellTouchStrip
    Private touchStripwithdropdownmenu As FarPoint.Win.Spread.CellTouchStrip

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data30.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 70
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 80
        sheet.Columns(3).Width = 140
        sheet.Columns(4).Width = 140
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 80
        sheet.Columns(7).Width = 50
        sheet.Columns(8).Width = 60
        sheet.Columns(9).Width = 70
        sheet.Columns(10).Width = 300

        ' 切り取りを表示しないタッチツールバー
        touchStripwithoutcut = New FarPoint.Win.Spread.CellTouchStrip(Me.FpSpread1)
        touchStripwithoutcut.Items("Cut").Visible = False

        ' ドロップダウンメニューを追加したタッチツールバー
        touchStripwithdropdownmenu = New FarPoint.Win.Spread.CellTouchStrip(Me.FpSpread1)
        touchStripwithdropdownmenu.Items("Cut").Visible = False

        Dim separator1 As New ToolStripSeparator()

        Dim s1 As System.IO.Stream = Me.[GetType]().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".AutoFill.png")
        Dim autoFill As New FarPoint.Win.Spread.TouchStripButton("オートフィル", System.Drawing.Image.FromStream(s1))
        AddHandler autoFill.Click, AddressOf autoFill_Click

        Dim separator2 As New ToolStripSeparator()

        Dim s2 As System.IO.Stream = Me.[GetType]().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".TouchMenuItemDownArrow.png")
        Dim dropDownMenu As New ToolStripDropDownButton(System.Drawing.Image.FromStream(s2))
        dropDownMenu.ShowDropDownArrow = False
        dropDownMenu.ImageScaling = ToolStripItemImageScaling.None
        Dim menu As ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip()
        Dim newcontitem1 As New ToolStripMenuItem()
        newcontitem1.Text = "コピー"
        AddHandler newcontitem1.Click, AddressOf newcontitem1_Click
        newcontitem1.AutoSize = False
        newcontitem1.Height = 30
        newcontitem1.Width = 100
        newcontitem1.TextAlign = ContentAlignment.MiddleLeft
        menu.Items.Add(newcontitem1)
        Dim newcontitem2 As New ToolStripMenuItem()
        newcontitem2.Text = "貼り付け"
        AddHandler newcontitem2.Click, AddressOf newcontitem2_Click
        newcontitem2.AutoSize = False
        newcontitem2.Height = 30
        newcontitem2.Width = 100
        newcontitem2.TextAlign = ContentAlignment.MiddleLeft
        menu.Items.Add(newcontitem2)
        Dim newcontitem3 As New ToolStripMenuItem()
        newcontitem3.Text = "クリア"
        AddHandler newcontitem3.Click, AddressOf newcontitem3_Click
        newcontitem3.AutoSize = False
        newcontitem3.Height = 30
        newcontitem3.Width = 100
        newcontitem3.TextAlign = ContentAlignment.MiddleLeft
        menu.Items.Add(newcontitem3)
        dropDownMenu.DropDown = menu

        touchStripwithdropdownmenu.Items.AddRange(New ToolStripItem() {separator1, autoFill, separator2, dropDownMenu})

        ' オートフィルを有効化 
        FpSpread1.AllowDragFill = True
    End Sub

    Private Sub FpSpread1_TouchStripOpening(sender As Object, e As FarPoint.Win.Spread.TouchStripOpeningEventArgs) Handles FpSpread1.TouchStripOpening
        If RadioButton1.Checked Then
            ' デフォルトのタッチツールバーを表示しない
            e.Cancel = True
        ElseIf RadioButton3.Checked Then
            ' デフォルトのタッチツールバーを表示しない
            e.Cancel = True

            ' カスタマイズしたタッチツールバーを表示
            touchStripwithoutcut.Show(New Point(e.X - 20, e.Y - 35 - touchStripwithoutcut.Height))
        ElseIf RadioButton4.Checked Then
            ' デフォルトのタッチツールバーを表示しない
            e.Cancel = True

            ' カスタマイズしたタッチツールバーを表示
            touchStripwithdropdownmenu.Show(New Point(e.X - 20, e.Y - 35 - touchStripwithdropdownmenu.Height))
        End If
    End Sub

    Private Sub autoFill_Click(sender As Object, e As EventArgs)
        Dim activeView As FarPoint.Win.Spread.SpreadView = fpSpread1.GetRootWorkbook().GetActiveWorkbook()
        If activeView IsNot Nothing Then
            activeView.ShowAutoFillIndicator()
        End If
    End Sub

    Private Sub newcontitem1_Click(sender As Object, e As EventArgs)
        ' コピー
        fpSpread1.ActiveSheet.ClipboardCopy()
    End Sub

    Private Sub newcontitem2_Click(sender As Object, e As EventArgs)
        ' 貼り付け
        fpSpread1.ActiveSheet.ClipboardPaste(FarPoint.Win.Spread.ClipboardPasteOptions.Values)
    End Sub

    Private Sub newcontitem3_Click(sender As Object, e As EventArgs)
        ' クリア
        Dim r1 As Integer = fpSpread1.ActiveSheet.Models.Selection.AnchorRow
        Dim c1 As Integer = fpSpread1.ActiveSheet.Models.Selection.AnchorColumn
        Dim r2 As Integer = fpSpread1.ActiveSheet.Models.Selection.LeadRow - r1 + 1
        Dim c2 As Integer = fpSpread1.ActiveSheet.Models.Selection.LeadColumn - c1 + 1
        Dim dataModel As FarPoint.Win.Spread.Model.DefaultSheetDataModel = DirectCast(fpSpread1.ActiveSheet.Models.Data, FarPoint.Win.Spread.Model.DefaultSheetDataModel)
        dataModel.ClearData(r1, c1, r2, c2)
    End Sub
End Class
