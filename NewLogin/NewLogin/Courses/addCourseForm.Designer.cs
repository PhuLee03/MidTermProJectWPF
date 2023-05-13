namespace NewLogin.Courses
{
    partial class addCourseForm
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
            this.course_ID_Label = new System.Windows.Forms.Label();
            this.label_Label = new System.Windows.Forms.Label();
            this.period_Label = new System.Windows.Forms.Label();
            this.description_Label = new System.Windows.Forms.Label();
            this.id_TextBox = new System.Windows.Forms.TextBox();
            this.label_TextBox = new System.Windows.Forms.TextBox();
            this.period_TextBox = new System.Windows.Forms.TextBox();
            this.discription_TextBox = new System.Windows.Forms.TextBox();
            this.add_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // course_ID_Label
            // 
            this.course_ID_Label.AutoSize = true;
            this.course_ID_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_ID_Label.Location = new System.Drawing.Point(63, 47);
            this.course_ID_Label.Name = "course_ID_Label";
            this.course_ID_Label.Size = new System.Drawing.Size(93, 19);
            this.course_ID_Label.TabIndex = 0;
            this.course_ID_Label.Text = "Course ID:";
            // 
            // label_Label
            // 
            this.label_Label.AutoSize = true;
            this.label_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Label.Location = new System.Drawing.Point(99, 88);
            this.label_Label.Name = "label_Label";
            this.label_Label.Size = new System.Drawing.Size(57, 19);
            this.label_Label.TabIndex = 1;
            this.label_Label.Text = "Label:";
            // 
            // period_Label
            // 
            this.period_Label.AutoSize = true;
            this.period_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_Label.Location = new System.Drawing.Point(90, 131);
            this.period_Label.Name = "period_Label";
            this.period_Label.Size = new System.Drawing.Size(66, 19);
            this.period_Label.TabIndex = 2;
            this.period_Label.Text = "Period:";
            // 
            // description_Label
            // 
            this.description_Label.AutoSize = true;
            this.description_Label.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_Label.Location = new System.Drawing.Point(51, 172);
            this.description_Label.Name = "description_Label";
            this.description_Label.Size = new System.Drawing.Size(105, 19);
            this.description_Label.TabIndex = 3;
            this.description_Label.Text = "Description:";
            // 
            // id_TextBox
            // 
            this.id_TextBox.Location = new System.Drawing.Point(184, 46);
            this.id_TextBox.Name = "id_TextBox";
            this.id_TextBox.Size = new System.Drawing.Size(244, 22);
            this.id_TextBox.TabIndex = 4;
            // 
            // label_TextBox
            // 
            this.label_TextBox.Location = new System.Drawing.Point(184, 88);
            this.label_TextBox.Name = "label_TextBox";
            this.label_TextBox.Size = new System.Drawing.Size(244, 22);
            this.label_TextBox.TabIndex = 5;
            // 
            // period_TextBox
            // 
            this.period_TextBox.Location = new System.Drawing.Point(184, 130);
            this.period_TextBox.Name = "period_TextBox";
            this.period_TextBox.Size = new System.Drawing.Size(244, 22);
            this.period_TextBox.TabIndex = 6;
            // 
            // discription_TextBox
            // 
            this.discription_TextBox.Location = new System.Drawing.Point(184, 172);
            this.discription_TextBox.Multiline = true;
            this.discription_TextBox.Name = "discription_TextBox";
            this.discription_TextBox.Size = new System.Drawing.Size(244, 99);
            this.discription_TextBox.TabIndex = 7;
            // 
            // add_Button
            // 
            this.add_Button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.add_Button.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Button.Location = new System.Drawing.Point(184, 290);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(244, 59);
            this.add_Button.TabIndex = 8;
            this.add_Button.Text = "ADD";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // addCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(507, 403);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.discription_TextBox);
            this.Controls.Add(this.period_TextBox);
            this.Controls.Add(this.label_TextBox);
            this.Controls.Add(this.id_TextBox);
            this.Controls.Add(this.description_Label);
            this.Controls.Add(this.period_Label);
            this.Controls.Add(this.label_Label);
            this.Controls.Add(this.course_ID_Label);
            this.Name = "addCourseForm";
            this.Text = "addCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label course_ID_Label;
        private System.Windows.Forms.Label label_Label;
        private System.Windows.Forms.Label period_Label;
        private System.Windows.Forms.Label description_Label;
        private System.Windows.Forms.TextBox id_TextBox;
        private System.Windows.Forms.TextBox label_TextBox;
        private System.Windows.Forms.TextBox period_TextBox;
        private System.Windows.Forms.TextBox discription_TextBox;
        private System.Windows.Forms.Button add_Button;
    }
}