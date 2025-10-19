namespace EMS.UI.Forms
{
    partial class SetTaskForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.setTaskButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(150, 50);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 0;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(150, 90);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.descriptionRichTextBox.TabIndex = 1;
            this.descriptionRichTextBox.Text = "";
            // 
            // setTaskButton
            // 
            this.setTaskButton.Location = new System.Drawing.Point(150, 200);
            this.setTaskButton.Name = "setTaskButton";
            this.setTaskButton.Size = new System.Drawing.Size(75, 23);
            this.setTaskButton.TabIndex = 2;
            this.setTaskButton.Text = "Set Task";
            this.setTaskButton.UseVisualStyleBackColor = true;
            this.setTaskButton.Click += new System.EventHandler(this.setTaskButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(240, 200);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(370, 20);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(75, 23);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 240);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(50, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(50, 93);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description:";
            // 
            // SetTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.setTaskButton);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Name = "SetTaskForm";
            this.Text = "Set Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button setTaskButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
    }
}