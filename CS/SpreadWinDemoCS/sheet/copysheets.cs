using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class copysheets : SpreadWinDemo.DemoBase
    {
        public copysheets()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.TabStrip.Editable = true;
            fpSpread1.AllowUserFormulas = true;

            // Sheet2にテストデータを設定
            var sheet2 = fpSpread1.AsWorkbook().Worksheets.Add();
            sheet2.Cells["A1"].Value = 1;
            sheet2.Cells["A2"].Value = 2;
            sheet2.Cells["A3"].Value = 3;

            // Sheet1に数式を設定
            fpSpread1.AsWorkbook().ActiveSheet.Cells[0, 0].Formula = "SUM(Sheet2!A1:A3)";
            fpSpread1.AsWorkbook().ActiveSheet.Columns[0].ColumnWidth = 200;
        }

        void button1_Click(object sender, EventArgs e)
        {
            // Sheet1とSheet2をコピー
            fpSpread1.AsWorkbook().Worksheets[0, 1].Copy(0);
        }
    }
}
