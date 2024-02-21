using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class dragfill : SpreadWinDemo.DemoBase
    {
        public dragfill()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            spread.AllowDragFill = true;
            spread.RangeDragFillMode = FarPoint.Win.Spread.DragFillMode.Copy;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // テストデータの設定
            sheet.RowCount = 20;
            sheet.ColumnCount = 10;
            sheet.Cells[0, 0].Value = 1;
            sheet.Cells[1, 0].Value = 3;
            sheet.Cells[2, 0].Value = 5;
            sheet.Cells[3, 0].Value = 7;
            sheet.Cells[4, 0].Value = 9;
            FarPoint.Win.Spread.CellType.CurrencyCellType currcell = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            currcell.CurrencySymbol = "円";
            currcell.ShowSeparator = true;
            currcell.PositiveFormat = FarPoint.Win.Spread.CellType.CurrencyPositiveFormat.CurrencySymbolAfter;
            sheet.Columns[1].CellType = currcell;            
            sheet.Cells[0, 1].Value = 1000;
            sheet.Cells[1, 1].Value = 1500;
            FarPoint.Win.Spread.CellType.DateTimeCellType datecell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            datecell.Calendar = new System.Globalization.JapaneseCalendar();
            datecell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined;
            datecell.UserDefinedFormat = "gg yy年M月d日";
            sheet.Columns[2].CellType = datecell;
            sheet.Columns[2].Width = 120;
            sheet.Cells[0, 2].Value = new DateTime(2015, 6, 15);
            sheet.Cells[1, 2].Value = new DateTime(2015, 6, 16);
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    fpSpread1.RangeDragFillMode = FarPoint.Win.Spread.DragFillMode.Copy;
                    break;
                case 1:
                    fpSpread1.RangeDragFillMode = FarPoint.Win.Spread.DragFillMode.Series;
                    break;
                case 2:
                    fpSpread1.RangeDragFillMode = FarPoint.Win.Spread.DragFillMode.ControlSeries;
                    break;
                case 3:
                    fpSpread1.RangeDragFillMode = FarPoint.Win.Spread.DragFillMode.ControlCopy;
                    break;
            }
        }
    }
}
