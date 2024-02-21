using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class excelshortcut : SpreadWinDemo.DemoBase
    {
        public excelshortcut()
        {
            InitializeComponent();

            fpSpread1.Features.ExcelCompatibleKeyboardShortcuts = true;

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            GrapeCity.Spreadsheet.IWorksheet sheet1 = workbook.Worksheets[0];
            GrapeCity.Spreadsheet.ITable table1 = sheet1.Cells["B2:E7"].CreateTable(true);
            sheet1.SetValue(1, 1, new object[,]
            {
                { "ID", "Qty", "Price" },
                { 1, 10, 9.5 },
                { 2, 15, 7.25 },
                { 3, 8, 16.0 },
                { 4, 12, 8.2 },
                { 5, 22, 11.52 },
            });
            sheet1.Cells["E2"].Value = "Total";
            table1.TableColumns[2].DataBodyRange.NumberFormat = "$0.00";
            table1.TableColumns[3].DataBodyRange.NumberFormat = "$0.00";

            GrapeCity.Spreadsheet.IWorksheet sheet2 = workbook.Worksheets.Add("種類");

            // Excel互換のショートカットキーの種類
            sheet2.Cells[0, 0].Value = "シート";
            sheet2.Cells[0, 0, 3, 0].Merge();

            sheet2.Cells[0, 1].Value = "Ctrl + Shift + @：";
            sheet2.Cells[0, 1, 0, 2].Merge();
            sheet2.Cells[1, 1].Value = "Ctrl + 1：";
            sheet2.Cells[1, 1, 1, 2].Merge();
            sheet2.Cells[2, 1].Value = "Ctrl + K：";
            sheet2.Cells[2, 1, 2, 2].Merge();
            sheet2.Cells[3, 1].Value = "Ctrl + Enter：";
            sheet2.Cells[3, 1, 3, 2].Merge();

            sheet2.Cells[0, 3].Value = "数式と計算結果の表示を切り替え";
            sheet2.Cells[0, 3, 0, 8].Merge();
            sheet2.Cells[1, 3].Value = "「セルの書式設定」を表示";
            sheet2.Cells[1, 3, 1, 8].Merge();
            sheet2.Cells[2, 3].Value = "「ハイパーリンクの挿入」を表示";
            sheet2.Cells[2, 3, 2, 8].Merge();
            sheet2.Cells[3, 3].Value = "複数セルにデータを入力";
            sheet2.Cells[3, 3, 3, 8].Merge();


            sheet2.Cells[4, 0].Value = "テーブル";
            sheet2.Cells[4, 0, 6, 0].Merge();

            sheet2.Cells[4, 1].Value = "Tab：";
            sheet2.Cells[4, 1, 4, 2].Merge();
            sheet2.Cells[5, 1].Value = "Shift + Tab：";
            sheet2.Cells[5, 1, 5, 2].Merge();
            sheet2.Cells[6, 1].Value = "Ctrl + A：";
            sheet2.Cells[6, 1, 6, 2].Merge();

            sheet2.Cells[4, 3].Value = "アクティブセルが最後の列の動作";
            sheet2.Cells[4, 3, 4, 8].Merge();
            sheet2.Cells[5, 3].Value = "アクティブセルが先頭の列の動作";
            sheet2.Cells[5, 3, 5, 8].Merge();
            sheet2.Cells[6, 3].Value = "テーブルを全選択";
            sheet2.Cells[6, 3, 6, 8].Merge();
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fpSpread1.Features.ExcelCompatibleKeyboardShortcuts = true;
            }
            else
            {
                fpSpread1.Features.ExcelCompatibleKeyboardShortcuts = false;
            }
        }
    }
}
