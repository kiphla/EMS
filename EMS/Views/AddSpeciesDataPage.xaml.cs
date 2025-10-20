using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class AddSpeciesDataPage : Page {
        public AddSpeciesDataPage() {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
            LoadSpecies();
        }

        private void LoadSpecies() {
            // TODO: Load species from repository
            // cboSpecies.ItemsSource = _speciesRepo.GetAllSpecies();
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
            if (cboSpecies.SelectedItem == null) {
                txtStatus.Text = "Please select a species.";
                return;
            }

            // TODO: Validate input and save species data to repository
            // var speciesData = new SpeciesData
            // {
            //     SpeciesID = ((Species)cboSpecies.SelectedItem).SpeciesID,
            //     Date = dpDate.SelectedDate.Value,
            //     PopulationCount = int.Parse(txtPopulationCount.Text),
            //     // ... other properties
            // };
            // _speciesDataRepo.Add(speciesData);

            txtStatus.Text = "Species data record added successfully.";
            BtnClear_Click(sender, e);
        }
    }
}
