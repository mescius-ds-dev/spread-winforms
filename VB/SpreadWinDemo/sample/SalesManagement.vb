Imports System.ComponentModel
Imports System.IO
Imports FarPoint.Win.Spread
Imports FarPoint.Win.Spread.CellType

Public Class SalesManagement

    Private StoretoSalesData As BindingList(Of StoreOfSales) = New BindingList(Of StoreOfSales)

    Public Sub New()
        InitializeComponent()

        StoreSpread.DataSource = StoretoSalesData
        InitStoreSpread()
        InitSalesSpread()
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        FileImport()
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        FileExport()
    End Sub

    Private Sub StoreSpread_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles StoreSpread.SelectionChanged
        SalesSpread.AsWorkbook().Worksheets(New String() {StoreSpread.ActiveSheet.Cells(StoreSpread.ActiveSheet.ActiveRowIndex, 0).Text}).[Select]()
    End Sub
    Private Sub SalesSpread_ActiveSheetChanged(sender As Object, e As EventArgs) Handles SalesSpread.ActiveSheetChanged
        If (SalesSpread.ActiveSheet Is Nothing OrElse StoretoSalesData.Count = 0) Then
            Return
        End If

        Dim index = StoretoSalesData.IndexOf(StoretoSalesData.First(Function(x) x.StoreName = SalesSpread.ActiveSheet.SheetName))
        If index = StoreSpread.ActiveSheet.ActiveRowIndex Then Return
        StoreSpread.ActiveSheet.SetActiveCell(index, 0)
    End Sub

    Private Sub InitStoreSpread()
        StoreSpread.ActiveSheet.Rows.Count = 0
        StoreSpread.ActiveSheet.ColumnCount = 4
        StoreSpread.ActiveSheet.ColumnHeader.Columns(0).Label = "店舗名"
        StoreSpread.ActiveSheet.ColumnHeader.Columns(1).Label = "売上"
        StoreSpread.ActiveSheet.ColumnHeader.Columns(2).Label = "原価"
        StoreSpread.ActiveSheet.ColumnHeader.Columns(3).Label = "粗利率"
        StoreSpread.ActiveSheet.Columns(3).Formula = "(B1-C1)/B1"
        SetStoreSpreadColumns()
        SetFontSheet(StoreSpread.ActiveSheet)
    End Sub

    Private Sub SetStoreSpreadColumns()
        Dim numberCell = New FarPoint.Win.Spread.CellType.NumberCellType() With {
            .DecimalPlaces = 0,
            .Separator = ",",
            .ShowSeparator = True
        }
        StoreSpread.ActiveSheet.Columns(1).CellType = numberCell
        StoreSpread.ActiveSheet.Columns(2).CellType = numberCell
        StoreSpread.ActiveSheet.Columns(3).CellType = New NumberCellType() With {
            .DecimalPlaces = 2
        }

        For i As Integer = 0 To StoreSpread.Sheets(0).ColumnCount - 1
            StoreSpread.ActiveSheet.ColumnHeader.Columns(i).Width = StoreSpread.ActiveSheet.GetPreferredColumnWidth(i, False, False, False) + 10
        Next
    End Sub

    Private Sub SetFontSheet(ByVal sheet As SheetView)
        For i As Integer = 0 To sheet.Columns.Count - 1
            sheet.ColumnHeader.Columns(i).Font = New System.Drawing.Font("メイリオ", 11)
            sheet.Columns(i).Font = New System.Drawing.Font("メイリオ", 11)
        Next
    End Sub

    Private Sub InitSalesSpread()
        SalesSpread.Sheets.Count = 0
        SalesSpread.ShowOutline = RowCol.Columns
    End Sub

    Private Sub FileImport()
        Using dialog = New OpenFileDialog() With {
            .InitialDirectory = System.IO.Path.GetFullPath("..\..\SampleData"),
            .Filter = "Excel ファイル|*.xls;*.xlsx;|全てのファイル|*.*",
            .FilterIndex = 1,
            .Title = "インポートする売上ファイルを選択してください。",
            .Multiselect = True
        }
            If dialog.ShowDialog() <> DialogResult.OK Then Return

            Try
                Cursor = Cursors.WaitCursor
                ImportExcelFiles(dialog.FileNames)
            Finally
                Cursor = Cursors.[Default]
            End Try
        End Using
    End Sub

    Private Sub ImportExcelFiles(ByVal filePaths As String())
        For Each filePath In filePaths
            ImportExcelFile(New FileInfo(filePath))
        Next

        SetStoreSpreadColumns()
        Dim rule = New TopRankedValuesConditionalFormattingRule() With {
            .IsDescending = True,
            .Rank = 1,
            .BackColor = System.Drawing.Color.Gold
        }
        StoreSpread.ActiveSheet.SetConditionalFormatting(0, 1, StoreSpread.ActiveSheet.RowCount, 1, rule)
    End Sub

    Private Sub ImportExcelFile(ByVal file As FileInfo)
        Dim sheetName = GetSheetName(file.Name)
        Dim index = GetSheetIndex(sheetName)

        If -1 < index Then
            If DialogResult.No = MessageBox.Show("同名の支店ファイルを既にインポートしています。再度インポートしますか？", "確認", MessageBoxButtons.YesNo) Then Return
            SalesSpread.Sheets.RemoveAt(index)
        End If

        Dim newSheet = New SheetView()
        SalesSpread.Sheets.Add(newSheet)
        SalesSpread.Sheets(SalesSpread.Sheets.Count - 1).OpenExcel(file.FullName, 0)
        SalesSpread.Sheets(SalesSpread.Sheets.Count - 1).RemoveRows(0, 1)
        newSheet.SheetName = sheetName
        CreateSheetSalesSpread(newSheet)
        CreateStoreSales(SalesSpread.Sheets(SalesSpread.Sheets.Count - 1))
    End Sub

    Private Function GetSheetName(ByVal filePath As String) As String
        Dim fileName = Path.GetFileName(filePath)
        Dim removeFileName = fileName.Remove(0, fileName.IndexOf("_") + 1)
        Return removeFileName.Remove(removeFileName.IndexOf("."))
    End Function

    Private Function GetSheetIndex(ByVal sheetName As String) As Integer
        For i As Integer = 0 To SalesSpread.Sheets.Count - 1
            If SalesSpread.Sheets(i).SheetName = sheetName Then Return i
        Next

        Return -1
    End Function

    Private Sub CreateSheetSalesSpread(ByVal sheet As SheetView)
        sheet.ColumnCount = 8
        sheet.ColumnHeader.Columns(0).Label = "販売日"
        sheet.ColumnHeader.Columns(1).Label = "商品番号"
        sheet.ColumnHeader.Columns(2).Label = "商品名"
        sheet.ColumnHeader.Columns(3).Label = "単価"
        sheet.ColumnHeader.Columns(4).Label = "個数"
        sheet.ColumnHeader.Columns(5).Label = "売上"
        sheet.ColumnHeader.Columns(6).Label = "原価"
        sheet.ColumnHeader.Columns(7).Label = "粗利率"
        sheet.Columns(7).Formula = "(F1-G1)/F1"
        sheet.Columns(7).CellType = New NumberCellType() With {
            .DecimalPlaces = 2
        }
        SetFontSheet(sheet)
        sheet.AddRangeGroup(1, 4, False)
        sheet.ExpandRangeGroup(1, 4, False, False)
        sheet.SetColumnMerge(0, FarPoint.Win.Spread.Model.MergePolicy.Always)
    End Sub


    Private Sub CreateStoreSales(ByVal salesSheet As SheetView)
        Dim storeSales = New StoreOfSales With {
            .StoreName = salesSheet.SheetName
        }

        For i As Integer = 0 To salesSheet.RowCount - 1
            If salesSheet.Cells(i, 0).Value Is Nothing Then Exit For

            storeSales.Sales += Integer.Parse(salesSheet.Cells(i, 5).Value.ToString())
            storeSales.Cost += Integer.Parse(salesSheet.Cells(i, 6).Value.ToString())
        Next

        MergeStoretoSales(storeSales)
    End Sub

    Private Sub MergeStoretoSales(ByVal storeSales As StoreOfSales)
        Dim first = StoretoSalesData.FirstOrDefault(Function(x) x.StoreName = storeSales.StoreName)

        If first Is Nothing Then
            StoretoSalesData.Add(storeSales)
        Else
            first.Sales = storeSales.Sales
            first.Cost = storeSales.Cost
        End If
    End Sub

    Private Sub FileExport()
        Using dialog = New FolderBrowserDialog() With {
                .Description = "ファイルを出力するフォルダを指定してください。",
                .RootFolder = Environment.SpecialFolder.Desktop,
                .ShowNewFolderButton = True
            }
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            Dim directory = New DirectoryInfo(dialog.SelectedPath)
            StoreSpread.SaveExcel(Path.Combine(directory.FullName, "店舗売上ファイル.xlsx"), FarPoint.Excel.ExcelSaveFlags.UseOOXMLFormat Or FarPoint.Excel.ExcelSaveFlags.SaveCustomColumnHeaders)
            MessageBox.Show("ファイル出力が完了しました。")
        End Using
    End Sub

    Private Class StoreOfSales
        Public Property StoreName As String
        Public Property Sales As Integer
        Public Property Cost As Integer
    End Class
End Class
