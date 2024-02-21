using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class celldragdrop : SpreadWinDemo.DemoBase
    {
        public celldragdrop()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // ドラッグ移動を許可
            spread.AllowDragDrop = true;
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
    }
}
