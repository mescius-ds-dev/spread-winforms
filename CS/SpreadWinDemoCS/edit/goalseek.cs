using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class goalseek : SpreadWinDemo.DemoBase
    {
        const int ROW_PR = 2;   //代金
        const int ROW_DP = 4;   //頭金
        const int ROW_AR = 8;   //年利
        const int ROW_BR = 6;   //借入金額
        const int ROW_BM = 7;   //借入月数
        const int ROW_RP = 10;   //毎月返済額

        public goalseek()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.ColumnCount = 3;
            sheet.RowCount = 11;

            sheet.SetValue(0, 0, "マイカーローン・シミュレーション");
            sheet.AddSpanCell(0, 0, 1, 3);

            sheet.SetValue(ROW_PR, 0, "代金:");
            sheet.SetValue(ROW_DP, 0, "頭金:");
            sheet.SetValue(ROW_BR, 0, "借入金額:");
            sheet.SetValue(ROW_BM, 0, "借入月数:");
            sheet.SetValue(ROW_AR, 0, "年利(%):");
            sheet.SetValue(ROW_RP, 0, "毎月返済額:");

            sheet.SetValue(ROW_PR, 1, "1300000.");
            sheet.SetValue(ROW_DP, 1, "100000.");
            sheet.SetValue(ROW_AR, 1, "0.03");
            sheet.SetValue(ROW_BM, 1, "12");

            sheet.SetValue(ROW_PR, 2, "購入代金（変更可）");
            sheet.SetValue(ROW_DP, 2, "計算対象（ゴールシークにより算出）");
            sheet.SetValue(ROW_BR, 2, "=B3-B5");
            sheet.SetValue(ROW_BM, 2, "返済する月数（変更可）");
            sheet.SetValue(ROW_AR, 2, "年利率（変更可）");
            sheet.SetValue(ROW_RP, 2, "=INT(PMT(B9/12,B8,-B7))");

            // セル型
            sheet.Cells[ROW_PR, 1, 4, 1].CellType = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            sheet.Cells[ROW_AR, 1].CellType = new FarPoint.Win.Spread.CellType.PercentCellType();
            sheet.Cells[ROW_BR, 1].CellType = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            sheet.Cells[ROW_BM, 1].CellType = new FarPoint.Win.Spread.CellType.NumberCellType();
            sheet.Cells[ROW_RP, 1].CellType = new FarPoint.Win.Spread.CellType.CurrencyCellType();

            // タイトル
            sheet.Cells[0, 0].ForeColor = System.Drawing.Color.Blue;
            sheet.Cells[0, 0].Font = new System.Drawing.Font("メイリオ", 18, FontStyle.Underline | FontStyle.Italic);

            // 代金-罫線
            sheet.Cells[ROW_PR, 0, ROW_PR, 2].Border = new FarPoint.Win.LineBorder(Color.Gray, 2);
            sheet.Cells[ROW_PR, 0, ROW_PR, 0].ForeColor = System.Drawing.Color.White;
            sheet.Cells[ROW_PR, 0, ROW_PR, 0].BackColor = System.Drawing.Color.DarkBlue;

            // 頭金-罫線
            sheet.Cells[ROW_DP, 0, ROW_DP, 2].Border = new FarPoint.Win.LineBorder(Color.Gray, 2);
            sheet.Cells[ROW_DP, 0, ROW_DP, 0].ForeColor = System.Drawing.Color.White;
            sheet.Cells[ROW_DP, 1, ROW_DP, 2].ForeColor = System.Drawing.Color.Red;
            sheet.Cells[ROW_DP, 0, ROW_DP, 0].BackColor = System.Drawing.Color.DarkBlue;

            // 借入-罫線
            sheet.Cells[ROW_BR, 0, ROW_AR, 2].Border = new FarPoint.Win.LineBorder(Color.Gray, 2);
            sheet.Cells[ROW_BR, 0, ROW_AR, 0].ForeColor = System.Drawing.Color.White;
            sheet.Cells[ROW_BR, 0, ROW_AR, 0].BackColor = System.Drawing.Color.DarkBlue;

            // 毎月返済額-罫線
            sheet.Cells[ROW_RP, 0, ROW_RP, 2].Border = new FarPoint.Win.LineBorder(Color.Gray, 2);
            sheet.Cells[ROW_RP, 0, ROW_RP, 0].ForeColor = System.Drawing.Color.White;
            sheet.Cells[ROW_RP, 0, ROW_RP, 0].BackColor = System.Drawing.Color.DarkBlue;

            // ロック
            sheet.DefaultStyle.Locked = true;
            sheet.Cells[ROW_PR, 1].Locked = false;
            sheet.Cells[ROW_BM, 1].Locked = false;
            sheet.Cells[ROW_AR, 1].Locked = false;

            sheet.Cells[ROW_DP, 1].BackColor = System.Drawing.Color.Cornsilk;
            sheet.Cells[ROW_BR, 1].BackColor = System.Drawing.Color.Cornsilk;
            sheet.Cells[ROW_RP, 1].BackColor = System.Drawing.Color.Cornsilk;

            // 計算式設定
            sheet.SetFormula(ROW_BR, 1, "B" + Convert.ToString(ROW_PR + 1) + "-B" + Convert.ToString(ROW_DP + 1));
            sheet.SetFormula(ROW_RP, 1, "INT(PMT(B" + Convert.ToString(ROW_AR + 1) + "/12,B" + Convert.ToString(ROW_BM + 1) + ",-B" + Convert.ToString(ROW_BR + 1) + "))");

            // 列幅の設定
            sheet.Columns[0].Width = 150;
            sheet.Columns[1].Width = 150;
            sheet.Columns[2].Width = 348;

            // 行高の設定
            sheet.Rows[0].Height = 50;
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 入力額取得
            int rp;
            int.TryParse(textBox1.Text, out rp);

            if (rp == 0)
            {
                return;
            }

            // ゴールシーク
            fpSpread1.GoalSeek(0, ROW_DP, 1, 0, ROW_RP, 1, rp);  
        }
    }
}
