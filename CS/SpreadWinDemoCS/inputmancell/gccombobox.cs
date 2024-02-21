using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.inputmancell
{
    public partial class gccombobox : SpreadWinDemo.DemoBase
    {
        public gccombobox()
        {
            InitializeComponent();

            // SPREADの設定
            fpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            fpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            fpSpread1.EditModeOn += fpSpread1_EditModeOn;

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
            sheet.Cells[0, 0].Text = "書式の設定";
            sheet.Cells[1, 0].Text = "文字種の自動変換";
            sheet.Cells[2, 0].Text = "未入力時の代替テキスト";
            sheet.Cells[3, 0].Text = "入力候補値";
            sheet.Cells[4, 0].Text = "最大文字数";
            sheet.Cells[5, 0].Text = "自動フォーカス移動";
            sheet.Cells[6, 0].Text = "オートコンプリート";
            sheet.Cells[7, 0].Text = "オートフィルタ";
            sheet.Cells[8, 0].Text = "データソース接続";
            sheet.Cells[9, 0].Text = "項目スタイル";
            sheet.Cells[10, 0].Text = "項目ツールチップ";
            sheet.Cells[11, 0].Text = "サイドボタン";

            sheet.Cells[0, 2].Text = "入力可能な文字種をカタカナに限定します";
            sheet.Cells[1, 2].Text = "全角の文字を入力すると半角に変換されます";
            sheet.Cells[2, 2].Text = "セルが未入力のときに代わりにテキストを表示します";
            sheet.Cells[3, 2].Text = "[Ctrl]+[Enter]で候補として表示された値を確定します";
            sheet.Cells[4, 2].Text = "最大5文字までしか入力できません";
            sheet.Cells[5, 2].Text = "5文字入力すると自動的に右のセルにフォーカスを移動します";
            sheet.Cells[6, 2].Text = "入力した文字を含む候補リストを表示します";
            sheet.Cells[7, 2].Text = "入力した文字を含む項目からなるリストを表示します";
            sheet.Cells[8, 2].Text = "リスト項目をデータ連結で設定します";
            sheet.Cells[9, 2].Text = "リスト項目ごとにスタイルを設定します";
            sheet.Cells[10, 2].Text = "リスト項目ごとに任意のツールチップを設定します";
            sheet.Cells[11, 2].Text = "スピンボタンを追加します";

            //【書式の設定】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo1 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo1.AutoConvert = false;
            gccombo1.DropDown.AllowResize = false;
            gccombo1.FormatString = "Ｋ";
            gccombo1.Items.AddRange(new string[] { "アイウエオ", "カキクケコ", "サシスセソ", "タチツテト", "ナニヌネノ" });
            gccombo1.ListHeaderPane.Visible = false;
            sheet.Cells[0, 1].CellType = gccombo1;
            sheet.Cells[0, 1].Value = "アイウエオ";

            //【文字種の自動変換】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo2 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo2.AutoConvert = true;
            gccombo2.DropDown.AllowResize = false;
            gccombo2.FormatString = "H";
            gccombo2.Items.AddRange(new string[] { "ｱｲｳｴｵ", "12345", "ABCDE", "abcde", ".\",'@" });
            gccombo2.ListHeaderPane.Visible = false;
            sheet.Cells[1, 1].CellType = gccombo2;
            sheet.Cells[1, 1].ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            sheet.Cells[1, 1].Value = "ｱｲｳｴｵ";

            //【未入力時の代替テキスト】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo3 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo3.DropDown.AllowResize = false;
            gccombo3.Items.AddRange(new string[] { "項目１", "項目２", "項目３", "項目４", "項目５" });
            gccombo3.ListHeaderPane.Visible = false;
            gccombo3.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen;
            gccombo3.AlternateText.DisplayNull.Text = "＜入力項目＞";
            gccombo3.AlternateText.Null.ForeColor = Color.LightPink;
            gccombo3.AlternateText.Null.Text = "入力してください";
            sheet.Cells[2, 1].CellType = gccombo3;

            //【入力候補値】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo4 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo4.DropDown.AllowResize = false;
            gccombo4.Items.AddRange(new string[] { "項目１", "項目２", "項目３", "項目４", "項目５" });
            gccombo4.ListHeaderPane.Visible = false;
            gccombo4.ShowRecommendedValue = true;
            gccombo4.RecommendedValue = "項目１";
            sheet.Cells[3, 1].CellType = gccombo4;

            //【最大文字数】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo5 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo5.DropDown.AllowResize = false;
            gccombo5.Items.AddRange(new string[] { "あいうえお", "ｱｲｳｴｵ", "12345", "ABCDE", "abcde" });
            gccombo5.ListHeaderPane.Visible = false;
            gccombo5.MaxLength = 5;
            gccombo5.MaxLengthUnit = GrapeCity.Win.Spread.InputMan.CellType.LengthUnit.Char;
            sheet.Cells[4, 1].CellType = gccombo5;

            //【自動フォーカス移動】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo6 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo6.DropDown.AllowResize = false;
            gccombo6.ExitOnLastChar = true;
            gccombo6.Items.AddRange(new string[] { "あいうえお", "ｱｲｳｴｵ", "12345", "ABCDE", "abcde" });
            gccombo6.ListHeaderPane.Visible = false;
            gccombo6.MaxLength = 5;
            gccombo6.MaxLengthUnit = GrapeCity.Win.Spread.InputMan.CellType.LengthUnit.Char;
            sheet.Cells[5, 1].CellType = gccombo6;

            //【オートコンプリート】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo7 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo7.AutoComplete.MatchingMode = GrapeCity.Win.Spread.InputMan.CellType.AutoCompleteMatchingMode.MatchAll;
            gccombo7.AutoComplete.HighlightMatchedText = true;
            gccombo7.AutoComplete.HighlightStyle.BackColor = Color.LavenderBlush;
            gccombo7.AutoComplete.HighlightStyle.ForeColor = Color.Red;
            gccombo7.AutoCompleteMode = AutoCompleteMode.Suggest;
            gccombo7.AutoCompleteSource = AutoCompleteSource.ListItems;
            gccombo7.DropDown.AllowResize = false;
            gccombo7.ListColumns.Add("Name");
            gccombo7.ListColumns.Add("Code");
            GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo item7;
            item7 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("abcde", null, ContentAlignment.MiddleLeft, false, false));
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(100, null, ContentAlignment.MiddleLeft, false, false));
            gccombo7.Items.Add(item7);
            item7 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("bcdef", null, ContentAlignment.MiddleLeft, false, false));
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(200, null, ContentAlignment.MiddleLeft, false, false));
            gccombo7.Items.Add(item7);
            item7 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("cdefg", null, ContentAlignment.MiddleLeft, false, false));
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(300, null, ContentAlignment.MiddleLeft, false, false));
            gccombo7.Items.Add(item7);
            item7 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("12345", null, ContentAlignment.MiddleLeft, false, false));
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(400, null, ContentAlignment.MiddleLeft, false, false));
            gccombo7.Items.Add(item7);
            item7 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("23456", null, ContentAlignment.MiddleLeft, false, false));
            item7.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(500, null, ContentAlignment.MiddleLeft, false, false));
            gccombo7.Items.Add(item7);
            gccombo7.ListHeaderPane.Visible = false;
            sheet.Cells[6, 1].CellType = gccombo7;

            //【オートフィルタ】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo8 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo8.AutoFilter.Enabled = true;
            gccombo8.AutoFilter.Interval = 500;
            gccombo8.AutoFilter.MaxFilteredItems = 5;
            gccombo8.AutoFilter.MinimumPrefixLength = 1;
            gccombo8.AutoFilter.MatchingMode = GrapeCity.Win.Spread.InputMan.CellType.AutoCompleteMatchingMode.MatchAll;
            gccombo8.AutoFilter.MatchingSource = GrapeCity.Win.Spread.InputMan.CellType.FilterMatchingSource.AllSubItems;
            gccombo8.DropDown.AllowResize = false;
            gccombo8.DropDownStyle = ComboBoxStyle.DropDown;
            gccombo8.ListColumns.Add("Name");
            gccombo8.ListColumns.Add("Code");
            GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo item8;
            item8 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("abcde", null, ContentAlignment.MiddleLeft, false, false));
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(100, null, ContentAlignment.MiddleLeft, false, false));
            gccombo8.Items.Add(item8);
            item8 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("bcdef", null, ContentAlignment.MiddleLeft, false, false));
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(200, null, ContentAlignment.MiddleLeft, false, false));
            gccombo8.Items.Add(item8);
            item8 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("cdefg", null, ContentAlignment.MiddleLeft, false, false));
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(300, null, ContentAlignment.MiddleLeft, false, false));
            gccombo8.Items.Add(item8);
            item8 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("12345", null, ContentAlignment.MiddleLeft, false, false));
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(400, null, ContentAlignment.MiddleLeft, false, false));
            gccombo8.Items.Add(item8);
            item8 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("23456", null, ContentAlignment.MiddleLeft, false, false));
            item8.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(500, null, ContentAlignment.MiddleLeft, false, false));
            gccombo8.Items.Add(item8);
            gccombo8.ListHeaderPane.Visible = false;
            sheet.Cells[7, 1].CellType = gccombo8;

            //【データソース接続】
            // データの作成
            DataTable dt = new DataTable("ComboList");
            dt.Columns.Add("Image", typeof(Image));
            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Code", typeof(Int32));
            Image image;
            image = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.history.gif"));
            dt.Rows.Add(image, "歴史", 100);
            image = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.music.gif"));
            dt.Rows.Add(image, "音楽", 200);
            image = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.science.gif"));
            dt.Rows.Add(image, "科学", 300);

            // コンボボックス型セルの設定
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo9 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            //// 自動列生成機能を使わない場合
            //gccombo9.AutoGenerateColumns = false;
            //gccombo9.ListColumns.Add(new GrapeCity.Win.Spread.InputMan.CellType.ListColumnInfo("Image") { DataDisplayType = GrapeCity.Win.Spread.InputMan.CellType.DataDisplayType.Image });
            //gccombo9.ListColumns.Add("Name");
            //gccombo9.ListColumns.Add("Code");
            //gccombo9.ListColumns[0].DataPropertyName = "Image";
            //gccombo9.ListColumns[1].DataPropertyName = "Name";
            //gccombo9.ListColumns[2].DataPropertyName = "Code";
            gccombo9.DataSource = dt;
            gccombo9.DropDown.AutoWidth = true;
            gccombo9.EditorValue = GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditorValue.Value;
            gccombo9.TextSubItemIndex = 1;
            gccombo9.ValueSubItemIndex = 2;
            sheet.Cells[8, 1].CellType = gccombo9;
            sheet.Cells[8, 1].Value = 100;

            //【項目スタイル 】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo10 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo10.DropDown.AllowResize = false;
            gccombo10.EditorValue = GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditorValue.Value;
            gccombo10.ExitOnLastChar = true;
            gccombo10.ListColumns.Add("Name");
            gccombo10.ListColumns.Add("Code");
            GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo item10;
            item10 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目１", null, ContentAlignment.MiddleLeft, false, false));
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(100, null, ContentAlignment.MiddleLeft, false, false));
            gccombo10.Items.Add(item10);
            item10 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目２", null, ContentAlignment.MiddleLeft, false, false));
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(200, null, ContentAlignment.MiddleLeft, false, false));
            gccombo10.Items.Add(item10);
            item10 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目３", null, ContentAlignment.MiddleLeft, false, false));
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(300, null, ContentAlignment.MiddleLeft, false, false));
            gccombo10.Items.Add(item10);
            item10 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目４", null, ContentAlignment.MiddleLeft, false, false));
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(400, null, ContentAlignment.MiddleLeft, false, false));
            gccombo10.Items.Add(item10);
            item10 = new GrapeCity.Win.Spread.InputMan.CellType.ListItemInfo();
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo("項目５", null, ContentAlignment.MiddleLeft, false, false));
            item10.SubItems.Add(new GrapeCity.Win.Spread.InputMan.CellType.SubItemInfo(500, null, ContentAlignment.MiddleLeft, false, false));
            gccombo10.Items.Add(item10);
            gccombo10.ListHeaderPane.Visible = false;
            GrapeCity.Win.Spread.InputMan.CellType.ItemTemplateInfo itemTemp1 = new GrapeCity.Win.Spread.InputMan.CellType.ItemTemplateInfo(0, null, Color.Silver, Color.Black, -1, fpSpread1.Font, null);
            GrapeCity.Win.Spread.InputMan.CellType.ItemTemplateInfo itemTemp2 = new GrapeCity.Win.Spread.InputMan.CellType.ItemTemplateInfo(0, null, Color.Black, Color.White, -1, fpSpread1.Font, null);
            gccombo10.ListItemTemplates.Add(itemTemp1);
            gccombo10.ListItemTemplates.Add(itemTemp2);
            gccombo10.TextSubItemIndex = 0;
            gccombo10.ValueSubItemIndex = 1;
            sheet.Cells[9, 1].CellType = gccombo10;
            sheet.Cells[9, 1].Value = 100;

            //【項目ツールチップ】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo11 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo11.DropDown.AllowResize = false;
            gccombo11.Items.AddRange(new string[] { "項目１", "項目２", "項目３", "項目４", "項目５" });
            gccombo11.Items[0].ToolTipText = "ヒント１";
            gccombo11.Items[1].ToolTipText = "ヒント２";
            gccombo11.Items[2].ToolTipText = "ヒント３";
            gccombo11.Items[3].ToolTipText = "ヒント４";
            gccombo11.Items[4].ToolTipText = "ヒント５";
            gccombo11.ListHeaderPane.Visible = false;
            gccombo11.ShowItemTip = true;
            sheet.Cells[10, 1].CellType = gccombo11;
            sheet.Cells[10, 1].Value = "項目１";

            //【サイドボタン】
            GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType gccombo12 = new GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxCellType();
            gccombo12.DropDown.AllowResize = false;
            gccombo12.Items.AddRange(new string[] { "項目１", "項目２", "項目３", "項目４", "項目５" });
            gccombo12.ListHeaderPane.Visible = false;
            gccombo12.SideButtons.Insert(0, new GrapeCity.Win.Spread.InputMan.CellType.SpinButtonInfo());
            gccombo12.Spin.SpinOnKeys = true;
            gccombo12.Spin.SpinOnWheel = true;
            sheet.Cells[11, 1].CellType = gccombo12;
            sheet.Cells[11, 1].Value = "項目１";
        }

        private void fpSpread1_EditModeOn(object sender, EventArgs e)
        {
            // コンボボックス型セルの編集コントロールの文字位置の調節
            if (fpSpread1.EditingControl is GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditingControl)
            {
                GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditingControl combo = fpSpread1.EditingControl as GrapeCity.Win.Spread.InputMan.CellType.GcComboBoxEditingControl;
                combo.Padding = new Padding(0);
            }
        }
    }
}
