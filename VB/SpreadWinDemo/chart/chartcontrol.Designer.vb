<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class chartcontrol
    Inherits SpreadWinDemo.DemoBase

    'Form は、コンポーネント一覧に後処理を実行するために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim LabelArea1 As FarPoint.Win.Chart.LabelArea = New FarPoint.Win.Chart.LabelArea()
        Dim LegendArea1 As FarPoint.Win.Chart.LegendArea = New FarPoint.Win.Chart.LegendArea()
        Dim YPlotArea1 As FarPoint.Win.Chart.YPlotArea = New FarPoint.Win.Chart.YPlotArea()
        Dim Wall1 As FarPoint.Win.Chart.Wall = New FarPoint.Win.Chart.Wall()
        Dim Wall2 As FarPoint.Win.Chart.Wall = New FarPoint.Win.Chart.Wall()
        Dim DirectionalLight1 As FarPoint.Win.Chart.DirectionalLight = New FarPoint.Win.Chart.DirectionalLight()
        Dim BarSeries1 As FarPoint.Win.Chart.BarSeries = New FarPoint.Win.Chart.BarSeries()
        Dim Wall3 As FarPoint.Win.Chart.Wall = New FarPoint.Win.Chart.Wall()
        Dim IndexAxis1 As FarPoint.Win.Chart.IndexAxis = New FarPoint.Win.Chart.IndexAxis()
        Dim ValueAxis1 As FarPoint.Win.Chart.ValueAxis = New FarPoint.Win.Chart.ValueAxis()
        Dim IndexAxis2 As FarPoint.Win.Chart.IndexAxis = New FarPoint.Win.Chart.IndexAxis()
        Me.FpChart1 = New FarPoint.Win.Chart.FpChart()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FpChart1)
        '
        'FpChart1
        '
        Me.FpChart1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FpChart1.Location = New System.Drawing.Point(0, 0)
        LabelArea1.AlignmentX = 0.5!
        LabelArea1.Location = New System.Drawing.PointF(0.5!, 0.1!)
        LabelArea1.ManualLayout = False
        LabelArea1.Padding = New FarPoint.Win.Chart.PaddingF(1.5!, 1.5!, 1.5!, 1.5!)
        LabelArea1.Text = "Bar Chart"
        Me.FpChart1.Model.LabelAreas.AddRange(New FarPoint.Win.Chart.LabelArea() {LabelArea1})
        LegendArea1.AlignmentX = 1.0!
        LegendArea1.AlignmentY = 0.5!
        LegendArea1.Location = New System.Drawing.PointF(0.98!, 0.5!)
        LegendArea1.Padding = New FarPoint.Win.Chart.PaddingF(3.0!, 3.0!, 3.0!, 3.0!)
        Me.FpChart1.Model.LegendAreas.AddRange(New FarPoint.Win.Chart.LegendArea() {LegendArea1})
        CType(YPlotArea1, System.ComponentModel.ISupportInitialize).BeginInit()
        Wall1.Visible = True
        YPlotArea1.BackWall = Wall1
        Wall2.Visible = True
        YPlotArea1.BottomWall = Wall2
        YPlotArea1.Elevation = 15.0!
        YPlotArea1.GlobalAmbientLight = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        DirectionalLight1.AmbientColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DirectionalLight1.DiffuseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DirectionalLight1.DirectionX = 10.0!
        DirectionalLight1.DirectionY = 20.0!
        DirectionalLight1.DirectionZ = 30.0!
        DirectionalLight1.SpecularColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        YPlotArea1.Lights.Clear()
        YPlotArea1.Lights.AddRange(New FarPoint.Win.Chart.Light() {DirectionalLight1})
        YPlotArea1.Projection = New FarPoint.Win.Chart.OrthogonalProjection()
        YPlotArea1.Rotation = -10.0!
        BarSeries1.SeriesName = "series"
        YPlotArea1.Series.AddRange(New FarPoint.Win.Chart.Series() {BarSeries1})
        Wall3.Visible = True
        YPlotArea1.SideWall = Wall3
        YPlotArea1.XAxis = IndexAxis1
        YPlotArea1.YAxes.Clear()
        YPlotArea1.YAxes.AddRange(New FarPoint.Win.Chart.ValueAxis() {ValueAxis1})
        YPlotArea1.ZAxis = IndexAxis2
        CType(YPlotArea1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FpChart1.Model.PlotAreas.AddRange(New FarPoint.Win.Chart.PlotArea() {YPlotArea1})
        Me.FpChart1.Name = "FpChart1"
        Me.FpChart1.Size = New System.Drawing.Size(708, 400)
        Me.FpChart1.TabIndex = 0
        Me.FpChart1.Text = "FpChart1"
        '
        'chartcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.Description = "SPREAD上にだけではなく、フォーム上に直接チャートを配置することができます。"
        Me.Name = "chartcontrol"
        Me.Title = "チャートコントロール"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FpChart1 As FarPoint.Win.Chart.FpChart

End Class
