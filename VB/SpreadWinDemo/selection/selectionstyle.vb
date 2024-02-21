Public Class selectionstyle

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

        ' 選択スタイルの初期設定
        sheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        sheet.SelectionBackColor = Color.Green
        sheet.SelectionFont = New System.Drawing.Font("メイリオ", 12.0F)
        sheet.SelectionForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim cd As New ColorDialog()
        If cd.ShowDialog() = DialogResult.OK Then
            Dim cr As FarPoint.Win.Spread.Model.CellRange() = FpSpread1.Sheets(0).GetSelections()
            For i As Integer = 0 To cr.Length - 1
                FpSpread1.Sheets(0).SelectionBackColor = cd.Color
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' FontDialogの設定
        Dim fd As New FontDialog()
        fd.Font = FpSpread1.Sheets(0).SelectionFont
        fd.Color = FpSpread1.Sheets(0).SelectionForeColor
        fd.MaxSize = 15
        fd.MinSize = 10
        fd.FontMustExist = True
        fd.AllowVerticalFonts = False
        fd.ShowColor = True
        fd.ShowEffects = True
        fd.FixedPitchOnly = False

        ' ダイアログを表示
        If fd.ShowDialog() <> DialogResult.Cancel Then
            ' フォントと色の設定
            FpSpread1.Sheets(0).SelectionFont = fd.Font
            FpSpread1.Sheets(0).SelectionForeColor = fd.Color
        End If
    End Sub
End Class
