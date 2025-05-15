using FarPoint.Win.Spread;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class contextmenu : SpreadWinDemo.DemoBase
    {
        public contextmenu()
        {
            InitializeComponent();

            // シートの設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.ContextMenuStrip = new SpreadContextMenuStrip();
        }
    }
}
