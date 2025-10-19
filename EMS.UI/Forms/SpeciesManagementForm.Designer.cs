namespace EMS.UI.Forms
{
    partial class SpeciesManagementForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            dataGridView = new DataGridView();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            speciesComboBox = new ComboBox();
            filterButton = new Button();
            addNewSpeciesButton = new Button();
            addSpeciesDataButton = new Button();
            homeButton = new Button();
            logoutButton = new Button();
            speciesLabel = new Label();
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
            chart.Location = new Point(58, 516);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(1078, 346);
            chart.TabIndex = 1;
            chart.Text = "chart1";
            chart.Click += chart_Click;
            // 
            // speciesComboBox
            // 
            speciesComboBox.FormattingEnabled = true;
            speciesComboBox.Location = new Point(140, 69);
            speciesComboBox.Margin = new Padding(4, 3, 4, 3);
            speciesComboBox.Name = "speciesComboBox";
            speciesComboBox.Size = new Size(233, 23);
            speciesComboBox.TabIndex = 4;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(397, 67);
            filterButton.Margin = new Padding(4, 3, 4, 3);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(88, 27);
            filterButton.TabIndex = 5;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // addNewSpeciesButton
            // 
            addNewSpeciesButton.Location = new Point(58, 23);
            addNewSpeciesButton.Margin = new Padding(4, 3, 4, 3);
            addNewSpeciesButton.Name = "addNewSpeciesButton";
            addNewSpeciesButton.Size = new Size(140, 35);
            addNewSpeciesButton.TabIndex = 6;
            addNewSpeciesButton.Text = "Add New Species";
            addNewSpeciesButton.UseVisualStyleBackColor = true;
            addNewSpeciesButton.Click += addNewSpeciesButton_Click;
            // 
            // addSpeciesDataButton
            // 
            addSpeciesDataButton.Location = new Point(210, 23);
            addSpeciesDataButton.Margin = new Padding(4, 3, 4, 3);
            addSpeciesDataButton.Name = "addSpeciesDataButton";
            addSpeciesDataButton.Size = new Size(140, 35);
            addSpeciesDataButton.TabIndex = 7;
            addSpeciesDataButton.Text = "Add Species Data";
            addSpeciesDataButton.UseVisualStyleBackColor = true;
            addSpeciesDataButton.Click += addSpeciesDataButton_Click;
            // 
            // homeButton
            // 
            homeButton.Location = new Point(957, 23);
            homeButton.Margin = new Padding(4, 3, 4, 3);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(88, 35);
            homeButton.TabIndex = 8;
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
            logoutButton.TabIndex = 9;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // speciesLabel
            // 
            speciesLabel.AutoSize = true;
            speciesLabel.Location = new Point(58, 73);
            speciesLabel.Margin = new Padding(4, 0, 4, 0);
            speciesLabel.Name = "speciesLabel";
            speciesLabel.Size = new Size(49, 15);
            speciesLabel.TabIndex = 10;
            speciesLabel.Text = "Species:";
            // 
            // chartTypeComboBox
            // 
            chartTypeComboBox.FormattingEnabled = true;
            chartTypeComboBox.Location = new Point(58, 475);
            chartTypeComboBox.Margin = new Padding(4, 3, 4, 3);
            chartTypeComboBox.Name = "chartTypeComboBox";
            chartTypeComboBox.Size = new Size(174, 23);
            chartTypeComboBox.TabIndex = 11;
            chartTypeComboBox.SelectedIndexChanged += chartTypeComboBox_SelectedIndexChanged;
            // 
            // SpeciesManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 886);
            Controls.Add(speciesLabel);
            Controls.Add(logoutButton);
            Controls.Add(homeButton);
            Controls.Add(addSpeciesDataButton);
            Controls.Add(addNewSpeciesButton);
            Controls.Add(filterButton);
            Controls.Add(speciesComboBox);
            Controls.Add(chart);
            Controls.Add(chartTypeComboBox);
            Controls.Add(dataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SpeciesManagementForm";
            Text = "Species Management";
            Load += SpeciesManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox speciesComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button addNewSpeciesButton;
        private System.Windows.Forms.Button addSpeciesDataButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label speciesLabel;
        private System.Windows.Forms.ComboBox chartTypeComboBox;
    }
}