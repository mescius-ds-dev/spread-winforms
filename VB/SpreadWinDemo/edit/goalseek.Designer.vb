<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class goalseek
    Inherits SpreadWinDemo.DemoBase

    'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FpSpread1)
        Me.SplitContainer1.Size = New System.Drawing.Size(708, 400)
        Me.SplitContainer1.SplitterDistance = 30
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(708, 30)
        Me.SplitContainer2.SplitterDistance = 233
        Me.SplitContainer2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "毎月返済希望額："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer3.Size = New System.Drawing.Size(471, 30)
        Me.SplitContainer3.SplitterDistance = 231
        Me.SplitContainer3.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(231, 25)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "30000"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "試算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(708, 366)
        Me.FpSpread1.TabIndex = 0
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        '
        'goalseek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "ゴールシークは数式の逆算機能です。 数式の結果が目的の値になるように、数式が参照している値を逆算することができます。"
        Me.Name = "goalseek"
        Me.Title = "ゴールシーク"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView

End Class
