namespace EMS.UI.Forms
{
    partial class AddSpeciesDataForm
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
            this.speciesComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.populationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.speciesLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.populationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // speciesComboBox
            // 
            this.speciesComboBox.FormattingEnabled = true;
            this.speciesComboBox.Location = new System.Drawing.Point(150, 50);
            this.speciesComboBox.Name = "speciesComboBox";
            this.speciesComboBox.Size = new System.Drawing.Size(200, 21);
            this.speciesComboBox.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(150, 90);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(150, 130);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 2;
            // 
            // populationNumericUpDown
            // 
            this.populationNumericUpDown.Location = new System.Drawing.Point(150, 170);
            this.populationNumericUpDown.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.populationNumericUpDown.Name = "populationNumericUpDown";
            this.populationNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.populationNumericUpDown.TabIndex = 3;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(150, 210);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addRecordButton.TabIndex = 4;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(240, 210);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(330, 210);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 250);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 7;
            // 
            // speciesLabel
            // 
            this.speciesLabel.AutoSize = true;
            this.speciesLabel.Location = new System.Drawing.Point(50, 53);
            this.speciesLabel.Name = "speciesLabel";
            this.speciesLabel.Size = new System.Drawing.Size(48, 13);
            this.speciesLabel.TabIndex = 8;
            this.speciesLabel.Text = "Species:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(50, 93);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Date:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(50, 133);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 10;
            this.locationLabel.Text = "Location:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(50, 173);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(60, 13);
            this.populationLabel.TabIndex = 11;
            this.populationLabel.Text = "Population:";
            // 
            // AddSpeciesDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.populationLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.speciesLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.populationNumericUpDown);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.speciesComboBox);
            this.Name = "AddSpeciesDataForm";
            this.Text = "Add Species Data";
            this.Load += new System.EventHandler(this.AddSpeciesDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.populationNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.NumericUpDown populationNumericUpDown;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label populationLabel;
    }
}