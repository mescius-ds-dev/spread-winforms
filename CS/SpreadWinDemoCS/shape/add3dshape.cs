using GrapeCity.Spreadsheet.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.shape
{
    public partial class add3dshape : SpreadWinDemo.DemoBase
    {
        public add3dshape()
        {
            InitializeComponent();

            // シートの設定
            InitSheet(fpSpread1.Sheets[0]);
        }

        private void InitSheet(FarPoint.Win.Spread.SheetView sheet)
        {
            fpSpread1.Features.EnhancedShapeEngine = true;

            // 3D回転なし
            IShape s1 = fpSpread1.AsWorkbook().ActiveSheet.Shapes.AddShape(AutoShapeType.CurvedDownArrow, 20, 20, 100, 100);

            // 3D回転あり
            IShape s2 = fpSpread1.AsWorkbook().ActiveSheet.Shapes.AddShape(AutoShapeType.CurvedDownArrow, 200, 20, 100, 100);
            IThreeDFormat threeDFormat2 = s2.ThreeD;
            threeDFormat2.RotationX = 30d;
            threeDFormat2.RotationY = 50d;
            threeDFormat2.RotationZ = 70d;
        }
    }
}
