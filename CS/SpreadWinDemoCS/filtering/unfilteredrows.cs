using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.filtering
{
    public partial class unfilteredrows : SpreadWinDemo.DemoBase
    {
        public unfilteredrows()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            ////【変更前】
            ////データ連結
            //DataSet ds = new DataSet();
            //ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));
            //sheet.DataSource = ds;

            //// 列幅の設定
            //sheet.Columns[0].Width = 40;
            //sheet.Columns[1].Width = 90;
            //sheet.Columns[2].Width = 97;
            //sheet.Columns[3].Width = 80;
            //sheet.Columns[4].Width = 70;
            //sheet.Columns[5].Width = 70;
            //sheet.Columns[6].Width = 75;
            //sheet.Columns[7].Width = 80;

            //// メールアドレス非表示
            //sheet.Columns[8].Visible = false;

            //sheet.ColumnHeaderAutoTextIndex = 0;
            //sheet.ColumnHeader.RowCount = 2;

            //// 固定行の設定
            //sheet.FrozenRowCount = 2;
            
            //// フィルターを設定
            //FarPoint.Win.Spread.HideRowFilter hideRowFilter = new FarPoint.Win.Spread.HideRowFilter(sheet);
            //hideRowFilter.AllString = "<すべて>";
            //hideRowFilter.NonBlanksString = "<空白以外>";
            //hideRowFilter.FilterFrozenRows = false;
            //sheet.RowFilter = hideRowFilter; //フィルターを設定
            //sheet.ColumnHeaderAutoFilterIndex = 1;

            //// フィルターに列を追加
            //FarPoint.Win.Spread.FilterColumnDefinition fcd;
            //fcd = new FarPoint.Win.Spread.FilterColumnDefinition(4);
            //hideRowFilter.AddColumn(fcd);
            //fcd = new FarPoint.Win.Spread.FilterColumnDefinition(5);
            //hideRowFilter.AddColumn(fcd);
            //fcd = new FarPoint.Win.Spread.FilterColumnDefinition(6);
            //hideRowFilter.AddColumn(fcd);


            //【変更後】：固定行が設定されていることがわかるようにスクロールが必要になるだけの行数のデータに変更
            //データ連結
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data30.xml"));
            sheet.DataSource = ds;

            // 列幅の設定
            sheet.Columns[0].Width = 70;
            sheet.Columns[1].Width = 70;
            sheet.Columns[2].Width = 80;
            sheet.Columns[3].Width = 140;
            sheet.Columns[4].Width = 140;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 80;
            sheet.Columns[7].Width = 50;
            sheet.Columns[8].Width = 60;
            sheet.Columns[9].Width = 70;
            sheet.Columns[10].Width = 300;

            // 固定行の設定
            sheet.FrozenRowCount = 2;

            // フィルターを設定
            FarPoint.Win.Spread.HideRowFilter hideRowFilter = new FarPoint.Win.Spread.HideRowFilter(sheet);
            hideRowFilter.AllString = "<すべて>";
            hideRowFilter.NonBlanksString = "<空白以外>";
            hideRowFilter.FilterFrozenRows = false;
            sheet.RowFilter = hideRowFilter; //フィルターを設定
            sheet.ColumnHeaderAutoFilterIndex = 1;

            // フィルターに列を追加
            FarPoint.Win.Spread.FilterColumnDefinition fcd;
            fcd = new FarPoint.Win.Spread.FilterColumnDefinition(1);
            hideRowFilter.AddColumn(fcd);
            fcd = new FarPoint.Win.Spread.FilterColumnDefinition(5);
            hideRowFilter.AddColumn(fcd);
        }
    }
}
