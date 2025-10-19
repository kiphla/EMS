using System.Windows.Forms.DataVisualization.Charting;

namespace EMS.UI.Forms
{
    partial class SoilManagementForm
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

        private void InitializeComponent() {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            dataGridView = new DataGridView();
            chart = new Chart();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            locationComboBox = new ComboBox();
            filterButton = new Button();
            addRecordButton = new Button();
            homeButton = new Button();
            logoutButton = new Button();
            startDateLabel = new Label();
            endDateLabel = new Label();
            locationLabel = new Label();
            chartTypeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(58, 115);
            dataGridView.Margin = new Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(1078, 346);
            dataGridView.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(58, 528);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(1078, 346);
            chart.TabIndex = 1;
            chart.Text = "chart1";
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(140, 69);
            startDatePicker.Margin = new Padding(4, 3, 4, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(233, 23);
            startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(467, 69);
            endDatePicker.Margin = new Padding(4, 3, 4, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(233, 23);
            endDatePicker.TabIndex = 3;
            // 
            // locationComboBox
            // 
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Location = new Point(793, 69);
            locationComboBox.Margin = new Padding(4, 3, 4, 3);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(140, 23);
            locationComboBox.TabIndex = 4;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(957, 67);
            filterButton.Margin = new Padding(4, 3, 4, 3);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(88, 27);
            filterButton.TabIndex = 5;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // addRecordButton
            // 
            addRecordButton.Location = new Point(58, 23);
            addRecordButton.Margin = new Padding(4, 3, 4, 3);
            addRecordButton.Name = "addRecordButton";
            addRecordButton.Size = new Size(117, 35);
            addRecordButton.TabIndex = 6;
            addRecordButton.Text = "Add Record";
            addRecordButton.UseVisualStyleBackColor = true;
            addRecordButton.Click += addRecordButton_Click;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(957, 23);
            homeButton.Margin = new Padding(4, 3, 4, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(88, 35);
            homeButton.TabIndex = 7;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(1050, 23);
            logoutButton.Margin = new Padding(4, 3, 4, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(88, 35);
            logoutButton.TabIndex = 8;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(58, 73);
            startDateLabel.Margin = new Padding(4, 0, 4, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(61, 15);
            startDateLabel.TabIndex = 9;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(385, 73);
            endDateLabel.Margin = new Padding(4, 0, 4, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(57, 15);
            endDateLabel.TabIndex = 10;
            endDateLabel.Text = "End Date:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new Point(723, 73);
            locationLabel.Margin = new Padding(4, 0, 4, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(56, 15);
            locationLabel.TabIndex = 11;
            locationLabel.Text = "Location:";
            // 
            // chartTypeComboBox
            // 
            chartTypeComboBox.FormattingEnabled = true;
            chartTypeComboBox.Location = new Point(58, 485);
            chartTypeComboBox.Margin = new Padding(4, 3, 4, 3);
            chartTypeComboBox.Name = "chartTypeComboBox";
            chartTypeComboBox.Size = new Size(174, 23);
            chartTypeComboBox.TabIndex = 12;
            chartTypeComboBox.SelectedIndexChanged += chartTypeComboBox_SelectedIndexChanged;
            // 
            // SoilManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 886);
            Controls.Add(locationLabel);
            Controls.Add(endDateLabel);
            Controls.Add(startDateLabel);
            Controls.Add(logoutButton);
            Controls.Add(homeButton);
            Controls.Add(addRecordButton);
            Controls.Add(filterButton);
            Controls.Add(locationComboBox);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Controls.Add(chart);
            Controls.Add(chartTypeComboBox);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SoilManagementForm";
            Text = "Soil Management";
            Load += SoilManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button addRecordButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ComboBox chartTypeComboBox;
    }
}