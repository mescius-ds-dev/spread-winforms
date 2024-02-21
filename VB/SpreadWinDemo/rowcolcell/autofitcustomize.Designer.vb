<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autofitcustomize
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
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.splitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.splitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.splitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.checkBox4 = New System.Windows.Forms.CheckBox()
        Me.splitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.checkBox5 = New System.Windows.Forms.CheckBox()
        Me.checkBox6 = New System.Windows.Forms.CheckBox()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        CType(Me.splitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer3.Panel1.SuspendLayout()
        Me.splitContainer3.Panel2.SuspendLayout()
        Me.splitContainer3.SuspendLayout()
        CType(Me.splitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer5.Panel1.SuspendLayout()
        Me.splitContainer5.Panel2.SuspendLayout()
        Me.splitContainer5.SuspendLayout()
        CType(Me.splitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer4.Panel1.SuspendLayout()
        Me.splitContainer4.Panel2.SuspendLayout()
        Me.splitContainer4.SuspendLayout()
        CType(Me.splitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer6.Panel1.SuspendLayout()
        Me.splitContainer6.Panel2.SuspendLayout()
        Me.splitContainer6.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.splitContainer1)
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.splitContainer2)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.FpSpread1)
        Me.splitContainer1.Size = New System.Drawing.Size(708, 400)
        Me.splitContainer1.SplitterDistance = 30
        Me.splitContainer1.SplitterWidth = 5
        Me.splitContainer1.TabIndex = 2
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer2.Name = "splitContainer2"
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me.splitContainer3)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.splitContainer4)
        Me.splitContainer2.Size = New System.Drawing.Size(708, 30)
        Me.splitContainer2.SplitterDistance = 352
        Me.splitContainer2.SplitterWidth = 5
        Me.splitContainer2.TabIndex = 0
        '
        'splitContainer3
        '
        Me.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer3.Name = "splitContainer3"
        '
        'splitContainer3.Panel1
        '
        Me.splitContainer3.Panel1.Controls.Add(Me.checkBox1)
        '
        'splitContainer3.Panel2
        '
        Me.splitContainer3.Panel2.Controls.Add(Me.splitContainer5)
        Me.splitContainer3.Size = New System.Drawing.Size(352, 30)
        Me.splitContainer3.SplitterDistance = 117
        Me.splitContainer3.SplitterWidth = 5
        Me.splitContainer3.TabIndex = 0
        '
        'checkBox1
        '
        Me.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox1.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.checkBox1.Location = New System.Drawing.Point(0, 0)
        Me.checkBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(117, 30)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "フッタの除外"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'splitContainer5
        '
        Me.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer5.Name = "splitContainer5"
        '
        'splitContainer5.Panel1
        '
        Me.splitContainer5.Panel1.Controls.Add(Me.checkBox2)
        '
        'splitContainer5.Panel2
        '
        Me.splitContainer5.Panel2.Controls.Add(Me.checkBox3)
        Me.splitContainer5.Size = New System.Drawing.Size(230, 30)
        Me.splitContainer5.SplitterDistance = 116
        Me.splitContainer5.SplitterWidth = 5
        Me.splitContainer5.TabIndex = 0
        '
        'checkBox2
        '
        Me.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox2.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.checkBox2.Location = New System.Drawing.Point(0, 0)
        Me.checkBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(116, 30)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "ヘッダの除外"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox3
        '
        Me.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox3.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.checkBox3.Location = New System.Drawing.Point(0, 0)
        Me.checkBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(109, 30)
        Me.checkBox3.TabIndex = 1
        Me.checkBox3.Text = "結合セルの除外"
        Me.checkBox3.UseVisualStyleBackColor = True
        '
        'splitContainer4
        '
        Me.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer4.Name = "splitContainer4"
        '
        'splitContainer4.Panel1
        '
        Me.splitContainer4.Panel1.Controls.Add(Me.checkBox4)
        '
        'splitContainer4.Panel2
        '
        Me.splitContainer4.Panel2.Controls.Add(Me.splitContainer6)
        Me.splitContainer4.Size = New System.Drawing.Size(351, 30)
        Me.splitContainer4.SplitterDistance = 116
        Me.splitContainer4.SplitterWidth = 5
        Me.splitContainer4.TabIndex = 0
        '
        'checkBox4
        '
        Me.checkBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox4.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.checkBox4.Location = New System.Drawing.Point(0, 0)
        Me.checkBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(116, 30)
        Me.checkBox4.TabIndex = 1
        Me.checkBox4.Text = "複数行セルの除外"
        Me.checkBox4.UseVisualStyleBackColor = True
        '
        'splitContainer6
        '
        Me.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.splitContainer6.Name = "splitContainer6"
        '
        'splitContainer6.Panel1
        '
        Me.splitContainer6.Panel1.Controls.Add(Me.checkBox5)
        '
        'splitContainer6.Panel2
        '
        Me.splitContainer6.Panel2.Controls.Add(Me.checkBox6)
        Me.splitContainer6.Size = New System.Drawing.Size(230, 30)
        Me.splitContainer6.SplitterDistance = 116
        Me.splitContainer6.SplitterWidth = 5
        Me.splitContainer6.TabIndex = 0
        '
        'checkBox5
        '
        Me.checkBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox5.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.checkBox5.Location = New System.Drawing.Point(0, 0)
        Me.checkBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox5.Name = "checkBox5"
        Me.checkBox5.Size = New System.Drawing.Size(116, 30)
        Me.checkBox5.TabIndex = 1
        Me.checkBox5.Text = "すべてを対象"
        Me.checkBox5.UseVisualStyleBackColor = True
        '
        'checkBox6
        '
        Me.checkBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox6.Font = New System.Drawing.Font("メイリオ", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.checkBox6.Location = New System.Drawing.Point(0, 0)
        Me.checkBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkBox6.Name = "checkBox6"
        Me.checkBox6.Size = New System.Drawing.Size(109, 30)
        Me.checkBox6.TabIndex = 1
        Me.checkBox6.Text = "自動調整の停止"
        Me.checkBox6.UseVisualStyleBackColor = True
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView1})
        Me.FpSpread1.Size = New System.Drawing.Size(708, 365)
        Me.FpSpread1.TabIndex = 0
        '
        'SheetView1
        '
        Me.SheetView1.Reset()
        Me.SheetView1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView1.ColumnFooter.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnFooter.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView1.ColumnFooter.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderDefaultEnhanced"
        Me.SheetView1.ColumnHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.DefaultStyle.Parent = "DataAreaDefault"
        Me.SheetView1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.FilterBar.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.SheetView1.FilterBar.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.RowHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.RowHeader.DefaultStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView1.RowHeader.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.SheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.SheetCornerStyle.Parent = "CornerDefaultEnhanced"
        Me.SheetView1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'autofitcustomize
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "ヘッダの境界線をダブルクリックしたときに列幅／行高を自動調整するユーザー操作をカスタマイズできます。 マウスのドラッグによる列幅／行高のリサイズは許可しても、ダブ" &
    "ルクリックによる自動調整は禁止するなど、細かい設定が可能です。 また、結合セルや、ヘッダ／フッタのテキストを除外するなどを指定することもできます。"
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "autofitcustomize"
        Me.Padding = New System.Windows.Forms.Padding(18, 27, 18, 5)
        Me.Title = "列幅、行高の自動調整"
        Me.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        Me.splitContainer3.Panel1.ResumeLayout(False)
        Me.splitContainer3.Panel2.ResumeLayout(False)
        CType(Me.splitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer3.ResumeLayout(False)
        Me.splitContainer5.Panel1.ResumeLayout(False)
        Me.splitContainer5.Panel2.ResumeLayout(False)
        CType(Me.splitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer5.ResumeLayout(False)
        Me.splitContainer4.Panel1.ResumeLayout(False)
        Me.splitContainer4.Panel2.ResumeLayout(False)
        CType(Me.splitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer4.ResumeLayout(False)
        Me.splitContainer6.Panel1.ResumeLayout(False)
        Me.splitContainer6.Panel2.ResumeLayout(False)
        CType(Me.splitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer6.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents splitContainer3 As System.Windows.Forms.SplitContainer
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents splitContainer5 As System.Windows.Forms.SplitContainer
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents splitContainer4 As System.Windows.Forms.SplitContainer
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
    Private WithEvents splitContainer6 As System.Windows.Forms.SplitContainer
    Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox6 As System.Windows.Forms.CheckBox
    Private WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Private WithEvents SheetView1 As FarPoint.Win.Spread.SheetView

End Class
