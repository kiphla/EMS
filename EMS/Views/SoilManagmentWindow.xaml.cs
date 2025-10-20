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
    public partial class SoilManagmentWindow : Window
    {
        private readonly SoilManagement _soilManagement;
        private List<SoilData> _currentData = new();

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
                _currentData = _soilManagement.GetAllSoilData().ToList();
                dgSoilData.ItemsSource = _currentData;
                UpdateChart(((ComboBoxItem)cboMetric.SelectedItem)?.Content?.ToString() ?? "pH Levels");
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

        private void UpdateChart(string metric)
        {
            if (_currentData == null || _currentData.Count == 0) return;

            var values = metric switch
            {
                "pH Levels" => _currentData.Select(d => (double)d.pH),
                "Moisture Trends" => _currentData.Select(d => (double)d.moisture),
                "Nitrogen Content" => _currentData.Select(d => (double)d.nitrogen),
                "Organic Matter" => _currentData.Select(d => (double)d.organicMatter),
                _ => _currentData.Select(d => (double)d.pH)
            };

            var dates = _currentData.Select(d => d.date.ToString("MM/dd")).ToArray();

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
