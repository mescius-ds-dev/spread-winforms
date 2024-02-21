Public Class border

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 行列数の設定
        sheet.RowCount = 10
        sheet.ColumnCount = 5

        ' 列幅の設定
        sheet.Columns(1).Width = 120
        sheet.Columns(3).Width = 120

        ' 行の高さの設定
        sheet.Rows(1).Height = 30
        sheet.Rows(3).Height = 30
        sheet.Rows(5).Height = 30
        sheet.Rows(7).Height = 30

        ' ベベル罫線（凹）の設定
        Dim bevelbrdr1 As New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered, SystemColors.ControlLightLight, SystemColors.ControlDark, 3, True, True, True, True)
        sheet.Cells(1, 1).Border = bevelbrdr1
        sheet.Cells(1, 1).Value = "ベベル罫線（凹）"

        ' ベベル罫線（凸）の設定
        Dim bevelbrdr2 As New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Raised, SystemColors.ControlLightLight, SystemColors.ControlDark, 3, True, True, True, True)
        sheet.Cells(3, 1).Border = bevelbrdr2
        sheet.Cells(3, 1).Value = "ベベル罫線（凸）"

        ' 複合罫線の設定
        Dim cbs1 As New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.ThickLine, Color.Red)
        Dim cbs2 As New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.DoubleLine, Color.Blue)
        Dim cbs3 As New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.DashDot, Color.Green)
        Dim cbs4 As New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumDashed, Color.Yellow)
        Dim cbrdr As New FarPoint.Win.ComplexBorder(cbs1, cbs2, cbs3, cbs4)
        sheet.Cells(5, 1).Border = cbrdr
        sheet.Cells(5, 1).Value = "複合罫線"

        ' 合成罫線の設定
        Dim cbside1 As New FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumDashed)
        Dim cbside2 As New FarPoint.Win.ComplexBorderSide()
        Dim cblb As New FarPoint.Win.ComplexBorder(cbside1)
        Dim cbtb As New FarPoint.Win.ComplexBorder(cbside2)
        Dim compoundbrdr As New FarPoint.Win.CompoundBorder(cblb, cbtb, 3, Color.Red)
        sheet.Cells(1, 3).Border = compoundbrdr
        sheet.Cells(1, 3).Value = "合成罫線"

        ' 二重罫線の設定
        Dim dblbrd As New FarPoint.Win.DoubleLineBorder(Color.Green)
        sheet.Cells(3, 3).Border = dblbrd
        sheet.Cells(3, 3).Value = "二重罫線"

        ' 標準罫線の設定
        Dim lbbrd As New FarPoint.Win.LineBorder(Color.Red, 2)
        sheet.Cells(5, 3).Border = lbbrd
        sheet.Cells(5, 3).Value = "標準罫線"

        ' 角丸罫線の設定
        Dim rlbrd As New FarPoint.Win.RoundedLineBorder(Color.Blue, 2)
        sheet.Cells(7, 3).Border = rlbrd
        sheet.Cells(7, 3).Value = "角丸罫線"
    End Sub
End Class
