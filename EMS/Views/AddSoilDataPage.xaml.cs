using System;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Models;
using EMS.Core.Services;

namespace EMS.Views
{
    public partial class AddSoilDataPage : Page
    {
        private readonly SoilManagement _soilManagement;

        public AddSoilDataPage()
        {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
            _soilManagement = new SoilManagement();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            dpDate.SelectedDate = DateTime.Today;
            txtPH.Text = string.Empty;
            txtFirmness.Text = string.Empty;
            txtDensity.Text = string.Empty;
            txtMoisture.Text = string.Empty;
            txtNitrogen.Text = string.Empty;
            txtOrganicMatter.Text = string.Empty;
            txtMicrobiology.Text = string.Empty;
            txtContaminants.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private bool ValidateInputs()
        {
            if (!dpDate.SelectedDate.HasValue) return false;
            if (string.IsNullOrWhiteSpace(txtPH.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtFirmness.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtDensity.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtMoisture.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtNitrogen.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtOrganicMatter.Text)) return false;

            return true;
        }

        private void BtnAddRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                {
                    txtStatus.Text = "Please fill in all required fields with valid values.";
                    return;
                }

                var soilData = new SoilData
                {
                    date = dpDate.SelectedDate!.Value,
                    pH = Convert.ToInt32(float.Parse(txtPH.Text)),
                    firmness = Convert.ToInt32(float.Parse(txtFirmness.Text)),
                    density = Convert.ToInt32(float.Parse(txtDensity.Text)),
                    moisture = Convert.ToInt32(float.Parse(txtMoisture.Text)),
                    nitrogen = Convert.ToInt32(float.Parse(txtNitrogen.Text)),
                    organicMatter = Convert.ToInt32(float.Parse(txtOrganicMatter.Text)),
                    microbiology = txtMicrobiology.Text,
                    contaminants = txtContaminants.Text
                };

                _soilManagement.AddSoilData(soilData);
                txtStatus.Text = "Soil data record added successfully.";
                BtnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error adding soil data: {ex.Message}";
            }
        }
    }
}
