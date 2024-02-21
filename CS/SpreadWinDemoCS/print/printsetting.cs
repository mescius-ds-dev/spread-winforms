using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.print
{
    public partial class printsetting : SpreadWinDemo.DemoBase
    {
        public printsetting()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // データの作成
            DataTable dt = new DataTable();
            int cols = 20;
            int rows = 65;
            for (var i = 0; i < cols; i++)
            {
                dt.Columns.Add(string.Format("列{0}", i + 1), typeof(String));
            }
            for (var i = 0; i < rows; i++)
            {
                DataRow dr = dt.NewRow();
                for (var j = 0; j < cols; j++)
                {
                    dr[j] = string.Format("R{0}C{1}", i, j);
                }
                dt.Rows.Add(dr);
            }
            dt.AcceptChanges();
            
            // データ連結
            sheet.DataAutoCellTypes = false;
            sheet.DataAutoSizeColumns = false;
            sheet.DataSource = dt;

            // セルノートの設定
            sheet.Cells[1, 1].Note = "セルノートの表示";
            sheet.Cells[1, 1].NoteIndicatorSize = new Size(5, 5);
        }

        void button1_Click(object sender, EventArgs e)
        {
            // マウスカーソルの一時変更
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;

            // ページ設定ダイアログの表示
            PrintSettingForm psDialog = new PrintSettingForm(fpSpread1);
            psDialog.ShowDialog();

            // マウスカーソルの一時変更の解除
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }
    }
}
