using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class canfocus : SpreadWinDemo.DemoBase
    {
        public canfocus()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
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

            //「計画」列をスキップ
            for (int i = 0; i < 12; i++)
            {
                sheet.Columns[i * 2 + 3].CanFocus = false;
            }
        }
    }
}
