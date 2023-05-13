namespace NewLogin
{
    partial class Print_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.all_Button = new System.Windows.Forms.RadioButton();
            this.check_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.No_Button = new System.Windows.Forms.RadioButton();
            this.Yes_Button = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthDate_Between_Label = new System.Windows.Forms.Label();
            this.Use_Date_Range_Label = new System.Windows.Forms.Label();
            this.other_Button = new System.Windows.Forms.RadioButton();
            this.female_Button = new System.Windows.Forms.RadioButton();
            this.male_Button = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save_To_Text_File_Button = new System.Windows.Forms.Button();
            this.To_Printer_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.all_Button);
            this.groupBox1.Controls.Add(this.check_Button);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.other_Button);
            this.groupBox1.Controls.Add(this.female_Button);
            this.groupBox1.Controls.Add(this.male_Button);
            this.groupBox1.Location = new System.Drawing.Point(220, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // all_Button
            // 
            this.all_Button.AutoSize = true;
            this.all_Button.Location = new System.Drawing.Point(21, 37);
            this.all_Button.Name = "all_Button";
            this.all_Button.Size = new System.Drawing.Size(43, 20);
            this.all_Button.TabIndex = 5;
            this.all_Button.TabStop = true;
            this.all_Button.Text = "All";
            this.all_Button.UseVisualStyleBackColor = true;
            // 
            // check_Button
            // 
            this.check_Button.BackColor = System.Drawing.Color.LightCoral;
            this.check_Button.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(53, 77);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(155, 41);
            this.check_Button.TabIndex = 4;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = false;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.No_Button);
            this.groupBox2.Controls.Add(this.Yes_Button);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BirthDate_Between_Label);
            this.groupBox2.Controls.Add(this.Use_Date_Range_Label);
            this.groupBox2.Location = new System.Drawing.Point(280, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 108);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(288, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // No_Button
            // 
            this.No_Button.AutoSize = true;
            this.No_Button.Location = new System.Drawing.Point(236, 23);
            this.No_Button.Name = "No_Button";
            this.No_Button.Size = new System.Drawing.Size(46, 20);
            this.No_Button.TabIndex = 4;
            this.No_Button.TabStop = true;
            this.No_Button.Text = "No";
            this.No_Button.UseVisualStyleBackColor = true;
            this.No_Button.CheckedChanged += new System.EventHandler(this.No_Button_CheckedChanged);
            // 
            // Yes_Button
            // 
            this.Yes_Button.AutoSize = true;
            this.Yes_Button.Location = new System.Drawing.Point(151, 23);
            this.Yes_Button.Name = "Yes_Button";
            this.Yes_Button.Size = new System.Drawing.Size(52, 20);
            this.Yes_Button.TabIndex = 3;
            this.Yes_Button.TabStop = true;
            this.Yes_Button.Text = "Yes";
            this.Yes_Button.UseVisualStyleBackColor = true;
            this.Yes_Button.CheckedChanged += new System.EventHandler(this.Yes_Button_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "and";
            // 
            // BirthDate_Between_Label
            // 
            this.BirthDate_Between_Label.AutoSize = true;
            this.BirthDate_Between_Label.Location = new System.Drawing.Point(6, 63);
            this.BirthDate_Between_Label.Name = "BirthDate_Between_Label";
            this.BirthDate_Between_Label.Size = new System.Drawing.Size(120, 16);
            this.BirthDate_Between_Label.TabIndex = 1;
            this.BirthDate_Between_Label.Text = "BirthDate Between:";
            // 
            // Use_Date_Range_Label
            // 
            this.Use_Date_Range_Label.AutoSize = true;
            this.Use_Date_Range_Label.Location = new System.Drawing.Point(18, 25);
            this.Use_Date_Range_Label.Name = "Use_Date_Range_Label";
            this.Use_Date_Range_Label.Size = new System.Drawing.Size(111, 16);
            this.Use_Date_Range_Label.TabIndex = 0;
            this.Use_Date_Range_Label.Text = "Use Date Range:";
            // 
            // other_Button
            // 
            this.other_Button.AutoSize = true;
            this.other_Button.Location = new System.Drawing.Point(214, 37);
            this.other_Button.Name = "other_Button";
            this.other_Button.Size = new System.Drawing.Size(60, 20);
            this.other_Button.TabIndex = 2;
            this.other_Button.TabStop = true;
            this.other_Button.Text = "Other";
            this.other_Button.UseVisualStyleBackColor = true;
            // 
            // female_Button
            // 
            this.female_Button.AutoSize = true;
            this.female_Button.Location = new System.Drawing.Point(134, 37);
            this.female_Button.Name = "female_Button";
            this.female_Button.Size = new System.Drawing.Size(74, 20);
            this.female_Button.TabIndex = 1;
            this.female_Button.TabStop = true;
            this.female_Button.Text = "Female";
            this.female_Button.UseVisualStyleBackColor = true;
            // 
            // male_Button
            // 
            this.male_Button.AutoSize = true;
            this.male_Button.Location = new System.Drawing.Point(70, 37);
            this.male_Button.Name = "male_Button";
            this.male_Button.Size = new System.Drawing.Size(58, 20);
            this.male_Button.TabIndex = 0;
            this.male_Button.TabStop = true;
            this.male_Button.Text = "Male";
            this.male_Button.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 297);
            this.dataGridView1.TabIndex = 1;
            // 
            // Save_To_Text_File_Button
            // 
            this.Save_To_Text_File_Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Save_To_Text_File_Button.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_To_Text_File_Button.ForeColor = System.Drawing.Color.White;
            this.Save_To_Text_File_Button.Location = new System.Drawing.Point(378, 467);
            this.Save_To_Text_File_Button.Name = "Save_To_Text_File_Button";
            this.Save_To_Text_File_Button.Size = new System.Drawing.Size(215, 54);
            this.Save_To_Text_File_Button.TabIndex = 2;
            this.Save_To_Text_File_Button.Text = "Save To Text File";
            this.Save_To_Text_File_Button.UseVisualStyleBackColor = false;
            this.Save_To_Text_File_Button.Click += new System.EventHandler(this.Save_To_Text_File_Button_Click);
            // 
            // To_Printer_Button
            // 
            this.To_Printer_Button.BackColor = System.Drawing.Color.Black;
            this.To_Printer_Button.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Printer_Button.ForeColor = System.Drawing.Color.Yellow;
            this.To_Printer_Button.Location = new System.Drawing.Point(617, 467);
            this.To_Printer_Button.Name = "To_Printer_Button";
            this.To_Printer_Button.Size = new System.Drawing.Size(174, 54);
            this.To_Printer_Button.TabIndex = 3;
            this.To_Printer_Button.Text = "To Printer";
            this.To_Printer_Button.UseVisualStyleBackColor = false;
            this.To_Printer_Button.Click += new System.EventHandler(this.To_Printer_Button_Click);
            // 
            // Print_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1182, 533);
            this.Controls.Add(this.To_Printer_Button);
            this.Controls.Add(this.Save_To_Text_File_Button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Print_Form";
            this.Text = "Print_Form";
            this.Load += new System.EventHandler(this.Print_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton all_Button;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton No_Button;
        private System.Windows.Forms.RadioButton Yes_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BirthDate_Between_Label;
        private System.Windows.Forms.Label Use_Date_Range_Label;
        private System.Windows.Forms.RadioButton other_Button;
        private System.Windows.Forms.RadioButton female_Button;
        private System.Windows.Forms.RadioButton male_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save_To_Text_File_Button;
        private System.Windows.Forms.Button To_Printer_Button;
    }
}