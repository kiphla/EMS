using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class ViewNotificationForm : Form
    {
        private readonly NotificationService _notificationService;
        private readonly int _notificationId;

        public ViewNotificationForm(int notificationId)
        {
            InitializeComponent();
            _notificationService = new NotificationService();
            _notificationId = notificationId;
        }

        private void ViewNotificationForm_Load(object sender, EventArgs e)
        {
            Notification notification = _notificationService.GetById(_notificationId);
            if (notification != null)
            {
                titleLabel.Text = notification.Title;
                descriptionRichTextBox.Text = notification.Description;
                createdDateLabel.Text = "Created Date: " + notification.CreatedDate.ToString("g");
                typeLabel.Text = "Type: " + (notification.IsOngoing ? "Ongoing" : "Single");
            }
            else
            {
                MessageBox.Show("Notification not found.");
                this.Close();
            }
        }

        private void terminateButton_Click(object sender, EventArgs e)
        {
            _notificationService.Terminate(_notificationId);
            MessageBox.Show("Notification terminated.");
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}