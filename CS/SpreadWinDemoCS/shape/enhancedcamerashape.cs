using FarPoint.Win.Spread;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.shape
{
    public partial class enhancedcamerashape : SpreadWinDemo.DemoBase
    {
        public enhancedcamerashape()
        {
            InitializeComponent();

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());

            // SPREADの設定
            InitSpread(fpSpread1);
        }


        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            spread.Features.EnhancedShapeEngine = true;
            spread.Features.RichClipboard = true;
            spread.Sheets.Count = 4;
            spread.ComboSelChange += fpSpread1_ComboSelChange;

            InitAreaSparkline(spread.Sheets[3]);
            InitPieSparkline(spread.Sheets[2]);
            InitParetoSparkline(spread.Sheets[1]);
            InitCameraShape(spread.Sheets[0]);
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;
        }

        private void InitCameraShape(FarPoint.Win.Spread.SheetView sheetView)
        {
            var worksheet = sheetView.AsWorksheet();
            var workbook = worksheet.Workbook;
            worksheet.Name = "CameraShape";

            worksheet.SetValue(1, 0, "Select :");
            worksheet.Cells["B2"].CellType = new FarPoint.Win.Spread.CellType.ComboBoxCellType()
            {
                Items = new string[] { "Late Arrivals By Reported Cause", "My Assets", "Revenue By State" },
                EditorValue = FarPoint.Win.Spread.CellType.EditorValue.Index,
                StopEditingAfterDropDownItemSelected = true
            };
            worksheet.Cells["B2"].Value = 0;
            workbook.Names.Add("SelectedRange", "=IF(CameraShape!$B$2=0,Pareto!$A$1:$E$8,IF(CameraShape!$B$2=1,Pie!$A$1:$D$8,Area!$A$1:$D$7))");
            worksheet.Columns["A:B"].AutoFit();

            workbook.Worksheets[1].Cells["$A$1:$E$8"].Copy(true);
            worksheet.Activate();
            worksheet.Pictures.Paste("A4", true);
            Clipboard.Clear();
        }

        private void InitParetoSparkline(SheetView sheetView)
        {
            var worksheet = sheetView.AsWorksheet();
            worksheet.Name = "Pareto";

            worksheet.SetValue(1, 0, new object[,] {
                { "Reason", "Cases", "Color", "Bar Size", "Diagram" },
                { "Traffic", 20, "#CCCCCC", 0.1, null },
                { "Child care", 15, "#82BC00", 0.3, null },
                { "Public transportation", 13, "#F7A711", 0.5, null },
                { "Weather", 6, "#00C2D6", 0.7, null },
                { "Overslept", 4, "#FFE7BA", 0.8, null },
                { "Emergency", 1, "#000000", 1, null }
            });

            worksheet.Cells["A11:I11"].Merge();
            worksheet.Cells["A11"].Value = "*Result: By the sparkline above can draw a conclusion that the reasons for 80% of the employees be late are \"traffic\", \"child care\" and \"public transportation\".";

            for (int index = 2; index < 8; index++)
            {
                worksheet.Cells[$"E{index + 1}"].Formula2 = $"PARETOSPARKLINE($B$3:$B$8,ROW()-2,$C$3:$C$8,0.5,0.8,0,2,false,\"gray\",\"orange\",$C$3:$C$8,$D$3:$D$8)";
            }

            for (int i = 1; i < 4; i++)
            {
                worksheet.Columns[$"{(char)(i + 65)}"].ColumnWidth = 80;
            }

            worksheet.Columns["E"].ColumnWidth = 340;
            worksheet.Columns["A"].ColumnWidth = 140;
            worksheet.Rows["1"].RowHeight = 35;
            worksheet.Cells["A1:E1"].Merge();

            worksheet.Cells["A1"].Value = "Late Arrivals by Reported Cause";
            worksheet.Cells["A1"].VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center;
            worksheet.Cells["A1"].Font.ApplyFont(new GrapeCity.Spreadsheet.Font() { Name = "Arial", Size = 10, Bold = true });
            sheetView.Cells["A1"].BackColor = System.Drawing.Color.Gray;
            sheetView.Cells["A1"].ForeColor = System.Drawing.Color.White;

            worksheet.Cells["A2:D8"].HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.Left;
            worksheet.Cells["A2:E2"].Font.ApplyFont(new GrapeCity.Spreadsheet.Font() { Name = "Arial", Size = 10, Bold = true });
            worksheet.Cells["A2:E2"].Borders.ApplyBorder(new GrapeCity.Spreadsheet.Border()
            {
                Bottom = new GrapeCity.Spreadsheet.BorderLine(GrapeCity.Spreadsheet.BorderLineStyle.Thin, GrapeCity.Spreadsheet.Color.FromKnownColor(GrapeCity.Core.KnownColor.Black))
            });
        }

        private void InitPieSparkline(FarPoint.Win.Spread.SheetView sheetView)
        {
            var worksheet = sheetView.AsWorksheet();
            worksheet.Name = "Pie";

            worksheet.Cells["A1:D1"].Merge();

            var range = worksheet.Cells["A1"];
            range.Value = "My Assets";
            range.Font.ApplyFont(new GrapeCity.Spreadsheet.Font() { Name = "Arial", Size = 17 });
            range.VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center;

            for (int i = 65; i < 69; i++)
            {
                sheetView.Cells[$"{Convert.ToChar(i)}2"].BackColor = ColorTranslator.FromHtml("#E3E3E3");
            }

            worksheet.SetValue(1, 0, new object[,]
            {
                { "Asset Type", "Amount", "Diagram", "Note" },
                { "House", 120000, null, null },
                { "401k", 78000, null, null },
                { "Savings", 25000, null, null },
                { "Bonds", 15000, null, null },
                { "Stocks", 9000, null, null },
                { "Car", 7500, null, null }
            });

            worksheet.Cells["C3:C8"].Merge();
            worksheet.Cells["C3"].Formula2 = "PIESPARKLINE(B3:B8,\"#82bc00\",\"#96c63f\",\"#aacf62\",\"#bcd983\",\"#cee3a3\",\"#dfecc3\")";

            sheetView.Cells["D3"].BackColor = ColorTranslator.FromHtml("#82bc00");
            worksheet.Cells["D3"].Formula = "B3/SUM(B3:B8)";
            sheetView.Cells["D4"].BackColor = ColorTranslator.FromHtml("#96c63f");
            worksheet.Cells["D4"].Formula = "B4/SUM(B3:B8)";
            sheetView.Cells["D5"].BackColor = ColorTranslator.FromHtml("#aacf62");
            worksheet.Cells["D5"].Formula = "B5/SUM(B3:B8)";
            sheetView.Cells["D6"].BackColor = ColorTranslator.FromHtml("#bcd983");
            worksheet.Cells["D6"].Formula = "B6/SUM(B3:B8)";
            sheetView.Cells["D7"].BackColor = ColorTranslator.FromHtml("#cee3a3");
            worksheet.Cells["D7"].Formula = "B7/SUM(B3:B8)";
            sheetView.Cells["D8"].BackColor = ColorTranslator.FromHtml("#dfecc3");
            worksheet.Cells["D8"].Formula = "B8/SUM(B3:B8)";

            worksheet.Cells["D3:D8"].CellType = new FarPoint.Win.Spread.CellType.PercentCellType()
            {
                DecimalPlaces = 2
            };

            worksheet.Cells["B3:B8"].CellType = new FarPoint.Win.Spread.CellType.CurrencyCellType()
            {
                ShowCurrencySymbol = true,
                DecimalPlaces = 0,
                ShowSeparator = true,
                CurrencySymbol = "$"
            };

            worksheet.Rows["1"].RowHeight = 30;
            worksheet.Rows["2:8"].RowHeight = 25;
            worksheet.Columns["A"].ColumnWidth = 100;
            worksheet.Columns["B"].ColumnWidth = 100;
            worksheet.Columns["C"].ColumnWidth = 200;
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

        private void fpSpread1_ComboSelChange(object sender, EditorNotifyEventArgs e)
        {
            fpSpread1.AsWorkbook().ActiveSheet.Shapes[0].Formula = "SelectedRange";
        }
    }
}
