using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class SetTaskForm : Form
    {
        private readonly TaskService _taskService;

        public SetTaskForm()
        {
            InitializeComponent();
            _taskService = new TaskService();
        }

        private void setTaskButton_Click(object sender, EventArgs e)
        {
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
                var task = new TaskItem
                {
                    Title = titleTextBox.Text,
                    Description = descriptionRichTextBox.Text,
                    CreatedDate = DateTime.Now,
                    IsActive = true
                };

                _taskService.Add(task);
                statusLabel.Text = "Task set successfully.";
                ClearFields();
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error setting task: " + ex.Message;
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
            titleTextBox.Clear();
            descriptionRichTextBox.Clear();
        }
    }
}