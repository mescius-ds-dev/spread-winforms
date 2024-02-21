using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.selection
{
    public partial class paintactivecell : SpreadWinDemo.DemoBase
    {
        public paintactivecell()
        {
            InitializeComponent();

            // SPREADの設定
            InitSheet(fpSpread1);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            checkBox1.CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
        }

        private void InitSheet(FarPoint.Win.Spread.FpSpread spread)
        {
            // アクティブセルの背景色を選択色と同じ色で塗りつぶす
            spread.PaintActiveCellInSelection = true;
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

            // 選択色の設定
            sheet.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors;
            sheet.SelectionBackColor = Color.FromArgb(51, 153, 255);
            FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer ch = new FarPoint.Win.Spread.CellType.EnhancedColumnHeaderRenderer();
            ch.SelectedBackgroundColor = Color.FromArgb(140, 198, 255);
            ch.SelectedGridLineColor = Color.FromArgb(230, 230, 230);
            ch.ActiveBackgroundColor = Color.FromArgb(186, 234, 253);
            ch.BackColor = System.Drawing.SystemColors.Control;
            ch.ForeColor = System.Drawing.SystemColors.ControlText;
            ch.NormalGridLineColor = Color.FromArgb(230, 230, 230);
            ch.SelectedActiveBackgroundColor = Color.FromArgb(186, 234, 253);
            fpSpread1.ActiveSheet.ColumnHeader.DefaultStyle.Renderer = ch;
            FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer rh = new FarPoint.Win.Spread.CellType.EnhancedRowHeaderRenderer();
            rh.SelectedBackgroundColor = Color.FromArgb(140, 198, 255);
            rh.SelectedGridLineColor = Color.FromArgb(230, 230, 230);
            rh.ActiveBackgroundColor = Color.FromArgb(186, 234, 253);
            rh.BackColor = System.Drawing.SystemColors.Control;
            rh.ForeColor = System.Drawing.SystemColors.ControlText;
            rh.NormalGridLineColor = Color.FromArgb(230, 230, 230);
            rh.SelectedActiveBackgroundColor = Color.FromArgb(186, 234, 253);
            fpSpread1.ActiveSheet.RowHeader.DefaultStyle.Renderer = rh;
        }

        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fpSpread1.PaintActiveCellInSelection = true;
            }
            else
            {
                fpSpread1.PaintActiveCellInSelection = false;
            }
        }
    }
}
