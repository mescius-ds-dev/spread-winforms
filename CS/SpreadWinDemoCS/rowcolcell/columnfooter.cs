using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class columnfooter : SpreadWinDemo.DemoBase
    {
        public columnfooter()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum3.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 140;
            sheet.Columns[3].Width = 40;
            sheet.Columns[4].Width = 65;
            sheet.Columns[5].Width = 65;
            sheet.Columns[6].Width = 65;
            sheet.Columns[7].Width = 65;
            sheet.Columns[8].Width = 65;
            sheet.Columns[9].Width = 65;

            // ３列目を非表示
            sheet.Columns[3].Visible = false;

            // 列フッターを表示
            sheet.ColumnFooter.Visible = true;
            sheet.ColumnFooter.RowCount = 2;
            sheet.ColumnFooter.Rows[0].BackColor = System.Drawing.Color.Orange;
            sheet.ColumnFooter.Cells[0, 0].Value = "製品数";
            sheet.ColumnFooter.Cells[0, 0].ColumnSpan = 3;
            sheet.ColumnFooter.Cells[1, 0].ColumnSpan = 3;
            sheet.ColumnFooter.Cells[0, 4].Value = "合計";
            sheet.ColumnFooter.Cells[0, 4].ColumnSpan = 6;

            // 列フッターに製品数を表示
            sheet.ColumnFooter.SetAggregationType(1, 0, FarPoint.Win.Spread.Model.AggregationType.CountA);

            // 列フッターに合計を表示
            for (int i = 4; i < sheet.ColumnCount; i++)
            {
                sheet.ColumnFooter.SetAggregationType(1, i, FarPoint.Win.Spread.Model.AggregationType.Sum);
            }
        }
    }
}
