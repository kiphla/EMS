using System;
using System.Windows.Forms;

namespace EMS.UI.Forms
{
    public partial class LogoutConfirmationForm : Form
    {
        public LogoutConfirmationForm()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}