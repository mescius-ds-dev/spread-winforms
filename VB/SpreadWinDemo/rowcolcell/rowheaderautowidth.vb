Public Class rowheaderautowidth

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        FpSpread1.ActiveSheet.RowCount = 1000000
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' 行ヘッダの自動拡張を有効にする
            FpSpread1.RowHeaderAutoWidthMax = -1
        Else
            ' 行ヘッダの自動拡張を有効にしない
            FpSpread1.RowHeaderAutoWidthMax = 0
        End If
    End Sub
End Class
