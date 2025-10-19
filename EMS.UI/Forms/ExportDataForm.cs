using EMS.Core.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class ExportDataForm : Form
    {
        private readonly ExportService _exportService;

        public ExportDataForm()
        {
            InitializeComponent();
            _exportService = new ExportService();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathTextBox.Text = saveFileDialog.FileName;
            }
        }

        private async void exportButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataTypeComboBox.Text))
            {
                MessageBox.Show("Please select a data type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(filePathTextBox.Text))
            {
                MessageBox.Show("Please select a file path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            progressBar.Value = 0;
            progressBar.Maximum = 100;

            string dataType = dataTypeComboBox.Text;
            string filePath = filePathTextBox.Text;
            DateTime? startDate = startDatePicker.Enabled ? startDatePicker.Value : (DateTime?)null;
            DateTime? endDate = endDatePicker.Enabled ? endDatePicker.Value : (DateTime?)null;
            string location = locationTextBox.Text;

            bool success = false;

            try
            {
                progressBar.Value = 10;
                
                switch (dataType)
                {
                    case "Soil":
                        success = await Task.Run(() => _exportService.ExportSoilDataToCsv(filePath, startDate, endDate, location));
                        break;
                    case "Water":
                        success = await Task.Run(() => _exportService.ExportHydrologyDataToCsv(filePath, startDate, endDate, location));
                        break;
                    case "Species":
                        success = await Task.Run(() => _exportService.ExportSpeciesDataToCsv(filePath, startDate, endDate, location));
                        break;
                }

                progressBar.Value = 100;

                if (success)
                {
                    MessageBox.Show("Data exported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("An error occurred while exporting data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Value = 0;
            }
        }
    }
}
