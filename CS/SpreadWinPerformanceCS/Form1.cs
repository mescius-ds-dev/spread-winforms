using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FarPoint.Excel;
using FarPoint.Win.Spread;

namespace SpreadWinPerformanceCS
{
    public partial class Form1 : Form
    {
        private StringBuilder Log { get; set; }
        private DateTime Time1 { get; set; }
        private DateTime Time2 { get; set; }
        private Int64 Memory1 { get; set; }
        private Int64 Memory2 { get; set; }
        private String TestItem { get; set; }

        public Form1()
        {
            InitializeComponent();

            // SPREADの初期化
            InitializeSpread(this);

            // ログの開始
            Log = new StringBuilder();

            // イベントハンドラの設定
            button1.Click += button_Click;
            button2.Click += button_Click;
            button3.Click += button_Click;
            button4.Click += button_Click;
            this.Deactivate += Form1_Deactivate;
            this.FormClosing += Form1_FormClosing;

            this.Text = Text + " - " + System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
        }

        private FpSpread InitializeSpread(Form form)
        {
            // 新しいSPREADの生成と設定
            foreach (Control c in form.Controls)
            {
                if (c is FpSpread)
                {
                    //// SPREADの生成：互換機能を使用する場合
                    //FpSpread spread = new FpSpread();

                    // SPREADの生成：新機能を使用する場合
                    FpSpread spread = new FpSpread(LegacyBehaviors.None);

                    // SPREADの設定
                    spread.Location = c.Location;
                    spread.Size = c.Size;
                    spread.Sheets.Add(new SheetView());

                    // シートの設定
                    var sheet = spread.ActiveSheet;
                    sheet.ColumnCount = 50;
                    sheet.RowCount = 10000;
                    sheet.AutoFilterMode = AutoFilterMode.EnhancedContextMenu;
                    sheet.AutoSortEnhancedContextMenu = true;
                    sheet.Columns[0].AllowAutoFilter = true;
                    sheet.Columns[0].AllowAutoSort = true;
                    sheet.RowHeader.Columns[0].Width = 60;
                    for (var i = 0; i < sheet.RowCount; i++)
                    {
                        sheet.SetValue(i, 0, $"A{i % 5000}");
                        for (var j = 1; j < sheet.ColumnCount; j++)
                        {
                            sheet.SetValue(i, j, $"R{i}C{j}");
                        }
                    }

                    // Formの設定
                    form.Controls.Remove(c);
                    form.Controls.Add(spread);
                    form.Refresh();

                    // 戻り値の設定
                    return spread;
                }
            }

            return null;
        }

        private void GetInitialInfo()
        {
            // 処理開始時のメモリ使用量と時刻の取得
            GC.Collect();
            Memory1 = Environment.WorkingSet;
            Time1 = DateTime.Now;
        }

        private String GetResult(object sender, FpSpread spread, bool measure)
        {
            // 処理完了時のメモリ使用量と時刻の取得
            Time2 = DateTime.Now;
            GC.Collect();
            Memory2 = Environment.WorkingSet;

            // 基本情報の取得
            var sb = new StringBuilder();
            sb.AppendLine($"[{(sender as Control).Text}]");
            sb.AppendLine($"Version = {spread.ProductVersion}");
            sb.AppendLine($"LegacyBehaviors = {spread.GetType().GetProperty("LegacyBehaviors").GetValue(spread)}");
            sb.AppendLine();

            // 計測結果の取得
            if (measure)
            {
                // 処理時間
                sb.AppendLine($"開始時刻 = {Time1:HH:mm:ss}");
                sb.AppendLine($"終了時刻 = {Time2:HH:mm:ss}");
                sb.AppendLine("-------------------------");
                sb.AppendLine($"処理時間 = {Time2.Subtract(Time1).TotalMilliseconds:#,##0} ミリ秒");
                sb.AppendLine();

                // メモリ使用量
                sb.AppendLine($"処理前 = {Memory1:#,##0} Byte");
                sb.AppendLine($"処理後 = {Memory2:#,##0} Byte");
                sb.AppendLine("-------------------------");
                sb.AppendLine($"増加量 = {Memory2 - Memory1:#,##0} Byte");

                // ログの記録
                Log.AppendLine(sb.ToString());
            }

            // 戻り値の設定
            return sb.ToString();
        }

