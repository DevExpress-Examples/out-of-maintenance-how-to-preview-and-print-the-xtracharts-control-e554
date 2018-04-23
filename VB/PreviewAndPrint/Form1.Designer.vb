Imports Microsoft.VisualBasic
Imports System
Namespace PreviewAndPrint
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Jan", New Object() { (CObj(10))})
			Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Feb", New Object() { (CObj(8))})
			Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("Mar", New Object() { (CObj(15))})
			Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("Apr", New Object() { (CObj(17))})
			Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("May", New Object() { (CObj(17))})
			Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Jun", New Object() { (CObj(19))})
			Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("Jul", New Object() { (CObj(19))})
			Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Aug", New Object() { (CObj(15))})
			Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint("Sep", New Object() { (CObj(25))})
			Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint("Oct", New Object() { (CObj(13))})
			Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint("Nov", New Object() { (CObj(13))})
			Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint("Dec", New Object() { (CObj(11))})
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.printableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Zoom
			series1.Name = "Series 1"
			series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			Me.chartControl1.Size = New System.Drawing.Size(505, 289)
			Me.chartControl1.TabIndex = 0
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(12, 295)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(110, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Print preview..."
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Location = New System.Drawing.Point(128, 295)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(127, 23)
			Me.simpleButton2.TabIndex = 2
			Me.simpleButton2.Text = "Print directly"
'			Me.simpleButton2.Click += New System.EventHandler(Me.simpleButton2_Click);
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.printableComponentLink1})
			' 
			' printableComponentLink1
			' 
			Me.printableComponentLink1.Component = Me.chartControl1
			Me.printableComponentLink1.CustomPaperSize = New System.Drawing.Size(0, 0)
			Me.printableComponentLink1.Landscape = True
			Me.printableComponentLink1.PrintingSystem = Me.printingSystem1
			Me.printableComponentLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(505, 329)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private printableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
	End Class
End Namespace

