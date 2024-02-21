Public Class datavalidator

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' データ連結
        Dim ds As New DataSet()
        ds.ReadXml(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".datanum2.xml"))
        sheet.DataSource = ds

        ' TextLengthValidatorの設定（1列目）
        Dim lengthValidator As New FarPoint.Win.Spread.TextLengthValidator()
        lengthValidator.MaximumLength = 5
        lengthValidator.MinimumLength = 5
        Dim tipNotify As New FarPoint.Win.Spread.TipNotify()
        tipNotify.ToolTipText = "5桁の文字列を入力してください。"
        lengthValidator.Actions.Add(tipNotify)
        sheet.AddValidators(New FarPoint.Win.Spread.Model.CellRange(0, 0, sheet.RowCount, 1), lengthValidator)

        ' CharFormatValidator（2～3列目）
        Dim formatValidator As New FarPoint.Win.Spread.CharFormatValidator()
        formatValidator.Format = "Ｚ"
        Dim msgNotify = New FarPoint.Win.Spread.MessageBoxNotify()
        msgNotify.Message = "全角で入力してください。"
        formatValidator.Actions.Add(msgNotify)
        sheet.AddValidators(New FarPoint.Win.Spread.Model.CellRange(0, 1, sheet.RowCount, 2), formatValidator)

        ' 列幅の設定
        sheet.Columns(0).Width = 50
        sheet.Columns(1).Width = 100
        sheet.Columns(2).Width = 141
        sheet.Columns(3).Width = 80
        sheet.Columns(4).Width = 80
        sheet.Columns(5).Width = 80
        sheet.Columns(6).Width = 80
    End Sub
End Class
