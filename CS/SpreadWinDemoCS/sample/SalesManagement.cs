using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SpreadWinDemo.sample
{
    public partial class SalesManagement : SpreadWinDemo.DemoBase
    {
        BindingList<StoreOfSales> StoretoSalesData { get; set; } = new BindingList<StoreOfSales>();

        public SalesManagement()
        {
            InitializeComponent();

            ImportButton.Click += (s, e) => FileImport();
            ExportButton.Click += (s, e) => FileExport();

            StoreSpread.SelectionChanged += (s, e) => 
                SalesSpread.AsWorkbook().Worksheets[
                    new string[] { StoreSpread.ActiveSheet.Cells[StoreSpread.ActiveSheet.ActiveRowIndex, 0].Text }
                    ].Select();
            SalesSpread.ActiveSheetChanged += (s, e) =>
            {
                if (SalesSpread.ActiveSheet == null || StoretoSalesData.Count == 0)
                    return;

                var index = StoretoSalesData.IndexOf(StoretoSalesData.First(x => x.StoreName == SalesSpread.ActiveSheet.SheetName));

                if (index == StoreSpread.ActiveSheet.ActiveRowIndex) return;

                StoreSpread.ActiveSheet.SetActiveCell(index, 0);
            };

            StoreSpread.DataSource = StoretoSalesData;

            InitStoreSpread();
            InitSalesSpread();
        }

        private void InitStoreSpread()
        {
            StoreSpread.ActiveSheet.Rows.Count = 0;
            StoreSpread.ActiveSheet.ColumnCount = 4;
            StoreSpread.ActiveSheet.ColumnHeader.Columns[0].Label = "店舗名";
            StoreSpread.ActiveSheet.ColumnHeader.Columns[1].Label = "売上";
            StoreSpread.ActiveSheet.ColumnHeader.Columns[2].Label = "原価";
            StoreSpread.ActiveSheet.ColumnHeader.Columns[3].Label = "粗利率";
            StoreSpread.ActiveSheet.Columns[3].Formula = "(B1-C1)/B1";

            SetStoreSpreadColumns();
            SetFontSheet(StoreSpread.ActiveSheet);
        }

        private void SetStoreSpreadColumns()
        {
            var numberCell = new FarPoint.Win.Spread.CellType.NumberCellType()
            {
                DecimalPlaces = 0,
                Separator = ",",
                ShowSeparator = true,
            };
            StoreSpread.ActiveSheet.Columns[1].CellType = numberCell;
            StoreSpread.ActiveSheet.Columns[2].CellType =  numberCell;

            StoreSpread.ActiveSheet.Columns[3].CellType = new NumberCellType() { DecimalPlaces = 2 };

            for (int i = 0; i < StoreSpread.Sheets[0].ColumnCount; i++)
            {
                StoreSpread.ActiveSheet.ColumnHeader.Columns[i].Width = StoreSpread.ActiveSheet.GetPreferredColumnWidth(i, false, false, false) + 10;
            }
        }

        private void SetFontSheet(SheetView sheet)
        {
            for (int i = 0; i < sheet.Columns.Count; i++)
            {
                sheet.ColumnHeader.Columns[i].Font = new System.Drawing.Font("メイリオ", 11);
                sheet.Columns[i].Font = new System.Drawing.Font("メイリオ", 11);
            }
        }

        private void InitSalesSpread()
        {
            SalesSpread.Sheets.Count = 0;
            SalesSpread.ShowOutline = RowCol.Columns;
        }

        private void FileImport()
        {
            using (var dialog = new OpenFileDialog()
            {
                InitialDirectory = System.IO.Path.GetFullPath(@"..\..\SampleData"),
                Filter = @"Excel ファイル|*.xls;*.xlsx;|全てのファイル|*.*",
                FilterIndex = 1,
                Title = @"インポートする売上ファイルを選択してください。",
                Multiselect = true,
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                try
                { 
                    Cursor = Cursors.WaitCursor;
                    ImportExcelFiles(dialog.FileNames);
                }
                finally { Cursor = Cursors.Default; }
            }
        }

        private void ImportExcelFiles(string[] filePaths)
        {
            foreach (var filePath in filePaths)
            {
                ImportExcelFile(new FileInfo(filePath));
            }
            SetStoreSpreadColumns();

            var rule = new TopRankedValuesConditionalFormattingRule()
            {
                IsDescending = true,
                Rank = 1,
                BackColor = System.Drawing.Color.Gold
            };

            StoreSpread.ActiveSheet.SetConditionalFormatting(0, 1, StoreSpread.ActiveSheet.RowCount, 1, rule);
        }

        private void ImportExcelFile(FileInfo file)
        {
            var sheetName = GetSheetName(file.Name);
            var index = GetSheetIndex(sheetName);

            if (-1 < index)
            {
                if (DialogResult.No == MessageBox.Show(
                    "同名の支店ファイルを既にインポートしています。再度インポートしますか？"
                    , "確認"
                    , MessageBoxButtons.YesNo)) return;

                SalesSpread.Sheets.RemoveAt(index);
            }

            var newSheet = new SheetView();
            SalesSpread.Sheets.Add(newSheet);
            SalesSpread.Sheets[SalesSpread.Sheets.Count - 1].OpenExcel(file.FullName, 0);
            SalesSpread.Sheets[SalesSpread.Sheets.Count - 1].RemoveRows(0, 1);
            newSheet.SheetName = sheetName;
            CreateSheetSalesSpread(newSheet);

            CreateStoreSales(SalesSpread.Sheets[SalesSpread.Sheets.Count - 1]);
        }

        private string GetSheetName(string filePath)
        {
            var fileName = Path.GetFileName(filePath);
            var removeFileName = fileName.Remove(0, fileName.IndexOf("_") + 1);
            return removeFileName.Remove(removeFileName.IndexOf("."));
        }

        private int GetSheetIndex(string sheetName)
        {
            for (int i = 0; i < SalesSpread.Sheets.Count; i++)
            {
                if (SalesSpread.Sheets[i].SheetName == sheetName) return i;
            }

            return -1;
        }

        private void CreateSheetSalesSpread(SheetView sheet)
        {
            sheet.ColumnCount = 8;
            sheet.ColumnHeader.Columns[0].Label = "販売日";
            sheet.ColumnHeader.Columns[1].Label = "商品番号";
            sheet.ColumnHeader.Columns[2].Label = "商品名";
            sheet.ColumnHeader.Columns[3].Label = "単価";
            sheet.ColumnHeader.Columns[4].Label = "個数";
            sheet.ColumnHeader.Columns[5].Label = "売上";
            sheet.ColumnHeader.Columns[6].Label = "原価";
            sheet.ColumnHeader.Columns[7].Label = "粗利率";
            sheet.Columns[7].Formula = "(F1-G1)/F1";
            sheet.Columns[7].CellType = new NumberCellType() { DecimalPlaces = 2 };

            SetFontSheet(sheet);

            sheet.AddRangeGroup(1, 4, false);
            sheet.ExpandRangeGroup(1,4,false,false);
            sheet.SetColumnMerge(0, FarPoint.Win.Spread.Model.MergePolicy.Always);
        }

        private void CreateStoreSales(SheetView salesSheet)
        {
            var storeSales = new StoreOfSales { StoreName = salesSheet.SheetName };

            for (int i = 0; i < salesSheet.RowCount; i++)
            {
                if (salesSheet.Cells[i, 0].Value is null) break;

                storeSales.Sales += int.Parse(salesSheet.Cells[i, 5].Value.ToString());
                storeSales.Cost += int.Parse(salesSheet.Cells[i, 6].Value.ToString());
            }

            MergeStoretoSales(storeSales);
        }

        private void MergeStoretoSales(StoreOfSales storeSales)
        {
            var first = StoretoSalesData.FirstOrDefault(x => x.StoreName == storeSales.StoreName);

            if (first is null)
            {
                StoretoSalesData.Add(storeSales);
            }
            else
            {
                first.Sales = storeSales.Sales;
                first.Cost = storeSales.Cost;
            }
        }

        private void FileExport()
        {
            using (var dialog = new FolderBrowserDialog()
            {
                Description = "ファイルを出力するフォルダを指定してください。",
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = true
            })
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;

                var directory = new DirectoryInfo(dialog.SelectedPath);
                StoreSpread.SaveExcel(Path.Combine(directory.FullName, @"店舗売上ファイル.xlsx")
                   , FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat
                   | FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders); ;

                MessageBox.Show("ファイル出力が完了しました。");
            };
        }

        private class StoreOfSales
        {
            public string StoreName { get; set; }
            public int Sales { get; set; }
            public int Cost { get; set; }
        }
    }
}
