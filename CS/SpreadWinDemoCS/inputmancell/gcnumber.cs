using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.inputmancell
{
    public partial class gcnumber : SpreadWinDemo.DemoBase
    {
        public gcnumber()
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
            sheet.RowCount = 13;

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
            sheet.Cells[0, 0].Text = "入力・表示書式";
            sheet.Cells[1, 0].Text = "漢数字";
            sheet.Cells[2, 0].Text = "リテラル文字";
            sheet.Cells[3, 0].Text = "未入力の代替テキスト";
            sheet.Cells[5, 0].Text = "入力候補値";
            sheet.Cells[6, 0].Text = "範囲指定\r\n（-9999～9999）";
            sheet.Cells[8, 0].Text = "自動フォーカス移動";
            sheet.Cells[9, 0].Text = "ドロップダウン電卓";
            sheet.Cells[10, 0].Text = "DeleteキーでNULL";
            sheet.Cells[11, 0].Text = "マイナス値の色と記号";
            sheet.Cells[12, 0].Text = "スピンボタン";

            sheet.Cells[0, 2].Text = "接頭辞・接尾辞を表示します";
            sheet.Cells[1, 2].Text = "アラビア数字で入力すると漢数字で表示されます";
            sheet.Cells[2, 2].Text = "リテラル文字を表示します";
            sheet.Cells[3, 2].Text = "値が0のときに代替テキストを表示します";
            sheet.Cells[4, 2].Text = "値がNULLのときに代替テキストを表示します";
            sheet.Cells[5, 2].Text = "[Ctrl]+[Enter]で候補として表示された値を確定します";
            sheet.Cells[6, 2].Text = "範囲外の値の場合は値がクリアされます";
            sheet.Cells[7, 2].Text = "範囲外の値の場合は値を最小値か最大値の近い方に設定します";
            sheet.Cells[8, 2].Text = "数字5桁入力すると自動的に右隣のセルにフォーカスが移動します";
            sheet.Cells[9, 2].Text = "サイドボタンでドロップダウン電卓を表示します";
            sheet.Cells[10, 2].Text = "[Delete]または[BackSpace]で0をクリアできます";
            sheet.Cells[11, 2].Text = "マイナス(-)を▲と表記します";
            sheet.Cells[12, 2].Text = "スピンボタンで値を変更できます";

            //【入力・表示書式】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber1 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber1.AlternateText.DisplayNull.Text = "¥__(税込)";
            gcnumber1.DisplayFields.Clear();
            gcnumber1.DisplayFields.AddRange("#,###,###,##0,¥,(税込),-,");
            gcnumber1.Fields.SetFields("#,###,###,##0,¥,(税込),-,");
            gcnumber1.SideButtons.Clear();
            sheet.Cells[0, 1].CellType = gcnumber1;

            //【漢数字】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber2 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber2.DisplayFields.Clear();
            gcnumber2.DisplayFields.AddRange("[DBNum1]G,,,-,");
            gcnumber2.Fields.SetFields("#########0,,,-,");
            gcnumber2.SideButtons.Clear();
            sheet.Cells[1, 1].CellType = gcnumber2;

            //【リテラル文字】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber3 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber3.AlternateText.DisplayNull.Text = "高さ__mm";
            gcnumber3.AlternateText.DisplayNull.ForeColor = Color.Gray;
            gcnumber3.AlternateText.Null.Text = "高さ__mm";
            gcnumber3.AlternateText.Null.ForeColor = Color.Gray;
            gcnumber3.Fields.SignPrefix.ForeColor = Color.Blue;
            gcnumber3.Fields.SignPrefix.PositivePattern = ("高さ");
            gcnumber3.Fields.SignPrefix.NegativePattern = ("高さ▲");
            gcnumber3.Fields.SignSuffix.ForeColor = Color.Blue;
            gcnumber3.Fields.SignSuffix.PositivePattern = ("mm");
            gcnumber3.Fields.SignSuffix.NegativePattern = ("mm");
            GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberSignDisplayFieldInfo signDisp1 = new GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberSignDisplayFieldInfo("高さ ", "高さ ▲");
            GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberSignDisplayFieldInfo signDisp2 = new GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberSignDisplayFieldInfo(" mm", " mm");
            GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberIntegerPartDisplayFieldInfo integerDisp1 = new GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberIntegerPartDisplayFieldInfo();
            GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDecimalSeparatorDisplayFieldInfo separatorDisp1 = new GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDecimalSeparatorDisplayFieldInfo();
            GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDecimalPartDisplayFieldInfo DecimalPartDisplayField1 = new GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDecimalPartDisplayFieldInfo();
            signDisp1.ForeColor = Color.Blue;
            signDisp2.ForeColor = Color.Blue;
            gcnumber3.DisplayFields.Clear();
            gcnumber3.DisplayFields.AddRange(new GrapeCity.Win.Spread.InputMan.CellType.Fields.NumberDisplayFieldInfo[] { signDisp1, integerDisp1, separatorDisp1, DecimalPartDisplayField1, signDisp2 });
            gcnumber3.PaintByControl = true;
            gcnumber3.SideButtons.Clear();
            sheet.Cells[2, 1].CellType = gcnumber3;

            //【未入力の代替テキスト】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber4 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber4.AlternateText.DisplayZero.Text = "0円です";
            gcnumber4.AlternateText.DisplayZero.ForeColor = System.Drawing.Color.LightSeaGreen;
            gcnumber4.AlternateText.Zero.Text = "0円は無効です";
            gcnumber4.AlternateText.Zero.ForeColor = System.Drawing.Color.LightPink;
            gcnumber4.SideButtons.Clear();
            sheet.Cells[3, 1].CellType = gcnumber4;
            sheet.Cells[3, 1].Value = 0;

            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber5 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber5.AlternateText.DisplayNull.Text = "未入力です";
            gcnumber5.AlternateText.DisplayNull.ForeColor = System.Drawing.Color.LightSeaGreen;
            gcnumber5.AlternateText.Null.Text = "税込で入力します";
            gcnumber5.AlternateText.Null.ForeColor = System.Drawing.Color.LightPink;
            gcnumber5.SideButtons.Clear();
            sheet.Cells[4, 1].CellType = gcnumber5;

            sheet.Cells[3, 0].RowSpan = 2;
            sheet.Cells[3, 0].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;

            //【入力候補値】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber6 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber6.RecommendedValue = 53000;
            gcnumber6.ShowRecommendedValue = true;
            gcnumber6.SideButtons.Clear();
            sheet.Cells[5, 1].CellType = gcnumber6;

            //【範囲指定】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber7 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber7.MaxValue = 9999;
            gcnumber7.MinValue = -9999;
            gcnumber7.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.Clear;
            gcnumber7.SideButtons.Clear();
            sheet.Cells[6, 1].CellType = gcnumber7;

            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber8 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber8.MaxValue = 9999;
            gcnumber8.MinValue = -9999;
            gcnumber8.MaxMinBehavior = GrapeCity.Win.Spread.InputMan.CellType.MaxMinBehavior.AdjustToMaxMin;
            gcnumber8.SideButtons.Clear();
            sheet.Cells[7, 1].CellType = gcnumber8;

            sheet.Cells[6, 0].CellType = new FarPoint.Win.Spread.CellType.GeneralCellType() { Multiline = true };
            sheet.Cells[6, 0].RowSpan = 2;
            sheet.Cells[6, 0].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;

            //【自動フォーカス移動】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber9 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber9.DisplayFields.Clear();
            gcnumber9.DisplayFields.AddRange("##,##0,,,-,");
            gcnumber9.Fields.SetFields("##,##0,,,-,");
            gcnumber9.ExitOnLastChar = true;
            gcnumber9.SideButtons.Clear();
            sheet.Cells[8, 1].CellType = gcnumber9;

            //【ドロップダウン電卓】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber10 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber10.DropDownCalculator.BackColor = Color.LightGoldenrodYellow;
            gcnumber10.DropDownCalculator.BorderStyle = BorderStyle.None;
            gcnumber10.DropDownCalculator.EditButtons.BackColor = Color.SlateBlue;
            gcnumber10.DropDownCalculator.EditButtons.ForeColor = Color.White;
            gcnumber10.DropDownCalculator.FlatStyle = FlatStyle.Flat;
            gcnumber10.DropDownCalculator.MemoryButtons.BackColor = Color.Goldenrod;
            gcnumber10.DropDownCalculator.MemoryButtons.ForeColor = Color.White;
            gcnumber10.DropDownCalculator.MathButtons.BackColor = Color.DarkMagenta;
            gcnumber10.DropDownCalculator.MathButtons.ForeColor = Color.White;
            gcnumber10.DropDownCalculator.NumericButtons.BackColor = Color.Gray;
            gcnumber10.DropDownCalculator.NumericButtons.ForeColor = Color.White;
            gcnumber10.DropDownCalculator.Output.ForeColor = Color.DarkSlateBlue;
            gcnumber10.DropDownCalculator.OutputHeight = 25;
            gcnumber10.DropDownCalculator.ResetButtons.BackColor = Color.Salmon;
            gcnumber10.DropDownCalculator.ResetButtons.ForeColor = Color.White;
            sheet.Cells[9, 1].CellType = gcnumber10;

            //【DeleteキーでNULL】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber11 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber11.AllowDeleteToNull = true;
            gcnumber11.SideButtons.Clear();
            sheet.Cells[10, 1].CellType = gcnumber11;
            sheet.Cells[10, 1].Value = 0;

            //【マイナス値の色と記号】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber12 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber12.DisplayFields.Clear();
            gcnumber12.DisplayFields.AddRange("##########0,,,▲,");
            gcnumber12.Fields.SetFields("##########0,,,▲,");
            gcnumber12.NegativeColor = Color.Green;
            gcnumber12.UseNegativeColor = true;
            gcnumber12.SideButtons.Clear();
            sheet.Cells[11, 1].CellType = gcnumber12;

            //【スピンボタン】
            GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType gcnumber13 = new GrapeCity.Win.Spread.InputMan.CellType.GcNumberCellType();
            gcnumber13.SideButtons.Clear();
            gcnumber13.SideButtons.Add(new GrapeCity.Win.Spread.InputMan.CellType.SpinButtonInfo());
            gcnumber13.Spin.SpinOnKeys = true;
            gcnumber13.Spin.SpinOnWheel = true;
            sheet.Cells[12, 1].CellType = gcnumber13;
            sheet.Cells[12, 1].Value = 0;
        }
    }
}
