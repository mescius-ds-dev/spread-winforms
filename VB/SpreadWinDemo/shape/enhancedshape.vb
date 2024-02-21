Public Class enhancedshape

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitWorkbook(FpSpread1.AsWorkbook())
    End Sub

    Private Sub InitWorkbook(workbook As GrapeCity.Spreadsheet.IWorkbook)
        ' 拡張シェイプエンジンを有効
        FpSpread1.Features.EnhancedShapeEngine = True

        ' AddShapeメソッドによるシェイプの追加
        workbook.ActiveSheet.Shapes.AddShape(GrapeCity.Spreadsheet.Drawing.AutoShapeType.Heart, 100, 50, 150, 150)

        ' 行列インデックスを指定したAddShapeToCellメソッドによるシェイプの追加
        Dim sunShape As GrapeCity.Spreadsheet.Drawing.IShape = workbook.ActiveSheet.Shapes.AddShapeToCell(GrapeCity.Spreadsheet.Drawing.AutoShapeType.Sun, 2, 4, 200, 200)
        ' シェイプのスタイルの変更
        sunShape.ShapeStyle = GrapeCity.Spreadsheet.Drawing.ShapeStyle.Preset12

        ' AddConnectorメソッドによるコネクタシェイプの追加
        Dim connectorShape As GrapeCity.Spreadsheet.Drawing.IShape = workbook.ActiveSheet.Shapes.AddConnector(GrapeCity.Spreadsheet.Drawing.ConnectorType.Elbow, 100, 300, 400, 250)
        ' コネクタシェイプの太さの変更
        connectorShape.Line.Weight = 5
    End Sub
End Class
