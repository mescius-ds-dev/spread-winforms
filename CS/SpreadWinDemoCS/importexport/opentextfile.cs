using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class opentextfile : SpreadWinDemo.DemoBase
    {
        public opentextfile()
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
                ofd.Filter = "csvファイル(*.csv)|*.csv"; 
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fn = ofd.FileName;
                }
                else
                {
                    return;
                }
            }

            // csv読込
            fpSpread1.ActiveSheet.LoadTextFile(fn, FarPoint.Win.Spread.TextFileFlags.ForceCellDelimiter, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly, System.Environment.NewLine, ",", "\"");
        }
    }
}
