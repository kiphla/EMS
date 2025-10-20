using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Models;
using EMS.Core.Repositories;

namespace EMS.Views
{
    public partial class SetNotificationPage : Page
    {
        private readonly NotificationsRepository _notificationRepo;
        private readonly User _currentUser;

        public SetNotificationPage(User currentUser)
        {
            InitializeComponent();
            _notificationRepo = new NotificationsRepository();
            _currentUser = currentUser;
            dpTerminationDate.SelectedDate = DateTime.Today.AddDays(7);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cboType.SelectedIndex = -1;
            dpTerminationDate.SelectedDate = DateTime.Today.AddDays(7);
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private async void BtnSetNotification_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    txtStatus.Text = "Please fill in all required fields.";
                    return;
                }

                if (cboType.SelectedIndex == 0 && !dpTerminationDate.SelectedDate.HasValue)
                {
                    txtStatus.Text = "Please select a termination date for single notification.";
                    return;
                }

                var notification = new Notification
                {
                    userID = _currentUser.userID,
                    title = txtTitle.Text,
                    description = txtDescription.Text,
                    creationDate = DateTime.Now,
                    terminationDate = cboType.SelectedIndex == 0 ? dpTerminationDate.SelectedDate ?? DateTime.Today.AddDays(7) : DateTime.MaxValue,
                    isActive = true
                };

                _notificationRepo.Add(notification);
                txtStatus.Text = "Notification set successfully.";

                // Refresh main window notifications if possible
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.RefreshNotifications();

                    // Give the UI a chance to update
                    await Task.Delay(500);

                    // Close the window after successful notification creation
                    if (Window.GetWindow(this) is Window parentWindow)
                    {
                        parentWindow.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error setting notification: {ex.Message}";
            }
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }
    }
}
