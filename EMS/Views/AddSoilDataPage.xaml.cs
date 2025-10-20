using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class AddSoilDataPage : Page {
        public AddSoilDataPage() {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) {
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

        private void BtnAddRecord_Click(object sender, RoutedEventArgs e) {
            // TODO: Validate input
            // TODO: Save soil data to repository
            // var soilData = new SoilData
            // {
            //     Date = dpDate.SelectedDate.Value,
            //     pH = float.Parse(txtPH.Text),
            //     // ... other properties
            // };
            // _soilDataRepo.Add(soilData);

            txtStatus.Text = "Soil data record added successfully.";
            BtnClear_Click(sender, e);
        }
    }
}
