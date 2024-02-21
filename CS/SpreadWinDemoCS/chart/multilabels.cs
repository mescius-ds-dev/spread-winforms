using FarPoint.Win.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.chart
{
    public partial class multilabels : SpreadWinDemo.DemoBase
    {
        public multilabels()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータ
            fpSpread1.ActiveSheet.Cells[1, 1].Value = "s1";
            fpSpread1.ActiveSheet.Cells[2, 1].Value = "s2";
            fpSpread1.ActiveSheet.Cells[3, 1].Value = "s3";
            fpSpread1.ActiveSheet.Cells[4, 1].Value = "s4";
            fpSpread1.ActiveSheet.Cells[5, 1].Value = "s5";
            fpSpread1.ActiveSheet.Cells[6, 1].Value = "s6";
            fpSpread1.ActiveSheet.Cells[1, 2].Value = 7;
            fpSpread1.ActiveSheet.Cells[2, 2].Value = 8;
            fpSpread1.ActiveSheet.Cells[3, 2].Value = 9;
            fpSpread1.ActiveSheet.Cells[4, 2].Value = 10;
            fpSpread1.ActiveSheet.Cells[5, 2].Value = 11;
            fpSpread1.ActiveSheet.Cells[6, 2].Value = 12;
            fpSpread1.ActiveSheet.Cells[1, 0].Value = "Category1";
            fpSpread1.ActiveSheet.Cells[3, 0].Value = "Category2";

            // チャートの追加
            FarPoint.Win.Spread.Model.CellRange range = new FarPoint.Win.Spread.Model.CellRange(1, 0, 6, 3);
            fpSpread1.ActiveSheet.AddChart(range, typeof(BarSeries), 300, 300, 250, 50, ChartViewType.View2D, false);

            // コンテキストメニューを有効
            fpSpread1.ActiveSheet.Charts[0].ContextMenuStrip = new FarPoint.Win.Spread.Chart.SpreadChartContextMenuStrip();

            // 複数レベルの項目軸ラベルを有効
            YPlotArea plotArea = (YPlotArea)(fpSpread1.Sheets[0].Charts[0].Model.PlotAreas[0]);
            plotArea.XAxis.MultiLevel = true;
        }  
    }
}
