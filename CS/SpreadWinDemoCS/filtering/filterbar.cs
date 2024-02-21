using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.filtering
{
    public partial class filterbar : SpreadWinDemo.DemoBase
    {
        public filterbar()
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

            // 列幅の設定
            sheet.Columns[0].Width = 100;
            sheet.Columns[1].Width = 100;
            sheet.Columns[2].Width = 100;
            sheet.Columns[3].Width = 120;
            sheet.Columns[4].Width = 100;
            sheet.Columns[5].Width = 100;
            sheet.Columns[6].Width = 100;
            sheet.Columns[7].Width = 130;
            sheet.Columns[8].Width = 190;

            // フィルタリングの設定
            sheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.FilterBar;

            FarPoint.Win.Spread.CellType.FilterBarCellType ct1 = new FarPoint.Win.Spread.CellType.FilterBarCellType();
            ct1.ContextMenuType = FarPoint.Win.Spread.CellType.FilterBarContextMenuType.Number;
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            sheet.FilterBar.Cells[0].CellType = ct1;
            nc.DecimalPlaces = 0;
            sheet.Columns[0].CellType = nc;
            sheet.FilterBar.Cells[3].CellType = ct1;

            FarPoint.Win.Spread.CellType.FilterBarCellType ct2 = new FarPoint.Win.Spread.CellType.FilterBarCellType();
            ct2.FormatString = "yyyy/MM/dd";
            ct2.ContextMenuType = FarPoint.Win.Spread.CellType.FilterBarContextMenuType.DateTime;

            sheet.FilterBar.Cells[3].CellType = ct2;
            sheet.FilterBar.Cells[3].BackColor = System.Drawing.Color.Yellow;

            sheet.FilterBar.Cells[7].CellType = ct2;
            sheet.FilterBar.Cells[7].BackColor = System.Drawing.Color.Tomato;
        }
    }
}
