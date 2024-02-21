Public Class blackwhiteprint
    Public Sub New()

        InitializeComponent()

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

        ' 文字色と背景色の設定
        sheet.DefaultStyle.BackColor = Color.LavenderBlush
        sheet.DefaultStyle.ForeColor = Color.Red
    End Sub

    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' SPREADの準備が完了していない場合を除外
        If FpSpread1.Sheets.Count = 0 Then Return

        ' 白黒印刷とカラー印刷の切り替え
        FpSpread1.Sheets(0).PrintInfo.ShowColor = Not CheckBox1.Checked
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 印刷の実行
        FpSpread1.Sheets(0).PrintInfo.Preview = False
        FpSpread1.PrintSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 印刷プレビューの表示
        FpSpread1.Sheets(0).PrintInfo.Preview = True
        FpSpread1.PrintSheet(FpSpread1.Sheets(0))
    End Sub
End Class
