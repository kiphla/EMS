namespace EMS.UI.Forms
{
    partial class AddNewSpeciesForm
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
            this.existingSpeciesListBox = new System.Windows.Forms.ListBox();
            this.speciesNameTextBox = new System.Windows.Forms.TextBox();
            this.addSpeciesButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.existingSpeciesLabel = new System.Windows.Forms.Label();
            this.newSpeciesNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // existingSpeciesListBox
            // 
            this.existingSpeciesListBox.FormattingEnabled = true;
            this.existingSpeciesListBox.Location = new System.Drawing.Point(50, 50);
            this.existingSpeciesListBox.Name = "existingSpeciesListBox";
            this.existingSpeciesListBox.Size = new System.Drawing.Size(300, 303);
            this.existingSpeciesListBox.TabIndex = 0;
            // 
            // speciesNameTextBox
            // 
            this.speciesNameTextBox.Location = new System.Drawing.Point(150, 370);
            this.speciesNameTextBox.Name = "speciesNameTextBox";
            this.speciesNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.speciesNameTextBox.TabIndex = 1;
            // 
            // addSpeciesButton
            // 
            this.addSpeciesButton.Location = new System.Drawing.Point(150, 410);
            this.addSpeciesButton.Name = "addSpeciesButton";
            this.addSpeciesButton.Size = new System.Drawing.Size(100, 23);
            this.addSpeciesButton.TabIndex = 2;
            this.addSpeciesButton.Text = "Add Species";
            this.addSpeciesButton.UseVisualStyleBackColor = true;
            this.addSpeciesButton.Click += new System.EventHandler(this.addSpeciesButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(275, 410);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 3;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 450);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 4;
            // 
            // existingSpeciesLabel
            // 
            this.existingSpeciesLabel.AutoSize = true;
            this.existingSpeciesLabel.Location = new System.Drawing.Point(50, 30);
            this.existingSpeciesLabel.Name = "existingSpeciesLabel";
            this.existingSpeciesLabel.Size = new System.Drawing.Size(88, 13);
            this.existingSpeciesLabel.TabIndex = 5;
            this.existingSpeciesLabel.Text = "Existing Species:";
            // 
            // newSpeciesNameLabel
            // 
            this.newSpeciesNameLabel.AutoSize = true;
            this.newSpeciesNameLabel.Location = new System.Drawing.Point(50, 373);
            this.newSpeciesNameLabel.Name = "newSpeciesNameLabel";
            this.newSpeciesNameLabel.Size = new System.Drawing.Size(82, 13);
            this.newSpeciesNameLabel.TabIndex = 6;
            this.newSpeciesNameLabel.Text = "Species Name:";
            // 
            // AddNewSpeciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.newSpeciesNameLabel);
            this.Controls.Add(this.existingSpeciesLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addSpeciesButton);
            this.Controls.Add(this.speciesNameTextBox);
            this.Controls.Add(this.existingSpeciesListBox);
            this.Name = "AddNewSpeciesForm";
            this.Text = "Add New Species";
            this.Load += new System.EventHandler(this.AddNewSpeciesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox existingSpeciesListBox;
        private System.Windows.Forms.TextBox speciesNameTextBox;
        private System.Windows.Forms.Button addSpeciesButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label existingSpeciesLabel;
        private System.Windows.Forms.Label newSpeciesNameLabel;
    }
}