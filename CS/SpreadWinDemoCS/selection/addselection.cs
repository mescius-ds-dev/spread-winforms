using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class addselection : SpreadWinDemo.DemoBase
    {
        public addselection()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            // 選択リスト設定
            InitList();

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
        }

        private void InitList()
        {
            for (int i = 0; i < fpSpread1.Sheets[0].RowCount; i++)
            {
                comboBox1.Items.Add(Convert.ToString(i));
            }

            for (int i = 1; i < fpSpread1.Sheets[0].RowCount + 1; i++)
            {
                comboBox3.Items.Add(Convert.ToString(i));
            }

            for (int i = 0; i < fpSpread1.Sheets[0].ColumnCount; i++)
            {
                comboBox2.Items.Add(Convert.ToString(i));
            }
            for (int i = 1; i < fpSpread1.Sheets[0].ColumnCount + 1; i++)
            {
                comboBox4.Items.Add(Convert.ToString(i));
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            int rowidx = 0;
            if (!int.TryParse(comboBox1.Text, out rowidx))
            {
                MessageBox.Show(comboBox1.Text + "を選択してください。");
                return;
            }

            int colidx = 0;
            if (!int.TryParse(comboBox2.Text, out colidx))
            {
                MessageBox.Show(comboBox2.Text + "を選択してください。");
                return;
            }

            int rowcnt = 0;
            if (!int.TryParse(comboBox3.Text, out rowcnt))
            {
                MessageBox.Show(comboBox3.Text + "を選択してください。");
                return;
            }

            int colcnt = 0;
            if (!int.TryParse(comboBox4.Text, out colcnt))
            {
                MessageBox.Show(comboBox4.Text + "を選択してください。");
                return;
            }

            // 選択範囲作成
            fpSpread1.Sheets[0].SetActiveCell(rowidx, colidx);
            fpSpread1.Sheets[0].Models.Selection.SetSelection(rowidx, colidx, rowcnt, colcnt);
        }

        void button2_Click(object sender, EventArgs e)
        {
            // 全選択
            fpSpread1.Sheets[0].Models.Selection.SetSelection(-1, -1, -1, -1);
        }
    }
}
