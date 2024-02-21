Public Class goalseek

    Const ROW_PR As Integer = 2    '代金
    Const ROW_DP As Integer = 4    '頭金
    Const ROW_AR As Integer = 8    '年利
    Const ROW_BR As Integer = 6    '借入金額
    Const ROW_BM As Integer = 7    '借入月数
    Const ROW_RP As Integer = 10    '毎月返済額

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        sheet.ColumnCount = 3
        sheet.RowCount = 11

        sheet.SetValue(0, 0, "マイカーローン・シミュレーション")
        sheet.AddSpanCell(0, 0, 1, 3)

        sheet.SetValue(ROW_PR, 0, "代金:")
        sheet.SetValue(ROW_DP, 0, "頭金:")
        sheet.SetValue(ROW_BR, 0, "借入金額:")
        sheet.SetValue(ROW_BM, 0, "借入月数:")
        sheet.SetValue(ROW_AR, 0, "年利(%):")
        sheet.SetValue(ROW_RP, 0, "毎月返済額:")

        sheet.SetValue(ROW_PR, 1, "1300000.")
        sheet.SetValue(ROW_DP, 1, "100000.")
        sheet.SetValue(ROW_AR, 1, "0.03")
        sheet.SetValue(ROW_BM, 1, "12")

        sheet.SetValue(ROW_PR, 2, "購入代金（変更可）")
        sheet.SetValue(ROW_DP, 2, "計算対象（ゴールシークにより算出）")
        sheet.SetValue(ROW_BR, 2, "=B3-B5")
        sheet.SetValue(ROW_BM, 2, "返済する月数（変更可）")
        sheet.SetValue(ROW_AR, 2, "年利率（変更可）")
        sheet.SetValue(ROW_RP, 2, "=INT(PMT(B9/12,B8,-B7))")

        ' セル型
        sheet.Cells(ROW_PR, 1, 4, 1).CellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()
        sheet.Cells(ROW_AR, 1).CellType = New FarPoint.Win.Spread.CellType.PercentCellType()
        sheet.Cells(ROW_BR, 1).CellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()
        sheet.Cells(ROW_BM, 1).CellType = New FarPoint.Win.Spread.CellType.NumberCellType()
        sheet.Cells(ROW_RP, 1).CellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()

        ' タイトル
        sheet.Cells(0, 0).ForeColor = System.Drawing.Color.Blue
        sheet.Cells(0, 0).Font = New System.Drawing.Font("メイリオ", 18, FontStyle.Underline Or FontStyle.Italic)

        ' 代金-罫線
        sheet.Cells(ROW_PR, 0, ROW_PR, 2).Border = New FarPoint.Win.LineBorder(Color.Gray, 2)
        sheet.Cells(ROW_PR, 0, ROW_PR, 0).ForeColor = System.Drawing.Color.White
        sheet.Cells(ROW_PR, 0, ROW_PR, 0).BackColor = System.Drawing.Color.DarkBlue

        ' 頭金-罫線
        sheet.Cells(ROW_DP, 0, ROW_DP, 2).Border = New FarPoint.Win.LineBorder(Color.Gray, 2)
        sheet.Cells(ROW_DP, 0, ROW_DP, 0).ForeColor = System.Drawing.Color.White
        sheet.Cells(ROW_DP, 1, ROW_DP, 2).ForeColor = System.Drawing.Color.Red
        sheet.Cells(ROW_DP, 0, ROW_DP, 0).BackColor = System.Drawing.Color.DarkBlue

        ' 借入-罫線
        sheet.Cells(ROW_BR, 0, ROW_AR, 2).Border = New FarPoint.Win.LineBorder(Color.Gray, 2)
        sheet.Cells(ROW_BR, 0, ROW_AR, 0).ForeColor = System.Drawing.Color.White
        sheet.Cells(ROW_BR, 0, ROW_AR, 0).BackColor = System.Drawing.Color.DarkBlue

        ' 毎月返済額-罫線
        sheet.Cells(ROW_RP, 0, ROW_RP, 2).Border = New FarPoint.Win.LineBorder(Color.Gray, 2)
        sheet.Cells(ROW_RP, 0, ROW_RP, 0).ForeColor = System.Drawing.Color.White
        sheet.Cells(ROW_RP, 0, ROW_RP, 0).BackColor = System.Drawing.Color.DarkBlue

        ' ロック
        sheet.DefaultStyle.Locked = True
        sheet.Cells(ROW_PR, 1).Locked = False
        sheet.Cells(ROW_BM, 1).Locked = False
        sheet.Cells(ROW_AR, 1).Locked = False

        sheet.Cells(ROW_DP, 1).BackColor = System.Drawing.Color.Cornsilk
        sheet.Cells(ROW_BR, 1).BackColor = System.Drawing.Color.Cornsilk
        sheet.Cells(ROW_RP, 1).BackColor = System.Drawing.Color.Cornsilk

        ' 計算式設定
        sheet.SetFormula(ROW_BR, 1, "B" & Convert.ToString(ROW_PR + 1) & "-B" & Convert.ToString(ROW_DP + 1))
        sheet.SetFormula(ROW_RP, 1, "INT(PMT(B" & Convert.ToString(ROW_AR + 1) & "/12,B" & Convert.ToString(ROW_BM + 1) & ",-B" & Convert.ToString(ROW_BR + 1) & "))")

        ' 列幅の設定
        sheet.Columns(0).Width = 150
        sheet.Columns(1).Width = 150
        sheet.Columns(2).Width = 348

        ' 行高の設定
        sheet.Rows(0).Height = 50
    End Sub

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        ' 入力額取得
        Dim rp As Integer
        Integer.TryParse(TextBox1.Text, rp)

        If rp = 0 Then
            Return
        End If

        ' ゴールシーク
        FpSpread1.GoalSeek(0, ROW_DP, 1, 0, ROW_RP, 1, rp)
    End Sub
End Class
