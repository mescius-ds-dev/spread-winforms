using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class bubblechart : SpreadWinDemo.DemoBase
    {
        public bubblechart()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetClipValue(0, 1, 1, 5, "S\tE\tW\tN\tNE");
            sheet.SetClipValue(1, 0, 1, 6, "S1\t500\t246\t549\t300\t260");
            sheet.SetClipValue(2, 0, 1, 6, "S2\t926\t146\t1501\t240\t650");
            sheet.SetClipValue(3, 0, 1, 6, "S3\t650\t260\t700\t600\t428");
            sheet.SetClipValue(4, 0, 1, 6, "S4\t240\t80\t260\t1100\t268");

            // シリーズを作成
            FarPoint.Win.Chart.XYBubbleSeries series1 = new FarPoint.Win.Chart.XYBubbleSeries();
            series1.SeriesName = "s1";
            series1.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series1.SizeValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$3:$F$3");
            series1.XValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.AutoIndex);
            series1.YValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$2:$F$2");

            FarPoint.Win.Chart.XYBubbleSeries series2 = new FarPoint.Win.Chart.XYBubbleSeries();
            series2.SeriesName = "s3";
            series2.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$4:$A$4", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series2.SizeValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$5:$F$5");
            series2.XValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.AutoIndex);
            series2.YValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$4:$F$4");

            // プロット領域を作成します
            FarPoint.Win.Chart.XYPlotArea plotArea = new FarPoint.Win.Chart.XYPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.7f, 0.8f);
            plotArea.Series.AddRange(new FarPoint.Win.Chart.Series[] { series1, series2 });

            // 凡例を設定
            FarPoint.Win.Chart.LegendArea legend = new FarPoint.Win.Chart.LegendArea();
            legend.Location = new System.Drawing.PointF(0.995f, 0.5f);
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
