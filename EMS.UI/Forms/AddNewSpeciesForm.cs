using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class AddNewSpeciesForm : Form
    {
        private readonly SpeciesDataManager _speciesDataManager;

        public AddNewSpeciesForm()
        {
            InitializeComponent();
            _speciesDataManager = new SpeciesDataManager();
        }

        private void AddNewSpeciesForm_Load(object sender, EventArgs e)
        {
            LoadExistingSpecies();
        }

        private void LoadExistingSpecies()
        {
            var species = _speciesDataManager.GetAllSpecies();
            existingSpeciesListBox.DataSource = species;
            existingSpeciesListBox.DisplayMember = "SpeciesName";
        }

        private void addSpeciesButton_Click(object sender, EventArgs e)
        {
            var speciesName = speciesNameTextBox.Text;
            if (string.IsNullOrWhiteSpace(speciesName))
            {
                statusLabel.Text = "Species name cannot be empty.";
                return;
            }

            var existingSpecies = (System.Collections.Generic.List<Species>)existingSpeciesListBox.DataSource;
            if (existingSpecies.Any(s => s.SpeciesName.Equals(speciesName, StringComparison.OrdinalIgnoreCase)))
            {
                statusLabel.Text = "Species with this name already exists.";
                return;
            }

            try
            {
                var newSpecies = new Species { SpeciesName = speciesName };
                _speciesDataManager.AddSpecies(newSpecies);
                statusLabel.Text = "Species added successfully.";
                speciesNameTextBox.Clear();
                LoadExistingSpecies();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error adding species: " + ex.Message;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}