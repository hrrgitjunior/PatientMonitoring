
namespace PatientsMonitoring
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.generateBtn = new System.Windows.Forms.Button();
            this.dateCB = new System.Windows.Forms.ComboBox();
            this.subjCB = new System.Windows.Forms.ComboBox();
            this.patientsDataGrid = new System.Windows.Forms.DataGridView();
            this.monitoringChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringChart)).BeginInit();
            this.SuspendLayout();
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.filterPanel.Controls.Add(this.generateBtn);
            this.filterPanel.Controls.Add(this.dateCB);
            this.filterPanel.Controls.Add(this.subjCB);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filterPanel.Size = new System.Drawing.Size(855, 100);
            this.filterPanel.TabIndex = 0;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(369, 30);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(79, 23);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "button1";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // dateCB
            // 
            this.dateCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCB.FormattingEnabled = true;
            this.dateCB.Location = new System.Drawing.Point(186, 30);
            this.dateCB.Name = "dateCB";
            this.dateCB.Size = new System.Drawing.Size(121, 28);
            this.dateCB.TabIndex = 1;
            this.dateCB.SelectedIndexChanged += new System.EventHandler(this.dateCB_SelectedIndexChanged);
            // 
            // subjCB
            // 
            this.subjCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjCB.FormattingEnabled = true;
            this.subjCB.Items.AddRange(new object[] {
            "Subj_1",
            "Subj_2"});
            this.subjCB.Location = new System.Drawing.Point(25, 30);
            this.subjCB.Name = "subjCB";
            this.subjCB.Size = new System.Drawing.Size(121, 28);
            this.subjCB.TabIndex = 0;
            this.subjCB.SelectedIndexChanged += new System.EventHandler(this.subjCB_SelectedIndexChanged);
            // 
            // patientsDataGrid
            // 
            this.patientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.patientsDataGrid.Location = new System.Drawing.Point(0, 100);
            this.patientsDataGrid.Name = "patientsDataGrid";
            this.patientsDataGrid.Size = new System.Drawing.Size(347, 438);
            this.patientsDataGrid.TabIndex = 1;
            // 
            // monitoringChart
            // 
            this.monitoringChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.monitoringChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.monitoringChart.Legends.Add(legend1);
            this.monitoringChart.Location = new System.Drawing.Point(353, 100);
            this.monitoringChart.Name = "monitoringChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.monitoringChart.Series.Add(series1);
            this.monitoringChart.Size = new System.Drawing.Size(502, 226);
            this.monitoringChart.TabIndex = 2;
            this.monitoringChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 538);
            this.Controls.Add(this.monitoringChart);
            this.Controls.Add(this.patientsDataGrid);
            this.Controls.Add(this.filterPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.ComboBox subjCB;
        private System.Windows.Forms.DataGridView patientsDataGrid;
        private System.Windows.Forms.ComboBox dateCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart monitoringChart;
        private System.Windows.Forms.Button generateBtn;
    }
}

