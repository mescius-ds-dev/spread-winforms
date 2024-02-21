using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class gettoprowcol : SpreadWinDemo.DemoBase
    {
        public gettoprowcol()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data30.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 50;
            sheet.Columns[2].Width = 90;
            sheet.Columns[3].Width = 120;
            sheet.Columns[4].Width = 150;
            sheet.Columns[5].Width = 40;
            sheet.Columns[6].Width = 80;
            sheet.Columns[7].Width = 40;
            sheet.Columns[8].Width = 70;
            sheet.Columns[9].Width = 70;
            sheet.Columns[10].Width = 280;
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 先頭行の取得
            int TopRow = fpSpread1.GetViewportTopRow(0);
            MessageBox.Show(TopRow.ToString());
        }

        void button2_Click(object sender, EventArgs e)
        {
            // 先頭列の取得
            int LeftCol = fpSpread1.GetViewportLeftColumn(0);
            MessageBox.Show(LeftCol.ToString());
        }
    }
}
