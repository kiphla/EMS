using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private readonly AuthenticationService _authenticationService;
        private User _currentUser;

        public ChangePasswordForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            // Assuming the current user's ID is 1 for now (admin user)
            _currentUser = _authenticationService.GetUserById(1);

            if (_currentUser != null)
            {
                usernameValueLabel.Text = _currentUser.Username;
            }
            else
            {
                MessageBox.Show("User details not found.");
                this.Close();
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                statusLabel.Text = "User not loaded.";
                return;
            }

            string currentPassword = currentPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmNewPassword = confirmNewPasswordTextBox.Text;

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmNewPassword))
            {
                statusLabel.Text = "All fields are required.";
                return;
            }

            if (currentPassword != _currentUser.Password)
            {
                statusLabel.Text = "Incorrect current password.";
                return;
            }

            if (newPassword.Length < 6)
            {
                statusLabel.Text = "New password must be at least 6 characters long.";
                return;
            }

            if (newPassword != confirmNewPassword)
            {
                statusLabel.Text = "New password and confirmation do not match.";
                return;
            }

            try
            {
                _authenticationService.ChangePassword(_currentUser.Id, newPassword);
                statusLabel.Text = "Password changed successfully.";
                MessageBox.Show("Password changed successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error changing password: " + ex.Message;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}