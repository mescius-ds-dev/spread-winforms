using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class selectionpolicy : SpreadWinDemo.DemoBase
    {
        public selectionpolicy()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

            //列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 120;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 50;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 65;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 140;

            // 選択スタイルの設定
            sheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors;
            sheet.SelectionBackColor = System.Drawing.Color.Red;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択のクリア
            fpSpread1.Sheets[0].Models.Selection.ClearSelection();

            string[] strCom = comboBox1.Text.Split('.');

            switch (Convert.ToInt32(strCom[0]))
            {
                case 0:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.None;
                    break;
                case 1:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Cells;
                    break;
                case 2:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Rows;
                    break;
                case 3:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Rows | FarPoint.Win.Spread.SelectionBlockOptions.Cells;
                    break;
                case 4:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns;
                    break;
                case 5:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns | FarPoint.Win.Spread.SelectionBlockOptions.Cells;
                    break;
                case 6:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns | FarPoint.Win.Spread.SelectionBlockOptions.Rows;
                    break;
                case 7:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Columns | FarPoint.Win.Spread.SelectionBlockOptions.Rows | FarPoint.Win.Spread.SelectionBlockOptions.Cells;
                    break;
                case 8:
                    fpSpread1.SelectionBlockOptions = FarPoint.Win.Spread.SelectionBlockOptions.Sheet;
                    break;
            }
        }


    }
}
