using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class histogram : SpreadWinDemo.DemoBase
    {
        public histogram()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetArray(0, 0, new object[,] { { 0.7, 1.8, 1.2, 2.2, 2.3, 2.6, 2.8, 2.9, 3.4, 3.5, 3.9, 4.7 } });

            // シリーズを作成
            FarPoint.Win.Chart.HistogramSeries series1 = new FarPoint.Win.Chart.HistogramSeries();
            series1.SeriesName = "s1";
            series1.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$1:$L$1");
            series1.BinOption.BinCount = 5;
            series1.BinOption.BinType = FarPoint.Win.Chart.BinOption.HistogramBinType.BinCount;
            series1.BinOption.UnderFlowValue = 1;
            series1.BinOption.OverFlowValue = 4;
            series1.BinOption.IsUnderflowBin = true;
            series1.BinOption.IsOverflowBin = true;

            // プロット領域を作成
            FarPoint.Win.Chart.YPlotArea plotArea = new FarPoint.Win.Chart.YPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.8f, 0.8f);
            plotArea.YAxes[0].AutoMinorUnit = false;
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
