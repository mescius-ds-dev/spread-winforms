using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class inputmap : SpreadWinDemo.DemoBase
    {
        public inputmap()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            fpSpread1.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(fpSpread1_ButtonClicked);
        }        

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 36;
            sheet.Columns[1].Width = 88;
            sheet.Columns[2].Width = 91;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 36;
            sheet.Columns[5].Width = 46;
            sheet.Columns[6].Width = 49;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 181;

            // 非連結行を追加します。
            sheet.AddUnboundRows(sheet.RowCount, 2);
            sheet.FrozenTrailingRowCount = 2;
            sheet.Cells[sheet.RowCount - 2, 0].Value = "[Enter]キーの動作：";
            sheet.Cells[sheet.RowCount - 2, 0].ColumnSpan = 2;
            sheet.Cells[sheet.RowCount - 1, 0].Value = "[Tab]キーの動作：";
            sheet.Cells[sheet.RowCount - 1, 0].ColumnSpan = 2;            
            FarPoint.Win.Spread.CellType.MultiOptionCellType multcellE = new FarPoint.Win.Spread.CellType.MultiOptionCellType();
            multcellE.Items = new String[] { "次の行へ移動", "次の列へ移動" };
            multcellE.Orientation = FarPoint.Win.RadioOrientation.Horizontal;
            sheet.Cells[sheet.RowCount - 2, 2].CellType = multcellE;
            sheet.Cells[sheet.RowCount - 2, 2].ColumnSpan = 7;
            FarPoint.Win.Spread.CellType.MultiOptionCellType multcellT = new FarPoint.Win.Spread.CellType.MultiOptionCellType();
            multcellT.Items = new String[] { "次の行へ移動", "次の列へ移動" };
            multcellT.Orientation = FarPoint.Win.RadioOrientation.Horizontal;
            sheet.Cells[sheet.RowCount - 1, 2].CellType = multcellT;
            sheet.Cells[sheet.RowCount - 1, 2].ColumnSpan = 7;
        }

        void fpSpread1_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            if (e.Row == fpSpread1.Sheets[0].RowCount - 2 & e.Column == 2)
            {
                if ((int)fpSpread1.ActiveSheet.ActiveCell.Value == 0)
                {
                    // [Enter]キーの動作を「次の行へ移動」に設定
                    FarPoint.Win.Spread.InputMap im;                    
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow);
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow);
                }
                else
                {
                    // [Enter]キーの動作を「次の列へ移動」に設定
                    FarPoint.Win.Spread.InputMap im;
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap);
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap);
                }
            }
            else if (e.Row == fpSpread1.Sheets[0].RowCount - 1 & e.Column == 2)
            {
                if ((int)fpSpread1.ActiveSheet.ActiveCell.Value == 0)
                {
                    // [Enter]キーの動作を「次の行へ移動」に設定
                    FarPoint.Win.Spread.InputMap im;
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow);
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow);
                }
                else
                {
                    // [Enter]キーの動作を「次の列へ移動」に設定
                    FarPoint.Win.Spread.InputMap im;
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap);
                    im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap);
                    im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap);
                }
            }
        }
    }
}
