Public Class dragbandonmoving
    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' 行のドラッグ移動を許可
        spread.AllowRowMove = True

        ' 列のドラッグ移動を許可
        spread.AllowColumnMove = True

        ' 行列のドラッグ移動時のアニメーションを簡素化
        spread.ShowDragBandOnMoving = False
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data50.xml"))
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

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' 行列のドラッグ移動時にドラッグバンドを表示する
            FpSpread1.ShowDragBandOnMoving = True
        Else
            ' 行列のドラッグ移動時のアニメーションを簡素化
            FpSpread1.ShowDragBandOnMoving = False
        End If
    End Sub
End Class
