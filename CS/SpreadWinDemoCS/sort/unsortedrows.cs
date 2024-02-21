using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sort
{
    public partial class unsortedrows : SpreadWinDemo.DemoBase
    {
        public unsortedrows()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
            
            fpSpread1.AutoSortingColumn += new FarPoint.Win.Spread.AutoSortingColumnEventHandler(fpSpread1_AutoSortingColumn);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data30.xml"));
            sheet.DataSource = ds;

            // シート設定
            sheet.FrozenRowCount = 2;

            // 列幅の設定
            sheet.Columns[0].Width = 70;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 80;
            sheet.Columns[3].Width = 140;
            sheet.Columns[4].Width = 140;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 80;
            sheet.Columns[7].Width = 50;
            sheet.Columns[8].Width = 60;
            sheet.Columns[9].Width = 70;
            sheet.Columns[10].Width = 300;

            // 列の非表示
            sheet.Columns[3].Visible = false;
            sheet.Columns[4].Visible = false;
            sheet.Columns[10].Visible = false;
            
            // 自動ソートを有効化
            for (int i = 0; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].AllowAutoSort = true;
            }            
        }

        void fpSpread1_AutoSortingColumn(object sender, FarPoint.Win.Spread.AutoSortingColumnEventArgs e)
        {
            // 固定行をソートしない
            e.SortFrozenRows = false;
        }
    }
}
