using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.inputmancell
{
    public partial class gccharmask : SpreadWinDemo.DemoBase
    {
        public gccharmask()
        {
            InitializeComponent();

            // SPREADの設定
            fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 列の設定
            sheet.ColumnCount = 3;
            sheet.Columns[0].Width = 170;
            sheet.Columns[1].Width = 125;
            sheet.Columns[2].Width = 374;
            sheet.Columns[0].CellPadding = new FarPoint.Win.Spread.CellPadding(0, 0, 4, 0);
            sheet.Columns[2].CellPadding = new FarPoint.Win.Spread.CellPadding(4, 0, 0, 0);

            // 行の設定
            sheet.RowCount = 6;

            // 列ヘッダの設定
            sheet.ColumnHeader.Columns[0].Label = "機能";
            sheet.ColumnHeader.Columns[1].Label = "実行例";
            sheet.ColumnHeader.Columns[2].Label = "説明";

            // プロテクトとロック（DefaultStyle）の設定
            sheet.Protect = true;
            sheet.DefaultStyle.Locked = false;
            sheet.RowHeader.DefaultStyle.Locked = false;
            sheet.ColumnHeader.DefaultStyle.Locked = false;

            // 読み取り専用設定
            sheet.Columns[0].Locked = true;
            sheet.Columns[2].Locked = true;

            // 背景色の設定
            sheet.Columns[0].BackColor = System.Drawing.SystemColors.Control;

            // 左揃え
            sheet.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

            // アクティブセルの設定
            sheet.SetActiveCell(0, 1);

            // 項目名と解説の設定
            sheet.Cells[0, 0].Text = "書式の設定";
            sheet.Cells[1, 0].Text = "文字種の自動変換";
            sheet.Cells[2, 0].Text = "入力方向の設定";
            sheet.Cells[3, 0].Text = "入力候補値";
            sheet.Cells[4, 0].Text = "自動フォーカス移動";
            sheet.Cells[5, 0].Text = "マス目のスタイル";

            sheet.Cells[0, 2].Text = "入力可能な文字種を半角数字に限定します";
            sheet.Cells[1, 2].Text = "全角の文字を入力すると半角に変換されます";
            sheet.Cells[2, 2].Text = "電卓のように右端のマス目から順に入力されます";
            sheet.Cells[3, 2].Text = "[Ctrl]+[Enter]で候補として表示された値を確定します";
            sheet.Cells[4, 2].Text = "5文字入力すると自動的に右のセルにフォーカスを移動します";
            sheet.Cells[5, 2].Text = "マス目ごとのスタイルを設定します";

            //【書式の設定】
            GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType gccharmask1 = new GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType();
            gccharmask1.CharBoxes.Clear();
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox1 = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(12, 17) };
            gccharmask1.CharBoxes.Add(new GrapeCity.Win.Spread.InputMan.CellType.LiteralBoxInfo("〒") { AutoSize = false, Size = new Size(12, 17), ForeColor = Color.Red });
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.CharBoxes.Add(new GrapeCity.Win.Spread.InputMan.CellType.SeparatorBoxInfo() { AutoSize = false, Size = new Size(12, 17), ForeColor = Color.Silver });
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.CharBoxes.Add(ibox1.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask1.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.FirstInputPosition;
            gccharmask1.FormatString = "9";
            gccharmask1.PaintByControl = true;
            sheet.Cells[0, 1].CellType = gccharmask1;
            sheet.Cells[0, 1].Value = "9813205";

            //【文字種の自動変換】
            GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType gccharmask2 = new GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType();
            gccharmask2.AutoConvert = true;
            gccharmask2.CharBoxes.Clear();
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox2 = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(12, 17) };
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.CharBoxes.Add(ibox2.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask2.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.FirstInputPosition;
            gccharmask2.FormatString = "H";
            gccharmask2.PaintByControl = true;
            sheet.Cells[1, 1].CellType = gccharmask2;
            sheet.Cells[1, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;

            //【入力方向の設定】
            GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType gccharmask3 = new GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType();
            gccharmask3.CharBoxes.Clear();
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox3 = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(12, 17) };
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.CharBoxes.Add(ibox3.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask3.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.FirstInputPosition;
            gccharmask3.FormatString = "9";
            gccharmask3.InputDirection = GrapeCity.Win.Spread.InputMan.CellType.CharMaskInputDirection.RightToLeft;
            gccharmask3.PaintByControl = true;
            sheet.Cells[2, 1].CellType = gccharmask3;

            //【入力候補値】
            GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType gccharmask4 = new GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType();
            gccharmask4.CharBoxes.Clear();
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox4 = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(17, 17) };
            gccharmask4.CharBoxes.Add(ibox4.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask4.CharBoxes.Add(ibox4.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask4.CharBoxes.Add(ibox4.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask4.CharBoxes.Add(ibox4.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask4.CharBoxes.Add(ibox4.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask4.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.FirstInputPosition;
            gccharmask4.FormatString = "Ｚ";
            gccharmask4.PaintByControl = true;
            gccharmask4.ShowRecommendedValue = true;
            gccharmask4.RecommendedValue = "あいうえお";
            sheet.Cells[3, 1].CellType = gccharmask4;
            sheet.Cells[3, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;

            //【自動フォーカス移動】
            GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType gccharmask5 = new GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType();
            gccharmask5.CharBoxes.Clear();
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox5 = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(17, 17) };
            gccharmask5.CharBoxes.Add(ibox5.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask5.CharBoxes.Add(ibox5.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask5.CharBoxes.Add(ibox5.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask5.CharBoxes.Add(ibox5.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask5.CharBoxes.Add(ibox5.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask5.ExitOnLastChar = true;
            gccharmask5.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.FirstInputPosition;
            gccharmask5.FormatString = "H";
            gccharmask5.PaintByControl = true;
            sheet.Cells[4, 1].CellType = gccharmask5;

            //【マス目のスタイル】
            GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType gccharmask6 = new GrapeCity.Win.Spread.InputMan.CellType.GcCharMaskCellType();
            gccharmask6.CharBoxes.Clear();
            GrapeCity.Win.Spread.InputMan.CellType.Line noline = new GrapeCity.Win.Spread.InputMan.CellType.Line(GrapeCity.Win.Spread.InputMan.CellType.LineStyle.None, Color.Empty);
            GrapeCity.Win.Spread.InputMan.CellType.Line blueline = new GrapeCity.Win.Spread.InputMan.CellType.Line(GrapeCity.Win.Spread.InputMan.CellType.LineStyle.Single, Color.Blue);
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox6A = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(12, 17), Border = new GrapeCity.Win.Spread.InputMan.CellType.CharBoxBorderInfo(blueline) };
            GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo ibox6B = new GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo() { AutoSize = false, Size = new Size(12, 15), Border = new GrapeCity.Win.Spread.InputMan.CellType.CharBoxBorderInfo(blueline) };
            gccharmask6.CharBoxes.Add(new GrapeCity.Win.Spread.InputMan.CellType.LiteralBoxInfo("〒") { AutoSize = false, Size = new Size(12, 17), ForeColor = Color.Red, Border = new GrapeCity.Win.Spread.InputMan.CellType.CharBoxBorderInfo(noline) });
            gccharmask6.CharBoxes.Add(ibox6A.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxes.Add(ibox6A.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxes.Add(ibox6A.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxes.Add(new GrapeCity.Win.Spread.InputMan.CellType.LiteralBoxInfo("-") { AutoSize = false, Size = new Size(6, 17), ForeColor = Color.Blue, Border = new GrapeCity.Win.Spread.InputMan.CellType.CharBoxBorderInfo(noline), Padding = new Padding(0) });
            gccharmask6.CharBoxes.Add(ibox6B.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxes.Add(ibox6B.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxes.Add(ibox6B.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxes.Add(ibox6B.Clone() as GrapeCity.Win.Spread.InputMan.CellType.InputBoxInfo);
            gccharmask6.CharBoxSpacing = 2;
            gccharmask6.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.EditorBaseFocusCursorPosition.FirstInputPosition;
            gccharmask6.FormatString = "9";
            gccharmask6.PaintByControl = true;
            sheet.Cells[5, 1].CellType = gccharmask6;
        }
    }
}
