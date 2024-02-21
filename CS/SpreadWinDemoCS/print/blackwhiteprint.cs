using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.print
{
    public partial class blackwhiteprint : SpreadWinDemo.DemoBase
    {
        public blackwhiteprint()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data50.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 110;
            sheet.Columns[2].Width = 110;
            sheet.Columns[3].Width = 100;
            sheet.Columns[4].Width = 50;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 50;
            sheet.Columns[7].Width = 100;
            sheet.Columns[8].Width = 240;

            // 文字色と背景色の設定
            sheet.DefaultStyle.BackColor = Color.LavenderBlush;
            sheet.DefaultStyle.ForeColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // SPREADの準備が完了していない場合を除外
            if (fpSpread1.Sheets.Count == 0) return;

            // 白黒印刷とカラー印刷の切り替え
            fpSpread1.Sheets[0].PrintInfo.ShowColor = !checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 印刷の実行
            fpSpread1.Sheets[0].PrintInfo.Preview = false;
            fpSpread1.PrintSheet(fpSpread1.Sheets[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 印刷プレビューの表示
            fpSpread1.Sheets[0].PrintInfo.Preview = true;
            fpSpread1.PrintSheet(fpSpread1.Sheets[0]);
        }
    }
}
