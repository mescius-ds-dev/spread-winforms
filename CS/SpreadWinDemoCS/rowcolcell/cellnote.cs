using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class cellnote : SpreadWinDemo.DemoBase
    {
        public cellnote()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
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

            // セルノートの設定
            sheet.AllowNoteEdit = true;
            sheet.Cells[1, 1].NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote;
            sheet.Cells[1, 1].Note = "セルのデータとは別に、メモなどを表示することができます。";

            // セルノートのスタイルの設定
            FarPoint.Win.Spread.DrawingSpace.StickyNoteStyleInfo nsinfo = new FarPoint.Win.Spread.DrawingSpace.StickyNoteStyleInfo();
            nsinfo.Width = 300;
            nsinfo.Height = 100;
            nsinfo.MarginTop = 10;
            nsinfo.MarginLeft = 10;
            nsinfo.Top = 20;
            nsinfo.Left = 20;
            nsinfo.Font = new System.Drawing.Font("メイリオ", 10);
            fpSpread1.ActiveSheet.SetStickyNoteStyleInfo(1, 1, nsinfo);
        }
    }
}
