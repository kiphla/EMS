using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class AddWaterDataForm : Form
    {
        private readonly HydrologyDataManager _hydrologyDataManager;

        public AddWaterDataForm()
        {
            InitializeComponent();
            _hydrologyDataManager = new HydrologyDataManager();
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                statusLabel.Text = "Location is required.";
                return;
            }

            try
            {
                var hydrologyData = new HydrologyData
                {
                    DateTime = dateTimePicker.Value,
                    Location = locationTextBox.Text,
                    WaterLevel = (double)waterLevelNumericUpDown.Value,
                    Rainfall = (double)rainfallNumericUpDown.Value,
                    Salinity = (double)salinityNumericUpDown.Value,
                    PH = (double)phNumericUpDown.Value,
                    DissolvedOxygen = (double)dissolvedOxygenNumericUpDown.Value,
                    Turbidity = (double)turbidityNumericUpDown.Value,
                    Temperature = (double)temperatureNumericUpDown.Value
                };

                _hydrologyDataManager.Add(hydrologyData);
                statusLabel.Text = "Record added successfully.";
                ClearFields();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error adding record: " + ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            locationTextBox.Text = string.Empty;
            waterLevelNumericUpDown.Value = 0;
            rainfallNumericUpDown.Value = 0;
            salinityNumericUpDown.Value = 0;
            phNumericUpDown.Value = 0;
            dissolvedOxygenNumericUpDown.Value = 0;
            turbidityNumericUpDown.Value = 0;
            temperatureNumericUpDown.Value = 0;
        }
    }
}