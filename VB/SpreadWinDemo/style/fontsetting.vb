Public Class fontsetting

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
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 100
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 80
        sheet.Columns(8).Width = 181
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' FontDialogの設定
        Dim fd As New FontDialog()
        fd.Font = FpSpread1.Font
        fd.Color = FpSpread1.Sheets(0).DefaultStyle.ForeColor
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
            FpSpread1.Font = fd.Font
            FpSpread1.Sheets(0).DefaultStyle.ForeColor = fd.Color
        End If
    End Sub
End Class
