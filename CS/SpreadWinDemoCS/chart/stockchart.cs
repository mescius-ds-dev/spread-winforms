using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class stockchart : SpreadWinDemo.DemoBase
    {
        public stockchart()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.SetClipValue(0, 1, 1, 5, "8/1\t8/2\t8/3\t8/4\t8/5");
            sheet.SetClipValue(1, 0, 1, 6, "Open\t864\t279\t825\t360\t384");
            sheet.SetClipValue(2, 0, 1, 6, "High\t926\t614\t865\t562\t650");
            sheet.SetClipValue(3, 0, 1, 6, "Low\t500\t146\t501\t310\t260");
            sheet.SetClipValue(4, 0, 1, 6, "Close\t650\t560\t786\t486\t428");

            // シリーズを作成
            FarPoint.Win.Chart.CandlestickSeries series1 = new FarPoint.Win.Chart.CandlestickSeries();
            series1.SeriesName = "Series 1";
            series1.CategoryNames.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldCategoryName", "Sheet1!$B$1:$F$1", FarPoint.Win.Spread.Chart.SegmentDataType.Text);
            series1.CloseValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue3", "Sheet1!$B$5:$F$5");
            series1.HighValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue1", "Sheet1!$B$3:$F$3");
            series1.LowValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue2", "Sheet1!$B$4:$F$4");
            series1.OpenValues.DataSource = new FarPoint.Win.Spread.Chart.SeriesDataField(sheet.FpSpread, "DataFieldValue0", "Sheet1!$B$2:$F$2");

            // プロット領域を作成します
            FarPoint.Win.Chart.YPlotArea plotArea = new FarPoint.Win.Chart.YPlotArea();
            plotArea.Location = new System.Drawing.PointF(0.1f, 0.1f);
            plotArea.Size = new System.Drawing.SizeF(0.7f, 0.8f);
            plotArea.XAxis.MajorGridVisible = true;
            plotArea.Series.AddRange(new FarPoint.Win.Chart.Series[] { series1 });

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
