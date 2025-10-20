using System;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Models;
using EMS.Core.Services;

namespace EMS.Views
{
    public partial class AddWaterDataPage : Page
    {
        private readonly WaterManagement _waterManagement;

        public AddWaterDataPage()
        {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
            txtTime.Text = DateTime.Now.ToString("HH:mm");
            _waterManagement = new WaterManagement();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            dpDate.SelectedDate = DateTime.Today;
            txtTime.Text = DateTime.Now.ToString("HH:mm");
            txtPH.Text = string.Empty;
            txtDissolvedOxygen.Text = string.Empty;
            txtSalinity.Text = string.Empty;
            txtTurbidity.Text = string.Empty;
            txtHardness.Text = string.Empty;
            txtEutrophicPotential.Text = string.Empty;
            txtMicrobiology.Text = string.Empty;
            txtContaminants.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private bool ValidateInputs()
        {
            if (!dpDate.SelectedDate.HasValue) return false;
            if (string.IsNullOrWhiteSpace(txtTime.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtPH.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtDissolvedOxygen.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtSalinity.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtTurbidity.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtHardness.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtEutrophicPotential.Text)) return false;

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

                var waterData = new WaterData
                {
                    date = dpDate.SelectedDate!.Value,
                    pH = Convert.ToInt32(float.Parse(txtPH.Text)),
                    dissolvedOxygen = Convert.ToInt32(float.Parse(txtDissolvedOxygen.Text)),
                    salinity = Convert.ToInt32(float.Parse(txtSalinity.Text)),
                    turbidity = Convert.ToInt32(float.Parse(txtTurbidity.Text)),
                    hardness = Convert.ToInt32(float.Parse(txtHardness.Text)),
                    eutrophicPotential = Convert.ToInt32(float.Parse(txtEutrophicPotential.Text)),
                    microbiology = txtMicrobiology.Text,
                    contaminants = txtContaminants.Text
                };

                _waterManagement.AddWaterData(waterData);
                txtStatus.Text = "Water data record added successfully.";
                BtnClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error adding water data: {ex.Message}";
            }
        }
    }
}
