using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class dragbandonmoving : SpreadWinDemo.DemoBase
    {
        public dragbandonmoving()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // 行のドラッグ移動を許可
            spread.AllowRowMove = true;

            // 列のドラッグ移動を許可
            spread.AllowColumnMove = true;

            // 行列のドラッグ移動時のアニメーションを簡素化
            spread.ShowDragBandOnMoving = false;
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
            if (checkBox1.Checked)
            {
                // 行列のドラッグ移動時にドラッグバンドを表示する
                fpSpread1.ShowDragBandOnMoving = true;
            }
            else
            {
                // 行列のドラッグ移動時のアニメーションを簡素化
                fpSpread1.ShowDragBandOnMoving = false;
            }
        }
    }
}
