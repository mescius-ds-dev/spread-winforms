using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class funnel : SpreadWinDemo.DemoBase
    {
        public funnel()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetArray(0, 0, new object[,] { { "A", "B", "C", "D", "E" } });
            sheet.SetArray(1, 0, new object[,] { { 9, 7, 5, 3, 1 } });

            // シリーズを作成
            FarPoint.Win.Chart.FunnelSeries series1 = new FarPoint.Win.Chart.FunnelSeries();
            series1.SeriesName = "s1";
            series1.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$E$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text); 
            series1.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$2:$E$2");

            // プロット領域を作成
            FarPoint.Win.Chart.YPlotArea plotArea = new FarPoint.Win.Chart.YPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.8f, 0.8f);
            plotArea.XAxis.Reverse = true; // じょうご図では必須（FunnelSeriesを追加する前に設定します）
            plotArea.Vertical = false; // じょうご図では必須（FunnelSeriesを追加する前に設定します）
            plotArea.Series.Add(series1);

            // チャートモデルに各情報を追加
            FarPoint.Win.Chart.ChartModel model = new FarPoint.Win.Chart.ChartModel();
            model.PlotAreas.Add(plotArea);

            // SPREADチャートにチャートモデルを設定
            FarPoint.Win.Spread.Chart.SpreadChart chart = new FarPoint.Win.Spread.Chart.SpreadChart();
            chart.Size = new Size(450, 250);
            chart.Location = new Point(0, 120);
            chart.Model = model;

            // シートにSPREADチャートを追加
            sheet.Charts.Add(chart);
        }
    }
}
