using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.shape
{
    public partial class freeform : SpreadWinDemo.DemoBase
    {
        public freeform()
        {
            InitializeComponent();

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;
        }

        void button1_Click(object sender, EventArgs e)
        {
            fpSpread1.StopAnnotationMode();

            // 図形
            fpSpread1.Features.EnhancedShapeEngine = true;
            fpSpread1.StartAnnotationMode(FarPoint.Win.Spread.AnnotationMode.Freeform);
            fpSpread1.Focus();
        }

        void button2_Click(object sender, EventArgs e)
        {
            fpSpread1.StopAnnotationMode();

            // フリーハンド
            fpSpread1.Features.EnhancedShapeEngine = true;
            fpSpread1.StartAnnotationMode(FarPoint.Win.Spread.AnnotationMode.Scribble);
        }
    }
}
