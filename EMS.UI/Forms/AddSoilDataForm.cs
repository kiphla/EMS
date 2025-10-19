using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class AddSoilDataForm : Form
    {
        private readonly SoilDataManager _soilDataManager;

        public AddSoilDataForm()
        {
            InitializeComponent();
            _soilDataManager = new SoilDataManager();
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
                var soilData = new SoilData
                {
                    DateTime = dateTimePicker.Value,
                    Location = locationTextBox.Text,
                    PHLevel = (double)phNumericUpDown.Value,
                    MoistureLevel = (double)moistureNumericUpDown.Value,
                    NitrogenLevel = (double)nitrogenNumericUpDown.Value,
                    PhosphorusLevel = (double)phosphorusNumericUpDown.Value,
                    SulphurLevel = (double)sulphurNumericUpDown.Value
                };

                _soilDataManager.Add(soilData);
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
            phNumericUpDown.Value = 0;
            moistureNumericUpDown.Value = 0;
            nitrogenNumericUpDown.Value = 0;
            phosphorusNumericUpDown.Value = 0;
            sulphurNumericUpDown.Value = 0;
        }
    }
}