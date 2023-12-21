using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.celltype
{
    public partial class basiccelltype : SpreadWinDemo.DemoBase
    {
        public basiccelltype()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            fpSpread1.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(fpSpread1_EditChange);
            fpSpread1.EditModeOn += new EventHandler(fpSpread1_EditModeOn);
        }        

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // シート設定
            sheet.RowCount = 11;
            sheet.ColumnCount = 4;
            sheet.Columns[0].BackColor = System.Drawing.SystemColors.Control;
            sheet.Columns[2].BackColor = System.Drawing.SystemColors.Control;

            // 列幅の設定
            sheet.Columns[0].Width = 100;
            sheet.Columns[1].Width = 140;
            sheet.Columns[2].Width = 180;
            sheet.Columns[3].Width = 200;

            // 行の高さの設定
            sheet.Rows.Default.Height = 24;
            sheet.Rows[5].Height = 60;
            sheet.Rows[10].Height = 60;

            // プロテクトとロック（DefaultStyle）の設定
            sheet.Protect = true;
            sheet.DefaultStyle.Locked = false;
            sheet.RowHeader.DefaultStyle.Locked = false;
            sheet.ColumnHeader.DefaultStyle.Locked = false;

            // 1列目のセルをロックしてユーザの編集を禁止
            sheet.Columns[0].Locked = true;

            // セル型の設定
            sheet.Cells[0, 0].Value = "通貨";
            sheet.Cells[0, 1].Value = 12345;

            sheet.Cells[1, 0].Value = "日付時刻";
            sheet.Cells[1, 1].Value = DateTime.Now.ToOADate();

            sheet.Cells[2, 0].Value = "標準";
            sheet.Cells[2, 1].Value = 12345;

            sheet.Cells[3, 0].Value = "マスク";
            sheet.Cells[3, 1].Value = "123-45-6789";

            sheet.Cells[4, 0].Value = "数値";
            sheet.Cells[4, 1].Value = 123.45;

            sheet.Cells[5, 0].Value = "パーセント";
            sheet.Cells[5, 1].Value = 0.65;

            sheet.Cells[6, 0].Value = "正規表現";
            sheet.Cells[6, 1].Value = "123-4567-8901";

            sheet.Cells[7, 0].Value = "テキスト";
            sheet.Cells[7, 1].Value = "テキスト";

            // 通貨型セルの設定
            FarPoint.Win.Spread.CellType.CurrencyCellType currcell = new FarPoint.Win.Spread.CellType.CurrencyCellType();
            sheet.Cells[0, 1].CellType = currcell;

            // 日付時刻型セルの設定
            FarPoint.Win.Spread.CellType.DateTimeCellType datecell = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            sheet.Cells[1, 1].CellType = datecell;

            // 標準型セルの設定
            FarPoint.Win.Spread.CellType.GeneralCellType gnrlcell = new FarPoint.Win.Spread.CellType.GeneralCellType();
            sheet.Cells[2, 1].CellType = gnrlcell;

            // マスク型セルの設定
            FarPoint.Win.Spread.CellType.MaskCellType maskcell = new FarPoint.Win.Spread.CellType.MaskCellType();
            maskcell.Mask = "###-##-####";
            maskcell.MaskChar = Convert.ToChar("_");
            sheet.Cells[3, 1].CellType = maskcell;

            // 数値型セルの設定
            FarPoint.Win.Spread.CellType.NumberCellType nmbrcell = new FarPoint.Win.Spread.CellType.NumberCellType();
            nmbrcell.DecimalPlaces = 2;
            nmbrcell.SpinButton = true;
            sheet.Cells[4, 1].CellType = nmbrcell;

            // パーセント型セルの設定
            FarPoint.Win.Spread.CellType.PercentCellType prctcell = new FarPoint.Win.Spread.CellType.PercentCellType();
            sheet.Cells[5, 1].CellType = prctcell;

            // 正規表現型セルの設定
            FarPoint.Win.Spread.CellType.RegularExpressionCellType regexcell = new FarPoint.Win.Spread.CellType.RegularExpressionCellType();
            regexcell.RegularExpression = "[0-9]{3}-[0-9]{4}-[0-9]{4}";
            sheet.Cells[6, 1].CellType = regexcell;

            // テキスト型セルの設定
            FarPoint.Win.Spread.CellType.TextCellType tcell = new FarPoint.Win.Spread.CellType.TextCellType();
            tcell.Multiline = true;
            sheet.Cells[7, 1].CellType = tcell;

            // 3列目のセルをロックしてユーザの編集を禁止
            sheet.Columns[2].Locked = true;

            // セル型の設定
            sheet.Cells[0, 2].Text = "コマンドボタン";

            sheet.Cells[1, 2].Text = "チェックボックス";
            sheet.Cells[1, 3].Value = true;

            sheet.Cells[2, 2].Text = "コンボボックス";

            sheet.Cells[3, 2].Text = "ハイパーリンク";

            sheet.Cells[4, 2].Text = "イメージ";

            sheet.Cells[5, 2].Text = "リストボックス";

            sheet.Cells[6, 2].Text = "マルチカラムコンボボックス";

            sheet.Cells[7, 2].Text = "マルチオプション";

            sheet.Cells[8, 2].Text = "プログレス";
            sheet.Cells[8, 3].Value = 44;

            sheet.Cells[9, 2].Text = "スライダー";
            sheet.Cells[9, 3].Value = 44;

            sheet.Cells[10, 2].Text = "リッチテキスト";            

            // コマンドボタン型セルの設定
            FarPoint.Win.Spread.CellType.ButtonCellType bttncell = new FarPoint.Win.Spread.CellType.ButtonCellType();            
            bttncell.Text = "コマンドボタン";
            sheet.Cells[0, 3].CellType = bttncell;

            // チェックボックス型セルの設定
            FarPoint.Win.Spread.CellType.CheckBoxCellType ckbxcell = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            ckbxcell.TextTrue ="チェック";
            ckbxcell.TextFalse ="未チェック";
            sheet.Cells[1, 3].CellType = ckbxcell;

            // コンボボックス型セルの設定
            FarPoint.Win.Spread.CellType.ComboBoxCellType cmbocell = new FarPoint.Win.Spread.CellType.ComboBoxCellType();            
            ImageList iList = new ImageList();
            iList.Images.Add(Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.history.gif")));
            iList.Images.Add(Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.music.gif")));
            iList.Images.Add(Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.science.gif")));
            FarPoint.Win.Spread.CellType.ComboBoxCellType c = new FarPoint.Win.Spread.CellType.ComboBoxCellType();
            cmbocell.Items = new String[] { "歴史", "音楽", "科学" };
            cmbocell.ImageList = iList;
            sheet.Cells[2, 3].CellType = cmbocell;

            // ハイパーリンク型セルの設定
            FarPoint.Win.Spread.CellType.HyperLinkCellType hlnkcell = new FarPoint.Win.Spread.CellType.HyperLinkCellType();
            hlnkcell.Text = "MESCIUS Webサイトはこちら";
            hlnkcell.Link = "https://developer.mescius.jp/";
            hlnkcell.LinkArea = new LinkArea(15, 3);
            sheet.Cells[3, 3].CellType = hlnkcell;

            // イメージ型セルの設定
            FarPoint.Win.Spread.CellType.ImageCellType imgct = new FarPoint.Win.Spread.CellType.ImageCellType();
            System.Drawing.Image image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.science.gif"));
            sheet.Cells[4, 3].CellType = imgct;
            sheet.Cells[4, 3].Value = image;

            // リストボックス型セルの設定
            FarPoint.Win.Spread.CellType.ListBoxCellType listcell = new FarPoint.Win.Spread.CellType.ListBoxCellType();
            listcell.Items = new string[] { "赤色", "緑色", "青色" };
            sheet.Cells[5, 3].CellType = listcell;

            // マルチカラムコンボボックス型セルの設定
            DataSet ds = new DataSet();
            ds.ReadXml(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".SampleData.data.xml"));            
            FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType mcb = new FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType();
            mcb.DataSourceList = ds;
            mcb.ColumnEditName = "氏名";
            mcb.DataColumnName = "ID";
            mcb.ListResizeColumns = FarPoint.Win.Spread.CellType.ListResizeColumns.FitWidestItem;
            mcb.ListWidth = 400;
            mcb.ListAlignment = FarPoint.Win.ListAlignment.Right;
            sheet.Cells[6, 3].CellType = mcb;

            // マルチオプション型セルの設定
            FarPoint.Win.Spread.CellType.MultiOptionCellType multcell = new FarPoint.Win.Spread.CellType.MultiOptionCellType();
            multcell.Items = new String[] { "赤色", "緑色", "青色" };
            multcell.Orientation = FarPoint.Win.RadioOrientation.Horizontal;
            sheet.Cells[7, 3].CellType = multcell;

            // プログレス型セルの設定
            FarPoint.Win.Spread.CellType.ProgressCellType progcell = new FarPoint.Win.Spread.CellType.ProgressCellType();
            sheet.Cells[8, 3].CellType = progcell;

            // スライダー型セルの設定
            FarPoint.Win.Spread.CellType.SliderCellType slider = new FarPoint.Win.Spread.CellType.SliderCellType();
            slider.TrackColor = Color.Red;
            slider.Minimum = 5;
            slider.Maximum = 95;
            slider.TickSpacing = 3;
            slider.KnobColor = Color.FromArgb(57, 0, 0, 255);
            sheet.Cells[9, 3].CellType = slider;

            // リッチテキスト型セルの設定
            FarPoint.Win.Spread.CellType.RichTextCellType rtfType = new FarPoint.Win.Spread.CellType.RichTextCellType();
            rtfType.Multiline = true;
            sheet.Cells[10, 3].CellType = rtfType;
            // リッチテキスト文字列の作成
            String rtfText = null;
            using (RichTextBox temp = new RichTextBox())
            {
                temp.Text = "ABC" + "\r\n" + "DEF" + "\r\n" + "GHI";
                temp.SelectionStart = 0;
                temp.SelectionLength = 3;
                temp.SelectionColor = Color.Red;
                temp.SelectionFont = new Font("MS UI Gothic", 9);
                temp.SelectionStart = 4;
                temp.SelectionLength = 3;
                temp.SelectionColor = Color.Blue;
                temp.SelectionFont = new Font("MS UI Gothic", 12);
                temp.SelectionStart = 8;
                temp.SelectionLength = 3;
                temp.SelectionColor = Color.Green;
                temp.SelectionFont = new Font("MS UI Gothic", 15);
                temp.SelectionStart = 0;
                temp.SelectionLength = 12;
                temp.SelectionAlignment = HorizontalAlignment.Center;
                rtfText = temp.Rtf;
            }
            sheet.Cells[10, 3].Value = rtfText;
        }

        void fpSpread1_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            // スライダ型セルのデータをプログレス型セルに反映
            if (e.Row == 9 & e.Column == 3)
            {
                fpSpread1.ActiveSheet.Cells[8, 3].Value = fpSpread1.ActiveSheet.Cells[9, 3].Value;
            }
        }

        void fpSpread1_EditModeOn(object sender, EventArgs e)
        {
            // アクティブセルのセル型を判断
            int row = fpSpread1.ActiveSheet.ActiveRowIndex;
            int col = fpSpread1.ActiveSheet.ActiveColumnIndex;
            if (fpSpread1.ActiveSheet.GetCellType(row, col) is FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType)
            {
                // ドロップダウンリストのオブジェクトの取得
                FarPoint.Win.Spread.FpSpread cmbSpread = (FarPoint.Win.Spread.FpSpread)((FarPoint.Win.Spread.CellType.GeneralEditor)fpSpread1.EditingControl).SubEditor;
                
                // 列幅の設定
                cmbSpread.ActiveSheet.Columns[4].Width = 50;
                cmbSpread.ActiveSheet.Columns[5].Width = 50;
            }
        }        
    }
}
