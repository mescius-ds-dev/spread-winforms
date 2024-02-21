using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class operationmode : SpreadWinDemo.DemoBase
    {
        public operationmode()
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

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択範囲のクリア
            fpSpread1.Sheets[0].ClearSelection();

            if (comboBox1.Text == "読み取り専用モード（一切の変更を禁止）")
            {
                fpSpread1.Sheets[0].OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly;
            }
            else if (comboBox1.Text == "行モード（セル編集可能な行選択モード）")
            {
                fpSpread1.Sheets[0].OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            }
            else if (comboBox1.Text == "単一選択モード（1つの行のみ選択）")
            {
                fpSpread1.Sheets[0].OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect;
            }
            else if (comboBox1.Text == "複数選択モード（複数の行の選択）")
            {
                fpSpread1.Sheets[0].OperationMode = FarPoint.Win.Spread.OperationMode.MultiSelect;
            }
            else if (comboBox1.Text == "拡張選択モード（[Ctrl]+クリック／[Shift]+方向キーで複数行選択）")
            {
                fpSpread1.Sheets[0].OperationMode = FarPoint.Win.Spread.OperationMode.ExtendedSelect;
            }
            else
            {
                fpSpread1.Sheets[0].OperationMode = FarPoint.Win.Spread.OperationMode.Normal;
            }
        }
    }
}
