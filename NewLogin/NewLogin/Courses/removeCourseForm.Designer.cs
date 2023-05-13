namespace NewLogin.Courses
{
    partial class removeCourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.find_TextBox = new System.Windows.Forms.TextBox();
            this.remove_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID\'s Course:";
            // 
            // find_TextBox
            // 
            this.find_TextBox.Location = new System.Drawing.Point(238, 65);
            this.find_TextBox.Multiline = true;
            this.find_TextBox.Name = "find_TextBox";
            this.find_TextBox.Size = new System.Drawing.Size(159, 32);
            this.find_TextBox.TabIndex = 1;
            // 
            // remove_Button
            // 
            this.remove_Button.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.remove_Button.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_Button.Location = new System.Drawing.Point(421, 64);
            this.remove_Button.Name = "remove_Button";
            this.remove_Button.Size = new System.Drawing.Size(126, 33);
            this.remove_Button.TabIndex = 2;
            this.remove_Button.Text = "REMOVE";
            this.remove_Button.UseVisualStyleBackColor = false;
            this.remove_Button.Click += new System.EventHandler(this.remove_Button_Click);
            // 
            // removeCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(621, 153);
            this.Controls.Add(this.remove_Button);
            this.Controls.Add(this.find_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "removeCourseForm";
            this.Text = "removeCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox find_TextBox;
        private System.Windows.Forms.Button remove_Button;
    }
}