using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpreadWinDemo.shape
{
    public partial class editshape : SpreadWinDemo.DemoBase
    {
        public editshape()
        {
            InitializeComponent();

            // ワークブックの設定
            InitWorkbook(fpSpread1.AsWorkbook());
        }

        private void InitWorkbook(GrapeCity.Spreadsheet.IWorkbook workbook)
        {
            // 拡張シェイプエンジンを有効
            fpSpread1.Features.EnhancedShapeEngine = true;

            // AddShapeメソッドによるシェイプの追加
            workbook.ActiveSheet.Shapes.AddShape(GrapeCity.Spreadsheet.Drawing.AutoShapeType.Heart, 100, 50, 150, 150);

            // 行列インデックスを指定したAddShapeToCellメソッドによるシェイプの追加
            GrapeCity.Spreadsheet.Drawing.IShape sunShape = workbook.ActiveSheet.Shapes.AddShapeToCell(GrapeCity.Spreadsheet.Drawing.AutoShapeType.Sun, 2, 4, 200, 200);
            // シェイプのスタイルの変更
            sunShape.ShapeStyle = GrapeCity.Spreadsheet.Drawing.ShapeStyle.Preset12;

            // AddConnectorメソッドによるコネクタシェイプの追加
            GrapeCity.Spreadsheet.Drawing.IShape connectorShape = workbook.ActiveSheet.Shapes.AddConnector(GrapeCity.Spreadsheet.Drawing.ConnectorType.Elbow, 100, 300, 400, 250);
            // コネクタシェイプの太さの変更
            connectorShape.Line.Weight =  5;
        }
    }
}
