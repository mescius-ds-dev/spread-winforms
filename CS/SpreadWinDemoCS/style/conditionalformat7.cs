using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class conditionalformat7 : SpreadWinDemo.DemoBase
    {
        public conditionalformat7()
        {
            InitializeComponent();

            // シート設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.dataconditionalformat.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 120;
            sheet.Columns[1].Width = 80;
            sheet.Columns[2].Width = 80;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;

            // 行の追加
            sheet.AddRows(sheet.RowCount, 1);
            sheet.Cells[sheet.RowCount - 1, 0].Value = "平均";
            sheet.Rows[sheet.RowCount - 1].BackColor = System.Drawing.Color.Khaki;

            // 数式の設定
            for (int i = 1; i < sheet.ColumnCount; i++)
            {
                string col = Convert.ToString((char)(65 + i));
                sheet.Cells[sheet.RowCount - 1, i].Formula = "AVERAGE(" + col + "1:" + col + Convert.ToString(sheet.RowCount - 1) + ")";
            }

            FarPoint.Win.Spread.ConditionalFormatting cf = new FarPoint.Win.Spread.ConditionalFormatting(new FarPoint.Win.Spread.Model.CellRange(0, 1, sheet.RowCount - 1, sheet.ColumnCount));
            FarPoint.Win.Spread.DatabarConditionalFormattingRule rule = new FarPoint.Win.Spread.DatabarConditionalFormattingRule();
            rule.BorderColor = System.Drawing.Color.Silver;
            rule.ShowBorder = true;
            rule.Gradient = true;
            rule.Minimum = new FarPoint.Win.Spread.ConditionalFormattingValue(0, FarPoint.Win.Spread.ConditionalFormattingValueType.Number);
            rule.Maximum = new FarPoint.Win.Spread.ConditionalFormattingValue(100, FarPoint.Win.Spread.ConditionalFormattingValueType.Max);
            cf.Add(rule);
            sheet.Models.ConditionalFormatting.Add(cf);

            FarPoint.Win.Spread.ConditionalFormatting cf1 = new FarPoint.Win.Spread.ConditionalFormatting(new FarPoint.Win.Spread.Model.CellRange(sheet.RowCount - 1, 1, 1, sheet.ColumnCount));
            FarPoint.Win.Spread.IconSetConditionalFormattingRule rule1 = new FarPoint.Win.Spread.IconSetConditionalFormattingRule(FarPoint.Win.Spread.ConditionalFormattingIconSetStyle.ThreeFlags);
            cf1.Add(rule1);
            sheet.Models.ConditionalFormatting.Add(cf1);
        }
    }
}
