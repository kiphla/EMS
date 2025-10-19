using EMS.Core.Models;
using EMS.Core.Services;
using EMS.Core.Utilities;

namespace EMS.UI.Forms {
    public partial class WaterManagementForm : Form {
        private readonly HydrologyDataManager _hydrologyDataManager;

        public WaterManagementForm() {
            InitializeComponent();
            _hydrologyDataManager = new HydrologyDataManager();
        }

        private void WaterManagementForm_Load(object sender, EventArgs e) {
            LoadData();
            PopulateLocationFilter();
            PopulateChartTypeCombo();
        }

        private void PopulateChartTypeCombo() {
            chartTypeComboBox.Items.Clear();
            chartTypeComboBox.Items.AddRange(new object[] { "Line", "Bar", "Pie" });
            chartTypeComboBox.SelectedIndex = 0;
        }

        private void LoadData(List<HydrologyData>? data = null) {
            dataGridView.DataSource = data ?? _hydrologyDataManager.GetAll();
            CreateChart();
        }

        private void PopulateLocationFilter() {
            var locations = _hydrologyDataManager.GetAll().Select(x => x.Location).Distinct().ToList();
            locationComboBox.DataSource = locations;
        }

        private void CreateChart() {
            ChartHelper.ClearChart(chart);
            var data = (List<HydrologyData>)dataGridView.DataSource ?? new List<HydrologyData>();
            var chartType = chartTypeComboBox?.SelectedItem?.ToString() ?? "Line";

            if (chartType == "Bar") {
                ChartHelper.AddBarSeries(chart, "Water Level", data, x => x.DateTime, x => x.WaterLevel);
                ChartHelper.AddBarSeries(chart, "Rainfall", data, x => x.DateTime, x => x.Rainfall);
                ChartHelper.AddBarSeries(chart, "Salinity", data, x => x.DateTime, x => x.Salinity);
                ChartHelper.AddBarSeries(chart, "pH Level", data, x => x.DateTime, x => x.PHLevel);
                ChartHelper.AddBarSeries(chart, "Dissolved Oxygen", data, x => x.DateTime, x => x.DissolvedOxygen);
                ChartHelper.AddBarSeries(chart, "Turbidity", data, x => x.DateTime, x => x.Turbidity);
                ChartHelper.AddBarSeries(chart, "Temperature", data, x => x.DateTime, x => x.Temperature);
            } else if (chartType == "Pie") {
                var groups = data.GroupBy(d => d.Location)
                                 .Select(g => new KeyValuePair<string, double>(g.Key, g.Average(x => x.PHLevel)));
                ChartHelper.AddPieSeriesFromGroups(chart, "Average PH by Location", groups);
            } else // Line
              {
                ChartHelper.AddLineSeries(chart, "Water Level", data, x => x.DateTime, x => x.WaterLevel);
                ChartHelper.AddLineSeries(chart, "Rainfall", data, x => x.DateTime, x => x.Rainfall);
                ChartHelper.AddLineSeries(chart, "Salinity", data, x => x.DateTime, x => x.Salinity);
                ChartHelper.AddLineSeries(chart, "pH Level", data, x => x.DateTime, x => x.PHLevel);
                ChartHelper.AddLineSeries(chart, "Dissolved Oxygen", data, x => x.DateTime, x => x.DissolvedOxygen);
                ChartHelper.AddLineSeries(chart, "Turbidity", data, x => x.DateTime, x => x.Turbidity);
                ChartHelper.AddLineSeries(chart, "Temperature", data, x => x.DateTime, x => x.Temperature);
            }
        }

        private void chartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            CreateChart();
        }

        private void filterButton_Click(object sender, EventArgs e) {
            var filteredData = _hydrologyDataManager.FilterByDate(startDatePicker.Value, endDatePicker.Value);
            if (locationComboBox.SelectedItem != null) {
                filteredData = filteredData.Where(x => x.Location == locationComboBox.SelectedItem.ToString()).ToList();
            }
            LoadData(filteredData);
        }

        private void addRecordButton_Click(object sender, EventArgs e) {
            var addWaterDataForm = new AddWaterDataForm();
            addWaterDataForm.ShowDialog();
            LoadData();
            PopulateLocationFilter();
        }

        private void homeButton_Click(object sender, EventArgs e) {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e) {
            var logoutConfirmationForm = new LogoutConfirmationForm();
            if (logoutConfirmationForm.ShowDialog() == DialogResult.Yes) {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}