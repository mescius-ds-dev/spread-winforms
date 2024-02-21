Public Class hierarchicalview

    Private myDataSet As New DataSet()

    Public Sub New()

        InitializeComponent()

        ' データ作成
        InitData()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitData()
        Dim thisyear As System.Data.DataTable, lastyear As System.Data.DataTable

        ' 当年度データ
        thisyear = myDataSet.Tables.Add("thisyear")
        thisyear.Columns.AddRange(New DataColumn() {New DataColumn("製品ID", Type.GetType("System.String")), New DataColumn("製品種別", Type.GetType("System.String")), New DataColumn("製品名", Type.GetType("System.String")), New DataColumn("当年第１Ｑ", Type.GetType("System.Int32")), New DataColumn("当年第２Ｑ", Type.GetType("System.Int32")), New DataColumn("当年第３Ｑ", Type.GetType("System.Int32")), New DataColumn("当年第４Ｑ", Type.GetType("System.Int32"))})

        thisyear.Rows.Add(New [Object]() {"10001", "乳製品", "酪農ミルク", 5500, 5000, 4500, 6000})
        thisyear.Rows.Add(New [Object]() {"20001", "清涼飲料水", "いよかんドリンク", 1000, 3000, 2700, 2700})
        thisyear.Rows.Add(New [Object]() {"20002", "清涼飲料水", "ぶどうジュース", 3000, 3500, 4800, 4800})
        thisyear.Rows.Add(New [Object]() {"20003", "清涼飲料水", "マンゴードリンク", 2000, 1000, 500, 1050})
        thisyear.Rows.Add(New [Object]() {"30001", "ビール", "激辛ビール", 5500, 8000, 8500, 10000})
        thisyear.Rows.Add(New [Object]() {"30002", "ビール", "モルトビール", 3000, 3500, 2780, 4000})
        thisyear.Rows.Add(New [Object]() {"20004", "清涼飲料水", "ぶどうの街", 500, 300, 200, 700})
        thisyear.Rows.Add(New [Object]() {"30003", "ビール", "オリエントの村", 8000, 9500, 9580, 9000})
        thisyear.Rows.Add(New [Object]() {"40002", "焼酎", "吟醸 ほめごろし", 6000, 7000, 9000, 9500})
        thisyear.Rows.Add(New [Object]() {"40003", "焼酎", "大吟醸 オリエント", 1000, 5000, 6000, 5000})
        thisyear.Rows.Add(New [Object]() {"40005", "焼酎", "麦焼酎 ちこちこ", 1000, 1500, 1200, 1258})
        thisyear.Rows.Add(New [Object]() {"10002", "乳製品", "酪農ミルク（低脂肪）", 501, 202, 380, 456})

        lastyear = myDataSet.Tables.Add("lastyear")
        lastyear.Columns.AddRange(New DataColumn() {New DataColumn("製品ID", Type.GetType("System.String")), New DataColumn("製品種別", Type.GetType("System.String")), New DataColumn("製品名", Type.GetType("System.String")), New DataColumn("前年第１Ｑ", Type.GetType("System.Int32")), New DataColumn("前年第２Ｑ", Type.GetType("System.Int32")), New DataColumn("前年第３Ｑ", Type.GetType("System.Int32")), New DataColumn("前年第４Ｑ", Type.GetType("System.Int32"))})

        lastyear.Rows.Add(New [Object]() {"10001", "乳製品", "酪農ミルク", 2000, 1000, 4023, 5230})
        lastyear.Rows.Add(New [Object]() {"20001", "清涼飲料水", "いよかんドリンク", 1050, 2000, 2500, 2600})
        lastyear.Rows.Add(New [Object]() {"20002", "清涼飲料水", "ぶどうジュース", 3600, 2400, 1200, 1600})
        lastyear.Rows.Add(New [Object]() {"20003", "清涼飲料水", "マンゴードリンク", 1600, 1250, 356, 1020})
        lastyear.Rows.Add(New [Object]() {"30001", "ビール", "激辛ビール", 5600, 5000, 2500, 1900})
        lastyear.Rows.Add(New [Object]() {"30002", "ビール", "モルトビール", 1000, 2500, 2760, 2000})
        lastyear.Rows.Add(New [Object]() {"20004", "清涼飲料水", "ぶどうの街", 500, 300, 200, 700})
        lastyear.Rows.Add(New [Object]() {"30003", "ビール", "オリエントの村", 1000, 500, 2580, 1230})
        lastyear.Rows.Add(New [Object]() {"40002", "焼酎", "吟醸 ほめごろし", 5000, 7589, 5000, 6895})
        lastyear.Rows.Add(New [Object]() {"40003", "焼酎", "大吟醸 オリエント", 800, 3568, 4521, 3564})
        lastyear.Rows.Add(New [Object]() {"40005", "焼酎", "麦焼酎 ちこちこ", 1000, 1512, 1212, 1058})
        lastyear.Rows.Add(New [Object]() {"10002", "乳製品", "酪農ミルク（低脂肪）", 301, 102, 280, 256})

        ' リレーションシップを設定します。
        myDataSet.Relations.Add("prddata", thisyear.Columns("製品ID"), lastyear.Columns("製品ID"))
    End Sub


    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        'データ連結            
        sheet.DataSource = myDataSet

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 140
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80
        sheet.Columns(6).Width = 80
    End Sub

    Private Sub FpSpread1_ChildViewCreated(sender As Object, e As FarPoint.Win.Spread.ChildViewCreatedEventArgs) Handles FpSpread1.ChildViewCreated
        Dim sv As FarPoint.Win.Spread.SheetView = e.SheetView

        Select Case e.SheetView.ParentRelationName
            Case "prddata"
                sv.Columns(0).Visible = False
                sv.Columns(1).Visible = False
                sv.Columns(2).Visible = False

                sv.RowHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank
                sv.RowHeader.Columns(0).Width = 290
                sv.Columns(3).Width = 80
                sv.Columns(4).Width = 80
                sv.Columns(5).Width = 80
                sv.Columns(6).Width = 80

                sv.RowHeader.Cells(0, 0).Text = "前年同期"
                sv.ColumnHeader.Visible = False
                sv.DefaultStyle.Locked = True

                sv.DefaultStyle.BackColor = System.Drawing.Color.LightYellow
                sv.SheetCornerStyle.BackColor = System.Drawing.Color.LightYellow
                sv.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.LightYellow
                sv.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.LightYellow

                Exit Select
        End Select
    End Sub
End Class
