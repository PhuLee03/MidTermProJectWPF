namespace NewLogin.Courses
{
    partial class editCourseForm
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
            this.select_Course_Label = new System.Windows.Forms.Label();
            this.label_Label = new System.Windows.Forms.Label();
            this.period_Label = new System.Windows.Forms.Label();
            this.discription_Label = new System.Windows.Forms.Label();
            this.selectCourse_comboBox = new System.Windows.Forms.ComboBox();
            this.label_TextBox = new System.Windows.Forms.TextBox();
            this.discription_textBox = new System.Windows.Forms.TextBox();
            this.period_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.edit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.period_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // select_Course_Label
            // 
            this.select_Course_Label.AutoSize = true;
            this.select_Course_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Course_Label.Location = new System.Drawing.Point(46, 27);
            this.select_Course_Label.Name = "select_Course_Label";
            this.select_Course_Label.Size = new System.Drawing.Size(125, 19);
            this.select_Course_Label.TabIndex = 0;
            this.select_Course_Label.Text = "Select Course:";
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Label.Location = new System.Drawing.Point(114, 73);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(57, 19);
            this.label_Label.TabIndex = 1;
            this.label_Label.Text = "Label:";
            // 
            // period_Label
            // 
            this.period_Label.AutoSize = true;
            this.period_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_Label.Location = new System.Drawing.Point(105, 113);
            this.period_Label.Name = "period_Label";
            this.period_Label.Size = new System.Drawing.Size(66, 19);
            this.period_Label.TabIndex = 2;
            this.period_Label.Text = "Period:";
            // 
            // discription_Label
            // 
            this.discription_Label.AutoSize = true;
            this.discription_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription_Label.Location = new System.Drawing.Point(71, 156);
            this.discription_Label.Name = "discription_Label";
            this.discription_Label.Size = new System.Drawing.Size(100, 19);
            this.discription_Label.TabIndex = 3;
            this.discription_Label.Text = "Discription:";
            // 
            // selectCourse_comboBox
            // 
            this.selectCourse_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCourse_comboBox.FormattingEnabled = true;
            this.selectCourse_comboBox.Location = new System.Drawing.Point(211, 27);
            this.selectCourse_comboBox.Name = "selectCourse_comboBox";
            this.selectCourse_comboBox.Size = new System.Drawing.Size(226, 24);
            this.selectCourse_comboBox.TabIndex = 4;
            this.selectCourse_comboBox.SelectedIndexChanged += new System.EventHandler(this.selectCourse_comboBox_SelectedIndexChanged);
            // 
            // label_TextBox
            // 
            this.label_TextBox.Location = new System.Drawing.Point(211, 72);
            this.label_TextBox.Name = "label_TextBox";
            this.label_TextBox.Size = new System.Drawing.Size(226, 22);
            this.label_TextBox.TabIndex = 5;
            // 
            // discription_textBox
            // 
            this.discription_textBox.Location = new System.Drawing.Point(211, 155);
            this.discription_textBox.Multiline = true;
            this.discription_textBox.Name = "discription_textBox";
            this.discription_textBox.Size = new System.Drawing.Size(226, 108);
            this.discription_textBox.TabIndex = 6;
            // 
            // period_numericUpDown
            // 
            this.period_numericUpDown.Location = new System.Drawing.Point(211, 113);
            this.period_numericUpDown.Name = "period_numericUpDown";
            this.period_numericUpDown.Size = new System.Drawing.Size(226, 22);
            this.period_numericUpDown.TabIndex = 7;
            // 
            // edit_Button
            // 
            this.edit_Button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.edit_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_Button.Location = new System.Drawing.Point(211, 279);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(226, 57);
            this.edit_Button.TabIndex = 8;
            this.edit_Button.Text = "EDIT";
            this.edit_Button.UseVisualStyleBackColor = false;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // editCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(509, 369);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.period_numericUpDown);
            this.Controls.Add(this.discription_textBox);
            this.Controls.Add(this.label_TextBox);
            this.Controls.Add(this.selectCourse_comboBox);
            this.Controls.Add(this.discription_Label);
            this.Controls.Add(this.period_Label);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.select_Course_Label);
            this.Name = "editCourseForm";
            this.Text = "editCourseForm";
            this.Load += new System.EventHandler(this.editCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.period_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label select_Course_Label;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label period_Label;
        private System.Windows.Forms.Label discription_Label;
        private System.Windows.Forms.ComboBox selectCourse_comboBox;
        private System.Windows.Forms.TextBox label_TextBox;
        private System.Windows.Forms.TextBox discription_textBox;
        private System.Windows.Forms.NumericUpDown period_numericUpDown;
        private System.Windows.Forms.Button edit_Button;
    }
}