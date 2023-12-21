Public Class DemoBase_settings

    Public Sub New()

        ' この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Public Property Title() As String
        Get
            Return Me.lblTitle.Text
        End Get
        Set(ByVal value As String)
            Me.lblTitle.Text = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return Me.lblDescription.Text
        End Get
        Set(ByVal value As String)
            Me.lblDescription.Text = value
        End Set
    End Property

End Class
