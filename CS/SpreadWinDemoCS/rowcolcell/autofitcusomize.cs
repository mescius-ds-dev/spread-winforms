using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class autofitcustomize : SpreadWinDemo.DemoBase
    {
        public autofitcustomize()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            checkBox5.CheckedChanged += checkBox_CheckedChanged;
            checkBox6.CheckedChanged += checkBox_CheckedChanged;

            checkBox5.Checked = true;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // ヘッダのWordWrap禁止
            FarPoint.Win.Spread.StyleInfo hsInfo = new FarPoint.Win.Spread.StyleInfo();
            fpSpread1.ActiveSheet.Models.ColumnHeaderStyle.GetCompositeInfo(0, 0, 0, hsInfo);
            (hsInfo.Renderer as FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer).WordWrap2 = false;
            fpSpread1.ActiveSheet.ColumnHeader.DefaultStyle.Renderer = hsInfo.Renderer; 

            // シートコーナーの設定
            sheet.SheetCorner.Columns.Default.Resizable = true;
            sheet.SheetCorner.Rows.Default.Resizable = true;

            // 列ヘッダの設定
            sheet.ColumnHeader.Cells[0, 1].Value = "列ヘッダのテスト";
            sheet.ColumnHeader.Cells[0, 1].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

            // 列フッタの設定
            sheet.ColumnFooter.Visible = true;
            sheet.ColumnFooter.Cells[0, 0].Value = "列フッタのテスト";
            sheet.ColumnFooter.Cells[0, 0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

            // 行ヘッダの設定
            sheet.RowHeader.Cells[0, 0].Value = "行ヘッダのテスト";
            sheet.RowHeader.Cells[0, 0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            sheet.RowHeader.Cells[0, 0].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Top;

            // セルの設定
            sheet.DefaultStyle.CellType = new FarPoint.Win.Spread.CellType.TextCellType() { WordWrap = true };
            sheet.Cells[1, 2].Value = "結合セル（水平）のテスト";
            sheet.Cells[2, 4].Value = "結合セル（垂直）のテスト";
            sheet.Cells[4, 5].Value = "複数行セルのテスト";
            sheet.Cells[1, 2].ColumnSpan = 2;
            sheet.Cells[2, 4].RowSpan = 2;

            // 列と幅の自動調節機能の初期化
            fpSpread1.AutoFitColumnOptions = FarPoint.Win.Spread.PreferredSizeColumnOptions.IncludeAll;
            fpSpread1.AutoFitRowOptions = FarPoint.Win.Spread.PreferredSizeRowOptions.IncludeAll;
        }

        private bool isSetByCode = false;

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // チェック状態の制御
            if (isSetByCode) return;
            isSetByCode = true;
            if (sender == checkBox5 && checkBox5.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox6.Checked = false;
                isSetByCode = false; ;
            }
            else if (sender == checkBox5 && !checkBox5.Checked)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
            }
            else if (sender == checkBox6 && checkBox6.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else if (sender != checkBox5 && sender != checkBox6)
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
            else if (sender != checkBox5)
            {
                checkBox5.Checked = false;
            }
            else if (sender != checkBox6)
            {
                checkBox6.Checked = false;
            }
            isSetByCode = false;

            // 列幅と行高さの自動調節方法の指定
            int colValue = 0;
            int rowValue = 0;
            if (checkBox1.Checked)
            {
                // フッタの除外
                colValue += (int)FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeFooters;
            }
            if (checkBox2.Checked)
            {
                // ヘッダの除外
                colValue += (int)FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeHeaders;
                rowValue += (int)FarPoint.Win.Spread.PreferredSizeRowOptions.ExcludeHeaders;
            }
            if (checkBox3.Checked)
            {
                // 結合セルの除外
                colValue += (int)FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeSpans;
                rowValue += (int)FarPoint.Win.Spread.PreferredSizeRowOptions.ExcludeSpans;
            }
            if (checkBox4.Checked)
            {
                // 複数行セルの除外
                colValue += (int)FarPoint.Win.Spread.PreferredSizeColumnOptions.ExcludeWordWrap;
            }
            if (checkBox5.Checked)
            {
                // すべてを対象
                colValue += (int)FarPoint.Win.Spread.PreferredSizeColumnOptions.IncludeAll;
                rowValue += (int)FarPoint.Win.Spread.PreferredSizeRowOptions.IncludeAll;
            }
            if (checkBox6.Checked)
            {
                // 自動調整の停止
                colValue += (int)FarPoint.Win.Spread.PreferredSizeColumnOptions.Off;
                rowValue += (int)FarPoint.Win.Spread.PreferredSizeRowOptions.Off;
            }
            fpSpread1.AutoFitColumnOptions = (FarPoint.Win.Spread.PreferredSizeColumnOptions)colValue;
            fpSpread1.AutoFitRowOptions = (FarPoint.Win.Spread.PreferredSizeRowOptions)rowValue;
        }
    }
}
