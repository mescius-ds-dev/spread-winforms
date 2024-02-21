namespace SpreadWinDemo.edit
{
    partial class headerfooterformula
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(headerfooterformula));
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, ((object)(resources.GetObject("panel1.Controls"))));
            this.fpSpread1_Sheet1 = this.fpSpread1.GetSheet(0);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpSpread1);
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.BackColor = System.Drawing.Color.Transparent;
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11F);
            this.fpSpread1.Location = new System.Drawing.Point(0, 0);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Size = new System.Drawing.Size(708, 400);
            this.fpSpread1.TabIndex = 0;
            // 
            // headerfooterformula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.Description = "ヘッダ・フッタで集計したデータを、他のセルから参照して別の集計に使用することが可能です。このサンプルでは、各列の合計値をフッタに算出してから、その値の合計を最終列" +
    "のフッタに出力しています。";
            this.Name = "headerfooterformula";
            this.Title = "ヘッダ・フッタ上のデータ参照";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
    }
}
