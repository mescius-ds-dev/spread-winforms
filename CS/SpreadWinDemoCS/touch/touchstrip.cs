using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.touch
{
    public partial class touchstrip : SpreadWinDemo.DemoBase
    {
        public touchstrip()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            fpSpread1.TouchStripOpening += new EventHandler<FarPoint.Win.Spread.TouchStripOpeningEventArgs>(fpSpread1_TouchStripOpening);
        }

        private FarPoint.Win.Spread.CellTouchStrip touchStripwithoutcut;
        private FarPoint.Win.Spread.CellTouchStrip touchStripwithdropdownmenu;

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
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

            // 切り取りを表示しないタッチツールバー
            touchStripwithoutcut = new FarPoint.Win.Spread.CellTouchStrip(this.fpSpread1);
            touchStripwithoutcut.Items["Cut"].Visible = false;

            // ドロップダウンメニューを追加したタッチツールバー
            touchStripwithdropdownmenu = new FarPoint.Win.Spread.CellTouchStrip(this.fpSpread1);
            touchStripwithdropdownmenu.Items["Cut"].Visible = false;

            ToolStripSeparator separator1 = new ToolStripSeparator();

            System.IO.Stream s1 = this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.AutoFill.png");
            FarPoint.Win.Spread.TouchStripButton autoFill = new FarPoint.Win.Spread.TouchStripButton("オートフィル", System.Drawing.Image.FromStream(s1));
            autoFill.Click += autoFill_Click;

            ToolStripSeparator separator2 = new ToolStripSeparator();

            System.IO.Stream s2 = this.GetType().Assembly.GetManifestResourceStream(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".images.TouchMenuItemDownArrow.png");
            ToolStripDropDownButton dropDownMenu = new ToolStripDropDownButton(System.Drawing.Image.FromStream(s2));
            dropDownMenu.ShowDropDownArrow = false;
            dropDownMenu.ImageScaling = ToolStripItemImageScaling.None;
            ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
            ToolStripMenuItem newcontitem1 = new ToolStripMenuItem();
            newcontitem1.Text = "コピー";
            newcontitem1.Click += newcontitem1_Click;
            newcontitem1.AutoSize = false;
            newcontitem1.Height = 30;
            newcontitem1.Width = 100;
            newcontitem1.TextAlign = ContentAlignment.MiddleLeft;
            menu.Items.Add(newcontitem1);
            ToolStripMenuItem newcontitem2 = new ToolStripMenuItem();
            newcontitem2.Text = "貼り付け";
            newcontitem2.Click += newcontitem2_Click;
            newcontitem2.AutoSize = false;
            newcontitem2.Height = 30;
            newcontitem2.Width = 100;
            newcontitem2.TextAlign = ContentAlignment.MiddleLeft;
            menu.Items.Add(newcontitem2);
            ToolStripMenuItem newcontitem3 = new ToolStripMenuItem();
            newcontitem3.Text = "クリア";
            newcontitem3.Click += newcontitem3_Click;
            newcontitem3.AutoSize = false;
            newcontitem3.Height = 30;
            newcontitem3.Width = 100;
            newcontitem3.TextAlign = ContentAlignment.MiddleLeft;
            menu.Items.Add(newcontitem3);
            dropDownMenu.DropDown = menu;

            touchStripwithdropdownmenu.Items.AddRange(new ToolStripItem[] { separator1, autoFill, separator2, dropDownMenu });

            // オートフィルを有効化 
            fpSpread1.AllowDragFill = true;
        }

        void fpSpread1_TouchStripOpening(object sender, FarPoint.Win.Spread.TouchStripOpeningEventArgs e)
        {
            if (radioButton1.Checked)
            {
                // デフォルトのタッチツールバーを表示しない
                e.Cancel = true;
            }
            else if (radioButton3.Checked)
            {
                // デフォルトのタッチツールバーを表示しない
                e.Cancel = true;

                // カスタマイズしたタッチツールバーを表示
                touchStripwithoutcut.Show(new Point(e.X - 20, e.Y - 35 - touchStripwithoutcut.Height));
            }
            else if (radioButton4.Checked)
            {
                // デフォルトのタッチツールバーを表示しない
                e.Cancel = true;

                // カスタマイズしたタッチツールバーを表示
                touchStripwithdropdownmenu.Show(new Point(e.X - 20, e.Y - 35 - touchStripwithdropdownmenu.Height));
            }
        }

        void autoFill_Click(object sender, EventArgs e)
        {
            FarPoint.Win.Spread.SpreadView activeView = fpSpread1.GetRootWorkbook().GetActiveWorkbook();
            if (activeView != null)
            {
                activeView.ShowAutoFillIndicator();
            }
        }

        void newcontitem1_Click(object sender, EventArgs e)
        {
            // コピー
            fpSpread1.ActiveSheet.ClipboardCopy();
        }

        void newcontitem2_Click(object sender, EventArgs e)
        {
            // 貼り付け
            fpSpread1.ActiveSheet.ClipboardPaste(FarPoint.Win.Spread.ClipboardPasteOptions.Values);
        }

        void newcontitem3_Click(object sender, EventArgs e)
        {
            // クリア
            int r1 = fpSpread1.ActiveSheet.Models.Selection.AnchorRow;
            int c1 = fpSpread1.ActiveSheet.Models.Selection.AnchorColumn;
            int r2 = fpSpread1.ActiveSheet.Models.Selection.LeadRow - r1 + 1;
            int c2 = fpSpread1.ActiveSheet.Models.Selection.LeadColumn - c1 + 1;
            FarPoint.Win.Spread.Model.DefaultSheetDataModel dataModel = (FarPoint.Win.Spread.Model.DefaultSheetDataModel)fpSpread1.ActiveSheet.Models.Data;
            dataModel.ClearData(r1, c1, r2, c2);
        }
    }
}
