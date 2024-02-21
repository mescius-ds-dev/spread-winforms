Public Class sparkline

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 行列数の設定
        sheet.RowCount = 32
        sheet.ColumnCount = 13
        sheet.RowHeader.ColumnCount = 2

        ' 列幅の設定
        sheet.Columns(0).Width = 120
        sheet.Columns(1, 12).Width = 40
        sheet.RowHeader.Columns(0).Width = 50
        sheet.RowHeader.Columns(1).Width = 100

        ' 行の高さの設定
        sheet.Rows.[Default].Height = 30

        ' 1列目を固定
        sheet.FrozenColumnCount = 1

        ' テストデータの設定
        sheet.ColumnHeaderAutoText = FarPoint.Win.Spread.HeaderAutoText.Blank
        For i As Integer = 1 To sheet.ColumnCount - 1
            sheet.ColumnHeader.Cells(0, i).Value = i.ToString() & "月"
        Next

        sheet.RowHeaderAutoText = FarPoint.Win.Spread.HeaderAutoText.Blank
        For i As Integer = 0 To sheet.RowCount - 1
            If i Mod 2 = 0 Then
                sheet.RowHeader.Cells(i, 1).Value = "平均気温( °C)"
                sheet.RowHeader.Cells(i, 0).RowSpan = 2
            Else
                sheet.RowHeader.Cells(i, 1).Value = "降水量(mm)"
            End If
        Next
        sheet.RowHeader.Cells(0, 0).Value = "札幌"
        sheet.RowHeader.Cells(2, 0).Value = "仙台"
        sheet.RowHeader.Cells(4, 0).Value = "新潟"
        sheet.RowHeader.Cells(6, 0).Value = "東京"
        sheet.RowHeader.Cells(8, 0).Value = "長野"
        sheet.RowHeader.Cells(10, 0).Value = "静岡"
        sheet.RowHeader.Cells(12, 0).Value = "名古屋"
        sheet.RowHeader.Cells(14, 0).Value = "大阪"
        sheet.RowHeader.Cells(16, 0).Value = "京都"
        sheet.RowHeader.Cells(18, 0).Value = "広島"
        sheet.RowHeader.Cells(20, 0).Value = "高知"
        sheet.RowHeader.Cells(22, 0).Value = "山口"
        sheet.RowHeader.Cells(24, 0).Value = "福岡"
        sheet.RowHeader.Cells(26, 0).Value = "長崎"
        sheet.RowHeader.Cells(28, 0).Value = "鹿児島"
        sheet.RowHeader.Cells(30, 0).Value = "那覇"

        sheet.SetClip(0, 1, 1, 12, "-4.7" & vbTab & "-4" & vbTab & "0" & vbTab & "6.3" & vbTab & "11.3" & vbTab & "17.6" & vbTab & "22.5" & vbTab & "23.1" & vbTab & "18.8" & vbTab & "12.9" & vbTab & "6.3" & vbTab & "0.8")
        sheet.SetClip(1, 1, 1, 12, "101.5" & vbTab & "117" & vbTab & "108" & vbTab & "115" & vbTab & "61.5" & vbTab & "62" & vbTab & "54.5" & vbTab & "183.5" & vbTab & "173" & vbTab & "131" & vbTab & "116" & vbTab & "124")
        sheet.SetClip(2, 1, 1, 12, "0.7" & vbTab & "1.1" & vbTab & "5.8" & vbTab & "10.2" & vbTab & "14.4" & vbTab & "19" & vbTab & "22.2" & vbTab & "25.6" & vbTab & "21.9" & vbTab & "16.7" & vbTab & "9.6" & vbTab & "4.7")
        sheet.SetClip(3, 1, 1, 12, "37" & vbTab & "18.5" & vbTab & "3" & vbTab & "118.5" & vbTab & "27.5" & vbTab & "92" & vbTab & "257.5" & vbTab & "88.5" & vbTab & "210.5" & vbTab & "179.5" & vbTab & "14" & vbTab & "65")
        sheet.SetClip(4, 1, 1, 12, "1.8" & vbTab & "1.5" & vbTab & "6" & vbTab & "10.1" & vbTab & "16.3" & vbTab & "22.1" & vbTab & "25.1" & vbTab & "26.9" & vbTab & "22.9" & vbTab & "18.3" & vbTab & "9.8" & vbTab & "5.2")
        sheet.SetClip(5, 1, 1, 12, "148.5" & vbTab & "93.5" & vbTab & "93.5" & vbTab & "142" & vbTab & "50" & vbTab & "93.5" & vbTab & "413" & vbTab & "264.5" & vbTab & "165" & vbTab & "176" & vbTab & "416" & vbTab & "271.5")
        sheet.SetClip(6, 1, 1, 12, "5.5" & vbTab & "6.2" & vbTab & "12.1" & vbTab & "15.2" & vbTab & "19.8" & vbTab & "22.9" & vbTab & "27.3" & vbTab & "29.2" & vbTab & "25.2" & vbTab & "19.8" & vbTab & "13.5" & vbTab & "8.3")
        sheet.SetClip(7, 1, 1, 12, "70" & vbTab & "30" & vbTab & "44.5" & vbTab & "283" & vbTab & "56" & vbTab & "159" & vbTab & "115.5" & vbTab & "99" & vbTab & "231.5" & vbTab & "440" & vbTab & "26" & vbTab & "59.5")
        sheet.SetClip(8, 1, 1, 12, "-1.1" & vbTab & "-0.7" & vbTab & "5.6" & vbTab & "9.5" & vbTab & "16.2" & vbTab & "21.2" & vbTab & "24.7" & vbTab & "25.4" & vbTab & "21.2" & vbTab & "16.4" & vbTab & "7.5" & vbTab & "2")
        sheet.SetClip(9, 1, 1, 12, "48.5" & vbTab & "46.5" & vbTab & "19.5" & vbTab & "75" & vbTab & "33" & vbTab & "126.5" & vbTab & "99" & vbTab & "234.5" & vbTab & "221" & vbTab & "148" & vbTab & "29.5" & vbTab & "56.5")
        sheet.SetClip(10, 1, 1, 12, "5.7" & vbTab & "7.3" & vbTab & "13.3" & vbTab & "15.4" & vbTab & "19.2" & vbTab & "22.6" & vbTab & "26.4" & vbTab & "28.4" & vbTab & "25.4" & vbTab & "21.1" & vbTab & "13.1" & vbTab & "8.2")
        sheet.SetClip(11, 1, 1, 12, "80.5" & vbTab & "120" & vbTab & "101.5" & vbTab & "269" & vbTab & "181" & vbTab & "163.5" & vbTab & "128" & vbTab & "89.5" & vbTab & "227" & vbTab & "298" & vbTab & "104.5" & vbTab & "59.5")
        sheet.SetClip(12, 1, 1, 12, "4" & vbTab & "4.6" & vbTab & "10.5" & vbTab & "13.8" & vbTab & "19.4" & vbTab & "23.6" & vbTab & "28.1" & vbTab & "29.3" & vbTab & "24.9" & vbTab & "20.2" & vbTab & "11.5" & vbTab & "6.4")
        sheet.SetClip(13, 1, 1, 12, "51.5" & vbTab & "68.5" & vbTab & "54" & vbTab & "130.5" & vbTab & "63.5" & vbTab & "148.5" & vbTab & "186.5" & vbTab & "136" & vbTab & "280" & vbTab & "236" & vbTab & "51" & vbTab & "57.5")
        sheet.SetClip(14, 1, 1, 12, "5.2" & vbTab & "5.6" & vbTab & "10.7" & vbTab & "14.3" & vbTab & "19.8" & vbTab & "24.3" & vbTab & "28.5" & vbTab & "30" & vbTab & "25.1" & vbTab & "20.8" & vbTab & "12.9" & vbTab & "7.8")
        sheet.SetClip(15, 1, 1, 12, "38.5" & vbTab & "92.5" & vbTab & "92" & vbTab & "108" & vbTab & "44" & vbTab & "266" & vbTab & "50" & vbTab & "128" & vbTab & "258.5" & vbTab & "210.5" & vbTab & "80.5" & vbTab & "49.5")
        sheet.SetClip(16, 1, 1, 12, "3.9" & vbTab & "4.5" & vbTab & "9.7" & vbTab & "13.4" & vbTab & "19.2" & vbTab & "24.1" & vbTab & "28" & vbTab & "29.2" & vbTab & "24.3" & vbTab & "20" & vbTab & "11.5" & vbTab & "6.3")
        sheet.SetClip(17, 1, 1, 12, "41" & vbTab & "96" & vbTab & "65.5" & vbTab & "109.5" & vbTab & "38" & vbTab & "173.5" & vbTab & "140" & vbTab & "102" & vbTab & "358" & vbTab & "217.5" & vbTab & "50" & vbTab & "59.5")
        sheet.SetClip(18, 1, 1, 12, "4.4" & vbTab & "6" & vbTab & "10.7" & vbTab & "13.5" & vbTab & "19.7" & vbTab & "24" & vbTab & "28.3" & vbTab & "29.5" & vbTab & "24.6" & vbTab & "19.9" & vbTab & "11.9" & vbTab & "6.5")
        sheet.SetClip(19, 1, 1, 12, "43.5" & vbTab & "93.5" & vbTab & "90" & vbTab & "100.5" & vbTab & "125.5" & vbTab & "329.5" & vbTab & "175.5" & vbTab & "238" & vbTab & "224.5" & vbTab & "295" & vbTab & "58.5" & vbTab & "46.5")
        sheet.SetClip(20, 1, 1, 12, "5.8" & vbTab & "7.8" & vbTab & "12.7" & vbTab & "14.8" & vbTab & "19.9" & vbTab & "23.2" & vbTab & "28.1" & vbTab & "29" & vbTab & "24.9" & vbTab & "20.7" & vbTab & "12.9" & vbTab & "7.4")
        sheet.SetClip(21, 1, 1, 12, "39" & vbTab & "132.5" & vbTab & "82.5" & vbTab & "243" & vbTab & "177.5" & vbTab & "306.5" & vbTab & "113.5" & vbTab & "85.5" & vbTab & "377.5" & vbTab & "579.5" & vbTab & "94.5" & vbTab & "95.5")
        sheet.SetClip(22, 1, 1, 12, "3.8" & vbTab & "5.6" & vbTab & "10" & vbTab & "12.7" & vbTab & "19.1" & vbTab & "23.2" & vbTab & "27.6" & vbTab & "28.6" & vbTab & "23.6" & vbTab & "18.9" & vbTab & "11" & vbTab & "5.5")
        sheet.SetClip(23, 1, 1, 12, "63.5" & vbTab & "107" & vbTab & "89" & vbTab & "153.5" & vbTab & "143.5" & vbTab & "357" & vbTab & "508" & vbTab & "325" & vbTab & "173.5" & vbTab & "203" & vbTab & "79" & vbTab & "65")
        sheet.SetClip(24, 1, 1, 12, "6.1" & vbTab & "7.8" & vbTab & "12.3" & vbTab & "14.7" & vbTab & "20.3" & vbTab & "23.7" & vbTab & "30" & vbTab & "30" & vbTab & "25.2" & vbTab & "20.7" & vbTab & "13.4" & vbTab & "8.1")
        sheet.SetClip(25, 1, 1, 12, "57.5" & vbTab & "81.5" & vbTab & "56.5" & vbTab & "108" & vbTab & "37" & vbTab & "268.5" & vbTab & "134" & vbTab & "501.5" & vbTab & "133" & vbTab & "227.5" & vbTab & "119.5" & vbTab & "77")
        sheet.SetClip(26, 1, 1, 12, "6.3" & vbTab & "8.1" & vbTab & "12.2" & vbTab & "14.6" & vbTab & "20" & vbTab & "23.7" & vbTab & "28.3" & vbTab & "29.3" & vbTab & "25.1" & vbTab & "20.8" & vbTab & "13.3" & vbTab & "8.3")
        sheet.SetClip(27, 1, 1, 12, "37.5" & vbTab & "148.5" & vbTab & "91.5" & vbTab & "148.5" & vbTab & "126" & vbTab & "224" & vbTab & "10.5" & vbTab & "198.5" & vbTab & "160" & vbTab & "249.5" & vbTab & "210.5" & vbTab & "78.5")
        sheet.SetClip(28, 1, 1, 12, "7.9" & vbTab & "10.3" & vbTab & "14.1" & vbTab & "16.3" & vbTab & "21.4" & vbTab & "24.6" & vbTab & "29.4" & vbTab & "30" & vbTab & "26.8" & vbTab & "22.5" & vbTab & "14.6" & vbTab & "9.3")
        sheet.SetClip(29, 1, 1, 12, "70" & vbTab & "199.5" & vbTab & "80.5" & vbTab & "120.5" & vbTab & "54.5" & vbTab & "426" & vbTab & "16.5" & vbTab & "93" & vbTab & "343.5" & vbTab & "154" & vbTab & "114.5" & vbTab & "105")
        sheet.SetClip(30, 1, 1, 12, "17" & vbTab & "18.6" & vbTab & "20.4" & vbTab & "20.6" & vbTab & "23.7" & vbTab & "27.9" & vbTab & "29.4" & vbTab & "29.6" & vbTab & "28.3" & vbTab & "25.3" & vbTab & "21.3" & vbTab & "17.3")
        sheet.SetClip(31, 1, 1, 12, "100" & vbTab & "75" & vbTab & "140.5" & vbTab & "202.5" & vbTab & "602.5" & vbTab & "105" & vbTab & "4.5" & vbTab & "212" & vbTab & "178" & vbTab & "200" & vbTab & "121" & vbTab & "130")

        ' スパークライン（折れ線）の設定
        Dim esg1 As New FarPoint.Win.Spread.ExcelSparklineGroup(New FarPoint.Win.Spread.ExcelSparklineSetting(), FarPoint.Win.Spread.SparklineType.Line)
        Dim ex1 As New FarPoint.Win.Spread.ExcelSparklineSetting()
        ex1.ManualMax = 30
        ex1.ManualMin = -5
        ex1.SeriesColor = System.Drawing.Color.Green
        esg1.Setting = ex1

        For i = 0 To sheet.RowCount - 1 Step 2
            Dim es1 As New FarPoint.Win.Spread.ExcelSparkline(i, 0, sheet, New FarPoint.Win.Spread.Model.CellRange(i, 1, 1, 12))
            esg1.Add(es1)
        Next

        sheet.SparklineContainer.Add(esg1)

        ' スパークライン（縦棒）の設定
        Dim esg2 As New FarPoint.Win.Spread.ExcelSparklineGroup(New FarPoint.Win.Spread.ExcelSparklineSetting(), FarPoint.Win.Spread.SparklineType.Column)
        Dim ex2 As New FarPoint.Win.Spread.ExcelSparklineSetting()
        ex2.ManualMax = 300
        ex2.ManualMin = 0
        ex2.SeriesColor = System.Drawing.Color.CornflowerBlue
        esg2.Setting = ex2


        For i = 1 To sheet.RowCount - 1 Step 2
            Dim es2 As New FarPoint.Win.Spread.ExcelSparkline(i, 0, sheet, New FarPoint.Win.Spread.Model.CellRange(i, 1, 1, 12))
            esg2.Add(es2)
        Next

        sheet.SparklineContainer.Add(esg2)
    End Sub
End Class
