Public Class fieldbinding

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        ComboBox1.Text = "全データを連結"
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".databind.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 140

        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' リセット            
        FpSpread1.Reset()

        If ComboBox1.Text = "計画データのみを連結" Then
            ' 連結時の列自動生成を無効
            FpSpread1.Sheets(0).AutoGenerateColumns = False
            FpSpread1.Sheets(0).ColumnCount = 15

            ' 連結フィールドの設定
            FpSpread1.Sheets(0).Columns(0).DataField = "製品ID"
            FpSpread1.Sheets(0).Columns(1).DataField = "製品分類"
            FpSpread1.Sheets(0).Columns(2).DataField = "製品名"
            FpSpread1.Sheets(0).Columns(3).DataField = "4月計画"
            FpSpread1.Sheets(0).Columns(4).DataField = "5月計画"
            FpSpread1.Sheets(0).Columns(5).DataField = "6月計画"
            FpSpread1.Sheets(0).Columns(6).DataField = "7月計画"
            FpSpread1.Sheets(0).Columns(7).DataField = "8月計画"
            FpSpread1.Sheets(0).Columns(8).DataField = "9月計画"
            FpSpread1.Sheets(0).Columns(9).DataField = "10月計画"
            FpSpread1.Sheets(0).Columns(10).DataField = "11月計画"
            FpSpread1.Sheets(0).Columns(11).DataField = "12月計画"
            FpSpread1.Sheets(0).Columns(12).DataField = "1月計画"
            FpSpread1.Sheets(0).Columns(13).DataField = "2月計画"
            FpSpread1.Sheets(0).Columns(14).DataField = "3月計画"

            ' データ連結
            Dim ds As New DataSet()
            ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".databind.xml"))
            FpSpread1.Sheets(0).DataSource = ds
        ElseIf ComboBox1.Text = "実績データのみを連結" Then
            ' 連結時の列自動生成を無効
            FpSpread1.Sheets(0).AutoGenerateColumns = False
            FpSpread1.Sheets(0).ColumnCount = 15

            ' 連結フィールドの設定
            FpSpread1.Sheets(0).Columns(0).DataField = "製品ID"
            FpSpread1.Sheets(0).Columns(1).DataField = "製品分類"
            FpSpread1.Sheets(0).Columns(2).DataField = "製品名"
            FpSpread1.Sheets(0).Columns(3).DataField = "4月実績"
            FpSpread1.Sheets(0).Columns(4).DataField = "5月実績"
            FpSpread1.Sheets(0).Columns(5).DataField = "6月実績"
            FpSpread1.Sheets(0).Columns(6).DataField = "7月実績"
            FpSpread1.Sheets(0).Columns(7).DataField = "8月実績"
            FpSpread1.Sheets(0).Columns(8).DataField = "9月実績"
            FpSpread1.Sheets(0).Columns(9).DataField = "10月実績"
            FpSpread1.Sheets(0).Columns(10).DataField = "11月実績"
            FpSpread1.Sheets(0).Columns(11).DataField = "12月実績"
            FpSpread1.Sheets(0).Columns(12).DataField = "1月実績"
            FpSpread1.Sheets(0).Columns(13).DataField = "2月実績"
            FpSpread1.Sheets(0).Columns(14).DataField = "3月実績"

            ' データ連結
            Dim ds As New DataSet()
            ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".databind.xml"))
            FpSpread1.Sheets(0).DataSource = ds
        Else
            ' データ連結
            Dim ds As New DataSet()
            ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".databind.xml"))

            FpSpread1.Sheets(0).DataSource = ds
        End If

        ' 列幅の設定
        FpSpread1.Sheets(0).Columns(0).Width = 45
        FpSpread1.Sheets(0).Columns(1).Width = 85
        FpSpread1.Sheets(0).Columns(2).Width = 140

        For i As Integer = 3 To FpSpread1.Sheets(0).ColumnCount - 1
            FpSpread1.Sheets(0).Columns(i).Width = 65
        Next
    End Sub
End Class
