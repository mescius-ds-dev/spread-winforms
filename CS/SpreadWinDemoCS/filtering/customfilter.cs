using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.filtering
{
    public partial class customfilter : SpreadWinDemo.DemoBase
    {
        public customfilter()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum2.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 135;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;


            sheet.ColumnHeaderAutoTextIndex = 0;
            sheet.ColumnHeader.RowCount = 2;

            // フィルターを設定
            FarPoint.Win.Spread.HideRowFilter hf;
            MyCustomFilter mc;
            FarPoint.Win.Spread.FilterColumnDefinition fcd;
            hf = new FarPoint.Win.Spread.HideRowFilter(sheet); //非表示フィルタの作成
            mc = new MyCustomFilter(); //カスタムフィルタを作成
            mc.SheetView = sheet; //シートの設定

            // 4列目～7列目にカスタムフィルタを設定
            for (int i = 0; i < 4; i++)
            {
                fcd = new FarPoint.Win.Spread.FilterColumnDefinition(i + 3, FarPoint.Win.Spread.FilterListBehavior.Custom);
                fcd.Filters.Add(mc); //カスタムフィルタを定義に追加
                hf.AddColumn(fcd); //フィルタ定義を非表示フィルタに追加            
            }

            sheet.RowFilter = hf; //フィルタをシートに設定; 
        }

        [Serializable()]
        public class MyCustomFilter : FarPoint.Win.Spread.DefaultFilterItem
        {
            FarPoint.Win.Spread.SheetView sv = null;

            public MyCustomFilter() { }
            public override string DisplayName
            {
                get { return "1000～5000"; }//フィルタに表示する文字列
            }
            public override FarPoint.Win.Spread.SheetView SheetView
            {
                set { sv = value; }
            }
            private bool IsNumeric(object ovalue)
            {
                System.Text.RegularExpressions.Regex _isNumber = new System.Text.RegularExpressions.Regex(@"^\-?\d+\.?\d*$");
                System.Text.RegularExpressions.Match m = _isNumber.Match(Convert.ToString(ovalue));
                return m.Success;
            }
            public bool IsFilteredIn(object ovalue)
            {
                bool ret = false;
                if (IsNumeric(ovalue))
                {
                    if (Double.Parse(Convert.ToString(ovalue)) >= 1000 && Double.Parse(Convert.ToString(ovalue)) <= 5000)
                        ret = true;
                }
                return ret;
            }
            public override int[] Filter(int columnIndex)
            {
                System.Collections.ArrayList ar = new System.Collections.ArrayList();
                object val;
                for (int i = 0; i < sv.RowCount; i++)
                {
                    val = sv.GetValue(i, columnIndex);
                    if (IsFilteredIn(val))
                        ar.Add(i); //条件に合致する行番号をリストに追加
                }
                return (Int32[])(ar.ToArray(typeof(Int32)));
            }
            public override bool ShowInDropDown(int columnIndex, int[] filteredInRowList)
            {
                // filteredInRowList引数は現在、フィルター・イン（フィルターの条件に合致した）行リスト
                // 条件に合うデータが存在する時のみフィルター要素を表示
                if (filteredInRowList == null)
                {
                    for (int i = 0; i < sv.RowCount; i++)
                    {
                        object value = sv.GetValue(i, columnIndex);
                        if (value != null)
                        {
                            if (IsFilteredIn(value))
                                return true;
                        }
                    }
                }
                else
                {
                    // 現在の行リストが条件に合致するか確認
                    for (int i = 0; i < filteredInRowList.Length; i++)
                    {
                        int row = filteredInRowList[i];
                        object value = sv.GetValue(row, columnIndex);
                        if (value != null)
                        {
                            if (IsFilteredIn(value))
                                return true;
                        }
                    }
                }
                return false;
            }
            public override bool Serialize(System.Xml.XmlTextWriter w)
            {
                w.WriteStartElement("MyCustomFilter");
                base.Serialize(w);
                w.WriteEndElement();
                return true;
            }
            public override bool Deserialize(System.Xml.XmlNodeReader r)
            {
                if (r.NodeType == System.Xml.XmlNodeType.Element)
                {
                    if (r.Name.Equals("MyCustomFilter"))
                        base.Deserialize(r);
                }
                return true;
            }
        }
    }
}
