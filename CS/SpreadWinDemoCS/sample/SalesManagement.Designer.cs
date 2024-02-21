namespace SpreadWinDemo.sample
{
    partial class SalesManagement
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManagement));
            this.StoreSpread = new FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, ((object)(resources.GetObject("panel1.Controls1"))));
            this.StoreSpread_Sheet1 = this.StoreSpread.GetSheet(0);
            this.SalesSpread = new FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, ((object)(resources.GetObject("panel1.Controls"))));
            this.SalesSpread_Sheet1 = this.SalesSpread.GetSheet(0);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreSpread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSpread)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesSpread);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.StoreSpread);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // StoreSpread
            // 
            this.StoreSpread.AccessibleDescription = "StoreSpread, Sheet1, Row 0, Column 0";
            this.StoreSpread.Dock = System.Windows.Forms.DockStyle.Left;
            this.StoreSpread.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.StoreSpread.Location = new System.Drawing.Point(0, 33);
            this.StoreSpread.Name = "StoreSpread";
            this.StoreSpread.Size = new System.Drawing.Size(325, 367);
            this.StoreSpread.TabIndex = 1;
            // 
            // SalesSpread
            // 
            this.SalesSpread.AccessibleDescription = "SalesSpread, Sheet1, Row 0, Column 0";
            this.SalesSpread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesSpread.Font = new System.Drawing.Font("メイリオ", 11.25F);
            this.SalesSpread.Location = new System.Drawing.Point(335, 33);
            this.SalesSpread.Name = "SalesSpread";
            this.SalesSpread.Size = new System.Drawing.Size(373, 367);
            this.SalesSpread.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ImportButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ExportButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 33);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ImportButton
            // 
            this.ImportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImportButton.Location = new System.Drawing.Point(427, 3);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(135, 27);
            this.ImportButton.TabIndex = 0;
            this.ImportButton.Text = "Excelインポート";
            this.ImportButton.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExportButton.Location = new System.Drawing.Point(568, 3);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(137, 27);
            this.ExportButton.TabIndex = 1;
            this.ExportButton.Text = "Excelエクスポート";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(325, 33);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 367);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // SalesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.Description = "このサンプルは、各店舗の売上Excelファイルをインポートし、集計レポートを作成しています。Excelファイルのインポートやエクスポート、シートの操作、ヘッダーや" +
    "セルへの設定、データバインドの方法などの使い方を示しています。ExcelはSampleDataフォルダに保存されている店舗売上ファイルをインポートします。";
            this.Name = "SalesManagement";
            this.Title = "売上管理";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoreSpread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSpread)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ImportButton;
        private FarPoint.Win.Spread.FpSpread SalesSpread;
        private FarPoint.Win.Spread.FpSpread StoreSpread;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ExportButton;
        private FarPoint.Win.Spread.SheetView StoreSpread_Sheet1;
        private FarPoint.Win.Spread.SheetView SalesSpread_Sheet1;
    }
}
