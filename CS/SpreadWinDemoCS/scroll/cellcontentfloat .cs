using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.scroll
{
    public partial class cellcontentfloat : SpreadWinDemo.DemoBase
    {
        public cellcontentfloat()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 行列数の設定
            sheet.RowCount = 50;
            sheet.ColumnCount = 30;

            // 第１行のマージ設定
            sheet.Cells[0, 0, 0, 19].Value = "左右中央";
            sheet.Cells[0, 0, 0, 19].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            sheet.Rows[0].MergePolicy = FarPoint.Win.Spread.Model.MergePolicy.Always;
            
            // 第１列のマージ設定
            sheet.Cells[1, 0, 29, 0].Value = "上下中央";
            sheet.Cells[1, 0, 29, 0].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            sheet.Columns[0].MergePolicy = FarPoint.Win.Spread.Model.MergePolicy.Always;

            checkBox1.Checked = true;
            fpSpread1.AllowCellContentFloat = checkBox1.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // テキスト位置の自動調整機能の切り替え
            fpSpread1.AllowCellContentFloat = checkBox1.Checked;
        }
    }
}
