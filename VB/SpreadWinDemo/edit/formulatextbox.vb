Public Class formulatextbox

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSpread(FpSpread1)

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' 名前ボックスの追加
        Dim namebox1 As New FarPoint.Win.Spread.NameBox()
        Me.splitContainer2.Panel1.Controls.Add(namebox1)
        namebox1.Dock = DockStyle.Fill
        namebox1.Attach(spread)
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum2.xml"))
        sheet.DataSource = ds

        ' 合計列追加
        sheet.AddColumns(7, 1)
        sheet.ColumnHeader.Cells(0, 7).Text = "合計"

        ' 数式設定
        For i As Integer = 0 To sheet.RowCount - 1
            Dim row As String = Convert.ToString(i + 1)
            sheet.Cells(i, 7).Formula = "SUM(D" & row & ":G" & row & ")"
        Next

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 135
        sheet.Columns(3).Width = 65
        sheet.Columns(4).Width = 65
        sheet.Columns(5).Width = 65
        sheet.Columns(6).Width = 65
        sheet.Columns(7).Width = 103
    End Sub
End Class
