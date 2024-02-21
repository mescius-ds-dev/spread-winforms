Public Class camerashape

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シートの設定            
        createHeader2(FpSpread1.Sheets(1))
        createDetail(FpSpread1.Sheets(2))
        createStamp(FpSpread1.Sheets(3))
        createHeader1(FpSpread1.Sheets(4))
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Const SHT_MAIN_NM As String = "Main"
    Private Const SHT_HD1_NM As String = "Head1"
    Private Const SHT_HD2_NM As String = "Head2"
    Private Const SHT_DT_NM As String = "Detail"
    Private Const SHT_ST_NM As String = "Stamp"

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        spread.Sheets.Count = 5

        spread.Sheets(0).SheetName = "Main"
        spread.Sheets(1).SheetName = "Head2"
        spread.Sheets(2).SheetName = "Detail"
        spread.Sheets(3).SheetName = "Stamp"
        spread.Sheets(4).SheetName = "Head1"
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        sheet.RowHeader.Visible = False
        sheet.ColumnHeader.Visible = False

        sheet.ColumnCount = 1
        sheet.Columns(0).Width = fpSpread1.Width

        sheet.SetValue(0, 0, "御 見 積 書")
        sheet.Cells(0, 0).Font = New Font("メイリオ", 14.0F, FontStyle.Bold)
        sheet.Cells(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        sheet.Rows(0).Height = 100

        sheet.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
        sheet.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)

        ' 各シートの情報をカメラシェイプでメインシートに追加
        Dim head1 As New FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape()
        head1.Formula = (SHT_HD1_NM & "!A1:B") + FpSpread1.Sheets(SHT_HD1_NM).RowCount.ToString()
        head1.Location = New System.Drawing.Point(10, 50)
        head1.ShapeOutlineThickness = 0
        sheet.AddShape(head1)

        Dim head2 As New FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape()
        head2.Formula = (SHT_HD2_NM & "!A1:B") + FpSpread1.Sheets(SHT_HD2_NM).RowCount.ToString()
        head2.Location = New System.Drawing.Point(10, 180)
        head2.ShapeOutlineThickness = 0
        sheet.AddShape(head2)

        Dim detail As New FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape()
        detail.Formula = (SHT_DT_NM & "!A1:G") + FpSpread1.Sheets(SHT_DT_NM).RowCount.ToString()
        detail.Location = New System.Drawing.Point(10, 280)
        detail.ShapeOutlineThickness = 0
        sheet.AddShape(detail)

        Dim stamp As New FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape()
        stamp.Formula = (SHT_ST_NM & "!A1:C") + FpSpread1.Sheets(SHT_ST_NM).RowCount.ToString()
        stamp.Location = New System.Drawing.Point(370, 50)
        stamp.ShapeOutlineThickness = 0
        sheet.AddShape(stamp)
    End Sub

    Private Sub createHeader1(sheet As FarPoint.Win.Spread.SheetView)
        Dim font As New Font("メイリオ", 9.0F)
        sheet.DefaultStyle.Font = font

        sheet.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)
        sheet.HorizontalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)

        sheet.RowCount = 4
        sheet.ColumnCount = 2

        sheet.Columns(0).Width = 240
        sheet.Columns(1).Width = 90

        Dim sysdt As System.DateTime = DateTime.Now
        Dim japaneseCulture As New System.Globalization.CultureInfo("ja-JP", False)
        japaneseCulture.DateTimeFormat.Calendar = New System.Globalization.JapaneseCalendar()

        sheet.Cells(0, 0).Value = "紫山株式会社様"
        sheet.Cells(0, 0).Font = New Font("メイリオ", 14.0F, FontStyle.Bold Or FontStyle.Underline)

        sheet.Cells(1, 0).Value = sysdt.ToString("ggyy年M月d日", japaneseCulture)
        sheet.Cells(2, 0).Value = "下記の通りお見積申し上げます。"
        sheet.Cells(3, 0).Value = "御見積金額"
        sheet.Cells(3, 1).Formula = "SUM(" & SHT_DT_NM & "!A1:G" & fpSpread1.Sheets(SHT_DT_NM).RowCount.ToString() & ")"

        sheet.Rows(3).Font = New Font("メイリオ", 9.0F, FontStyle.Bold)

        sheet.Rows(3).Border = New FarPoint.Win.DoubleLineBorder(Color.Black, False, False, False, True)

        Dim cur As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        cur.DecimalPlaces = 0
        cur.FixedPoint = False
        cur.ShowCurrencySymbol = True
        cur.ShowSeparator = True
        sheet.Cells(3, 1).CellType = cur

        sheet.Rows(0).Height = 40
        sheet.Rows(1).Height = 20
        sheet.Rows(2).Height = 20
        sheet.Rows(3).Height = 25
    End Sub

    Private Sub createHeader2(sheet As FarPoint.Win.Spread.SheetView)
        Dim font As New Font("メイリオ", 9.0F)
        sheet.DefaultStyle.Font = font

        sheet.VerticalGridLine = New FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None)

        sheet.RowCount = 4
        sheet.ColumnCount = 2

        sheet.Columns(0).Width = 120
        sheet.Columns(1).Width = 190

        sheet.Cells(0, 0).Value = "支払条件："
        sheet.Cells(1, 0).Value = "受渡期限："
        sheet.Cells(2, 0).Value = "見積有効期限："
        sheet.Cells(3, 0).Value = "受渡場所："

        sheet.Cells(0, 1).Value = "当月末締め翌月末払い"
        sheet.Cells(1, 1).Value = "受注後約1週間"
        sheet.Cells(2, 1).Value = "見積提出日より1ヶ月"
        sheet.Cells(3, 1).Value = "貴社指定場所"
    End Sub

    Private Sub createDetail(sheet As FarPoint.Win.Spread.SheetView)
        Dim font As New Font("メイリオ", 9.0F)
        sheet.DefaultStyle.Font = font
        sheet.Rows.[Default].Height = 30
        sheet.Rows.[Default].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom

        Dim ds As DataSet = CreateDataSource()
        sheet.DataSource = ds.Tables(0)

        ' ヘッダ用の行追加
        sheet.AddUnboundRows(0, 1)

        sheet.Columns(0).Width = 25
        sheet.Columns(1).Width = 60
        sheet.Columns(2).Width = 200
        sheet.Columns(3).Width = 90
        sheet.Columns(4).Width = 70
        sheet.Columns(5).Width = 50
        sheet.Columns(6).Width = 80

        Dim cur As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        cur.DecimalPlaces = 0
        cur.FixedPoint = False
        cur.ShowSeparator = True
        cur.ShowCurrencySymbol = False

        sheet.Columns(4).CellType = cur
        sheet.Columns(6).CellType = cur

        Dim gur As New FarPoint.Win.Spread.CellType.GeneralCellType()
        sheet.Rows(0).CellType = gur

        ' ヘッダ作成
        For index As Integer = 0 To ds.Tables(0).Columns.Count - 1
            sheet.SetValue(0, index, sheet.ColumnHeader.Columns(index).Label)
        Next

        sheet.Rows(0).BackColor = Color.AliceBlue
        sheet.Rows(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
    End Sub

    Private Sub createStamp(sheet As FarPoint.Win.Spread.SheetView)
        Dim font As New Font("メイリオ", 9.0F)
        sheet.DefaultStyle.Font = font

        sheet.RowCount = 2
        sheet.ColumnCount = 3

        sheet.Columns(0, 2).Width = 70
        sheet.Cells(0, 0).Value = "経理"
        sheet.Cells(0, 1).Value = "担当長"
        sheet.Cells(0, 2).Value = "担当"

        sheet.Rows(1).Height = 60
        sheet.Rows(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center

        Dim bds As New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.ThinLine, Color.Black)
        Dim bd As New FarPoint.Win.ComplexBorder(bds, bds, bds, bds)
        sheet.Cells(0, 0).Border = New FarPoint.Win.ComplexBorder(bds, bds, bds, bds)
        sheet.Cells(0, 1).Border = New FarPoint.Win.ComplexBorder(Nothing, bds, bds, bds)
        sheet.Cells(0, 2).Border = New FarPoint.Win.ComplexBorder(Nothing, bds, bds, bds)
        sheet.Cells(1, 0).Border = New FarPoint.Win.ComplexBorder(bds, Nothing, bds, bds)
        sheet.Cells(1, 1).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, bds, bds)
        sheet.Cells(1, 2).Border = New FarPoint.Win.ComplexBorder(Nothing, Nothing, bds, bds)

    End Sub
    ' テストデータの作成
    Public Function CreateDataSource() As DataSet
        Dim ds As New DataSet()
        Dim dt As DataTable = Nothing
        Dim dr As DataRow = Nothing

        dt = New DataTable()
        dt.Columns.Add(New DataColumn("No", GetType(Integer)))
        dt.Columns.Add(New DataColumn("製品No", GetType(String)))
        dt.Columns.Add(New DataColumn("品名", GetType(String)))
        dt.Columns.Add(New DataColumn("詳細", GetType(String)))
        dt.Columns.Add(New DataColumn("単価", GetType(Decimal)))
        dt.Columns.Add(New DataColumn("数量", GetType(Integer)))
        dt.Columns.Add(New DataColumn("金額", GetType(Decimal)))

        dr = dt.NewRow()
        dr(0) = 1
        dr(1) = "10002"
        dr(2) = "スキャナ GC-SCAN"
        dr(3) = "GC-9600T"
        dr(4) = 18900
        dr(5) = 5
        dr(6) = 94500
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = 2
        dr(1) = "10003"
        dr(2) = "スキャナ GC-SCAN-P"
        dr(3) = "GC-8600T"
        dr(4) = 12900
        dr(5) = 1
        dr(6) = 12900
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = 3
        dr(1) = "20013"
        dr(2) = "プリンタ GC-AR-P"
        dr(3) = "GC-Y.WK"
        dr(4) = 34800
        dr(5) = 1
        dr(6) = 34800
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = 4
        dr(1) = "50001"
        dr(2) = "デジタルカメラ GC-LD"
        dr(3) = "GC-K.UJ"
        dr(4) = 24800
        dr(5) = 1
        dr(6) = 24800
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr(0) = 5
        dr(1) = "11001"
        dr(2) = "パソコン GC-SP"
        dr(3) = "GC-Y.NG"
        dr(4) = 189000
        dr(5) = 2
        dr(6) = 378000
        dt.Rows.Add(dr)
        ds.Tables.Add(dt)

        Return ds
    End Function
End Class
