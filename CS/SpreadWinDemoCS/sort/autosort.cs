using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sort
{
    public partial class autosort : SpreadWinDemo.DemoBase
    {
        public autosort()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
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
            sheet.Columns[4].Width = 50;
            sheet.Columns[5].Width = 60;
            sheet.Columns[6].Width = 50;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 181;

            // 自動ソートを有効化
            for (int i = 0; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].AllowAutoSort = true;
            }   
        }
    }
}
