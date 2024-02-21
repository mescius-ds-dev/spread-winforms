using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class autoformat : SpreadWinDemo.DemoBase
    {
        public autoformat()
        {
            InitializeComponent();

            // 数式のオートフォーマットを有効
            GrapeCity.Spreadsheet.IWorkbook workbook = fpSpread1.AsWorkbook();
            workbook.Features.AutoFormatting = true;

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

            workbook.ActiveSheet.Columns[0, 3].ColumnWidth = 150;
            workbook.ActiveSheet.ColumnHeader.Cells[0, 0].Text = "書式";
            workbook.ActiveSheet.ColumnHeader.Cells[0, 1].Text = "関数";
            workbook.ActiveSheet.ColumnHeader.Cells[0, 2].Text = "表示";
            workbook.ActiveSheet.ColumnHeader.Cells[0, 3].Text = "参照用データ";

            // 参照用データ
            workbook.ActiveSheet.Cells[4, 3].Value = 500;
            workbook.ActiveSheet.Cells[5, 3].Value = 1000;
            workbook.ActiveSheet.Cells[4, 3, 5, 3].NumberFormat = "¥#,##0;¥-#,##0";

            // 日付書式
            fpSpread1.AsWorkbook().ActiveSheet.Cells[0, 0].Text = "日付書式";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[0, 0, 1, 0].Merge();
            fpSpread1.AsWorkbook().ActiveSheet.Cells[0, 1].Text = "Today()";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[0, 2].Formula = "Today()";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[1, 1].Text = "Date(2021, 1, 1)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[1, 2].Formula = "Date(2021, 1, 1)";

            // 数値書式
            fpSpread1.AsWorkbook().ActiveSheet.Cells[2, 0].Text = "数値書式";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[2, 0, 3, 0].Merge();
            fpSpread1.AsWorkbook().ActiveSheet.Cells[2, 1].Text = "RATE(60,-5,150)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[2, 2].Formula = "RATE(60,-5,150)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[3, 1].Text = "DB(500000,5000,5,1,10)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[3, 2].Formula = "DB(500000,5000,5,1,10)";

            // セル参照書式
            fpSpread1.AsWorkbook().ActiveSheet.Cells[4, 0].Text = "セル参照書式";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[4, 0, 5, 0].Merge();
            fpSpread1.AsWorkbook().ActiveSheet.Cells[4, 1].Text = "SUM(D5:D6)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[4, 2].Formula = "SUM(D5:D6)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[5, 1].Text = "AVERAGE(D5:D6)";
            fpSpread1.AsWorkbook().ActiveSheet.Cells[5, 2].Formula = "AVERAGE(D5:D6)";
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GrapeCity.Spreadsheet.IWorkbook workbook = fpSpread1.AsWorkbook();

            if (checkBox1.Checked)
            {
                workbook.Features.AutoFormatting = true;
            }
            else
            {
                workbook.Features.AutoFormatting = false;
            }

            fpSpread1.ActiveSheet.Reset();
            InitWorkbook(fpSpread1.AsWorkbook());
        }
    }
}
