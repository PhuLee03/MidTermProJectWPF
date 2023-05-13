namespace NewLogin
{
    partial class Static_Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chartt = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Total_Label = new System.Windows.Forms.Label();
            this.Male_Label = new System.Windows.Forms.Label();
            this.Female_label = new System.Windows.Forms.Label();
            this.Other_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chartt)).BeginInit();
            this.SuspendLayout();
            // 
            // Chartt
            // 
            chartArea2.Name = "ChartArea1";
            this.Chartt.ChartAreas.Add(chartArea2);
            this.Chartt.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.Chartt.Legends.Add(legend2);
            this.Chartt.Location = new System.Drawing.Point(0, 0);
            this.Chartt.Name = "Chartt";
            this.Chartt.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Student Chart";
            this.Chartt.Series.Add(series2);
            this.Chartt.Size = new System.Drawing.Size(371, 433);
            this.Chartt.TabIndex = 0;
            this.Chartt.Text = "chart1";
            title2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "Student Chart";
            title2.Text = "Student Chart";
            this.Chartt.Titles.Add(title2);
            // 
            // Total_Label
            // 
            this.Total_Label.AutoSize = true;
            this.Total_Label.BackColor = System.Drawing.Color.Transparent;
            this.Total_Label.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.Location = new System.Drawing.Point(377, 18);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(66, 21);
            this.Total_Label.TabIndex = 1;
            this.Total_Label.Text = "Total";
            // 
            // Male_Label
            // 
            this.Male_Label.AutoSize = true;
            this.Male_Label.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Male_Label.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male_Label.Location = new System.Drawing.Point(377, 60);
            this.Male_Label.Name = "Male_Label";
            this.Male_Label.Size = new System.Drawing.Size(41, 23);
            this.Male_Label.TabIndex = 2;
            this.Male_Label.Text = "Male";
            // 
            // Female_label
            // 
            this.Female_label.AutoSize = true;
            this.Female_label.BackColor = System.Drawing.Color.Lime;
            this.Female_label.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female_label.Location = new System.Drawing.Point(377, 89);
            this.Female_label.Name = "Female_label";
            this.Female_label.Size = new System.Drawing.Size(57, 23);
            this.Female_label.TabIndex = 3;
            this.Female_label.Text = "Female";
            // 
            // Other_Label
            // 
            this.Other_Label.AutoSize = true;
            this.Other_Label.BackColor = System.Drawing.Color.Orchid;
            this.Other_Label.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Other_Label.Location = new System.Drawing.Point(377, 124);
            this.Other_Label.Name = "Other_Label";
            this.Other_Label.Size = new System.Drawing.Size(48, 23);
            this.Other_Label.TabIndex = 4;
            this.Other_Label.Text = "Other";
            // 
            // Static_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 433);
            this.Controls.Add(this.Other_Label);
            this.Controls.Add(this.Female_label);
            this.Controls.Add(this.Male_Label);
            this.Controls.Add(this.Total_Label);
            this.Controls.Add(this.Chartt);
            this.Name = "Static_Form";
            this.Text = "Static_Form";
            this.Load += new System.EventHandler(this.Static_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chartt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chartt;
        private System.Windows.Forms.Label Total_Label;
        private System.Windows.Forms.Label Male_Label;
        private System.Windows.Forms.Label Female_label;
        private System.Windows.Forms.Label Other_Label;
    }
}