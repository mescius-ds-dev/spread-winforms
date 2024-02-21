Public Class addshape

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' シェイプの追加
        Dim arrow As New FarPoint.Win.Spread.DrawingSpace.ArrowShape()
        arrow.Name = "arrow"
        arrow.BackColor = Color.Red
        arrow.AlphaBlendBackColor = 90
        arrow.ShadowColor = Color.Blue
        arrow.AlphaBlendShadowColor = 90
        arrow.ShadowDirection = FarPoint.Win.Spread.DrawingSpace.ShadowDirection.BottomRight
        arrow.SetBounds(320, 60, 90, 60)
        sheet.AddShape(arrow)

        Dim rect1 As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()
        rect1.Name = "rect101"
        rect1.BackColor = Color.FromArgb(91, 155, 213)
        rect1.ForeColor = Color.White
        rect1.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        rect1.Text = "取締役社長"
        rect1.Font = New Font("メイリオ", 12)
        rect1.CanRenderText = True
        rect1.SetBounds(240, 200, 120, 60)
        sheet.AddShape(rect1)

        Dim rect2 As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()
        rect2.Name = "rect102"
        rect2.BackColor = Color.FromArgb(91, 155, 213)
        rect2.ForeColor = Color.White
        rect2.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        rect2.Text = "営業部"
        rect2.Font = New Font("メイリオ", 12)
        rect2.CanRenderText = True
        rect2.SetBounds(60, 300, 120, 60)
        sheet.AddShape(rect2)

        Dim rect3 As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()
        rect3.Name = "rect103"
        rect3.BackColor = Color.FromArgb(91, 155, 213)
        rect3.ForeColor = Color.White
        rect3.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        rect3.Text = "経理部"
        rect3.Font = New Font("メイリオ", 12)
        rect3.CanRenderText = True
        rect3.SetBounds(240, 300, 120, 60)
        sheet.AddShape(rect3)

        Dim rect4 As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()
        rect4.Name = "rect104"
        rect4.BackColor = Color.FromArgb(91, 155, 213)
        rect4.ForeColor = Color.White
        rect4.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        rect4.Text = "総務部"
        rect4.Font = New Font("メイリオ", 12)
        rect4.CanRenderText = True
        rect4.SetBounds(420, 300, 120, 60)
        sheet.AddShape(rect4)

        Dim line1 As New FarPoint.Win.Spread.DrawingSpace.LineShape()
        line1.Name = "line101"
        line1.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        line1.ShapeOutlineThickness = 3
        line1.SetBounds(120, 280, 360, 0)
        sheet.AddShape(line1)

        Dim line2 As New FarPoint.Win.Spread.DrawingSpace.LineShape()
        line2.Name = "line102"
        line2.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        line2.ShapeOutlineThickness = 3
        line2.SetBounds(300, 260, 0, 20)
        sheet.AddShape(line2)

        Dim line3 As New FarPoint.Win.Spread.DrawingSpace.LineShape()
        line3.Name = "line103"
        line3.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        line3.ShapeOutlineThickness = 3
        line3.SetBounds(120, 280, 0, 20)
        sheet.AddShape(line3)

        Dim line4 As New FarPoint.Win.Spread.DrawingSpace.LineShape()
        line4.Name = "line104"
        line4.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        line4.ShapeOutlineThickness = 3
        line4.SetBounds(300, 280, 0, 20)
        sheet.AddShape(line4)

        Dim line5 As New FarPoint.Win.Spread.DrawingSpace.LineShape()
        line5.Name = "line105"
        line5.ShapeOutlineColor = Color.FromArgb(65, 113, 156)
        line5.ShapeOutlineThickness = 3
        line5.SetBounds(480, 280, 0, 20)
        sheet.AddShape(line5)
    End Sub
End Class
