using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.shape
{
    public partial class camerashape : SpreadWinDemo.DemoBase
    {
        public camerashape()
        {
            InitializeComponent();

            // SPREADの設定
            InitSpread(fpSpread1);

            // シートの設定            
            createHeader2(fpSpread1.Sheets[1]);
            createDetail(fpSpread1.Sheets[2]);
            createStamp(fpSpread1.Sheets[3]);
            createHeader1(fpSpread1.Sheets[4]);
            InitSheet(fpSpread1.Sheets[0]);
        }

        private const string SHT_MAIN_NM = "Main";
        private const string SHT_HD1_NM = "Head1";
        private const string SHT_HD2_NM = "Head2";
        private const string SHT_DT_NM = "Detail";
        private const string SHT_ST_NM = "Stamp";

        private void InitSpread(FarPoint.Win.Spread.FpSpread spread)
        {
            spread.Sheets.Count = 5;

            spread.Sheets[0].SheetName = "Main";
            spread.Sheets[1].SheetName = "Head2";
            spread.Sheets[2].SheetName = "Detail";
            spread.Sheets[3].SheetName = "Stamp";
            spread.Sheets[4].SheetName = "Head1";
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.RowHeader.Visible = false;
            sheet.ColumnHeader.Visible = false;

            sheet.ColumnCount = 1;
            sheet.Columns[0].Width = fpSpread1.Width;

            sheet.SetValue(0, 0, "御 見 積 書");
            sheet.Cells[0, 0].Font = new Font("メイリオ", 14.0f, FontStyle.Bold);
            sheet.Cells[0, 0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            sheet.Rows[0].Height = 100;

            sheet.HorizontalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);
            sheet.VerticalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);

            // 各シートの情報をカメラシェイプでメインシートに追加
            FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape head1 = new FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape();
            head1.Formula = SHT_HD1_NM + "!A1:B" + fpSpread1.Sheets[SHT_HD1_NM].RowCount;
            head1.Location = new System.Drawing.Point(10, 50);
            head1.ShapeOutlineThickness = 0;
            sheet.AddShape(head1);

            FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape head2 = new FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape();
            head2.Formula = SHT_HD2_NM + "!A1:B" + fpSpread1.Sheets[SHT_HD2_NM].RowCount;
            head2.Location = new System.Drawing.Point(10, 180);
            head2.ShapeOutlineThickness = 0;
            sheet.AddShape(head2);

            FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape detail = new FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape();
            detail.Formula = SHT_DT_NM + "!A1:G" + fpSpread1.Sheets[SHT_DT_NM].RowCount;
            detail.Location = new System.Drawing.Point(10, 280);
            detail.ShapeOutlineThickness = 0;
            sheet.AddShape(detail);

            FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape stamp = new FarPoint.Win.Spread.DrawingSpace.SpreadCameraShape();
            stamp.Formula = SHT_ST_NM + "!A1:C" + fpSpread1.Sheets[SHT_ST_NM].RowCount;
            stamp.Location = new System.Drawing.Point(370, 50);
            stamp.ShapeOutlineThickness = 0;
            sheet.AddShape(stamp);
        }

        private void createHeader1(FarPoint.Win.Spread.SheetView sheet)
        {
            Font font = new Font("メイリオ", 9.0f);
            sheet.DefaultStyle.Font = font;

            sheet.VerticalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);
            sheet.HorizontalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);

            sheet.RowCount = 4;
            sheet.ColumnCount = 2;

            sheet.Columns[0].Width = 240;
            sheet.Columns[1].Width = 90;

            System.DateTime sysdt = DateTime.Now;
            System.Globalization.CultureInfo japaneseCulture = new System.Globalization.CultureInfo("ja-JP", false);
            japaneseCulture.DateTimeFormat.Calendar = new System.Globalization.JapaneseCalendar();

            sheet.Cells[0, 0].Value = "紫山株式会社様";
            sheet.Cells[0, 0].Font = new Font("メイリオ", 14.0f, FontStyle.Bold | FontStyle.Underline);

            sheet.Cells[1, 0].Value = sysdt.ToString("ggyy年M月d日", japaneseCulture);
            sheet.Cells[2, 0].Value = "下記の通りお見積申し上げます。";
            sheet.Cells[3, 0].Value = "御見積金額";
            sheet.Cells[3, 1].Formula = "SUM(" + SHT_DT_NM + "!A1:G" + fpSpread1.Sheets[SHT_DT_NM].RowCount.ToString() + ")";

            sheet.Rows[3].Font = new Font("メイリオ", 9.0f, FontStyle.Bold);

            sheet.Rows[3].Border = new FarPoint.Win.DoubleLineBorder(Color.Black, false, false, false, true);

            FarPoint.Win.Spread.CellType.CurrencyCellType cur = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            cur.DecimalPlaces = 0;
            cur.FixedPoint = false;
            cur.ShowCurrencySymbol = true;
            cur.ShowSeparator = true;
            sheet.Cells[3, 1].CellType = cur;

            sheet.Rows[0].Height = 40;
            sheet.Rows[1].Height = 20;
            sheet.Rows[2].Height = 20;
            sheet.Rows[3].Height = 25;
        }

        private void createHeader2(FarPoint.Win.Spread.SheetView sheet)
        {
            Font font = new Font("メイリオ", 9.0f);
            sheet.DefaultStyle.Font = font;

            sheet.VerticalGridLine = new FarPoint.Win.Spread.GridLine(FarPoint.Win.Spread.GridLineType.None);

            sheet.RowCount = 4;
            sheet.ColumnCount = 2;

            sheet.Columns[0].Width = 120;
            sheet.Columns[1].Width = 190;

            sheet.Cells[0, 0].Value = "支払条件：";
            sheet.Cells[1, 0].Value = "受渡期限：";
            sheet.Cells[2, 0].Value = "見積有効期限：";
            sheet.Cells[3, 0].Value = "受渡場所：";

            sheet.Cells[0, 1].Value = "当月末締め翌月末払い";
            sheet.Cells[1, 1].Value = "受注後約1週間";
            sheet.Cells[2, 1].Value = "見積提出日より1ヶ月";
            sheet.Cells[3, 1].Value = "貴社指定場所";
        }

        private void createDetail(FarPoint.Win.Spread.SheetView sheet)
        {
            Font font = new Font("メイリオ", 9.0f);
            sheet.DefaultStyle.Font = font;
            sheet.Rows.Default.Height = 30;
            sheet.Rows.Default.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom;

            DataSet ds = CreateDataSource();
            sheet.DataSource = ds.Tables[0];

            // ヘッダ用の行追加
            sheet.AddUnboundRows(0, 1);

            sheet.Columns[0].Width = 25;
            sheet.Columns[1].Width = 60;
            sheet.Columns[2].Width = 200;
            sheet.Columns[3].Width = 90;
            sheet.Columns[4].Width = 70;
            sheet.Columns[5].Width = 50;
            sheet.Columns[6].Width = 80;

            FarPoint.Win.Spread.CellType.CurrencyCellType cur = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            cur.DecimalPlaces = 0;
            cur.FixedPoint = false;
            cur.ShowSeparator = true;
            cur.ShowCurrencySymbol = false;
            sheet.Columns[4].CellType = cur;
            sheet.Columns[6].CellType = cur;

            FarPoint.Win.Spread.CellType.GeneralCellType gur = new FarPoint.Win.Spread.CellType.GeneralCellType();
            sheet.Rows[0].CellType = gur;

            // ヘッダ作成
            for (int index = 0; index <= ds.Tables[0].Columns.Count - 1; index++)
            {
                sheet.SetValue(0, index, sheet.ColumnHeader.Columns[index].Label);
            }

            sheet.Rows[0].BackColor = Color.AliceBlue;
            sheet.Rows[0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
        }

        private void createStamp(FarPoint.Win.Spread.SheetView sheet)
        {
            Font font = new Font("メイリオ", 9.0f);
            sheet.DefaultStyle.Font = font;

            sheet.RowCount = 2;
            sheet.ColumnCount = 3;

            sheet.Columns[0, 2].Width = 70;
            sheet.Cells[0, 0].Value = "経理";
            sheet.Cells[0, 1].Value = "担当長";
            sheet.Cells[0, 2].Value = "担当";

            sheet.Rows[1].Height = 60;
            sheet.Rows[0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;

            FarPoint.Win.ComplexBorderSide bds = new FarPoint.Win.ComplexBorderSide(FarPoint.Win.ComplexBorderSideStyle.ThinLine, Color.Black);
            FarPoint.Win.ComplexBorder bd = new FarPoint.Win.ComplexBorder(bds, bds, bds, bds);
            sheet.Cells[0, 0].Border = new FarPoint.Win.ComplexBorder(bds, bds, bds, bds);
            sheet.Cells[0, 1].Border = new FarPoint.Win.ComplexBorder(null, bds, bds, bds);
            sheet.Cells[0, 2].Border = new FarPoint.Win.ComplexBorder(null, bds, bds, bds);
            sheet.Cells[1, 0].Border = new FarPoint.Win.ComplexBorder(bds, null, bds, bds);
            sheet.Cells[1, 1].Border = new FarPoint.Win.ComplexBorder(null, null, bds, bds);
            sheet.Cells[1, 2].Border = new FarPoint.Win.ComplexBorder(null, null, bds, bds);

        }
        // テストデータの作成
        public DataSet CreateDataSource()
        {
            DataSet ds = new DataSet();
            DataTable dt = null;
            DataRow dr = null;

            dt = new DataTable();
            dt.Columns.Add(new DataColumn("No", typeof(int)));
            dt.Columns.Add(new DataColumn("製品No", typeof(string)));
            dt.Columns.Add(new DataColumn("品名", typeof(string)));
            dt.Columns.Add(new DataColumn("詳細", typeof(string)));
            dt.Columns.Add(new DataColumn("単価", typeof(decimal)));
            dt.Columns.Add(new DataColumn("数量", typeof(int)));
            dt.Columns.Add(new DataColumn("金額", typeof(decimal)));

            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "10002";
            dr[2] = "スキャナ GC-SCAN";
            dr[3] = "GC-9600T";
            dr[4] = 18900;
            dr[5] = 5;
            dr[6] = 94500;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 2;
            dr[1] = "10003";
            dr[2] = "スキャナ GC-SCAN-P";
            dr[3] = "GC-8600T";
            dr[4] = 12900;
            dr[5] = 1;
            dr[6] = 12900;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 3;
            dr[1] = "20013";
            dr[2] = "プリンタ GC-AR-P";
            dr[3] = "GC-Y.WK";
            dr[4] = 34800;
            dr[5] = 1;
            dr[6] = 34800;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 4;
            dr[1] = "50001";
            dr[2] = "デジタルカメラ GC-LD";
            dr[3] = "GC-K.UJ";
            dr[4] = 24800;
            dr[5] = 1;
            dr[6] = 24800;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = 5;
            dr[1] = "11001";
            dr[2] = "パソコン GC-SP";
            dr[3] = "GC-Y.NG";
            dr[4] = 189000;
            dr[5] = 2;
            dr[6] = 378000;
            dt.Rows.Add(dr);
            ds.Tables.Add(dt);

            return ds;
        }
    }
}
