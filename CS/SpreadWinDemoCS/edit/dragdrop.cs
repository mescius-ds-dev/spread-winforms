using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class dragdrop : SpreadWinDemo.DemoBase
    {
        public dragdrop()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1, fpSpread2);

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            // TextBoxの設定：ドロップを許可
            textBox1.AllowDrop = true;

            fpSpread1.MouseDown += new MouseEventHandler(fpSpread1_MouseDown);
            fpSpread1.DragOver += new DragEventHandler(fpSpread1_DragOver);
            fpSpread2.DragEnter += new DragEventHandler(fpSpread2_DragEnter);
            fpSpread2.DragOver += new DragEventHandler(fpSpread2_DragOver);
            fpSpread2.DragDrop += new DragEventHandler(fpSpread2_DragDrop);
            textBox1.DragEnter += new DragEventHandler(textBox1_DragEnter);
            textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);
        }

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread1, FarPoint.Win.Spread.FpSpread spread2)
        {
            // ドロップを許可
            spread1.AllowDrop = true;
            spread2.AllowDrop = true;
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
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
        }

        void fpSpread1_MouseDown(object sender, MouseEventArgs e)
        {
            // マウスの右ボタンが押下された場合
            if (e.Button == MouseButtons.Right)
            {
                // SPREADの取得
                FarPoint.Win.Spread.FpSpread spread = sender as FarPoint.Win.Spread.FpSpread;

                // 選択範囲の取得
                FarPoint.Win.Spread.Model.CellRange range = spread.ActiveSheet.GetSelection(0);
                if (range == null)
                {
                    range = new FarPoint.Win.Spread.Model.CellRange(spread.ActiveSheet.ActiveRowIndex, spread.ActiveSheet.ActiveColumnIndex, 1, 1);
                }
                if (range.Column < 0)
                {
                    range = new FarPoint.Win.Spread.Model.CellRange(range.Row, 0, range.RowCount, spread.ActiveSheet.ColumnCount);
                }
                if (range.Row < 0)
                {
                    range = new FarPoint.Win.Spread.Model.CellRange(0, range.Column, spread.ActiveSheet.RowCount, range.ColumnCount);
                }

                // 選択範囲のデータの取得
                string data = spread.ActiveSheet.GetClip(range.Row, range.Column, range.RowCount, range.ColumnCount);

                // ドラッグ＆ドロップの開始
                spread.DoDragDrop(data, DragDropEffects.Move);
            }
        }

        void fpSpread1_DragOver(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップ操作の指定
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        void fpSpread2_DragEnter(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップ操作の指定
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        void fpSpread2_DragOver(object sender, DragEventArgs e)
        {
            // SPREADの取得
            FarPoint.Win.Spread.FpSpread spread = sender as FarPoint.Win.Spread.FpSpread;

            // マウスポインタ位置の取得
            Point pos = spread.PointToClient(new Point(e.X, e.Y));
            FarPoint.Win.Spread.Model.CellRange range = spread.GetCellFromPixel(0, 0, pos.X, pos.Y);

            // マウスポインタが通常セル上にある場合
            if (range.ColumnCount > -1 && range.RowCount > -1)
            {
                // ドロップ対象範囲の明示
                spread.ActiveSheet.ClearSelection();
                string data = (string)e.Data.GetData("Text");
                string[] lines = data.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                string[] cells = lines[0].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                spread.ActiveSheet.AddSelection(range.Row, range.Column, lines.Length, cells.Length);
            }
        }

        void fpSpread2_DragDrop(object sender, DragEventArgs e)
        {
            // SPREADの取得
            FarPoint.Win.Spread.FpSpread spread = sender as FarPoint.Win.Spread.FpSpread;

            // ドロップ対象範囲の取得
            FarPoint.Win.Spread.Model.CellRange range = spread.ActiveSheet.GetSelection(0);

            // ドロップ操作の実行
            spread.ActiveSheet.SetClip(range.Row, range.Column, range.RowCount, range.ColumnCount, (string)e.Data.GetData("Text"));
        }

        void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップ操作の指定
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            // TextBoxの取得
            TextBox tb = sender as TextBox;

            // ドロップ操作の実行
            tb.Text = (string)e.Data.GetData("Text");
        }
    }
}
