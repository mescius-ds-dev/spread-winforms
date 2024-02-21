using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class columnchart : SpreadWinDemo.DemoBase
    {
        public columnchart()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetClipValue(0, 1, 1, 5, "S\tE\tW\tN\tNE");
            sheet.SetClipValue(1, 0, 1, 6, "S1\t50\t25\t85\t30\t26");
            sheet.SetClipValue(2, 0, 1, 6, "S2\t92\t14\t15\t24\t65");
            sheet.SetClipValue(3, 0, 1, 6, "S3\t65\t26\t70\t60\t43");
            sheet.SetClipValue(4, 0, 1, 6, "S4\t24\t80\t26\t11\t27");

            // シリーズを作成
            FarPoint.Win.Chart.BarSeries series1 = new FarPoint.Win.Chart.BarSeries();
            series1.SeriesName = "s1";
            series1.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series1.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series1.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$2:$F$2");

            FarPoint.Win.Chart.BarSeries series2 = new FarPoint.Win.Chart.BarSeries();
            series2.SeriesName = "s2";
            series2.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$3:$A$3", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series2.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series2.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$3:$F$3");

            FarPoint.Win.Chart.BarSeries series3 = new FarPoint.Win.Chart.BarSeries();
            series3.SeriesName = "s3";
            series3.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$4:$A$4", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series3.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series3.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$4:$F$4");

            FarPoint.Win.Chart.BarSeries series4 = new FarPoint.Win.Chart.BarSeries();
            series4.SeriesName = "s4";
            series4.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$5:$A$5", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series4.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series4.Values.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue", "Sheet1!$B$5:$F$5");

            FarPoint.Win.Chart.ClusteredBarSeries barSeries = new FarPoint.Win.Chart.ClusteredBarSeries();
            barSeries.Series.AddRange(new FarPoint.Win.Chart.BarSeries[] { series1, series2, series3, series4 });

            // プロット領域を作成
            FarPoint.Win.Chart.YPlotArea plotArea = new FarPoint.Win.Chart.YPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.7f, 0.8f);
            plotArea.XAxis.MajorGridVisible = true;
            plotArea.Series.AddRange(new FarPoint.Win.Chart.Series[] { barSeries });

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
