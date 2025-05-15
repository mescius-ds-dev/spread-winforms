using FarPoint.Win.Spread;
using GrapeCity.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class pdfexport : SpreadWinDemo.DemoBase
    {
        public pdfexport()
        {
            InitializeComponent();

            fpSpread1.Sheets.Count = 2;

            fpSpread1.Features.EnhancedShapeEngine = true;
            fpSpread1.Features.RichTextEdit = RichTextEditMode.On;
            fpSpread1.Features.ExcelCompatiblePrinting = true;
            fpSpread1.BorderCollapse = BorderCollapse.Enhanced;

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());

            // ワークシートの設定
            InitSheet1(fpSpread1.AsWorkbook().Worksheets[0]);
            InitSheet2(fpSpread1.AsWorkbook().Worksheets[1]);

            button1.Click += new EventHandler(button1_Click);
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;
        }

        private void InitSheet1(GrapeCity.Spreadsheet.IWorksheet worksheet)
        {
            // ヘッダの設定
            worksheet.Columns[0, 2].ColumnWidth = 200;
            worksheet.ColumnHeader.Cells[0, 0].Value = "分類";
            worksheet.ColumnHeader.Cells[0, 1].Value = "スタイル";
            worksheet.ColumnHeader.Cells[0, 2].Value = "表示";

            // 背景色の設定
            worksheet.Columns[0, 1].Interior.Color = GrapeCity.Spreadsheet.Color.FromThemeColor(GrapeCity.Core.ThemeColors.Background2);

            // 標準
            worksheet.Cells[0, 0].Value = "標準";
            worksheet.Cells[0, 2].NumberFormat = "G/標準";
            worksheet.Cells[0, 2].Value = 12345;

            // 数値
            // 桁区切り
            worksheet.Cells[1, 0].Value = "数値";
            worksheet.Cells[1, 1].Value = "桁区切り";
            worksheet.Cells[1, 2].NumberFormat = "#,##0_ ";
            worksheet.Cells[1, 2].Value = 12345;
            // マイナス
            worksheet.Range("A2:A3").Merge();
            worksheet.Cells[2, 1].Value = "マイナスは赤で表示";
            worksheet.Cells[2, 2].NumberFormat = "0_ ;[赤]-0 ";
            worksheet.Cells[2, 2].Value = -12345;

            // 通貨
            // 桁区切り
            worksheet.Cells[3, 0].Value = "通貨";
            worksheet.Cells[3, 1].Value = "桁区切り";
            worksheet.Cells[3, 2].NumberFormat = "¥#,##0;¥-#,##0";
            worksheet.Cells[3, 2].Value = 12345;
            // マイナス
            worksheet.Range("A4:A5").Merge();
            worksheet.Cells[4, 1].Value = "マイナスは赤で表示";
            worksheet.Cells[4, 2].NumberFormat = "¥#,##0;[赤]¥-#,##0";
            worksheet.Cells[4, 2].Value = -12345;

            // 会計
            worksheet.Cells[5, 0].Value = "会計";
            worksheet.Cells[5, 2].NumberFormat = "_ ¥* #,##0_ ;_ ¥* -#,##0_ ;_ ¥* \" - \"_ ;_ @_ ";
            worksheet.Cells[5, 2].Value = -12345;

            // 日付
            // 西暦
            worksheet.Cells[6, 0].Value = "日付";
            worksheet.Cells[6, 1].Value = "西暦";
            worksheet.Cells[6, 2].NumberFormat = "yyyy\"年\"m\"月\"d\"日\"";
            worksheet.Cells[6, 2].Value = DateTime.Now;
            // 和暦
            worksheet.Range("A7:A8").Merge();
            worksheet.Cells[7, 1].Value = "和暦";
            worksheet.Cells[7, 2].NumberFormat = "[$-ja-JP]ggge\"年\"m\"月\"d\"日\"";
            worksheet.Cells[7, 2].Value = DateTime.Now;

            // 時刻
            // 24時間表記
            worksheet.Cells[8, 0].Value = "時刻";
            worksheet.Cells[8, 1].Value = "24時間表記";
            worksheet.Cells[8, 2].NumberFormat = "h:mm:ss;@";
            worksheet.Cells[8, 2].Value = DateTime.Now;
            // AM/PM表記
            worksheet.Range("A9:A10").Merge();
            worksheet.Cells[9, 1].Value = "AM/PM表記";
            worksheet.Cells[9, 2].NumberFormat = "h:mm AM/PM;@";
            worksheet.Cells[9, 2].Value = DateTime.Now;


            //パーセンテージ
            worksheet.Cells[10, 0].Value = "パーセンテージ";
            worksheet.Cells[10, 2].NumberFormat = "0%";
            worksheet.Cells[10, 2].Value = 0.12;

            // 分数
            worksheet.Cells[11, 0].Value = "分数";
            worksheet.Cells[11, 2].NumberFormat = "# ?/?";
            worksheet.Cells[11, 2].Value = 8.333;

            // 指数
            worksheet.Cells[12, 0].Value = "指数";
            worksheet.Cells[12, 2].NumberFormat = "0.E+00";
            worksheet.Cells[12, 2].Value = 1234567890;

            // 文字列
            worksheet.Cells[13, 0].Value = "文字列";
            worksheet.Cells[13, 2].NumberFormat = "@";
            worksheet.Cells[13, 2].Value = "12345";
        }

        private void InitSheet2(GrapeCity.Spreadsheet.IWorksheet worksheet)
        {
            // AddShapeメソッドによるシェイプの追加
            worksheet.Shapes.AddShape(GrapeCity.Spreadsheet.Drawing.AutoShapeType.Heart, 100, 50, 150, 150);

            // 行列インデックスを指定したAddShapeToCellメソッドによるシェイプの追加
            GrapeCity.Spreadsheet.Drawing.IShape sunShape = worksheet.Shapes.AddShapeToCell(GrapeCity.Spreadsheet.Drawing.AutoShapeType.Sun, 2, 4, 200, 200);
            // シェイプのスタイルの変更
            sunShape.ShapeStyle = GrapeCity.Spreadsheet.Drawing.ShapeStyle.Preset12;
            // シェイプの透明度の変更
            sunShape.Fill.Transparency = 0.5;

            // AddConnectorメソッドによるコネクタシェイプの追加
            GrapeCity.Spreadsheet.Drawing.IShape connectorShape = worksheet.Shapes.AddConnector(GrapeCity.Spreadsheet.Drawing.ConnectorType.Elbow, 100, 300, 400, 250);
            // コネクタシェイプの太さの変更
            connectorShape.Line.Weight = 5;
        }

        void button1_Click(object sender, EventArgs e)
        {            
            // ファイル保存ダイアログ起動
            string fn = "";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDFファイル(*.pdf)|*.pdf";
                sfd.FileName = "SpreadClickOnceデモ.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fn = sfd.FileName;
                }
                else
                {
                    return;
                }
            }

            // ブックの保存
            IWorkbook book1 = fpSpread1.AsWorkbook();
            book1.SaveAs(fn, GrapeCity.Spreadsheet.IO.FileFormat.PDF);
        }
    }
}
