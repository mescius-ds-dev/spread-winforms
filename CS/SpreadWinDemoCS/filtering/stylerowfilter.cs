using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.filtering
{
    public partial class stylerowfilter : SpreadWinDemo.DemoBase
    {
        public stylerowfilter()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

            // メールアドレス非表示
            sheet.Columns[8].Visible = false;

            // 列幅の設定
            sheet.Columns[0].Width = 40;
            sheet.Columns[1].Width = 90;
            sheet.Columns[2].Width = 97;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 70;
            sheet.Columns[5].Width = 70;
            sheet.Columns[6].Width = 75;
            sheet.Columns[7].Width = 80;

            sheet.ColumnHeaderAutoTextIndex = 0;
            sheet.ColumnHeader.RowCount = 2;

            // フィルタ用スタイル設定
            FarPoint.Win.Spread.NamedStyle instyle = new FarPoint.Win.Spread.NamedStyle();
            FarPoint.Win.Spread.NamedStyle outstyle = new FarPoint.Win.Spread.NamedStyle();

            instyle.BackColor = System.Drawing.Color.Orange;
            instyle.ForeColor = System.Drawing.Color.Red;

            outstyle.BackColor = System.Drawing.Color.WhiteSmoke;

            // フィルターを設定
            FarPoint.Win.Spread.StyleRowFilter styleRowFilter = new FarPoint.Win.Spread.StyleRowFilter(sheet, instyle, outstyle);
            styleRowFilter.AllString = "<すべて>";
            styleRowFilter.NonBlanksString = "<空白以外>";

            // フィルターに列を追加
            FarPoint.Win.Spread.FilterColumnDefinition fcd;
            fcd = new FarPoint.Win.Spread.FilterColumnDefinition(4, FarPoint.Win.Spread.FilterListBehavior.Default);
            styleRowFilter.AddColumn(fcd);
            fcd = new FarPoint.Win.Spread.FilterColumnDefinition(5, FarPoint.Win.Spread.FilterListBehavior.Default);
            styleRowFilter.AddColumn(fcd);
            fcd = new FarPoint.Win.Spread.FilterColumnDefinition(6, FarPoint.Win.Spread.FilterListBehavior.Default);
            styleRowFilter.AddColumn(fcd);

            // シートに対して設定
            sheet.RowFilter = styleRowFilter; //フィルターを設定
            sheet.ColumnHeaderAutoFilterIndex = 1;
        }
    }
}
