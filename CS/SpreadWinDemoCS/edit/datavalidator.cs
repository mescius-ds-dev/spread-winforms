using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class datavalidator : SpreadWinDemo.DemoBase
    {
        public datavalidator()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.datanum2.xml"));
            sheet.DataSource = ds;

            // TextLengthValidatorの設定（1列目）
            FarPoint.Win.Spread.TextLengthValidator lengthValidator = new FarPoint.Win.Spread.TextLengthValidator();
            lengthValidator.MaximumLength = 5;
            lengthValidator.MinimumLength = 5;
            FarPoint.Win.Spread.TipNotify tipNotify = new FarPoint.Win.Spread.TipNotify();
            tipNotify.ToolTipText = "5桁の文字列を入力してください。";
            lengthValidator.Actions.Add(tipNotify);
            sheet.AddValidators(new FarPoint.Win.Spread.Model.CellRange(0, 0, sheet.RowCount, 1), lengthValidator);

            // CharFormatValidator（2～3列目）
            FarPoint.Win.Spread.CharFormatValidator formatValidator = new FarPoint.Win.Spread.CharFormatValidator();
            formatValidator.Format = "Ｚ";
            FarPoint.Win.Spread.MessageBoxNotify msgNotify = new FarPoint.Win.Spread.MessageBoxNotify();
            msgNotify.Message = "全角で入力してください。";
            formatValidator.Actions.Add(msgNotify);
            sheet.AddValidators(new FarPoint.Win.Spread.Model.CellRange(0, 1, sheet.RowCount, 2), formatValidator);

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 100;
            sheet.Columns[2].Width = 141;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;
        }
    }
}
