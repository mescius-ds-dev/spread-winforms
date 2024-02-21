using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.print
{
    public partial class printpreview : SpreadWinDemo.DemoBase
    {
        public printpreview()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            fpSpread1.PrintPreviewShowing += new FarPoint.Win.Spread.PrintPreviewShowingEventHandler(fpSpread1_PrintPreviewShowing);
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
        }

        void fpSpread1_PrintPreviewShowing(object sender, FarPoint.Win.Spread.PrintPreviewShowingEventArgs e)
        {
            // 印刷プレビューダイアログ上のToolStripコントロールの取得
            ToolStrip ts = e.PreviewDialog.Controls[1] as ToolStrip;

            // クリックされたボタンコントロールの判別
            if (button2.ContainsFocus)
            {
                // ======================================
                // 印刷プレビューダイアログのカスタマイズ
                // ======================================

                // ズームの自動調節
                ToolStripSplitButton tssb = ts.Items[1] as ToolStripSplitButton;
                tssb.DropDownItems[0].PerformClick();

                // 表示ページ数指定ボタンの非表示
                ts.Items[2].Visible = false;
                ts.Items[3].Visible = false;
                ts.Items[4].Visible = false;
                ts.Items[5].Visible = false;
                ts.Items[6].Visible = false;
                ts.Items[7].Visible = false;
                ts.Items[8].Visible = false;
            }
            else
            {
                // ================================================
                // 印刷プレビューダイアログのデフォルト設定への復元
                // ================================================

                // 表示ページ数指定ボタンの表示
                ts.Items[2].Visible = true;
                ts.Items[3].Visible = true;
                ts.Items[4].Visible = true;
                ts.Items[5].Visible = true;
                ts.Items[6].Visible = true;
                ts.Items[7].Visible = true;
                ts.Items[8].Visible = true;
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 印刷プレビュー（デフォルト）の表示
            fpSpread1.Sheets[0].PrintInfo.Preview = true;
            fpSpread1.PrintSheet(fpSpread1.Sheets[0]);
        }

        void button2_Click(object sender, EventArgs e)
        {
            // 印刷プレビュー（カスタマイズ）の表示
            fpSpread1.Sheets[0].PrintInfo.Preview = true;
            fpSpread1.PrintSheet(fpSpread1.Sheets[0]);
        }
    }
}
