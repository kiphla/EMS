using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class SetNotificationPage : Page {
        public SetNotificationPage() {
            InitializeComponent();
            dpTerminationDate.SelectedDate = DateTime.Today.AddDays(7);
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) {
            cboType.SelectedIndex = -1;
            dpTerminationDate.SelectedDate = DateTime.Today.AddDays(7);
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private void BtnSetNotification_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text)) {
                txtStatus.Text = "Please fill in all required fields.";
                return;
            }

            // TODO: Save notification to repository
            // var notification = new Notification
            // {
            //     Title = txtTitle.Text,
            //     Description = txtDescription.Text,
            //     CreationDate = DateTime.Today,
            //     TerminationDate = cboType.SelectedIndex == 0 ? dpTerminationDate.SelectedDate : null,
            //     Active = true
            // };
            // _notificationRepo.Add(notification);

            txtStatus.Text = "Notification set successfully.";
            BtnClear_Click(sender, e);
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e) {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null) {
                parentWindow.Close();
            }
        }
    }
}
