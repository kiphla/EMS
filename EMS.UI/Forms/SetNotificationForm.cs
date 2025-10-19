using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class SetNotificationForm : Form
    {
        private readonly NotificationService _notificationService;

        public SetNotificationForm()
        {
            InitializeComponent();
            _notificationService = new NotificationService();
        }

        private void setNotificationButton_Click(object sender, EventArgs e)
        {
            if (typeComboBox.SelectedItem == null)
            {
                statusLabel.Text = "Please select a notification type.";
                return;
            }

            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                statusLabel.Text = "Title is required.";
                return;
            }

            if (string.IsNullOrWhiteSpace(descriptionRichTextBox.Text))
            {
                statusLabel.Text = "Description is required.";
                return;
            }

            try
            {
                var notification = new Notification
                {
                    Title = titleTextBox.Text,
                    Description = descriptionRichTextBox.Text,
                    CreatedDate = DateTime.Now,
                    IsOngoing = typeComboBox.SelectedItem.ToString() == "Ongoing",
                    IsActive = true
                };

                _notificationService.Add(notification);
                statusLabel.Text = "Notification set successfully.";
                ClearFields();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error setting notification: " + ex.Message;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void ClearFields()
        {
            typeComboBox.SelectedIndex = -1;
            titleTextBox.Clear();
            descriptionRichTextBox.Clear();
        }
    }
}