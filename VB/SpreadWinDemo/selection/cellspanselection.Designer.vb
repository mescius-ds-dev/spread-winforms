<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cellspanselection
    Inherits SpreadWinDemo.DemoBase

    'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1.SuspendLayout()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
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
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.ComboBox1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.FpSpread1)
        Me.splitContainer1.Size = New System.Drawing.Size(708, 400)
        Me.splitContainer1.SplitterDistance = 30
        Me.splitContainer1.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"既定値", "クリックされた列（行）のみを選択", "ヘッダ領域に収まるセルだけを選択", "ヘッダの領域に含まれるセルをすべて選択"})
        Me.ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(708, 26)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "既定値"
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.SerializingWorkbookData = False
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView1})
        Me.FpSpread1.Size = New System.Drawing.Size(708, 366)
        Me.FpSpread1.TabIndex = 0
        '
        'SheetView1
        '
        Me.SheetView1.Reset()
        Me.SheetView1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.SheetView1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.ColumnFooter.DefaultStyle.Locked = False
        Me.SheetView1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnFooterSheetCornerStyle.Locked = False
        Me.SheetView1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.ColumnHeader.DefaultStyle.Locked = False
        Me.SheetView1.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.DefaultStyle.Locked = False
        Me.SheetView1.FilterBar.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.FilterBar.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.FilterBar.DefaultStyle.Locked = False
        Me.SheetView1.FilterBarHeaderStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.FilterBarHeaderStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.Locked = False
        Me.SheetView1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.RowHeader.DefaultStyle.Locked = False
        Me.SheetView1.SheetCornerStyle.BackColor = System.Drawing.Color.Empty
        Me.SheetView1.SheetCornerStyle.ForeColor = System.Drawing.Color.Empty
        Me.SheetView1.SheetCornerStyle.Locked = False
        Me.SheetView1.SheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'cellspanselection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "結合されたヘッダセルをクリックしたときの選択範囲を指定できます。 結合されたセルの左の列（上の行）のみを選択、ヘッダ領域に収まるセルだけを選択、ヘッダの領域に含ま" &
    "れるセルをすべて選択などのパターンで選択方法を設定できます。"
        Me.Name = "cellspanselection"
        Me.Title = "ヘッダクリック時の選択範囲"
        Me.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Private WithEvents SheetView1 As FarPoint.Win.Spread.SheetView

End Class
