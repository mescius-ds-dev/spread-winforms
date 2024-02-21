using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.filtering
{
    public partial class filtersort : SpreadWinDemo.DemoBase
    {
        public filtersort()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.dataexcelfilter.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 120;
            sheet.Columns[2].Width = 80;
            sheet.Columns[3].Width = 100;
            sheet.Columns[4].Width = 80;

            // 背景色の設定
            for (int i = 0; i < sheet.RowCount; i++)
            {
                if (i % 5 == 0)
                {
                    sheet.Rows[i].BackColor = System.Drawing.Color.Azure;
                }
                else if (i % 5 == 1)
                {
                    sheet.Rows[i].BackColor = System.Drawing.Color.Beige;
                }
                else if (i % 5 == 2)
                {
                    sheet.Rows[i].BackColor = System.Drawing.Color.LavenderBlush;
                }
                else if (i % 5 == 3)
                {
                    sheet.Rows[i].BackColor = System.Drawing.Color.Silver;
                }
                else if (i % 5 == 4)
                {
                    sheet.Rows[i].BackColor = System.Drawing.Color.PaleVioletRed;
                }
            }

            // フィルタリングとソートの設定
            sheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu;
            sheet.AutoSortEnhancedContextMenu = true;
            sheet.AutoSortEnhancedMode = FarPoint.Win.Spread.SortingMode.ViewIndex;
            sheet.Columns[1, 4].AllowAutoFilter = true;
            sheet.Columns[1, 4].AllowAutoSort = true;
        }
    }
}
