using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class border : SpreadWinDemo.DemoBase
    {
        public border()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            // 行列数の設定
            sheet.RowCount = 10;
            sheet.ColumnCount = 5;

            // 列幅の設定
            sheet.Columns[1].Width = 120;
            sheet.Columns[3].Width = 120;

            // 行の高さの設定
            sheet.Rows[1].Height = 30;
            sheet.Rows[3].Height = 30;
            sheet.Rows[5].Height = 30;
            sheet.Rows[7].Height = 30;

            // ベベル罫線（凹）の設定
            FarPoint.Win.BevelBorder bevelbrdr1 = new FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered, SystemColors.ControlLightLight, SystemColors.ControlDark, 3, true, true, true, true);            
            sheet.Cells[1, 1].Border = bevelbrdr1;
            sheet.Cells[1, 1].Value = "ベベル罫線（凹）";

            // ベベル罫線（凸）の設定
            FarPoint.Win.BevelBorder bevelbrdr2 = new FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Raised, SystemColors.ControlLightLight, SystemColors.ControlDark, 3, true, true, true, true);  
            sheet.Cells[3, 1].Border = bevelbrdr2;
            sheet.Cells[3, 1].Value = "ベベル罫線（凸）";

            // 複合罫線の設定
            FarPoint.Win.ComplexBorderSide cbs1 = new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.ThickLine, Color.Red);
            FarPoint.Win.ComplexBorderSide cbs2 = new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.DoubleLine, Color.Blue);
            FarPoint.Win.ComplexBorderSide cbs3 = new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.DashDot, Color.Green);
            FarPoint.Win.ComplexBorderSide cbs4 = new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumDashed, Color.Yellow);
            FarPoint.Win.ComplexBorder cbrdr = new FarPoint.Win.ComplexBorder(cbs1, cbs2, cbs3, cbs4);
            sheet.Cells[5, 1].Border = cbrdr;
            sheet.Cells[5, 1].Value = "複合罫線";

            // 合成罫線の設定
            FarPoint.Win.ComplexBorderSide cbside1 = new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.MediumDashed);
            FarPoint.Win.ComplexBorderSide cbside2 = new FarPoint.Win.ComplexBorderSide();
            FarPoint.Win.ComplexBorder cblb = new FarPoint.Win.ComplexBorder(cbside1);
            FarPoint.Win.ComplexBorder cbtb = new FarPoint.Win.ComplexBorder(cbside2);
            FarPoint.Win.CompoundBorder compoundbrdr = new FarPoint.Win.CompoundBorder(cblb, cbtb, 3, Color.Red);
            sheet.Cells[1, 3].Border = compoundbrdr;
            sheet.Cells[1, 3].Value = "合成罫線";

            // 二重罫線の設定
            FarPoint.Win.DoubleLineBorder dblbrd = new FarPoint.Win.DoubleLineBorder(Color.Green);
            sheet.Cells[3, 3].Border = dblbrd;
            sheet.Cells[3, 3].Value = "二重罫線";

            // 標準罫線の設定
            FarPoint.Win.LineBorder lbbrd = new FarPoint.Win.LineBorder(Color.Red, 2);
            sheet.Cells[5, 3].Border = lbbrd;
            sheet.Cells[5, 3].Value = "標準罫線";

            // 角丸罫線の設定
            FarPoint.Win.RoundedLineBorder rlbrd = new FarPoint.Win.RoundedLineBorder(Color.Blue, 2);
            sheet.Cells[7, 3].Border = rlbrd;
            sheet.Cells[7, 3].Value = "角丸罫線";
        }
    }
}
