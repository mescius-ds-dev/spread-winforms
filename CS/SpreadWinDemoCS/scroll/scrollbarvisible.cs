using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.scroll
{
    public partial class scrollbarvisible : SpreadWinDemo.DemoBase
    {
        public scrollbarvisible()
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
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data30.xml"));
            sheet.DataSource = ds;
            
            // 列幅の設定
            sheet.Columns[0].Width = 70;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 80;
            sheet.Columns[3].Width = 140;
            sheet.Columns[4].Width = 140;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 80;
            sheet.Columns[7].Width = 50;
            sheet.Columns[8].Width = 60;
            sheet.Columns[9].Width = 70;
            sheet.Columns[10].Width = 300;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "垂直スクロールバーを表示しない")
            {
                fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            }
            else if (comboBox1.Text == "垂直スクロールバーを必要な場合のみ表示")
            {
                fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            }
            else
            {
                fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Always;
            }
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "水平スクロールバーを表示しない")
            {
                fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            }
            else if (comboBox2.Text == "水平スクロールバーを必要な場合のみ表示")
            {
                fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            }
            else
            {
                fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Always;
            }
        }

    }
}
