using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class zoomfactor : SpreadWinDemo.DemoBase
    {
        public zoomfactor()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
            fpSpread1.UserZooming += new FarPoint.Win.Spread.UserZoomingEventHandler(fpSpread1_UserZooming);
            trackBar1.Scroll += new EventHandler(trackBar1_Scroll);            
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

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fpSpread1.AllowUserZoom = true;
            }
            else
            {
                fpSpread1.AllowUserZoom = false;
            }
        }

        void fpSpread1_UserZooming(object sender, FarPoint.Win.Spread.ZoomEventArgs e)
        {
            label2.Text = e.NewZoomFactor.ToString("#0%"); 
        }   

        void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {   
                return;
            }

            float zf = (float)trackBar1.Value / 10;
            fpSpread1.ZoomFactor = zf;
            label2.Text = this.fpSpread1.ZoomFactor.ToString("#0%");
        }
    }
}
