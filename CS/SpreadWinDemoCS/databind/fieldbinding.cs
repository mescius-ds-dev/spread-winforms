using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.databind
{
    public partial class fieldbinding : SpreadWinDemo.DemoBase
    {
        public fieldbinding()
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
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.databind.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 140;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リセット            
            fpSpread1.Reset();

            if (comboBox1.Text == "計画データのみを連結")
            {
                // 連結時の列自動生成を無効
                fpSpread1.Sheets[0].AutoGenerateColumns = false;
                fpSpread1.Sheets[0].ColumnCount = 15;

                // 連結フィールドの設定
                fpSpread1.Sheets[0].Columns[0].DataField = "製品ID";
                fpSpread1.Sheets[0].Columns[1].DataField = "製品分類";
                fpSpread1.Sheets[0].Columns[2].DataField = "製品名";
                fpSpread1.Sheets[0].Columns[3].DataField = "4月計画";
                fpSpread1.Sheets[0].Columns[4].DataField = "5月計画";
                fpSpread1.Sheets[0].Columns[5].DataField = "6月計画";
                fpSpread1.Sheets[0].Columns[6].DataField = "7月計画";
                fpSpread1.Sheets[0].Columns[7].DataField = "8月計画";
                fpSpread1.Sheets[0].Columns[8].DataField = "9月計画";
                fpSpread1.Sheets[0].Columns[9].DataField = "10月計画";
                fpSpread1.Sheets[0].Columns[10].DataField = "11月計画";
                fpSpread1.Sheets[0].Columns[11].DataField = "12月計画";
                fpSpread1.Sheets[0].Columns[12].DataField = "1月計画";
                fpSpread1.Sheets[0].Columns[13].DataField = "2月計画";
                fpSpread1.Sheets[0].Columns[14].DataField = "3月計画";

                //データ連結
                DataSet ds = new DataSet();
                ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.databind.xml"));
                fpSpread1.Sheets[0].DataSource = ds;
            }
            else if (comboBox1.Text == "実績データのみを連結")
            {
                // 連結時の列自動生成を無効
                fpSpread1.Sheets[0].AutoGenerateColumns = false;
                fpSpread1.Sheets[0].ColumnCount = 15;

                // 連結フィールドの設定
                fpSpread1.Sheets[0].Columns[0].DataField = "製品ID";
                fpSpread1.Sheets[0].Columns[1].DataField = "製品分類";
                fpSpread1.Sheets[0].Columns[2].DataField = "製品名";
                fpSpread1.Sheets[0].Columns[3].DataField = "4月実績";
                fpSpread1.Sheets[0].Columns[4].DataField = "5月実績";
                fpSpread1.Sheets[0].Columns[5].DataField = "6月実績";
                fpSpread1.Sheets[0].Columns[6].DataField = "7月実績";
                fpSpread1.Sheets[0].Columns[7].DataField = "8月実績";
                fpSpread1.Sheets[0].Columns[8].DataField = "9月実績";
                fpSpread1.Sheets[0].Columns[9].DataField = "10月実績";
                fpSpread1.Sheets[0].Columns[10].DataField = "11月実績";
                fpSpread1.Sheets[0].Columns[11].DataField = "12月実績";
                fpSpread1.Sheets[0].Columns[12].DataField = "1月実績";
                fpSpread1.Sheets[0].Columns[13].DataField = "2月実績";
                fpSpread1.Sheets[0].Columns[14].DataField = "3月実績";

                //データ連結
                DataSet ds = new DataSet();
                ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.databind.xml"));
                fpSpread1.Sheets[0].DataSource = ds;
            }
            else
            {
                //データ連結
                DataSet ds = new DataSet();
                ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.databind.xml"));
                fpSpread1.Sheets[0].DataSource = ds;                
            }

            // 列幅の設定
            fpSpread1.Sheets[0].Columns[0].Width = 45;
            fpSpread1.Sheets[0].Columns[1].Width = 85;
            fpSpread1.Sheets[0].Columns[2].Width = 140;

            for (int i = 3; i < fpSpread1.Sheets[0].ColumnCount; i++)
            {
                fpSpread1.Sheets[0].Columns[i].Width = 65;
            }            
        }

    }
}
