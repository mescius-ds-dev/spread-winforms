using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class viewport : SpreadWinDemo.DemoBase
    {
        public viewport()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
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

            // ビューポートの設定
            fpSpread1.AddViewport(0, 0);
            fpSpread1.SetViewportLeftColumn(1, 5);
            fpSpread1.SetViewportTopRow(1, 10);
        }
    }
}
