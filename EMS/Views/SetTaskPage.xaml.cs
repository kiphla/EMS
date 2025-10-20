using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using EMS.Core.Models;
using EMS.Core.Repositories;

namespace EMS.Views
{
    public partial class SetTaskPage : Page
    {
        private readonly UserTaskRepository _taskRepo;
        private readonly User _currentUser;

        public SetTaskPage(User currentUser)
        {
            InitializeComponent();
            _taskRepo = new UserTaskRepository();
            _currentUser = currentUser;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private async void BtnSetTask_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    txtStatus.Text = "Please fill in all required fields.";
                    return;
                }

                var task = new UserTask
                {
                    userID = _currentUser.userID,
                    title = txtTitle.Text,
                    description = txtDescription.Text,
                    creationDate = DateTime.Now,
                    isActive = true
                };

                _taskRepo.Add(task);
                txtStatus.Text = "Task set successfully.";

                // Refresh main window tasks if possible
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.RefreshTasks();

                    // Give the UI a chance to update
                    await Task.Delay(500);

                    // Close the window after successful task creation
                    if (Window.GetWindow(this) is Window parentWindow)
                    {
                        parentWindow.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                txtStatus.Text = $"Error setting task: {ex.Message}";
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
