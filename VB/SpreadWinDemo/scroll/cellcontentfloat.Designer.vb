<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cellcontentfloat
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
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
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
        Me.splitContainer1.Panel1.Controls.Add(Me.checkBox1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.FpSpread1)
        Me.splitContainer1.Size = New System.Drawing.Size(708, 400)
        Me.splitContainer1.SplitterDistance = 30
        Me.splitContainer1.TabIndex = 2
        '
        'checkBox1
        '
        Me.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkBox1.Location = New System.Drawing.Point(0, 0)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(708, 30)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "テキスト位置の自動調整機能を有効にする"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpSpread1.Location = New System.Drawing.Point(0, 0)
        Me.FpSpread1.Name = "FpSpread1"
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
        Me.SheetView1.ColumnFooterSheetCornerStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.ColumnFooterSheetCornerStyle.Parent = "CornerFooterDefaultEnhanced"
        Me.SheetView1.ColumnFooterSheetCornerStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
        Me.SheetView1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.SheetView1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.SheetView1.FilterBarHeaderStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.General
        Me.SheetView1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'cellcontentfloat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "セルが大きすぎてその一部が画面の外に出てしまうとき、スクロール操作によりセルのテキストも見えなくなる場合があります。このようなとき、スクロール位置にかかわらず、上" & _
    "下中央／左右中央にテキスト位置を固定し、常に表示領域内に表示することができます。"
        Me.Name = "cellcontentfloat"
        Me.Title = "テキスト位置の自動調整"
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
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Private WithEvents SheetView1 As FarPoint.Win.Spread.SheetView

End Class
