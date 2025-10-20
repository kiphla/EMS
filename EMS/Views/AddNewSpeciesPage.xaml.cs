using System;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Models;
using EMS.Core.Services;

namespace EMS.Views
{
    public partial class AddNewSpeciesPage : Page
    {
        private readonly SpeciesManagement _speciesManagement;

        public AddNewSpeciesPage()
        {
            InitializeComponent();
            _speciesManagement = new SpeciesManagement();
            LoadExistingSpecies();
        }

        private void LoadExistingSpecies()
        {
            try
            {
                var species = _speciesManagement.GetAllSpecies();
                dgSpecies.ItemsSource = species;
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error loading species: {ex.Message}";
            }
        }

        private void BtnAddSpecies_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSpeciesName.Text))
                {
                    txtStatus.Text = "Please enter a species name.";
                    return;
                }

                var species = new Species
                {
                    speciesName = txtSpeciesName.Text
                };

                _speciesManagement.AddSpecies(species);
                txtSpeciesName.Text = string.Empty;
                txtStatus.Text = "Species added successfully.";
                LoadExistingSpecies();
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error adding species: {ex.Message}";
            }
        }
    }
}
