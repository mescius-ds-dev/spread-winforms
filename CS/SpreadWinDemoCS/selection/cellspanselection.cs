using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class cellspanselection : SpreadWinDemo.DemoBase
    {
        public cellspanselection()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 列ヘッダの結合
            sheet.ColumnHeader.RowCount = 3;
            sheet.ColumnHeader.Cells[0, 0].ColumnSpan = 8;
            sheet.ColumnHeader.Cells[1, 0].ColumnSpan = 2;
            sheet.ColumnHeader.Cells[1, 2].ColumnSpan = 2;
            sheet.ColumnHeader.Cells[1, 4].ColumnSpan = 2;
            sheet.ColumnHeader.Cells[1, 6].ColumnSpan = 2;

            // 列ヘッダキャプションの設定
            sheet.ColumnHeader.Cells[0, 0].Value = "今年度（内訳）";
            sheet.ColumnHeader.Cells[1, 0].Value = "第１四半期";
            sheet.ColumnHeader.Cells[1, 2].Value = "第２四半期";
            sheet.ColumnHeader.Cells[1, 4].Value = "第３四半期";
            sheet.ColumnHeader.Cells[1, 6].Value = "第４四半期";
            sheet.ColumnHeader.Cells[2, 0].Value = "Ａ期間";
            sheet.ColumnHeader.Cells[2, 1].Value = "Ｂ期間";
            sheet.ColumnHeader.Cells[2, 2].Value = "Ａ期間";
            sheet.ColumnHeader.Cells[2, 3].Value = "Ｂ期間";
            sheet.ColumnHeader.Cells[2, 4].Value = "Ａ期間";
            sheet.ColumnHeader.Cells[2, 5].Value = "Ｂ期間";
            sheet.ColumnHeader.Cells[2, 6].Value = "Ａ期間";
            sheet.ColumnHeader.Cells[2, 7].Value = "Ｂ期間";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // SPREADの準備が完了していない場合を除外
            if (fpSpread1.Sheets.Count == 0) return;

            // 選択範囲のクリア
            fpSpread1.Sheets[0].ClearSelection();

            // 選択動作の設定
            if (comboBox1.Text == "既定値（従来バージョンと同じ動作）")
            {
                fpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Default;
            }
            else if (comboBox1.Text == "クリックされた列（行）のみを選択")
            {
                fpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.IgnoreSpan;
            }
            else if (comboBox1.Text == "ヘッダ領域に収まるセルだけを選択")
            {
                fpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Contained;
            }
            else if (comboBox1.Text == "ヘッダの領域に含まれるセルをすべて選択")
            {
                fpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Intersected;
            }
            else
            {
                fpSpread1.CellSpanSelectionPolicy = FarPoint.Win.Spread.CellSpanSelectionPolicy.Default;
            }
        }
    }
}
