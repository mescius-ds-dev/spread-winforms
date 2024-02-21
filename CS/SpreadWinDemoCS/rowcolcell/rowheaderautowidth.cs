using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class rowheaderautowidth : SpreadWinDemo.DemoBase
    {
        public rowheaderautowidth()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            fpSpread1.ActiveSheet.RowCount = 1000000;
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // 行ヘッダの自動拡張を有効にする
                fpSpread1.RowHeaderAutoWidthMax = -1;
            }
            else
            {
                // 行ヘッダの自動拡張を有効にしない
                fpSpread1.RowHeaderAutoWidthMax = 0;
            }
        }
    }
}
