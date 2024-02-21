using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class editmodereplace : SpreadWinDemo.DemoBase
    {
        public editmodereplace()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // 上書き入力を設定
            spread.EditModeReplace = true;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum2.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 100;
            sheet.Columns[2].Width = 141;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;
        }  
    }
}
