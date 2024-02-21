using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class selectionstyle : SpreadWinDemo.DemoBase
    {
        public selectionstyle()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 36;
            sheet.Columns[1].Width = 88;
            sheet.Columns[2].Width = 91;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 36;
            sheet.Columns[5].Width = 46;
            sheet.Columns[6].Width = 49;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 181;

            // 選択スタイルの初期設定
            sheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors;
            sheet.SelectionBackColor = Color.Green;
            sheet.SelectionFont = new System.Drawing.Font("メイリオ", 12.0f);
            sheet.SelectionForeColor = Color.Black;
        }

        void button1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                FarPoint.Win.Spread.Model.CellRange[] cr = fpSpread1.Sheets[0].GetSelections();
                for (int i = 0; i <= cr.Length - 1; i++)
                {
                    fpSpread1.Sheets[0].SelectionBackColor = cd.Color;
                }
            } 
        }

        void button2_Click(object sender, EventArgs e)
        {
            // FontDialogの設定
            FontDialog fd = new FontDialog();
            fd.Font = fpSpread1.Sheets[0].SelectionFont;
            fd.Color = fpSpread1.Sheets[0].SelectionForeColor;
            fd.MaxSize = 15;
            fd.MinSize = 10;
            fd.FontMustExist = true;
            fd.AllowVerticalFonts = false;
            fd.ShowColor = true;
            fd.ShowEffects = true;
            fd.FixedPitchOnly = false;

            // ダイアログを表示
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                // フォントと色の設定
                fpSpread1.Sheets[0].SelectionFont = fd.Font;
                fpSpread1.Sheets[0].SelectionForeColor = fd.Color;
            }
        }
    }
}
