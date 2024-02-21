using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class customformula : SpreadWinDemo.DemoBase
    {
        public customformula()
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

            // 総合計列追加
            sheet.AddColumns(7, 1);
            sheet.ColumnHeader.Cells[0, 7].Text = "総合計";

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 135;
            sheet.Columns[3].Width = 65;
            sheet.Columns[4].Width = 65;
            sheet.Columns[5].Width = 65;
            sheet.Columns[6].Width = 65;
            sheet.Columns[7].Width = 78;


            // 作成したカスタム関数を追加
            FarPoint.Win.Spread.Model.ICustomFunctionSupport fs = (FarPoint.Win.Spread.Model.ICustomFunctionSupport)fpSpread1.ActiveSheet.Models.Data;
            fs.AddCustomFunction(new MySumFunction());

            // セルに関数を設定
            sheet.SetFormula(sheet.RowCount - 1, 7, "MySumFunction(D1:G" + Convert.ToString(sheet.RowCount) + ")");
            sheet.Cells[sheet.RowCount - 1, 7].BackColor = System.Drawing.Color.Salmon;
        }

        //FunctionInfoクラスを継承したサブクラスを作成
        [Serializable()] public class MySumFunction : FarPoint.CalcEngine.FunctionInfo 
        {
            public override object Evaluate(object[] args)
            {
                FarPoint.CalcEngine.CalcReference cr;
                double total = 0;

                if (args[0] is FarPoint.CalcEngine.CalcReference)
                {

                    // 引数args[0]より範囲を取得
                    cr = (FarPoint.CalcEngine.CalcReference)args[0];
                    for (int r = cr.Row; r < (cr.Row + cr.RowCount); r++)
                    {
                        for (int c = cr.Column; c < (cr.Column + cr.ColumnCount); c++)
                        {
                            // 範囲内の値を加算
                            total += FarPoint.CalcEngine.CalcConvert.ToDouble(cr.GetValue(r, c));
                        }
                    }

                    // 計算結果
                    return total;
                }
                else
                {
                    return FarPoint.CalcEngine.CalcError.Value;
                }
            }

            public override int MaxArgs { get { return 1; } }

            public override int MinArgs { get { return 1; } }

            public override string Name { get { return "MySumFunction"; } }

            public override bool AcceptsReference(int i) { return true; }
        }
    }
}
