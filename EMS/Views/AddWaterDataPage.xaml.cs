using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class AddWaterDataPage : Page {
        public AddWaterDataPage() {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Today;
            txtTime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) {
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

        private void BtnAddRecord_Click(object sender, RoutedEventArgs e) {
            // TODO: Validate input
            // TODO: Save water data to repository
            // var waterData = new WaterData
            // {
            //     Date = dpDate.SelectedDate.Value,
            //     Time = TimeSpan.Parse(txtTime.Text),
            //     pH = float.Parse(txtPH.Text),
            //     // ... other properties
            // };
            // _waterDataRepo.Add(waterData);

            txtStatus.Text = "Water data record added successfully.";
            BtnClear_Click(sender, e);
        }
    }
}
