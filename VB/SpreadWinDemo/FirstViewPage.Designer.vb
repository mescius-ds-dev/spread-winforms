<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstViewPage
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FirstViewPage))
        Me.product_body = New System.Windows.Forms.Label()
        Me.product_title = New System.Windows.Forms.Label()
        Me.product1 = New System.Windows.Forms.Label()
        Me.product2 = New System.Windows.Forms.Label()
        Me.product3 = New System.Windows.Forms.Label()
        Me.mainvisual = New System.Windows.Forms.PictureBox()
        CType(Me.mainvisual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'product_body
        '
        Me.product_body.AutoSize = True
        Me.product_body.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product_body.Location = New System.Drawing.Point(34, 378)
        Me.product_body.Name = "product_body"
        Me.product_body.Size = New System.Drawing.Size(680, 72)
        Me.product_body.TabIndex = 1
        Me.product_body.Text = resources.GetString("product_body.Text")
        '
        'product_title
        '
        Me.product_title.AutoSize = True
        Me.product_title.Font = New System.Drawing.Font("メイリオ", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.product_title.Location = New System.Drawing.Point(32, 350)
        Me.product_title.Name = "product_title"
        Me.product_title.Size = New System.Drawing.Size(648, 23)
        Me.product_title.TabIndex = 1
        Me.product_title.Text = "アプリケーションにExcelと同等のユーザーインタフェースを提供できる表計算コンポーネント"
        '
        'product1
        '
        Me.product1.AutoSize = True
        Me.product1.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product1.Location = New System.Drawing.Point(32, 267)
        Me.product1.Name = "product1"
        Me.product1.Size = New System.Drawing.Size(259, 28)
        Me.product1.TabIndex = 1
        Me.product1.Text = "最強の表計算コンポーネント"
        '
        'product2
        '
        Me.product2.AutoSize = True
        Me.product2.Font = New System.Drawing.Font("メイリオ", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product2.Location = New System.Drawing.Point(29, 295)
        Me.product2.Name = "product2"
        Me.product2.Size = New System.Drawing.Size(147, 48)
        Me.product2.TabIndex = 1
        Me.product2.Text = "SPREAD"
        '
        'product3
        '
        Me.product3.AutoSize = True
        Me.product3.Font = New System.Drawing.Font("メイリオ", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.product3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.product3.Location = New System.Drawing.Point(170, 309)
        Me.product3.Name = "product3"
        Me.product3.Size = New System.Drawing.Size(190, 28)
        Me.product3.TabIndex = 1
        Me.product3.Text = "for Windows Forms"
        '
        'mainvisual
        '
        Me.mainvisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.mainvisual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.mainvisual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainvisual.Image = Global.SpreadWinDemo.My.Resources.Resources.mainvisual
        Me.mainvisual.Location = New System.Drawing.Point(0, 0)
        Me.mainvisual.Name = "mainvisual"
        Me.mainvisual.Size = New System.Drawing.Size(724, 500)
        Me.mainvisual.TabIndex = 0
        Me.mainvisual.TabStop = False
        '
        'FirstViewPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.product3)
        Me.Controls.Add(Me.product2)
        Me.Controls.Add(Me.product1)
        Me.Controls.Add(Me.product_title)
        Me.Controls.Add(Me.product_body)
        Me.Controls.Add(Me.mainvisual)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FirstViewPage"
        Me.Size = New System.Drawing.Size(724, 500)
        CType(Me.mainvisual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents mainvisual As System.Windows.Forms.PictureBox
    Friend WithEvents product_body As System.Windows.Forms.Label
    Private WithEvents product_title As System.Windows.Forms.Label
    Private WithEvents product1 As System.Windows.Forms.Label
    Private WithEvents product2 As System.Windows.Forms.Label
    Private WithEvents product3 As System.Windows.Forms.Label

End Class
