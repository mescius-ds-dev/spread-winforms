using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.rowcolcell
{
    public partial class headervisible : SpreadWinDemo.DemoBase
    {
        public headervisible()
        {
            InitializeComponent();

            // シートの設定
            InitSpreadStyles(fpSpread1.Sheets[0]);
        }

        private void InitSpreadStyles(FarPoint.Win.Spread.SheetView sheet)
        {
            // 行ヘッダ非表示
            sheet.RowHeader.Visible = false;

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int days = DateTime.DaysInMonth(year, month);

            sheet.RowCount = days;
            sheet.ColumnCount = 9;

            // 列幅の設定
            sheet.Columns[0].Width = 80;
            sheet.Columns[1].Width = 40;
            sheet.Columns[2].Width = 50;
            sheet.Columns[3].Width = 70;
            sheet.Columns[4].Width = 70;
            sheet.Columns[5].Width = 70;
            sheet.Columns[6].Width = 70;
            sheet.Columns[7].Width = 70;
            sheet.Columns[8].Width = 170;

            // ヘッダ        
            sheet.ColumnHeader.Cells[0, 0].Text = "日付";
            sheet.ColumnHeader.Cells[0, 1].Text = "曜日";
            sheet.ColumnHeader.Cells[0, 2].Text = "シフト";
            sheet.ColumnHeader.Cells[0, 3].Text = "出勤時間";
            sheet.ColumnHeader.Cells[0, 4].Text = "退勤時間";
            sheet.ColumnHeader.Cells[0, 5].Text = "休憩時間";
            sheet.ColumnHeader.Cells[0, 6].Text = "実働時間";
            sheet.ColumnHeader.Cells[0, 7].Text = "時間外";
            sheet.ColumnHeader.Cells[0, 8].Text = "備考";            

            for (int i = 1; i < days + 1; i++)
            {
                DateTime day = new DateTime(year, month, i);

                sheet.Cells[i - 1, 0].Value = day.ToString("yyyy/MM/dd");
                sheet.Cells[i - 1, 1].Value = day.ToString("ddd");
                if (i % 7 == 0 || i % 7 == 3)
                {
                    sheet.Cells[i - 1, 2].Value = "公休";
                }
                else
                {
                    sheet.Cells[i - 1, 2].Value = "S1";
                }

                if (day.ToString("ddd").Equals("土"))
                {
                    sheet.Rows[i - 1].BackColor = System.Drawing.Color.AliceBlue;
                }
                else if (day.ToString("ddd").Equals("日"))
                {
                    sheet.Rows[i - 1].BackColor = System.Drawing.Color.MistyRose;
                }

                // 出勤
                sheet.Cells[0, 3].Value = "09:00"; sheet.Cells[3, 3].Value = "09:00"; sheet.Cells[5, 3].Value = "09:00";
                sheet.Cells[1, 3].Value = "09:00"; sheet.Cells[4, 3].Value = "09:00"; sheet.Cells[7, 3].Value = "09:00";
                // 退勤
                sheet.Cells[0, 4].Value = "18:00"; sheet.Cells[3, 4].Value = "18:00"; sheet.Cells[5, 4].Value = "19:00";
                sheet.Cells[1, 4].Value = "18:00"; sheet.Cells[4, 4].Value = "18:00"; sheet.Cells[7, 4].Value = "19:30";
                // 休憩
                sheet.Cells[0, 5].Value = "01:00"; sheet.Cells[3, 5].Value = "01:00"; sheet.Cells[5, 5].Value = "01:00";
                sheet.Cells[1, 5].Value = "01:00"; sheet.Cells[4, 5].Value = "01:00"; sheet.Cells[7, 5].Value = "01:00";
                // 実働
                sheet.Cells[0, 6].Value = "08:00"; sheet.Cells[3, 6].Value = "08:00"; sheet.Cells[5, 6].Value = "09:00";
                sheet.Cells[1, 6].Value = "08:00"; sheet.Cells[4, 6].Value = "08:00"; sheet.Cells[7, 6].Value = "09:30";
                // 時間外
                sheet.Cells[0, 7].Value = ""; sheet.Cells[3, 7].Value = ""; sheet.Cells[5, 7].Value = "01:00";
                sheet.Cells[1, 7].Value = ""; sheet.Cells[4, 7].Value = ""; sheet.Cells[7, 7].Value = "01:30";
                // 備考
                sheet.Cells[0, 8].Value = ""; sheet.Cells[3, 8].Value = ""; sheet.Cells[5, 8].Value = "新店舗出店準備のため";
                sheet.Cells[1, 8].Value = ""; sheet.Cells[4, 8].Value = ""; sheet.Cells[7, 8].Value = "新店舗出店準備のため";
            }  
        }
    }
}
