using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class treemap : SpreadWinDemo.DemoBase
    {
        public treemap()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetArray(0, 0, new object[,] { { "A", "", "", "", "B", "", "", "C", "", "D" } });
            sheet.SetArray(1, 0, new object[,] { { "A-1", "", "", "A-2", "B-1", "B-2", "B-3", "C-1", "C-2", "D-1" } });
            sheet.SetArray(2, 0, new object[,] { { "A-1-1", "A-1-2", "A-1-3", "", "", "", "", "", "", "" } });
            sheet.SetArray(3, 0, new object[,] { { 1, 2, 4, 8, 12, 1, 2, 4, 8, 12 } });

            // シリーズを作成
            FarPoint.Win.Chart.TreemapSeries series1 = new FarPoint.Win.Chart.TreemapSeries();
            series1.SeriesName = "s1";
            series1.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$J$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series1.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$4:$J$4");

            // プロット領域を作成
            FarPoint.Win.Chart.TreemapPlotArea plotArea = new FarPoint.Win.Chart.TreemapPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.7f, 0.8f);
            plotArea.Series.Add(series1);

            // 凡例を設定
            FarPoint.Win.Chart.LegendArea legend = new FarPoint.Win.Chart.LegendArea();
            legend.Location = new System.Drawing.PointF(0.95f, 0.5f);
            legend.AlignmentX = 1f;
            legend.AlignmentY = 0.5f;

            // チャートモデルに各情報を追加
            FarPoint.Win.Chart.ChartModel model = new FarPoint.Win.Chart.ChartModel();
            model.LegendAreas.Add(legend);
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
