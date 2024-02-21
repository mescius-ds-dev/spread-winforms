using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class multirange : SpreadWinDemo.DemoBase
    {
        public multirange()
        {
            InitializeComponent();

            fpSpread1.Features.RichClipboard = true;

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            fpSpread1.Sheets.Count = 2;
            fpSpread1.Sheets[0].SheetName = "単一から複数";
            fpSpread1.Sheets[0].Cells["B2"].Value = 1;
            fpSpread1.Sheets[0].Cells["B3"].Value = 2;
            fpSpread1.Sheets[0].Cells["C2"].Value = 3;
            fpSpread1.Sheets[0].Cells["C3"].Value = 4;
            fpSpread1.Sheets[0].Cells["B10"].Value = "単一のセル範囲をコピーして複数のセル範囲にペースト";
            fpSpread1.Sheets[0].Cells["B11"].Value = "1.セルB2からC3を選択します";
            fpSpread1.Sheets[0].Cells["B12"].Value = "2.［Ctrl］+［C］をタイプしてコピーします";
            fpSpread1.Sheets[0].Cells["B13"].Value = "3.セルB5をクリックし［Ctrl］を押下しながらセルB8をクリックします";
            fpSpread1.Sheets[0].Cells["B14"].Value = "4.［Ctrl］+［V］でペーストします";
            fpSpread1.Sheets[0].Cells["B10"].ColumnSpan = 6;
            fpSpread1.Sheets[0].Cells["B11"].ColumnSpan = 6;
            fpSpread1.Sheets[0].Cells["B12"].ColumnSpan = 6;
            fpSpread1.Sheets[0].Cells["B13"].ColumnSpan = 6;
            fpSpread1.Sheets[0].Cells["B14"].ColumnSpan = 6;

            fpSpread1.Sheets[1].SheetName = "複数から単一";
            fpSpread1.Sheets[1].Cells["B2"].Value = 1;
            fpSpread1.Sheets[1].Cells["B3"].Value = 2;
            fpSpread1.Sheets[1].Cells["B4"].Value = 3;
            fpSpread1.Sheets[1].Cells["B5"].Value = 4;
            fpSpread1.Sheets[1].Cells["B7"].Value = "1.セルB2をクリックし［Ctrl］を押下しながらセルB4とB5をクリックします";
            fpSpread1.Sheets[1].Cells["B8"].Value = "2.［Ctrl］+［C］をタイプしてコピーします";
            fpSpread1.Sheets[1].Cells["B9"].Value = "3.セルD2をクリックし［Ctrl］+［V］でペーストします";
            fpSpread1.Sheets[1].Cells["B7"].ColumnSpan = 6;
            fpSpread1.Sheets[1].Cells["B8"].ColumnSpan = 6;
            fpSpread1.Sheets[1].Cells["B9"].ColumnSpan = 6;
        }
    }
}
