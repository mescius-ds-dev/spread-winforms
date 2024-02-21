<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintSettingForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tpPage = New System.Windows.Forms.TabPage()
        Me.numFirstPage = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cmbPaperSize = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.numByPageV = New System.Windows.Forms.NumericUpDown()
        Me.numByPageH = New System.Windows.Forms.NumericUpDown()
        Me.numZoom = New System.Windows.Forms.NumericUpDown()
        Me.rdoByPage = New System.Windows.Forms.RadioButton()
        Me.rdoZoom = New System.Windows.Forms.RadioButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoAuto = New System.Windows.Forms.RadioButton()
        Me.rdoDirectionH = New System.Windows.Forms.RadioButton()
        Me.rdoDirectionV = New System.Windows.Forms.RadioButton()
        Me.tpMergin = New System.Windows.Forms.TabPage()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.numFooterHeight = New System.Windows.Forms.NumericUpDown()
        Me.label12 = New System.Windows.Forms.Label()
        Me.numHeaderHeight = New System.Windows.Forms.NumericUpDown()
        Me.label11 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.numMerginBottom = New System.Windows.Forms.NumericUpDown()
        Me.label10 = New System.Windows.Forms.Label()
        Me.numMerginTop = New System.Windows.Forms.NumericUpDown()
        Me.label9 = New System.Windows.Forms.Label()
        Me.numMerginRight = New System.Windows.Forms.NumericUpDown()
        Me.label8 = New System.Windows.Forms.Label()
        Me.numMerginLeft = New System.Windows.Forms.NumericUpDown()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.ckbCenterV = New System.Windows.Forms.CheckBox()
        Me.ckbCenterH = New System.Windows.Forms.CheckBox()
        Me.tpHeaderFooter = New System.Windows.Forms.TabPage()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmbFooter = New System.Windows.Forms.ComboBox()
        Me.txtFooter = New System.Windows.Forms.TextBox()
        Me.groupBox6 = New System.Windows.Forms.GroupBox()
        Me.cmbHeader = New System.Windows.Forms.ComboBox()
        Me.txtHeader = New System.Windows.Forms.TextBox()
        Me.tpSheet = New System.Windows.Forms.TabPage()
        Me.groupBox9 = New System.Windows.Forms.GroupBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.numRepeatRightCol = New System.Windows.Forms.NumericUpDown()
        Me.numRepeatLeftCol = New System.Windows.Forms.NumericUpDown()
        Me.label19 = New System.Windows.Forms.Label()
        Me.numRepeatBottomRow = New System.Windows.Forms.NumericUpDown()
        Me.label20 = New System.Windows.Forms.Label()
        Me.numRepeatTopRow = New System.Windows.Forms.NumericUpDown()
        Me.label22 = New System.Windows.Forms.Label()
        Me.groupBox10 = New System.Windows.Forms.GroupBox()
        Me.cmbCellNote = New System.Windows.Forms.ComboBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.rdoPageOrderAuto = New System.Windows.Forms.RadioButton()
        Me.rdoPageOrderTopBottom = New System.Windows.Forms.RadioButton()
        Me.rdoPageOrderLeftRight = New System.Windows.Forms.RadioButton()
        Me.label23 = New System.Windows.Forms.Label()
        Me.ckbColHeader = New System.Windows.Forms.CheckBox()
        Me.ckbRowHeader = New System.Windows.Forms.CheckBox()
        Me.ckbGrid = New System.Windows.Forms.CheckBox()
        Me.ckbBorder = New System.Windows.Forms.CheckBox()
        Me.groupBox8 = New System.Windows.Forms.GroupBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.numRangeRightCol = New System.Windows.Forms.NumericUpDown()
        Me.numRangeLeftCol = New System.Windows.Forms.NumericUpDown()
        Me.label15 = New System.Windows.Forms.Label()
        Me.numRangeBottomRow = New System.Windows.Forms.NumericUpDown()
        Me.label16 = New System.Windows.Forms.Label()
        Me.numRangeTopRow = New System.Windows.Forms.NumericUpDown()
        Me.label17 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.tabControl1.SuspendLayout()
        Me.tpPage.SuspendLayout()
        CType(Me.numFirstPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.numByPageV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numByPageH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.tpMergin.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        CType(Me.numFooterHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox3.SuspendLayout()
        CType(Me.numMerginBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMerginTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMerginRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMerginLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox5.SuspendLayout()
        Me.tpHeaderFooter.SuspendLayout()
        Me.groupBox7.SuspendLayout()
        Me.groupBox6.SuspendLayout()
        Me.tpSheet.SuspendLayout()
        Me.groupBox9.SuspendLayout()
        CType(Me.numRepeatRightCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRepeatLeftCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRepeatBottomRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRepeatTopRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox10.SuspendLayout()
        Me.groupBox8.SuspendLayout()
        CType(Me.numRangeRightCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRangeLeftCol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRangeBottomRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRangeTopRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tpPage)
        Me.tabControl1.Controls.Add(Me.tpMergin)
        Me.tabControl1.Controls.Add(Me.tpHeaderFooter)
        Me.tabControl1.Controls.Add(Me.tpSheet)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(360, 309)
        Me.tabControl1.TabIndex = 1
        '
        'tpPage
        '
        Me.tpPage.Controls.Add(Me.numFirstPage)
        Me.tpPage.Controls.Add(Me.label2)
        Me.tpPage.Controls.Add(Me.cmbPaperSize)
        Me.tpPage.Controls.Add(Me.label1)
        Me.tpPage.Controls.Add(Me.groupBox2)
        Me.tpPage.Controls.Add(Me.groupBox1)
        Me.tpPage.Location = New System.Drawing.Point(4, 22)
        Me.tpPage.Name = "tpPage"
        Me.tpPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPage.Size = New System.Drawing.Size(352, 283)
        Me.tpPage.TabIndex = 0
        Me.tpPage.Text = "ページ"
        Me.tpPage.UseVisualStyleBackColor = True
        '
        'numFirstPage
        '
        Me.numFirstPage.Location = New System.Drawing.Point(95, 214)
        Me.numFirstPage.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFirstPage.Name = "numFirstPage"
        Me.numFirstPage.Size = New System.Drawing.Size(80, 19)
        Me.numFirstPage.TabIndex = 10
        Me.numFirstPage.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 216)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(83, 12)
        Me.label2.TabIndex = 7
        Me.label2.Text = "先頭ページ番号"
        '
        'cmbPaperSize
        '
        Me.cmbPaperSize.FormattingEnabled = True
        Me.cmbPaperSize.Location = New System.Drawing.Point(95, 188)
        Me.cmbPaperSize.Name = "cmbPaperSize"
        Me.cmbPaperSize.Size = New System.Drawing.Size(174, 20)
        Me.cmbPaperSize.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(6, 191)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(58, 12)
        Me.label1.TabIndex = 5
        Me.label1.Text = "用紙サイズ"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.numByPageV)
        Me.groupBox2.Controls.Add(Me.numByPageH)
        Me.groupBox2.Controls.Add(Me.numZoom)
        Me.groupBox2.Controls.Add(Me.rdoByPage)
        Me.groupBox2.Controls.Add(Me.rdoZoom)
        Me.groupBox2.Location = New System.Drawing.Point(6, 62)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.groupBox2.Size = New System.Drawing.Size(340, 120)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "拡大縮小印刷"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(115, 42)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(11, 12)
        Me.label6.TabIndex = 3
        Me.label6.Text = "%"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(155, 89)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(17, 12)
        Me.label5.TabIndex = 8
        Me.label5.Text = "縦"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(136, 89)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(17, 12)
        Me.label4.TabIndex = 7
        Me.label4.Text = "×"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(27, 89)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(17, 12)
        Me.label3.TabIndex = 5
        Me.label3.Text = "横"
        '
        'numByPageV
        '
        Me.numByPageV.Location = New System.Drawing.Point(178, 87)
        Me.numByPageV.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numByPageV.Name = "numByPageV"
        Me.numByPageV.Size = New System.Drawing.Size(80, 19)
        Me.numByPageV.TabIndex = 9
        Me.numByPageV.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numByPageH
        '
        Me.numByPageH.Location = New System.Drawing.Point(50, 87)
        Me.numByPageH.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numByPageH.Name = "numByPageH"
        Me.numByPageH.Size = New System.Drawing.Size(80, 19)
        Me.numByPageH.TabIndex = 6
        Me.numByPageH.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numZoom
        '
        Me.numZoom.Location = New System.Drawing.Point(29, 40)
        Me.numZoom.Maximum = New Decimal(New Integer() {400, 0, 0, 0})
        Me.numZoom.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numZoom.Name = "numZoom"
        Me.numZoom.Size = New System.Drawing.Size(80, 19)
        Me.numZoom.TabIndex = 1
        Me.numZoom.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'rdoByPage
        '
        Me.rdoByPage.AutoSize = True
        Me.rdoByPage.Location = New System.Drawing.Point(13, 65)
        Me.rdoByPage.Name = "rdoByPage"
        Me.rdoByPage.Size = New System.Drawing.Size(161, 16)
        Me.rdoByPage.TabIndex = 4
        Me.rdoByPage.Text = "次のページ数に合わせて印刷"
        Me.rdoByPage.UseVisualStyleBackColor = True
        '
        'rdoZoom
        '
        Me.rdoZoom.AutoSize = True
        Me.rdoZoom.Checked = True
        Me.rdoZoom.Location = New System.Drawing.Point(13, 18)
        Me.rdoZoom.Name = "rdoZoom"
        Me.rdoZoom.Size = New System.Drawing.Size(77, 16)
        Me.rdoZoom.TabIndex = 0
        Me.rdoZoom.TabStop = True
        Me.rdoZoom.Text = "拡大/縮小"
        Me.rdoZoom.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rdoAuto)
        Me.groupBox1.Controls.Add(Me.rdoDirectionH)
        Me.groupBox1.Controls.Add(Me.rdoDirectionV)
        Me.groupBox1.Location = New System.Drawing.Point(6, 6)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.groupBox1.Size = New System.Drawing.Size(340, 50)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "印刷の向き"
        '
        'rdoAuto
        '
        Me.rdoAuto.Checked = True
        Me.rdoAuto.Location = New System.Drawing.Point(13, 18)
        Me.rdoAuto.Name = "rdoAuto"
        Me.rdoAuto.Size = New System.Drawing.Size(80, 24)
        Me.rdoAuto.TabIndex = 0
        Me.rdoAuto.TabStop = True
        Me.rdoAuto.Text = "自動"
        Me.rdoAuto.UseVisualStyleBackColor = True
        '
        'rdoDirectionH
        '
        Me.rdoDirectionH.Location = New System.Drawing.Point(185, 18)
        Me.rdoDirectionH.Name = "rdoDirectionH"
        Me.rdoDirectionH.Size = New System.Drawing.Size(80, 24)
        Me.rdoDirectionH.TabIndex = 2
        Me.rdoDirectionH.Text = "横"
        Me.rdoDirectionH.UseVisualStyleBackColor = True
        '
        'rdoDirectionV
        '
        Me.rdoDirectionV.Location = New System.Drawing.Point(99, 18)
        Me.rdoDirectionV.Name = "rdoDirectionV"
        Me.rdoDirectionV.Size = New System.Drawing.Size(80, 24)
        Me.rdoDirectionV.TabIndex = 1
        Me.rdoDirectionV.Text = "縦"
        Me.rdoDirectionV.UseVisualStyleBackColor = True
        '
        'tpMergin
        '
        Me.tpMergin.Controls.Add(Me.groupBox4)
        Me.tpMergin.Controls.Add(Me.groupBox3)
        Me.tpMergin.Controls.Add(Me.groupBox5)
        Me.tpMergin.Location = New System.Drawing.Point(4, 22)
        Me.tpMergin.Name = "tpMergin"
        Me.tpMergin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMergin.Size = New System.Drawing.Size(352, 283)
        Me.tpMergin.TabIndex = 1
        Me.tpMergin.Text = "余白"
        Me.tpMergin.UseVisualStyleBackColor = True
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.numFooterHeight)
        Me.groupBox4.Controls.Add(Me.label12)
        Me.groupBox4.Controls.Add(Me.numHeaderHeight)
        Me.groupBox4.Controls.Add(Me.label11)
        Me.groupBox4.Location = New System.Drawing.Point(6, 87)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(340, 75)
        Me.groupBox4.TabIndex = 1
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "高さ"
        '
        'numFooterHeight
        '
        Me.numFooterHeight.Location = New System.Drawing.Point(48, 43)
        Me.numFooterHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numFooterHeight.Name = "numFooterHeight"
        Me.numFooterHeight.Size = New System.Drawing.Size(80, 19)
        Me.numFooterHeight.TabIndex = 3
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(11, 46)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(28, 12)
        Me.label12.TabIndex = 2
        Me.label12.Text = "フッタ"
        '
        'numHeaderHeight
        '
        Me.numHeaderHeight.Location = New System.Drawing.Point(48, 18)
        Me.numHeaderHeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numHeaderHeight.Name = "numHeaderHeight"
        Me.numHeaderHeight.Size = New System.Drawing.Size(80, 19)
        Me.numHeaderHeight.TabIndex = 1
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(11, 20)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(31, 12)
        Me.label11.TabIndex = 0
        Me.label11.Text = "ヘッダ"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.numMerginBottom)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.numMerginTop)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Controls.Add(Me.numMerginRight)
        Me.groupBox3.Controls.Add(Me.label8)
        Me.groupBox3.Controls.Add(Me.numMerginLeft)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Location = New System.Drawing.Point(6, 6)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(340, 75)
        Me.groupBox3.TabIndex = 0
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "余白"
        '
        'numMerginBottom
        '
        Me.numMerginBottom.Location = New System.Drawing.Point(143, 44)
        Me.numMerginBottom.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numMerginBottom.Name = "numMerginBottom"
        Me.numMerginBottom.Size = New System.Drawing.Size(80, 19)
        Me.numMerginBottom.TabIndex = 7
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(120, 46)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(17, 12)
        Me.label10.TabIndex = 6
        Me.label10.Text = "下"
        '
        'numMerginTop
        '
        Me.numMerginTop.Location = New System.Drawing.Point(34, 44)
        Me.numMerginTop.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numMerginTop.Name = "numMerginTop"
        Me.numMerginTop.Size = New System.Drawing.Size(80, 19)
        Me.numMerginTop.TabIndex = 5
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(11, 46)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(17, 12)
        Me.label9.TabIndex = 4
        Me.label9.Text = "上"
        '
        'numMerginRight
        '
        Me.numMerginRight.Location = New System.Drawing.Point(143, 19)
        Me.numMerginRight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numMerginRight.Name = "numMerginRight"
        Me.numMerginRight.Size = New System.Drawing.Size(80, 19)
        Me.numMerginRight.TabIndex = 3
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(120, 21)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(17, 12)
        Me.label8.TabIndex = 2
        Me.label8.Text = "右"
        '
        'numMerginLeft
        '
        Me.numMerginLeft.Location = New System.Drawing.Point(34, 18)
        Me.numMerginLeft.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numMerginLeft.Name = "numMerginLeft"
        Me.numMerginLeft.Size = New System.Drawing.Size(80, 19)
        Me.numMerginLeft.TabIndex = 1
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(11, 21)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(17, 12)
        Me.label7.TabIndex = 0
        Me.label7.Text = "左"
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.ckbCenterV)
        Me.groupBox5.Controls.Add(Me.ckbCenterH)
        Me.groupBox5.Location = New System.Drawing.Point(6, 168)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Padding = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.groupBox5.Size = New System.Drawing.Size(340, 70)
        Me.groupBox5.TabIndex = 2
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "ページ中央"
        '
        'ckbCenterV
        '
        Me.ckbCenterV.AutoSize = True
        Me.ckbCenterV.Location = New System.Drawing.Point(13, 40)
        Me.ckbCenterV.Name = "ckbCenterV"
        Me.ckbCenterV.Size = New System.Drawing.Size(48, 16)
        Me.ckbCenterV.TabIndex = 1
        Me.ckbCenterV.Text = "垂直"
        Me.ckbCenterV.UseVisualStyleBackColor = True
        '
        'ckbCenterH
        '
        Me.ckbCenterH.AutoSize = True
        Me.ckbCenterH.Location = New System.Drawing.Point(13, 18)
        Me.ckbCenterH.Name = "ckbCenterH"
        Me.ckbCenterH.Size = New System.Drawing.Size(48, 16)
        Me.ckbCenterH.TabIndex = 0
        Me.ckbCenterH.Text = "水平"
        Me.ckbCenterH.UseVisualStyleBackColor = True
        '
        'tpHeaderFooter
        '
        Me.tpHeaderFooter.Controls.Add(Me.groupBox7)
        Me.tpHeaderFooter.Controls.Add(Me.groupBox6)
        Me.tpHeaderFooter.Location = New System.Drawing.Point(4, 22)
        Me.tpHeaderFooter.Name = "tpHeaderFooter"
        Me.tpHeaderFooter.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHeaderFooter.Size = New System.Drawing.Size(352, 283)
        Me.tpHeaderFooter.TabIndex = 2
        Me.tpHeaderFooter.Text = "ヘッダ／フッタ"
        Me.tpHeaderFooter.UseVisualStyleBackColor = True
        '
        'groupBox7
        '
        Me.groupBox7.Controls.Add(Me.cmbFooter)
        Me.groupBox7.Controls.Add(Me.txtFooter)
        Me.groupBox7.Location = New System.Drawing.Point(6, 87)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(340, 75)
        Me.groupBox7.TabIndex = 1
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "フッタ"
        '
        'cmbFooter
        '
        Me.cmbFooter.FormattingEnabled = True
        Me.cmbFooter.Location = New System.Drawing.Point(6, 43)
        Me.cmbFooter.Name = "cmbFooter"
        Me.cmbFooter.Size = New System.Drawing.Size(328, 20)
        Me.cmbFooter.TabIndex = 1
        '
        'txtFooter
        '
        Me.txtFooter.Location = New System.Drawing.Point(6, 18)
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Size = New System.Drawing.Size(328, 19)
        Me.txtFooter.TabIndex = 0
        '
        'groupBox6
        '
        Me.groupBox6.Controls.Add(Me.cmbHeader)
        Me.groupBox6.Controls.Add(Me.txtHeader)
        Me.groupBox6.Location = New System.Drawing.Point(6, 6)
        Me.groupBox6.Name = "groupBox6"
        Me.groupBox6.Size = New System.Drawing.Size(340, 75)
        Me.groupBox6.TabIndex = 0
        Me.groupBox6.TabStop = False
        Me.groupBox6.Text = "ヘッダ"
        '
        'cmbHeader
        '
        Me.cmbHeader.FormattingEnabled = True
        Me.cmbHeader.Location = New System.Drawing.Point(6, 43)
        Me.cmbHeader.Name = "cmbHeader"
        Me.cmbHeader.Size = New System.Drawing.Size(328, 20)
        Me.cmbHeader.TabIndex = 1
        '
        'txtHeader
        '
        Me.txtHeader.Location = New System.Drawing.Point(6, 18)
        Me.txtHeader.Name = "txtHeader"
        Me.txtHeader.Size = New System.Drawing.Size(328, 19)
        Me.txtHeader.TabIndex = 0
        '
        'tpSheet
        '
        Me.tpSheet.Controls.Add(Me.groupBox9)
        Me.tpSheet.Controls.Add(Me.groupBox10)
        Me.tpSheet.Controls.Add(Me.groupBox8)
        Me.tpSheet.Location = New System.Drawing.Point(4, 22)
        Me.tpSheet.Name = "tpSheet"
        Me.tpSheet.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSheet.Size = New System.Drawing.Size(352, 283)
        Me.tpSheet.TabIndex = 3
        Me.tpSheet.Text = "シート"
        Me.tpSheet.UseVisualStyleBackColor = True
        '
        'groupBox9
        '
        Me.groupBox9.Controls.Add(Me.label18)
        Me.groupBox9.Controls.Add(Me.numRepeatRightCol)
        Me.groupBox9.Controls.Add(Me.numRepeatLeftCol)
        Me.groupBox9.Controls.Add(Me.label19)
        Me.groupBox9.Controls.Add(Me.numRepeatBottomRow)
        Me.groupBox9.Controls.Add(Me.label20)
        Me.groupBox9.Controls.Add(Me.numRepeatTopRow)
        Me.groupBox9.Controls.Add(Me.label22)
        Me.groupBox9.Location = New System.Drawing.Point(6, 87)
        Me.groupBox9.Name = "groupBox9"
        Me.groupBox9.Size = New System.Drawing.Size(340, 75)
        Me.groupBox9.TabIndex = 0
        Me.groupBox9.TabStop = False
        Me.groupBox9.Text = "印刷タイトル"
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.Location = New System.Drawing.Point(154, 45)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(51, 12)
        Me.label18.TabIndex = 14
        Me.label18.Text = "最後の列"
        '
        'numRepeatRightCol
        '
        Me.numRepeatRightCol.Location = New System.Drawing.Point(211, 43)
        Me.numRepeatRightCol.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRepeatRightCol.Name = "numRepeatRightCol"
        Me.numRepeatRightCol.Size = New System.Drawing.Size(80, 19)
        Me.numRepeatRightCol.TabIndex = 15
        Me.numRepeatRightCol.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'numRepeatLeftCol
        '
        Me.numRepeatLeftCol.Location = New System.Drawing.Point(63, 43)
        Me.numRepeatLeftCol.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRepeatLeftCol.Name = "numRepeatLeftCol"
        Me.numRepeatLeftCol.Size = New System.Drawing.Size(80, 19)
        Me.numRepeatLeftCol.TabIndex = 13
        Me.numRepeatLeftCol.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'label19
        '
        Me.label19.AutoSize = True
        Me.label19.Location = New System.Drawing.Point(6, 45)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(51, 12)
        Me.label19.TabIndex = 12
        Me.label19.Text = "最初の列"
        '
        'numRepeatBottomRow
        '
        Me.numRepeatBottomRow.Location = New System.Drawing.Point(211, 18)
        Me.numRepeatBottomRow.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRepeatBottomRow.Name = "numRepeatBottomRow"
        Me.numRepeatBottomRow.Size = New System.Drawing.Size(80, 19)
        Me.numRepeatBottomRow.TabIndex = 11
        Me.numRepeatBottomRow.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(154, 20)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(51, 12)
        Me.label20.TabIndex = 10
        Me.label20.Text = "最後の行"
        '
        'numRepeatTopRow
        '
        Me.numRepeatTopRow.Location = New System.Drawing.Point(63, 18)
        Me.numRepeatTopRow.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRepeatTopRow.Name = "numRepeatTopRow"
        Me.numRepeatTopRow.Size = New System.Drawing.Size(80, 19)
        Me.numRepeatTopRow.TabIndex = 9
        Me.numRepeatTopRow.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.Location = New System.Drawing.Point(6, 20)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(51, 12)
        Me.label22.TabIndex = 8
        Me.label22.Text = "最初の行"
        '
        'groupBox10
        '
        Me.groupBox10.Controls.Add(Me.cmbCellNote)
        Me.groupBox10.Controls.Add(Me.label13)
        Me.groupBox10.Controls.Add(Me.rdoPageOrderAuto)
        Me.groupBox10.Controls.Add(Me.rdoPageOrderTopBottom)
        Me.groupBox10.Controls.Add(Me.rdoPageOrderLeftRight)
        Me.groupBox10.Controls.Add(Me.label23)
        Me.groupBox10.Controls.Add(Me.ckbColHeader)
        Me.groupBox10.Controls.Add(Me.ckbRowHeader)
        Me.groupBox10.Controls.Add(Me.ckbGrid)
        Me.groupBox10.Controls.Add(Me.ckbBorder)
        Me.groupBox10.Location = New System.Drawing.Point(6, 168)
        Me.groupBox10.Name = "groupBox10"
        Me.groupBox10.Size = New System.Drawing.Size(340, 109)
        Me.groupBox10.TabIndex = 0
        Me.groupBox10.TabStop = False
        Me.groupBox10.Text = "印刷"
        '
        'cmbCellNote
        '
        Me.cmbCellNote.FormattingEnabled = True
        Me.cmbCellNote.Location = New System.Drawing.Point(89, 71)
        Me.cmbCellNote.Name = "cmbCellNote"
        Me.cmbCellNote.Size = New System.Drawing.Size(121, 20)
        Me.cmbCellNote.TabIndex = 9
        '
        'label13
        '
        Me.label13.AutoSize = True
        Me.label13.Location = New System.Drawing.Point(6, 74)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(51, 12)
        Me.label13.TabIndex = 8
        Me.label13.Text = "セルノート"
        '
        'rdoPageOrderAuto
        '
        Me.rdoPageOrderAuto.AutoSize = True
        Me.rdoPageOrderAuto.Checked = True
        Me.rdoPageOrderAuto.Location = New System.Drawing.Point(89, 44)
        Me.rdoPageOrderAuto.Name = "rdoPageOrderAuto"
        Me.rdoPageOrderAuto.Size = New System.Drawing.Size(47, 16)
        Me.rdoPageOrderAuto.TabIndex = 7
        Me.rdoPageOrderAuto.TabStop = True
        Me.rdoPageOrderAuto.Text = "自動"
        Me.rdoPageOrderAuto.UseVisualStyleBackColor = True
        '
        'rdoPageOrderTopBottom
        '
        Me.rdoPageOrderTopBottom.AutoSize = True
        Me.rdoPageOrderTopBottom.Location = New System.Drawing.Point(251, 44)
        Me.rdoPageOrderTopBottom.Name = "rdoPageOrderTopBottom"
        Me.rdoPageOrderTopBottom.Size = New System.Drawing.Size(65, 16)
        Me.rdoPageOrderTopBottom.TabIndex = 6
        Me.rdoPageOrderTopBottom.Text = "上から下"
        Me.rdoPageOrderTopBottom.UseVisualStyleBackColor = True
        '
        'rdoPageOrderLeftRight
        '
        Me.rdoPageOrderLeftRight.AutoSize = True
        Me.rdoPageOrderLeftRight.Location = New System.Drawing.Point(170, 44)
        Me.rdoPageOrderLeftRight.Name = "rdoPageOrderLeftRight"
        Me.rdoPageOrderLeftRight.Size = New System.Drawing.Size(65, 16)
        Me.rdoPageOrderLeftRight.TabIndex = 5
        Me.rdoPageOrderLeftRight.Text = "左から右"
        Me.rdoPageOrderLeftRight.UseVisualStyleBackColor = True
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.Location = New System.Drawing.Point(6, 46)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(69, 12)
        Me.label23.TabIndex = 4
        Me.label23.Text = "ページの方向"
        '
        'ckbColHeader
        '
        Me.ckbColHeader.Checked = True
        Me.ckbColHeader.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbColHeader.Location = New System.Drawing.Point(251, 18)
        Me.ckbColHeader.Name = "ckbColHeader"
        Me.ckbColHeader.Size = New System.Drawing.Size(75, 20)
        Me.ckbColHeader.TabIndex = 3
        Me.ckbColHeader.Text = "列ヘッダ"
        Me.ckbColHeader.UseVisualStyleBackColor = True
        '
        'ckbRowHeader
        '
        Me.ckbRowHeader.Checked = True
        Me.ckbRowHeader.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbRowHeader.Location = New System.Drawing.Point(170, 18)
        Me.ckbRowHeader.Name = "ckbRowHeader"
        Me.ckbRowHeader.Size = New System.Drawing.Size(75, 20)
        Me.ckbRowHeader.TabIndex = 2
        Me.ckbRowHeader.Text = "行ヘッダ"
        Me.ckbRowHeader.UseVisualStyleBackColor = True
        '
        'ckbGrid
        '
        Me.ckbGrid.Checked = True
        Me.ckbGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbGrid.Location = New System.Drawing.Point(89, 18)
        Me.ckbGrid.Name = "ckbGrid"
        Me.ckbGrid.Size = New System.Drawing.Size(75, 20)
        Me.ckbGrid.TabIndex = 1
        Me.ckbGrid.Text = "グリッド線"
        Me.ckbGrid.UseVisualStyleBackColor = True
        '
        'ckbBorder
        '
        Me.ckbBorder.Checked = True
        Me.ckbBorder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbBorder.Location = New System.Drawing.Point(8, 18)
        Me.ckbBorder.Name = "ckbBorder"
        Me.ckbBorder.Size = New System.Drawing.Size(75, 20)
        Me.ckbBorder.TabIndex = 0
        Me.ckbBorder.Text = "枠線"
        Me.ckbBorder.UseVisualStyleBackColor = True
        '
        'groupBox8
        '
        Me.groupBox8.Controls.Add(Me.label21)
        Me.groupBox8.Controls.Add(Me.numRangeRightCol)
        Me.groupBox8.Controls.Add(Me.numRangeLeftCol)
        Me.groupBox8.Controls.Add(Me.label15)
        Me.groupBox8.Controls.Add(Me.numRangeBottomRow)
        Me.groupBox8.Controls.Add(Me.label16)
        Me.groupBox8.Controls.Add(Me.numRangeTopRow)
        Me.groupBox8.Controls.Add(Me.label17)
        Me.groupBox8.Location = New System.Drawing.Point(6, 6)
        Me.groupBox8.Name = "groupBox8"
        Me.groupBox8.Size = New System.Drawing.Size(340, 75)
        Me.groupBox8.TabIndex = 0
        Me.groupBox8.TabStop = False
        Me.groupBox8.Text = "印刷範囲"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(154, 47)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(51, 12)
        Me.label21.TabIndex = 6
        Me.label21.Text = "最後の列"
        '
        'numRangeRightCol
        '
        Me.numRangeRightCol.Location = New System.Drawing.Point(211, 45)
        Me.numRangeRightCol.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRangeRightCol.Name = "numRangeRightCol"
        Me.numRangeRightCol.Size = New System.Drawing.Size(80, 19)
        Me.numRangeRightCol.TabIndex = 7
        Me.numRangeRightCol.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'numRangeLeftCol
        '
        Me.numRangeLeftCol.Location = New System.Drawing.Point(63, 43)
        Me.numRangeLeftCol.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRangeLeftCol.Name = "numRangeLeftCol"
        Me.numRangeLeftCol.Size = New System.Drawing.Size(80, 19)
        Me.numRangeLeftCol.TabIndex = 5
        Me.numRangeLeftCol.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Location = New System.Drawing.Point(6, 45)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(51, 12)
        Me.label15.TabIndex = 4
        Me.label15.Text = "最初の列"
        '
        'numRangeBottomRow
        '
        Me.numRangeBottomRow.Location = New System.Drawing.Point(211, 18)
        Me.numRangeBottomRow.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRangeBottomRow.Name = "numRangeBottomRow"
        Me.numRangeBottomRow.Size = New System.Drawing.Size(80, 19)
        Me.numRangeBottomRow.TabIndex = 3
        Me.numRangeBottomRow.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'label16
        '
        Me.label16.AutoSize = True
        Me.label16.Location = New System.Drawing.Point(154, 20)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(51, 12)
        Me.label16.TabIndex = 2
        Me.label16.Text = "最後の行"
        '
        'numRangeTopRow
        '
        Me.numRangeTopRow.Location = New System.Drawing.Point(63, 18)
        Me.numRangeTopRow.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me.numRangeTopRow.Name = "numRangeTopRow"
        Me.numRangeTopRow.Size = New System.Drawing.Size(80, 19)
        Me.numRangeTopRow.TabIndex = 1
        Me.numRangeTopRow.Value = New Decimal(New Integer() {1, 0, 0, -2147483648})
        '
        'label17
        '
        Me.label17.AutoSize = True
        Me.label17.Location = New System.Drawing.Point(6, 20)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(51, 12)
        Me.label17.TabIndex = 0
        Me.label17.Text = "最初の行"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(297, 327)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnPreview.Location = New System.Drawing.Point(93, 327)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(100, 23)
        Me.btnPreview.TabIndex = 5
        Me.btnPreview.Text = "印刷プレビュー"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 327)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "印刷"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintSettingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 362)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.tabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintSettingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ページ設定"
        Me.tabControl1.ResumeLayout(False)
        Me.tpPage.ResumeLayout(False)
        Me.tpPage.PerformLayout()
        CType(Me.numFirstPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.numByPageV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numByPageH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.tpMergin.ResumeLayout(False)
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        CType(Me.numFooterHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        CType(Me.numMerginBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMerginTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMerginRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMerginLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.tpHeaderFooter.ResumeLayout(False)
        Me.tpHeaderFooter.PerformLayout()
        Me.groupBox7.ResumeLayout(False)
        Me.groupBox7.PerformLayout()
        Me.groupBox6.ResumeLayout(False)
        Me.groupBox6.PerformLayout()
        Me.tpSheet.ResumeLayout(False)
        Me.groupBox9.ResumeLayout(False)
        Me.groupBox9.PerformLayout()
        CType(Me.numRepeatRightCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRepeatLeftCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRepeatBottomRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRepeatTopRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox10.ResumeLayout(False)
        Me.groupBox10.PerformLayout()
        Me.groupBox8.ResumeLayout(False)
        Me.groupBox8.PerformLayout()
        CType(Me.numRangeRightCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRangeLeftCol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRangeBottomRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRangeTopRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpPage As System.Windows.Forms.TabPage
    Private WithEvents numFirstPage As System.Windows.Forms.NumericUpDown
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cmbPaperSize As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents numByPageV As System.Windows.Forms.NumericUpDown
    Private WithEvents numByPageH As System.Windows.Forms.NumericUpDown
    Private WithEvents numZoom As System.Windows.Forms.NumericUpDown
    Private WithEvents rdoByPage As System.Windows.Forms.RadioButton
    Private WithEvents rdoZoom As System.Windows.Forms.RadioButton
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rdoAuto As System.Windows.Forms.RadioButton
    Private WithEvents rdoDirectionH As System.Windows.Forms.RadioButton
    Private WithEvents rdoDirectionV As System.Windows.Forms.RadioButton
    Private WithEvents tpMergin As System.Windows.Forms.TabPage
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents numFooterHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents numHeaderHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents numMerginBottom As System.Windows.Forms.NumericUpDown
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents numMerginTop As System.Windows.Forms.NumericUpDown
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents numMerginRight As System.Windows.Forms.NumericUpDown
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents numMerginLeft As System.Windows.Forms.NumericUpDown
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents groupBox5 As System.Windows.Forms.GroupBox
    Private WithEvents ckbCenterV As System.Windows.Forms.CheckBox
    Private WithEvents ckbCenterH As System.Windows.Forms.CheckBox
    Private WithEvents tpHeaderFooter As System.Windows.Forms.TabPage
    Private WithEvents lnkControlCommand As System.Windows.Forms.LinkLabel
    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Private WithEvents cmbFooter As System.Windows.Forms.ComboBox
    Private WithEvents txtFooter As System.Windows.Forms.TextBox
    Private WithEvents groupBox6 As System.Windows.Forms.GroupBox
    Private WithEvents cmbHeader As System.Windows.Forms.ComboBox
    Private WithEvents txtHeader As System.Windows.Forms.TextBox
    Private WithEvents tpSheet As System.Windows.Forms.TabPage
    Private WithEvents groupBox9 As System.Windows.Forms.GroupBox
    Private WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents numRepeatRightCol As System.Windows.Forms.NumericUpDown
    Private WithEvents numRepeatLeftCol As System.Windows.Forms.NumericUpDown
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents numRepeatBottomRow As System.Windows.Forms.NumericUpDown
    Private WithEvents label20 As System.Windows.Forms.Label
    Private WithEvents numRepeatTopRow As System.Windows.Forms.NumericUpDown
    Private WithEvents label22 As System.Windows.Forms.Label
    Private WithEvents groupBox10 As System.Windows.Forms.GroupBox
    Private WithEvents cmbCellNote As System.Windows.Forms.ComboBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents rdoPageOrderAuto As System.Windows.Forms.RadioButton
    Private WithEvents rdoPageOrderTopBottom As System.Windows.Forms.RadioButton
    Private WithEvents rdoPageOrderLeftRight As System.Windows.Forms.RadioButton
    Private WithEvents label23 As System.Windows.Forms.Label
    Private WithEvents ckbColHeader As System.Windows.Forms.CheckBox
    Private WithEvents ckbRowHeader As System.Windows.Forms.CheckBox
    Private WithEvents ckbGrid As System.Windows.Forms.CheckBox
    Private WithEvents ckbBorder As System.Windows.Forms.CheckBox
    Private WithEvents groupBox8 As System.Windows.Forms.GroupBox
    Private WithEvents label21 As System.Windows.Forms.Label
    Private WithEvents numRangeRightCol As System.Windows.Forms.NumericUpDown
    Private WithEvents numRangeLeftCol As System.Windows.Forms.NumericUpDown
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents numRangeBottomRow As System.Windows.Forms.NumericUpDown
    Private WithEvents label16 As System.Windows.Forms.Label
    Private WithEvents numRangeTopRow As System.Windows.Forms.NumericUpDown
    Private WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnPreview As System.Windows.Forms.Button
    Private WithEvents btnPrint As System.Windows.Forms.Button
End Class
