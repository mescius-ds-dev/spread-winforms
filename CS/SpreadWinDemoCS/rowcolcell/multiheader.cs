using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class multiheader : SpreadWinDemo.DemoBase
    {
        public multiheader()
        {
            InitializeComponent();

            // シートの設定
            InitSpread(fpSpread1.Sheets[0]);
        }

        private void InitSpread(FarPoint.Win.Spread.SheetView sheet)
        {
            // セル型の自動設定を無効化
            sheet.DataAutoCellTypes = false;

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

            // 各列のセル型を設定
            FarPoint.Win.Spread.CellType.GeneralCellType gnr = new FarPoint.Win.Spread.CellType.GeneralCellType();
            gnr.FormatString = "#,##0";
            sheet.Columns[4, 9].CellType = gnr;

            sheet.Columns[3].Visible = false;

            // 列ヘッダを２行に設定
            sheet.ColumnHeader.RowCount = 2;
            sheet.ColumnHeader.AutoTextIndex = 0;

            // ヘッダ再設定
            sheet.ColumnHeader.Cells[0, 0].RowSpan = 2;
            sheet.ColumnHeader.Cells[0, 1].RowSpan = 2;
            sheet.ColumnHeader.Cells[0, 2].RowSpan = 2;

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
        }
    }
}
