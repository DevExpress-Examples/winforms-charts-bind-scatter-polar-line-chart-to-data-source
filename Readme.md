<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ScatterPolarLine/Form1.cs) (VB: [Form1.vb](./VB/ScatterPolarLine/Form1.vb))
<!-- default file list end -->
# How to bind a Scatter Polar Line Chart to a Data Source

 The following example binds a [Scatter Polar Line Chart](xref:113900) to a data table:

* Create an instance of the [Chart Control](xref:DevExpress.XtraCharts.ChartControl) class and specify the [ChartControl.DataSource](xref:DevExpress.XtraCharts.ChartControl.DataSource) property.

* Create a [Series](xref:DevExpress.XtraCharts.Series) and specify the [Series.Name](xref:DevExpress.XtraCharts.Series.Name) and [ViewType](xref:DevExpress.XtraCharts.ViewType) in the series constructor. Set the [Series.ArgumentDataMember](xref:DevExpress.XtraCharts.SeriesBase.ArgumentDataMember) property to a data source field that contains series point arguments, and the [Series.ValueDataMembers](xref:DevExpress.XtraCharts.SeriesBase.ValueDataMembers) property - to a data source field that contains values. Add this series to the [ChartControl.Series](xref:DevExpress.XtraCharts.ChartControl.Series) collection.
 
* Cast the [Series.View](xref:DevExpress.XtraCharts.SeriesBase.View) property to the [ScatterPolarLineSeriesView](xref:DevExpress.XtraCharts.ScatterPolarLineSeriesView) and use the [RadarLineSeriesView.MarkerVisibility](xref:DevExpress.XtraCharts.RadarLineSeriesView.MarkerVisibility) property to hide markers. Set the [ScatterPolarLineSeriesView.Closed](xref:DevExpress.XtraCharts.RadarLineSeriesView.Closed) property to false to hide the line that connects the first and last point. See the following section for more information about the chart customization: [Change Chart Appearance](#change-chart-appearance).    

* Use the [Legend.Visibility](xref:DevExpress.XtraCharts.Legend.Visibility) property to hide the chart's legend.

* Call the [Titles.Add](xref:DevExpress.XtraCharts.ChartTitleCollection.Add(DevExpress.XtraCharts.ChartTitle)) method to add a chart's title to the [ChartControl.Titles](xref:DevExpress.XtraCharts.ChartControl.Titles) collection.

<br/>
