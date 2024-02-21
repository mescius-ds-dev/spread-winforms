namespace SpreadWinDemo.edit
{
    partial class richclipboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(richclipboard));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, ((object)(resources.GetObject("splitContainer1.Panel1.Controls"))));
            this.fpSpread1_Sheet1 = this.fpSpread1.GetSheet(0);
            this.fpSpread2 = new FarPoint.Win.Spread.FpSpread(FarPoint.Win.Spread.LegacyBehaviors.None, ((object)(resources.GetObject("splitContainer1.Panel2.Controls"))));
            this.fpSpread2_Sheet1 = this.fpSpread2.GetSheet(0);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fpSpread1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fpSpread2);
            this.splitContainer1.Size = new System.Drawing.Size(708, 400);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 3;
            // 
            // fpSpread1
            // 
            this.fpSpread1.AccessibleDescription = "";
            this.fpSpread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread1.Location = new System.Drawing.Point(0, 0);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.Size = new System.Drawing.Size(352, 400);
            this.fpSpread1.TabIndex = 1;
            // 
            // fpSpread2
            // 
            this.fpSpread2.AccessibleDescription = "";
            this.fpSpread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpSpread2.Location = new System.Drawing.Point(0, 0);
            this.fpSpread2.Name = "fpSpread2";
            this.fpSpread2.Size = new System.Drawing.Size(352, 400);
            this.fpSpread2.TabIndex = 2;
            // 
            // richclipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.Description = "セル範囲をコピーする時にExcelと同じように緑枠のアニメーションが選択している範囲に設定されます。コメントや異なるワークブックに対する参照も引き継がれます。";
            this.Name = "richclipboard";
            this.Title = "Excelライクなコピー＆ペースト";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private FarPoint.Win.Spread.FpSpread fpSpread1;
        private FarPoint.Win.Spread.SheetView fpSpread1_Sheet1;
        private FarPoint.Win.Spread.FpSpread fpSpread2;
        private FarPoint.Win.Spread.SheetView fpSpread2_Sheet1;
    }
}
