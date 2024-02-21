<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class focusindicator
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.FpSpread1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComboBox1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComboBox2)
        Me.SplitContainer2.Size = New System.Drawing.Size(708, 30)
        Me.SplitContainer2.SplitterDistance = 352
        Me.SplitContainer2.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"選択範囲の外側にフォーカス枠を表示", "アクティブセルのみにフォーカス枠を表示"})
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(352, 26)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "選択範囲の外側にフォーカス枠を表示"
        '
        'ComboBox2
        '
        Me.ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"緑枠（デフォルト）", "太さの変更", "色の変更", "アニメーション", "Ver 3.0J以前のスタイル", "非表示"})
        Me.ComboBox2.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(352, 26)
        Me.ComboBox2.TabIndex = 0
        Me.ComboBox2.Text = "緑枠（デフォルト）"
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
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.ColumnFooter.DefaultStyle.Locked = False
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.ColumnFooterSheetCornerStyle.Locked = False
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.ColumnHeader.DefaultStyle.Locked = False
        Me.FpSpread1_Sheet1.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.DefaultStyle.Locked = False
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.FilterBar.DefaultStyle.Locked = False
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.FilterBarHeaderStyle.Locked = False
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.RowHeader.DefaultStyle.Locked = False
        Me.FpSpread1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.FpSpread1_Sheet1.SheetCornerStyle.Locked = False
        Me.FpSpread1_Sheet1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.FpSpread1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'focusindicator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "アクティブセルや選択範囲を強調表示するフォーカス枠をカスタマイズすることができます。"
        Me.Name = "focusindicator"
        Me.Title = "フォーカス枠"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FpSpread1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Friend WithEvents FpSpread1_Sheet1 As FarPoint.Win.Spread.SheetView

End Class
