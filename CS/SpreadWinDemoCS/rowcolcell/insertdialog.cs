using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class insertdialog : SpreadWinDemo.DemoBase
    {
        public insertdialog()
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

            fpSpread1.Features.ExcelCompatibleKeyboardShortcuts = true;
            fpSpread1.Features.RichClipboard = true;
            GrapeCity.Spreadsheet.IWorksheet sheet1 = workbook.ActiveSheet;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sheet1.Cells[i, j].Value = i + j;
                }
            }
        }
    }
}
