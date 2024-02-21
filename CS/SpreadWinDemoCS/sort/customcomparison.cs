using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sort
{
    public partial class customcomparison : SpreadWinDemo.DemoBase
    {
        public customcomparison()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
        }

        private Boolean isasc; 

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

            // 列の非表示
            sheet.Columns[6].Visible = false;
            sheet.Columns[7].Visible = false;

            isasc = false;
        }

        void button1_Click(object sender, EventArgs e)
        {
            if (!isasc)
            {
                isasc = true;
            }
            else
            {
                isasc = false;
            }

            // Comparerを指定してソートを実行
            fpSpread1.Sheets[0].SortRows(8, isasc, true, new MyStringComparer());
        }
    }

    //----------------------------------
    //IComparer 実装クラス
    //----------------------------------
    [Serializable()] public class MyStringComparer : System.Collections.IComparer
    {

        public int Compare(object x, object y)
        {
            // ドメイン部分を抜き出し
            string val1 = Convert.ToString(x).Substring(Convert.ToString(x).IndexOf("@") + 1);
            string val2 = Convert.ToString(y).Substring(Convert.ToString(y).IndexOf("@") + 1);

            int compareResult;
            compareResult = string.Compare(val1, val2, false);

            return compareResult;
        }
    }
}
