using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class SpeciesManagmentWindow : Window {
        public SpeciesManagmentWindow() {
            InitializeComponent();
            LoadSpecies();
            LoadSpeciesData();
        }

        private void LoadSpecies() {
            // TODO: Load species list from repository
            // cboSpecies.ItemsSource = _speciesRepo.GetAllSpecies();
        }

        private void LoadSpeciesData() {
            // TODO: Load species data from repository based on selected species
            // if (cboSpecies.SelectedItem != null)
            //     dgSpeciesData.ItemsSource = _speciesDataRepo.GetDataForSpecies(((Species)cboSpecies.SelectedItem).SpeciesID);
        }

        private void BtnAddSpecies_Click(object sender, RoutedEventArgs e) {
            var frame = new Frame();
            frame.Content = new AddNewSpeciesPage();
            var window = new Window {
                Content = frame,
                Title = "Add New Species",
                Width = 800,
                Height = 600
            };
            window.Show();
        }

        private void BtnAddSpeciesData_Click(object sender, RoutedEventArgs e) {
            var frame = new Frame();
            frame.Content = new AddSpeciesDataPage();
            var window = new Window {
                Content = frame,
                Title = "Add Species Data",
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

        private void CboSpecies_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            LoadSpeciesData();
        }

        private void CboMetric_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cboMetric.SelectedItem != null) {
                // TODO: Update chart based on selected metric
                // UpdateChart(((ComboBoxItem)cboMetric.SelectedItem).Content.ToString());
            }
        }
    }
}
