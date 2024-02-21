using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class savetextfile : SpreadWinDemo.DemoBase
    {
        public savetextfile()
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
            sheet.ColumnHeader.Cells[0, 0].Value = "No";

            // 列幅の設定
            sheet.Columns[0].Width = 36;
            sheet.Columns[1].Width = 88;
            sheet.Columns[2].Width = 91;
            sheet.Columns[3].Width = 71;
            sheet.Columns[4].Width = 36;
            sheet.Columns[5].Width = 46;
            sheet.Columns[6].Width = 49;
            sheet.Columns[7].Width = 71;
            sheet.Columns[8].Width = 181;
        }

        void button1_Click(object sender, EventArgs e)
        {
            // ファイル保存ダイアログ起動
            string fn = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "csvファイル(*.csv)|*.csv";
                sfd.FileName = "SpreadClickOnceデモ.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fn = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            // csv出力
            fpSpread1.ActiveSheet.SaveTextFile(fn, FarPoint.Win.Spread.TextFileFlags.None, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly, System.Environment.NewLine, ",", "\"");            
        }
    }
}
