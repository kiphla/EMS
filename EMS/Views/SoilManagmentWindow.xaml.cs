using System;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Services;

namespace EMS.Views
{
    public partial class SoilManagmentWindow : Window
    {
        private readonly SoilManagement _soilManagement;

        public SoilManagmentWindow()
        {
            InitializeComponent();
            _soilManagement = new SoilManagement();
            LoadSoilData();
        }

        private void LoadSoilData()
        {
            try
            {
                var soilData = _soilManagement.GetAllSoilData();
                dgSoilData.ItemsSource = soilData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading soil data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddSoilData_Click(object sender, RoutedEventArgs e)
        {
            var frame = new Frame();
            frame.Content = new AddSoilDataPage();
            var window = new Window
            {
                Content = frame,
                Title = "Add Soil Data",
                Width = 800,
                Height = 600,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            window.Closed += (s, args) =>
            {
                LoadSoilData(); // Refresh the data grid when the add window is closed
            };

            window.Show();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            var logoutWindow = new LogoutWindow();
            if (logoutWindow.ShowDialog() == true)
            {
                Application.Current.MainWindow.Show();
                this.Close();
            }
        }

        private void CboMetric_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboMetric.SelectedItem != null)
            {
                // TODO: Update chart based on selected metric
                // UpdateChart(((ComboBoxItem)cboMetric.SelectedItem).Content.ToString());
            }
        }
    }
}
