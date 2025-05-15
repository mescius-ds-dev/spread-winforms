Imports FarPoint.Win.Spread

Public Class contextmenu

    Public Sub New()

        InitializeComponent()

        ' シートの設定
        InitSpreadStyles(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSpreadStyles(sheet As FarPoint.Win.Spread.SheetView)
        FpSpread1.ContextMenuStrip = New SpreadContextMenuStrip()
    End Sub
End Class
