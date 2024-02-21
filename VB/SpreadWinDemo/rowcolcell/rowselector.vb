Public Class rowselector

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        CheckBox1.Checked = True
        CheckBox2.Checked = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data.xml"))
        sheet.DataSource = ds

        ' シート設定
        sheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode

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

        ' 行セレクタの表示
        sheet.ShowRowSelector = True
        sheet.ShowEditingRowSelector = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            FpSpread1.Sheets(0).ShowRowSelector = True
        Else
            FpSpread1.Sheets(0).ShowRowSelector = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            FpSpread1.Sheets(0).ShowEditingRowSelector = True
        Else
            FpSpread1.Sheets(0).ShowEditingRowSelector = False
        End If
    End Sub
End Class
