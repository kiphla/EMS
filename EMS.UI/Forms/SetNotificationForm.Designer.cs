namespace EMS.UI.Forms
{
    partial class SetNotificationForm
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.setNotificationButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Single",
            "Ongoing"});
            this.typeComboBox.Location = new System.Drawing.Point(150, 50);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(200, 21);
            this.typeComboBox.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(150, 90);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(150, 130);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.descriptionRichTextBox.TabIndex = 2;
            this.descriptionRichTextBox.Text = "";
            // 
            // setNotificationButton
            // 
            this.setNotificationButton.Location = new System.Drawing.Point(150, 240);
            this.setNotificationButton.Name = "setNotificationButton";
            this.setNotificationButton.Size = new System.Drawing.Size(100, 23);
            this.setNotificationButton.TabIndex = 3;
            this.setNotificationButton.Text = "Set Notification";
            this.setNotificationButton.UseVisualStyleBackColor = true;
            this.setNotificationButton.Click += new System.EventHandler(this.setNotificationButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(275, 240);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(370, 20);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 5;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 280);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 6;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(50, 53);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "Type:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(50, 93);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(50, 133);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 9;
            this.descriptionLabel.Text = "Description:";
            // 
            // SetNotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.setNotificationButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Name = "SetNotificationForm";
            this.Text = "Set Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button setNotificationButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}