using EMS.Core.Services;
using EMS.Core.Utilities;
using EMS.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EMS.UI.Forms
{
    public partial class SoilManagementForm : Form
    {
        private readonly SoilDataManager _soilDataManager;

        public SoilManagementForm()
        {
            InitializeComponent();
            _soilDataManager = new SoilDataManager();
        }

        private void SoilManagementForm_Load(object sender, EventArgs e)
        {
            LoadData();
            PopulateLocationFilter();
            PopulateChartTypeCombo();
        }

        private void PopulateChartTypeCombo()
        {
            chartTypeComboBox.Items.Clear();
            chartTypeComboBox.Items.AddRange(new object[] { "Line", "Bar", "Pie" });
            chartTypeComboBox.SelectedIndex = 0;
        }

        private void LoadData(List<SoilData>? data = null)
        {
            dataGridView.DataSource = data ?? _soilDataManager.GetAll();
            CreateChart();
        }

        private void PopulateLocationFilter()
        {
            var locations = _soilDataManager.GetAll().Select(x => x.Location).Distinct().ToList();
            locationComboBox.DataSource = locations;
        }

        private void CreateChart()
        {
            ChartHelper.ClearChart(chart);
            var data = (List<SoilData>)dataGridView.DataSource ?? new List<SoilData>();
            var chartType = chartTypeComboBox?.SelectedItem?.ToString() ?? "Line";

            if (chartType == "Bar")
            {
                ChartHelper.AddBarSeries(chart, "pH Level", data, x => x.DateTime, x => x.PHLevel);
                ChartHelper.AddBarSeries(chart, "Moisture Level", data, x => x.DateTime, x => x.MoistureLevel);
            }
            else if (chartType == "Pie")
            {
                // group by location and show average PH per location
                var groups = data.GroupBy(d => d.Location)
                                 .Select(g => new KeyValuePair<string, double>(g.Key, g.Average(x => x.PHLevel)));
                ChartHelper.AddPieSeriesFromGroups(chart, "Average PH by Location", groups);
            }
            else // Line
            {
                ChartHelper.AddLineSeries(chart, "pH Level", data, x => x.DateTime, x => x.PHLevel);
                ChartHelper.AddLineSeries(chart, "Moisture Level", data, x => x.DateTime, x => x.MoistureLevel);
            }
        }

        private void chartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateChart();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            var filteredData = _soilDataManager.FilterByDate(startDatePicker.Value, endDatePicker.Value);
            if (locationComboBox.SelectedItem != null)
            {
                filteredData = filteredData.Where(x => x.Location == locationComboBox.SelectedItem.ToString()).ToList();
            }
            LoadData(filteredData);
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            var addSoilDataForm = new AddSoilDataForm();
            addSoilDataForm.ShowDialog();
            LoadData();
            PopulateLocationFilter();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var logoutConfirmationForm = new LogoutConfirmationForm();
            if (logoutConfirmationForm.ShowDialog() == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}