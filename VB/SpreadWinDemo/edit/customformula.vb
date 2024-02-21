Public Class customformula

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

        ' 総合計列追加
        sheet.AddColumns(7, 1)
        sheet.ColumnHeader.Cells(0, 7).Text = "総合計"

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 135
        sheet.Columns(3).Width = 65
        sheet.Columns(4).Width = 65
        sheet.Columns(5).Width = 65
        sheet.Columns(6).Width = 65
        sheet.Columns(7).Width = 78


        ' 作成したカスタム関数を追加
        Dim fs As FarPoint.Win.Spread.Model.ICustomFunctionSupport = DirectCast(FpSpread1.ActiveSheet.Models.Data, FarPoint.Win.Spread.Model.ICustomFunctionSupport)
        fs.AddCustomFunction(New MySumFunction())

        ' セルに関数を設定
        sheet.SetFormula(sheet.RowCount - 1, 7, "MySumFunction(D1:G" & Convert.ToString(sheet.RowCount) & ")")
        sheet.Cells(sheet.RowCount - 1, 7).BackColor = System.Drawing.Color.Salmon
    End Sub

    ' FunctionInfoクラスを継承したサブクラスを作成
    <Serializable()> _
    Public Class MySumFunction
        Inherits FarPoint.CalcEngine.FunctionInfo
        Public Overrides Function Evaluate(args As Object()) As Object
            Dim cr As FarPoint.CalcEngine.CalcReference
            Dim total As Double = 0

            If TypeOf args(0) Is FarPoint.CalcEngine.CalcReference Then

                ' 引数args[0]より範囲を取得
                cr = DirectCast(args(0), FarPoint.CalcEngine.CalcReference)
                For r As Integer = cr.Row To (cr.Row + cr.RowCount) - 1
                    For c As Integer = cr.Column To (cr.Column + cr.ColumnCount) - 1
                        ' 範囲内の値を加算
                        total += FarPoint.CalcEngine.CalcConvert.ToDouble(cr.GetValue(r, c))
                    Next
                Next

                ' 計算結果
                Return total
            Else
                Return FarPoint.CalcEngine.CalcError.Value
            End If
        End Function

        Public Overrides ReadOnly Property MaxArgs() As Integer
            Get
                Return 1
            End Get
        End Property

        Public Overrides ReadOnly Property MinArgs() As Integer
            Get
                Return 1
            End Get
        End Property

        Public Overrides ReadOnly Property Name() As String
            Get
                Return "MySumFunction"
            End Get
        End Property

        Public Overrides Function AcceptsReference(i As Integer) As Boolean
            Return True
        End Function
    End Class
End Class
