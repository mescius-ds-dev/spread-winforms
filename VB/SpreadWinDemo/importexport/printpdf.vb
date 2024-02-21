Public Class printpdf

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".data50.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 40     ' ID
        sheet.Columns(1).Width = 90     ' 氏名
        sheet.Columns(2).Width = 95     ' カナ
        sheet.Columns(3).Width = 85     ' 生年月日
        sheet.Columns(4).Width = 40     ' 性別
        sheet.Columns(5).Width = 50     ' 血液型
        sheet.Columns(6).Width = 50     ' 部署    
        sheet.Columns(7).Width = 85     ' 入社日
        sheet.Columns(8).Width = 220    ' メールアドレス

        ' 水平位置の設定
        sheet.Columns(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center   ' ID
        sheet.Columns(4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center   ' 性別
        sheet.Columns(5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center   ' 血液型

        Dim pi As New FarPoint.Win.Spread.PrintInfo()

        ' ヘッダに「カラー」「イメージ」を設定します
        pi.Colors = New System.Drawing.Color() {System.Drawing.Color.Purple, System.Drawing.Color.Green, System.Drawing.Color.Indigo}
        Dim s As System.IO.Stream = Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".science.gif")
        pi.Images = New System.Drawing.Image() {System.Drawing.Image.FromStream(s)}
        pi.Header = "/c/fz""20""/cl""0""/fb1/fu0/fi1 SPREAD for Windows Forms "
        pi.Footer = "/fn""Arial""/fz""10""/cl""1""/fb0/fu0/fi0/dl /ds /tl " & "/c/fn""Arial""/fz""10""/cl""2""/p///pc Page /r/fn""Times New Roman""/fz""14""/cl""1""/fb1/fu0/fi1/g""0"""

        pi.ShowColor = True
        pi.Centering = FarPoint.Win.Spread.Centering.Horizontal

        ' マージンの設定
        pi.Margin.Top = 30
        pi.Margin.Left = 5
        pi.Margin.Right = 0
        pi.Margin.Bottom = 70
        pi.Margin.Footer = 10
        pi.Margin.Header = 10

        ' 定義したPrintInfoオブジェクトを設定
        sheet.PrintInfo = pi
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' ファイル保存ダイアログ起動
        Dim fn As String = ""
        Using sfd As New SaveFileDialog()
            sfd.Filter = "PDFファイル(*.pdf)|*.pdf"
            sfd.FileName = "SpreadClickOnceデモ.pdf"
            If sfd.ShowDialog() = DialogResult.OK Then
                fn = sfd.FileName
            Else
                Return
            End If
        End Using

        FpSpread1.Sheets(0).PrintInfo.PrintToPdf = True
        FpSpread1.Sheets(0).PrintInfo.PdfFileName = fn
        FpSpread1.PrintSheet(FpSpread1.Sheets(0))
    End Sub
End Class
