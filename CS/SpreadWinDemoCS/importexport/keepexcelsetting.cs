using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class keepexcelsetting : SpreadWinDemo.DemoBase
    {
        public keepexcelsetting()
        {
            InitializeComponent();

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ファイル選択ダイアログ起動
            string fn = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excelファイル(*.xlsx;*.xlsm)|*.xlsx;*.xlsm";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fn = ofd.FileName;
                }
                else
                {
                    return;
                }
            }
            
            // Excelファイルのインポート（Excelの情報を維持）
            fpSpread1.OpenExcel(fn, FarPoint.Excel.ExcelOpenFlags.DocumentCaching | FarPoint.Excel.ExcelOpenFlags.TruncateEmptyRowsAndColumns);

            // SPREADの値を変更
            fpSpread1.ActiveSheet.Cells[0, 0].Value = "test";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ファイル保存ダイアログ起動
            string fn = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excelファイル(*.xlsx;*.xlsm)|*.xlsx;*.xlsm";
                sfd.FileName = "SpreadClickOnceデモ2.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fn = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            // Excelファイルのエクスポート（Excelの情報を維持）
            fpSpread1.SaveExcel(fn, FarPoint.Excel.ExcelSaveFlags.DocumentCaching | FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat);
        }
    }
}
