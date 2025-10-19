using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly NotificationService _notificationService;
        private readonly TaskService _taskService;

        public MainForm()
        {
            InitializeComponent();
            _notificationService = new NotificationService();
            _taskService = new TaskService();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotifications();
            LoadTasks();
        }

        private void LoadNotifications()
        {
            notificationsListBox.DataSource = null;
            notificationsListBox.DataSource = _notificationService.GetAll();
            notificationsListBox.DisplayMember = "Title";
        }

        private void LoadTasks()
        {
            tasksListBox.DataSource = null;
            tasksListBox.DataSource = _taskService.GetAll();
            tasksListBox.DisplayMember = "Title";
        }

        private void soilMgmtButton_Click(object sender, EventArgs e)
        {
            var soilManagementForm = new SoilManagementForm();
            soilManagementForm.Show();
            this.Hide();
        }

        private void waterMgmtButton_Click(object sender, EventArgs e)
        {
            var waterManagementForm = new WaterManagementForm();
            waterManagementForm.Show();
            this.Hide();
        }

        private void speciesMgmtButton_Click(object sender, EventArgs e)
        {
            var speciesManagementForm = new SpeciesManagementForm();
            speciesManagementForm.Show();
            this.Hide();
        }

        private void setNotificationButton_Click(object sender, EventArgs e)
        {
            var setNotificationForm = new SetNotificationForm();
            setNotificationForm.ShowDialog();
            LoadNotifications();
        }

        private void setTaskButton_Click(object sender, EventArgs e)
        {
            var setTaskForm = new SetTaskForm();
            setTaskForm.ShowDialog();
            LoadTasks();
        }

        private void notificationsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (notificationsListBox.SelectedItem is Notification selectedNotification)
            {
                var viewNotificationForm = new ViewNotificationForm(selectedNotification.Id);
                viewNotificationForm.ShowDialog();
                LoadNotifications();
            }
        }

        private void tasksListBox_DoubleClick(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedItem is TaskItem selectedTask)
            {
                var viewTaskForm = new ViewTaskForm(selectedTask.Id);
                viewTaskForm.ShowDialog();
                LoadTasks();
            }
        }

        private void userDetailsButton_Click(object sender, EventArgs e)
        {
            var userDetailsForm = new UserDetailsForm();
            userDetailsForm.Show();
            this.Hide();
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

        private void exportDataButton_Click(object sender, EventArgs e)
        {
            var exportDataForm = new ExportDataForm();
            exportDataForm.ShowDialog();
        }
    }
}
