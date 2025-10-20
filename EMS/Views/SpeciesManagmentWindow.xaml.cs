using EMS.Core.Models;
using EMS.Core.Services;
using System;
using System.Windows;
using System.Windows.Controls;

namespace EMS.Views
{
    public partial class SpeciesManagmentWindow : Window
    {
        private readonly SpeciesManagement _speciesManagement;

        public SpeciesManagmentWindow()
        {
            InitializeComponent();
            _speciesManagement = new SpeciesManagement();
            LoadSpecies();
        }

        private void LoadSpecies()
        {
            try
            {
                var species = _speciesManagement.GetAllSpecies();
                cboSpecies.ItemsSource = species;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading species: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadSpeciesData(int speciesId)
        {
            try
            {
                var speciesData = _speciesManagement.GetSpeciesDataBySpecies(speciesId);
                dgSpeciesData.ItemsSource = speciesData;
                txtStatus.Text = $"Loaded {speciesData.Count} records.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading species data: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CboSpecies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSpecies.SelectedItem is Species selectedSpecies)
            {
                LoadSpeciesData(selectedSpecies.speciesID);
            }
        }

        private void BtnAddSpecies_Click(object sender, RoutedEventArgs e)
        {
            var frame = new Frame();
            frame.Content = new AddNewSpeciesPage();
            var window = new Window
            {
                Content = frame,
                Title = "Add New Species",
                Width = 800,
                Height = 600,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Closed += (s, args) =>
            {
                LoadSpecies(); // Refresh the species list when the add window is closed
            };
            window.Show();
        }

        private void BtnAddSpeciesData_Click(object sender, RoutedEventArgs e)
        {
            if (cboSpecies.SelectedItem == null)
            {
                MessageBox.Show("Please select a species first.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var selectedSpecies = cboSpecies.SelectedItem as Species;
            var frame = new Frame();
            frame.Content = new AddSpeciesDataPage(selectedSpecies);
            var window = new Window
            {
                Content = frame,
                Title = $"Add Data for {selectedSpecies?.speciesName}",
                Width = 800,
                Height = 600,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Closed += (s, args) =>
            {
                if (cboSpecies.SelectedValue is int speciesId)
                {
                    LoadSpeciesData(speciesId); // Refresh the data grid when the add window is closed
                }
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

        //private void CboSpecies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    LoadSpeciesData();
        //}

        private void CboMetric_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboMetric.SelectedItem != null)
            {
                // TODO: Update chart based on selected metric
                //UpdateChart(((ComboBoxItem)cboMetric.SelectedItem).Content.ToString());
            }
        }
    }
}
