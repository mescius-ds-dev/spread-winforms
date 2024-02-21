Public Class saveexcelfile

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
            sfd.Filter = "Excelファイル(*.xls)|*.xls"
            sfd.FileName = "SpreadClickOnceデモ.xls"
            If sfd.ShowDialog() = DialogResult.OK Then
                fn = sfd.FileName
            Else
                Return
            End If
        End Using

        ' Excelファイルに保存
        FpSpread1.SaveExcel(fn, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders)
    End Sub

    Private Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        ' ファイル保存ダイアログ起動
        Dim fn As String = ""
        Using sfd As New SaveFileDialog()
            sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx"
            sfd.FileName = "SpreadClickOnceデモ.xlsx"
            If sfd.ShowDialog() = DialogResult.OK Then
                fn = sfd.FileName
            Else
                Return
            End If
        End Using

        ' Excelファイルに保存
        FpSpread1.SaveExcel(fn, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders Or FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat)
    End Sub
End Class
