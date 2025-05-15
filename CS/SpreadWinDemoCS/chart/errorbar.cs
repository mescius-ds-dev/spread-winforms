using FarPoint.Win.Chart;
using FarPoint.Win.Spread.Model;
using GrapeCity.Spreadsheet.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class errorbar : SpreadWinDemo.DemoBase
    {
        public errorbar()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.ActiveSheet.SetClip(0, 1, 1, 5, "1.2\t0\t-12.5\t-5\t15");
            fpSpread1.ActiveSheet.SetClip(1, 0, 1, 6, "1\t-15.43\t-11\t16\t0\t17.5");
            fpSpread1.ActiveSheet.SetClip(2, 0, 1, 6, "2\t7\t12\0\t-10\t10\t0");
            fpSpread1.ActiveSheet.AddChart(new CellRange(0, 0, 3, 6), typeof(FarPoint.Win.Chart.ClusteredBarSeries), 400, 250, 100, 100);
            if (fpSpread1.ActiveSheet.Charts[0].Model.PlotAreas[0].Series[0] is ClusteredBarSeries cluster)
            {
                foreach (BarSeries series in cluster.Series)
                {
                    // 誤差範囲の設定
                    ErrorBars errorBar = series.SetErrorBarsVisible(true);
                    errorBar.ValueType = ErrorBarValueType.StandardError;
                    errorBar.Type = FarPoint.Win.Chart.ErrorBarType.Both;
                }
            }
        }  
    }
}
