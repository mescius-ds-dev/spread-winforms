using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.databind
{
    public partial class tableautoupdate : SpreadWinDemo.DemoBase
    {
        public tableautoupdate()
        {
            InitializeComponent();

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            button1.Click += new EventHandler(button1_Click);
        }

        DataSet ds;
        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            // テストデータの設定
            ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));

            // テーブルの追加
            fpSpread1.AsWorkbook().ActiveSheet.AutoUpdateFilter = true;
            GrapeCity.Spreadsheet.ITable table = workbook.ActiveSheet.Tables.Add("B2:J14", GrapeCity.Spreadsheet.YesNoGuess.Yes);
            // テーブルと連結
            table.DataSource = ds;
            checkBox1.Checked = workbook.ActiveSheet.Tables[0].AutoFilter.AutoUpdate;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // SPREADの準備が完了していない場合を除外
            if (fpSpread1.Sheets.Count == 0) return;

            GrapeCity.Spreadsheet.IWorkbook workbook = fpSpread1.AsWorkbook();
            GrapeCity.Spreadsheet.ITable table = workbook.ActiveSheet.Tables[0];

            // テーブルフィルタの自動更新の切り替え
            table.AutoFilter.AutoUpdate = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // データソースの変更
            ds.Tables[0].Rows[6][0] = "1001";
        }
    }
}
