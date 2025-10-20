using System.Windows;
using System.Windows.Controls;

namespace EMS.Views {
    public partial class SetTaskPage : Page {
        public SetTaskPage() {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) {
            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtStatus.Text = string.Empty;
        }

        private void BtnSetTask_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text)) {
                txtStatus.Text = "Please fill in all required fields.";
                return;
            }

            // TODO: Save task to repository
            // var task = new UserTask
            // {
            //     Title = txtTitle.Text,
            //     Description = txtDescription.Text,
            //     CreationDate = DateTime.Today,
            //     Active = true
            // };
            // _taskRepo.Add(task);

            txtStatus.Text = "Task set successfully.";
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
