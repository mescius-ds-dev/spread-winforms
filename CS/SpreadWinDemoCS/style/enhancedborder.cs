using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class enhancedborder : SpreadWinDemo.DemoBase
    {
        public enhancedborder()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            // 行列数の設定
            sheet.RowCount = 10;
            sheet.ColumnCount = 5;

            for (int r = 1; r <= 3; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    fpSpread1.AsWorkbook().ActiveSheet.Cells[r, c].Borders.LineStyle = GrapeCity.Spreadsheet.BorderLineStyle.Double;
                }
            }

            for (int r = 5; r <= 7; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    fpSpread1.AsWorkbook().ActiveSheet.Cells[r, c].Borders.LineStyle = GrapeCity.Spreadsheet.BorderLineStyle.Thick;
                }
            }
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // 拡張罫線を有効にする
                fpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Enhanced;
            }
            else
            {
                // 拡張罫線を無効にする
                fpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Collapse;
            }
        }
    }
}
