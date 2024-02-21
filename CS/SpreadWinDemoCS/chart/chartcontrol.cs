using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class chartcontrol : SpreadWinDemo.DemoBase
    {
        public chartcontrol()
        {
            InitializeComponent();

            // チャートコントロールの設定
            InitChart(fpChart1);
        }

        private void InitChart(FarPoint.Win.Chart.FpChart chart)
        {
            // チャートコントロールの初期化
            chart.Model.LabelAreas.Clear();
            chart.Model.LegendAreas.Clear();
            chart.Model.PlotAreas.Clear();

            // テストデータの設定
            FarPoint.Win.Chart.StringCollectionItem collection1 = new FarPoint.Win.Chart.StringCollectionItem();
            string[] testName = new string[] { "A", "B", "C", "D", "E" };
            double[] testData1 = new double[] { 2, 5, 8, 7, 4 };
            double[] testData2 = new double[] { 7, 3, 2, 4, 9 };

            // 棒グラフ用シリーズの作成
            FarPoint.Win.Chart.BarSeries series1 = new FarPoint.Win.Chart.BarSeries();
            series1.SeriesName = "シリーズ１";
            series1.BarBorder = new FarPoint.Win.Chart.SolidLine(Color.Black);
            series1.BarFill = new FarPoint.Win.Chart.SolidFill(Color.Blue);
            series1.CategoryNames.AddRange(testName);
            series1.Values.AddRange(testData1);

            // 折れ線グラフ用シリーズの作成
            FarPoint.Win.Chart.LineSeries series2 = new FarPoint.Win.Chart.LineSeries();
            series2.SeriesName = "シリーズ２";
            series2.LineBorder = new FarPoint.Win.Chart.SolidLine(Color.Red, 3.0F);
            series2.PointBorder = new FarPoint.Win.Chart.SolidLine(Color.Black);
            series2.PointFill = new FarPoint.Win.Chart.SolidFill(Color.Red);
            series2.PointMarker = new FarPoint.Win.Chart.BuiltinMarker(FarPoint.Win.Chart.MarkerShape.Circle, 10.0F);
            series2.CategoryNames.AddRange(testName);
            series2.Values.AddRange(testData2);
            series2.YAxisId = 1;

            // プロット領域の作成
            FarPoint.Win.Chart.YPlotArea area1 = new FarPoint.Win.Chart.YPlotArea();
            area1.YAxes.Add(new FarPoint.Win.Chart.ValueAxis());
            area1.YAxes[0].AutoMaximum = false;
            area1.YAxes[0].AutoMinimum = false;
            area1.YAxes[0].Maximum = 10;
            area1.YAxes[0].Minimum = 0;
            area1.YAxes[1].AutoMaximum = false;
            area1.YAxes[1].AutoMinimum = false;
            area1.YAxes[1].Maximum = 10;
            area1.YAxes[1].Minimum = 0;
            area1.YAxes[1].AxisId = 1;
            area1.YAxes[1].Location = FarPoint.Win.Chart.AxisLocation.Far;
            area1.Series.Add(series1);
            area1.Series.Add(series2);

            // チャートモデルに各情報を追加
            chart.Model.PlotAreas.Add(area1);
            chart.Model.LabelAreas.Add(new FarPoint.Win.Chart.LabelArea() { Text = "縦棒グラフと折れ線グラフ", Location = new PointF(0.3f, 0.04f) });
            chart.Model.LegendAreas.Add(new FarPoint.Win.Chart.LegendArea());
        }
    }
}
