<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dragdrop
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
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.FpSpread2 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread2_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread2_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FpSpread1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(708, 400)
        Me.SplitContainer1.SplitterDistance = 352
        Me.SplitContainer1.TabIndex = 0
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread1_Sheet1})
        Me.FpSpread1.Size = New System.Drawing.Size(352, 400)
        Me.FpSpread1.TabIndex = 0
        '
        'FpSpread1_Sheet1
        '
        Me.FpSpread1_Sheet1.Reset()
        Me.FpSpread1_Sheet1.SheetName = "Sheet1"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.FpSpread2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(352, 400)
        Me.SplitContainer2.SplitterDistance = 285
        Me.SplitContainer2.TabIndex = 0
        '
        'FpSpread2
        '
        Me.FpSpread2.AccessibleDescription = ""
        Me.FpSpread2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread2.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread2.Name = "FpSpread2"
        Me.FpSpread2.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpSpread2_Sheet1})
        Me.FpSpread2.Size = New System.Drawing.Size(352, 285)
        Me.FpSpread2.TabIndex = 0
        '
        'FpSpread2_Sheet1
        '
        Me.FpSpread2_Sheet1.Reset()
        Me.FpSpread2_Sheet1.SheetName = "Sheet1"
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(352, 111)
        Me.TextBox1.TabIndex = 0
        '
        'dragdrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "選択したセル範囲をマウスの右ボタンのドラッグ＆ドロップで他のコントロールへ移動できます。"
        Me.Name = "dragdrop"
        Me.Title = "ドラッグ＆ドロップ"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread2_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents FpSpread2 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread2_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
