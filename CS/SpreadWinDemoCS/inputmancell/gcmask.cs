using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.inputmancell
{
    public partial class gcmask : SpreadWinDemo.DemoBase
    {
        public gcmask()
        {
            InitializeComponent();

            // SPREADの設定
            fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            fpSpread1.EditModeOn += fpSpread1_EditModeOn;
            fpSpread1.EditModeOff += fpSpread1_EditModeOff;

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
            sheet.RowCount = 9;

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
            sheet.Cells[2, 0].Text = "パスワード入力";
            sheet.Cells[3, 0].Text = "未入力時の代替テキスト";
            sheet.Cells[4, 0].Text = "入力候補値";
            sheet.Cells[5, 0].Text = "最大文字数";
            sheet.Cells[6, 0].Text = "自動フォーカス移動";
            sheet.Cells[7, 0].Text = "フィールドのスタイル";
            sheet.Cells[8, 0].Text = "サイドボタン";

            sheet.Cells[0, 2].Text = "リテラル文字は自動的にとばして値を入力できます";
            sheet.Cells[1, 2].Text = "全角の文字を入力すると半角に変換されます";
            sheet.Cells[2, 2].Text = "入力した文字を表示しないパスワード入力にします";
            sheet.Cells[3, 2].Text = "セルが未入力のときに代わりにテキストを表示します";
            sheet.Cells[4, 2].Text = "[Ctrl]+[Enter]で候補として表示された値を確定します";
            sheet.Cells[5, 2].Text = "最大5文字までしか入力できません";
            sheet.Cells[6, 2].Text = "5文字入力すると自動的に右のセルにフォーカスを移動します";
            sheet.Cells[7, 2].Text = "フィールドごとのスタイルを設定します";
            sheet.Cells[8, 2].Text = "サイドボタンを追加します";

            //【書式の設定】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask1 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask1.Fields.AddRange("〒\\D{3}-\\D{4}");
            gcmask1.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            sheet.Cells[0, 1].CellType = gcmask1;

            //【文字種の自動変換】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask2 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask2.AutoConvert = true;
            gcmask2.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            gcmask2.Fields.AddRange("\\H{0,}");
            sheet.Cells[1, 1].CellType = gcmask2;
            sheet.Cells[1, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;

            //【パスワード入力】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask3 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask3.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            gcmask3.Fields.AddRange("[\\H^\\K\\N]{8,10}");
            foreach (GrapeCity.Win.Spread.InputMan.CellType.Fields.MaskFieldInfo mf in gcmask3.Fields)
            {
                if (mf is GrapeCity.Win.Spread.InputMan.CellType.Fields.MaskPatternFieldInfo)
                {
                    (mf as GrapeCity.Win.Spread.InputMan.CellType.Fields.MaskPatternFieldInfo).UseSystemPasswordChar = true;
                }
            }
            gcmask3.PasswordRevelationMode = GrapeCity.Win.Spread.InputMan.CellType.PasswordRevelationMode.None;
            sheet.Cells[2, 1].CellType = gcmask3;

            //【未入力時の代替テキスト】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask4 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask4.Fields.AddRange("\\D{5}");
            gcmask4.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen;
            gcmask4.AlternateText.DisplayNull.Text = "＜数値入力＞";
            gcmask4.AlternateText.Null.ForeColor = Color.LightPink;
            gcmask4.AlternateText.Null.Text = "5桁の数値を入力";
            gcmask4.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            sheet.Cells[3, 1].CellType = gcmask4;

            //【入力候補値】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask5 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask5.Fields.AddRange("\\D{5}");
            gcmask5.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            gcmask5.ShowRecommendedValue = true;
            gcmask5.RecommendedValue = "12345";
            sheet.Cells[4, 1].CellType = gcmask5;

            //【最大文字数】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask6 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask6.Fields.AddRange("[\\H\\Ｚ]{0,5}");
            gcmask6.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            sheet.Cells[5, 1].CellType = gcmask6;

            //【自動フォーカス移動】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask7 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask7.ExitOnLastChar = true;
            gcmask7.Fields.AddRange("[\\H\\Ｚ]{0,5}");
            gcmask7.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            sheet.Cells[6, 1].CellType = gcmask7;

            //【フィールドのスタイル】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask8 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask8.Fields.AddRange("〒\\D{3}-\\D{4}");
            gcmask8.Fields[0].ForeColor = Color.Red;
            gcmask8.Fields[1].ForeColor = Color.Blue;
            gcmask8.Fields[2].ForeColor = Color.Red;
            gcmask8.Fields[3].ForeColor = Color.Blue;
            gcmask8.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            gcmask8.PaintByControl = true;
            sheet.Cells[7, 1].CellType = gcmask8;

            //【サイドボタン】
            GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType gcmask9 = new GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType();
            gcmask9.Fields.AddRange("[\\H\\Ｚ]{0,5}");
            gcmask9.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition;
            gcmask9.SideButtons.Add(new GrapeCity.Win.Spread.InputMan.CellType.SideButtonInfo());
            sheet.Cells[8, 1].CellType = gcmask9;
        }

        private void fpSpread1_EditModeOn(object sender, EventArgs e)
        {
            // サイドボタンのClickイベントの設定
            if (fpSpread1.EditingControl is GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl)
            {
                GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl mask = fpSpread1.EditingControl as GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl;
                if (mask.SideButtons.Count > 0)
                {
                    mask.SideButtons[0].Click += sidebutton_Click;
                }
            }
        }

        private void fpSpread1_EditModeOff(object sender, EventArgs e)
        {
            // サイドボタンのClickイベントの解除
            if (fpSpread1.EditingControl is GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl)
            {
                GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl mask = fpSpread1.EditingControl as GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl;
                if (mask.SideButtons.Count > 0)
                {
                    mask.SideButtons[0].Click -= sidebutton_Click;
                }
            }
        }

        private void sidebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("サイドボタンがクリックされました。");
        }
    }
}
