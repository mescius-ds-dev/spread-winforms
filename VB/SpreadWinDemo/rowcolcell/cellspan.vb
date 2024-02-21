Public Class cellspan

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        sheet.ColumnCount = 7
        sheet.RowCount = 10

        ' 数式の参照スタイルをR1C1形式に設定
        sheet.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1

        ' 列幅を設定
        sheet.Columns(0).Width = 120
        sheet.Columns(1).Width = 80
        sheet.Columns(5).Width = 120

        ' セル型の設定
        Dim chkcell As New FarPoint.Win.Spread.CellType.CheckBoxCellType()
        sheet.Columns(4).CellType = chkcell
        sheet.Columns(6).CellType = chkcell

        Dim curcell As New FarPoint.Win.Spread.CellType.CurrencyCellType()
        sheet.Columns(2).CellType = curcell

        ' 列ヘッダの設定
        sheet.ColumnHeader.RowCount = 2
        sheet.ColumnHeader.Cells(0, 0).Value = "商品名"
        sheet.ColumnHeader.Cells(0, 1).Value = "注文ID"
        sheet.ColumnHeader.Cells(1, 1).Value = "注文日"
        sheet.ColumnHeader.Cells(0, 2).Value = "単価"
        sheet.ColumnHeader.Cells(0, 3).Value = "数量"
        sheet.ColumnHeader.Cells(1, 2).Value = "金額"
        sheet.ColumnHeader.Cells(0, 4).Value = "注文確認"
        sheet.ColumnHeader.Cells(0, 5).Value = "店舗ID"
        sheet.ColumnHeader.Cells(1, 5).Value = "店舗名"
        sheet.ColumnHeader.Cells(0, 6).Value = "店舗確認"
        sheet.ColumnHeader.Cells(0, 0).RowSpan = 2
        sheet.ColumnHeader.Cells(1, 2).ColumnSpan = 2
        sheet.ColumnHeader.Cells(0, 4).RowSpan = 2
        sheet.ColumnHeader.Cells(0, 6).RowSpan = 2

        ' テストデータの設定
        sheet.Cells(0, 0).Value = "いよかんドリンク"
        sheet.Cells(0, 1).Value = "B10101"
        sheet.Cells(1, 1).Value = "2009/09/01"
        sheet.Cells(0, 2).Value = 800
        sheet.Cells(0, 3).Value = 1
        sheet.Cells(1, 2).Formula = "R[-1]C*R[-1]C[1]"
        sheet.Cells(0, 5).Value = "S423"
        sheet.Cells(1, 5).Value = "橋龍商事"

        sheet.Cells(2, 1).Value = "B10102"
        sheet.Cells(3, 1).Value = "2009/09/05"
        sheet.Cells(2, 2).Value = 800
        sheet.Cells(2, 3).Value = 4
        sheet.Cells(3, 2).Formula = "R[-1]C*R[-1]C[1]"
        sheet.Cells(2, 5).Value = "S357"
        sheet.Cells(3, 5).Value = "グレープストア"

        sheet.Cells(4, 1).Value = "B10103"
        sheet.Cells(5, 1).Value = "2009/09/06"
        sheet.Cells(4, 2).Value = 800
        sheet.Cells(4, 3).Value = 2
        sheet.Cells(5, 2).Formula = "R[-1]C*R[-1]C[1]"
        sheet.Cells(4, 5).Value = "S341"
        sheet.Cells(5, 5).Value = "丘野ソフト商会"

        sheet.Cells(6, 0).Value = "麦焼酎 ちこちこ"
        sheet.Cells(6, 1).Value = "C10101"
        sheet.Cells(7, 1).Value = "2009/09/03"
        sheet.Cells(6, 2).Value = 4800
        sheet.Cells(6, 3).Value = 2
        sheet.Cells(7, 2).Formula = "R[-1]C*R[-1]C[1]"
        sheet.Cells(6, 5).Value = "S201"
        sheet.Cells(7, 5).Value = "グレープタウン商事"

        sheet.Cells(8, 1).Value = "C10102"
        sheet.Cells(9, 1).Value = "2009/09/04"
        sheet.Cells(8, 2).Value = 4800
        sheet.Cells(8, 3).Value = 5
        sheet.Cells(9, 2).Formula = "R[-1]C*R[-1]C[1]"
        sheet.Cells(8, 5).Value = "S357"
        sheet.Cells(9, 5).Value = "グレープストア"

        ' セルの結合
        sheet.Cells(0, 0).RowSpan = 6
        sheet.Cells(1, 2).ColumnSpan = 2
        sheet.Cells(0, 4).RowSpan = 2
        sheet.Cells(0, 6).RowSpan = 2

        sheet.Cells(3, 2).ColumnSpan = 2
        sheet.Cells(2, 4).RowSpan = 2
        sheet.Cells(2, 6).RowSpan = 2

        sheet.Cells(5, 2).ColumnSpan = 2
        sheet.Cells(4, 4).RowSpan = 2
        sheet.Cells(4, 6).RowSpan = 2

        sheet.Cells(6, 0).RowSpan = 4
        sheet.Cells(7, 2).ColumnSpan = 2
        sheet.Cells(6, 4).RowSpan = 2
        sheet.Cells(6, 6).RowSpan = 2

        sheet.Cells(9, 2).ColumnSpan = 2
        sheet.Cells(8, 4).RowSpan = 2
        sheet.Cells(8, 6).RowSpan = 2
    End Sub
End Class
