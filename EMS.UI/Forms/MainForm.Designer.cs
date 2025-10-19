namespace EMS.UI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.soilMgmtButton = new System.Windows.Forms.Button();
            this.waterMgmtButton = new System.Windows.Forms.Button();
            this.speciesMgmtButton = new System.Windows.Forms.Button();
            this.notificationsListBox = new System.Windows.Forms.ListBox();
            this.tasksListBox = new System.Windows.Forms.ListBox();
            this.setNotificationButton = new System.Windows.Forms.Button();
            this.setTaskButton = new System.Windows.Forms.Button();
            this.userDetailsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.notificationsLabel = new System.Windows.Forms.Label();
            this.tasksLabel = new System.Windows.Forms.Label();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soilMgmtButton
            // 
            this.soilMgmtButton.Location = new System.Drawing.Point(50, 50);
            this.soilMgmtButton.Name = "soilMgmtButton";
            this.soilMgmtButton.Size = new System.Drawing.Size(150, 50);
            this.soilMgmtButton.TabIndex = 0;
            this.soilMgmtButton.Text = "Soil Management";
            this.soilMgmtButton.UseVisualStyleBackColor = true;
            this.soilMgmtButton.Click += new System.EventHandler(this.soilMgmtButton_Click);
            // 
            // waterMgmtButton
            // 
            this.waterMgmtButton.Location = new System.Drawing.Point(50, 120);
            this.waterMgmtButton.Name = "waterMgmtButton";
            this.waterMgmtButton.Size = new System.Drawing.Size(150, 50);
            this.waterMgmtButton.TabIndex = 1;
            this.waterMgmtButton.Text = "Water Management";
            this.waterMgmtButton.UseVisualStyleBackColor = true;
            this.waterMgmtButton.Click += new System.EventHandler(this.waterMgmtButton_Click);
            // 
            // speciesMgmtButton
            // 
            this.speciesMgmtButton.Location = new System.Drawing.Point(50, 190);
            this.speciesMgmtButton.Name = "speciesMgmtButton";
            this.speciesMgmtButton.Size = new System.Drawing.Size(150, 50);
            this.speciesMgmtButton.TabIndex = 2;
            this.speciesMgmtButton.Text = "Species Management";
            this.speciesMgmtButton.UseVisualStyleBackColor = true;
            this.speciesMgmtButton.Click += new System.EventHandler(this.speciesMgmtButton_Click);
            // 
            // notificationsListBox
            // 
            this.notificationsListBox.FormattingEnabled = true;
            this.notificationsListBox.Location = new System.Drawing.Point(250, 75);
            this.notificationsListBox.Name = "notificationsListBox";
            this.notificationsListBox.Size = new System.Drawing.Size(300, 500);
            this.notificationsListBox.TabIndex = 3;
            this.notificationsListBox.DoubleClick += new System.EventHandler(this.notificationsListBox_DoubleClick);
            // 
            // tasksListBox
            // 
            this.tasksListBox.FormattingEnabled = true;
            this.tasksListBox.Location = new System.Drawing.Point(600, 75);
            this.tasksListBox.Name = "tasksListBox";
            this.tasksListBox.Size = new System.Drawing.Size(300, 500);
            this.tasksListBox.TabIndex = 4;
            this.tasksListBox.DoubleClick += new System.EventHandler(this.tasksListBox_DoubleClick);
            // 
            // setNotificationButton
            // 
            this.setNotificationButton.Location = new System.Drawing.Point(250, 600);
            this.setNotificationButton.Name = "setNotificationButton";
            this.setNotificationButton.Size = new System.Drawing.Size(120, 30);
            this.setNotificationButton.TabIndex = 5;
            this.setNotificationButton.Text = "Set Notification";
            this.setNotificationButton.UseVisualStyleBackColor = true;
            this.setNotificationButton.Click += new System.EventHandler(this.setNotificationButton_Click);
            // 
            // setTaskButton
            // 
            this.setTaskButton.Location = new System.Drawing.Point(600, 600);
            this.setTaskButton.Name = "setTaskButton";
            this.setTaskButton.Size = new System.Drawing.Size(120, 30);
            this.setTaskButton.TabIndex = 6;
            this.setTaskButton.Text = "Set Task";
            this.setTaskButton.UseVisualStyleBackColor = true;
            this.setTaskButton.Click += new System.EventHandler(this.setTaskButton_Click);
            // 
            // userDetailsButton
            // 
            this.userDetailsButton.Location = new System.Drawing.Point(800, 20);
            this.userDetailsButton.Name = "userDetailsButton";
            this.userDetailsButton.Size = new System.Drawing.Size(100, 30);
            this.userDetailsButton.TabIndex = 7;
            this.userDetailsButton.Text = "User Details";
            this.userDetailsButton.UseVisualStyleBackColor = true;
            this.userDetailsButton.Click += new System.EventHandler(this.userDetailsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(920, 20);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 30);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // notificationsLabel
            // 
            this.notificationsLabel.AutoSize = true;
            this.notificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsLabel.Location = new System.Drawing.Point(246, 52);
            this.notificationsLabel.Name = "notificationsLabel";
            this.notificationsLabel.Size = new System.Drawing.Size(107, 20);
            this.notificationsLabel.TabIndex = 9;
            this.notificationsLabel.Text = "Notifications";
            // 
            // tasksLabel
            // 
            this.tasksLabel.AutoSize = true;
            this.tasksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksLabel.Location = new System.Drawing.Point(596, 52);
            this.tasksLabel.Name = "tasksLabel";
            this.tasksLabel.Size = new System.Drawing.Size(56, 20);
            this.tasksLabel.TabIndex = 10;
            this.tasksLabel.Text = "Tasks";
            // 
            // exportDataButton
            // 
            this.exportDataButton.Location = new System.Drawing.Point(50, 260);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(150, 50);
            this.exportDataButton.TabIndex = 11;
            this.exportDataButton.Text = "Export Data";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportDataButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.exportDataButton);
            this.Controls.Add(this.tasksLabel);
            this.Controls.Add(this.notificationsLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.userDetailsButton);
            this.Controls.Add(this.setTaskButton);
            this.Controls.Add(this.setNotificationButton);
            this.Controls.Add(this.tasksListBox);
            this.Controls.Add(this.notificationsListBox);
            this.Controls.Add(this.speciesMgmtButton);
            this.Controls.Add(this.waterMgmtButton);
            this.Controls.Add(this.soilMgmtButton);
            this.Name = "MainForm";
            this.Text = "EMS - Environmental Monitoring System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button soilMgmtButton;
        private System.Windows.Forms.Button waterMgmtButton;
        private System.Windows.Forms.Button speciesMgmtButton;
        private System.Windows.Forms.ListBox notificationsListBox;
        private System.Windows.Forms.ListBox tasksListBox;
        private System.Windows.Forms.Button setNotificationButton;
        private System.Windows.Forms.Button setTaskButton;
        private System.Windows.Forms.Button userDetailsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label notificationsLabel;
        private System.Windows.Forms.Label tasksLabel;
        private System.Windows.Forms.Button exportDataButton;
    }
}
