using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class sheetvisible : SpreadWinDemo.DemoBase
    {
        public sheetvisible()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet1(fpSpread1.Sheets[0]);
            InitSheet2(fpSpread1.Sheets[1]);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }        

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // シート追加
            FarPoint.Win.Spread.SheetView sht = new FarPoint.Win.Spread.SheetView();
            spread.Sheets.Add(sht);

            // シートタブを常に表示
            spread.TabStripPolicy = FarPoint.Win.Spread.TabStripPolicy.Always;
        }

        private void InitSheet1(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datapln.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 130;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }

            // シート名設定
            sheet.SheetName = "計画シート";
        }

        private void InitSheet2(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datares.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 130;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }

            // シート名設定
            sheet.SheetName = "実績シート";
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 全シート表示
            for (int i = 0; i < fpSpread1.Sheets.Count; i++)
            {
                fpSpread1.Sheets[i].Visible = true;
            }

            if (comboBox1.Text == "計画シート非表示")
            {
                fpSpread1.Sheets[0].Visible = false;
            }
            else if (comboBox1.Text == "実績シート非表示")
            {
                fpSpread1.Sheets[1].Visible = false;
            }
        }
    }
}
