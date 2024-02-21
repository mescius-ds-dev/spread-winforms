using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class openexcelfile : SpreadWinDemo.DemoBase
    {
        public openexcelfile()
        {
            InitializeComponent();

            button1.Click += new EventHandler(button1_Click);
        }

        void button1_Click(object sender, EventArgs e)
        {
            string fn = "";
            // ファイル選択ダイアログ起動
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excelファイル(*.xls;*.xlsx)|*.xls;*.xlsx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fn = ofd.FileName;
                }
                else
                {
                    return;
                }
            }

            // excelファイル読込
            fpSpread1.OpenExcel(fn, FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns);
        }
    }
}
