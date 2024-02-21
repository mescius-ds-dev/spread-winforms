using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class statusbar : SpreadWinDemo.DemoBase
    {
        public statusbar()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.databind.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 45;
            sheet.Columns[1].Width = 85;
            sheet.Columns[2].Width = 140;
            for (int i = 3; i < sheet.ColumnCount; i++)
            {
                sheet.Columns[i].Width = 65;
            }

            // ステータスバーの表示
            fpSpread1.StatusBarVisible = true;

            // ステータスバーのスタイル設定
            fpSpread1.StatusBar.BackColor = Color.LemonChiffon;
            fpSpread1.StatusBar.ZoomSliderColor = Color.Turquoise;
            fpSpread1.StatusBar.ForeColor = Color.OliveDrab;
            fpSpread1.StatusBar.ZoomButtonHoverColor = Color.Gold;
            fpSpread1.StatusBar.ZoomSliderTrackColor = Color.DodgerBlue;
            fpSpread1.StatusBar.ZoomSliderHoverColor = Color.BurlyWood;

            // ステータスバーのすべての項目を表示
            // ステータスバーを右クリックして表示されるコンテキストメニューから各項目の表示と非表示を設定できます
            for (var i = 0; i < fpSpread1.StatusBar.Elements.Count; i++)
            {
                fpSpread1.StatusBar.Elements[i].Visible = true;
                //Console.WriteLine(fpSpread1.StatusBar.Elements[i].GetType());
            }
        }
    }
}
