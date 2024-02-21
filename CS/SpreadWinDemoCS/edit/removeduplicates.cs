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
    public partial class removeduplicates : SpreadWinDemo.DemoBase
    {
        public removeduplicates()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.ActiveSheet.SetValue(0, 0, "Steve");
            fpSpread1.ActiveSheet.SetValue(1, 0, "Steve");
            fpSpread1.ActiveSheet.SetValue(2, 0, "Pete");
            fpSpread1.ActiveSheet.SetValue(3, 0, "Mike");
            fpSpread1.ActiveSheet.SetValue(4, 0, "Steve");
            fpSpread1.ActiveSheet.SetValue(5, 0, "Emily");
            fpSpread1.ActiveSheet.SetValue(6, 0, "Steve");

            fpSpread1.ActiveSheet.SetValue(0, 1, 1);
            fpSpread1.ActiveSheet.SetValue(1, 1, 1);
            fpSpread1.ActiveSheet.SetValue(2, 1, 2);
            fpSpread1.ActiveSheet.SetValue(3, 1, 3);
            fpSpread1.ActiveSheet.SetValue(4, 1, 5);
            fpSpread1.ActiveSheet.SetValue(5, 1, 8);
            fpSpread1.ActiveSheet.SetValue(6, 1, 13);

            fpSpread1.ActiveSheet.SetValue(0, 2, 1);
            fpSpread1.ActiveSheet.SetValue(1, 2, 1);
            fpSpread1.ActiveSheet.SetValue(2, 2, 2);
            fpSpread1.ActiveSheet.SetValue(3, 2, 3);
            fpSpread1.ActiveSheet.SetValue(4, 2, 5);
            fpSpread1.ActiveSheet.SetValue(5, 2, 8);
            fpSpread1.ActiveSheet.SetValue(6, 2, 13);

            fpSpread1.ActiveSheet.SetValue(0, 3, 1);
            fpSpread1.ActiveSheet.SetValue(1, 3, 1);
            fpSpread1.ActiveSheet.SetValue(2, 3, 2);
            fpSpread1.ActiveSheet.SetValue(3, 3, 3);
            fpSpread1.ActiveSheet.SetValue(4, 3, 5);
            fpSpread1.ActiveSheet.SetValue(5, 3, 8);
            fpSpread1.ActiveSheet.SetValue(6, 3, 13);

            fpSpread1.ActiveSheet.SetValue(0, 4, 1);
            fpSpread1.ActiveSheet.SetValue(1, 4, 1);
            fpSpread1.ActiveSheet.SetValue(2, 4, 2);
            fpSpread1.ActiveSheet.SetValue(3, 4, 3);
            fpSpread1.ActiveSheet.SetValue(4, 4, 5);
            fpSpread1.ActiveSheet.SetValue(5, 4, 8);
            fpSpread1.ActiveSheet.SetValue(6, 4, 13);
        }

        void button1_Click(object sender, EventArgs e)
        {
            // メソッドで重複データを削除
            int[] columns = { 1, 2 };
            fpSpread1.AsWorkbook().ActiveSheet.Range("A1:E7").RemoveDuplicates(columns, YesNoGuess.No);
        }

        void button2_Click(object sender, EventArgs e)
        {
            // ダイアログで重複データを削除
            FarPoint.Win.Spread.Dialogs.BuiltInDialogs.RemoveDuplicates(fpSpread1).ShowDialog(fpSpread1);
        }
    }
}
