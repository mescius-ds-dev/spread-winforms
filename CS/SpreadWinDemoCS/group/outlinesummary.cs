using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.group
{
    public partial class outlinesummary : SpreadWinDemo.DemoBase
    {
        public outlinesummary()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 36;
            sheet.Columns[1].Width = 88;
            sheet.Columns[2].Width = 91;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 36;
            sheet.Columns[5].Width = 46;
            sheet.Columns[6].Width = 49;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 181;

            // アウトラインの設定
            sheet.AddRangeGroup(3, 5, true);
            sheet.AddRangeGroup(2, 4, false);
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fpSpread1.Sheets[0].RangeGroupSummaryRowBelow = true;
            }
            else
            {
                fpSpread1.Sheets[0].RangeGroupSummaryRowBelow = false;
            }
        }

        void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fpSpread1.Sheets[0].RangeGroupSummaryColumnRight = true;
            }
            else
            {
                fpSpread1.Sheets[0].RangeGroupSummaryColumnRight = false;
            }
        }
    }
}
