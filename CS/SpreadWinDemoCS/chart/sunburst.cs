using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class sunburst : SpreadWinDemo.DemoBase
    {
        public sunburst()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetArray(0, 0, new object[,] { { "A", "", "", "", "B", "", "", "C", "", "D" } });
            sheet.SetArray(1, 0, new object[,] { { "A1", "", "A2", "A3", "B1", "B2", "", "C1", "C2", "D1" } });
            sheet.SetArray(2, 0, new object[,] { { "A1a", "A1b", "", "", "", "B2a", "B2b", "", "", "" } });
            sheet.SetArray(3, 0, new object[,] { { 1, 2, 3, 4, 5, 2, 2, 3, 4, 5 } });

            // シリーズを作成
            FarPoint.Win.Chart.SunburstSeries series1 = new FarPoint.Win.Chart.SunburstSeries();
            series1.SeriesName = "s1";
            series1.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$J$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series1.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$4:$J$4");

            // プロット領域を作成
            FarPoint.Win.Chart.SunburstPlotArea plotArea = new FarPoint.Win.Chart.SunburstPlotArea();
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
