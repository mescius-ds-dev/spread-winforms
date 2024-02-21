using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.print
{
    public partial class PrintSettingForm : Form
    {
        private FarPoint.Win.Spread.FpSpread spread;

        public PrintSettingForm(FarPoint.Win.Spread.FpSpread ss)
        {
            InitializeComponent();

            // SPREADの取得
            spread = ss;

            // コントロールの初期化
            InitializeControls();

            cmbHeader.SelectedIndexChanged += new EventHandler(cmbHeader_SelectedIndexChanged);
            cmbFooter.SelectedIndexChanged += new EventHandler(cmbFooter_SelectedIndexChanged);
            btnPrint.Click += new EventHandler(btnPrint_Click);
            btnPreview.Click += new EventHandler(btnPreview_Click);
        }

        private void InitializeControls()
        {
            // デフォルトプリンタの用紙サイズの取得
            DataTable dtPaperSize = new DataTable("PaperSize");
            dtPaperSize.Columns.Add("RawKind", typeof(int));
            dtPaperSize.Columns.Add("Name", typeof(string));
            dtPaperSize.Columns.Add("PaperSize", typeof(System.Drawing.Printing.PaperSize));
            dtPaperSize.PrimaryKey = new DataColumn[] { dtPaperSize.Columns["RawKind"] };
            System.Drawing.Printing.PrinterSettings ps = new System.Drawing.Printing.PrinterSettings();
            foreach (System.Drawing.Printing.PaperSize p in ps.PaperSizes)
            {
                dtPaperSize.Rows.Add(new Object[] { p.RawKind, p.PaperName, p });
            }
            cmbPaperSize.DataSource = dtPaperSize;
            cmbPaperSize.DisplayMember = "Name";
            cmbPaperSize.ValueMember = "PaperSize";
            cmbPaperSize.SelectedIndex = 0;
            try
            {
                cmbPaperSize.SelectedValue = dtPaperSize.Rows.Find(System.Drawing.Printing.PaperKind.A4)["PaperSize"] as System.Drawing.Printing.PaperSize;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // ヘッダ／フッタ用文字列の作成
            DataTable dtHeader = new DataTable("HeaderFooter");
            dtHeader.Columns.Add("Name", typeof(string));
            dtHeader.Columns.Add("Command", typeof(string));
            dtHeader.Rows.Add("未設定", "");
            dtHeader.Rows.Add("ページ番号", "/c(/p///pc)");
            dtHeader.Rows.Add("日付", "/r/dl");
            dtHeader.Rows.Add("カラー文字", "/l/cl\"0\"カラー/cl\"1\"文字");
            dtHeader.Rows.Add("画像", "/c/g\"0\"");
            dtHeader.AcceptChanges();
            cmbHeader.DataSource = dtHeader;
            cmbHeader.DisplayMember = "Name";
            cmbHeader.ValueMember = "Command";
            cmbFooter.DataSource = dtHeader.Copy();
            cmbFooter.DisplayMember = "Name";
            cmbFooter.ValueMember = "Command";

            // セルノート設定用コンボボックスの設定
            cmbCellNote.Items.AddRange(new string[] { "(なし)", "シートの末尾", "画面表示イメージ" });
            cmbCellNote.SelectedIndex = 0;

            // PrintInfoの初期化
            FarPoint.Win.Spread.PrintInfo pInfo = new FarPoint.Win.Spread.PrintInfo();
            pInfo.Colors = new Color[] { Color.Blue, Color.Red };
            Image image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.science.gif"));
            pInfo.Images = new Image[] { image };
            spread.Sheets[0].PrintInfo = pInfo;
        }

        private void SetPrintSettings()
        {
            FarPoint.Win.Spread.PrintInfo pInfo = spread.Sheets[0].PrintInfo;

            // ページ：印刷の向き
            if (rdoAuto.Checked)
            {
                pInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Auto;
            }
            else if (rdoDirectionV.Checked)
            {
                pInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Portrait;
            }
            else if (rdoDirectionH.Checked)
            {
                pInfo.Orientation = FarPoint.Win.Spread.PrintOrientation.Landscape;
            }

            // ページ：拡大縮小印刷
            if (rdoZoom.Checked)
            {
                pInfo.ZoomFactor = (float)numZoom.Value / 100;
                pInfo.UseSmartPrint = false;
            }
            else if (rdoByPage.Checked)
            {
                pInfo.ZoomFactor = 1f;
                pInfo.SmartPrintPagesTall = (int)numByPageV.Value;
                pInfo.SmartPrintPagesWide = (int)numByPageH.Value;
                pInfo.UseSmartPrint = true;
            }

            // ページ：用紙サイズ
            pInfo.PaperSize = cmbPaperSize.SelectedValue as System.Drawing.Printing.PaperSize;

            // ページ：先頭ページ番号
            pInfo.FirstPageNumber = (int)numFirstPage.Value;

            // 余白：余白
            pInfo.Margin.Left = (int)numMerginLeft.Value;
            pInfo.Margin.Right = (int)numMerginRight.Value;
            pInfo.Margin.Top = (int)numMerginTop.Value;
            pInfo.Margin.Bottom = (int)numMerginBottom.Value;

            // 余白：高さ
            pInfo.HeaderHeight = (int)numHeaderHeight.Value;
            pInfo.FooterHeight = (int)numFooterHeight.Value;

            // 余白：ページ中央
            if (ckbCenterH.Checked)
            {
                if (ckbCenterV.Checked)
                {
                    pInfo.Centering = FarPoint.Win.Spread.Centering.Both;
                }
                else
                {
                    pInfo.Centering = FarPoint.Win.Spread.Centering.Horizontal;
                }
            }
            else
            {
                if (ckbCenterV.Checked)
                {
                    pInfo.Centering = FarPoint.Win.Spread.Centering.Vertical;
                }
                else
                {
                    pInfo.Centering = FarPoint.Win.Spread.Centering.None;
                }
            }

            // ヘッダ／フッタ：ヘッダ
            pInfo.Header = txtHeader.Text;

            // ヘッダ／フッタ：フッタ
            pInfo.Footer = txtFooter.Text;

            // シート：印刷範囲
            if (numRangeTopRow.Value > -1 || numRangeBottomRow.Value > -1 || numRangeLeftCol.Value > -1 || numRangeRightCol.Value > -1)
            {
                pInfo.PrintType = FarPoint.Win.Spread.PrintType.CellRange;
                pInfo.RowStart = (int)numRangeTopRow.Value;
                pInfo.RowEnd = (int)numRangeBottomRow.Value;
                pInfo.ColStart = (int)numRangeLeftCol.Value;
                pInfo.ColEnd = (int)numRangeRightCol.Value;
            }
            else
            {
                pInfo.PrintType = FarPoint.Win.Spread.PrintType.All;
            }

            // シート：印刷タイトル
            pInfo.RepeatRowStart = (int)numRepeatTopRow.Value;
            pInfo.RepeatRowEnd = (int)numRepeatBottomRow.Value;
            pInfo.RepeatColStart = (int)numRepeatLeftCol.Value;
            pInfo.RepeatColEnd = (int)numRepeatRightCol.Value;

            // シート：印刷.枠線
            pInfo.ShowBorder = ckbBorder.Checked;

            // シート：印刷.グリッド線
            pInfo.ShowGrid = ckbGrid.Checked;

            // シート：印刷.行ヘッダ
            if (ckbRowHeader.Checked)
            {
                pInfo.ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Show;
            }
            else
            {
                pInfo.ShowRowHeader = FarPoint.Win.Spread.PrintHeader.Hide;
            }

            // シート：印刷.列ヘッダ
            if (ckbColHeader.Checked)
            {
                pInfo.ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Show;
            }
            else
            {
                pInfo.ShowColumnHeader = FarPoint.Win.Spread.PrintHeader.Hide;
            }

            // シート：印刷.ページの方向
            if (rdoPageOrderAuto.Checked)
            {
                pInfo.PageOrder = FarPoint.Win.Spread.PrintPageOrder.Auto;
            }
            else if (rdoPageOrderLeftRight.Checked)
            {
                pInfo.PageOrder = FarPoint.Win.Spread.PrintPageOrder.OverThenDown;
            }
            else if (rdoPageOrderTopBottom.Checked)
            {
                pInfo.PageOrder = FarPoint.Win.Spread.PrintPageOrder.DownThenOver;
            }

            // シート：印刷.セルノート
            if (cmbCellNote.SelectedIndex == 0)
            {
                // (なし)
                pInfo.PrintNotes = FarPoint.Win.Spread.PrintNotes.None;
            }
            else if (cmbCellNote.SelectedIndex == 1)
            {
                // シートの末尾
                pInfo.PrintNotes = FarPoint.Win.Spread.PrintNotes.AtEnd;
            }
            else if (cmbCellNote.SelectedIndex == 2)
            {
                // 画面表示イメージ：NoteStyleがStickyNoteの場合にのみ有効
                spread.Sheets[0].Cells[1, 1].NoteStyle = FarPoint.Win.Spread.NoteStyle.StickyNote;
                pInfo.PrintNotes = FarPoint.Win.Spread.PrintNotes.AsDisplayed;
            }
        }

        void cmbHeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ヘッダ文字列の設定
            if ((sender as ComboBox).SelectedValue is string)
            {
                txtHeader.Text = (string)(sender as ComboBox).SelectedValue;
            }

            // ヘッダ高さの設定
            if (!string.IsNullOrEmpty(txtHeader.Text))
            {
                numHeaderHeight.Value = 30;
            }
            else
            {
                numHeaderHeight.Value = 0;
            }
        }

        void cmbFooter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // フッタ文字列の設定
            if ((sender as ComboBox).SelectedValue is string)
            {
                txtFooter.Text = (string)(sender as ComboBox).SelectedValue;
            }

            // ヘッダ高さの設定
            if (!string.IsNullOrEmpty(txtFooter.Text))
            {
                numFooterHeight.Value = 30;
            }
            else
            {
                numFooterHeight.Value = 0;
            }
        }

        void btnPrint_Click(object sender, EventArgs e)
        {
            // 印刷の設定
            this.SetPrintSettings();

            // 印刷の実行
            spread.Sheets[0].PrintInfo.Preview = false;
            spread.PrintSheet(0, false);            

            // シートのセルノート設定の初期化
            spread.Sheets[0].Cells[1, 1].NoteStyle = FarPoint.Win.Spread.NoteStyle.PopupNote;

            // ダイアログの終了
            this.Close();
        }

        void btnPreview_Click(object sender, EventArgs e)
        {
            // 印刷の設定
            this.SetPrintSettings();

            // 印刷プレビュー画面の表示
            spread.Sheets[0].PrintInfo.Preview = true;
            spread.PrintSheet(spread.Sheets[0]);

            // シートのセルノート設定の初期化
            spread.Sheets[0].Cells[1, 1].NoteStyle = FarPoint.Win.Spread.NoteStyle.PopupNote;
        }
    }
}
