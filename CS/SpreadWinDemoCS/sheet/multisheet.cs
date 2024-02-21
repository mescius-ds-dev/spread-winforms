using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class multisheet : SpreadWinDemo.DemoBase
    {
        public multisheet()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シート設定
            InitSpreadStyles1(fpSpread1.Sheets[0]);
            InitSpreadStyles2(fpSpread1.Sheets[1]);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            // シート追加
            FarPoint.Win.Spread.SheetView sht = new FarPoint.Win.Spread.SheetView();
            spread.Sheets.Add(sht);
        }

        private void InitSpreadStyles1(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datapln.xml"));
            sheet.DataSource = ds;
            sheet.SheetName = "計画シート";

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 130;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }
        }

        private void InitSpreadStyles2(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datares.xml"));
            sheet.DataSource = ds;
            sheet.SheetName = "実績シート";

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 130;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }
        }
    }
}
