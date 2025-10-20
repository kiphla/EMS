using EMS.Core.Models;
using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class ViewTaskPage : Page {
        private readonly UserTask currentTask;

        public ViewTaskPage(UserTask task) {
            InitializeComponent();
            currentTask = task;
            LoadTaskDetails();
        }

        private void LoadTaskDetails() {
            //txtTitle.Text = currentTask.Title;
            //txtCreationDate.Text = currentTask.CreationDate.ToShortDateString();
            //txtDescription.Text = currentTask.Description;
        }

        private void BtnMarkDone_Click(object sender, RoutedEventArgs e) {
            // TODO: Update task in repository
            // currentTask.Active = false;
            // _taskRepo.Update(currentTask);

            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null) {
                parentWindow.Close();
            }
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e) {
            Window parentWindow = Window.GetWindow(this);
            if (parentWindow != null) {
                parentWindow.Close();
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e) {
            var logoutWindow = new LogoutWindow();
            Window parentWindow = Window.GetWindow(this);
            if (logoutWindow.ShowDialog() == true && parentWindow != null) {
                Application.Current.MainWindow.Show();
                parentWindow.Close();
            }
        }
    }
}