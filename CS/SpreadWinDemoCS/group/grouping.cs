using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.group
{
    public partial class grouping : SpreadWinDemo.DemoBase
    {
        public grouping()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 36;
            sheet.Columns[1].Width = 90;
            sheet.Columns[2].Width = 94;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 50;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 60;

            // 行高の設定
            sheet.Rows.Default.Height = 26;

            // 列の非表示
            sheet.Columns[7].Visible = false;
            sheet.Columns[8].Visible = false;

            // グループ化の設定
            sheet.FpSpread.AllowColumnMove = true;
            sheet.AllowGroup = true;
            sheet.GroupBarVisible = true;
            sheet.GroupBarInfo.Text = "列ヘッダをここにドラッグしてグループ化します";
        }
    }
}
