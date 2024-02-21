using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class rowvisible : SpreadWinDemo.DemoBase
    {
        public rowvisible()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            checkBox2.CheckedChanged += new EventHandler(checkBox2_CheckedChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.databind.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 140;

            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }

            //「計画」列の背景色を設定
            for (int i = 0; i < 12; i++)
            {
                sheet.Columns[i * 2 + 3].BackColor = System.Drawing.Color.LavenderBlush;
            }

            //「乳製品」行の背景色を設定
            for (int i = 0; i < sheet.RowCount; i++)
            {
                if (sheet.Cells[i, 1].Text == "乳製品")
                {
                    sheet.Rows[i].BackColor = System.Drawing.Color.LavenderBlush;
                }
            }
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //「乳製品」行を非表示
                for (int i = 0; i < fpSpread1.Sheets[0].RowCount; i++)
                {
                    if (fpSpread1.Sheets[0].Cells[i, 1].Text == "乳製品")
                    {
                        fpSpread1.Sheets[0].Rows[i].Visible = false;
                    }
                }
                checkBox1.Text = "全行表示";
            }
            else{
                // 全行表示
                for (int i = 0; i < fpSpread1.Sheets[0].RowCount; i++)
                {
                    fpSpread1.Sheets[0].Rows[i].Visible = true;
                }
                checkBox1.Text = "「乳製品」行を非表示";
            }  
        }

        void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                // 「計画」列を非表示
                for (int i = 0; i < 12; i++)
                {
                    fpSpread1.Sheets[0].Columns[i * 2 + 3].Visible = false;
                }
                checkBox2.Text = "全列表示";
            }
            else
            {
                // 全列表示
                for (int i = 0; i < fpSpread1.Sheets[0].ColumnCount; i++)
                {
                    fpSpread1.Sheets[0].Columns[i].Visible = true;
                }
                checkBox2.Text = "「計画」列を非表示";
            }  
        }
    }
}
