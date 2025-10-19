namespace EMS.UI.Forms
{
    partial class AddWaterDataForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.waterLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rainfallNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.salinityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.phNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dissolvedOxygenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.turbidityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.temperatureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.rainfallLabel = new System.Windows.Forms.Label();
            this.salinityLabel = new System.Windows.Forms.Label();
            this.phLabel = new System.Windows.Forms.Label();
            this.dissolvedOxygenLabel = new System.Windows.Forms.Label();
            this.turbidityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waterLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainfallNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salinityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dissolvedOxygenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(150, 50);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(150, 90);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 1;
            // 
            // waterLevelNumericUpDown
            // 
            this.waterLevelNumericUpDown.DecimalPlaces = 2;
            this.waterLevelNumericUpDown.Location = new System.Drawing.Point(150, 130);
            this.waterLevelNumericUpDown.Name = "waterLevelNumericUpDown";
            this.waterLevelNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.waterLevelNumericUpDown.TabIndex = 2;
            // 
            // rainfallNumericUpDown
            // 
            this.rainfallNumericUpDown.DecimalPlaces = 2;
            this.rainfallNumericUpDown.Location = new System.Drawing.Point(150, 170);
            this.rainfallNumericUpDown.Name = "rainfallNumericUpDown";
            this.rainfallNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.rainfallNumericUpDown.TabIndex = 3;
            // 
            // salinityNumericUpDown
            // 
            this.salinityNumericUpDown.DecimalPlaces = 2;
            this.salinityNumericUpDown.Location = new System.Drawing.Point(150, 210);
            this.salinityNumericUpDown.Name = "salinityNumericUpDown";
            this.salinityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.salinityNumericUpDown.TabIndex = 4;
            // 
            // phNumericUpDown
            // 
            this.phNumericUpDown.DecimalPlaces = 2;
            this.phNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            this.phNumericUpDown.Location = new System.Drawing.Point(150, 250);
            this.phNumericUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            this.phNumericUpDown.Name = "phNumericUpDown";
            this.phNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.phNumericUpDown.TabIndex = 5;
            // 
            // dissolvedOxygenNumericUpDown
            // 
            this.dissolvedOxygenNumericUpDown.DecimalPlaces = 2;
            this.dissolvedOxygenNumericUpDown.Location = new System.Drawing.Point(150, 290);
            this.dissolvedOxygenNumericUpDown.Name = "dissolvedOxygenNumericUpDown";
            this.dissolvedOxygenNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.dissolvedOxygenNumericUpDown.TabIndex = 6;
            // 
            // turbidityNumericUpDown
            // 
            this.turbidityNumericUpDown.DecimalPlaces = 2;
            this.turbidityNumericUpDown.Location = new System.Drawing.Point(150, 330);
            this.turbidityNumericUpDown.Name = "turbidityNumericUpDown";
            this.turbidityNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.turbidityNumericUpDown.TabIndex = 7;
            // 
            // temperatureNumericUpDown
            // 
            this.temperatureNumericUpDown.DecimalPlaces = 2;
            this.temperatureNumericUpDown.Location = new System.Drawing.Point(150, 370);
            this.temperatureNumericUpDown.Name = "temperatureNumericUpDown";
            this.temperatureNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.temperatureNumericUpDown.TabIndex = 8;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(150, 410);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addRecordButton.TabIndex = 9;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(240, 410);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(330, 410);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 11;
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
            this.statusLabel.TabIndex = 12;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(50, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(50, 93);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 14;
            this.locationLabel.Text = "Location:";
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(50, 133);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(67, 13);
            this.waterLevelLabel.TabIndex = 15;
            this.waterLevelLabel.Text = "Water Level:";
            // 
            // rainfallLabel
            // 
            this.rainfallLabel.AutoSize = true;
            this.rainfallLabel.Location = new System.Drawing.Point(50, 173);
            this.rainfallLabel.Name = "rainfallLabel";
            this.rainfallLabel.Size = new System.Drawing.Size(45, 13);
            this.rainfallLabel.TabIndex = 16;
            this.rainfallLabel.Text = "Rainfall:";
            // 
            // salinityLabel
            // 
            this.salinityLabel.AutoSize = true;
            this.salinityLabel.Location = new System.Drawing.Point(50, 213);
            this.salinityLabel.Name = "salinityLabel";
            this.salinityLabel.Size = new System.Drawing.Size(43, 13);
            this.salinityLabel.TabIndex = 17;
            this.salinityLabel.Text = "Salinity:";
            // 
            // phLabel
            // 
            this.phLabel.AutoSize = true;
            this.phLabel.Location = new System.Drawing.Point(50, 253);
            this.phLabel.Name = "phLabel";
            this.phLabel.Size = new System.Drawing.Size(52, 13);
            this.phLabel.TabIndex = 18;
            this.phLabel.Text = "pH Level:";
            // 
            // dissolvedOxygenLabel
            // 
            this.dissolvedOxygenLabel.AutoSize = true;
            this.dissolvedOxygenLabel.Location = new System.Drawing.Point(50, 293);
            this.dissolvedOxygenLabel.Name = "dissolvedOxygenLabel";
            this.dissolvedOxygenLabel.Size = new System.Drawing.Size(94, 13);
            this.dissolvedOxygenLabel.TabIndex = 19;
            this.dissolvedOxygenLabel.Text = "Dissolved Oxygen:";
            // 
            // turbidityLabel
            // 
            this.turbidityLabel.AutoSize = true;
            this.turbidityLabel.Location = new System.Drawing.Point(50, 333);
            this.turbidityLabel.Name = "turbidityLabel";
            this.turbidityLabel.Size = new System.Drawing.Size(50, 13);
            this.turbidityLabel.TabIndex = 20;
            this.turbidityLabel.Text = "Turbidity:";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(50, 373);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(70, 13);
            this.temperatureLabel.TabIndex = 21;
            this.temperatureLabel.Text = "Temperature:";
            // 
            // AddWaterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.turbidityLabel);
            this.Controls.Add(this.dissolvedOxygenLabel);
            this.Controls.Add(this.phLabel);
            this.Controls.Add(this.salinityLabel);
            this.Controls.Add(this.rainfallLabel);
            this.Controls.Add(this.waterLevelLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.temperatureNumericUpDown);
            this.Controls.Add(this.turbidityNumericUpDown);
            this.Controls.Add(this.dissolvedOxygenNumericUpDown);
            this.Controls.Add(this.phNumericUpDown);
            this.Controls.Add(this.salinityNumericUpDown);
            this.Controls.Add(this.rainfallNumericUpDown);
            this.Controls.Add(this.waterLevelNumericUpDown);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AddWaterDataForm";
            this.Text = "Add Water Data";
            ((System.ComponentModel.ISupportInitialize)(this.waterLevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainfallNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salinityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dissolvedOxygenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.NumericUpDown waterLevelNumericUpDown;
        private System.Windows.Forms.NumericUpDown rainfallNumericUpDown;
        private System.Windows.Forms.NumericUpDown salinityNumericUpDown;
        private System.Windows.Forms.NumericUpDown phNumericUpDown;
        private System.Windows.Forms.NumericUpDown dissolvedOxygenNumericUpDown;
        private System.Windows.Forms.NumericUpDown turbidityNumericUpDown;
        private System.Windows.Forms.NumericUpDown temperatureNumericUpDown;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label waterLevelLabel;
        private System.Windows.Forms.Label rainfallLabel;
        private System.Windows.Forms.Label salinityLabel;
        private System.Windows.Forms.Label phLabel;
        private System.Windows.Forms.Label dissolvedOxygenLabel;
        private System.Windows.Forms.Label turbidityLabel;
        private System.Windows.Forms.Label temperatureLabel;
    }
}