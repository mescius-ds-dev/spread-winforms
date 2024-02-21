using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class sheetcorner : SpreadWinDemo.DemoBase
    {
        public sheetcorner()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.ColumnCount = 6;
            sheet.RowCount = 12;

            // 列ヘッダの設定
            sheet.ColumnHeader.RowCount = 3;
            sheet.ColumnHeader.Cells[0, 0].Value = "項目A";
            sheet.ColumnHeader.Cells[0, 3].Value = "項目B";
            sheet.ColumnHeader.Cells[0, 0].ColumnSpan = 3;
            sheet.ColumnHeader.Cells[0, 3].ColumnSpan = 3;
            sheet.ColumnHeader.Cells[1, 0].Value = "中項目１";
            sheet.ColumnHeader.Cells[1, 1].Value = "中項目２";
            sheet.ColumnHeader.Cells[1, 2].Value = "中項目３";
            sheet.ColumnHeader.Cells[1, 3].Value = "中項目１";
            sheet.ColumnHeader.Cells[1, 4].Value = "中項目２";
            sheet.ColumnHeader.Cells[1, 5].Value = "中項目３";
            sheet.ColumnHeader.Cells[2, 0].Value = "小項目１";
            sheet.ColumnHeader.Cells[2, 1].Value = "小項目２";
            sheet.ColumnHeader.Cells[2, 2].Value = "小項目３";
            sheet.ColumnHeader.Cells[2, 3].Value = "小項目１";
            sheet.ColumnHeader.Cells[2, 4].Value = "小項目２";
            sheet.ColumnHeader.Cells[2, 5].Value = "小項目３";

            // 行ヘッダの設定
            sheet.RowHeader.ColumnCount = 4;
            sheet.RowHeader.Columns[1].Width = 40;
            sheet.RowHeader.Columns[2].Width = 40;
            sheet.RowHeader.Cells[0, 0].Value = "1";
            sheet.RowHeader.Cells[2, 0].Value = "2";
            sheet.RowHeader.Cells[4, 0].Value = "3";
            sheet.RowHeader.Cells[6, 0].Value = "4";
            sheet.RowHeader.Cells[8, 0].Value = "5";
            sheet.RowHeader.Cells[10, 0].Value = "6";
            sheet.RowHeader.Cells[0, 0].RowSpan = 2;
            sheet.RowHeader.Cells[2, 0].RowSpan = 2;
            sheet.RowHeader.Cells[4, 0].RowSpan = 2;
            sheet.RowHeader.Cells[6, 0].RowSpan = 2;
            sheet.RowHeader.Cells[8, 0].RowSpan = 2;
            sheet.RowHeader.Cells[10, 0].RowSpan = 2;
            sheet.RowHeader.Cells[0, 1].Value = "札幌";
            sheet.RowHeader.Cells[6, 1].Value = "千葉";
            sheet.RowHeader.Cells[8, 1].Value = "広島";
            sheet.RowHeader.Cells[0, 1].RowSpan = 6;
            sheet.RowHeader.Cells[6, 1].RowSpan = 2;
            sheet.RowHeader.Cells[8, 1].RowSpan = 4;
            sheet.RowHeader.Cells[0, 2].Value = "1001";
            sheet.RowHeader.Cells[1, 2].Value = "1002";
            sheet.RowHeader.Cells[2, 2].Value = "2001";
            sheet.RowHeader.Cells[3, 2].Value = "2002";
            sheet.RowHeader.Cells[4, 2].Value = "3001";
            sheet.RowHeader.Cells[5, 2].Value = "3002";
            sheet.RowHeader.Cells[6, 2].Value = "1001";
            sheet.RowHeader.Cells[7, 2].Value = "1002";
            sheet.RowHeader.Cells[8, 2].Value = "1001";
            sheet.RowHeader.Cells[9, 2].Value = "1002";
            sheet.RowHeader.Cells[10, 2].Value = "2001";
            sheet.RowHeader.Cells[11, 2].Value = "2002";
            sheet.RowHeader.Cells[0, 3].Value = "佐藤";
            sheet.RowHeader.Cells[2, 3].Value = "山本";
            sheet.RowHeader.Cells[4, 3].Value = "石川";
            sheet.RowHeader.Cells[6, 3].Value = "鈴木";
            sheet.RowHeader.Cells[8, 3].Value = "田中";
            sheet.RowHeader.Cells[10, 3].Value = "橋本";
            sheet.RowHeader.Cells[0, 3].RowSpan = 2;
            sheet.RowHeader.Cells[2, 3].RowSpan = 2;
            sheet.RowHeader.Cells[4, 3].RowSpan = 2;
            sheet.RowHeader.Cells[6, 3].RowSpan = 2;
            sheet.RowHeader.Cells[8, 3].RowSpan = 2;
            sheet.RowHeader.Cells[10, 3].RowSpan = 2;

            // シートコーナーを分割
            sheet.AllowTableCorner = true;
            sheet.SheetCorner.Cells[0, 0].Value = "紫山商事";
            sheet.SheetCorner.Cells[0, 0].ColumnSpan = 4;
            sheet.SheetCorner.Cells[1, 0].Value = "NO";
            sheet.SheetCorner.Cells[1, 1].Value = "支店";
            sheet.SheetCorner.Cells[1, 2].Value = "ID A";
            sheet.SheetCorner.Cells[2, 2].Value = "ID B";
            sheet.SheetCorner.Cells[1, 3].Value = "担当";
            sheet.SheetCorner.Cells[1, 0].RowSpan = 2;
            sheet.SheetCorner.Cells[1, 1].RowSpan = 2;
            sheet.SheetCorner.Cells[1, 3].RowSpan = 2;
            sheet.SheetCorner.Cells[1, 2].ForeColor = System.Drawing.Color.Red;
            sheet.SheetCorner.Cells[2, 2].ForeColor = System.Drawing.Color.Green;
        }
    }
}
