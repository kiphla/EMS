using EMS.Core.Models;
using EMS.Core.Repositories;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Serialization;

namespace EMS.Views
{
    public partial class ExportDataPage : Page
    {
        private readonly SoilRepository _soilRepo;
        private readonly WaterRepository _waterRepo;
        private readonly SpeciesRepository _speciesRepo;

        public ExportDataPage()
        {
            InitializeComponent();
            InitializeDatePickers();

            _soilRepo = new SoilRepository();
            _waterRepo = new WaterRepository();
            _speciesRepo = new SpeciesRepository();
        }

        private void InitializeDatePickers()
        {
            dpStartDate.SelectedDate = DateTime.Today.AddMonths(-1);
            dpEndDate.SelectedDate = DateTime.Today;
        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            string extension = ".csv";

            if (rbJSON.IsChecked == true)
                extension = ".json";
            else if (rbXML.IsChecked == true)
                extension = ".xml";

            dialog.DefaultExt = extension;
            dialog.Filter = $"Data Files (*{extension})|*{extension}";

            if (dialog.ShowDialog() == true)
            {
                txtExportPath.Text = dialog.FileName;
            }
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExportPath.Text))
            {
                txtStatus.Text = "Please select an export location.";
                return;
            }

            if (!dpStartDate.SelectedDate.HasValue || !dpEndDate.SelectedDate.HasValue)
            {
                txtStatus.Text = "Please select valid date range.";
                return;
            }

            try
            {
                var startDate = dpStartDate.SelectedDate.Value;
                var endDate = dpEndDate.SelectedDate.Value;

                // Get data based on selected type
                var data = GetDataByType(startDate, endDate);

                // Export data in selected format
                ExportData(data, txtExportPath.Text);

                txtStatus.Text = "Data exported successfully.";
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error exporting data: {ex.Message}";
            }
        }

        private object GetDataByType(DateTime startDate, DateTime endDate)
        {
            if (rbSoil.IsChecked == true)
            {
                var data = _soilRepo.GetAll();
                return data.Where(d => d.date >= startDate && d.date <= endDate).ToList();
            }
            else if (rbWater.IsChecked == true)
            {
                var data = _waterRepo.GetAll();
                return data.Where(d => d.date >= startDate && d.date <= endDate).ToList();
            }
            else
            {
                var data = _speciesRepo.GetAll();
                // Species doesn't have a date field, so we return all species
                return data;
            }
        }

        private void ExportData(object data, string filePath)
        {
            if (rbJSON.IsChecked == true)
            {
                var jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            else if (rbXML.IsChecked == true)
            {
                using var writer = new StreamWriter(filePath);
                var serializer = new XmlSerializer(data.GetType());
                serializer.Serialize(writer, data);
            }
            else // CSV
            {
                using var writer = new StreamWriter(filePath);

                // Get the list type and first item
                var list = data as System.Collections.IEnumerable;
                if (list == null) return;

                var enumerator = list.GetEnumerator();
                if (!enumerator.MoveNext()) return;
                var firstItem = enumerator.Current;

                // Write headers
                var properties = firstItem.GetType().GetProperties();
                writer.WriteLine(string.Join(",", properties.Select(p => p.Name)));

                // Write first row
                WriteRow(writer, properties, firstItem);

                // Write remaining rows
                while (enumerator.MoveNext())
                {
                    WriteRow(writer, properties, enumerator.Current);
                }
            }
        }

        private void WriteRow(StreamWriter writer, System.Reflection.PropertyInfo[] properties, object item)
        {
            var values = properties.Select(p =>
            {
                var value = p.GetValue(item);
                if (value == null) return "";

                // If it's a date, format it consistently
                if (value is DateTime date)
                    return date.ToString("yyyy-MM-dd HH:mm:ss");

                // If it's a string that might contain commas, wrap it in quotes
                if (value is string str && str.Contains(","))
                    return $"\"{str}\"";

                return value.ToString() ?? "";
            });
            writer.WriteLine(string.Join(",", values));
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
    }
}
