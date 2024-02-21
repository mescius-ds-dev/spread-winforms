using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.print
{
    public partial class ownerprint : SpreadWinDemo.DemoBase
    {
        public ownerprint()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シート設定
            InitSpreadStyles1(fpSpread1.Sheets[0]);
            InitSpreadStyles2(fpSpread1.Sheets[1]);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // シート追加
            FarPoint.Win.Spread.SheetView sht = new FarPoint.Win.Spread.SheetView();
            spread.Sheets.Add(sht);
        }

        private void InitSpreadStyles1(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datapln.xml"));
            sheet.DataSource = ds;
            sheet.SheetName = "計画シート";

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 130;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }
        }

        private void InitSpreadStyles2(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datares.xml"));
            sheet.DataSource = ds;
            sheet.SheetName = "実績シート";

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 130;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }
        }

        private System.Drawing.Printing.PrintDocument CreatePrintPage()
        {
            // PrintDocumentの生成
            System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument();
            pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pd_PrintPage);

            // 用紙の指定
            System.Drawing.Printing.PrinterSettings ps = pd.PrinterSettings;
            System.Drawing.Printing.PaperSize sizeA4 = null;
            for (int i = 0; i < ps.PaperSizes.Count; i++)
            {
                if (ps.PaperSizes[i].Kind == System.Drawing.Printing.PaperKind.A4)
                {
                    sizeA4 = ps.PaperSizes[i];
                    break;
                }
            }
            pd.DefaultPageSettings.PaperSize = sizeA4;
            pd.DefaultPageSettings.Landscape = true;
            pd.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);

            // 戻り値の設定
            return pd;
        }

        void button1_Click(object sender, EventArgs e)
        {
            // PrintDocumentの生成
            System.Drawing.Printing.PrintDocument pd = this.CreatePrintPage();

            // 印刷
            pd.Print();
        }

        void button2_Click(object sender, EventArgs e)
        {
            // PrintDocumentの生成
            System.Drawing.Printing.PrintDocument pd = this.CreatePrintPage();

            // 印刷プレビューダイアログの表示
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // 表題の描画領域の取得
            Rectangle rect0 = new Rectangle(e.MarginBounds.X, e.MarginBounds.Y, e.MarginBounds.Width, 50);

            // 表題の描画
            e.Graphics.DrawString("計画と実績", new Font("メイリオ",20, FontStyle.Bold), Brushes.Blue, rect0);

            // 計画シートの描画領域の取得
            Rectangle rect1 = new Rectangle(e.MarginBounds.X, e.MarginBounds.Y + 50, e.MarginBounds.Width, 250);

            // 計画シートの描画
            if (fpSpread1.GetOwnerPrintPageCount(e.Graphics, rect1, 0) == 1)
            {
                fpSpread1.OwnerPrintDraw(e.Graphics, rect1, 0, 1);
                e.HasMorePages = false;
            }

            // 実績シートの描画領域の取得
            Rectangle rect2 = new Rectangle(e.MarginBounds.X, e.MarginBounds.Y + 300, e.MarginBounds.Width, 300);

            // 実績シートの描画
            if (fpSpread1.GetOwnerPrintPageCount(e.Graphics, rect2, 1) == 1)
            {
                fpSpread1.OwnerPrintDraw(e.Graphics, rect2, 1, 1);
                e.HasMorePages = false;
            }
        }
    }
}
