using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class xyzchart : SpreadWinDemo.DemoBase
    {
        public xyzchart()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetClipValue(1, 0, 1, 6, "S1\t500\t246\t549\t300\t260");
            sheet.SetClipValue(2, 1, 1, 5, "926\t146\t1501\t240\t650");
            sheet.SetClipValue(3, 1, 1, 5, "650\t260\t700\t600\t428");
            sheet.SetClipValue(4, 1, 1, 5, "240\t80\t260\t1100\t268");

            // シリーズを作成
            FarPoint.Win.Chart.XYZSurfaceSeries series1 = new FarPoint.Win.Chart.XYZSurfaceSeries();
            series1.SeriesName = "s1";

            FarPoint.Win.Chart.DoubleCollection doubleCollection1 = new FarPoint.Win.Chart.DoubleCollection();
            FarPoint.Win.Chart.DoubleCollection doubleCollection2 = new FarPoint.Win.Chart.DoubleCollection();
            FarPoint.Win.Chart.DoubleCollection doubleCollection3 = new FarPoint.Win.Chart.DoubleCollection();
            FarPoint.Win.Chart.DoubleCollection doubleCollection4 = new FarPoint.Win.Chart.DoubleCollection();
            series1.SeriesNameDataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldSeriesName", "Sheet1!$A$2:$A$2", FarPoint.Win.Spread.Chart.SegmentDataType.Text, new FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, false));
            doubleCollection1.DataField = "";
            doubleCollection1.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$2:$F$2", FarPoint.Win.Spread.Chart.SegmentDataType.Number, new FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, false));
            series1.Values.Add(doubleCollection1);
            doubleCollection2.DataField = "";
            doubleCollection2.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$3:$F$3", FarPoint.Win.Spread.Chart.SegmentDataType.Number, new FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, false));
            series1.Values.Add(doubleCollection2);
            doubleCollection3.DataField = "";
            doubleCollection3.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue2", "Sheet1!$B$4:$F$4", FarPoint.Win.Spread.Chart.SegmentDataType.Number, new FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, false));
            series1.Values.Add(doubleCollection3);
            doubleCollection4.DataField = "";
            doubleCollection4.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue3", "Sheet1!$B$5:$F$5", FarPoint.Win.Spread.Chart.SegmentDataType.Number, new FarPoint.Win.Spread.Chart.ChartDataSetting(FarPoint.Win.Spread.Chart.EmptyValueStyle.Zero, false));
            series1.Values.Add(doubleCollection4);

            // プロット領域を作成します
            FarPoint.Win.Chart.XYZPlotArea plotArea = new FarPoint.Win.Chart.XYZPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.2f, 0.2f);
            plotArea.Size = new System.Drawing.SizeF(0.5f, 0.5f);
            plotArea.Elevation = 18;
            plotArea.Rotation = -24;
            plotArea.Series.AddRange(new FarPoint.Win.Chart.Series[] { series1 });

            // チャートモデルに各情報を追加
            FarPoint.Win.Chart.ChartModel model = new FarPoint.Win.Chart.ChartModel();
            model.PlotAreas.Add(plotArea);

            // SPREADチャートにチャートモデルを設定
            FarPoint.Win.Spread.Chart.SpreadChart chart = new FarPoint.Win.Spread.Chart.SpreadChart();
            chart.Size = new Size(450, 250);
            chart.Location = new Point(0, 120);
            chart.ViewType = FarPoint.Win.Chart.ChartViewType.View3D;
            chart.Model = model;

            // シートにSPREADチャートを追加
            sheet.Charts.Add(chart);
        }  
    }
}
