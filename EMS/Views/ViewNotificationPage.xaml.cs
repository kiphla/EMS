using EMS.Core.Models;
using System.Windows;
using System.Windows.Controls;

namespace EMS.Views
{
    public partial class ViewNotificationPage : Page
    {
        private readonly Notification currentNotification;

        public ViewNotificationPage(Notification notification)
        {
            InitializeComponent();
            currentNotification = notification;
            LoadNotificationDetails();
        }

        private void LoadNotificationDetails()
        {
            txtTitle.Text = currentNotification.title;
            txtCreationDate.Text = currentNotification.creationDate.ToShortDateString();
            txtTerminationDate.Text = currentNotification.terminationDate.ToShortDateString() ?? "Ongoing";
            txtDescription.Text = currentNotification.description;
        }

        private void BtnTerminate_Click(object sender, RoutedEventArgs e)
        {
            // currentNotification.Active = false;
            // _notificationRepo.Update(currentNotification);

            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null)
            {
                parentWindow.Close();
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

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            var logoutWindow = new LogoutWindow();
            Window parentWindow = Window.GetWindow(this);
            if (logoutWindow.ShowDialog() == true && parentWindow != null)
            {
                Application.Current.MainWindow.Show();
                parentWindow.Close();
            }
        }
    }
}
