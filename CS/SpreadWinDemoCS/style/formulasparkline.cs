using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class formulasparkline : SpreadWinDemo.DemoBase
    {
        public formulasparkline()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            spread.Features.EnhancedShapeEngine = true;

            InitAreaSparkline(spread.ActiveSheet);
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;
        }

        private void InitAreaSparkline(FarPoint.Win.Spread.SheetView sheetView)
        {
            var worksheet = sheetView.AsWorksheet();
            worksheet.Name = "Area";
            worksheet.Cells["A1:E1"].Merge();
            worksheet.Rows["1"].RowHeight = 32;

            worksheet.Cells["A1"].Text = "Revenue by State";
            worksheet.Cells["A1"].VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center;
            worksheet.Cells["A1"].Font.ApplyFont(new GrapeCity.Spreadsheet.Font() { Name = "Arial", Size = 17 });

            var table = worksheet.Tables.Add("A2:E6", GrapeCity.Spreadsheet.YesNoGuess.Guess, FarPoint.Win.Spread.TableStyle.TableStyleLight1);
            table.ShowAutoFilter = false;

            worksheet.SetValue(1, 0, new object[,]
            {
                { "State", 2018, 2019, 2020, "Diagram" },
                { "Idaho", 10000, -9000, 15000, null },
                { "Montana", 1000, 9000, null, null },
                { "Oregon", 10000, 7000, 0, null },
                { "Washington", 1000, 10000, 5000, null },
                { "Utah", -5000, 5000, 12000, null }
            });

            worksheet.Cells["B3:D7"].CellType = new FarPoint.Win.Spread.CellType.CurrencyCellType() { DecimalPlaces = 0 };
            worksheet.Cells["E3"].Formula = "AREASPARKLINE(B3:D3,,,0,10000,\"#82bc00\",\"#f7a711\")";
            worksheet.Cells["E4"].Formula = "AREASPARKLINE(B4:D4,,,0,10000,\"#82bc00\",\"#f7a711\")";
            worksheet.Cells["E5"].Formula = "AREASPARKLINE(B5:D5,,,0,10000,\"#82bc00\",\"#f7a711\")";
            worksheet.Cells["E6"].Formula = "AREASPARKLINE(B6:D6,,,0,10000,\"#82bc00\",\"#f7a711\")";
            worksheet.Cells["E7"].Formula = "AREASPARKLINE(B7:D7,,,0,10000,\"#82bc00\",\"#f7a711\")";

            worksheet.Rows["1"].RowHeight = 50;
            worksheet.Rows["2"].RowHeight = 25;
            worksheet.Rows["3:7"].RowHeight = 35;

            worksheet.Columns["A"].ColumnWidth = 100;
            worksheet.Columns["B:D"].ColumnWidth = 80;
            worksheet.Columns["E"].ColumnWidth = 200;
        }
    }
}
