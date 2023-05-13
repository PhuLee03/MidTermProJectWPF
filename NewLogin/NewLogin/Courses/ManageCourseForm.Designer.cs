namespace NewLogin.Course_Scores
{
    partial class ManageCourseForm
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
            this.id_Label = new System.Windows.Forms.Label();
            this.label_Label = new System.Windows.Forms.Label();
            this.hours_number_Label = new System.Windows.Forms.Label();
            this.discription_Label = new System.Windows.Forms.Label();
            this.totalC_Label = new System.Windows.Forms.Label();
            this.id_TextBox = new System.Windows.Forms.TextBox();
            this.label_TextBox = new System.Windows.Forms.TextBox();
            this.dscpt_TextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.courseName_TextBox = new System.Windows.Forms.ListBox();
            this.first_Button = new System.Windows.Forms.Button();
            this.previous_Button = new System.Windows.Forms.Button();
            this.next_Button = new System.Windows.Forms.Button();
            this.last_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.remove_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Label.Location = new System.Drawing.Point(121, 31);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(31, 23);
            this.id_Label.TabIndex = 0;
            this.id_Label.Text = "ID:";
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Label.Location = new System.Drawing.Point(98, 69);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(54, 23);
            this.label_Label.TabIndex = 1;
            this.label_Label.Text = "Label:";
            // 
            // hours_number_Label
            // 
            this.hours_number_Label.AutoSize = true;
            this.hours_number_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_number_Label.Location = new System.Drawing.Point(27, 106);
            this.hours_number_Label.Name = "hours_number_Label";
            this.hours_number_Label.Size = new System.Drawing.Size(129, 23);
            this.hours_number_Label.TabIndex = 2;
            this.hours_number_Label.Text = "Hours Number:";
            // 
            // discription_Label
            // 
            this.discription_Label.AutoSize = true;
            this.discription_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discription_Label.Location = new System.Drawing.Point(61, 153);
            this.discription_Label.Name = "discription_Label";
            this.discription_Label.Size = new System.Drawing.Size(95, 23);
            this.discription_Label.TabIndex = 3;
            this.discription_Label.Text = "Discription:";
            // 
            // totalC_Label
            // 
            this.totalC_Label.AutoSize = true;
            this.totalC_Label.Location = new System.Drawing.Point(440, 206);
            this.totalC_Label.Name = "totalC_Label";
            this.totalC_Label.Size = new System.Drawing.Size(97, 16);
            this.totalC_Label.TabIndex = 4;
            this.totalC_Label.Text = "Total Courses: ";
            // 
            // id_TextBox
            // 
            this.id_TextBox.Location = new System.Drawing.Point(183, 33);
            this.id_TextBox.Name = "id_TextBox";
            this.id_TextBox.Size = new System.Drawing.Size(201, 22);
            this.id_TextBox.TabIndex = 5;
            // 
            // label_TextBox
            // 
            this.label_TextBox.Location = new System.Drawing.Point(183, 71);
            this.label_TextBox.Name = "label_TextBox";
            this.label_TextBox.Size = new System.Drawing.Size(201, 22);
            this.label_TextBox.TabIndex = 6;
            // 
            // dscpt_TextBox
            // 
            this.dscpt_TextBox.Location = new System.Drawing.Point(183, 155);
            this.dscpt_TextBox.Multiline = true;
            this.dscpt_TextBox.Name = "dscpt_TextBox";
            this.dscpt_TextBox.Size = new System.Drawing.Size(201, 133);
            this.dscpt_TextBox.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(183, 109);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(201, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // courseName_TextBox
            // 
            this.courseName_TextBox.FormattingEnabled = true;
            this.courseName_TextBox.ItemHeight = 16;
            this.courseName_TextBox.Location = new System.Drawing.Point(443, 33);
            this.courseName_TextBox.Name = "courseName_TextBox";
            this.courseName_TextBox.Size = new System.Drawing.Size(174, 148);
            this.courseName_TextBox.TabIndex = 9;
            this.courseName_TextBox.Click += new System.EventHandler(this.courseName_TextBox_Click);
            this.courseName_TextBox.SelectedIndexChanged += new System.EventHandler(this.courseName_TextBox_SelectedIndexChanged);
            this.courseName_TextBox.DoubleClick += new System.EventHandler(this.courseName_TextBox_DoubleClick);
            // 
            // first_Button
            // 
            this.first_Button.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_Button.Location = new System.Drawing.Point(41, 294);
            this.first_Button.Name = "first_Button";
            this.first_Button.Size = new System.Drawing.Size(75, 41);
            this.first_Button.TabIndex = 10;
            this.first_Button.Text = "First";
            this.first_Button.UseVisualStyleBackColor = true;
            this.first_Button.Click += new System.EventHandler(this.first_Button_Click);
            // 
            // previous_Button
            // 
            this.previous_Button.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_Button.Location = new System.Drawing.Point(122, 294);
            this.previous_Button.Name = "previous_Button";
            this.previous_Button.Size = new System.Drawing.Size(100, 41);
            this.previous_Button.TabIndex = 11;
            this.previous_Button.Text = "Previous";
            this.previous_Button.UseVisualStyleBackColor = true;
            this.previous_Button.Click += new System.EventHandler(this.previous_Button_Click);
            // 
            // next_Button
            // 
            this.next_Button.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_Button.Location = new System.Drawing.Point(228, 294);
            this.next_Button.Name = "next_Button";
            this.next_Button.Size = new System.Drawing.Size(75, 41);
            this.next_Button.TabIndex = 12;
            this.next_Button.Text = "Next";
            this.next_Button.UseVisualStyleBackColor = true;
            this.next_Button.Click += new System.EventHandler(this.next_Button_Click);
            // 
            // last_Button
            // 
            this.last_Button.Font = new System.Drawing.Font("Gill Sans MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_Button.Location = new System.Drawing.Point(309, 294);
            this.last_Button.Name = "last_Button";
            this.last_Button.Size = new System.Drawing.Size(75, 41);
            this.last_Button.TabIndex = 13;
            this.last_Button.Text = "Last";
            this.last_Button.UseVisualStyleBackColor = true;
            this.last_Button.Click += new System.EventHandler(this.last_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Button.Location = new System.Drawing.Point(41, 341);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(104, 43);
            this.add_Button.TabIndex = 14;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_Button.Location = new System.Drawing.Point(151, 341);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(114, 43);
            this.edit_Button.TabIndex = 15;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // remove_Button
            // 
            this.remove_Button.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_Button.Location = new System.Drawing.Point(271, 341);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(113, 43);
            this.remove_Button.TabIndex = 16;
            this.remove_Button.Text = "Remove";
            this.remove_Button.UseVisualStyleBackColor = true;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(666, 489);
            this.Controls.Add(this.remove_Button);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.last_Button);
            this.Controls.Add(this.next_Button);
            this.Controls.Add(this.previous_Button);
            this.Controls.Add(this.first_Button);
            this.Controls.Add(this.courseName_TextBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dscpt_TextBox);
            this.Controls.Add(this.label_TextBox);
            this.Controls.Add(this.id_TextBox);
            this.Controls.Add(this.totalC_Label);
            this.Controls.Add(this.discription_Label);
            this.Controls.Add(this.hours_number_Label);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.id_Label);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_Label;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label hours_number_Label;
        private System.Windows.Forms.Label discription_Label;
        private System.Windows.Forms.Label totalC_Label;
        private System.Windows.Forms.TextBox id_TextBox;
        private System.Windows.Forms.TextBox label_TextBox;
        private System.Windows.Forms.TextBox dscpt_TextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox courseName_TextBox;
        private System.Windows.Forms.Button first_Button;
        private System.Windows.Forms.Button previous_Button;
        private System.Windows.Forms.Button next_Button;
        private System.Windows.Forms.Button last_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.Button remove_Button;
    }
}