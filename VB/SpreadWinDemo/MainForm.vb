Public Class MainForm

    Public Sub New()

        ' この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        ' VS2010のデザイナで入れ子のFixedPanelプロパティを設定すると
        ' デザイナを開くたびにサイズが大きくなるため、コードから設定して回避
        SplitContainer3.FixedPanel = FixedPanel.Panel2
        ' デザイナを開くたびに位置が変わるため、コードから設定して回避
        mescius_logo.Location = New Point(12, 27)
        copyright.Location = New Point(173, 35)

        ' ちらつき防止
        ' ヘッダ
        PictureBox1.Controls.Add(cube)
        PictureBox1.Controls.Add(product_logo)
        PictureBox1.Controls.Add(product_title)
        PictureBox1.Controls.Add(firstView)

        ' フッタ
        PictureBox2.Controls.Add(mescius_logo)
        PictureBox2.Controls.Add(copyright)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' ファーストビューを開く
        Me.setMainPanel(New FirstViewPage())
    End Sub

    Private Sub treemenu_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treemenu.AfterSelect
        If e.Node.Parent Is Nothing Then
            Return
        End If

        Select Case e.Node.Parent.Text
            Case "新機能"
                Select Case e.Node.Text
                    Case "テーブルへのデータバインディング"
                        Me.setMainPanel(New SpreadWinDemo.tablebinding())
                        Exit Select
                    Case "テーブルの自動拡張"
                        Me.setMainPanel(New SpreadWinDemo.autotable())
                        Exit Select
                    Case "数式を使用したスパークライン"
                        Me.setMainPanel(New SpreadWinDemo.formulasparkline())
                        Exit Select
                    Case "拡張カメラシェイプ"
                        Me.setMainPanel(New SpreadWinDemo.enhancedcamerashape())
                        Exit Select
                    Case "Excel互換のショートカットキー"
                        Me.setMainPanel(New SpreadWinDemo.excelshortcut())
                        Exit Select
                    Case "Excelライクなコピー＆ペースト"
                        Me.setMainPanel(New SpreadWinDemo.richclipboard())
                        Exit Select
                    Case "挿入ダイアログ"
                        Me.setMainPanel(New SpreadWinDemo.insertdialog())
                        Exit Select
                    Case "拡張罫線"
                        Me.setMainPanel(New SpreadWinDemo.enhancedborder())
                        Exit Select
                    Case "フリーフォーム"
                        Me.setMainPanel(New SpreadWinDemo.freeform())
                        Exit Select
                    Case "コメント"
                        Me.setMainPanel(New SpreadWinDemo.addcomment())
                        Exit Select
                    Case "シェイプの頂点の編集"
                        Me.setMainPanel(New SpreadWinDemo.editshape())
                        Exit Select
                    Case "数式の表示"
                        Me.setMainPanel(New SpreadWinDemo.displayformula())
                        Exit Select
                    Case "固定線の色"
                        Me.setMainPanel(New SpreadWinDemo.frozenline())
                        Exit Select
                    Case "マウスホイールのピクセルスクロール"
                        Me.setMainPanel(New SpreadWinDemo.mousewheel())
                        Exit Select
                    Case "行ヘッダの自動拡張"
                        Me.setMainPanel(New SpreadWinDemo.rowheaderautowidth())
                        Exit Select
                End Select
            Case "行、列、セル、ヘッダ"
                Select Case e.Node.Text
                    Case "列幅、行高の自動調整"
                        Me.setMainPanel(New SpreadWinDemo.autofitcustomize())
                        Exit Select
                    Case "行セレクタ"
                        Me.setMainPanel(New SpreadWinDemo.rowselector())
                        Exit Select
                    Case "行列ドラッグ移動のアニメーション"
                        Me.setMainPanel(New SpreadWinDemo.dragbandonmoving())
                        Exit Select
                    Case "結合"
                        Me.setMainPanel(New SpreadWinDemo.cellspan())
                        Exit Select
                    Case "マージ"
                        Me.setMainPanel(New SpreadWinDemo.rowcolmerge())
                        Exit Select
                    Case "テキストチップ"
                        Me.setMainPanel(New SpreadWinDemo.texttip())
                        Exit Select
                    Case "セルノート"
                        Me.setMainPanel(New SpreadWinDemo.cellnote())
                        Exit Select
                    Case "行、列の非表示"
                        Me.setMainPanel(New SpreadWinDemo.rowvisible())
                        Exit Select
                    Case "行、列のリサイズ"
                        Me.setMainPanel(New SpreadWinDemo.rowresize())
                        Exit Select
                    Case "行列のドラッグ移動"
                        Me.setMainPanel(New SpreadWinDemo.rowcolmove())
                        Exit Select
                    Case "列フッタ"
                        Me.setMainPanel(New SpreadWinDemo.columnfooter())
                        Exit Select
                    Case "ヘッダの非表示"
                        Me.setMainPanel(New SpreadWinDemo.headervisible())
                        Exit Select
                    Case "マルチヘッダ"
                        Me.setMainPanel(New SpreadWinDemo.multiheader())
                        Exit Select
                    Case "シートコーナーの分割"
                        Me.setMainPanel(New SpreadWinDemo.sheetcorner())
                        Exit Select
                    Case "タイトル、サブタイトル"
                        Me.setMainPanel(New SpreadWinDemo.title())
                        Exit Select
                End Select
            Case "シート"
                Select Case e.Node.Text
                    Case "ステータスバー"
                        Me.setMainPanel(New SpreadWinDemo.statusbar())
                        Exit Select
                    Case "前後のコントロールに移動"
                        Me.setMainPanel(New SpreadWinDemo.movenextcontrol())
                        Exit Select
                    Case "テーブル"
                        Me.setMainPanel(New SpreadWinDemo.addtable())
                        Exit Select
                    Case "スライサー"
                        Me.setMainPanel(New SpreadWinDemo.slicers())
                        Exit Select
                    Case "マルチシート"
                        Me.setMainPanel(New SpreadWinDemo.multisheet())
                        Exit Select
                    Case "シートの非表示"
                        Me.setMainPanel(New SpreadWinDemo.sheetvisible())
                        Exit Select
                    Case "グリッド線"
                        Me.setMainPanel(New SpreadWinDemo.gridline())
                        Exit Select
                    Case "ズーム"
                        Me.setMainPanel(New SpreadWinDemo.zoomfactor())
                        Exit Select
                    Case "キーボードマップ"
                        Me.setMainPanel(New SpreadWinDemo.inputmap())
                        Exit Select
                    Case "アンドゥ・リドゥ"
                        Me.setMainPanel(New SpreadWinDemo.undoredo())
                        Exit Select
                    Case "ビューポート"
                        Me.setMainPanel(New SpreadWinDemo.viewport())
                        Exit Select
                    Case "先頭セルの取得"
                        Me.setMainPanel(New SpreadWinDemo.gettoprowcol())
                        Exit Select
                End Select
            Case "スタイル"
                Select Case e.Node.Text
                    Case "斜め罫線"
                        Me.setMainPanel(New SpreadWinDemo.diagonalline())
                        Exit Select
                    Case "背景色の回転"
                        Me.setMainPanel(New SpreadWinDemo.backcolorrotation())
                        Exit Select
                    Case "フォント"
                        Me.setMainPanel(New SpreadWinDemo.fontsetting())
                        Exit Select
                    Case "背景色"
                        Me.setMainPanel(New SpreadWinDemo.backcolor())
                        Exit Select
                    Case "罫線"
                        Me.setMainPanel(New SpreadWinDemo.border())
                        Exit Select
                    Case "スキン"
                        Me.setMainPanel(New SpreadWinDemo.skin())
                        Exit Select
                    Case "条件付き書式"
                        Me.setMainPanel(New SpreadWinDemo.conditionalformat7())
                        Exit Select
                    Case "スパークライン"
                        Me.setMainPanel(New SpreadWinDemo.sparkline())
                        Exit Select
                    Case "パターンとグラデーション"
                        Me.setMainPanel(New SpreadWinDemo.patterngradient())
                        Exit Select
                End Select
            Case "選択"
                Select Case e.Node.Text
                    Case "ヘッダクリック時の選択範囲"
                        Me.setMainPanel(New SpreadWinDemo.cellspanselection())
                        Exit Select
                    Case "アクティブセルの色"
                        Me.setMainPanel(New SpreadWinDemo.paintactivecell())
                        Exit Select
                    Case "ヘッダのハイライト表示"
                        Me.setMainPanel(New SpreadWinDemo.paintselectionheader())
                        Exit Select
                    Case "フォーカス枠"
                        Me.setMainPanel(New SpreadWinDemo.focusindicator())
                        Exit Select
                    Case "選択範囲の作成"
                        Me.setMainPanel(New SpreadWinDemo.addselection())
                        Exit Select
                    Case "選択範囲の取得"
                        Me.setMainPanel(New SpreadWinDemo.getselectedrange())
                        Exit Select
                    Case "選択範囲のクリア"
                        Me.setMainPanel(New SpreadWinDemo.clearselection())
                        Exit Select
                    Case "選択のスタイル"
                        Me.setMainPanel(New SpreadWinDemo.selectionstyle())
                        Exit Select
                    Case "オペレーションモード"
                        Me.setMainPanel(New SpreadWinDemo.operationmode())
                        Exit Select
                    Case "選択のカスタマイズ"
                        Me.setMainPanel(New SpreadWinDemo.selectionpolicy())
                        Exit Select
                    Case "セル移動のスキップ"
                        Me.setMainPanel(New SpreadWinDemo.canfocus())
                        Exit Select
                End Select
            Case "セル型"
                Select Case e.Node.Text
                    Case "セル型"
                        Me.setMainPanel(New SpreadWinDemo.basiccelltype())
                        Exit Select
                    Case "セルの書式設定"
                        Me.setMainPanel(New SpreadWinDemo.cellformat())
                        Exit Select
                End Select
            Case "高度な入力支援（InputManセル）"
                Select Case e.Node.Text
                    Case "コンボボックス"
                        Me.setMainPanel(New SpreadWinDemo.gccombobox())
                        Exit Select
                    Case "マスク"
                        Me.setMainPanel(New SpreadWinDemo.gcmask())
                        Exit Select
                    Case "時間間隔"
                        Me.setMainPanel(New SpreadWinDemo.gctimespan())
                        Exit Select
                    Case "マス目"
                        Me.setMainPanel(New SpreadWinDemo.gccharmask())
                        Exit Select
                    Case "テキスト"
                        Me.setMainPanel(New SpreadWinDemo.gctextbox())
                        Exit Select
                    Case "日付"
                        Me.setMainPanel(New SpreadWinDemo.gcdatetime())
                        Exit Select
                    Case "数値"
                        Me.setMainPanel(New SpreadWinDemo.gcnumber())
                        Exit Select
                End Select
            Case "編集"
                Select Case e.Node.Text
                    Case "非表示の値を無視する集計"
                        Me.setMainPanel(New SpreadWinDemo.calcignorehidden())
                        Exit Select
                    Case "IMEモード"
                        Me.setMainPanel(New SpreadWinDemo.imemode())
                        Exit Select
                    Case "常時入力モード"
                        Me.setMainPanel(New SpreadWinDemo.editmodepermanent())
                        Exit Select
                    Case "上書き入力"
                        Me.setMainPanel(New SpreadWinDemo.editmodereplace())
                        Exit Select
                    Case "ロック"
                        Me.setMainPanel(New SpreadWinDemo.lockedcell())
                        Exit Select
                    Case "クリップボード"
                        Me.setMainPanel(New SpreadWinDemo.useclipboard())
                        Exit Select
                    Case "オートフィル"
                        Me.setMainPanel(New SpreadWinDemo.dragfill())
                        Exit Select
                    Case "オートフィルメニュー"
                        Me.setMainPanel(New SpreadWinDemo.dragfillmenu())
                        Exit Select
                    Case "ドラッグ移動"
                        Me.setMainPanel(New SpreadWinDemo.celldragdrop())
                        Exit Select
                    Case "ドラッグ＆ドロップ"
                        Me.setMainPanel(New SpreadWinDemo.dragdrop())
                        Exit Select
                    Case "オーバーフロー"
                        Me.setMainPanel(New SpreadWinDemo.celloverflow())
                        Exit Select
                    Case "データ検証"
                        Me.setMainPanel(New SpreadWinDemo.datavalidator())
                        Exit Select
                    Case "数式"
                        Me.setMainPanel(New SpreadWinDemo.formula())
                        Exit Select
                    Case "別シートセルの数式参照"
                        Me.setMainPanel(New SpreadWinDemo.differentsheetformula())
                        Exit Select
                    Case "独自の数式"
                        Me.setMainPanel(New SpreadWinDemo.customformula())
                        Exit Select
                    Case "配列数式"
                        Me.setMainPanel(New SpreadWinDemo.arrayformula())
                        Exit Select
                    Case "ヘッダ・フッタ上のデータ参照"
                        Me.setMainPanel(New SpreadWinDemo.headerfooterformula())
                        Exit Select
                    Case "数式テキストボックス"
                        Me.setMainPanel(New SpreadWinDemo.formulatextbox())
                        Exit Select
                    Case "ゴールシーク"
                        Me.setMainPanel(New SpreadWinDemo.goalseek())
                        Exit Select
                    Case "検索"
                        Me.setMainPanel(New SpreadWinDemo.search())
                        Exit Select
                    Case "数式のオートフォーマット"
                        Me.setMainPanel(New SpreadWinDemo.autoformat())
                        Exit Select
                    Case "動的配列数式"
                        Me.setMainPanel(New SpreadWinDemo.dynamicarray())
                        Exit Select
                End Select
            Case "ソート"
                Select Case e.Node.Text
                    Case "自動ソート"
                        Me.setMainPanel(New SpreadWinDemo.autosort())
                        Exit Select
                    Case "固定行を除いたソート"
                        Me.setMainPanel(New SpreadWinDemo.unsortedrows())
                        Exit Select
                    Case "セル範囲のソート"
                        Me.setMainPanel(New SpreadWinDemo.rangesort())
                        Exit Select
                    Case "独自のソートロジックでソート"
                        Me.setMainPanel(New SpreadWinDemo.customcomparison())
                        Exit Select
                End Select
            Case "フィルタリング"
                Select Case e.Node.Text
                    Case "ドロップダウンメニューからソート"
                        Me.setMainPanel(New SpreadWinDemo.filtersort())
                        Exit Select
                    Case "フィルタリングの自動実行"
                        Me.setMainPanel(New SpreadWinDemo.autofilter())
                        Exit Select
                    Case "非表示フィルタ"
                        Me.setMainPanel(New SpreadWinDemo.hiderowfilter())
                        Exit Select
                    Case "スタイルフィルタ"
                        Me.setMainPanel(New SpreadWinDemo.stylerowfilter())
                        Exit Select
                    Case "カスタムフィルタ"
                        Me.setMainPanel(New SpreadWinDemo.customfilter())
                        Exit Select
                    Case "条件フィルタ"
                        Me.setMainPanel(New SpreadWinDemo.filterbar())
                        Exit Select
                    Case "Excelフィルタリング"
                        Me.setMainPanel(New SpreadWinDemo.enhancedfilter())
                        Exit Select
                    Case "非フィルタリング行"
                        Me.setMainPanel(New SpreadWinDemo.unfilteredrows())
                        Exit Select
                    Case "セル範囲のフィルタリング"
                        Me.setMainPanel(New SpreadWinDemo.rangefilter())
                        Exit Select
                End Select
            Case "グループ化"
                Select Case e.Node.Text
                    Case "アウトラインのボタン位置"
                        Me.setMainPanel(New SpreadWinDemo.outlinesummary())
                        Exit Select
                    Case "Outlookスタイルグループ化"
                        Me.setMainPanel(New SpreadWinDemo.grouping())
                        Exit Select
                    Case "アウトライン"
                        Me.setMainPanel(New SpreadWinDemo.outline())
                        Exit Select
                End Select
            Case "スクロール"
                Select Case e.Node.Text
                    Case "テキスト位置の自動調整"
                        Me.setMainPanel(New SpreadWinDemo.cellcontentfloat())
                        Exit Select
                    Case "スクロール単位"
                        Me.setMainPanel(New SpreadWinDemo.scrollmode())
                        Exit Select
                    Case "スクロールバーの表示・非表示"
                        Me.setMainPanel(New SpreadWinDemo.scrollbarvisible())
                        Exit Select
                    Case "遅延スクロール"
                        Me.setMainPanel(New SpreadWinDemo.scrollbartrack())
                        Exit Select
                    Case "行・列の固定"
                        Me.setMainPanel(New SpreadWinDemo.frozenrowcol())
                        Exit Select
                End Select
            Case "データ連結"
                Select Case e.Node.Text
                    Case "バウンドデータ"
                        Me.setMainPanel(New SpreadWinDemo.databinding())
                        Exit Select
                    Case "アンバウンドデータ"
                        Me.setMainPanel(New SpreadWinDemo.dataunbinding())
                        Exit Select
                    Case "特定の列だけを連結"
                        Me.setMainPanel(New SpreadWinDemo.fieldbinding())
                        Exit Select
                    Case "行の追加"
                        Me.setMainPanel(New SpreadWinDemo.addrows())
                        Exit Select
                    Case "行の削除"
                        Me.setMainPanel(New SpreadWinDemo.removerows())
                        Exit Select
                    Case "新規行"
                        Me.setMainPanel(New SpreadWinDemo.newrows())
                        Exit Select
                    Case "階層表示"
                        Me.setMainPanel(New SpreadWinDemo.hierarchicalview())
                        Exit Select
                End Select
            Case "チャート"
                Select Case e.Node.Text
                    Case "チャートコントロール"
                        Me.setMainPanel(New SpreadWinDemo.chartcontrol())
                        Exit Select
                    Case "ツリーマップ"
                        Me.setMainPanel(New SpreadWinDemo.treemap())
                        Exit Select
                    Case "サンバースト"
                        Me.setMainPanel(New SpreadWinDemo.sunburst())
                        Exit Select
                    Case "ヒストグラム"
                        Me.setMainPanel(New SpreadWinDemo.histogram())
                        Exit Select
                    Case "パレート図"
                        Me.setMainPanel(New SpreadWinDemo.pareto())
                        Exit Select
                    Case "箱ひげ図"
                        Me.setMainPanel(New SpreadWinDemo.boxwhisker())
                        Exit Select
                    Case "ウォーターフォール"
                        Me.setMainPanel(New SpreadWinDemo.waterfall())
                        Exit Select
                    Case "じょうご"
                        Me.setMainPanel(New SpreadWinDemo.funnel())
                        Exit Select
                    Case "折れ線チャートの線種"
                        Me.setMainPanel(New SpreadWinDemo.linechartstyle())
                        Exit Select
                    Case "縦棒"
                        Me.setMainPanel(New SpreadWinDemo.columnchart())
                        Exit Select
                    Case "折れ線"
                        Me.setMainPanel(New SpreadWinDemo.linechart())
                        Exit Select
                    Case "円"
                        Me.setMainPanel(New SpreadWinDemo.piechart())
                        Exit Select
                    Case "横棒"
                        Me.setMainPanel(New SpreadWinDemo.barchart())
                        Exit Select
                    Case "面"
                        Me.setMainPanel(New SpreadWinDemo.areachart())
                        Exit Select
                    Case "散布図"
                        Me.setMainPanel(New SpreadWinDemo.xychart())
                        Exit Select
                    Case "バブル"
                        Me.setMainPanel(New SpreadWinDemo.bubblechart())
                        Exit Select
                    Case "株価"
                        Me.setMainPanel(New SpreadWinDemo.stockchart())
                        Exit Select
                    Case "XYZ散布図"
                        Me.setMainPanel(New SpreadWinDemo.xyzchart())
                        Exit Select
                    Case "ドーナツ"
                        Me.setMainPanel(New SpreadWinDemo.doughnutchart())
                        Exit Select
                    Case "レーダー"
                        Me.setMainPanel(New SpreadWinDemo.radarchart())
                        Exit Select
                    Case "ポーラ"
                        Me.setMainPanel(New SpreadWinDemo.polarchart())
                        Exit Select
                End Select
            Case "印刷"
                Select Case e.Node.Text
                    Case "白黒印刷"
                        Me.setMainPanel(New SpreadWinDemo.blackwhiteprint())
                        Exit Select
                    Case "印刷"
                        Me.setMainPanel(New SpreadWinDemo.printsheet())
                        Exit Select
                    Case "両面印刷"
                        Me.setMainPanel(New SpreadWinDemo.duplexprint())
                        Exit Select
                    Case "印刷プレビュー"
                        Me.setMainPanel(New SpreadWinDemo.printpreview())
                        Exit Select
                    Case "Excelライクプレビュー"
                        Me.setMainPanel(New SpreadWinDemo.excelprintpreview())
                        Exit Select
                    Case "印刷ページ設定"
                        Me.setMainPanel(New SpreadWinDemo.printsetting())
                        Exit Select
                    Case "ユーザー定義印刷"
                        Me.setMainPanel(New SpreadWinDemo.ownerprint())
                        Exit Select
                End Select
            Case "インポート／エクスポート"
                Select Case e.Node.Text
                    Case "PDFエクスポート"
                        Me.setMainPanel(New SpreadWinDemo.printpdf())
                        Exit Select
                    Case "csv（テキスト）ファイルの読込"
                        Me.setMainPanel(New SpreadWinDemo.opentextfile())
                        Exit Select
                    Case "csv（テキスト）ファイルへ保存"
                        Me.setMainPanel(New SpreadWinDemo.savetextfile())
                        Exit Select
                    Case "Excelファイルの読込"
                        Me.setMainPanel(New SpreadWinDemo.openexcelfile())
                        Exit Select
                    Case "Excelファイルへ保存"
                        Me.setMainPanel(New SpreadWinDemo.saveexcelfile())
                        Exit Select
                    Case "Excelファイルの読込と保存（Excel情報の維持）"
                        Me.setMainPanel(New SpreadWinDemo.keepexcelsetting())
                        Exit Select
                End Select
            Case "マルチタッチ機能"
                Select Case e.Node.Text
                    Case "タッチツールバー"
                        Me.setMainPanel(New SpreadWinDemo.touchstrip())
                        Exit Select
                    Case "選択グリッパー"
                        Me.setMainPanel(New SpreadWinDemo.touchselection())
                        Exit Select
                    Case "タッチスクロール"
                        Me.setMainPanel(New SpreadWinDemo.touchscroll())
                        Exit Select
                    Case "ドロップダウンリストの拡大表示"
                        Me.setMainPanel(New SpreadWinDemo.touchdropdownscale())
                        Exit Select
                    Case "タッチキーボード"
                        Me.setMainPanel(New SpreadWinDemo.touchkeyboard())
                        Exit Select
                End Select
            Case "シェイプオブジェクト"
                Select Case e.Node.Text
                    Case "シェイプ"
                        Me.setMainPanel(New SpreadWinDemo.addshape())
                        Exit Select
                    Case "カメラシェイプ"
                        Me.setMainPanel(New SpreadWinDemo.camerashape())
                        Exit Select
                    Case "拡張シェイプエンジン"
                        Me.setMainPanel(New SpreadWinDemo.enhancedshape())
                        Exit Select
                End Select
        End Select
    End Sub

    Private Sub treemenu_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treemenu.AfterCollapse
        treemenu.SelectedNode = Nothing
    End Sub

