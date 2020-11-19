<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ScatterPolarLine/Form1.cs) (VB: [Form1.vb](./VB/ScatterPolarLine/Form1.vb))
<!-- default file list end -->
# How to bind a Scatter Polar Line Chart to a Data Source

 The following example binds a [Scatter Polar Line Chart](xref:113900) to a data table:

* Create an instance of the [Chart Control](xref:DevExpress.XtraCharts.ChartControl) class and specify the [ChartControl.DataSource](xref:DevExpress.XtraCharts.ChartControl.DataSource) property.

* Create a [Series](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Series) and specify the [Series.Name](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Series.Name) and [ViewType](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ViewType) in the series constructor. Set the [Series.ArgumentDataMember](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.ArgumentDataMember) property to a data source field that contains series point arguments, and the [Series.ValueDataMembers](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.ValueDataMembers) property - to a data source field that contains values. Add this series to the [ChartControl.Series](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Series) collection.
 
* Cast the [Series.View](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.View) property to the [ScatterPolarLineSeriesView](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ScatterPolarLineSeriesView) and use the [ScatterPolarLineSeriesView.MarkerVisibility](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.RadarLineSeriesView.MarkerVisibility) property to hide markers. Set the [ScatterPolarLineSeriesView.Closed](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.RadarLineSeriesView.Closed) property to false to hide the line that connects the first and last point.

* Use the [Legend.Visibility](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Legend.Visibility) property to hide the chart's legend.

* Call the [Titles.Add](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.ChartTitleCollection.Add(DevExpress.XtraCharts.ChartTitle)) method to add a chart's title to the [ChartControl.Titles](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Titles) collection.

<br/>
