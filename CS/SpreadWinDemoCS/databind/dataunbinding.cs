using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.databind
{
    public partial class dataunbinding : SpreadWinDemo.DemoBase
    {
        public dataunbinding()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            sheet.RowCount = 12;
            sheet.ColumnCount = 9;

            sheet.ColumnHeader.Cells[0, 0].Text = "ID";
            sheet.ColumnHeader.Cells[0, 1].Text = "氏名";
            sheet.ColumnHeader.Cells[0, 2].Text = "カナ";
            sheet.ColumnHeader.Cells[0, 3].Text = "生年月日";
            sheet.ColumnHeader.Cells[0, 4].Text = "性別";
            sheet.ColumnHeader.Cells[0, 5].Text = "血液型";
            sheet.ColumnHeader.Cells[0, 6].Text = "部署";
            sheet.ColumnHeader.Cells[0, 7].Text = "入社日";
            sheet.ColumnHeader.Cells[0, 8].Text = "メールアドレス";


            sheet.Cells[0, 0].Value = "1001";
            sheet.Cells[1, 0].Value = "1002";
            sheet.Cells[2, 0].Value = "1003";
            sheet.Cells[3, 0].Value = "1004";
            sheet.Cells[4, 0].Value = "1005";
            sheet.Cells[5, 0].Value = "1006";
            sheet.Cells[6, 0].Value = "1007";
            sheet.Cells[7, 0].Value = "1008";
            sheet.Cells[8, 0].Value = "1009";
            sheet.Cells[9, 0].Value = "1010";
            sheet.Cells[10, 0].Value = "1011";
            sheet.Cells[11, 0].Value = "1012";

            sheet.Cells[0, 1].Value = "亀甲　滋万";
            sheet.Cells[1, 1].Value = "寒田　希世";
            sheet.Cells[2, 1].Value = "小和瀬　澄";
            sheet.Cells[3, 1].Value = "宇夫　早余子";
            sheet.Cells[4, 1].Value = "宇田津　聖智";
            sheet.Cells[5, 1].Value = "茨城　昭児";
            sheet.Cells[6, 1].Value = "石ヶ休　椎茄";
            sheet.Cells[7, 1].Value = "赤司　恵治郎";
            sheet.Cells[8, 1].Value = "小橋　仰一";
            sheet.Cells[9, 1].Value = "一重　公大";
            sheet.Cells[10, 1].Value = "稲並　勝五郎";
            sheet.Cells[11, 1].Value = "穎原　紀代一";

            sheet.Cells[0, 2].Value = "ｷｺｳ ｼｹﾞﾏ";
            sheet.Cells[1, 2].Value = "ｶﾝﾀﾞ ｷﾖ";
            sheet.Cells[2, 2].Value = "ｵﾜｾ ｷﾖ";
            sheet.Cells[3, 2].Value = "ｳﾌﾞ ｻﾖｺ";
            sheet.Cells[4, 2].Value = "ｳﾀﾞﾂ ｷﾖﾄﾓ";
            sheet.Cells[5, 2].Value = "ｲﾊﾞﾗｷ ｼｮｳｼﾞ";
            sheet.Cells[6, 2].Value = "ｲｼｶﾞｷｭｳ ｼｲﾅ";
            sheet.Cells[7, 2].Value = "ｱｶﾂｶｻ ｹｲｼﾞﾛｳ";
            sheet.Cells[8, 2].Value = "ｵﾊｼ ｷﾞｮｳｲﾁ";
            sheet.Cells[9, 2].Value = "ｲﾁｼﾞｭｳ ｺｳﾀﾞｲ";
            sheet.Cells[10, 2].Value = "ｲﾅﾐ ｼｮｳｺﾞﾛｳ";
            sheet.Cells[11, 2].Value = "ｴｲﾊﾗ ｷﾖｶｽﾞ";

            sheet.Cells[0, 3].Value = "1950/02/04";
            sheet.Cells[1, 3].Value = "1959/06/28";
            sheet.Cells[2, 3].Value = "1969/03/06";
            sheet.Cells[3, 3].Value = "1976/07/28";
            sheet.Cells[4, 3].Value = "1965/09/04";
            sheet.Cells[5, 3].Value = "1963/04/28";
            sheet.Cells[6, 3].Value = "1953/02/21";
            sheet.Cells[7, 3].Value = "1968/08/02";
            sheet.Cells[8, 3].Value = "1972/03/02";
            sheet.Cells[9, 3].Value = "1964/04/19";
            sheet.Cells[10, 3].Value = "1962/02/18";
            sheet.Cells[11, 3].Value = "1965/02/13";

            sheet.Cells[0, 4].Value = "男";
            sheet.Cells[1, 4].Value = "女";
            sheet.Cells[2, 4].Value = "男";
            sheet.Cells[3, 4].Value = "女";
            sheet.Cells[4, 4].Value = "男";
            sheet.Cells[5, 4].Value = "男";
            sheet.Cells[6, 4].Value = "男";
            sheet.Cells[7, 4].Value = "男";
            sheet.Cells[8, 4].Value = "男";
            sheet.Cells[9, 4].Value = "男";
            sheet.Cells[10, 4].Value = "男";
            sheet.Cells[11, 4].Value = "男";

            sheet.Cells[0, 5].Value = "A";
            sheet.Cells[1, 5].Value = "B";
            sheet.Cells[2, 5].Value = "A";
            sheet.Cells[3, 5].Value = "O";
            sheet.Cells[4, 5].Value = "A";
            sheet.Cells[5, 5].Value = "O";
            sheet.Cells[6, 5].Value = "O";
            sheet.Cells[7, 5].Value = "O";
            sheet.Cells[8, 5].Value = "B";
            sheet.Cells[9, 5].Value = "B";
            sheet.Cells[10, 5].Value = "A";
            sheet.Cells[11, 5].Value = "O";

            sheet.Cells[0, 6].Value = "人事部";
            sheet.Cells[1, 6].Value = "人事部";
            sheet.Cells[2, 6].Value = "人事部";
            sheet.Cells[3, 6].Value = "人事部";
            sheet.Cells[4, 6].Value = "営業部";
            sheet.Cells[5, 6].Value = "営業部";
            sheet.Cells[6, 6].Value = "営業部";
            sheet.Cells[7, 6].Value = "経理部";
            sheet.Cells[8, 6].Value = "経理部";
            sheet.Cells[9, 6].Value = "経理部";
            sheet.Cells[10, 6].Value = "営業部";
            sheet.Cells[11, 6].Value = "営業部";

            sheet.Cells[0, 7].Value = "1972/04/01";
            sheet.Cells[1, 7].Value = "1981/04/01";
            sheet.Cells[2, 7].Value = "1991/04/01";
            sheet.Cells[3, 7].Value = "1998/04/01";
            sheet.Cells[4, 7].Value = "1987/04/01";
            sheet.Cells[5, 7].Value = "1985/04/01";
            sheet.Cells[6, 7].Value = "1975/04/01";
            sheet.Cells[7, 7].Value = "1990/04/01";
            sheet.Cells[8, 7].Value = "1994/04/01";
            sheet.Cells[9, 7].Value = "1986/04/01";
            sheet.Cells[10, 7].Value = "1984/04/01";
            sheet.Cells[11, 7].Value = "1987/04/01";

            sheet.Cells[0, 8].Value = "sigema_kikou@abc.co.jp";
            sheet.Cells[1, 8].Value = "kiyo_kanda@bbb.or.jp";
            sheet.Cells[2, 8].Value = "kiyo_owase@aaa.co.jp";
            sheet.Cells[3, 8].Value = "sayoko_ubu@bbb.or.jp";
            sheet.Cells[4, 8].Value = "kiyotomo_udatu@abc.co.jp";
            sheet.Cells[5, 8].Value = "shouzi_ibaraki@xyz.ne.jp";
            sheet.Cells[6, 8].Value = "siina_isigagyuu@abc.co.jp";
            sheet.Cells[7, 8].Value = "keizirou_akatukasa@abc.co.jp";
            sheet.Cells[8, 8].Value = "gyouiti_ohasi@abc.co.jp";
            sheet.Cells[9, 8].Value = "koudai_itizyuu@xyz.ne.jp";
            sheet.Cells[10, 8].Value = "shougorou_inami@bbb.or.jp";
            sheet.Cells[11, 8].Value = "kiyokazu_eihara@bbb.or.jp";

            // 列幅の設定
            sheet.Columns[0].Width = 36;
            sheet.Columns[1].Width = 88;
            sheet.Columns[2].Width = 91;
            sheet.Columns[3].Width = 80;
            sheet.Columns[4].Width = 36;
            sheet.Columns[5].Width = 46;
            sheet.Columns[6].Width = 49;
            sheet.Columns[7].Width = 80;
            sheet.Columns[8].Width = 181;
        }
    }
}
