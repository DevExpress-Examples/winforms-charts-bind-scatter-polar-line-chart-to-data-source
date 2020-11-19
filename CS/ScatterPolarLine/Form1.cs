using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;
using DevExpress.Utils;
using System.Data;

namespace ScatterPolarLine {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl scatterPolarLineChart = new ChartControl();

            // Add the chart to the form.
            scatterPolarLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(scatterPolarLineChart);
            scatterPolarLineChart.DataSource = CreateChartData();
          
            // Create a scatter polar line series.
            Series series = new Series("Series 1", ViewType.ScatterPolarLine);
            series.ArgumentDataMember = "Angle";
            series.ValueDataMembers.AddRange(new string[] { "Distance" });
            scatterPolarLineChart.Series.Add(series);
            ScatterPolarLineSeriesView view = (ScatterPolarLineSeriesView)series.View;
            
            // Hide markers.
            view.MarkerVisibility = DefaultBoolean.False;
            // Hide the line that connects the first and last point.
            view.Closed = false;

            // Hide the legend (if necessary).
            scatterPolarLineChart.Legend.Visibility = DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            scatterPolarLineChart.Titles.Add(new ChartTitle());
            scatterPolarLineChart.Titles[0].Text = "Archimedean Spiral";
        }

        private DataTable CreateChartData() {
            DataTable table = new DataTable("Table1");
            table.Columns.Add("Angle", typeof(double));
            table.Columns.Add("Distance", typeof(double));

            double minAngle = 0;
            double maxAngle = 720;
            int intervalsCount = 72;
            double angleStep = (maxAngle - minAngle) / (double)intervalsCount;
            for (int pointIndex = 0; pointIndex <= intervalsCount; pointIndex++) {
                double angle = minAngle + pointIndex * angleStep;
                double angleRadians = angle * Math.PI / 180.0;
                double distance = angleRadians;
                double normalizeAngle = angle % 360;
                table.Rows.Add(new object[] { normalizeAngle, distance });
            }
            return table;
        }
    }
}
