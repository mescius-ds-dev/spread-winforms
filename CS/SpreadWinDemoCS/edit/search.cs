using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.edit
{
    public partial class search : SpreadWinDemo.DemoBase
    {
        public search()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
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
            sheet.Columns[7].Width = 71;
            sheet.Columns[8].Width = 181;
            
            // セルノート設定
            sheet.Cells[0, 0].Note = "人事異動予定";
            sheet.Cells[0, 0].NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote;

            // タグ設定
            sheet.Cells[1, 0].Tag = "退職予定";
        }

        void button1_Click(object sender, EventArgs e)
        {
            // 標準検索の実行
            fpSpread1.SearchWithDialog("人事部");
        }

        void button2_Click(object sender, EventArgs e)
        {
            // 高度な検索の実行
            fpSpread1.SearchWithDialogAdvanced("人事異動予定");
        }
    }
}
