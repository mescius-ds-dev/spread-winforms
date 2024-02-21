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
    public partial class chartsheet : SpreadWinDemo.DemoBase
    {
        public chartsheet()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.Features.EnhancedShapeEngine = true;

            // テストデータの設定
            sheet.SetClipValue(0, 1, 1, 5, "S\tE\tW\tN\tNE");
            sheet.SetClipValue(1, 0, 1, 6, "S1\t50\t25\t85\t30\t26");
            sheet.SetClipValue(2, 0, 1, 6, "S2\t92\t14\t15\t24\t65");
            sheet.SetClipValue(3, 0, 1, 6, "S3\t65\t26\t70\t60\t43");
            sheet.SetClipValue(4, 0, 1, 6, "S4\t24\t80\t26\t11\t27");

            // チャートを追加
            fpSpread1.AsWorkbook().Charts.Add();
            fpSpread1.Sheets[0].Charts[0].DataFormula = "Sheet1!B2:F5";
            fpSpread1.Sheets[0].Charts[0].CategoryFormula = "Sheet1!A2:A5";
            fpSpread1.Sheets[0].Charts[0].SeriesNameFormula = "Sheet1!B1:F1";

            // 3Dでレンダリング
            fpSpread1.Sheets[0].Charts[0].ViewType = ChartViewType.View3D;
        }  
    }
}
