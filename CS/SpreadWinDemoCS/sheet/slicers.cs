using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.sheet
{
    public partial class slicers : SpreadWinDemo.DemoBase
    {
        public slicers()
        {
            InitializeComponent();

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // フォントの設定
            GrapeCity.Spreadsheet.IStyle normalStyle = workbook.Styles[GrapeCity.Spreadsheet.BuiltInStyle.Normal];
            normalStyle.Font.Name = "メイリオ";
            normalStyle.Font.Size = 9;

            // 拡張シェイプエンジンを有効
            fpSpread1.Features.EnhancedShapeEngine = true;

            // テストデータの設定
            fpSpread1.ActiveSheet.SetClip(0, 0, 1, 8, "顧客番号\t顧客名\t地区\t商品名\t商品分類\t価格\t数量");
            fpSpread1.ActiveSheet.SetClip(1, 0, 1, 7, "1001\t亀甲　滋万\t関東\tコピー用紙\t紙製品\t3500\t8");
            fpSpread1.ActiveSheet.SetClip(2, 0, 1, 7, "1002\t寒田　希世\t関東\tカラーコピー用紙\t紙製品\t4500\t5");
            fpSpread1.ActiveSheet.SetClip(3, 0, 1, 7, "1003\t小和瀬　澄\t関東\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(4, 0, 1, 7, "1004\t宇夫　早余子\t関東\t宛名ラベル\t紙製品\t2800\t10");
            fpSpread1.ActiveSheet.SetClip(5, 0, 1, 7, "1005\t宇田津　聖智\t関東\tカラーメモシール\t事務用品\t2800\t6");
            fpSpread1.ActiveSheet.SetClip(6, 0, 1, 7, "1006\t茨城　昭児\t関東\tエアークッション材\t梱包材\t2800\t4");
            fpSpread1.ActiveSheet.SetClip(7, 0, 1, 7, "1007\t石ヶ休　椎茄\t関東\t段ボール箱（大）\t梱包材\t2900\t10");
            fpSpread1.ActiveSheet.SetClip(8, 0, 1, 7, "1008\t赤司　恵治郎\t関東\tコピー用紙\t紙製品\t3500\t6");
            fpSpread1.ActiveSheet.SetClip(9, 0, 1, 7, "1009\t小橋　仰一\t関東\t宛名ラベル\t紙製品\t2800\t5");
            fpSpread1.ActiveSheet.SetClip(10, 0, 1, 7, "1010\t一重　公大\t関東\tCD DVDラベル\t紙製品\t5000\t1");
            fpSpread1.ActiveSheet.SetClip(11, 0, 1, 7, "1011\t稲並　勝五郎\t中部\tコピー用紙\t紙製品\t3500\t6");
            fpSpread1.ActiveSheet.SetClip(12, 0, 1, 7, "1012\t穎原　紀代一\t中部\tCD DVDラベル\t紙製品\t5000\t4");
            fpSpread1.ActiveSheet.SetClip(13, 0, 1, 7, "1013\t安士　定助\t中部\tクリアケース\t事務用品\t2500\t4");
            fpSpread1.ActiveSheet.SetClip(14, 0, 1, 7, "1014\t今重　邦三郎\t中部\t軽量バインダー\t事務用品\t3500\t4");
            fpSpread1.ActiveSheet.SetClip(15, 0, 1, 7, "1015\t魚見　秀里\t中部\tエアークッション材\t梱包材\t2800\t7");
            fpSpread1.ActiveSheet.SetClip(16, 0, 1, 7, "1016\t小佐井　幸仁\t中部\tクリアケース\t事務用品\t2500\t1");
            fpSpread1.ActiveSheet.SetClip(17, 0, 1, 7, "1017\t大高　吉左右\t中部\tカラーメモシール\t事務用品\t2800\t1");
            fpSpread1.ActiveSheet.SetClip(18, 0, 1, 7, "1018\t上垣内　正名\t関西\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(19, 0, 1, 7, "1019\t金曽　憙佳\t関西\tカラーコピー用紙\t紙製品\t4500\t5");
            fpSpread1.ActiveSheet.SetClip(20, 0, 1, 7, "1020\t吉光　定太郎\t関西\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(21, 0, 1, 7, "1021\t小曾　三三\t関西\t宛名ラベル\t紙製品\t2800\t2");
            fpSpread1.ActiveSheet.SetClip(22, 0, 1, 7, "1022\t貴俵　健有\t関西\tエアークッション材\t梱包材\t2800\t10");
            fpSpread1.ActiveSheet.SetClip(23, 0, 1, 7, "1023\t蔭島　太郎\t関西\t段ボール箱（小）\t梱包材\t1900\t10");
            fpSpread1.ActiveSheet.SetClip(24, 0, 1, 7, "1024\t金賀　憲逸\t関西\t段ボール箱（大）\t梱包材\t2900\t10");
            fpSpread1.ActiveSheet.SetClip(25, 0, 1, 7, "1025\t楠下　サヤ子\t関東\tコピー用紙\t紙製品\t3500\t8");
            fpSpread1.ActiveSheet.SetClip(26, 0, 1, 7, "1026\t角本　好七\t関東\tカラーコピー用紙\t紙製品\t4500\t4");
            fpSpread1.ActiveSheet.SetClip(27, 0, 1, 7, "1027\t蒲沢　宗英\t関東\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(28, 0, 1, 7, "1028\t久角　堅市\t関東\t宛名ラベル\t紙製品\t2800\t10");
            fpSpread1.ActiveSheet.SetClip(29, 0, 1, 7, "1029\t郷田　圭亮\t関東\tカラーメモシール\t事務用品\t2800\t6");
            fpSpread1.ActiveSheet.SetClip(30, 0, 1, 7, "1030\t倉員　恵孝\t関東\tエアークッション材\t梱包材\t2800\t4");
            fpSpread1.ActiveSheet.SetClip(31, 0, 1, 7, "1031\t饒村　九三子\t関東\t段ボール箱（大）\t梱包材\t2900\t11");
            fpSpread1.ActiveSheet.SetClip(32, 0, 1, 7, "1032\t潮屋　恵勇\t関東\tコピー用紙\t紙製品\t3500\t6");
            fpSpread1.ActiveSheet.SetClip(33, 0, 1, 7, "1033\t多留　光八\t関東\t宛名ラベル\t紙製品\t2800\t5");
            fpSpread1.ActiveSheet.SetClip(34, 0, 1, 7, "1034\t茶本　将司\t中部\tコピー用紙\t紙製品\t3500\t6");
            fpSpread1.ActiveSheet.SetClip(35, 0, 1, 7, "1035\t大部　悟作\t中部\tCD DVDラベル\t紙製品\t5000\t4");
            fpSpread1.ActiveSheet.SetClip(36, 0, 1, 7, "1036\t立井　健七\t中部\tクリアケース\t事務用品\t2500\t4");
            fpSpread1.ActiveSheet.SetClip(37, 0, 1, 7, "1037\t高橋　賢一朗\t中部\t軽量バインダー\t事務用品\t3500\t5");
            fpSpread1.ActiveSheet.SetClip(38, 0, 1, 7, "1038\t請川　公平\t中部\tエアークッション材\t梱包材\t2800\t7");
            fpSpread1.ActiveSheet.SetClip(39, 0, 1, 7, "1039\t椹木　公己\t関西\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(40, 0, 1, 7, "1040\t田底　清策\t関西\tカラーコピー用紙\t紙製品\t4500\t5");
            fpSpread1.ActiveSheet.SetClip(41, 0, 1, 7, "1041\t調　佐之助\t関西\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(42, 0, 1, 7, "1042\t垰野　久仁弘\t関西\t宛名ラベル\t紙製品\t2800\t3");
            fpSpread1.ActiveSheet.SetClip(43, 0, 1, 7, "1043\t麝島　冴\t関西\tエアークッション材\t梱包材\t2800\t10");
            fpSpread1.ActiveSheet.SetClip(44, 0, 1, 7, "1044\t砂古口　祥公\t関西\t段ボール箱（小）\t梱包材\t1900\t10");
            fpSpread1.ActiveSheet.SetClip(45, 0, 1, 7, "1045\t桜谷　欣重\t関西\t段ボール箱（大）\t梱包材\t2900\t10");
            fpSpread1.ActiveSheet.SetClip(46, 0, 1, 7, "1046\t赤野　茂貞\t関東\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(47, 0, 1, 7, "1047\t栄永　貢右\t関東\tカラーコピー用紙\t紙製品\t4500\t5");
            fpSpread1.ActiveSheet.SetClip(48, 0, 1, 7, "1048\t鷹木　サツ\t関東\tコピー用紙\t紙製品\t3500\t10");
            fpSpread1.ActiveSheet.SetClip(49, 0, 1, 7, "1049\t澤海　剛義\t関東\t宛名ラベル\t紙製品\t2800\t10");
            fpSpread1.ActiveSheet.SetClip(50, 0, 1, 7, "1050\t外江　昊司\t関東\tカラーメモシール\t事務用品\t2800\t6");

            // テーブルの追加
            GrapeCity.Spreadsheet.ITable table = workbook.ActiveSheet.Tables.Add("A1:G51", GrapeCity.Spreadsheet.YesNoGuess.Yes);

            // 列インデックスを使用してSlicerCacheを追加
            GrapeCity.Spreadsheet.Slicers.ISlicerCache slicerCache = workbook.SlicerCaches.Add(table, 2, "slicerCache");

            //// SlicerCacheにスライサーを追加
            GrapeCity.Spreadsheet.Slicers.ISlicer slicer = slicerCache.Slicers.Add(workbook.ActiveSheet, "slicer", "地区", 200, 150, 200, 200);

            // 列名を使用してSlicerCacheを追加
            GrapeCity.Spreadsheet.Slicers.ISlicerCache slicerCache2 = workbook.SlicerCaches.Add(table, "商品分類", "slicerCache2");

            // SlicerCacheにスライサーを追加
            GrapeCity.Spreadsheet.Slicers.ISlicer slicer2 = slicerCache2.Slicers.Add(workbook.ActiveSheet, "slicer2", "商品分類", 410, 150, 200, 200);
        }
    }
}
