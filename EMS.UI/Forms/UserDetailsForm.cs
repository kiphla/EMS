using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class UserDetailsForm : Form
    {
        private readonly AuthenticationService _authenticationService;

        public UserDetailsForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            // Assuming the current user's ID is 1 for now (admin user)
            User currentUser = _authenticationService.GetUserById(1);

            if (currentUser != null)
            {
                usernameValueLabel.Text = currentUser.Username;
                // Redact password for display
                passwordValueLabel.Text = currentUser.Password.Substring(0, 1) + "*****" + currentUser.Password.Substring(currentUser.Password.Length - 1, 1);
                createdDateValueLabel.Text = currentUser.CreatedDate.ToString("g");
            }
            else
            {
                MessageBox.Show("User details not found.");
                this.Close();
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            var changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
            // Refresh user details after password change
            UserDetailsForm_Load(sender, e);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var logoutConfirmationForm = new LogoutConfirmationForm();
            if (logoutConfirmationForm.ShowDialog() == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}