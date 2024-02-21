using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.scroll
{
    public partial class frozenrowcol : SpreadWinDemo.DemoBase
    {
        public frozenrowcol()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datascroll.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 100;
            sheet.Columns[1].Width = 80;
            sheet.Columns[2].Width = 80;
            sheet.Columns[3].Width = 100;
            sheet.Columns[4].Width = 100;
            sheet.Columns[5].Width = 60;
            sheet.Columns[6].Width = 100;
            sheet.Columns[7].Width = 300;
            sheet.Columns[8].Width = 80;
            sheet.Columns[9].Width = 80;
            sheet.Columns[10].Width = 140;
            sheet.Columns[11].Width = 100;
            sheet.Columns[12].Width = 60;
            sheet.Columns[13].Width = 80;
            sheet.Columns[14].Width = 60;

            // 行・列を固定
            sheet.FrozenRowCount = 1;
            sheet.FrozenColumnCount = 3;
            sheet.Columns[0, 2].BackColor = Color.LavenderBlush;
            sheet.Rows[0].BackColor = Color.LavenderBlush;
        }
    }
}
