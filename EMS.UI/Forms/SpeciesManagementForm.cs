using EMS.Core.Models;
using EMS.Core.Services;
using EMS.Core.Utilities;

namespace EMS.UI.Forms {
    public partial class SpeciesManagementForm : Form {
        private readonly SpeciesDataManager _speciesDataManager;

        public SpeciesManagementForm() {
            InitializeComponent();
            _speciesDataManager = new SpeciesDataManager();
        }

        private void SpeciesManagementForm_Load(object sender, EventArgs e) {
            LoadData();
            PopulateSpeciesFilter();
            PopulateChartTypeCombo();
        }

        private void PopulateChartTypeCombo() {
            chartTypeComboBox.Items.Clear();
            chartTypeComboBox.Items.AddRange(new object[] { "Line", "Bar", "Pie" });
            chartTypeComboBox.SelectedIndex = 0;
        }

        private void LoadData(List<SpeciesData>? data = null) {
            dataGridView.DataSource = data ?? _speciesDataManager.GetAll();
            CreateChart();
        }

        private void PopulateSpeciesFilter() {
            var species = _speciesDataManager.GetAllSpecies();
            speciesComboBox.DataSource = species;
            speciesComboBox.DisplayMember = "SpeciesName";
            speciesComboBox.ValueMember = "Id";
        }

        private void CreateChart() {
            ChartHelper.ClearChart(chart);
            var data = (List<SpeciesData>)dataGridView.DataSource ?? new List<SpeciesData>();
            var chartType = chartTypeComboBox?.SelectedItem?.ToString() ?? "Line";

            if (chartType == "Bar") {
                ChartHelper.AddBarSeries(chart, "Population", data, x => x.DateTime, x => x.Population);
            } else if (chartType == "Pie") {
                // group by location and sum populations
                var groups = data.GroupBy(d => d.Location)
                                 .Select(g => new KeyValuePair<string, double>(g.Key, g.Sum(x => x.Population)));
                ChartHelper.AddPieSeriesFromGroups(chart, "Population by Location", groups);
            } else // Line
              {
                ChartHelper.AddLineSeries(chart, "Population", data, x => x.DateTime, x => x.Population);
            }
        }

        private void chartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            CreateChart();
        }

        private void filterButton_Click(object sender, EventArgs e) {
            if (speciesComboBox.SelectedItem != null) {
                var selectedSpecies = (Species)speciesComboBox.SelectedItem;
                var filteredData = _speciesDataManager.FilterBySpecies(selectedSpecies.Id);
                LoadData(filteredData);
            }
        }

        private void addNewSpeciesButton_Click(object sender, EventArgs e) {
            var addNewSpeciesForm = new AddNewSpeciesForm();
            addNewSpeciesForm.ShowDialog();
            PopulateSpeciesFilter();
        }

        private void addSpeciesDataButton_Click(object sender, EventArgs e) {
            var addSpeciesDataForm = new AddSpeciesDataForm();
            addSpeciesDataForm.ShowDialog();
            LoadData();
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

        private void chart_Click(object sender, EventArgs e) {

        }
    }
}