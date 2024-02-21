Public Class opentextfile

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim fn As String = ""
        ' ファイル選択ダイアログ起動
        Using ofd As New OpenFileDialog()
            ofd.Filter = "csvファイル(*.csv)|*.csv"
            If ofd.ShowDialog() = DialogResult.OK Then
                fn = ofd.FileName
            Else
                Return
            End If
        End Using

        ' csv読込
        FpSpread1.ActiveSheet.LoadTextFile(fn, FarPoint.Win.Spread.TextFileFlags.ForceCellDelimiter, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly, System.Environment.NewLine, ",", """")
    End Sub
End Class
