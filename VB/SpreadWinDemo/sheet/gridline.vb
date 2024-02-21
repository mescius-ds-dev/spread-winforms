Public Class gridline

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

        '垂直グリッド線を非表示
        FpSpread1.ActiveSheet.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)

        ' 水平グリッド線を非表示
        FpSpread1.ActiveSheet.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim cd As New ColorDialog()
            If cd.ShowDialog() = DialogResult.OK Then
                '垂直グリッド線を表示
                FpSpread1.ActiveSheet.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, cd.Color)
            Else
                CheckBox1.Checked = False
            End If
        Else
            '垂直グリッド線を非表示
            FpSpread1.ActiveSheet.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Dim cd As New ColorDialog()
            If cd.ShowDialog() = DialogResult.OK Then
                ' 水平グリッド線を表示
                FpSpread1.ActiveSheet.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.Flat, cd.Color)
            Else
                CheckBox2.Checked = False
            End If
        Else
            ' 水平グリッド線を非表示
            FpSpread1.ActiveSheet.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
        End If
    End Sub
End Class
