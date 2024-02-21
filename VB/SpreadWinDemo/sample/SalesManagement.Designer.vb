<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesManagement
    Inherits SpreadWinDemo.DemoBase

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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesManagement))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.SalesSpread = New FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, CType(resources.GetObject("Panel1.Controls"), Object))
        Me.SalesSpread_Sheet1 = Me.SalesSpread.GetSheet(0)
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.StoreSpread = New FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, CType(resources.GetObject("Panel1.Controls1"), Object))
        Me.StoreSpread_Sheet1 = Me.StoreSpread.GetSheet(0)
        Me.Panel1.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.SalesSpread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreSpread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SalesSpread)
        Me.Panel1.Controls.Add(Me.splitter1)
        Me.Panel1.Controls.Add(Me.StoreSpread)
        Me.Panel1.Controls.Add(Me.tableLayoutPanel1)
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.ImportButton, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.ExportButton, 2, 0)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 1
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(708, 33)
        Me.tableLayoutPanel1.TabIndex = 4
        '
        'ImportButton
        '
        Me.ImportButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImportButton.Location = New System.Drawing.Point(427, 3)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(135, 27)
        Me.ImportButton.TabIndex = 0
        Me.ImportButton.Text = "Excelインポート"
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExportButton.Location = New System.Drawing.Point(568, 3)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(137, 27)
        Me.ExportButton.TabIndex = 1
        Me.ExportButton.Text = "Excelエクスポート"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'SalesSpread
        '
        Me.SalesSpread.AccessibleDescription = "SalesSpread, Sheet1, Row 0, Column 0"
        Me.SalesSpread.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SalesSpread.Font = New System.Drawing.Font("メイリオ", 11.25!)
        Me.SalesSpread.Location = New System.Drawing.Point(335, 33)
        Me.SalesSpread.Name = "SalesSpread"
        Me.SalesSpread.Size = New System.Drawing.Size(373, 367)
        Me.SalesSpread.TabIndex = 6
        '
        'splitter1
        '
        Me.splitter1.Location = New System.Drawing.Point(325, 33)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(10, 367)
        Me.splitter1.TabIndex = 7
        Me.splitter1.TabStop = False
        '
        'StoreSpread
        '
        Me.StoreSpread.AccessibleDescription = "StoreSpread, Sheet1, Row 0, Column 0"
        Me.StoreSpread.Dock = System.Windows.Forms.DockStyle.Left
        Me.StoreSpread.Font = New System.Drawing.Font("メイリオ", 11.25!)
        Me.StoreSpread.Location = New System.Drawing.Point(0, 33)
        Me.StoreSpread.Name = "StoreSpread"
        Me.StoreSpread.Size = New System.Drawing.Size(325, 367)
        Me.StoreSpread.TabIndex = 5
        '
        'SalesManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Description = "このサンプルは、各店舗の売上Excelファイルをインポートし、集計レポートを作成しています。Excelファイルのインポートやエクスポート、シートの操作、ヘッダーや" &
    "セルへの設定、データバインドの方法などの使い方を示しています。ExcelはSampleDataフォルダに保存されている店舗売上ファイルをインポートします。"
        Me.Name = "SalesManagement"
        Me.Title = "売上管理"
        Me.Panel1.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        CType(Me.SalesSpread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreSpread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tableLayoutPanel1 As TableLayoutPanel
    Private WithEvents ImportButton As Button
    Private WithEvents ExportButton As Button
    Private WithEvents SalesSpread As FarPoint.Win.Spread.FpSpread
    Private WithEvents splitter1 As Splitter
    Private WithEvents StoreSpread As FarPoint.Win.Spread.FpSpread
    Friend WithEvents SalesSpread_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents StoreSpread_Sheet1 As FarPoint.Win.Spread.SheetView
End Class
