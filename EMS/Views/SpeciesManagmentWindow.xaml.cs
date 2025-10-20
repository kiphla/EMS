using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using EMS.Core.Services;
using EMS.Core.Models;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WPF;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace EMS.Views
{
    public partial class SpeciesManagmentWindow : Window
    {
        private readonly SpeciesManagement _speciesManagement;
        private List<SpeciesData> _currentSpeciesData = new();

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
                _currentSpeciesData = _speciesManagement.GetSpeciesDataBySpecies(speciesId).ToList();
                dgSpeciesData.ItemsSource = _currentSpeciesData;
                txtStatus.Text = $"Loaded {_currentSpeciesData.Count} records.";
                UpdateChart(((ComboBoxItem)cboMetric.SelectedItem)?.Content?.ToString() ?? "Population Trends");
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

        private void UpdateChart(string metric)
        {
            if (_currentSpeciesData == null || _currentSpeciesData.Count == 0) return;

            var values = metric switch
            {
                "Population Trends" => _currentSpeciesData.Select(d => (double)d.populationCount),
                "Reproductive Rates" => _currentSpeciesData.Select(d => (double)d.reproductiveFactor),
                "Activity Indicators" => _currentSpeciesData.Select(d => (double)d.scatCount),
                _ => _currentSpeciesData.Select(d => (double)d.populationCount)
            };

            var dates = _currentSpeciesData.Select(d => d.date.ToString("MM/dd")).ToArray();

            var chart = new CartesianChart
            {
                Series = new ISeries[]
                {
                    new LineSeries<double>
                    {
                        Values = values.ToArray(),
                        Fill = null,
                        GeometrySize = 10,
                        Name = metric
                    }
                },
                XAxes = new Axis[]
                {
                    new Axis
                    {
                        Labels = dates,
                        LabelsRotation = 45
                    }
                },
                YAxes = new Axis[]
                {
                    new Axis
                    {
                        Name = metric
                    }
                }
            };

            chartHolder.Content = chart;
        }

        private void CboMetric_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboMetric.SelectedItem is ComboBoxItem selectedItem && selectedItem.Content is string content)
            {
                UpdateChart(content);
            }
        }
    }
}
