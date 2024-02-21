using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class title : SpreadWinDemo.DemoBase
    {
        public title()
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
            spread.Sheets.Count = 2;

            // タイトルの設定
            spread.TitleInfo.Visible = true;
            spread.TitleInfo.Text = "グレープ商事";
            spread.TitleInfo.Font = new Font("メイリオ", 16);
            spread.TitleInfo.Height = 40;
        }

        private void InitSpreadStyles1(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datapln.xml"));
            sheet.DataSource = ds;

            // サブタイトルの設定
            sheet.TitleInfo.Visible = true;
            sheet.TitleInfo.Text = "計画シート";
            sheet.TitleInfo.BackColor = System.Drawing.Color.Orange;            
            sheet.TitleInfo.Font = new Font("メイリオ", 12);

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
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datares.xml"));
            sheet.DataSource = ds;

            // サブタイトルの設定
            sheet.TitleInfo.Visible = true;
            sheet.TitleInfo.Text = "実績シート";
            sheet.TitleInfo.BackColor = System.Drawing.Color.Silver;
            sheet.TitleInfo.Font = new Font("メイリオ", 12);

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
