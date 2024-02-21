using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.inputmancell
{
    public partial class gctextbox : SpreadWinDemo.DemoBase
    {
        public gctextbox()
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
            sheet.RowCount = 12;

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
            sheet.Cells[0, 0].Text = "カタカナ";
            sheet.Cells[1, 0].Text = "半角英数字";
            sheet.Cells[2, 0].Text = "サロゲートペア";
            sheet.Cells[3, 0].Text = "未入力の代替テキスト";
            sheet.Cells[4, 0].Text = "入力候補値";
            sheet.Cells[5, 0].Text = "最大文字数";
            sheet.Cells[6, 0].Text = "自動フォーカス移動";
            sheet.Cells[7, 0].Text = "ドロップダウンエディット";
            sheet.Cells[8, 0].Text = "複数行";
            sheet.Cells[9, 0].Text = "オートコンプリート";
            sheet.Cells[10, 0].Text = "省略文字";

            sheet.Cells[0, 2].Text = "ひらがなを入力すると全角カタカナに変換されます";
            sheet.Cells[1, 2].Text = "全角英数字を入力すると半角に変換されます";
            sheet.Cells[2, 2].Text = "サロゲートペア文字（例：𩸽（ほっけ））のみ入力できます";
            sheet.Cells[3, 2].Text = "セルが未入力のときに代わりにテキストを表示します";
            sheet.Cells[4, 2].Text = "[Ctrl]+[Enter]で候補として表示された値を確定します";
            sheet.Cells[5, 2].Text = "最大5文字までしか入力できません";
            sheet.Cells[6, 2].Text = "5文字入力すると自動的に右のセルにフォーカスを移動します";
            sheet.Cells[7, 2].Text = "ドロップダウンボタンでエディタを表示します";
            sheet.Cells[8, 2].Text = "[Ctrl]+[Enter]で改行できます";
            sheet.Cells[9, 2].Text = "「a」と入力すると、候補値がリストで表示されます";
            sheet.Cells[10, 2].Text = "省略文字を値の中央に表示します";
            sheet.Cells[11, 2].Text = "省略文字を値の末尾に表示します";

            //【カタカナ】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext1 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext1.FormatString = "Ｋ";
            sheet.Cells[0, 1].CellType = gctext1;
            sheet.Cells[0, 1].Value = "あいうえお";
            sheet.Cells[0, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;

            //【半角英数字】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext2 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext2.FormatString = "Aa9";
            sheet.Cells[1, 1].CellType = gctext2;
            sheet.Cells[1, 1].Value = "abc123";
            sheet.Cells[1, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;

            //【サロゲートペア】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext3 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext3.FormatString = "Ｔ";
            sheet.Cells[2, 1].CellType = gctext3;
            sheet.Cells[2, 1].Value = "𩸽";
            sheet.Cells[2, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;

            //【未入力の代替テキスト】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext4 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext4.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen;
            gctext4.AlternateText.DisplayNull.Text = "＜入力項目＞";
            gctext4.AlternateText.Null.ForeColor = Color.LightPink;
            gctext4.AlternateText.Null.Text = "入力してください";
            sheet.Cells[3, 1].CellType = gctext4;

            //【入力候補値】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext5 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext5.RecommendedValue = "宮城県";
            gctext5.ShortcutKeys.Add(Keys.Control | Keys.Return, "ApplyRecommendedValue");
            gctext5.ShowRecommendedValue = true;
            sheet.Cells[4, 1].CellType = gctext5;

            //【最大文字数】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext6 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext6.MaxLength = 5;
            gctext6.MaxLengthUnit = GrapeCity.Win.Spread.InputMan.CellType.LengthUnit.Char;
            sheet.Cells[5, 1].CellType = gctext6;

            //【自動フォーカス移動】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext7 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext7.ExitOnLastChar = true;
            gctext7.MaxLength = 5;
            gctext7.MaxLengthUnit = GrapeCity.Win.Spread.InputMan.CellType.LengthUnit.Char;
            sheet.Cells[6, 1].CellType = gctext7;

            //【ドロップダウンエディット】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext8 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext8.GridLine = new GrapeCity.Win.Spread.InputMan.CellType.Line(GrapeCity.Win.Spread.InputMan.CellType.LineStyle.Dashed, Color.Blue);
            gctext8.Multiline = true;
            gctext8.SideButtons.Add(new GrapeCity.Win.Spread.InputMan.CellType.DropDownButtonInfo());
            sheet.Cells[7, 1].CellType = gctext8;

            //【複数行】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext9 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext9.Multiline = true;
            sheet.Cells[8, 1].CellType = gctext9;
            sheet.Cells[8, 1].Value = "1行目\r\n2行目";

            sheet.Cells[8, 0].CellType = new FarPoint.Win.Spread.CellType.GeneralCellType() { Multiline = true };
            sheet.Cells[8, 0].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            sheet.Cells[8, 2].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            sheet.Rows[8].Height *= 2;

            //【オートコンプリート】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext10 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            AutoCompleteStringCollection stringlist = new AutoCompleteStringCollection();
            stringlist.AddRange(new string[] { 
                "AcceptsArrowKeys", "AcceptsCrLf", "AcceptsTabChar", "AllowSpace", "AlternateText",
                "AutoComplete", "AutoCompleteCustomSource", "AutoCompleteMode", "AutoCompleteSource", "AutoConvert"});
            gctext10.AutoCompleteCustomSource = stringlist;
            gctext10.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            gctext10.AutoCompleteSource = AutoCompleteSource.CustomSource;
            sheet.Cells[9, 1].CellType = gctext10;

            //【省略文字】
            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext11 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext11.Ellipsis = GrapeCity.Win.Spread.InputMan.CellType.EllipsisMode.EllipsisPath;
            sheet.Cells[10, 1].CellType = gctext11;
            sheet.Cells[10, 1].Value = "きめ細かい入力制御と自動変換がユーザーの入力操作を効率化します。";

            GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType gctext12 = new GrapeCity.Win.Spread.InputMan.CellType.GcTextBoxCellType();
            gctext12.Ellipsis = GrapeCity.Win.Spread.InputMan.CellType.EllipsisMode.EllipsisEnd;
            sheet.Cells[11, 1].CellType = gctext12;
            sheet.Cells[11, 1].Value = "きめ細かい入力制御と自動変換がユーザーの入力操作を効率化します。";
            
            sheet.Cells[10, 0].RowSpan = 2;
            sheet.Cells[10, 0].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
        }
    }
}
