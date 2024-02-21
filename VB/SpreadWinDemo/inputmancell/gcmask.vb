Public Class gcmask
    Public Sub New()

        InitializeComponent()

        ' SPREADの設定
        FpSpread1.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded
        FpSpread1.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded

        ' シートの設定
        InitSheet(FpSpread1.Sheets(0))
    End Sub

    Private Sub InitSheet(sheet As FarPoint.Win.Spread.SheetView)
        ' 列の設定
        sheet.ColumnCount = 3
        sheet.Columns(0).Width = 170
        sheet.Columns(1).Width = 125
        sheet.Columns(2).Width = 374
        sheet.Columns(0).CellPadding = New FarPoint.Win.Spread.CellPadding(0, 0, 4, 0)
        sheet.Columns(2).CellPadding = New FarPoint.Win.Spread.CellPadding(4, 0, 0, 0)

        ' 行の設定
        sheet.RowCount = 9

        ' 列ヘッダの設定
        sheet.ColumnHeader.Columns(0).Label = "機能"
        sheet.ColumnHeader.Columns(1).Label = "実行例"
        sheet.ColumnHeader.Columns(2).Label = "説明"

        ' プロテクトとロック（DefaultStyle）の設定
        sheet.Protect = True
        sheet.DefaultStyle.Locked = False
        sheet.RowHeader.DefaultStyle.Locked = False
        sheet.ColumnHeader.DefaultStyle.Locked = False

        ' 読み取り専用設定
        sheet.Columns(0).Locked = True
        sheet.Columns(2).Locked = True

        ' 背景色の設定
        sheet.Columns(0).BackColor = System.Drawing.SystemColors.Control

        ' 左揃え
        sheet.ColumnHeader.DefaultStyle.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left

        ' アクティブセルの設定
        sheet.SetActiveCell(0, 1)

        ' 項目名と解説の設定
        sheet.Cells(0, 0).Text = "書式の設定"
        sheet.Cells(1, 0).Text = "文字種の自動変換"
        sheet.Cells(2, 0).Text = "パスワード入力"
        sheet.Cells(3, 0).Text = "未入力時の代替テキスト"
        sheet.Cells(4, 0).Text = "入力候補値"
        sheet.Cells(5, 0).Text = "最大文字数"
        sheet.Cells(6, 0).Text = "自動フォーカス移動"
        sheet.Cells(7, 0).Text = "フィールドのスタイル"
        sheet.Cells(8, 0).Text = "サイドボタン"

        sheet.Cells(0, 2).Text = "リテラル文字は自動的にとばして値を入力できます"
        sheet.Cells(1, 2).Text = "全角の文字を入力すると半角に変換されます"
        sheet.Cells(2, 2).Text = "入力した文字を表示しないパスワード入力にします"
        sheet.Cells(3, 2).Text = "セルが未入力のときに代わりにテキストを表示します"
        sheet.Cells(4, 2).Text = "(Ctrl)+(Enter)で候補として表示された値を確定します"
        sheet.Cells(5, 2).Text = "最大5文字までしか入力できません"
        sheet.Cells(6, 2).Text = "5文字入力すると自動的に右のセルにフォーカスを移動します"
        sheet.Cells(7, 2).Text = "フィールドごとのスタイルを設定します"
        sheet.Cells(8, 2).Text = "サイドボタンを追加します"

        '【書式の設定】
        Dim gcmask1 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask1.Fields.AddRange("〒\D{3}-\D{4}")
        gcmask1.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(0, 1).CellType = gcmask1

        '【文字種の自動変換】
        Dim gcmask2 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask2.AutoConvert = True
        gcmask2.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcmask2.Fields.AddRange("\H{0,}")
        sheet.Cells(1, 1).CellType = gcmask2
        sheet.Cells(1, 1).ImeMode = System.Windows.Forms.ImeMode.Hiragana

        '【パスワード入力】
        Dim gcmask3 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask3.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcmask3.Fields.AddRange("[\H^\K\N]{8,10}")
        For Each mf As GrapeCity.Win.Spread.InputMan.CellType.Fields.MaskFieldInfo In gcmask3.Fields
            If TypeOf mf Is GrapeCity.Win.Spread.InputMan.CellType.Fields.MaskPatternFieldInfo Then
                DirectCast(mf, GrapeCity.Win.Spread.InputMan.CellType.Fields.MaskPatternFieldInfo).UseSystemPasswordChar = True
            End If
        Next
        gcmask3.PasswordRevelationMode = GrapeCity.Win.Spread.InputMan.CellType.PasswordRevelationMode.None
        sheet.Cells(2, 1).CellType = gcmask3

        '【未入力時の代替テキスト】
        Dim gcmask4 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask4.Fields.AddRange("\D{5}")
        gcmask4.AlternateText.DisplayNull.ForeColor = Color.LightSeaGreen
        gcmask4.AlternateText.DisplayNull.Text = "＜数値入力＞"
        gcmask4.AlternateText.Null.ForeColor = Color.LightPink
        gcmask4.AlternateText.Null.Text = "5桁の数値を入力"
        gcmask4.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(3, 1).CellType = gcmask4

        '【入力候補値】
        Dim gcmask5 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask5.Fields.AddRange("\D{5}")
        gcmask5.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcmask5.ShowRecommendedValue = True
        gcmask5.RecommendedValue = "12345"
        sheet.Cells(4, 1).CellType = gcmask5

        '【最大文字数】
        Dim gcmask6 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask6.Fields.AddRange("[\H\Ｚ]{0,5}")
        gcmask6.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(5, 1).CellType = gcmask6

        '【自動フォーカス移動】
        Dim gcmask7 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask7.ExitOnLastChar = True
        gcmask7.Fields.AddRange("[\H\Ｚ]{0,5}")
        gcmask7.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        sheet.Cells(6, 1).CellType = gcmask7

        '【フィールドのスタイル】
        Dim gcmask8 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask8.Fields.AddRange("〒\D{3}-\D{4}")
        gcmask8.Fields(0).ForeColor = Color.Red
        gcmask8.Fields(1).ForeColor = Color.Blue
        gcmask8.Fields(2).ForeColor = Color.Red
        gcmask8.Fields(3).ForeColor = Color.Blue
        gcmask8.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcmask8.PaintByControl = True
        sheet.Cells(7, 1).CellType = gcmask8

        '【サイドボタン】
        Dim gcmask9 As New GrapeCity.Win.Spread.InputMan.CellType.GcMaskCellType()
        gcmask9.Fields.AddRange("[\H\Ｚ]{0,5}")
        gcmask9.FocusPosition = GrapeCity.Win.Spread.InputMan.CellType.FieldsEditorFocusCursorPosition.FirstInputPosition
        gcmask9.SideButtons.Add(New GrapeCity.Win.Spread.InputMan.CellType.SideButtonInfo())
        sheet.Cells(8, 1).CellType = gcmask9
    End Sub

    Private Sub FpSpread1_EditModeOn(sender As Object, e As EventArgs) Handles FpSpread1.EditModeOn
        ' サイドボタンのClickイベントの設定
        If TypeOf FpSpread1.EditingControl Is GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl Then
            Dim mask As GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl = DirectCast(FpSpread1.EditingControl, GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl)
            If (mask.SideButtons.Count > 0) Then
                AddHandler mask.SideButtons(0).Click, AddressOf sidebutton_Click
            End If
        End If
    End Sub

    Private Sub FpSpread1_EditModeOff(sender As Object, e As EventArgs) Handles FpSpread1.EditModeOff
        ' サイドボタンのClickイベントの解除
        If TypeOf FpSpread1.EditingControl Is GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl Then
            Dim mask As GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl = DirectCast(FpSpread1.EditingControl, GrapeCity.Win.Spread.InputMan.CellType.GcMaskEditingControl)
            If (mask.SideButtons.Count > 0) Then
                RemoveHandler mask.SideButtons(0).Click, AddressOf sidebutton_Click
            End If
        End If
    End Sub

    Private Sub sidebutton_Click(sender As Object, e As EventArgs)
        MessageBox.Show("サイドボタンがクリックされました。")
    End Sub
End Class