        private void button_Click(object sender, EventArgs e)
        {
            // テスト項目の保存
            TestItem = (sender as Control).Name;

            // マウスカーソルの変更
            this.Cursor = Cursors.WaitCursor;

            // テキストボックスの初期化
            textBox1.Text = string.Empty;
            textBox1.Refresh();

            // SPREADの生成
            var spread = InitializeSpread(this);

            // 処理前の描画制御
            if (radioButton1.Checked)
            {
                // 描画の一時停止
                spread.SuspendLayout();

                // 描画とイベントの一時停止
                spread.AsWorkbook().WorkbookSet.BeginUpdate();
            }
            else if (radioButton2.Checked)
            {
                // 描画の一時停止
                spread.SuspendLayout();
            }
            else if (radioButton3.Checked)
            {
                // 描画の制御なし
            }

            // 処理の実行
            //
            switch ((sender as Control).Name)
            {
                case "button1":
                    // 処理開始時のメモリ使用量と時刻の取得
                    GetInitialInfo();

                    // Excelファイルのインポート
                    try
                    {
                        spread.OpenExcel("PerformanceTest_withStyle.xlsx", ExcelOpenFlags.TruncateEmptyRowsAndColumns);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"テスト：{ex.Message}");
                    }
                    break;
                case "button2":
                    // フィルタリストの表示

                    #region "参考：ver.12の機能を使った計測方法"
                    //spread.BeforeShowContextMenu += (s, ea) =>
                    //{
                    //    // マウスカーソルの変更
                    //    this.Cursor = Cursors.WaitCursor;

                    //    // 処理開始時のメモリ使用量と時刻の取得
                    //    GetInitialInfo();

                    //    // 処理完了時のメモリ使用量と時刻の取得
                    //    ea.ContextMenu.Opened += (s1, ea1) =>
                    //    {
                    //        textBox1.Text = GetResult(sender, spread, true);

                    //        // マウスカーソルの復元
                    //        this.Cursor = Cursors.Default;
                    //    };
                    //};
                    #endregion

                    spread.MouseDown += (s, ea) =>
                    {
                        var ht = spread.HitTest(ea.X, ea.Y);
                        if (ht.Type == HitTestType.ColumnHeader && ht.HeaderInfo.Column == 0)
                        {
                            // マウスカーソルの変更
                            this.Cursor = Cursors.WaitCursor;

                            // 処理開始時のメモリ使用量と時刻の取得
                            GetInitialInfo();
                        }
                    };

                    // 開始処理のキャンセル
                    spread.CellClick += (s, ea) =>
                    {
                        if (ea.ColumnHeader && ea.Column == 0)
                        {
                            Time1 = DateTime.MinValue;
                            Memory1 = 0;
                            this.Cursor = Cursors.Default;
                        }
                    };
                    break;
                case "button3":
                    // フィルタの実行

                    #region "参考：コードによるフィルタの実行"
                    //// 処理開始時のメモリ使用量と時刻の取得
                    //GetInitialInfo();

                    ////// SheetViewの機能を使う方法
                    ////spread.ActiveSheet.AutoFilterColumn(0, "A100", 0);

                    //// IWorkSheetの機能を使う方法：高速です！
                    //var wsheet = spread.ActiveSheet.AsWorksheet();
                    //wsheet.InsertRows(0, 1);
                    //wsheet.Cells[0, 0, wsheet.RowCount - 1, wsheet.ColumnCount - 1].AutoFilter();
                    //wsheet.Cells[0, 0, wsheet.RowCount - 1, wsheet.ColumnCount - 1].AutoFilter(0, criteria1: "=A100");
                    #endregion

                    spread.AutoFilteringColumn += (s, ea) =>
                    {
                        // マウスカーソルの変更
                        this.Cursor = Cursors.WaitCursor;

                        // 処理開始時のメモリ使用量と時刻の取得
                        GetInitialInfo();
                    };
                    spread.AutoFilteredColumn += (s, ea) =>
                    {
                        // 処理完了時のメモリ使用量と時刻の取得
                        textBox1.Text = GetResult(sender, spread, true);

                        // マウスカーソルの復元
                        this.Cursor = Cursors.Default;
                    };
                    break;
                case "button4":
                    // 処理開始時のメモリ使用量と時刻の取得
                    GetInitialInfo();

                    // スタイルの設定

                    #region "参考：IWorkSheetの機能を使う方法：高速です！"
                    // この手法はLegacyBehaviorsのStyleフラグがオフのときにのみ有効です
                    var wsheet = spread.ActiveSheet.AsWorksheet();
                    var backColor = GrapeCity.Spreadsheet.Color.FromArgb(Color.LavenderBlush.ToArgb());
                    var foreColor = GrapeCity.Spreadsheet.Color.FromArgb(Color.Blue.ToArgb());
                    for (var i = 0; i < wsheet.RowCount; i++)
                    {
                        for (var j = 0; j < wsheet.ColumnCount; j++)
                        {
                            wsheet.Cells[i, j].Interior.Color = backColor;
                            wsheet.Cells[i, j].Font.Color = foreColor;
                        }
                    }
                    #endregion

                    //var sheet = spread.ActiveSheet;
                    //for (var i = 0; i < sheet.RowCount; i++)
                    //{
                    //    for (var j = 0; j < sheet.ColumnCount; j++)
                    //    {
                    //        sheet.Cells[i, j].BackColor = Color.LavenderBlush;
                    //        sheet.Cells[i, j].ForeColor = Color.Blue;
                    //    }
                    //}
                    break;
            }

