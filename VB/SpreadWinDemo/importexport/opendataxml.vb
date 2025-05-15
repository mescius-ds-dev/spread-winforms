Public Class opendataxml

    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' XMLデータの読込
        Dim iWorkbook As GrapeCity.Spreadsheet.IWorkbook = FpSpread1.AsWorkbook().WorkbookSet.Workbooks.OpenXML(Me.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name & ".DataFormat.xml"))
        FpSpread1.Attach(iWorkbook)
    End Sub
End Class
