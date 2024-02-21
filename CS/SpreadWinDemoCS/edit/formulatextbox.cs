using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class formulatextbox : SpreadWinDemo.DemoBase
    {
        public formulatextbox()
        {
            InitializeComponent();

            // シートの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // 名前ボックスの追加
            FarPoint.Win.Spread.NameBox namebox1 = new FarPoint.Win.Spread.NameBox();
            this.splitContainer2.Panel1.Controls.Add(namebox1);
            namebox1.Dock = DockStyle.Fill;
            namebox1.Attach(spread);      
        }  

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
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
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 135;
            sheet.Columns[3].Width = 65;
            sheet.Columns[4].Width = 65;
            sheet.Columns[5].Width = 65;
            sheet.Columns[6].Width = 65;
            sheet.Columns[7].Width = 103;
        }  
    }
}
