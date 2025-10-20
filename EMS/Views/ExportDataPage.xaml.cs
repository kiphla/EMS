using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class ExportDataPage : Page {
        public ExportDataPage() {
            InitializeComponent();
            InitializeDatePickers();
        }

        private void InitializeDatePickers() {
            dpStartDate.SelectedDate = DateTime.Today.AddMonths(-1);
            dpEndDate.SelectedDate = DateTime.Today;
        }

        private void BtnBrowse_Click(object sender, RoutedEventArgs e) {
            var dialog = new SaveFileDialog();
            string extension = ".csv";

            if (rbJSON.IsChecked == true)
                extension = ".json";
            else if (rbXML.IsChecked == true)
                extension = ".xml";

            dialog.DefaultExt = extension;
            dialog.Filter = $"Data Files (*{extension})|*{extension}";

            if (dialog.ShowDialog() == true) {
                txtExportPath.Text = dialog.FileName;
            }
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtExportPath.Text)) {
                txtStatus.Text = "Please select an export location.";
                return;
            }

            if (!dpStartDate.SelectedDate.HasValue || !dpEndDate.SelectedDate.HasValue) {
                txtStatus.Text = "Please select valid date range.";
                return;
            }

            try {
                string dataType = "soil";
                if (rbWater.IsChecked == true)
                    dataType = "water";
                else if (rbSpecies.IsChecked == true)
                    dataType = "species";

                // TODO: Get data from appropriate repository based on date range
                // var data = dataType switch
                // {
                //     "soil" => _soilDataRepo.GetDataInRange(dpStartDate.SelectedDate.Value, dpEndDate.SelectedDate.Value),
                //     "water" => _waterDataRepo.GetDataInRange(dpStartDate.SelectedDate.Value, dpEndDate.SelectedDate.Value),
                //     "species" => _speciesDataRepo.GetDataInRange(dpStartDate.SelectedDate.Value, dpEndDate.SelectedDate.Value),
                //     _ => throw new ArgumentException("Invalid data type")
                // };

                string format = "csv";
                if (rbJSON.IsChecked == true)
                    format = "json";
                else if (rbXML.IsChecked == true)
                    format = "xml";

                // TODO: Export data in selected format
                // ExportData(data, txtExportPath.Text, format);

                txtStatus.Text = "Data exported successfully.";
            } catch (Exception ex) {
                txtStatus.Text = $"Error exporting data: {ex.Message}";
            }
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e) {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null) {
                parentWindow.Close();
            }
        }
    }
}
