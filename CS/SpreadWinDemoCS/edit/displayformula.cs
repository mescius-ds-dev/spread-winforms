using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class displayformula : SpreadWinDemo.DemoBase
    {
        public displayformula()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum2.xml"));
            sheet.DataSource = ds;

            // 合計列追加
            sheet.AddColumns(7, 1);
            sheet.ColumnHeader.Cells[0, 7].Text = "合計";

            // 数式設定
            for (int i = 0; i < sheet.RowCount; i++)
            {
                string row = Convert.ToString(i + 1);
                sheet.Cells[i, 7].Formula = "SUM(D" + row + ":G" + row + ")";
            }

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 0;
            sheet.Columns[2].Width = 0;
            sheet.Columns[3].Width = 60;
            sheet.Columns[4].Width = 60;
            sheet.Columns[5].Width = 60;
            sheet.Columns[6].Width = 60;
            sheet.Columns[7].Width = 103;
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // 数式を表示する
                fpSpread1.AsWorkbook().ActiveSheet.View.DisplayFormulas = true;
            }
            else
            {
                // 数式を表示しない
                fpSpread1.AsWorkbook().ActiveSheet.View.DisplayFormulas = false;
            }
        }
    }
}
