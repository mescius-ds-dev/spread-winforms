using FarPoint.Win.Chart;
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
    public partial class embeddedshape : SpreadWinDemo.DemoBase
    {
        public embeddedshape()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.Features.EnhancedShapeEngine = true;

            fpSpread1.AsWorkbook().ActiveSheet.SetValue(1, 1, new object[,] { { "data1", "data2", "data3", "data4", "data5", "data6" }, { 1, 2, 3, 4, 5, 6 } });
            FarPoint.Win.Spread.Model.CellRange range = new FarPoint.Win.Spread.Model.CellRange(1, 1, 2, 6);
            sheet.AddChart(range, typeof(BarSeries), 400, 250, 100, 120, ChartViewType.View2D, false);

            // シェイプを埋め込み
            fpSpread1.AsWorkbook().ActiveSheet.ChartObjects[0].Chart.Shapes.AddShape(AutoShapeType.RightArrow, 50, 50, 150, 50);
        }  
    }
}
