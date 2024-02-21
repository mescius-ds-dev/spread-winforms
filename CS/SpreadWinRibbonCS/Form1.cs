using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using GrapeCity.Core;
using GrapeCity.Spreadsheet.WinForms.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SpreadWinRibbonCS
{
    public partial class Form1 : Form
    {
        // SPREAD定義（実績データ）
        private int _SPR_RDATA_RH = 0;
        private int _SPR_RDATA_Hgkey = 1;
        private int _SPR_RDATA_product = 2;
        private int _SPR_RDATA_m4 = 3;
        private int _SPR_RDATA_m5 = 4;
        private int _SPR_RDATA_m6 = 5;
        private int _SPR_RDATA_m7 = 6;
        private int _SPR_RDATA_m8 = 7;
        private int _SPR_RDATA_m9 = 8;
        private int _SPR_RDATA_m10 = 9;
        private int _SPR_RDATA_m11 = 10;
        private int _SPR_RDATA_m12 = 11;
        private int _SPR_RDATA_m1 = 12;
        private int _SPR_RDATA_m2 = 13;
        private int _SPR_RDATA_m3 = 14;
        // ヘッダ開始行
        private int _SPR_RDATA_START_ROW = 2;
        // タイトル
        private int _SPR_RDATA_TITLE_ROW = 0;
        private int _SPR_RDATA_TITLE_COL = 0;
        private int _SPR_COL_RDATA_WIDHT_CUR = 40;     //SPREAD金額列の列幅    

        //列名
        private string _SPR_COLNM_PRD = "製品";

        // ブランク列
        private int _SPR_COLBLK1 = 15;

        // ブランク行
        private int _SPR_ROWBLK1 = 1;
        private int _SPR_ROWBLK2 = 19;

        //チャート関連
        private int _CHT_RDATA_WIDTH = 650;
        private int _CHT_RDATA_HIGHT = 280;

        public Form1()
        {
            InitializeComponent();
        }

        // *******************************************************
        // フォームロード時
        // *******************************************************
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //SPREAD初期化
                initSPREAD();

                // 売上実績
                dspSalesResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        #region SPREAD初期化
        // ------------------------------------------------------
        // SPREAD初期化
        // ------------------------------------------------------
        private void initSPREAD()
        {
            // Ribbonコントロールに新しいタブを追加
            ribbonBar1.Tabs.Add(new GrapeCity.Spreadsheet.WinForms.Ribbon.RibbonTab());
            ribbonBar1.Tabs[ribbonBar1.Tabs.Count - 1].Text = "新しいタブ";
            ribbonBar1.Tabs[ribbonBar1.Tabs.Count - 1].Groups.Add(new GrapeCity.Spreadsheet.WinForms.Ribbon.RibbonGroup());
            ribbonBar1.Tabs[ribbonBar1.Tabs.Count - 1].Groups[0].Text = "新しいグループ";
            ribbonBar1.Tabs[ribbonBar1.Tabs.Count - 1].Groups[0].Items.Add("アクティブセルの情報を取得");
            ribbonBar1.Tabs[ribbonBar1.Tabs.Count - 1].Groups[0].Items[0].Name = "RibbonItem1";
            ribbonBar1.CommandExecuting += RibbonBar1_CommandExecuting;

            setAppearance(true);

        }
        #endregion

        #region SPREADの外観を設定
        // ------------------------------------------------------
        // SPREADの外観を設定
        // ------------------------------------------------------
        private void setAppearance(bool init)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IWorkbook workbook = fpSpread1.AsWorkbook();
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            // タイトル用スタイル作成
            GrapeCity.Spreadsheet.IStyle titleStyle = workbook.Styles["MyTitle"];
            if (titleStyle == null) titleStyle = workbook.Styles.Add("MyTitle");
            titleStyle.Interior.Color = GrapeCity.Spreadsheet.Color.FromKnownColor(GrapeCity.Core.KnownColor.DarkBlue);
            titleStyle.Font.Name = "メイリオ";
            titleStyle.Font.Size = 11f;
            titleStyle.Font.Italic = true;
            titleStyle.Font.Bold = true;
            titleStyle.Font.Color = GrapeCity.Spreadsheet.Color.FromKnownColor(GrapeCity.Core.KnownColor.White);
            titleStyle.VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center;
            // ヘッダ用スタイル作成
            GrapeCity.Spreadsheet.IStyle headStyle = workbook.Styles["MyHead"];
            if (headStyle == null) headStyle = workbook.Styles.Add("MyHead");
            headStyle.Interior.Color = GrapeCity.Spreadsheet.Color.FromKnownColor(GrapeCity.Core.KnownColor.SeaGreen);
            headStyle.Font.Color = GrapeCity.Spreadsheet.Color.FromKnownColor(GrapeCity.Core.KnownColor.White);
            headStyle.HorizontalAlignment = GrapeCity.Spreadsheet.HorizontalAlignment.Center;
            headStyle.VerticalAlignment = GrapeCity.Spreadsheet.VerticalAlignment.Center;

            // ----------------------------------------------------------------------------------
            // ◆売上実績ブロック
            // ----------------------------------------------------------------------------------
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_TITLE_ROW, _SPR_RDATA_TITLE_COL, "製品別売上実績");
            fpSpread1.ActiveSheet.AddSpanCell(_SPR_RDATA_TITLE_ROW, _SPR_RDATA_TITLE_COL, 1, 7);
            // タイトル関連
            fpSpread1.AsWorkbook().ActiveSheet.Cells[_SPR_RDATA_TITLE_ROW, _SPR_RDATA_TITLE_COL].Style = titleStyle;
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_TITLE_ROW, _SPR_RDATA_m2, "単位:百円");
            fpSpread1.ActiveSheet.AddSpanCell(_SPR_RDATA_TITLE_ROW, _SPR_RDATA_m2, 1, 2);
            fpSpread1.ActiveSheet.Cells[_SPR_RDATA_TITLE_ROW, _SPR_RDATA_m2].HorizontalAlignment = CellHorizontalAlignment.Right;
            fpSpread1.ActiveSheet.Cells[_SPR_RDATA_TITLE_ROW, _SPR_RDATA_m2].VerticalAlignment = CellVerticalAlignment.Bottom;
            fpSpread1.ActiveSheet.Cells[_SPR_RDATA_TITLE_ROW, _SPR_RDATA_m2].Font = new Font("メイリオ", 8f);
            // 行ヘッダ
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_product, _SPR_COLNM_PRD);
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m4, "4月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m5, "5月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m6, "6月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m7, "7月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m8, "8月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m9, "9月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m10, "10月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m11, "11月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m12, "12月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m1, "1月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m2, "2月");
            fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW, _SPR_RDATA_m3, "3月");
            fpSpread1.AsWorkbook().ActiveSheet.Cells[_SPR_RDATA_START_ROW, _SPR_RDATA_RH, _SPR_RDATA_START_ROW, _SPR_RDATA_m3].Style = headStyle;
            // 列幅
            fpSpread1.ActiveSheet.Columns[_SPR_RDATA_RH].Width = 20;
            fpSpread1.ActiveSheet.Columns[_SPR_RDATA_product].Width = 150;
            fpSpread1.ActiveSheet.Columns[_SPR_RDATA_m4, _SPR_RDATA_m3].Width = _SPR_COL_RDATA_WIDHT_CUR;
            // キー項目非表示
            fpSpread1.ActiveSheet.Columns[_SPR_RDATA_Hgkey].Visible = false;

            // ブランク列
            fpSpread1.ActiveSheet.Columns[_SPR_COLBLK1].Width = 10;
            // ブランク行
            fpSpread1.ActiveSheet.Rows[_SPR_ROWBLK1].Height = 5;
            fpSpread1.ActiveSheet.Rows[_SPR_ROWBLK2].Height = 5;
        }
        #endregion

        #region 売上実績部分を表示
        // ------------------------------------------------------
        // 売上実績部分を表示
        // ------------------------------------------------------
        private void dspSalesResult()
        {
            try
            {
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                dt = ds.Tables.Add("fyeardata");
                dt.Columns.AddRange(new DataColumn[] {
                    new DataColumn("No", typeof(int)),
                    new DataColumn("製品",  typeof(string)),
                    new DataColumn("4月", typeof(int)),
                    new DataColumn("5月", typeof(int)),
                    new DataColumn("6月", typeof(int)),
                    new DataColumn("7月", typeof(int)),
                    new DataColumn("8月", typeof(int)),
                    new DataColumn("9月", typeof(int)),
                    new DataColumn("10月", typeof(int)),
                    new DataColumn("11月", typeof(int)),
                    new DataColumn("12月", typeof(int)),
                    new DataColumn("1月", typeof(int)),
                    new DataColumn("2月", typeof(int)),
                    new DataColumn("3月", typeof(int))
                });

                dt.Rows.Add(new object[] { 1, "Multi Reports 共通", 67410, 109872, 203616, 72324, 32004, 65646, 69930, 32004, 26964, 0, 0, 0 });
                dt.Rows.Add(new object[] { 2, "AllComponent 共通", 5985, 5985, 5985, 17955, 11970, 11970, 47880, 29925, 11970, 0, 0, 0 });
                dt.Rows.Add(new object[] { 3, "Gsheet Windows Forms", 4788, 22680, 4788, 4536, 4788, 4788, 16632, 4536, 7056, 0, 0, 0 });
                dt.Rows.Add(new object[] { 4, "SpeedGrid Windows Forms", 16727, 5387, 8222, 7938, 23814, 7938, 22113, 29484, 20696, 0, 0, 0 });
                dt.Rows.Add(new object[] { 5, "CADHSuite 共通", 4316, 12947, 4316, 4788, 4316, 4788, 17262, 22050, 21578, 0, 0, 0 });
                dt.Rows.Add(new object[] { 6, "KindInput Windows Forms", 6804, 27216, 7560, 6804, 14742, 28728, 120204, 20790, 20412, 0, 0, 0 });
                dt.Rows.Add(new object[] { 7, "KindInput ASP", 7182, 6804, 13608, 7560, 22302, 3402, 10584, 3780, 3402, 0, 0, 0 });
                dt.Rows.Add(new object[] { 8, "ImageView 共通", 10773, 10206, 10206, 15876, 12348, 8379, 13482, 5103, 3969, 0, 0, 0 });
                dt.Rows.Add(new object[] { 9, "MaxGrid Windows Forms", 13608, 6804, 56700, 27216, 27216, 21924, 14742, 3780, 17010, 0, 0, 0 });
                dt.Rows.Add(new object[] { 10, "AnotherPak Windows Forms", 4158, 4158, 31185, 4158, 4158, 2079, 4158, 20790, 2079, 0, 0, 0 });
                dt.Rows.Add(new object[] { 11, "EXSheet Windows Forms", 32760, 118944, 159768, 28224, 77616, 57456, 138600, 59472, 79632, 0, 0, 0 });
                dt.Rows.Add(new object[] { 12, "EXSheet ASP", 28224, 82656, 32760, 101808, 31752, 33264, 84672, 36792, 54936, 0, 0, 0 });
                dt.Rows.Add(new object[] { 13, "AllInChart Windows Forms", 5103, 10490, 15309, 5387, 7938, 7938, 50747, 8222, 25799, 0, 0, 0 });
                dt.Rows.Add(new object[] { 14, "AllInChart ASP", 7655, 2552, 2552, 2835, 7655, 2552, 10490, 13325, 10206, 0, 0, 0 });

                // セル範囲データ連結用クラス
                using (FarPoint.Win.Spread.Data.SpreadDataBindingAdapter Sdba = new FarPoint.Win.Spread.Data.SpreadDataBindingAdapter())
                {
                    // 連結対象のデータテーブル
                    Sdba.DataSource = ds.Tables["fyeardata"];
                    // 連結対象のSPREADコントロール
                    Sdba.Spread = fpSpread1;
                    // 連結対象のシート
                    Sdba.SheetName = fpSpread1.ActiveSheet.SheetName;
                    // 行の自動生成なし
                    Sdba.AutoGenerateRow = false;
                    Sdba.DataAutoCellTypes = false;

                    // 連結対象範囲
                    Sdba.MapperInfo = new FarPoint.Win.Spread.Data.MapperInfo(_SPR_RDATA_START_ROW + 1, _SPR_RDATA_RH + 1, ds.Tables["fyeardata"].Rows.Count, ds.Tables["fyeardata"].Columns.Count);
                    // セル範囲に連結
                    Sdba.FillSpreadDataByDataSource();
                }
                ds.Tables["fyeardata"].EndLoadData();

                // 行番号
                for (int i = 0; i < ds.Tables["fyeardata"].Rows.Count; i++)
                {
                    fpSpread1.ActiveSheet.SetValue(_SPR_RDATA_START_ROW + i + 1, _SPR_RDATA_RH, i + 1);
                }

                // スライサーの機能を使用するためEnhancedShapeEngineプロパティを使用してシェイプエンジンを有効
                fpSpread1.Features.EnhancedShapeEngine = true;

                // 製品別売上実績
                // テーブルを作成
                GrapeCity.Spreadsheet.ITable tableProduct = fpSpread1.AsWorkbook().ActiveSheet.Tables.Add(_SPR_RDATA_START_ROW,
                                                                                                          _SPR_RDATA_RH,
                                                                                                          _SPR_RDATA_START_ROW + ds.Tables["fyeardata"].Rows.Count,
                                                                                                          _SPR_RDATA_RH + ds.Tables["fyeardata"].Columns.Count,
                                                                                                          GrapeCity.Spreadsheet.YesNoGuess.Yes);
                // フィルタのドロップダウンは非表示
                tableProduct.ShowAutoFilterDropDown = false;

                // 列インデックスを使用してSlicerCacheを追加
                GrapeCity.Spreadsheet.Slicers.ISlicerCache slicerCache = fpSpread1.AsWorkbook().SlicerCaches.Add(tableProduct, 2, "slicerCache");

                // SlicerCacheにスライサーを追加
                GrapeCity.Spreadsheet.Slicers.ISlicer slicer = slicerCache.Slicers.Add(fpSpread1.AsWorkbook().ActiveSheet, "slicer", "製品", 670, 25, 400, 300);

                // スライサーを動作させるためProtectを外す
                fpSpread1.ActiveSheet.Protect = false;

                // セル型設定
                CurrencyCellType prc = new CurrencyCellType();
                prc.DecimalPlaces = 0;          // 小数点以下桁数
                prc.MaximumValue = 999999999999;
                prc.ShowCurrencySymbol = false; // 通貨記号非表示
                prc.ShowSeparator = true;   //カンマ区切り
                fpSpread1.ActiveSheet.Cells[_SPR_RDATA_START_ROW + 1, _SPR_RDATA_m4, _SPR_RDATA_START_ROW + 1 + ds.Tables["fyeardata"].Rows.Count - 1, _SPR_RDATA_m3].CellType = prc;

                // ◆チャート関連
                //---------------------------------------------------------
                // 最終行の座標
                Rectangle rmaxrow = fpSpread1.GetCellRectangle(0, 0, _SPR_RDATA_START_ROW + 1 + ds.Tables["fyeardata"].Rows.Count, 0);

                // データ領域およスタイルを指定してチャートを設定
                FarPoint.Win.Spread.Model.CellRange range = new FarPoint.Win.Spread.Model.CellRange(_SPR_RDATA_START_ROW, _SPR_RDATA_product, ds.Tables["fyeardata"].Rows.Count + 1, ds.Tables["fyeardata"].Columns.Count - 1);
                fpSpread1.Sheets[0].AddChart(range, typeof(FarPoint.Win.Chart.LineSeries), _CHT_RDATA_WIDTH, _CHT_RDATA_HIGHT, 0, rmaxrow.Y + 20, FarPoint.Win.Chart.ChartViewType.View2D, true);
                FarPoint.Win.Spread.Chart.SpreadChart spreadChart = fpSpread1.Sheets[0].Charts[0];

                // 行・列入れ替え
                spreadChart.SwitchRowColumn();
                // プロットエリアの位置調整
                spreadChart.Model.PlotAreas[0].Location = new PointF(0.1f, 0.1f);
                // プロットエリアのサイズ調整
                // Modified on 2015/11/22
                //spreadChart.Model.PlotAreas[0].Size = new SizeF(0.6f, 0.8f);
                spreadChart.Model.PlotAreas[0].Size = new SizeF(0.55f, 0.8f);
                // Y軸ラベルのフォーマット設定
                FarPoint.Win.Chart.YPlotArea yp = (FarPoint.Win.Chart.YPlotArea)spreadChart.Model.PlotAreas[0];
                FarPoint.Win.Spread.Model.GeneralFormatter axisfmt = new FarPoint.Win.Spread.Model.GeneralFormatter("#,##0", false);
                yp.YAxes[0].LabelFormatter = axisfmt;

                // シリーズ設定
                FarPoint.Win.Chart.LineSeries ls;
                for (int i = 0; i < yp.Series.Count; i++)
                {
                    ls = (FarPoint.Win.Chart.LineSeries)yp.Series[i];
                    // マーカーなし
                    ls.PointMarker = new FarPoint.Win.Chart.NoMarker();
                }
                // 色
                spreadChart.Model.Fill = new FarPoint.Win.Chart.SolidFill(Color.Black);
                yp.BackWall.Fill = new FarPoint.Win.Chart.SolidFill(Color.Gray);
                yp.YAxes[0].LabelTextFill = new FarPoint.Win.Chart.SolidFill(Color.White);
                yp.YAxes[0].MajorGridLine = new FarPoint.Win.Chart.SolidLine(Color.White);
                yp.XAxis.LabelTextFill = new FarPoint.Win.Chart.SolidFill(Color.White);
                spreadChart.Model.LegendAreas[0].TextFill = new FarPoint.Win.Chart.SolidFill(Color.White);
                //---------------------------------------------------------

                // 罫線
                FarPoint.Win.ComplexBorderSide chbd = new FarPoint.Win.ComplexBorderSide(Color.Gray, 2);
                FarPoint.Win.Spread.Model.CellRange bcr = new FarPoint.Win.Spread.Model.CellRange(_SPR_RDATA_START_ROW, _SPR_RDATA_RH, ds.Tables["fyeardata"].Rows.Count + 1, ds.Tables["fyeardata"].Columns.Count + 1);
                FarPoint.Win.ComplexBorder cb1 = new FarPoint.Win.ComplexBorder(chbd, chbd, chbd, chbd);
                fpSpread1.ActiveSheet.SetOutlineBorder(bcr, cb1);
            }
            catch (Exception)
            {
                throw;
            }

        }
        #endregion

        private void RibbonBar1_CommandExecuting(object sender, ExecuteCommandEventArgs e)
        {
            if (e.CommandName == "RibbonItem1")
            {
                e.Handled = true;
                MessageBox.Show(String.Format("行インデックス：{0}\r\n列インデックス：{1}\r\n値：{2}", fpSpread1.AsWorkbook().ActiveSheet.ActiveCell.Row , fpSpread1.AsWorkbook().ActiveSheet.ActiveCell.Column, fpSpread1.AsWorkbook().ActiveSheet.ActiveCell.Value));
            }
        }
    }
}
