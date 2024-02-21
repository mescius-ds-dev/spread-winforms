using FarPoint.Win.Spread;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class addthreadedcomment : SpreadWinDemo.DemoBase
    {
        public addthreadedcomment()
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
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            // 列幅の設定
            workbook.ActiveSheet.Columns[0].ColumnWidth = 36;
            workbook.ActiveSheet.Columns[1].ColumnWidth = 88;
            workbook.ActiveSheet.Columns[2].ColumnWidth = 91;
            workbook.ActiveSheet.Columns[3].ColumnWidth = 80;
            workbook.ActiveSheet.Columns[4].ColumnWidth = 36;
            workbook.ActiveSheet.Columns[5].ColumnWidth = 46;
            workbook.ActiveSheet.Columns[6].ColumnWidth = 49;
            workbook.ActiveSheet.Columns[7].ColumnWidth = 80;
            workbook.ActiveSheet.Columns[8].ColumnWidth = 181;

            // スレッド形式のコメント
            fpSpread1.Features.EnhancedShapeEngine = true;
            fpSpread1.AsWorkbook().ActiveSheet.Cells["B2"].AddCommentThreaded("スレッド形式のコメント").AddReply("最初の返信");
        }
    }
}
