Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports System.Data

Namespace ScatterPolarLine
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a new chart.
			Dim scatterPolarLineChart As New ChartControl()

			' Add the chart to the form.
			scatterPolarLineChart.Dock = DockStyle.Fill
			Me.Controls.Add(scatterPolarLineChart)
			scatterPolarLineChart.DataSource = CreateChartData()

			' Create a scatter polar line series.
			Dim series As New Series("Series 1", ViewType.ScatterPolarLine)
			series.ArgumentDataMember = "Angle"
			series.ValueDataMembers.AddRange(New String() { "Distance" })
			scatterPolarLineChart.Series.Add(series)
			Dim view As ScatterPolarLineSeriesView = CType(series.View, ScatterPolarLineSeriesView)

			' Hide markers.
			view.MarkerVisibility = DefaultBoolean.False
			' Hide the line that connects the first and last point.
			view.Closed = False

			' Hide the legend (if necessary).
			scatterPolarLineChart.Legend.Visibility = DefaultBoolean.False

			' Add a title to the chart (if necessary).
			scatterPolarLineChart.Titles.Add(New ChartTitle())
			scatterPolarLineChart.Titles(0).Text = "Archimedean Spiral"
		End Sub

		Private Function CreateChartData() As DataTable
			Dim table As New DataTable("Table1")
			table.Columns.Add("Angle", GetType(Double))
			table.Columns.Add("Distance", GetType(Double))

			Dim minAngle As Double = 0
			Dim maxAngle As Double = 720
			Dim intervalsCount As Integer = 72
			Dim angleStep As Double = (maxAngle - minAngle) / CDbl(intervalsCount)
			For pointIndex As Integer = 0 To intervalsCount
				Dim angle As Double = minAngle + pointIndex * angleStep
				Dim angleRadians As Double = angle * Math.PI / 180.0
				Dim distance As Double = angleRadians
				Dim normalizeAngle As Double = angle Mod 360
				table.Rows.Add(New Object() { normalizeAngle, distance })
			Next pointIndex
			Return table
		End Function
	End Class
End Namespace
