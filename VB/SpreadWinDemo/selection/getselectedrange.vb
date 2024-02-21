Public Class getselectedrange

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' 選択範囲の取得
        Dim cr As FarPoint.Win.Spread.Model.CellRange = FpSpread1.ActiveSheet.GetSelection(0)
        Dim msgstr As String
        msgstr = "選択された先頭行インデックス：" & cr.Row.ToString()
        msgstr += System.Environment.NewLine & "選択された行数：" & cr.RowCount.ToString()
        msgstr += System.Environment.NewLine & "選択された先頭列インデックス：" & cr.Column.ToString()
        msgstr += System.Environment.NewLine & "選択された列数：" & cr.ColumnCount.ToString()
        MessageBox.Show(msgstr)
    End Sub
End Class
