using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class skin : SpreadWinDemo.DemoBase
    {
        public skin()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シート設定
            InitSheet(fpSpread1.Sheets[0]);

            fpSpread1.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(fpSpread1_ButtonClicked);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            spread.Sheets.Count = 2;
            spread.TabStripInsertTab = true;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 列幅の設定
            sheet.Columns[0].Width = 150;
            sheet.Columns[1].Width = 100;

            // セル型の設定
            FarPoint.Win.Spread.CellType.ComboBoxCellType cmbocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            System.Collections.ArrayList al = new System.Collections.ArrayList();
            foreach (FarPoint.Win.Spread.SpreadSkin fpskin in FarPoint.Win.Spread.DefaultSpreadSkins.Skins)
            {
                al.Add(fpskin.Name);
            }
            cmbocell.Items = (string[])al.ToArray(typeof(string));
            sheet.Cells[0, 0].CellType = cmbocell;
            sheet.Cells[0, 0].Text = "Default";
            FarPoint.Win.Spread.CellType.ButtonCellType bttncell = new FarPoint.Win.Spread.CellType.ButtonCellType();
            bttncell.Text = "スキンを変更";
            sheet.Cells[0, 1].CellType = bttncell;
        }

        void fpSpread1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            fpSpread1.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Find(fpSpread1.ActiveSheet.Cells[e.Row, e.Column - 1].Text);
        }
    }
}
