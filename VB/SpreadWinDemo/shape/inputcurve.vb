Imports FarPoint.Win.Spread

Public Class inputcurve

    Public Sub New()

        InitializeComponent()
    End Sub


    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' 曲線シェイプの入力を開始
        FpSpread1.Features.EnhancedShapeEngine = True
        FpSpread1.StartAnnotationMode(AnnotationMode.Curve)
    End Sub
End Class
