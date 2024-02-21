Public Class backcolorrotation

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 行列数の設定
        sheet.RowCount = 11
        sheet.ColumnCount = 8

        ' テストデータの設定
        sheet.SetClip(0, 0, 1, 8, "店舗" & vbTab & "4月" & vbTab & "5月" & vbTab & "6月" & vbTab & "7月" & vbTab & "8月" & vbTab & "9月" & vbTab & "合計")
        sheet.SetClip(1, 0, 1, 7, "本店" & vbTab & "72623" & vbTab & "81731" & vbTab & "76801" & vbTab & "55815" & vbTab & "20603" & vbTab & "55887")
        sheet.SetClip(2, 0, 1, 7, "中町店" & vbTab & "24866" & vbTab & "11074" & vbTab & "46700" & vbTab & "77159" & vbTab & "65751" & vbTab & "43277")
        sheet.SetClip(3, 0, 1, 7, "駅前店" & vbTab & "77108" & vbTab & "40415" & vbTab & "16599" & vbTab & "98503" & vbTab & "10900" & vbTab & "30667")
        sheet.SetClip(4, 0, 1, 7, "二丁目店" & vbTab & "29351" & vbTab & "69757" & vbTab & "86497" & vbTab & "19848" & vbTab & "56048" & vbTab & "18057")
        sheet.SetClip(5, 0, 1, 7, "南町店" & vbTab & "81593" & vbTab & "99098" & vbTab & "56396" & vbTab & "41192" & vbTab & "1197" & vbTab & "5447")
        sheet.SetClip(6, 0, 1, 7, "中央通り店" & vbTab & "33836" & vbTab & "28441" & vbTab & "26296" & vbTab & "62536" & vbTab & "46345" & vbTab & "92836")
        sheet.SetClip(7, 0, 1, 7, "モール店" & vbTab & "86078" & vbTab & "57783" & vbTab & "96194" & vbTab & "83881" & vbTab & "91493" & vbTab & "80226")
        sheet.SetClip(8, 0, 1, 7, "パーク店" & vbTab & "38321" & vbTab & "87124" & vbTab & "66093" & vbTab & "5226" & vbTab & "36642" & vbTab & "67616")
        sheet.SetClip(9, 0, 1, 7, "ガーデン店" & vbTab & "90563" & vbTab & "16467" & vbTab & "35992" & vbTab & "26570" & vbTab & "81791" & vbTab & "55006")
        sheet.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        sheet.Cells(0, 0).ForeColor = Color.FromArgb(129, 133, 139)
        sheet.Cells(0, 0).Font = New Font("メイリオ", 12)

        ' テキストおよび背景色の回転
        sheet.EnableDiagonalLine = True
        Dim tcell As New FarPoint.Win.Spread.CellType.TextCellType()
        tcell.TextRotationAngle = 45
        tcell.TextOrientation = FarPoint.Win.TextOrientation.TextRotateCustom
        sheet.Cells(0, 1, 0, 7).CellType = tcell
        sheet.Cells(0, 1).BackColor = Color.FromArgb(65, 138, 179)
        sheet.Cells(0, 1).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(65, 138, 179)))
        sheet.Cells(0, 2).BackColor = Color.FromArgb(167, 183, 43)
        sheet.Cells(0, 2).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(167, 183, 43)))
        sheet.Cells(0, 3).BackColor = Color.FromArgb(246, 146, 0)
        sheet.Cells(0, 3).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(246, 146, 0)))
        sheet.Cells(0, 4).BackColor = Color.FromArgb(131, 131, 132)
        sheet.Cells(0, 4).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(131, 131, 132)))
        sheet.Cells(0, 5).BackColor = Color.FromArgb(253, 196, 10)
        sheet.Cells(0, 5).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(253, 196, 10)))
        sheet.Cells(0, 6).BackColor = Color.FromArgb(223, 84, 39)
        sheet.Cells(0, 6).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(223, 84, 39)))
        sheet.Cells(0, 7).BackColor = Color.FromArgb(65, 138, 179)
        sheet.Cells(0, 7).Border = New FarPoint.Win.ComplexBorder(New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(65, 138, 179)))
        sheet.Cells(1, 1, 10, 1).BackColor = Color.FromArgb(215, 231, 240)
        sheet.Cells(1, 2, 10, 2).BackColor = Color.FromArgb(242, 245, 208)
        sheet.Cells(1, 3, 10, 3).BackColor = Color.FromArgb(254, 233, 202)
        sheet.Cells(1, 4, 10, 4).BackColor = Color.FromArgb(229, 230, 230)
        sheet.Cells(1, 5, 10, 5).BackColor = Color.FromArgb(247, 242, 205)
        sheet.Cells(1, 6, 10, 6).BackColor = Color.FromArgb(248, 220, 211)
        sheet.Cells(1, 7, 10, 7).BackColor = Color.FromArgb(215, 231, 240)

        ' 合計の計算
        Dim currcell As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        currcell.ShowSeparator = True
        sheet.Cells(1, 1, 10, 7).CellType = currcell
        sheet.Cells(1, 7).Formula = "SUM(B2:G2)"
        sheet.Cells(2, 7).Formula = "SUM(B3:G3)"
        sheet.Cells(3, 7).Formula = "SUM(B4:G4)"
        sheet.Cells(4, 7).Formula = "SUM(B5:G5)"
        sheet.Cells(5, 7).Formula = "SUM(B6:G6)"
        sheet.Cells(6, 7).Formula = "SUM(B7:G7)"
        sheet.Cells(7, 7).Formula = "SUM(B8:G8)"
        sheet.Cells(8, 7).Formula = "SUM(B9:G9)"
        sheet.Cells(9, 7).Formula = "SUM(B10:G10)"
        sheet.Cells(10, 1).Formula = "SUM(B2:B10)"
        sheet.Cells(10, 2).Formula = "SUM(C2:C10)"
        sheet.Cells(10, 3).Formula = "SUM(D2:D10)"
        sheet.Cells(10, 4).Formula = "SUM(E2:E10)"
        sheet.Cells(10, 5).Formula = "SUM(F2:F10)"
        sheet.Cells(10, 6).Formula = "SUM(G2:G10)"
        sheet.Cells(10, 7).Formula = "SUM(H2:H10)"
        sheet.Cells(10, 0).Value = "合計"
        sheet.FrozenTrailingRowCount = 1

        ' 行高列幅の設定
        sheet.Rows(0).Height = 30
        sheet.Rows(1, 10).Height = 30
        sheet.Columns(0).Width = 90
        sheet.Columns(1, 7).Width = 80
    End Sub
End Class
