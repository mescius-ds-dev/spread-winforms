<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class richclipboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(richclipboard))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, CType(resources.GetObject("SplitContainer1.Panel1.Controls"), Object))
        Me.FpSpread1_Sheet1 = Me.FpSpread1.GetSheet(0)
        Me.FpSpread2 = New FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, CType(resources.GetObject("SplitContainer1.Panel2.Controls"), Object))
        Me.FpSpread2_Sheet1 = Me.FpSpread2.GetSheet(0)
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.FpSpread2)
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
        Me.FpSpread1.Size = New System.Drawing.Size(352, 400)
        Me.FpSpread1.TabIndex = 0
        '
        'FpSpread2
        '
        Me.FpSpread2.AccessibleDescription = ""
        Me.FpSpread2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread2.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread2.Name = "FpSpread2"
        Me.FpSpread2.Size = New System.Drawing.Size(352, 400)
        Me.FpSpread2.TabIndex = 0
        '
        'richclipboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "セル範囲をコピーする時にExcelと同じように緑枠のアニメーションが選択している範囲に設定されます。コメントや異なるワークブックに対する参照も引き継がれます。"
        Me.Name = "richclipboard"
        Me.Title = "Excelライクなコピー＆ペースト"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents FpSpread2 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread2_Sheet1 As FarPoint.Win.Spread.SheetView

End Class
