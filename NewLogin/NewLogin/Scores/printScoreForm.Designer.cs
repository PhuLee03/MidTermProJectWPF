namespace NewLogin.Scores
{
    partial class printScoreForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.finding_textBox = new System.Windows.Forms.TextBox();
            this.finding_Button = new System.Windows.Forms.Button();
            this.print_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find With Student ID:";
            // 
            // finding_textBox
            // 
            this.finding_textBox.Location = new System.Drawing.Point(643, 25);
            this.finding_textBox.Name = "finding_textBox";
            this.finding_textBox.Size = new System.Drawing.Size(145, 22);
            this.finding_textBox.TabIndex = 2;
            // 
            // finding_Button
            // 
            this.finding_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finding_Button.Location = new System.Drawing.Point(643, 53);
            this.finding_Button.Name = "finding_Button";
            this.finding_Button.Size = new System.Drawing.Size(145, 31);
            this.finding_Button.TabIndex = 3;
            this.finding_Button.Text = "Find";
            this.finding_Button.UseVisualStyleBackColor = true;
            this.finding_Button.Click += new System.EventHandler(this.finding_Button_Click);
            // 
            // print_button
            // 
            this.print_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_button.Location = new System.Drawing.Point(517, 53);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(99, 31);
            this.print_button.TabIndex = 4;
            this.print_button.Text = "PRINT";
            this.print_button.UseVisualStyleBackColor = true;
            this.print_button.Click += new System.EventHandler(this.print_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(291, 53);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(220, 31);
            this.save_button.TabIndex = 5;
            this.save_button.Text = "SAVE TO TEXT FILE";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // printScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.print_button);
            this.Controls.Add(this.finding_Button);
            this.Controls.Add(this.finding_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "printScoreForm";
            this.Text = "printScoreForm";
            this.Load += new System.EventHandler(this.printScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox finding_textBox;
        private System.Windows.Forms.Button finding_Button;
        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button save_button;
    }
}