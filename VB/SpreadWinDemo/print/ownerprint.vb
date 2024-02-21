Public Class ownerprint

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シート設定
        InitSpreadStyles1(FpSpread1.Sheets(0))
        InitSpreadStyles2(FpSpread1.Sheets(1))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        ' シート追加
        Dim sht As New FarPoint.Win.Spread.SheetView()
        spread.Sheets.Add(sht)
    End Sub

    Private Sub InitSpreadStyles1(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".datapln.xml"))
        sheet.DataSource = ds
        sheet.SheetName = "計画シート"

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next
    End Sub

    Private Sub InitSpreadStyles2(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".datares.xml"))
        sheet.DataSource = ds
        sheet.SheetName = "実績シート"

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 70
        sheet.Columns(2).Width = 130
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next
    End Sub

    Private Function CreatePrintPage() As System.Drawing.Printing.PrintDocument
        ' PrintDocumentの生成
        Dim pd As New System.Drawing.Printing.PrintDocument()
        AddHandler pd.PrintPage, AddressOf pd_PrintPage

        ' 用紙の指定
        Dim ps As System.Drawing.Printing.PrinterSettings = pd.PrinterSettings
        Dim sizeA4 As System.Drawing.Printing.PaperSize = Nothing
        For i As Integer = 0 To ps.PaperSizes.Count - 1
            If ps.PaperSizes(i).Kind = System.Drawing.Printing.PaperKind.A4 Then
                sizeA4 = ps.PaperSizes(i)
                Exit For
            End If
        Next
        pd.DefaultPageSettings.PaperSize = sizeA4
        pd.DefaultPageSettings.Landscape = True
        pd.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)

        ' 戻り値の設定
        Return pd
    End Function

    Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
        ' PrintDocumentの生成
        Dim pd As System.Drawing.Printing.PrintDocument = Me.CreatePrintPage()

        ' 印刷
        pd.Print()
    End Sub

    Private Sub button2_Click(sender As Object, e As System.EventArgs) Handles button2.Click
        ' PrintDocumentの生成
        Dim pd As System.Drawing.Printing.PrintDocument = Me.CreatePrintPage()

        ' 印刷プレビューダイアログの表示
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = pd
        ppd.ShowDialog()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        ' 表題の描画領域の取得
        Dim rect0 As New Rectangle(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, 50)

        ' 表題の描画
        e.Graphics.DrawString("計画と実績", New Font("メイリオ", 20, FontStyle.Bold), Brushes.Blue, rect0)

        ' 計画シートの描画領域の取得
        Dim rect1 As New Rectangle(e.MarginBounds.X, e.MarginBounds.Y + 50, e.MarginBounds.Width, 250)

        ' 計画シートの描画
        If FpSpread1.GetOwnerPrintPageCount(e.Graphics, rect1, 0) = 1 Then
            FpSpread1.OwnerPrintDraw(e.Graphics, rect1, 0, 1)
            e.HasMorePages = False
        End If

        ' 実績シートの描画領域の取得
        Dim rect2 As New Rectangle(e.MarginBounds.X, e.MarginBounds.Y + 300, e.MarginBounds.Width, 300)

        ' 実績シートの描画
        If FpSpread1.GetOwnerPrintPageCount(e.Graphics, rect2, 1) = 1 Then
            FpSpread1.OwnerPrintDraw(e.Graphics, rect2, 1, 1)
            e.HasMorePages = False
        End If
    End Sub
End Class
