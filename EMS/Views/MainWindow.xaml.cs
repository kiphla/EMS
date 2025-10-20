using EMS.Core.Models;
using EMS.Core.Repositories;
using EMS.Views;
using System.Windows;
using System.Windows.Controls;

namespace EMS
{
    public partial class MainWindow : Window
    {
        private readonly User currentUser;
        private NotificationsRepository _notificationRepo = new NotificationsRepository();
        private UserTaskRepository _taskRepo = new UserTaskRepository();

        public MainWindow(User user)
        {
            InitializeComponent();
            currentUser = user;
            txtWelcome.Text = $"Welcome, {currentUser.firstName} {currentUser.lastName} to the Environment Management System!";

            LoadNotifications();
            LoadTasks();
        }

        public void RefreshNotifications()
        {
            LoadNotifications();
        }

        public void RefreshTasks()
        {
            LoadTasks();
        }

        private void LoadNotifications()
        {
            dgNotifications.ItemsSource = _notificationRepo.GetActiveByUser(currentUser.userID);
        }

        private void LoadTasks()
        {
            dgTasks.ItemsSource = _taskRepo.GetActiveByUser(currentUser.userID);
        }

        // Button click handlers - open new windows for modules
        private void BtnSoil_Click(object sender, RoutedEventArgs e)
        {
            var window = new SoilManagmentWindow();
            WindowManager.Open(this, window);
        }

        private void BtnWater_Click(object sender, RoutedEventArgs e)
        {
            var window = new WaterManagmentWindow();
            WindowManager.Open(this, window);
        }

        private void BtnSpecies_Click(object sender, RoutedEventArgs e)
        {
            var window = new SpeciesManagmentWindow();
            WindowManager.Open(this, window);
        }

        private void BtnNotifications_Click(object sender, RoutedEventArgs e)
        {
            var frame = new Frame();
            frame.Content = new SetNotificationPage(currentUser);
            var window = new Window
            {
                Content = frame,
                Title = "Set Notification",
                Width = 800,
                Height = 600,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Owner = this
            };
            window.Closed += (s, args) => LoadNotifications();
            window.Show();
        }

        private void BtnTasks_Click(object sender, RoutedEventArgs e)
        {
            var frame = new Frame();
            frame.Content = new SetTaskPage(currentUser);
            var window = new Window
            {
                Content = frame,
                Title = "Set Task",
                Width = 800,
                Height = 600,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Owner = this
            };
            window.Closed += (s, args) => LoadTasks();
            window.Show();
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
            var frame = new Frame();
            frame.Content = new ExportDataPage();
            var window = new Window
            {
                Content = frame,
                Title = "Export Data",
                Width = 800,
                Height = 600
            };
            window.Show();
        }

        private void BtnUserDetails_Click(object sender, RoutedEventArgs e)
        {
            var window = new UserDetailsWindow(currentUser);
            WindowManager.Open(this, window);
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            var logoutWindow = new LogoutWindow();
            WindowManager.Open(this, logoutWindow);
        }
    }
}
