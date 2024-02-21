using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class texttip : SpreadWinDemo.DemoBase
    {
        public texttip()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // テキストチップの設定
            spread.TextTipPolicy = FarPoint.Win.Spread.TextTipPolicy.Floating;
            spread.TextTipDelay = 1000;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            sheet.DataAutoSizeColumns = false;
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;
        }
    }
}
