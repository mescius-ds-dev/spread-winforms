using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.databind
{
    public partial class tablebinding : SpreadWinDemo.DemoBase
    {
        public tablebinding()
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

            // テストデータの設定
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));

            // テーブルの追加
            GrapeCity.Spreadsheet.ITable table = workbook.ActiveSheet.Tables.Add("B2:J14", GrapeCity.Spreadsheet.YesNoGuess.Yes);
            // テーブルと連結
            table.DataSource = ds;
        }
    }
}
