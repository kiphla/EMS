namespace EMS.UI.Forms
{
    partial class UserDetailsForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createdDateLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.usernameValueLabel = new System.Windows.Forms.Label();
            this.passwordValueLabel = new System.Windows.Forms.Label();
            this.createdDateValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(50, 50);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(86, 17);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(50, 90);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(84, 17);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // createdDateLabel
            // 
            this.createdDateLabel.AutoSize = true;
            this.createdDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdDateLabel.Location = new System.Drawing.Point(50, 130);
            this.createdDateLabel.Name = "createdDateLabel";
            this.createdDateLabel.Size = new System.Drawing.Size(112, 17);
            this.createdDateLabel.TabIndex = 2;
            this.createdDateLabel.Text = "Created Date:";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(50, 170);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(120, 30);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(250, 20);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 30);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(330, 20);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 30);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // usernameValueLabel
            // 
            this.usernameValueLabel.AutoSize = true;
            this.usernameValueLabel.Location = new System.Drawing.Point(170, 53);
            this.usernameValueLabel.Name = "usernameValueLabel";
            this.usernameValueLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameValueLabel.TabIndex = 6;
            // 
            // passwordValueLabel
            // 
            this.passwordValueLabel.AutoSize = true;
            this.passwordValueLabel.Location = new System.Drawing.Point(170, 93);
            this.passwordValueLabel.Name = "passwordValueLabel";
            this.passwordValueLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordValueLabel.TabIndex = 7;
            // 
            // createdDateValueLabel
            // 
            this.createdDateValueLabel.AutoSize = true;
            this.createdDateValueLabel.Location = new System.Drawing.Point(170, 133);
            this.createdDateValueLabel.Name = "createdDateValueLabel";
            this.createdDateValueLabel.Size = new System.Drawing.Size(0, 13);
            this.createdDateValueLabel.TabIndex = 8;
            // 
            // UserDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.createdDateValueLabel);
            this.Controls.Add(this.passwordValueLabel);
            this.Controls.Add(this.usernameValueLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.createdDateLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "UserDetailsForm";
            this.Text = "User Details";
            this.Load += new System.EventHandler(this.UserDetailsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label createdDateLabel;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label usernameValueLabel;
        private System.Windows.Forms.Label passwordValueLabel;
        private System.Windows.Forms.Label createdDateValueLabel;
    }
}