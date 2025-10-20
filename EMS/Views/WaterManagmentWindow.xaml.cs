using System;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Services;

namespace EMS.Views
{
    public partial class WaterManagmentWindow : Window
    {
        private readonly WaterManagement _waterManagement;

        public WaterManagmentWindow()
        {
            InitializeComponent();
            _waterManagement = new WaterManagement();
            LoadWaterData();
        }

        private void LoadWaterData()
        {
            try
            {
                var waterData = _waterManagement.GetAllWaterData();
                dgWaterData.ItemsSource = waterData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading water data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddWaterData_Click(object sender, RoutedEventArgs e)
        {
            var frame = new Frame();
            frame.Content = new AddWaterDataPage();
            var window = new Window
            {
                Content = frame,
                Title = "Add Water Data",
                Width = 800,
                Height = 600,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Closed += (s, args) =>
            {
                LoadWaterData(); // Refresh the data grid when the add window is closed
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
