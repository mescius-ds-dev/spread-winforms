using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.databind
{
    public partial class hierarchicalview : SpreadWinDemo.DemoBase
    {
        DataSet myDataSet = new DataSet();

        public hierarchicalview()
        {
            InitializeComponent();

            // データ作成
            InitData();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);

            fpSpread1.ChildViewCreated += new FarPoint.Win.Spread.ChildViewCreatedEventHandler(fpSpread1_ChildViewCreated);
        }        

        private void InitData()
        {
            System.Data.DataTable thisyear, lastyear;

            // 当年度データ
            thisyear = myDataSet.Tables.Add("thisyear");
            thisyear.Columns.AddRange(new DataColumn[] { new DataColumn("製品ID",Type.GetType("System.String")), 
                                                    new DataColumn("製品種別", Type.GetType("System.String")), 
                                                    new DataColumn("製品名", Type.GetType("System.String")), 
                                                    new DataColumn("当年第１Ｑ", Type.GetType("System.Int32")) ,
                                                    new DataColumn("当年第２Ｑ", Type.GetType("System.Int32")) ,
                                                    new DataColumn("当年第３Ｑ", Type.GetType("System.Int32")) ,
                                                    new DataColumn("当年第４Ｑ", Type.GetType("System.Int32")) 
                                                    });

            thisyear.Rows.Add(new Object[] { "10001", "乳製品", "酪農ミルク", 5500, 5000, 4500, 6000 });
            thisyear.Rows.Add(new Object[] { "20001", "清涼飲料水", "いよかんドリンク", 1000, 3000, 2700, 2700 });
            thisyear.Rows.Add(new Object[] { "20002", "清涼飲料水", "ぶどうジュース", 3000, 3500, 4800, 4800 });
            thisyear.Rows.Add(new Object[] { "20003", "清涼飲料水", "マンゴードリンク", 2000, 1000, 500, 1050 });
            thisyear.Rows.Add(new Object[] { "30001", "ビール", "激辛ビール", 5500, 8000, 8500, 10000 });
            thisyear.Rows.Add(new Object[] { "30002", "ビール", "モルトビール", 3000, 3500, 2780, 4000 });
            thisyear.Rows.Add(new Object[] { "20004", "清涼飲料水", "ぶどうの街", 500, 300, 200, 700 });
            thisyear.Rows.Add(new Object[] { "30003", "ビール", "オリエントの村", 8000, 9500, 9580, 9000 });
            thisyear.Rows.Add(new Object[] { "40002", "焼酎", "吟醸 ほめごろし", 6000, 7000, 9000, 9500 });
            thisyear.Rows.Add(new Object[] { "40003", "焼酎", "大吟醸 オリエント", 1000, 5000, 6000, 5000 });
            thisyear.Rows.Add(new Object[] { "40005", "焼酎", "麦焼酎 ちこちこ", 1000, 1500, 1200, 1258 });
            thisyear.Rows.Add(new Object[] { "10002", "乳製品", "酪農ミルク（低脂肪）", 501, 202, 380, 456 });

            lastyear = myDataSet.Tables.Add("lastyear");
            lastyear.Columns.AddRange(new DataColumn[] { new DataColumn("製品ID",Type.GetType("System.String")), 
                                                    new DataColumn("製品種別", Type.GetType("System.String")), 
                                                    new DataColumn("製品名", Type.GetType("System.String")), 
                                                    new DataColumn("前年第１Ｑ", Type.GetType("System.Int32")) ,
                                                    new DataColumn("前年第２Ｑ", Type.GetType("System.Int32")) ,
                                                    new DataColumn("前年第３Ｑ", Type.GetType("System.Int32")) ,
                                                    new DataColumn("前年第４Ｑ", Type.GetType("System.Int32")) 
                                                    });

            lastyear.Rows.Add(new Object[] { "10001", "乳製品", "酪農ミルク", 2000, 1000, 4023, 5230 });
            lastyear.Rows.Add(new Object[] { "20001", "清涼飲料水", "いよかんドリンク", 1050, 2000, 2500, 2600 });
            lastyear.Rows.Add(new Object[] { "20002", "清涼飲料水", "ぶどうジュース", 3600, 2400, 1200, 1600 });
            lastyear.Rows.Add(new Object[] { "20003", "清涼飲料水", "マンゴードリンク", 1600, 1250, 356, 1020 });
            lastyear.Rows.Add(new Object[] { "30001", "ビール", "激辛ビール", 5600, 5000, 2500, 1900 });
            lastyear.Rows.Add(new Object[] { "30002", "ビール", "モルトビール", 1000, 2500, 2760, 2000 });
            lastyear.Rows.Add(new Object[] { "20004", "清涼飲料水", "ぶどうの街", 500, 300, 200, 700 });
            lastyear.Rows.Add(new Object[] { "30003", "ビール", "オリエントの村", 1000, 500, 2580, 1230 });
            lastyear.Rows.Add(new Object[] { "40002", "焼酎", "吟醸 ほめごろし", 5000, 7589, 5000, 6895 });
            lastyear.Rows.Add(new Object[] { "40003", "焼酎", "大吟醸 オリエント", 800, 3568, 4521, 3564 });
            lastyear.Rows.Add(new Object[] { "40005", "焼酎", "麦焼酎 ちこちこ", 1000, 1512, 1212, 1058 });
            lastyear.Rows.Add(new Object[] { "10002", "乳製品", "酪農ミルク（低脂肪）", 301, 102, 280, 256 });

            // リレーションシップを設定します。
            myDataSet.Relations.Add("prddata", thisyear.Columns["製品ID"], lastyear.Columns["製品ID"]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            //データ連結            
            sheet.DataSource = myDataSet;

            // 列幅の設定
            sheet.Columns[0].Width = 50;
            sheet.Columns[1].Width = 100;
            sheet.Columns[2].Width = 140;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 80;
            sheet.Columns[5].Width = 80;
            sheet.Columns[6].Width = 80;
        }

        void fpSpread1_ChildViewCreated(object sender, FarPoint.Win.Spread.ChildViewCreatedEventArgs e)
        {
            FarPoint.Win.Spread.SheetView sv = e.SheetView;

            switch (e.SheetView.ParentRelationName)
            {
                case "prddata":
                    sv.Columns[0].Visible = false;
                    sv.Columns[1].Visible = false;
                    sv.Columns[2].Visible = false;

                    sv.RowHeader.AutoText = FarPoint.Win.Spread.HeaderAutoText.Blank;
                    sv.RowHeader.Columns[0].Width = 290;
                    sv.Columns[3].Width = 80;
                    sv.Columns[4].Width = 80;
                    sv.Columns[5].Width = 80;
                    sv.Columns[6].Width = 80;

                    sv.RowHeader.Cells[0, 0].Text = "前年同期";
                    sv.ColumnHeader.Visible = false;
                    sv.DefaultStyle.Locked = true;

                    sv.DefaultStyle.BackColor = System.Drawing.Color.LightYellow;
                    sv.SheetCornerStyle.BackColor = System.Drawing.Color.LightYellow;
                    sv.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.LightYellow;
                    sv.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.LightYellow;

                    break;
            }
        }
    }
}
