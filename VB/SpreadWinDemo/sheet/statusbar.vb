Public Class statusbar
    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".databind.xml"))
        sheet.DataSource = ds

        ' 列幅の設定
        sheet.Columns(0).Width = 45
        sheet.Columns(1).Width = 85
        sheet.Columns(2).Width = 140
        For i As Integer = 3 To sheet.ColumnCount - 1
            sheet.Columns(i).Width = 65
        Next

        ' ステータスバーの表示
        FpSpread1.StatusBarVisible = True

        ' ステータスバーのスタイル設定
        FpSpread1.StatusBar.BackColor = Color.LemonChiffon
        FpSpread1.StatusBar.ZoomSliderColor = Color.Turquoise
        FpSpread1.StatusBar.ForeColor = Color.OliveDrab
        FpSpread1.StatusBar.ZoomButtonHoverColor = Color.Gold
        FpSpread1.StatusBar.ZoomSliderTrackColor = Color.DodgerBlue
        FpSpread1.StatusBar.ZoomSliderHoverColor = Color.BurlyWood

        ' ステータスバーのすべての項目を表示
        ' ステータスバーを右クリックして表示されるコンテキストメニューから各項目の表示と非表示を設定できます
        For i As Integer = 0 To FpSpread1.StatusBar.Elements.Count - 1
            FpSpread1.StatusBar.Elements(i).Visible = True
            'Console.WriteLine(FpSpread1.StatusBar.Elements(i).GetType())
        Next
    End Sub
End Class
