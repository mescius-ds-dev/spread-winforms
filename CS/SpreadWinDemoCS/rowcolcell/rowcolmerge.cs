using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class rowcolmerge : SpreadWinDemo.DemoBase
    {
        public rowcolmerge()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);

            fpSpread1.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(fpSpread1_ButtonClicked);
        }        

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.ColumnCount = 7;
            sheet.RowCount = 13;
            sheet.FrozenTrailingRowCount = 3;

            // 列幅の設定
            sheet.Columns[0].Width = 150;
            sheet.Columns[2].Width = 100;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;

            // 行の高さの設定
            sheet.Rows[10, 12].Height = 40;

            // セル型の設定
            FarPoint.Win.Spread.CellType.NumberCellType ic = new FarPoint.Win.Spread.CellType.NumberCellType();
            ic.DecimalPlaces = 0;
            sheet.Columns[2].CellType = ic;
            FarPoint.Win.Spread.CellType.DateTimeCellType dc = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            sheet.Columns[4, 5].CellType = dc;
            FarPoint.Win.Spread.CellType.ButtonCellType bcn = new FarPoint.Win.Spread.CellType.ButtonCellType();
            bcn.Text = "マージの解除";
            sheet.Cells[10, 0].CellType = bcn;
            FarPoint.Win.Spread.CellType.ButtonCellType bca = new FarPoint.Win.Spread.CellType.ButtonCellType();
            bca.Text = "常にマージ";
            sheet.Cells[11, 0].CellType = bca;
            FarPoint.Win.Spread.CellType.ButtonCellType bcr = new FarPoint.Win.Spread.CellType.ButtonCellType();
            bcr.Text = "他の列にあわせてマージ";
            sheet.Cells[12, 0].CellType = bcr;

            // 列名の設定
            sheet.ColumnHeader.Cells[0, 0].Value = "プロジェクト名";
            sheet.ColumnHeader.Cells[0, 1].Value = "分類";
            sheet.ColumnHeader.Cells[0, 2].Value = "プライオリティ";
            sheet.ColumnHeader.Cells[0, 3].Value = "担当者";
            sheet.ColumnHeader.Cells[0, 4].Value = "期限";
            sheet.ColumnHeader.Cells[0, 5].Value = "対応日";
            sheet.ColumnHeader.Cells[0, 6].Value = "ステータス";

            // テストデータの設定
            sheet.Cells[10, 1].Value = "セルのマージを解除します。";
            sheet.Cells[10, 1].ColumnSpan = sheet.ColumnCount - 1;
            sheet.Cells[11, 1].Value = "同一列の隣接するセルが同じ値であれば、マージします。";
            sheet.Cells[11, 1].ColumnSpan = sheet.ColumnCount - 1;
            sheet.Cells[12, 1].Value = "同一列の隣接するセルが同じ値で隣の列もマージされていれば、マージします。";
            sheet.Cells[12, 1].ColumnSpan = sheet.ColumnCount - 1;

            sheet.Cells[0, 0, 6, 0].Value = "グレープ商事";
            sheet.Cells[7, 0, 9, 0].Value = "紫山工務店";

            sheet.Cells[0, 1, 2, 1].Value = "機能改善";
            sheet.Cells[3, 1, 6, 1].Value = "バグ";
            sheet.Cells[7, 1].Value = "機能改善";
            sheet.Cells[8, 1, 9, 1].Value = "バグ";

            sheet.Cells[0, 2, 2, 2].Value = 1;
            sheet.Cells[3, 2, 4, 2].Value = 2;
            sheet.Cells[5, 2, 6, 2].Value = 3;
            sheet.Cells[7, 2, 8, 2].Value = 1;
            sheet.Cells[9, 2].Value = 2;

            sheet.Cells[0, 3, 2, 3].Value = "佐藤";
            sheet.Cells[3, 3, 6, 3].Value = "山田";
            sheet.Cells[7, 3, 9, 3].Value = "高橋";

            sheet.Cells[0, 4, 6, 4].Value = DateTime.Parse("2010/06/30");
            sheet.Cells[7, 4, 9, 4].Value = DateTime.Parse("2009/08/15");

            sheet.Cells[0, 5, 6, 5].Value = DateTime.Parse("2009/9/10");
            sheet.Cells[7, 5].Value = DateTime.Parse("2009/07/20");
            sheet.Cells[8, 5].Value = DateTime.Parse("2009/08/04");
            sheet.Cells[9, 5].Value = DateTime.Parse("2009/08/05");

            sheet.Cells[0, 6].Value = "新規";
            sheet.Cells[1, 6, 2, 6].Value = "対応中";
            sheet.Cells[3, 6, 6, 6].Value = "新規";
            sheet.Cells[7, 6, 9, 6].Value = "対応済み";
        }

        void fpSpread1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Row == 10)
            {
                // マージの設定
                fpSpread1.Sheets[0].SetColumnMerge(-1, FarPoint.Win.Spread.Model.MergePolicy.None);
            }
            else if (e.Row == 11)
            {
                // マージの設定
                fpSpread1.Sheets[0].SetColumnMerge(-1, FarPoint.Win.Spread.Model.MergePolicy.Always);
            }
            else if (e.Row == 12)
            {
                // マージの設定
                fpSpread1.Sheets[0].SetColumnMerge(-1, FarPoint.Win.Spread.Model.MergePolicy.Restricted);
            }
        }
    }
}
