using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class saveexcelfile : SpreadWinDemo.DemoBase
    {
        public saveexcelfile()
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
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

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
                sfd.Filter = "Excelファイル(*.xls)|*.xls";
                sfd.FileName = "SpreadClickOnceデモ.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fn = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            // Excelファイルに保存
            fpSpread1.SaveExcel(fn, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders);
        }

        void button2_Click(object sender, EventArgs e)
        {
            // ファイル保存ダイアログ起動
            string fn = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excelファイル(*.xlsx)|*.xlsx";
                sfd.FileName = "SpreadClickOnceデモ.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fn = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            // Excelファイルに保存
            fpSpread1.SaveExcel(fn, FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders | FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat);
        }
    }
}