            // 処理後の描画制御
            if (radioButton1.Checked)
            {
                // 描画とイベントの一時停止の解除
                spread.AsWorkbook().WorkbookSet.EndUpdate();

                // 描画の一時停止の解除
                spread.ResumeLayout();
            }
            else if (radioButton2.Checked)
            {
                // 描画の一時停止の解除
                spread.ResumeLayout();
            }
            else if (radioButton3.Checked)
            {
                // 描画の制御なし
            }

            // 情報の取得と表示
            if ((sender as Control).Name == "button2")
            {
                textBox1.Text = GetResult(sender, spread, false);
                spread.ActiveSheet.TitleInfo.Text = "第１列の列ヘッダ内のドロップダウンボタンをクリックしてください。";
                spread.ActiveSheet.TitleInfo.ForeColor = Color.Red;
                spread.ActiveSheet.TitleInfo.Visible = true;
            }
            else if ((sender as Control).Name == "button3")
            {
                textBox1.Text = GetResult(sender, spread, false);
                spread.ActiveSheet.TitleInfo.Text = "第１列でフィルタ操作を行って「A0」のチェックを外してOKボタンをクリックしてください。";
                spread.ActiveSheet.TitleInfo.ForeColor = Color.Red;
                spread.ActiveSheet.TitleInfo.Visible = true;
            }
            else
            {
                textBox1.Text = GetResult(sender, spread, true);
            }

            // マウスカーソルの復元
            this.Cursor = Cursors.Default;
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            // 処理完了時のメモリ使用量と時刻の取得
            if (TestItem == "button2" && Time1 != DateTime.MinValue)
            {
                foreach (Control c in (sender as Form).Controls)
                {
                    if (c is FpSpread)
                    {
                        textBox1.Text = GetResult(button2, c as FpSpread, true);

                        // マウスカーソルの復元
                        this.Cursor = Cursors.Default;
                        break;
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ログの出力
            using (FileStream fs = File.OpenWrite($"v12_{DateTime.Now:yyyyMMddHHmmss}.log"))
            {
                var info = new UTF8Encoding(true).GetBytes(Log.ToString());
                fs.Write(info, 0, info.Length);
            }
        }
    }
}
