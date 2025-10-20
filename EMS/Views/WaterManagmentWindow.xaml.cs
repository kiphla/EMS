using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class WaterManagmentWindow : Window {
        public WaterManagmentWindow() {
            InitializeComponent();
            LoadWaterData();
        }

        private void LoadWaterData() {
            // TODO: Load water data from repository
            // dgWaterData.ItemsSource = _waterDataRepo.GetAllData();
        }

        private void BtnAddWaterData_Click(object sender, RoutedEventArgs e) {
            var frame = new Frame();
            frame.Content = new AddWaterDataPage();
            var window = new Window {
                Content = frame,
                Title = "Add Water Data",
                Width = 800,
                Height = 600
            };
            window.Show();
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e) {
            var logoutWindow = new LogoutWindow();
            if (logoutWindow.ShowDialog() == true) {
                Application.Current.MainWindow.Show();
                this.Close();
            }
        }

        private void CboMetric_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cboMetric.SelectedItem != null) {
                // TODO: Update chart based on selected metric
                // UpdateChart(((ComboBoxItem)cboMetric.SelectedItem).Content.ToString());
            }
        }
    }
}
