using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.scroll
{
    public partial class frozenwidth : SpreadWinDemo.DemoBase
    {
        public frozenwidth()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            trackBar1.Scroll += new EventHandler(trackBar1_Scroll);
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

            // 固定線の太さ設定
            fpSpread1.ActiveSheet.AsWorksheet().Options.FrozenLineThickness = 10;
        }

        void trackBar1_Scroll(object sender, EventArgs e)
        {
            fpSpread1.ActiveSheet.AsWorksheet().Options.FrozenLineThickness = trackBar1.Value;
            label2.Text = trackBar1.Value.ToString("#0");
        }
    }
}
