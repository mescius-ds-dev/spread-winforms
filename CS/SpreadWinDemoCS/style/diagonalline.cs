using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class diagonalline : SpreadWinDemo.DemoBase
    {
        public diagonalline()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum4.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 140;
            sheet.Columns[3].Width = 40;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 80;
            sheet.Columns[9].Width = 80;

            // ３列目を非表示
            sheet.Columns[3].Visible = false;

            // 斜め罫線の設定
            FarPoint.Win.ComplexBorderSide diagonalborder = new FarPoint.Win.ComplexBorderSide(Color.Black, 1, System.Drawing.Drawing2D.DashStyle.Solid);
            for (int i = 0; i < sheet.RowCount; i++)
            {
                for (int j = 0; j < sheet.ColumnCount; j++)
                {
                    if (sheet.Cells[i, j].Value == null)
                    {
                        sheet.Cells[i, j].Border = new FarPoint.Win.ComplexBorder(null, null, null, null, diagonalborder, false, true);
                    }
                }
            }
        }
    }
}
