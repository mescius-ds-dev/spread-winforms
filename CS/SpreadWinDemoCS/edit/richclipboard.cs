using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class richclipboard : SpreadWinDemo.DemoBase
    {
        public richclipboard()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1, fpSpread2);

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
            InitWorkbook(fpSpread2.AsWorkbook());
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread1, FarPoint.Win.Spread.FpSpread spread2)
        {
            spread2.AsWorkbook().Name = "Book2";
            spread1.AsWorkbook().WorkbookSet.Workbooks.Add(spread2.AsWorkbook());

            spread1.Features.EnhancedShapeEngine = true;
            spread2.Features.EnhancedShapeEngine = true;
            spread1.Features.RichClipboard = true;
            spread2.Features.RichClipboard = true;

            spread1.AllowUserFormulas = true;
            spread2.AllowUserFormulas = true;
            spread1.AsWorkbook().ActiveSheet.Cells["A1"].Value = 3;
            spread1.AsWorkbook().ActiveSheet.Cells["B3"].Formula = "Sheet1!A1";

            // コメントの追加
            GrapeCity.Spreadsheet.IComment cm = fpSpread1.AsWorkbook().ActiveSheet.Cells["B6"].AddComment("新しいコメント");
            cm.Visible = true;
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;
        }
    }
}
