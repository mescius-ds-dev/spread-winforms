using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class backcolorrotation : SpreadWinDemo.DemoBase
    {
        public backcolorrotation()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 行列数の設定
            sheet.RowCount = 11;
            sheet.ColumnCount = 8;

            // テストデータの設定
            sheet.SetClip(0, 0, 1, 8, "店舗\t4月\t5月\t6月\t7月\t8月\t9月\t合計");
            sheet.SetClip(1, 0, 1, 7, "本店\t72623\t81731\t76801\t55815\t20603\t55887");
            sheet.SetClip(2, 0, 1, 7, "中町店\t24866\t11074\t46700\t77159\t65751\t43277");
            sheet.SetClip(3, 0, 1, 7, "駅前店\t77108\t40415\t16599\t98503\t10900\t30667");
            sheet.SetClip(4, 0, 1, 7, "二丁目店\t29351\t69757\t86497\t19848\t56048\t18057");
            sheet.SetClip(5, 0, 1, 7, "南町店\t81593\t99098\t56396\t41192\t1197\t5447");
            sheet.SetClip(6, 0, 1, 7, "中央通り店\t33836\t28441\t26296\t62536\t46345\t92836");
            sheet.SetClip(7, 0, 1, 7, "モール店\t86078\t57783\t96194\t83881\t91493\t80226");
            sheet.SetClip(8, 0, 1, 7, "パーク店\t38321\t87124\t66093\t5226\t36642\t67616");
            sheet.SetClip(9, 0, 1, 7, "ガーデン店\t90563\t16467\t35992\t26570\t81791\t55006");
            sheet.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            sheet.Cells[0, 0].ForeColor = Color.FromArgb(129, 133, 139);
            sheet.Cells[0, 0].Font = new Font("メイリオ", 12);

            // テキストおよび背景色の回転
            sheet.EnableDiagonalLine = true;            
            FarPoint.Win.Spread.CellType.TextCellType tcell = new FarPoint.Win.Spread.CellType.TextCellType();
            tcell.TextRotationAngle = 45;
            tcell.TextOrientation = FarPoint.Win.TextOrientation.TextRotateCustom;
            sheet.Cells[0, 1, 0, 7].CellType = tcell;            
            sheet.Cells[0, 1].BackColor = Color.FromArgb(65, 138, 179);
            sheet.Cells[0, 1].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(65, 138, 179)));
            sheet.Cells[0, 2].BackColor = Color.FromArgb(167, 183, 43);
            sheet.Cells[0, 2].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(167, 183, 43)));
            sheet.Cells[0, 3].BackColor = Color.FromArgb(246, 146, 0);
            sheet.Cells[0, 3].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(246, 146, 0)));
            sheet.Cells[0, 4].BackColor = Color.FromArgb(131, 131, 132);
            sheet.Cells[0, 4].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(131, 131, 132)));
            sheet.Cells[0, 5].BackColor = Color.FromArgb(253, 196, 10);
            sheet.Cells[0, 5].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(253, 196, 10)));
            sheet.Cells[0, 6].BackColor = Color.FromArgb(223, 84, 39);
            sheet.Cells[0, 6].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(223, 84, 39)));
            sheet.Cells[0, 7].BackColor = Color.FromArgb(65, 138, 179);
            sheet.Cells[0, 7].Border = new FarPoint.Win.ComplexBorder(new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumLine, Color.FromArgb(65, 138, 179)));
            sheet.Cells[1, 1, 10, 1].BackColor = Color.FromArgb(215, 231, 240);
            sheet.Cells[1, 2, 10, 2].BackColor = Color.FromArgb(242, 245, 208);
            sheet.Cells[1, 3, 10, 3].BackColor = Color.FromArgb(254, 233, 202);
            sheet.Cells[1, 4, 10, 4].BackColor = Color.FromArgb(229, 230, 230);
            sheet.Cells[1, 5, 10, 5].BackColor = Color.FromArgb(247, 242, 205);
            sheet.Cells[1, 6, 10, 6].BackColor = Color.FromArgb(248, 220, 211);
            sheet.Cells[1, 7, 10, 7].BackColor = Color.FromArgb(215, 231, 240);
            
            // 合計の計算
            FarPoint.Win.Spread.CellType.CurrencyCellType currcell = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            currcell.ShowSeparator = true;
            sheet.Cells[1, 1, 10, 7].CellType = currcell;
            sheet.Cells[1, 7].Formula = "SUM(B2:G2)";
            sheet.Cells[2, 7].Formula = "SUM(B3:G3)";
            sheet.Cells[3, 7].Formula = "SUM(B4:G4)";
            sheet.Cells[4, 7].Formula = "SUM(B5:G5)";
            sheet.Cells[5, 7].Formula = "SUM(B6:G6)";
            sheet.Cells[6, 7].Formula = "SUM(B7:G7)";
            sheet.Cells[7, 7].Formula = "SUM(B8:G8)";
            sheet.Cells[8, 7].Formula = "SUM(B9:G9)";
            sheet.Cells[9, 7].Formula = "SUM(B10:G10)";
            sheet.Cells[10, 1].Formula = "SUM(B2:B10)";
            sheet.Cells[10, 2].Formula = "SUM(C2:C10)";
            sheet.Cells[10, 3].Formula = "SUM(D2:D10)";
            sheet.Cells[10, 4].Formula = "SUM(E2:E10)";
            sheet.Cells[10, 5].Formula = "SUM(F2:F10)";
            sheet.Cells[10, 6].Formula = "SUM(G2:G10)";
            sheet.Cells[10, 7].Formula = "SUM(H2:H10)";
            sheet.Cells[10, 0].Value = "合計";
            sheet.FrozenTrailingRowCount = 1;

            // 行高列幅の設定
            sheet.Rows[0].Height = 30;
            sheet.Rows[1, 10].Height = 30;
            sheet.Columns[0].Width = 90;
            sheet.Columns[1, 7].Width = 80;
        }  
    }
}
