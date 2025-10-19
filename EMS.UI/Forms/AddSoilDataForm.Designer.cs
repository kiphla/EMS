namespace EMS.UI.Forms
{
    partial class AddSoilDataForm
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
            this.phNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.moistureNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nitrogenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.phosphorusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sulphurNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addRecordButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.phLabel = new System.Windows.Forms.Label();
            this.moistureLabel = new System.Windows.Forms.Label();
            this.nitrogenLabel = new System.Windows.Forms.Label();
            this.phosphorusLabel = new System.Windows.Forms.Label();
            this.sulphurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moistureNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrogenNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phosphorusNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sulphurNumericUpDown)).BeginInit();
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
            // phNumericUpDown
            // 
            this.phNumericUpDown.DecimalPlaces = 2;
            this.phNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            this.phNumericUpDown.Location = new System.Drawing.Point(150, 130);
            this.phNumericUpDown.Maximum = new decimal(new int[] { 14, 0, 0, 0 });
            this.phNumericUpDown.Name = "phNumericUpDown";
            this.phNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.phNumericUpDown.TabIndex = 2;
            // 
            // moistureNumericUpDown
            // 
            this.moistureNumericUpDown.DecimalPlaces = 2;
            this.moistureNumericUpDown.Location = new System.Drawing.Point(150, 170);
            this.moistureNumericUpDown.Name = "moistureNumericUpDown";
            this.moistureNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.moistureNumericUpDown.TabIndex = 3;
            // 
            // nitrogenNumericUpDown
            // 
            this.nitrogenNumericUpDown.DecimalPlaces = 2;
            this.nitrogenNumericUpDown.Location = new System.Drawing.Point(150, 210);
            this.nitrogenNumericUpDown.Name = "nitrogenNumericUpDown";
            this.nitrogenNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nitrogenNumericUpDown.TabIndex = 4;
            // 
            // phosphorusNumericUpDown
            // 
            this.phosphorusNumericUpDown.DecimalPlaces = 2;
            this.phosphorusNumericUpDown.Location = new System.Drawing.Point(150, 250);
            this.phosphorusNumericUpDown.Name = "phosphorusNumericUpDown";
            this.phosphorusNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.phosphorusNumericUpDown.TabIndex = 5;
            // 
            // sulphurNumericUpDown
            // 
            this.sulphurNumericUpDown.DecimalPlaces = 2;
            this.sulphurNumericUpDown.Location = new System.Drawing.Point(150, 290);
            this.sulphurNumericUpDown.Name = "sulphurNumericUpDown";
            this.sulphurNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sulphurNumericUpDown.TabIndex = 6;
            // 
            // addRecordButton
            // 
            this.addRecordButton.Location = new System.Drawing.Point(150, 330);
            this.addRecordButton.Name = "addRecordButton";
            this.addRecordButton.Size = new System.Drawing.Size(75, 23);
            this.addRecordButton.TabIndex = 7;
            this.addRecordButton.Text = "Add Record";
            this.addRecordButton.UseVisualStyleBackColor = true;
            this.addRecordButton.Click += new System.EventHandler(this.addRecordButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(240, 330);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(330, 330);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(150, 370);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 10;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(50, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 11;
            this.dateLabel.Text = "Date:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(50, 93);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 12;
            this.locationLabel.Text = "Location:";
            // 
            // phLabel
            // 
            this.phLabel.AutoSize = true;
            this.phLabel.Location = new System.Drawing.Point(50, 133);
            this.phLabel.Name = "phLabel";
            this.phLabel.Size = new System.Drawing.Size(52, 13);
            this.phLabel.TabIndex = 13;
            this.phLabel.Text = "pH Level:";
            // 
            // moistureLabel
            // 
            this.moistureLabel.AutoSize = true;
            this.moistureLabel.Location = new System.Drawing.Point(50, 173);
            this.moistureLabel.Name = "moistureLabel";
            this.moistureLabel.Size = new System.Drawing.Size(79, 13);
            this.moistureLabel.TabIndex = 14;
            this.moistureLabel.Text = "Moisture Level:";
            // 
            // nitrogenLabel
            // 
            this.nitrogenLabel.AutoSize = true;
            this.nitrogenLabel.Location = new System.Drawing.Point(50, 213);
            this.nitrogenLabel.Name = "nitrogenLabel";
            this.nitrogenLabel.Size = new System.Drawing.Size(79, 13);
            this.nitrogenLabel.TabIndex = 15;
            this.nitrogenLabel.Text = "Nitrogen Level:";
            // 
            // phosphorusLabel
            // 
            this.phosphorusLabel.AutoSize = true;
            this.phosphorusLabel.Location = new System.Drawing.Point(50, 253);
            this.phosphorusLabel.Name = "phosphorusLabel";
            this.phosphorusLabel.Size = new System.Drawing.Size(95, 13);
            this.phosphorusLabel.TabIndex = 16;
            this.phosphorusLabel.Text = "Phosphorus Level:";
            // 
            // sulphurLabel
            // 
            this.sulphurLabel.AutoSize = true;
            this.sulphurLabel.Location = new System.Drawing.Point(50, 293);
            this.sulphurLabel.Name = "sulphurLabel";
            this.sulphurLabel.Size = new System.Drawing.Size(74, 13);
            this.sulphurLabel.TabIndex = 17;
            this.sulphurLabel.Text = "Sulphur Level:";
            // 
            // AddSoilDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.sulphurLabel);
            this.Controls.Add(this.phosphorusLabel);
            this.Controls.Add(this.nitrogenLabel);
            this.Controls.Add(this.moistureLabel);
            this.Controls.Add(this.phLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addRecordButton);
            this.Controls.Add(this.sulphurNumericUpDown);
            this.Controls.Add(this.phosphorusNumericUpDown);
            this.Controls.Add(this.nitrogenNumericUpDown);
            this.Controls.Add(this.moistureNumericUpDown);
            this.Controls.Add(this.phNumericUpDown);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "AddSoilDataForm";
            this.Text = "Add Soil Data";
            ((System.ComponentModel.ISupportInitialize)(this.phNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moistureNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nitrogenNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phosphorusNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sulphurNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.NumericUpDown phNumericUpDown;
        private System.Windows.Forms.NumericUpDown moistureNumericUpDown;
        private System.Windows.Forms.NumericUpDown nitrogenNumericUpDown;
        private System.Windows.Forms.NumericUpDown phosphorusNumericUpDown;
        private System.Windows.Forms.NumericUpDown sulphurNumericUpDown;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label phLabel;
        private System.Windows.Forms.Label moistureLabel;
        private System.Windows.Forms.Label nitrogenLabel;
        private System.Windows.Forms.Label phosphorusLabel;
        private System.Windows.Forms.Label sulphurLabel;
    }
}