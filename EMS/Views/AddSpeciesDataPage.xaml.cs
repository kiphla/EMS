using EMS.Core.Models;
using EMS.Core.Services;
using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class AddSpeciesDataPage : Page {
        private readonly SpeciesManagement _speciesManagement;

        public AddSpeciesDataPage() {
            InitializeComponent();
            _speciesManagement = new SpeciesManagement();
            dpDate.SelectedDate = DateTime.Today;
            LoadSpecies();
        }

        private void LoadSpecies() {
            try {
                var species = _speciesManagement.GetAllSpecies();
                cboSpecies.ItemsSource = species;
            } catch (Exception ex) {
                MessageBox.Show($"Error loading species: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool ValidateInputs() {
            if (!dpDate.SelectedDate.HasValue) return false;
            if (cboSpecies.SelectedItem == null) return false;
            if (string.IsNullOrWhiteSpace(txtPopulationCount.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtScatCount.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtReproductiveFactor.Text)) return false;

            return true;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) {
            dpDate.SelectedDate = DateTime.Today;
            cboSpecies.SelectedIndex = -1;
            txtPopulationCount.Text = string.Empty;
            txtScatCount.Text = string.Empty;
            txtReproductiveFactor.Text = string.Empty;
            txtKnownHabitats.Text = string.Empty;
            txtHealthConcerns.Text = string.Empty;
            txtNotes.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private void BtnAddRecord_Click(object sender, RoutedEventArgs e) {
            try {
                if (!ValidateInputs()) {
                    txtStatus.Text = "Please fill in all required fields with valid values.";
                    return;
                }

                var speciesData = new SpeciesData {
                    speciesID = ((Species)cboSpecies.SelectedItem).speciesID,
                    date = dpDate.SelectedDate!.Value,
                    populationCount = int.Parse(txtPopulationCount.Text),
                    scatCount = int.Parse(txtScatCount.Text),
                    reproductiveFactor = float.Parse(txtReproductiveFactor.Text),
                    knownHabitats = txtKnownHabitats.Text,
                    healthConcerns = txtHealthConcerns.Text,
                    additionalNotes = txtNotes.Text
                };

                _speciesManagement.AddSpeciesData(speciesData);
                txtStatus.Text = "Species data record added successfully.";
                BtnClear_Click(sender, e);
            } catch (Exception ex) {
                txtStatus.Text = $"Error adding species data: {ex.Message}";
            }
        }
    }
}
