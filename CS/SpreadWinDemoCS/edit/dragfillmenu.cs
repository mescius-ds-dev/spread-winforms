using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class dragfillmenu : SpreadWinDemo.DemoBase
    {
        public dragfillmenu()
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
            spread.EnableDragFillMenu = true;
            spread.DragFillDataOnly = false;
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
            sheet.Cells[0, 0, 4, 0].BackColor = Color.LightBlue;
            FarPoint.Win.Spread.CellType.CurrencyCellType currcell = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            currcell.CurrencySymbol = "円";
            currcell.ShowSeparator = true;
            currcell.PositiveFormat = FarPoint.Win.Spread.CellType.CurrencyPositiveFormat.CurrencySymbolAfter;
            sheet.Columns[1].CellType = currcell;            
            sheet.Cells[0, 1].Value = 1000;
            sheet.Cells[1, 1].Value = 1500;
            sheet.Cells[0, 1, 1, 1].BackColor = Color.LightPink;
            FarPoint.Win.Spread.CellType.DateTimeCellType datecell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            datecell.Calendar = new System.Globalization.JapaneseCalendar();
            datecell.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined;
            datecell.UserDefinedFormat = "gg yy年M月d日";
            sheet.Columns[2].CellType = datecell;
            sheet.Columns[2].Width = 120;
            sheet.Cells[0, 2].Value = new DateTime(2018, 2, 21);
            sheet.Cells[1, 2].Value = new DateTime(2018, 2, 22);
            sheet.Cells[0, 2, 1, 2].BackColor = Color.LightGreen;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    fpSpread1.DragFillDataOnly = false;
                    break;
                case 1:
                    fpSpread1.DragFillDataOnly = true;
                    break;
            }
        }
    }
}
