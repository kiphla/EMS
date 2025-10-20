using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class AddNewSpeciesPage : Page {
        public AddNewSpeciesPage() {
            InitializeComponent();
            LoadExistingSpecies();
        }

        private void LoadExistingSpecies() {
            // TODO: Load species from repository
            // dgSpecies.ItemsSource = _speciesRepo.GetAllSpecies();
        }

        private void BtnAddSpecies_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtSpeciesName.Text)) {
                txtStatus.Text = "Please enter a species name.";
                return;
            }

            // TODO: Add species to repository
            // var species = new Species { SpeciesName = txtSpeciesName.Text };
            // _speciesRepo.Add(species);

            txtSpeciesName.Text = string.Empty;
            txtStatus.Text = "Species added successfully.";
            LoadExistingSpecies();
        }
    }
}
