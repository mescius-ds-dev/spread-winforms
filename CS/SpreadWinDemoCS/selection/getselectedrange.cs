using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class getselectedrange : SpreadWinDemo.DemoBase
    {
        public getselectedrange()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
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
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 選択範囲の取得
            FarPoint.Win.Spread.Model.CellRange cr = fpSpread1.ActiveSheet.GetSelection(0);
            string msgstr;
            msgstr = "選択された先頭行インデックス：" + cr.Row.ToString();
            msgstr += System.Environment.NewLine + "選択された行数：" + cr.RowCount.ToString();
            msgstr += System.Environment.NewLine + "選択された先頭列インデックス：" + cr.Column.ToString();
            msgstr += System.Environment.NewLine + "選択された列数：" + cr.ColumnCount.ToString();
            MessageBox.Show(msgstr);
        }
    }
}
