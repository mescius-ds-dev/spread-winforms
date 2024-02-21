Imports GrapeCity.Spreadsheet.Drawing

Public Class add3dshape

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.Features.EnhancedShapeEngine = True

        ' 3D回転なし
        Dim s1 As IShape = FpSpread1.AsWorkbook().ActiveSheet.Shapes.AddShape(AutoShapeType.CurvedDownArrow, 20, 20, 100, 100)

        ' 3D回転あり
        Dim s2 As IShape = FpSpread1.AsWorkbook().ActiveSheet.Shapes.AddShape(AutoShapeType.CurvedDownArrow, 200, 20, 100, 100)
        Dim threeDFormat2 As IThreeDFormat = s2.ThreeD
        threeDFormat2.RotationX = 30D
        threeDFormat2.RotationY = 50D
        threeDFormat2.RotationZ = 70D
    End Sub
End Class
