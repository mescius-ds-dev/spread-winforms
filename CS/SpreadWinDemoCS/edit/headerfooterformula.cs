using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class headerfooterformula : SpreadWinDemo.DemoBase
    {
        public headerfooterformula()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum2.xml"));
            sheet.DataSource = ds;
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定			
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            // 合計列追加
            workbook.ActiveSheet.InsertColumns(7, 1);
            workbook.ActiveSheet.ColumnHeader.Cells[0, 7].Text = "総合計";

            // 列合計の算出
            workbook.ActiveSheet.ColumnFooter.Visible = true;
            workbook.ActiveSheet.ColumnFooter.Cells[0, 3].Formula = "SUM(Sheet1!D:D)";
            workbook.ActiveSheet.ColumnFooter.Cells[0, 4].Formula = "SUM(Sheet1!E:E)";
            workbook.ActiveSheet.ColumnFooter.Cells[0, 5].Formula = "SUM(Sheet1!F:F)";
            workbook.ActiveSheet.ColumnFooter.Cells[0, 6].Formula = "SUM(Sheet1!G:G)";

            // 総合計の算出
            workbook.ActiveSheet.ColumnFooter.Cells[0, 7].Formula = "SUM(Sheet1[[#集計],$D$1:$G$1])";

            // 列幅の設定
            workbook.ActiveSheet.Columns[0].ColumnWidth  = 45;
            workbook.ActiveSheet.Columns[1].ColumnWidth = 85;
            workbook.ActiveSheet.Columns[2].ColumnWidth = 135;
            workbook.ActiveSheet.Columns[3].ColumnWidth = 65;
            workbook.ActiveSheet.Columns[4].ColumnWidth = 65;
            workbook.ActiveSheet.Columns[5].ColumnWidth = 65;
            workbook.ActiveSheet.Columns[6].ColumnWidth = 65;
            workbook.ActiveSheet.Columns[7].ColumnWidth = 103;
        }
    }
}
