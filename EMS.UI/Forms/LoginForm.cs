using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthenticationService _authenticationService;

        public LoginForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                statusLabel.Text = "Username and password are required.";
                return;
            }

            User user = _authenticationService.Authenticate(username, password);

            if (user != null)
            {
                // Store user session if needed, for now just open the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                statusLabel.Text = "Invalid username or password.";
            }
        }
    }
}