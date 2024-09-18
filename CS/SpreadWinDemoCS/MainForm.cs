using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace SpreadWinDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(MainForm_Load);
            treemenu.AfterSelect += new TreeViewEventHandler(treemenu_AfterSelect);
            treemenu.AfterCollapse += new TreeViewEventHandler(treemenu_AfterCollapse);
            firstView.LinkClicked += new LinkLabelLinkClickedEventHandler(firstView_LinkClicked);
            trial.LinkClicked += new LinkLabelLinkClickedEventHandler(trial_LinkClicked);
            searchtext.TextChanged += new EventHandler(searchtext_TextChanged);
            searchlist.SelectedIndexChanged += new EventHandler(searchlist_SelectedIndexChanged);
            myTabControl1.SelectedIndexChanged += new EventHandler(myTabControl1_SelectedIndexChanged);

            // VS2010のデザイナで入れ子のFixedPanelプロパティを設定すると
            // デザイナを開くたびにサイズが大きくなるため、コードから設定して回避
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            // デザイナを開くたびに位置が変わるため、コードから設定して回避
            mescius_logo.Location = new Point(12, 27);
            copyright.Location = new Point(173, 35);

            // ちらつき防止
            // ヘッダ
            pictureBox1.Controls.Add(cube);
            pictureBox1.Controls.Add(product_title);
            pictureBox1.Controls.Add(firstView);
            pictureBox1.Controls.Add(trial);

            // フッタ
            pictureBox2.Controls.Add(mescius_logo);
            pictureBox2.Controls.Add(copyright);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ファーストビューを開く
            this.setMainPanel(new FirstViewPage());
        }

        private void treemenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null) return;

            switch (e.Node.Parent.Text)
            {
                case "新機能":
                    switch (e.Node.Text)
                    {
                        case "チャートシート":
                            this.setMainPanel(new SpreadWinDemo.chart.chartsheet());
                            break;
                        case "チャートへシェイプの埋め込み":
                            this.setMainPanel(new SpreadWinDemo.chart.embeddedshape());
                            break;
                        case "チャートの複数項目軸ラベル":
                            this.setMainPanel(new SpreadWinDemo.chart.multilabels());
                            break;
                        case "複数範囲のコピー＆ペースト":
                            this.setMainPanel(new SpreadWinDemo.edit.multirange());
                            break;
                        case "スレッド形式のコメント":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.addthreadedcomment());
                            break;
                        case "複数シートのコピー":
                            this.setMainPanel(new SpreadWinDemo.sheet.copysheets());
                            break;
                        case "固定線の太さ":
                            this.setMainPanel(new SpreadWinDemo.scroll.frozenwidth());
                            break;
                        case "選択範囲内で中央":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.centeracrossselection());
                            break;
                        case "テキストから列":
                            this.setMainPanel(new SpreadWinDemo.edit.texttocolumns());
                            break;
                        case "重複データの削除":
                            this.setMainPanel(new SpreadWinDemo.edit.removeduplicates());
                            break;
                        case "マウスホイールによる水平スクロール":
                            this.setMainPanel(new SpreadWinDemo.scroll.horizontalmousewheel());
                            break;
                        case "シェイプの3D回転":
                            this.setMainPanel(new SpreadWinDemo.shape.add3dshape());
                            break;
                        case "曲線シェイプの入力":
                            this.setMainPanel(new SpreadWinDemo.shape.inputcurve());
                            break;
                        case "Excel互換の印刷機能":
                            this.setMainPanel(new SpreadWinDemo.print.excelprint());
                            break;
                    }
                    break;
                case "行、列、セル、ヘッダ":
                    switch (e.Node.Text)
                    {
                        case "列幅、行高の自動調整":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.autofitcustomize());
                            break;
                        case "行セレクタ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.rowselector());
                            break;
                        case "行列ドラッグ移動のアニメーション":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.dragbandonmoving());
                            break;
                        case "結合":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.cellspan());
                            break;
                        case "マージ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.rowcolmerge());
                            break;
                        case "テキストチップ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.texttip());
                            break;
                        case "セルノート":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.cellnote());
                            break;
                        case "コメント":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.addcomment());
                            break;
                        case "行、列の非表示":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.rowvisible());
                            break;
                        case "行、列のリサイズ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.rowresize());
                            break;
                        case "行列のドラッグ移動":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.rowcolmove());
                            break;
                        case "挿入ダイアログ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.insertdialog());
                            break;
                        case "列フッタ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.columnfooter());
                            break;
                        case "ヘッダの非表示":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.headervisible());
                            break;
                        case "マルチヘッダ":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.multiheader());
                            break;
                        case "シートコーナーの分割":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.sheetcorner());
                            break;
                        case "タイトル、サブタイトル":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.title());
                            break;
                        case "行ヘッダの自動拡張":
                            this.setMainPanel(new SpreadWinDemo.rowcolcell.rowheaderautowidth());
                            break;
                    }
                    break;
                case "シート":
                    switch (e.Node.Text)
                    {
                        case "ステータスバー":
                            this.setMainPanel(new SpreadWinDemo.sheet.statusbar());
                            break;
                        case "前後のコントロールに移動":
                            this.setMainPanel(new SpreadWinDemo.sheet.movenextcontrol());
                            break;
                        case "テーブル":
                            this.setMainPanel(new SpreadWinDemo.sheet.addtable());
                            break;
                        case "スライサー":
                            this.setMainPanel(new SpreadWinDemo.sheet.slicers());
                            break;
                        case "マルチシート":
                            this.setMainPanel(new SpreadWinDemo.sheet.multisheet());
                            break;
                        case "シートの非表示":
                            this.setMainPanel(new SpreadWinDemo.sheet.sheetvisible());
                            break;
                        case "グリッド線":
                            this.setMainPanel(new SpreadWinDemo.sheet.gridline());
                            break;
                        case "ズーム":
                            this.setMainPanel(new SpreadWinDemo.sheet.zoomfactor());
                            break;
                        case "キーボードマップ":
                            this.setMainPanel(new SpreadWinDemo.sheet.inputmap());
                            break;
                        case "アンドゥ・リドゥ":
                            this.setMainPanel(new SpreadWinDemo.sheet.undoredo());
                            break;
                        case "ビューポート":
                            this.setMainPanel(new SpreadWinDemo.sheet.viewport());
                            break;
                        case "先頭セルの取得":
                            this.setMainPanel(new SpreadWinDemo.sheet.gettoprowcol());
                            break;
                        case "Excel互換のショートカットキー":
                            this.setMainPanel(new SpreadWinDemo.sheet.excelshortcut());
                            break;
                    }
                    break;
                case "スタイル":
                    switch (e.Node.Text)
                    {
                        case "斜め罫線":
                            this.setMainPanel(new SpreadWinDemo.style.diagonalline());
                            break;
                        case "背景色の回転":
                            this.setMainPanel(new SpreadWinDemo.style.backcolorrotation());
                            break;
                        case "フォント":
                            this.setMainPanel(new SpreadWinDemo.style.fontsetting());
                            break;
                        case "背景色":
                            this.setMainPanel(new SpreadWinDemo.style.backcolor());
                            break;
                        case "罫線":
                            this.setMainPanel(new SpreadWinDemo.style.border());
                            break;
                        case "拡張罫線":
                            this.setMainPanel(new SpreadWinDemo.style.enhancedborder());
                            break;
                        case "スキン":
                            this.setMainPanel(new SpreadWinDemo.style.skin());
                            break;
                        case "条件付き書式":
                            this.setMainPanel(new SpreadWinDemo.style.conditionalformat7());
                            break;
                        case "スパークライン":
                            this.setMainPanel(new SpreadWinDemo.style.sparkline());
                            break;
                        case "数式を使用したスパークライン":
                            this.setMainPanel(new SpreadWinDemo.style.formulasparkline());
                            break;
                        case "パターンとグラデーション":
                            this.setMainPanel(new SpreadWinDemo.style.patterngradient());
                            break;
                    }
                    break;
                case "選択":
                    switch (e.Node.Text)
                    {
                        case "ヘッダクリック時の選択範囲":
                            this.setMainPanel(new SpreadWinDemo.selection.cellspanselection());
                            break;
                        case "アクティブセルの色":
                            this.setMainPanel(new SpreadWinDemo.selection.paintactivecell());
                            break;
                        case "ヘッダのハイライト表示":
                            this.setMainPanel(new SpreadWinDemo.selection.paintselectionheader());
                            break;
                        case "フォーカス枠":
                            this.setMainPanel(new SpreadWinDemo.selection.focusindicator());
                            break;
                        case "選択範囲の作成":
                            this.setMainPanel(new SpreadWinDemo.selection.addselection());
                            break;
                        case "選択範囲の取得":
                            this.setMainPanel(new SpreadWinDemo.selection.getselectedrange());
                            break;
                        case "選択範囲のクリア":
                            this.setMainPanel(new SpreadWinDemo.selection.clearselection());
                            break;
                        case "選択のスタイル":
                            this.setMainPanel(new SpreadWinDemo.selection.selectionstyle());
                            break;
                        case "オペレーションモード":
                            this.setMainPanel(new SpreadWinDemo.selection.operationmode());
                            break;
                        case "選択のカスタマイズ":
                            this.setMainPanel(new SpreadWinDemo.selection.selectionpolicy());
                            break;
                        case "セル移動のスキップ":
                            this.setMainPanel(new SpreadWinDemo.selection.canfocus());
                            break;
                     }
                    break;
                case "セル型":
                    switch (e.Node.Text)
                    {
                        case "セル型":
                            this.setMainPanel(new SpreadWinDemo.celltype.basiccelltype());
                            break;
                        case "セルの書式設定":
                            this.setMainPanel(new SpreadWinDemo.celltype.cellformat());
                            break;
                    }
                    break;
                case "高度な入力支援（InputManセル）":
                    switch (e.Node.Text)
                    {
                        case "コンボボックス":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gccombobox());
                            break;
                        case "マスク":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gcmask());
                            break;
                        case "時間間隔":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gctimespan());
                            break;
                        case "マス目":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gccharmask());
                            break;
                        case "テキスト":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gctextbox());
                            break;
                        case "日付":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gcdatetime());
                            break;
                        case "数値":
                            this.setMainPanel(new SpreadWinDemo.inputmancell.gcnumber());
                            break;
                    }
                    break;
                case "編集":
                    switch (e.Node.Text)
                    {
                        case "非表示の値を無視する集計":
                            this.setMainPanel(new SpreadWinDemo.edit.calcignorehidden());
                            break;
                        case "IMEモード":
                            this.setMainPanel(new SpreadWinDemo.edit.imemode());
                            break;
                        case "常時入力モード":
                            this.setMainPanel(new SpreadWinDemo.edit.editmodepermanent());
                            break;
                        case "上書き入力":
                            this.setMainPanel(new SpreadWinDemo.edit.editmodereplace());
                            break;
                         case "ロック":
                            this.setMainPanel(new SpreadWinDemo.edit.lockedcell());
                            break;
                         case "クリップボード":
                            this.setMainPanel(new SpreadWinDemo.edit.useclipboard());
                            break;
                        case "Excelライクなコピー＆ペースト":
                            this.setMainPanel(new SpreadWinDemo.edit.richclipboard());
                            break;
                         case "オートフィル":
                            this.setMainPanel(new SpreadWinDemo.edit.dragfill());
                            break;
                        case "オートフィルメニュー":
                            this.setMainPanel(new SpreadWinDemo.edit.dragfillmenu());
                            break;
                        case "ドラッグ移動":
                            this.setMainPanel(new SpreadWinDemo.edit.celldragdrop());
                            break;
                         case "ドラッグ＆ドロップ":
                            this.setMainPanel(new SpreadWinDemo.edit.dragdrop());
                            break;
                         case "オーバーフロー":
                            this.setMainPanel(new SpreadWinDemo.edit.celloverflow());
                            break;
                        case "データ検証":
                            this.setMainPanel(new SpreadWinDemo.edit.datavalidator());
                            break;
                        case "数式":
                            this.setMainPanel(new SpreadWinDemo.edit.formula());
                            break;
                        case "別シートセルの数式参照":
                            this.setMainPanel(new SpreadWinDemo.edit.differentsheetformula());
                            break;
                        case "独自の数式":
                            this.setMainPanel(new SpreadWinDemo.edit.customformula());
                            break;
                        case "配列数式":
                            this.setMainPanel(new SpreadWinDemo.edit.arrayformula());
                            break;
                        case "ヘッダ・フッタ上のデータ参照":
                            this.setMainPanel(new SpreadWinDemo.edit.headerfooterformula());
                            break;
                        case "数式テキストボックス":
                            this.setMainPanel(new SpreadWinDemo.edit.formulatextbox());
                            break;
                        case "ゴールシーク":
                            this.setMainPanel(new SpreadWinDemo.edit.goalseek());
                            break;
                        case "検索":
                            this.setMainPanel(new SpreadWinDemo.edit.search());
                            break;
                        case "数式のオートフォーマット":
                            this.setMainPanel(new SpreadWinDemo.edit.autoformat());
                            break;
                        case "動的配列数式":
                            this.setMainPanel(new SpreadWinDemo.edit.dynamicarray());
                            break;
                        case "数式の表示":
                            this.setMainPanel(new SpreadWinDemo.edit.displayformula());
                            break;
                    }
                    break;
                case "ソート":
                    switch (e.Node.Text)
                    {
                        case "自動ソート":
                            this.setMainPanel(new SpreadWinDemo.sort.autosort());
                            break;
                        case "固定行を除いたソート":
                            this.setMainPanel(new SpreadWinDemo.sort.unsortedrows());
                            break;
                        case "セル範囲のソート":
                            this.setMainPanel(new SpreadWinDemo.sort.rangesort());
                            break;
                        case "独自のソートロジックでソート":
                            this.setMainPanel(new SpreadWinDemo.sort.customcomparison());
                            break;
                    }
                    break;
                case "フィルタリング":
                    switch (e.Node.Text)
                    {
                        case "ドロップダウンメニューからソート":
                            this.setMainPanel(new SpreadWinDemo.filtering.filtersort());
                            break;
                        case "フィルタリングの自動実行":
                            this.setMainPanel(new SpreadWinDemo.filtering.autofilter());
                            break;
                        case "非表示フィルタ":
                            this.setMainPanel(new SpreadWinDemo.filtering.hiderowfilter());
                            break;
                        case "スタイルフィルタ":
                            this.setMainPanel(new SpreadWinDemo.filtering.stylerowfilter());
                            break;
                        case "カスタムフィルタ":
                            this.setMainPanel(new SpreadWinDemo.filtering.customfilter());
                            break;
                        case "条件フィルタ":
                            this.setMainPanel(new SpreadWinDemo.filtering.filterbar());
                            break;
                        case "Excelフィルタリング":
                            this.setMainPanel(new SpreadWinDemo.filtering.enhancedfilter());
                            break;
                        case "非フィルタリング行":
                            this.setMainPanel(new SpreadWinDemo.filtering.unfilteredrows());
                            break;
                        case "セル範囲のフィルタリング":
                            this.setMainPanel(new SpreadWinDemo.filtering.rangefilter());
                            break;
                    }
                    break;
                case "グループ化":
                    switch (e.Node.Text)
                    {
                        case "アウトラインのボタン位置":
                            this.setMainPanel(new SpreadWinDemo.group.outlinesummary());
                            break;
                        case "Outlookスタイルグループ化":
                            this.setMainPanel(new SpreadWinDemo.group.grouping());
                            break;
                        case "アウトライン":
                            this.setMainPanel(new SpreadWinDemo.group.outline());
                            break;
                    }
                    break;
                case "スクロール":
                    switch (e.Node.Text)
                    {
                        case "テキスト位置の自動調整":
                            this.setMainPanel(new SpreadWinDemo.scroll.cellcontentfloat());
                            break;
                        case "スクロール単位":
                            this.setMainPanel(new SpreadWinDemo.scroll.scrollmode());
                            break;
                        case "マウスホイールのピクセルスクロール":
                            this.setMainPanel(new SpreadWinDemo.scroll.mousewheel());
                            break;
                        case "スクロールバーの表示・非表示":
                            this.setMainPanel(new SpreadWinDemo.scroll.scrollbarvisible());
                            break;
                        case "遅延スクロール":
                            this.setMainPanel(new SpreadWinDemo.scroll.scrollbartrack());
                            break;
                        case "行・列の固定":
                            this.setMainPanel(new SpreadWinDemo.scroll.frozenrowcol());
                            break;
                        case "固定線の色":
                            this.setMainPanel(new SpreadWinDemo.scroll.frozenline());
                            break;
                    }
                    break;
                case "データ連結":
                    switch (e.Node.Text)
                    {
                        case "バウンドデータ":
                            this.setMainPanel(new SpreadWinDemo.databind.databinding());
                            break;
                        case "アンバウンドデータ":
                            this.setMainPanel(new SpreadWinDemo.databind.dataunbinding());
                            break;
                        case "特定の列だけを連結":
                            this.setMainPanel(new SpreadWinDemo.databind.fieldbinding());
                            break;
                        case "テーブルへのデータバインディング":
                            this.setMainPanel(new SpreadWinDemo.databind.tablebinding());
                            break;
                        case "テーブルの自動拡張":
                            this.setMainPanel(new SpreadWinDemo.sheet.autotable());
                            break;
                        case "行の追加":
                            this.setMainPanel(new SpreadWinDemo.databind.addrows());
                            break;
                        case "行の削除":
                            this.setMainPanel(new SpreadWinDemo.databind.removerows());
                            break;
                        case "新規行":
                            this.setMainPanel(new SpreadWinDemo.databind.newrows());
                            break;
                        case "階層表示":
                            this.setMainPanel(new SpreadWinDemo.databind.hierarchicalview());
                            break;
                    }
                    break;
                case "チャート":
                    switch (e.Node.Text)
                    {
                        case "チャートコントロール":
                            this.setMainPanel(new SpreadWinDemo.chart.chartcontrol());
                            break;
                        case "ツリーマップ":
                            this.setMainPanel(new SpreadWinDemo.chart.treemap());
                            break;
                        case "サンバースト":
                            this.setMainPanel(new SpreadWinDemo.chart.sunburst());
                            break;
                        case "ヒストグラム":
                            this.setMainPanel(new SpreadWinDemo.chart.histogram());
                            break;
                        case "パレート図":
                            this.setMainPanel(new SpreadWinDemo.chart.pareto());
                            break;
                        case "箱ひげ図":
                            this.setMainPanel(new SpreadWinDemo.chart.boxwhisker());
                            break;
                        case "ウォーターフォール":
                            this.setMainPanel(new SpreadWinDemo.chart.waterfall());
                            break;
                        case "じょうご":
                            this.setMainPanel(new SpreadWinDemo.chart.funnel());
                            break;
                        case "折れ線チャートの線種":
                            this.setMainPanel(new SpreadWinDemo.chart.linechartstyle());
                            break;
                        case "縦棒":
                            this.setMainPanel(new SpreadWinDemo.chart.columnchart());
                            break;
                        case "折れ線":
                            this.setMainPanel(new SpreadWinDemo.chart.linechart());
                            break;
                        case "円":
                            this.setMainPanel(new SpreadWinDemo.chart.piechart());
                            break;
                        case "横棒":
                            this.setMainPanel(new SpreadWinDemo.chart.barchart());
                            break;
                        case "面":
                            this.setMainPanel(new SpreadWinDemo.chart.areachart());
                            break;
                        case "散布図":
                            this.setMainPanel(new SpreadWinDemo.chart.xychart());
                            break;
                        case "バブル":
                            this.setMainPanel(new SpreadWinDemo.chart.bubblechart());
                            break;
                        case "株価":
                            this.setMainPanel(new SpreadWinDemo.chart.stockchart());
                            break;
                        case "XYZ散布図":
                            this.setMainPanel(new SpreadWinDemo.chart.xyzchart());
                            break;
                        case "ドーナツ":
                            this.setMainPanel(new SpreadWinDemo.chart.doughnutchart());
                            break;
                        case "レーダー":
                            this.setMainPanel(new SpreadWinDemo.chart.radarchart());
                            break;
                        case "ポーラ":
                            this.setMainPanel(new SpreadWinDemo.chart.polarchart());
                            break;
                    }
                    break;
                case "印刷":
                    switch (e.Node.Text)
                    {
                        case "白黒印刷":
                            this.setMainPanel(new SpreadWinDemo.print.blackwhiteprint());
                            break;
                        case "印刷":
                            this.setMainPanel(new SpreadWinDemo.print.printsheet());
                            break;
                        case "両面印刷":
                            this.setMainPanel(new SpreadWinDemo.print.duplexprint());
                            break;
                        case "印刷プレビュー":
                            this.setMainPanel(new SpreadWinDemo.print.printpreview());
                            break;
                        case "Excelライクプレビュー":
                            this.setMainPanel(new SpreadWinDemo.print.excelprintpreview());
                            break;
                        case "印刷ページ設定":
                            this.setMainPanel(new SpreadWinDemo.print.printsetting());
                            break;
                        case "ユーザー定義印刷":
                            this.setMainPanel(new SpreadWinDemo.print.ownerprint());
                            break;
                    }
                    break;
                case "インポート／エクスポート":
                    switch (e.Node.Text)
                    {
                        case "PDFエクスポート":
                            this.setMainPanel(new SpreadWinDemo.importexport.printpdf());
                            break;
                        case "csv（テキスト）ファイルの読込":
                            this.setMainPanel(new SpreadWinDemo.importexport.opentextfile());
                            break;
                        case "csv（テキスト）ファイルへ保存":
                            this.setMainPanel(new SpreadWinDemo.importexport.savetextfile());
                            break;
                        case "Excelファイルの読込":
                            this.setMainPanel(new SpreadWinDemo.importexport.openexcelfile());
                            break;
                        case "Excelファイルへ保存":
                            this.setMainPanel(new SpreadWinDemo.importexport.saveexcelfile());
                            break;
                        case "Excelファイルの読込と保存（Excel情報の維持）":
                            this.setMainPanel(new SpreadWinDemo.importexport.keepexcelsetting());
                            break;
                    }
                    break;
                case "マルチタッチ機能":
                    switch (e.Node.Text)
                    {
                        case "タッチツールバー":
                            this.setMainPanel(new SpreadWinDemo.touch.touchstrip());
                            break;
                        case "選択グリッパー":
                            this.setMainPanel(new SpreadWinDemo.touch.touchselection());
                            break;
                        case "タッチスクロール":
                            this.setMainPanel(new SpreadWinDemo.touch.touchscroll());
                            break;
                        case "ドロップダウンリストの拡大表示":
                            this.setMainPanel(new SpreadWinDemo.touch.touchdropdownscale());
                            break;
                        case "タッチキーボード":
                            this.setMainPanel(new SpreadWinDemo.touch.touchkeyboard());
                            break;
                    }
                    break;
                case "シェイプオブジェクト":
                    switch (e.Node.Text)
                    {
                        case "シェイプ":
                            this.setMainPanel(new SpreadWinDemo.shape.addshape());
                            break;
                        case "カメラシェイプ":
                            this.setMainPanel(new SpreadWinDemo.shape.camerashape());
                            break;
                        case "拡張シェイプエンジン":
                            this.setMainPanel(new SpreadWinDemo.shape.enhancedshape());
                            break;
                        case "拡張カメラシェイプ":
                            this.setMainPanel(new SpreadWinDemo.shape.enhancedcamerashape());
                            break;
                        case "シェイプの頂点の編集":
                            this.setMainPanel(new SpreadWinDemo.shape.editshape());
                            break;
                        case "フリーフォーム":
                            this.setMainPanel(new SpreadWinDemo.shape.freeform());
                            break;
                    }
                    break;
                case "サンプル":
                    switch (e.Node.Text)
                    {
                        case "売上管理":
                            this.setMainPanel(new SpreadWinDemo.sample.SalesManagement());
                            break;
                    }
                    break;
            }
        }

        private void treemenu_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            treemenu.SelectedNode = null;
        }

        #region ページ移動処理
        private void setMainPanel(FirstViewPage ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        private void setMainPanel(DemoBase ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        private void setMainPanel(DemoBase_settings ucontrol)
        {
            ucontrol.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Add(ucontrol);
            if (this.splitContainer1.Panel2.Controls.Count > 1)
            {
                this.splitContainer1.Panel2.Controls.RemoveAt(0);
            }
        }
        #endregion

        #region リンク処理
        private void firstView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // ファーストビューに戻る
            this.setMainPanel(new FirstViewPage());
            treemenu.SelectedNode = null;
            treemenu.CollapseAll();
        }
        private void trial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // トライアル版へのリンク
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = "https://developer.mescius.jp/download",
            });
        }
        #endregion

        #region 検索機能
        // 検索ノードのコレクション               
        ArrayList myNode = new ArrayList();

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            // 検索結果(searchlist)をクリア
            searchlist.Items.Clear();
            myNode.Clear();

            if (searchtext.Text == "") return;

            // ツリーコントロールのノードを取得
            foreach (TreeNode node in GetAllNodes(treemenu.Nodes))
            {
                if (node.Parent != null)
                {
                    string s = node.Text;
                    if (node.Tag != null) s += node.Tag.ToString();

                    // 検索ワードを含むノードのみ抽出
                    if (s.Contains(searchtext.Text))
                    {
                        myNode.Add(node);
                        searchlist.Items.Add(node.Text);
                    }
                }
            }
        }

        private ArrayList GetAllNodes(TreeNodeCollection Nodes)
        {
            ArrayList Ar = new ArrayList();
            // ツリーコントロールのノードを取得
            foreach (TreeNode Node in Nodes) {
		        Ar.Add(Node);
		        if (Node.GetNodeCount(false) > 0) Ar.AddRange(GetAllNodes(Node.Nodes));
	        }
	        return Ar;
        }

        private void searchlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストボックスで選択されたページを表示
            treemenu.SelectedNode = (TreeNode)myNode[searchlist.SelectedIndex];
        }

        private void myTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ツリービューにフォーカスを設定して選択状態にする
            if (myTabControl1.SelectedIndex == 0)
            {
                treemenu.Select();
            }
        }
        #endregion
    }

    // ツリービューのカスタマイズ
    class MyTreeView : TreeView
    {
        protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
        {
            // ツリービューのシングルクリックでの開閉
            if (e.Node != null)
            {
                if (HitTest(e.Location).Location == TreeViewHitTestLocations.Label ||
                    HitTest(e.Location).Location == TreeViewHitTestLocations.Image)
                {
                    e.Node.Toggle();
                }
            }

            // 既定の動作
            base.OnNodeMouseClick(e);
        }
    }

    // タブコントロール内のちらつきを抑える
    class MyTabControl : TabControl
    {
        // リサイズ途中のちらつきを抑える処理
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}