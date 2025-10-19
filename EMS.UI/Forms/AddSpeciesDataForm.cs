using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class AddSpeciesDataForm : Form
    {
        private readonly SpeciesDataManager _speciesDataManager;

        public AddSpeciesDataForm()
        {
            InitializeComponent();
            _speciesDataManager = new SpeciesDataManager();
        }

        private void AddSpeciesDataForm_Load(object sender, EventArgs e)
        {
            LoadSpecies();
        }

        private void LoadSpecies()
        {
            var species = _speciesDataManager.GetAllSpecies();
            speciesComboBox.DataSource = species;
            speciesComboBox.DisplayMember = "SpeciesName";
            speciesComboBox.ValueMember = "Id";
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {
            if (speciesComboBox.SelectedItem == null)
            {
                statusLabel.Text = "Please select a species.";
                return;
            }

            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                statusLabel.Text = "Location is required.";
                return;
            }

            try
            {
                var speciesData = new SpeciesData
                {
                    SpeciesId = (int)speciesComboBox.SelectedValue,
                    DateTime = dateTimePicker.Value,
                    Location = locationTextBox.Text,
                    Population = (int)populationNumericUpDown.Value
                };

                _speciesDataManager.Add(speciesData);
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
            speciesComboBox.SelectedIndex = -1;
            locationTextBox.Text = string.Empty;
            populationNumericUpDown.Value = 0;
        }
    }
}