using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.touch
{
    public partial class touchscroll : SpreadWinDemo.DemoBase
    {
        public touchscroll()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            comboBox2.SelectedIndexChanged += new EventHandler(comboBox2_SelectedIndexChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data50.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 100;
            sheet.Columns[2].Width = 100;
            sheet.Columns[3].Width = 100;
            sheet.Columns[4].Width = 50;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 80;
            sheet.Columns[7].Width = 100;
            sheet.Columns[8].Width = 200;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    fpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.None; 
                    break;
                case 1:
                    fpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.HorizontalOnly;
                    break;
                case 2:
                    fpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.VerticalOnly;
                    break;
                case 3:
                    fpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.HorizontalOrVertical;
                    break;
                case 4:
                    fpSpread1.PanningMode = FarPoint.Win.Spread.SpreadPanningMode.Both;
                    break;
            }
        }

        void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    fpSpread1.BoundaryFeedbackMode = FarPoint.Win.Spread.BoundaryFeedbackMode.Standard;
                    break;
                case 1:
                    fpSpread1.BoundaryFeedbackMode = FarPoint.Win.Spread.BoundaryFeedbackMode.Split;
                    break;
            }
        }
    }
}
