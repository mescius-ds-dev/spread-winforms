using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.touch
{
    public partial class touchkeyboard : SpreadWinDemo.DemoBase
    {
        public touchkeyboard()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
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

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fpSpread1.AutoScrollWhenKeyboardShowing = checkBox1.Checked;
        }

        void button1_Click(object sender, EventArgs e)
        {
            fpSpread1.Focus();
            fpSpread1.ShowTouchKeyboard();
        }

        void button2_Click(object sender, EventArgs e)
        {
            fpSpread1.Focus();
            fpSpread1.HideTouchKeyboard();
        }
    }
}
