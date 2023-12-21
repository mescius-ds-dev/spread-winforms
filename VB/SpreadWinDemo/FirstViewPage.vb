Public Class FirstViewPage

    Public Sub New()

        ' この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Private Sub FirstViewPage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' ラベルの背景をPictureBoxコントロールに対して透過にする
        mainvisual.Controls.Add(product1)
        mainvisual.Controls.Add(product2)
        mainvisual.Controls.Add(product3)
        mainvisual.Controls.Add(product_body)
        mainvisual.Controls.Add(product_title)
    End Sub

End Class
