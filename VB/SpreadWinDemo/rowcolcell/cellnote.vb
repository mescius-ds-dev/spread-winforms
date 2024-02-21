Public Class cellnote

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

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

        ' セルノートの設定
        sheet.AllowNoteEdit = True
        sheet.Cells(1, 1).NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote
        sheet.Cells(1, 1).Note = "セルのデータとは別に、メモなどを表示することができます。"

        ' セルノートのスタイルの設定
        Dim nsinfo As New FarPoint.Win.Spread.DrawingSpace.StickyNoteStyleInfo()
        nsinfo.Width = 300
        nsinfo.Height = 100
        nsinfo.MarginTop = 10
        nsinfo.MarginLeft = 10
        nsinfo.Top = 20
        nsinfo.Left = 20
        nsinfo.Font = New System.Drawing.Font("メイリオ", 10)
        FpSpread1.ActiveSheet.SetStickyNoteStyleInfo(1, 1, nsinfo)
    End Sub
End Class
