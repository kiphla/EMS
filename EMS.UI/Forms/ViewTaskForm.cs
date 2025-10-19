using EMS.Core.Services;
using EMS.Core.Models;
using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class ViewTaskForm : Form
    {
        private readonly TaskService _taskService;
        private readonly int _taskId;

        public ViewTaskForm(int taskId)
        {
            InitializeComponent();
            _taskService = new TaskService();
            _taskId = taskId;
        }

        private void ViewTaskForm_Load(object sender, EventArgs e)
        {
            TaskItem task = _taskService.GetById(_taskId);
            if (task != null)
            {
                titleLabel.Text = task.Title;
                descriptionRichTextBox.Text = task.Description;
                createdDateLabel.Text = "Created Date: " + task.CreatedDate.ToString("g");
            }
            else
            {
                MessageBox.Show("Task not found.");
                this.Close();
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            _taskService.Complete(_taskId);
            MessageBox.Show("Task completed.");
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}