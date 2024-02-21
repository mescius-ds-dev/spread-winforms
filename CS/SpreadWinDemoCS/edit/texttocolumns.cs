using GrapeCity.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class texttocolumns : SpreadWinDemo.DemoBase
    {
        public texttocolumns()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A1"].Value = "Jacob Dev SpreadWin";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A2"].Value = "Steve Dev Raykit";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A3"].Value = "Serena Tester SpreadWin";
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A4"].Value = "Keira Tester Raykit";

        }

        void button1_Click(object sender, EventArgs e)
        {
            // メソッドで設定
            fpSpread1.AsWorkbook().ActiveSheet.Cells["A1:A4"].TextToColumns("A5", TextParsingType.Delimited, TextQualifier.None, false, false, false, false, true);
        }

        void button2_Click(object sender, EventArgs e)
        {
            // ダイアログで設定
            FarPoint.Win.Spread.Dialogs.BuiltInDialogs.TextToColumns(fpSpread1)?.Show(fpSpread1);
        }
    }
}
