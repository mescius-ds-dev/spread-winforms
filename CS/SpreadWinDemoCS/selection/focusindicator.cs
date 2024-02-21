using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class focusindicator : SpreadWinDemo.DemoBase
    {
        public focusindicator()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
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
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "選択範囲の外側にフォーカス枠を表示")
            {
                fpSpread1.PaintSelectionBorder = true;
            }
            else if (comboBox1.Text == "アクティブセルのみにフォーカス枠を表示")
            {
                fpSpread1.PaintSelectionBorder = false;
            }
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "緑枠（デフォルト）")
            {
                fpSpread1.ResetFocusRenderer();
            }
            else if (comboBox2.Text == "太さの変更")
            {
                fpSpread1.FocusRenderer = new FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1);
            }
            else if (comboBox2.Text == "色の変更")
            {
                fpSpread1.FocusRenderer = new FarPoint.Win.Spread.SolidFocusIndicatorRenderer(Color.Black, 2);
            }
            else if (comboBox2.Text == "アニメーション")
            {
                fpSpread1.FocusRenderer = new FarPoint.Win.Spread.MarqueeFocusIndicatorRenderer(Color.FromArgb(33, 115, 70), 2);
            }
            else if (comboBox2.Text == "Ver 3.0J以前のスタイル")
            {
                fpSpread1.FocusRenderer = new FarPoint.Win.Spread.DefaultFocusIndicatorRenderer();
            }
            else if (comboBox2.Text == "非表示")
            {
                fpSpread1.FocusRenderer = new FarPoint.Win.Spread.DefaultFocusIndicatorRenderer(0);
            }
        }
    }
}
