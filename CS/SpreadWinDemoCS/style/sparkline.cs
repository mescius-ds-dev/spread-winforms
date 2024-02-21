using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.style
{
    public partial class sparkline : SpreadWinDemo.DemoBase
    {
        public sparkline()
        {
            InitializeComponent();

            // シート設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            // 行列数の設定
            sheet.RowCount = 32;
            sheet.ColumnCount = 13;
            sheet.RowHeader.ColumnCount = 2;

            // 列幅の設定
            sheet.Columns[0].Width = 120;
            sheet.Columns[1, 12].Width = 40;
            sheet.RowHeader.Columns[0].Width = 50;
            sheet.RowHeader.Columns[1].Width = 100;

            // 行の高さの設定
            sheet.Rows.Default.Height = 30;

            // 1列目を固定
            sheet.FrozenColumnCount = 1;

            // テストデータの設定
            sheet.ColumnHeaderAutoText = FarPoint.Win.Spread.HeaderAutoText.Blank;
            for (int i = 1; i < sheet.ColumnCount; i++)
            {
                sheet.ColumnHeader.Cells[0, i].Value = i.ToString() + "月";
            }

            sheet.RowHeaderAutoText = FarPoint.Win.Spread.HeaderAutoText.Blank;            
            for (int i = 0; i < sheet.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    sheet.RowHeader.Cells[i, 1].Value = "平均気温( °C)";
                    sheet.RowHeader.Cells[i, 0].RowSpan = 2;
                }
                else
                {
                    sheet.RowHeader.Cells[i, 1].Value = "降水量(mm)";
                }                
            }
            sheet.RowHeader.Cells[0, 0].Value = "札幌";
            sheet.RowHeader.Cells[2, 0].Value = "仙台";
            sheet.RowHeader.Cells[4, 0].Value = "新潟";
            sheet.RowHeader.Cells[6, 0].Value = "東京";
            sheet.RowHeader.Cells[8, 0].Value = "長野";
            sheet.RowHeader.Cells[10, 0].Value = "静岡";
            sheet.RowHeader.Cells[12, 0].Value = "名古屋";
            sheet.RowHeader.Cells[14, 0].Value = "大阪";
            sheet.RowHeader.Cells[16, 0].Value = "京都";
            sheet.RowHeader.Cells[18, 0].Value = "広島";
            sheet.RowHeader.Cells[20, 0].Value = "高知";
            sheet.RowHeader.Cells[22, 0].Value = "山口";
            sheet.RowHeader.Cells[24, 0].Value = "福岡";
            sheet.RowHeader.Cells[26, 0].Value = "長崎";
            sheet.RowHeader.Cells[28, 0].Value = "鹿児島";
            sheet.RowHeader.Cells[30, 0].Value = "那覇";

            sheet.SetClip(0, 1, 1, 12, "-4.7\t-4\t0\t6.3\t11.3\t17.6\t22.5\t23.1\t18.8\t12.9\t6.3\t0.8");
            sheet.SetClip(1, 1, 1, 12, "101.5\t117\t108\t115\t61.5\t62\t54.5\t183.5\t173\t131\t116\t124");
            sheet.SetClip(2, 1, 1, 12, "0.7\t1.1\t5.8\t10.2\t14.4\t19\t22.2\t25.6\t21.9\t16.7\t9.6\t4.7");
            sheet.SetClip(3, 1, 1, 12, "37\t18.5\t3\t118.5\t27.5\t92\t257.5\t88.5\t210.5\t179.5\t14\t65");
            sheet.SetClip(4, 1, 1, 12, "1.8\t1.5\t6\t10.1\t16.3\t22.1\t25.1\t26.9\t22.9\t18.3\t9.8\t5.2");
            sheet.SetClip(5, 1, 1, 12, "148.5\t93.5\t93.5\t142\t50\t93.5\t413\t264.5\t165\t176\t416\t271.5");
            sheet.SetClip(6, 1, 1, 12, "5.5\t6.2\t12.1\t15.2\t19.8\t22.9\t27.3\t29.2\t25.2\t19.8\t13.5\t8.3");
            sheet.SetClip(7, 1, 1, 12, "70\t30\t44.5\t283\t56\t159\t115.5\t99\t231.5\t440\t26\t59.5");
            sheet.SetClip(8, 1, 1, 12, "-1.1\t-0.7\t5.6\t9.5\t16.2\t21.2\t24.7\t25.4\t21.2\t16.4\t7.5\t2");
            sheet.SetClip(9, 1, 1, 12, "48.5\t46.5\t19.5\t75\t33\t126.5\t99\t234.5\t221\t148\t29.5\t56.5");
            sheet.SetClip(10, 1, 1, 12, "5.7\t7.3\t13.3\t15.4\t19.2\t22.6\t26.4\t28.4\t25.4\t21.1\t13.1\t8.2");
            sheet.SetClip(11, 1, 1, 12, "80.5\t120\t101.5\t269\t181\t163.5\t128\t89.5\t227\t298\t104.5\t59.5");
            sheet.SetClip(12, 1, 1, 12, "4\t4.6\t10.5\t13.8\t19.4\t23.6\t28.1\t29.3\t24.9\t20.2\t11.5\t6.4");
            sheet.SetClip(13, 1, 1, 12, "51.5\t68.5\t54\t130.5\t63.5\t148.5\t186.5\t136\t280\t236\t51\t57.5");
            sheet.SetClip(14, 1, 1, 12, "5.2\t5.6\t10.7\t14.3\t19.8\t24.3\t28.5\t30\t25.1\t20.8\t12.9\t7.8");
            sheet.SetClip(15, 1, 1, 12, "38.5\t92.5\t92\t108\t44\t266\t50\t128\t258.5\t210.5\t80.5\t49.5");
            sheet.SetClip(16, 1, 1, 12, "3.9\t4.5\t9.7\t13.4\t19.2\t24.1\t28\t29.2\t24.3\t20\t11.5\t6.3");
            sheet.SetClip(17, 1, 1, 12, "41\t96\t65.5\t109.5\t38\t173.5\t140\t102\t358\t217.5\t50\t59.5");
            sheet.SetClip(18, 1, 1, 12, "4.4\t6\t10.7\t13.5\t19.7\t24\t28.3\t29.5\t24.6\t19.9\t11.9\t6.5");
            sheet.SetClip(19, 1, 1, 12, "43.5\t93.5\t90\t100.5\t125.5\t329.5\t175.5\t238\t224.5\t295\t58.5\t46.5");
            sheet.SetClip(20, 1, 1, 12, "5.8\t7.8\t12.7\t14.8\t19.9\t23.2\t28.1\t29\t24.9\t20.7\t12.9\t7.4");
            sheet.SetClip(21, 1, 1, 12, "39\t132.5\t82.5\t243\t177.5\t306.5\t113.5\t85.5\t377.5\t579.5\t94.5\t95.5");
            sheet.SetClip(22, 1, 1, 12, "3.8\t5.6\t10\t12.7\t19.1\t23.2\t27.6\t28.6\t23.6\t18.9\t11\t5.5");
            sheet.SetClip(23, 1, 1, 12, "63.5\t107\t89\t153.5\t143.5\t357\t508\t325\t173.5\t203\t79\t65");
            sheet.SetClip(24, 1, 1, 12, "6.1\t7.8\t12.3\t14.7\t20.3\t23.7\t30\t30\t25.2\t20.7\t13.4\t8.1");
            sheet.SetClip(25, 1, 1, 12, "57.5\t81.5\t56.5\t108\t37\t268.5\t134\t501.5\t133\t227.5\t119.5\t77");
            sheet.SetClip(26, 1, 1, 12, "6.3\t8.1\t12.2\t14.6\t20\t23.7\t28.3\t29.3\t25.1\t20.8\t13.3\t8.3");
            sheet.SetClip(27, 1, 1, 12, "37.5\t148.5\t91.5\t148.5\t126\t224\t10.5\t198.5\t160\t249.5\t210.5\t78.5");
            sheet.SetClip(28, 1, 1, 12, "7.9\t10.3\t14.1\t16.3\t21.4\t24.6\t29.4\t30\t26.8\t22.5\t14.6\t9.3");
            sheet.SetClip(29, 1, 1, 12, "70\t199.5\t80.5\t120.5\t54.5\t426\t16.5\t93\t343.5\t154\t114.5\t105");
            sheet.SetClip(30, 1, 1, 12, "17\t18.6\t20.4\t20.6\t23.7\t27.9\t29.4\t29.6\t28.3\t25.3\t21.3\t17.3");
            sheet.SetClip(31, 1, 1, 12, "100\t75\t140.5\t202.5\t602.5\t105\t4.5\t212\t178\t200\t121\t130");

            // スパークライン（折れ線）の設定
            FarPoint.Win.Spread.ExcelSparklineGroup esg1 = new FarPoint.Win.Spread.ExcelSparklineGroup(new FarPoint.Win.Spread.ExcelSparklineSetting(), FarPoint.Win.Spread.SparklineType.Line);
            FarPoint.Win.Spread.ExcelSparklineSetting ex1 = new FarPoint.Win.Spread.ExcelSparklineSetting();
            ex1.ManualMax = 30;
            ex1.ManualMin = -5;
            ex1.SeriesColor = System.Drawing.Color.Green;
            esg1.Setting = ex1;

            for (int i = 0; i < sheet.RowCount; i = i + 2)
            {
                FarPoint.Win.Spread.ExcelSparkline es1 = new FarPoint.Win.Spread.ExcelSparkline(i, 0, sheet, new FarPoint.Win.Spread.Model.CellRange(i, 1, 1, 12));
                esg1.Add(es1);
            }

            sheet.SparklineContainer.Add(esg1);

            // スパークライン（縦棒）の設定
            FarPoint.Win.Spread.ExcelSparklineGroup esg2 = new FarPoint.Win.Spread.ExcelSparklineGroup(new FarPoint.Win.Spread.ExcelSparklineSetting(), FarPoint.Win.Spread.SparklineType.Column);
            FarPoint.Win.Spread.ExcelSparklineSetting ex2 = new FarPoint.Win.Spread.ExcelSparklineSetting();
            ex2.ManualMax = 300;
            ex2.ManualMin = 0;
            ex2.SeriesColor = System.Drawing.Color.CornflowerBlue;
            esg2.Setting = ex2;


            for (int i = 1; i < sheet.RowCount; i = i + 2)
            {
                FarPoint.Win.Spread.ExcelSparkline es2 = new FarPoint.Win.Spread.ExcelSparkline(i, 0, sheet, new FarPoint.Win.Spread.Model.CellRange(i, 1, 1, 12));
                esg2.Add(es2);
            }           

            sheet.SparklineContainer.Add(esg2);
        }
    }
}
