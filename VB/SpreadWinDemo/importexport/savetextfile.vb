Public Class savetextfile

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds
        sheet.ColumnHeader.Cells(0, 0).Value = "No"

        ' 列幅の設定
        sheet.Columns(0).Width = 36
        sheet.Columns(1).Width = 88
        sheet.Columns(2).Width = 91
        sheet.Columns(3).Width = 71
        sheet.Columns(4).Width = 36
        sheet.Columns(5).Width = 46
        sheet.Columns(6).Width = 49
        sheet.Columns(7).Width = 71
        sheet.Columns(8).Width = 181
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' ファイル保存ダイアログ起動
        Dim fn As String = ""
        Using sfd As New SaveFileDialog()
            sfd.Filter = "csvファイル(*.csv)|*.csv"
            sfd.FileName = "SpreadClickOnceデモ.csv"
            If sfd.ShowDialog() = DialogResult.OK Then
                fn = sfd.FileName
            Else
                Return
            End If
        End Using

        ' csv出力
        FpSpread1.ActiveSheet.SaveTextFile(fn, FarPoint.Win.Spread.TextFileFlags.None, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly, System.Environment.NewLine, ",", """")
    End Sub
End Class
