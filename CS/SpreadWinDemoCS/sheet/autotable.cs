using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class autotable : SpreadWinDemo.DemoBase
    {
        public autotable()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // ユーザーに数式の入力を許可
            spread.AllowUserFormulas = true;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.RowCount = 60;
            sheet.ColumnCount = 11;

            fpSpread1.Features.AutoExpandTable = true;
            fpSpread1.Features.AutoCreateCalculatedTableColumns = true;
            GrapeCity.Spreadsheet.IWorkbook workBook = fpSpread1.AsWorkbook();
            GrapeCity.Spreadsheet.IWorksheet sheet1 = workBook.Worksheets[0];
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
            sheet1.Cells["E2"].Value = "合計";
            table1.TableColumns[2].DataBodyRange.NumberFormat = "$0.00";
            table1.TableColumns[3].DataBodyRange.NumberFormat = "$0.00";
        }
    }
}
