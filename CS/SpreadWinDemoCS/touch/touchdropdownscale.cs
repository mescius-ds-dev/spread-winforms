using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.touch
{
    public partial class touchdropdownscale : SpreadWinDemo.DemoBase
    {
        public touchdropdownscale()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            numericUpDown1.ValueChanged += new EventHandler(numericUpDown1_ValueChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.RowCount = 10;
            sheet.ColumnCount = 5;

            // 列の右端とインジケータの間隔を指定
            sheet.FpSpread.HeaderIndicatorPositionAdjusting = 4;

            // テストデータの設定
            for (int i = 0; i < sheet.RowCount; i++)
            {
                sheet.Cells[i, 0].Value = i % 5;
            }

            // 自動フィルタリング機能を有効
            sheet.Columns[0].AllowAutoFilter = true;
            sheet.AutoFilterMode = FarPoint.Win.Spread.AutoFilterMode.EnhancedContextMenu;

            // 列幅の設定
            sheet.Columns[1].Width = 160;
            sheet.Columns[2].Width = 140;
            sheet.Columns[3].Width = 120;
            sheet.Columns[4].Width = 120;

            // コンボボックス型セルの設定
            FarPoint.Win.Spread.CellType.ComboBoxCellType cmbocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            cmbocell.Items = (new String[] { "1月", "2月", "3月", "4月", "5月", "6月" });
            sheet.Cells[1, 1].CellType = cmbocell;
            sheet.Cells[0, 1].Value = "コンボボックス型セル";
            sheet.Cells[1, 1].Value = "1月";

            // 日付時刻型セルの設定
            FarPoint.Win.Spread.CellType.DateTimeCellType datecell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            datecell.DropDownButton = true;
            sheet.Cells[1, 2].CellType = datecell;
            sheet.Cells[0, 2].Value = "日付時刻型セル";
            sheet.Cells[1, 2].Value = DateTime.Today;

            // GcComboBox型セルの設定
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccmbcell = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            DataTable emp = new DataTable();
            emp.Columns.Add("氏名");
            emp.Columns.Add("所属");
            emp.Rows.Add(new Object[] { "葡萄 花子", "営業部" });
            emp.Rows.Add(new Object[] { "仙台 一郎", "開発部" });
            gccmbcell.DataSource = emp;
            gccmbcell.TextFormat = "[0] 所属：[1]";
            sheet.Cells[4, 1].CellType = gccmbcell;
            sheet.Cells[3, 1].Value = "GcComboBox型セル";
            sheet.Cells[4, 1].Value = "葡萄 花子 所属：営業部";

            // GcDateTime型セルの設定
            GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType gcdatecell = new GrapeCity.Win.Spread.InputMan.CellType.GcDateTimeCellType();
            gcdatecell.Fields.Clear();
            gcdatecell.DisplayFields.Clear();
            gcdatecell.Fields.AddRange("yyyy年 MM月 dd日");
            gcdatecell.DisplayFields.AddRange("ggg ee年 M月 d日");
            sheet.Cells[4, 2].CellType = gcdatecell;
            sheet.Cells[3, 2].Value = "GcDateTime型セル";
            sheet.Cells[4, 2].Value = DateTime.Today;            

            // GcNumber型セルの設定
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumcell = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            sheet.Cells[4, 3].CellType = gcnumcell;
            sheet.Cells[3, 3].Value = "GcNumber型セル";
            sheet.Cells[4, 3].Value = 100;

            // GcTextBox型セルの設定
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctxtcell = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            GrapeCity.Win.Spread.InputMan.CellType.DropDownButtonInfo MyDropDownButton = new GrapeCity.Win.Spread.InputMan.CellType.DropDownButtonInfo();
            MyDropDownButton.IsDefaultBehavior = true;
            gctxtcell.SideButtons.Add(MyDropDownButton);
            sheet.Cells[4, 4].CellType = gctxtcell;
            sheet.Cells[3, 4].Value = "GcTextBox型セル";
            sheet.Cells[4, 4].Value = "GcTextBox型セルの設定";
        }

        void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            fpSpread1.TouchDropDownScale = (float)this.numericUpDown1.Value;
        }
    }
}
