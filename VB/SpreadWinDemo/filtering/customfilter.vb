Public Class customfilter

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".datanum2.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 135
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80
        sheet.Columns(6).Width = 80

        sheet.ColumnHeaderAutoTextIndex = 0
        sheet.ColumnHeader.RowCount = 2

        ' フィルターを設定
        Dim hf As FarPoint.Win.Spread.HideRowFilter
        Dim mc As MyCustomFilter
        Dim fcd As FarPoint.Win.Spread.FilterColumnDefinition
        hf = New FarPoint.Win.Spread.HideRowFilter(sheet)
        '非表示フィルタの作成
        mc = New MyCustomFilter()
        'カスタムフィルタを作成
        mc.SheetView = sheet
        'シートの設定
        ' 4列目～7列目にカスタムフィルタを設定
        For i As Integer = 0 To 3
            fcd = New FarPoint.Win.Spread.FilterColumnDefinition(i + 3, FarPoint.Win.Spread.FilterListBehavior.Custom)
            fcd.Filters.Add(mc)
            'カスタムフィルタを定義に追加
            'フィルタ定義を非表示フィルタに追加            
            hf.AddColumn(fcd)
        Next

        'フィルタをシートに設定
        sheet.RowFilter = hf
    End Sub

    <Serializable()> _
    Public Class MyCustomFilter
        Inherits FarPoint.Win.Spread.DefaultFilterItem
        Private sv As FarPoint.Win.Spread.SheetView = Nothing

        Public Sub New()
        End Sub
        Public Overrides ReadOnly Property DisplayName() As String
            Get
                Return "1000～5000"
            End Get
        End Property
        'フィルタに表示する文字列
        Public Overrides WriteOnly Property SheetView() As FarPoint.Win.Spread.SheetView
            Set(value As FarPoint.Win.Spread.SheetView)
                sv = value
            End Set
        End Property
        Private Function IsNumeric(ovalue As Object) As Boolean
            Dim _isNumber As New System.Text.RegularExpressions.Regex("^\-?\d+\.?\d*$")
            Dim m As System.Text.RegularExpressions.Match = _isNumber.Match(Convert.ToString(ovalue))
            Return m.Success
        End Function
        Public Function IsFilteredIn(ovalue As Object) As Boolean
            Dim ret As Boolean = False
            If IsNumeric(ovalue) Then
                If [Double].Parse(Convert.ToString(ovalue)) >= 1000 AndAlso [Double].Parse(Convert.ToString(ovalue)) <= 5000 Then
                    ret = True
                End If
            End If
            Return ret
        End Function
        Public Overrides Function Filter(columnIndex As Integer) As Integer()
            Dim ar As New System.Collections.ArrayList()
            Dim val As Object
            For i As Integer = 0 To sv.RowCount - 1
                val = sv.GetValue(i, columnIndex)
                If IsFilteredIn(val) Then
                    ar.Add(i)
                    '条件に合致する行番号をリストに追加
                End If
            Next
            Return DirectCast(ar.ToArray(GetType(Int32)), Int32())
        End Function
        Public Overrides Function ShowInDropDown(columnIndex As Integer, filteredInRowList As Integer()) As Boolean
            ' filteredInRowList引数は現在、フィルター・イン（フィルターの条件に合致した）行リスト
            ' 条件に合うデータが存在する時のみフィルター要素を表示
            If filteredInRowList Is Nothing Then
                For i As Integer = 0 To sv.RowCount - 1
                    Dim value As Object = sv.GetValue(i, columnIndex)
                    If value IsNot Nothing Then
                        If IsFilteredIn(value) Then
                            Return True
                        End If
                    End If
                Next
            Else
                ' 現在の行リストが条件に合致するか確認
                For i As Integer = 0 To filteredInRowList.Length - 1
                    Dim row As Integer = filteredInRowList(i)
                    Dim value As Object = sv.GetValue(row, columnIndex)
                    If value IsNot Nothing Then
                        If IsFilteredIn(value) Then
                            Return True
                        End If
                    End If
                Next
            End If
            Return False
        End Function
        Public Overrides Function Serialize(w As System.Xml.XmlTextWriter) As Boolean
            w.WriteStartElement("MyCustomFilter")
            MyBase.Serialize(w)
            w.WriteEndElement()
            Return True
        End Function
        Public Overrides Function Deserialize(r As System.Xml.XmlNodeReader) As Boolean
            If r.NodeType = System.Xml.XmlNodeType.Element Then
                If r.Name.Equals("MyCustomFilter") Then
                    MyBase.Deserialize(r)
                End If
            End If
            Return True
        End Function
    End Class
End Class
