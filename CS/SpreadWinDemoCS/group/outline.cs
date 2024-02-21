using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.group
{
    public partial class outline : SpreadWinDemo.DemoBase
    {
        public outline()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum2.xml"));
            sheet.DataSource = ds;

            // シート設定
            sheet.FrozenRowCount = 2;

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 100;
            sheet.Columns[2].Width = 141;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;

            // 列の追加
            sheet.AddColumns(sheet.ColumnCount, 1);
            sheet.Columns[sheet.ColumnCount - 1].Width = 80;

            // 行の追加
            sheet.AddUnboundRows(sheet.RowCount, 1);

            // セル型の設定
            FarPoint.Win.Spread.CellType.CurrencyCellType currcell = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            sheet.Columns[3, sheet.ColumnCount - 1].CellType = currcell;

            // 合計行／列の設定
            sheet.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            sheet.ColumnHeader.Cells[0, sheet.ColumnCount - 1].Value = "合計";
            sheet.RowHeader.Cells[sheet.RowCount - 1, 0].Value = "合計";
            for (int row = 0; row < sheet.RowCount - 1; row++)
            {
                sheet.Cells[row, sheet.ColumnCount - 1].Formula = "SUM(RC[-4]:RC[-1])";
            }
            for (int col = 3; col < sheet.ColumnCount; col++)
            {
                sheet.Cells[sheet.RowCount - 1, col].Formula = "SUM(R[-11]C:R[-1]C)";
            }

            // アウトラインの設定
            sheet.AddRangeGroup(0, 12, true);
            sheet.AddRangeGroup(3, 4, false);
            FarPoint.Win.Spread.RangeGroupInfo[] rgi = sheet.Columns.GetRangeGroupInfo(1);
            sheet.ExpandRangeGroup(rgi[0], false, false);
        }
    }
}
