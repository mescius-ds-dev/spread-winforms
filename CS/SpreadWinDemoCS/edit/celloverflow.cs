using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class celloverflow : SpreadWinDemo.DemoBase
    {
        public celloverflow()
        {
            InitializeComponent();
                        
            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            string strVal = "長いテキストは、となりのセルにはみ出します。";
            sheet.Cells[0, 5].Value = strVal + "(右揃え)";
            sheet.Cells[0, 5].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;
            sheet.Cells[1, 5].Value = strVal + "(左揃え)";
            sheet.Cells[1, 5].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            sheet.Cells[2, 5].Value = strVal + "(中央揃え)";
            sheet.Cells[2, 5].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fpSpread1.AllowCellOverflow = true;
            }
            else
            {
                fpSpread1.AllowCellOverflow = false;
            }
        }

        void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fpSpread1.AllowEditOverflow = true;
            }
            else
            {
                fpSpread1.AllowEditOverflow = false;
            }
        }
    }
}
