using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class pareto : SpreadWinDemo.DemoBase
    {
        public pareto()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetArray(0, 0, new object[,] { { "項目A", "項目A", "項目A", "項目A", "項目B", "項目B", "項目B", "項目C", "項目C", "項目D", "項目D", "項目E" } });
            sheet.SetArray(1, 0, new object[,] { { 4.7, 3.9, 3.5, 3.4, 2.9, 2.8, 2.6, 2.3, 2.2, 1.2, 1.8, 0.7 } });

            // シリーズを作成
            FarPoint.Win.Chart.ParetoSeries series1 = new FarPoint.Win.Chart.ParetoSeries();
            series1.SeriesName = "s1";
            series1.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$A$1:$L$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text); 
            series1.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$A$2:$L$2");
            series1.BinOption.BinCount = 5;
            series1.BinOption.BinType = FarPoint.Win.Chart.BinOption.HistogramBinType.ByCategory;
            series1.Bar.YAxisId = 0;
            series1.ParetoLine.YAxisId = 1;

            // プロット領域を作成
            FarPoint.Win.Chart.YPlotArea plotArea = new FarPoint.Win.Chart.YPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.8f, 0.8f);
            plotArea.YAxes.Add(new FarPoint.Win.Chart.ValueAxis() { AxisId = 1, Location = FarPoint.Win.Chart.AxisLocation.Far });
            plotArea.YAxes[0].AutoMaximum = false;
            plotArea.YAxes[0].AutoMajorUnit = false;
            plotArea.YAxes[0].Maximum = 20;
            plotArea.YAxes[0].MajorUnit = 4;
            plotArea.YAxes[1].DisplayUnits = 0.01;
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
