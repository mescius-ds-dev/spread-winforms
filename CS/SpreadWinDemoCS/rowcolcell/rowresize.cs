using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class rowresize : SpreadWinDemo.DemoBase
    {
        public rowresize()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
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

            sheet.Columns[3].Visible = false;

            // 列ヘッダを２行に設定
            sheet.ColumnHeader.RowCount = 2;
            sheet.ColumnHeader.AutoTextIndex = 0;
            // 行ヘッダを２行に設定
            sheet.RowHeader.ColumnCount = 2;
            sheet.RowHeader.AutoTextIndex = 0;

            // ヘッダ再設定
            sheet.ColumnHeader.Cells[0, 0].RowSpan = 2;
            sheet.ColumnHeader.Cells[0, 1].RowSpan = 2;
            sheet.ColumnHeader.Cells[0, 2].RowSpan = 2;
            sheet.ColumnHeader.Cells[0, 3].RowSpan = 2;

            sheet.ColumnHeader.Cells[1, 4].Text = "４月";
            sheet.ColumnHeader.Cells[1, 5].Text = "５月";
            sheet.ColumnHeader.Cells[1, 6].Text = "６月";
            sheet.ColumnHeader.Cells[1, 7].Text = "７月";
            sheet.ColumnHeader.Cells[1, 8].Text = "８月";
            sheet.ColumnHeader.Cells[1, 9].Text = "９月";

            sheet.ColumnHeader.Cells[0, 4].Text = "第１Ｑ";
            sheet.ColumnHeader.Cells[0, 4].ColumnSpan = 3;

            sheet.ColumnHeader.Cells[0, 7].Text = "第２Ｑ";
            sheet.ColumnHeader.Cells[0, 7].ColumnSpan = 3;

            sheet.RowHeader.Cells[0, 1].Text = "増";
            sheet.RowHeader.Cells[1, 1].Text = "減";
            sheet.RowHeader.Cells[2, 1].Text = "増";
            sheet.RowHeader.Cells[3, 1].Text = "増";
            sheet.RowHeader.Cells[4, 1].Text = "並";
            sheet.RowHeader.Cells[5, 1].Text = "並";
            sheet.RowHeader.Cells[6, 1].Text = "増";
            sheet.RowHeader.Cells[7, 1].Text = "減";
            sheet.RowHeader.Cells[8, 1].Text = "減";
            sheet.RowHeader.Cells[9, 1].Text = "並";
            sheet.RowHeader.Cells[10, 1].Text = "増";
            sheet.RowHeader.Cells[11, 1].Text = "増";
            sheet.RowHeader.Cells[12, 1].Text = "増";
            sheet.RowHeader.Cells[13, 1].Text = "減";
            sheet.RowHeader.Cells[14, 1].Text = "増";
            sheet.RowHeader.Cells[15, 1].Text = "増";
            sheet.RowHeader.Cells[16, 1].Text = "増";

            // 行のリサイズを許可しない
            sheet.Rows.Default.Resizable = false;

            // 1～3列目のリサイズを許可しない
            for (int i = 0; i < 3; i++)
            {
                sheet.Columns[i].Resizable = false;
            }

            // ヘッダのリサイズを許可
            sheet.ColumnHeader.Rows.Default.Resizable = true;
            sheet.RowHeader.Columns.Default.Resizable = true;
            sheet.AllowTableCorner = true;
        }
    }
}
