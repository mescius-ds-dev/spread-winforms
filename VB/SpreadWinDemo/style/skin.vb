Public Class skin

    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        InitSpread(FpSpread1)

        ' シート設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSpread(spread As FarPoint.Win.Spread.FpSpread)
        spread.Sheets.Count = 2
        spread.TabStripInsertTab = True
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 列幅の設定
        sheet.Columns(0).Width = 150
        sheet.Columns(1).Width = 100

        ' セル型の設定
        Dim cmbocell As New FarPoint.Win.Spread.CellType.ComboBoxCellType()
        Dim al As New System.Collections.ArrayList()
        For Each fpskin As FarPoint.Win.Spread.SpreadSkin In FarPoint.Win.Spread.DefaultSpreadSkins.Skins
            al.Add(fpskin.Name)
        Next
        cmbocell.Items = DirectCast(al.ToArray(GetType(String)), String())
        sheet.Cells(0, 0).CellType = cmbocell
        sheet.Cells(0, 0).Text = "Default"
        Dim bttncell As New FarPoint.Win.Spread.CellType.ButtonCellType()
        bttncell.Text = "スキンを変更"
        sheet.Cells(0, 1).CellType = bttncell
    End Sub

    Private Sub FpSpread1_ButtonClicked(sender As Object, e As FarPoint.Win.Spread.EditorNotifyEventArgs) Handles FpSpread1.ButtonClicked
        FpSpread1.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Find(FpSpread1.ActiveSheet.Cells(e.Row, e.Column - 1).Text)
    End Sub
End Class
