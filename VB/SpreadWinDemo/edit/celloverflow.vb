Public Class celloverflow

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' テストデータの設定
        Dim strVal As String = "長いテキストは、となりのセルにはみ出します。"
        sheet.Cells(0, 5).Value = strVal & "(右揃え)"
        sheet.Cells(0, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
        sheet.Cells(1, 5).Value = strVal & "(左揃え)"
        sheet.Cells(1, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        sheet.Cells(2, 5).Value = strVal & "(中央揃え)"
        sheet.Cells(2, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            FpSpread1.AllowCellOverflow = True
        Else
            FpSpread1.AllowCellOverflow = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            FpSpread1.AllowEditOverflow = True
        Else
            FpSpread1.AllowEditOverflow = False
        End If
    End Sub
End Class
