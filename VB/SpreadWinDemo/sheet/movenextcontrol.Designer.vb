<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class movenextcontrol
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
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.FpSpread1 = New FarPoint.Win.Spread.FpSpread()
        Me.SheetView1 = New FarPoint.Win.Spread.SheetView()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.textBox2)
        Me.Panel1.Controls.Add(Me.FpSpread1)
        Me.Panel1.Controls.Add(Me.textBox1)
        '
        'textBox2
        '
        Me.textBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox2.Location = New System.Drawing.Point(598, 364)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 25)
        Me.textBox2.TabIndex = 5
        Me.textBox2.Text = "次のコントロール"
        '
        'FpSpread1
        '
        Me.FpSpread1.AccessibleDescription = ""
        Me.FpSpread1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FpSpread1.Location = New System.Drawing.Point(10, 46)
        Me.FpSpread1.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.FpSpread1.Name = "FpSpread1"
        Me.FpSpread1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.SheetView1})
        Me.FpSpread1.Size = New System.Drawing.Size(688, 308)
        Me.FpSpread1.TabIndex = 4
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
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(10, 11)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(10, 10, 10, 5)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 25)
        Me.textBox1.TabIndex = 3
        Me.textBox1.Text = "前のコントロール"
        '
        'movenextcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "キーボードマップを使用して、先頭／最終セルから前／次のコントロールにフォーカス移動するキーアクションを任意のキーに割り当てることができます。ここでは、[Tab]キーで次の、[Shift + Tab]キーで前のコントロールに移動します。"
        Me.Name = "movenextcontrol"
        Me.Title = "前後のコントロールに移動 "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SheetView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents FpSpread1 As FarPoint.Win.Spread.FpSpread
    Private WithEvents SheetView1 As FarPoint.Win.Spread.SheetView
    Private WithEvents textBox1 As System.Windows.Forms.TextBox

End Class
