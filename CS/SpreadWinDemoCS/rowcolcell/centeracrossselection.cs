using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class centeracrossselection : SpreadWinDemo.DemoBase
    {
        public centeracrossselection()
        {
            InitializeComponent();

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            // セルのオーバーフローを有効
            fpSpread1.AllowCellOverflow = true;
            // 拡張罫線を有効
            fpSpread1.BorderCollapse = FarPoint.Win.Spread.BorderCollapse.Enhanced;

            fpSpread1.AsWorkbook().ActiveSheet.Cells["C2"].Text = "SPREAD for Windows Forms";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["C2:K2"].HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection;
            fpSpread1.AsWorkbook().ActiveSheet.Cells["C3"].Text = "SPREAD for Windows Forms";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["C3"].HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection; 
            fpSpread1.AsWorkbook().ActiveSheet.Cells["C4"].Text = "SPREAD for Windows Forms";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["C4:D4"].HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection;
            fpSpread1.AsWorkbook().ActiveSheet.Cells["C5"].Text = "SPREAD for Windows Forms";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["B5:C5"].HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.CenterAcrossSelection;
        }
    }
}
