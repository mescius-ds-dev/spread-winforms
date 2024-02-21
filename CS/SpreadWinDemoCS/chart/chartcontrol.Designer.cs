namespace SpreadWinDemo.chart
{
    partial class chartcontrol
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
            FarPoint.Win.Chart.LabelArea labelArea1 = new FarPoint.Win.Chart.LabelArea();
            FarPoint.Win.Chart.LegendArea legendArea1 = new FarPoint.Win.Chart.LegendArea();
            FarPoint.Win.Chart.YPlotArea yPlotArea1 = new FarPoint.Win.Chart.YPlotArea();
            FarPoint.Win.Chart.Wall wall1 = new FarPoint.Win.Chart.Wall();
            FarPoint.Win.Chart.Wall wall2 = new FarPoint.Win.Chart.Wall();
            FarPoint.Win.Chart.DirectionalLight directionalLight1 = new FarPoint.Win.Chart.DirectionalLight();
            FarPoint.Win.Chart.BarSeries barSeries1 = new FarPoint.Win.Chart.BarSeries();
            FarPoint.Win.Chart.Wall wall3 = new FarPoint.Win.Chart.Wall();
            FarPoint.Win.Chart.IndexAxis indexAxis1 = new FarPoint.Win.Chart.IndexAxis();
            FarPoint.Win.Chart.ValueAxis valueAxis1 = new FarPoint.Win.Chart.ValueAxis();
            FarPoint.Win.Chart.IndexAxis indexAxis2 = new FarPoint.Win.Chart.IndexAxis();
            this.fpChart1 = new FarPoint.Win.Chart.FpChart();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpChart1);
            // 
            // fpChart1
            // 
            this.fpChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpChart1.Location = new System.Drawing.Point(0, 0);
            labelArea1.AlignmentX = 0.5F;
            labelArea1.Location = new System.Drawing.PointF(0.5F, 0.1F);
            labelArea1.ManualLayout = false;
            labelArea1.Padding = new FarPoint.Win.Chart.PaddingF(1.5F, 1.5F, 1.5F, 1.5F);
            labelArea1.Text = "Bar Chart";
            this.fpChart1.Model.LabelAreas.AddRange(new FarPoint.Win.Chart.LabelArea[] {
            labelArea1});
            legendArea1.AlignmentX = 1F;
            legendArea1.AlignmentY = 0.5F;
            legendArea1.Location = new System.Drawing.PointF(0.98F, 0.5F);
            legendArea1.Padding = new FarPoint.Win.Chart.PaddingF(3F, 3F, 3F, 3F);
            this.fpChart1.Model.LegendAreas.AddRange(new FarPoint.Win.Chart.LegendArea[] {
            legendArea1});
            ((System.ComponentModel.ISupportInitialize)(yPlotArea1)).BeginInit();
            wall1.Visible = true;
            yPlotArea1.BackWall = wall1;
            wall2.Visible = true;
            yPlotArea1.BottomWall = wall2;
            yPlotArea1.Elevation = 15F;
            yPlotArea1.GlobalAmbientLight = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            directionalLight1.AmbientColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            directionalLight1.DiffuseColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            directionalLight1.DirectionX = 10F;
            directionalLight1.DirectionY = 20F;
            directionalLight1.DirectionZ = 30F;
            directionalLight1.SpecularColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            yPlotArea1.Lights.Clear();
            yPlotArea1.Lights.AddRange(new FarPoint.Win.Chart.Light[] {
            directionalLight1});
            yPlotArea1.Projection = new FarPoint.Win.Chart.OrthogonalProjection();
            yPlotArea1.Rotation = -10F;
            barSeries1.SeriesName = "series";
            yPlotArea1.Series.AddRange(new FarPoint.Win.Chart.Series[] {
            barSeries1});
            wall3.Visible = true;
            yPlotArea1.SideWall = wall3;
            yPlotArea1.XAxis = indexAxis1;
            yPlotArea1.YAxes.Clear();
            yPlotArea1.YAxes.AddRange(new FarPoint.Win.Chart.ValueAxis[] {
            valueAxis1});
            yPlotArea1.ZAxis = indexAxis2;
            ((System.ComponentModel.ISupportInitialize)(yPlotArea1)).EndInit();
            this.fpChart1.Model.PlotAreas.AddRange(new FarPoint.Win.Chart.PlotArea[] {
            yPlotArea1});
            this.fpChart1.Name = "fpChart1";
            this.fpChart1.Size = new System.Drawing.Size(708, 400);
            this.fpChart1.TabIndex = 0;
            this.fpChart1.Text = "fpChart1";
            // 
            // chartcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.Description = "SPREAD上にだけではなく、フォーム上に直接チャートを配置することができます。";
            this.Name = "chartcontrol";
            this.Title = "チャートコントロール";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarPoint.Win.Chart.FpChart fpChart1;
    }
}
