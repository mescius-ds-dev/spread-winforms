using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.importexport
{
    public partial class printpdf : SpreadWinDemo.DemoBase
    {
        public printpdf()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
        }        

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data50.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 40;    // ID
            sheet.Columns[1].Width = 90;    // 氏名
            sheet.Columns[2].Width = 95;    // カナ
            sheet.Columns[3].Width = 85;    // 生年月日
            sheet.Columns[4].Width = 40;    // 性別
            sheet.Columns[5].Width = 50;    // 血液型
            sheet.Columns[6].Width = 50;    // 部署
            sheet.Columns[7].Width = 85;    // 入社日
            sheet.Columns[8].Width = 220;   // メールアドレス

            // 水平位置の設定
            sheet.Columns[0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;  // ID
            sheet.Columns[4].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;  // 性別
            sheet.Columns[5].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;  // 血液型

            FarPoint.Win.Spread.PrintInfo pi = new FarPoint.Win.Spread.PrintInfo();

            //ヘッダに「カラー」「イメージ」を設定します
            pi.Colors = new System.Drawing.Color[] { System.Drawing.Color.Purple, System.Drawing.Color.Green, System.Drawing.Color.Indigo };
            System.IO.Stream s = this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.science.gif");
            pi.Images = new System.Drawing.Image[] { System.Drawing.Image.FromStream(s) };
            pi.Header = "/c/fz\"20\"/cl\"0\"/fb1/fu0/fi1 SPREAD for Windows Forms ";
            pi.Footer = "/fn\"Arial\"/fz\"10\"/cl\"1\"/fb0/fu0/fi0/dl /ds /tl "
                         + "/c/fn\"Arial\"/fz\"10\"/cl\"2\"/p///pc Page /r/fn\"Times New Roman\"/fz\"14\"/cl\"1\"/fb1/fu0/fi1/g\"0\"";

            pi.ShowColor = true;
            pi.Centering = FarPoint.Win.Spread.Centering.Horizontal;

            // マージンの設定
            pi.Margin.Top = 30;
            pi.Margin.Left = 5;
            pi.Margin.Right = 0;
            pi.Margin.Bottom = 70;
            pi.Margin.Footer = 10;
            pi.Margin.Header = 10;

            //定義したPrintInfoオブジェクトを設定します
            sheet.PrintInfo = pi;
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

            fpSpread1.Sheets[0].PrintInfo.PrintToPdf = true;
            fpSpread1.Sheets[0].PrintInfo.PdfFileName = fn;
            fpSpread1.PrintSheet(fpSpread1.Sheets[0]);
        }
    }
}