#Region "ページ移動処理"
    Private Sub setMainPanel(ByVal ucontrol As FirstViewPage)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub setMainPanel(ByVal ucontrol As DemoBase)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
    Private Sub setMainPanel(ByVal ucontrol As DemoBase_settings)
        ucontrol.Dock = DockStyle.Fill
        Me.splitContainer1.Panel2.Controls.Add(ucontrol)
        If Me.splitContainer1.Panel2.Controls.Count > 1 Then
            Me.splitContainer1.Panel2.Controls.RemoveAt(0)
        End If
    End Sub
#End Region

#Region "リンク処理"

    Private Sub firstView_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles firstView.LinkClicked
        ' ファーストビューに戻る
        Me.setMainPanel(New FirstViewPage())
        treemenu.SelectedNode = Nothing
        treemenu.CollapseAll()
    End Sub

#End Region

#Region "検索機能"
    ' 検索ノードのコレクション               
    Dim myNode As New ArrayList()

    Private Sub searchtext_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchtext.TextChanged
        ' 検索結果(searchlist)をクリア
        searchlist.Items.Clear()
        myNode.Clear()

        If searchtext.Text = "" Then
            Return
        End If

        ' ツリーコントロールのノードを取得
        For Each node As TreeNode In GetAllNodes(treemenu.Nodes)
            If node.Parent IsNot Nothing Then
                Dim s As String = node.Text
                If node.Tag IsNot Nothing Then
                    s += node.Tag.ToString()
                End If

                ' 検索ワードを含むノードのみ抽出
                If s.Contains(searchtext.Text) Then
                    myNode.Add(node)
                    searchlist.Items.Add(node.Text)
                End If
            End If
        Next
    End Sub

    Private Function GetAllNodes(ByVal Nodes As TreeNodeCollection) As ArrayList
        Dim Ar As New ArrayList()
        ' ツリーコントロールのノードを取得
        For Each Node As TreeNode In Nodes
            Ar.Add(Node)
            If Node.GetNodeCount(False) > 0 Then
                Ar.AddRange(GetAllNodes(Node.Nodes))
            End If
        Next
        Return Ar
    End Function

    Private Sub searchlist_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchlist.SelectedIndexChanged
        ' リストボックスで選択されたページを表示
        treemenu.SelectedNode = DirectCast(myNode(searchlist.SelectedIndex), TreeNode)
    End Sub

    Private Sub MyTabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' ツリービューにフォーカスを設定して選択状態にする
        If MyTabControl1.SelectedIndex = 0 Then
            treemenu.[Select]()
        End If
    End Sub
#End Region

End Class


' ツリービューのカスタマイズ
Class MyTreeView
    Inherits TreeView

    Protected Overrides Sub OnNodeMouseClick(e As TreeNodeMouseClickEventArgs)
        '  ツリービューのシングルクリックでの開閉
        If e.Node IsNot Nothing Then
            If HitTest(e.Location).Location = TreeViewHitTestLocations.Label OrElse HitTest(e.Location).Location = TreeViewHitTestLocations.Image Then
                e.Node.Toggle()
            End If
        End If

        ' 既定の動作
        MyBase.OnNodeMouseClick(e)
    End Sub
End Class

Class MyTabControl
    Inherits TabControl

    ' リサイズ途中のちらつきを抑える処理
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class
