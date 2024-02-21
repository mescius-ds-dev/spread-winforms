Public Class autofitcustomize

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))

        checkBox5.Checked = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' ヘッダのWordWrap禁止
        Dim hsInfo As New FarPoint.Win.Spread.StyleInfo()
        FpSpread1.ActiveSheet.Models.ColumnHeaderStyle.GetCompositeInfo(0, 0, 0, hsInfo)
        DirectCast(hsInfo.Renderer, FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer).WordWrap2 = False
        FpSpread1.ActiveSheet.ColumnHeader.DefaultStyle.Renderer = hsInfo.Renderer

        ' シートコーナーの設定
        sheet.SheetCorner.Columns.Default.Resizable = True
        sheet.SheetCorner.Rows.Default.Resizable = True

        ' 列ヘッダの設定
        sheet.ColumnHeader.Cells(0, 1).Value = "列ヘッダのテスト"
        sheet.ColumnHeader.Cells(0, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

        ' 列フッタの設定
        sheet.ColumnFooter.Visible = True
        sheet.ColumnFooter.Cells(0, 0).Value = "列フッタのテスト"
        sheet.ColumnFooter.Cells(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

        ' 行ヘッダの設定
        sheet.RowHeader.Cells(0, 0).Value = "行ヘッダのテスト"
        sheet.RowHeader.Cells(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        sheet.RowHeader.Cells(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Top

        ' セルの設定
        sheet.DefaultStyle.CellType = New FarPoint.Win.Spread.CellType.TextCellType() With {.WordWrap = True}
        sheet.Cells(1, 2).Value = "結合セル（水平）のテスト"
        sheet.Cells(2, 4).Value = "結合セル（垂直）のテスト"
        sheet.Cells(4, 5).Value = "複数行セルのテスト"
        sheet.Cells(1, 2).ColumnSpan = 2
        sheet.Cells(2, 4).RowSpan = 2

        ' 列と幅の自動調節機能の初期化
        FpSpread1.AutoFitColumnOptions = FarPoint.Win.Spread.PreferredSizeColumnOptions.IncludeAll
        FpSpread1.AutoFitRowOptions = FarPoint.Win.Spread.PreferredSizeRowOptions.IncludeAll
    End Sub

    Private isSetByCode As Boolean = False

    Private Sub checkBox_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged, checkBox2.CheckedChanged, checkBox3.CheckedChanged, checkBox4.CheckedChanged, checkBox5.CheckedChanged, checkBox6.CheckedChanged
        ' チェック状態の制御
        If isSetByCode Then Return
        isSetByCode = True
        If sender Is checkBox5 AndAlso checkBox5.Checked Then
            checkBox1.Checked = False
            checkBox2.Checked = False
            checkBox3.Checked = False
            checkBox4.Checked = False
            checkBox6.Checked = False
            isSetByCode = False
        ElseIf sender Is checkBox5 AndAlso Not checkBox6.Checked Then
            checkBox1.Checked = True
            checkBox2.Checked = True
            checkBox3.Checked = True
            checkBox4.Checked = True
        ElseIf sender Is checkBox6 AndAlso checkBox6.Checked Then
            checkBox1.Checked = False
            checkBox2.Checked = False
            checkBox3.Checked = False
            checkBox4.Checked = False
            checkBox5.Checked = False
        ElseIf Not sender Is checkBox5 AndAlso Not sender Is checkBox6 Then
            checkBox5.Checked = False
            checkBox6.Checked = False
        ElseIf Not sender Is checkBox5 Then
            checkBox5.Checked = False
        ElseIf Not sender Is checkBox6 Then
            checkBox6.Checked = False
        End If
        isSetByCode = False

        ' 列幅と行高さの自動調節方法の指定
        Dim colValue As Integer = 0
        Dim rowValue As Integer = 0
        If checkBox1.Checked Then
            ' フッタの除外
            colValue += CInt(FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeFooters)
        End If
        If checkBox2.Checked Then
            ' ヘッダの除外
            colValue += CInt(FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeHeaders)
            rowValue += CInt(FarPoint.Win.Spread.PreferredSizeRowOptions.ExcludeHeaders)
        End If
        If checkBox3.Checked Then
            ' 結合セルの除外
            colValue += CInt(FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeSpans)
            rowValue += CInt(FarPoint.Win.Spread.PreferredSizeRowOptions.ExcludeSpans)
        End If
        If checkBox4.Checked Then
            ' 複数行セルの除外
            colValue += CInt(FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeWordWrap)
        End If
        If checkBox5.Checked Then
            ' すべてを対象
            colValue += CInt(FarPoint.Win.Spread.PreferredSizeColumnOptions.IncludeAll)
            rowValue += CInt(FarPoint.Win.Spread.PreferredSizeRowOptions.IncludeAll)
        End If
        If checkBox6.Checked Then
            ' 自動調整の停止
            colValue += CInt(FarPoint.Win.Spread.PreferredSizeColumnOptions.Off)
            rowValue += CInt(FarPoint.Win.Spread.PreferredSizeRowOptions.Off)
        End If
        FpSpread1.AutoFitColumnOptions = DirectCast(colValue, FarPoint.Win.Spread.PreferredSizeColumnOptions)
        FpSpread1.AutoFitRowOptions = DirectCast(rowValue, FarPoint.Win.Spread.PreferredSizeRowOptions)
    End Sub
End Class
