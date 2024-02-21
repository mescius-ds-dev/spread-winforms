Public Class customcomparison

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private isasc As Boolean

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
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

        ' 列の非表示
        sheet.Columns(6).Visible = False
        sheet.Columns(7).Visible = False

        isasc = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        If Not isasc Then
            isasc = True
        Else
            isasc = False
        End If

        ' Comparerを指定してソートを実行
        FpSpread1.Sheets(0).SortRows(8, isasc, True, New MyStringComparer())
    End Sub
End Class

'----------------------------------
'IComparer 実装クラス
'----------------------------------
<Serializable()> _
Public Class MyStringComparer
    Implements System.Collections.IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        ' ドメイン部分を抜き出し
        Dim val1 As String = Convert.ToString(x).Substring(Convert.ToString(x).IndexOf("@") + 1)
        Dim val2 As String = Convert.ToString(y).Substring(Convert.ToString(y).IndexOf("@") + 1)

        Dim compareResult As Integer
        compareResult = String.Compare(val1, val2, False)

        Return compareResult
    End Function
End Class