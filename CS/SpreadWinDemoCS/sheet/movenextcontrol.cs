using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class movenextcontrol : SpreadWinDemo.DemoBase
    {
        public movenextcontrol()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 列数と行数の設定
            sheet.ColumnCount = 3;
            sheet.RowCount = 3;

            // 入力マップの設定
            FarPoint.Win.Spread.InputMap im;
            im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused);
            im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextCellThenControl);
            im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousCellThenControl);

            //// 常時入力モードの場合
            //fpSpread1.EditModePermanent = true;
            //im = fpSpread1.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused);
            //im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextCellThenControl);
            //im.Put(new FarPoint.Win.Spread.Keystroke(Keys.Tab, Keys.Shift), FarPoint.Win.Spread.SpreadActions.MoveToPreviousCellThenControl);
        }
    }
}
