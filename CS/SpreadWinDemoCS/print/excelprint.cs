using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.print
{
    public partial class excelprint : SpreadWinDemo.DemoBase
    {
        public excelprint()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A1"].Value = "Page1";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A60"].Value = "Page2";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A100"].Value = "Page3";

            // 先頭ページのヘッダ設定
            fpSpread1.ActiveSheet.PrintInfo.DifferentFirstPageHeaderFooter = true;
            fpSpread1.ActiveSheet.PrintInfo.FirstHeader = "/l先頭ページ";

            // 偶数ページのヘッダ設定
            fpSpread1.ActiveSheet.PrintInfo.OddAndEvenPagesHeaderFooter = true;
            fpSpread1.ActiveSheet.PrintInfo.EvenHeader = "/l偶数ページ";

            // 奇数ページのヘッダ設定
            fpSpread1.ActiveSheet.PrintInfo.Header = "/l奇数ページ";

            fpSpread1.Sheets[0].PrintInfo.Preview = true;
            fpSpread1.Sheets[0].PrintInfo.EnhancePreview = true;
            fpSpread1.Sheets[0].PrintInfo.Margin.Top = 50;

            // Excel互換印刷
            fpSpread1.Features.ExcelCompatiblePrinting = true;
        }

        void button1_Click(object sender, EventArgs e)
        {
            fpSpread1.PrintSheet(0);
        }
    }
}
