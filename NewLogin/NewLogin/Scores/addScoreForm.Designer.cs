namespace NewLogin.Scores
{
    partial class addScoreForm
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
            this.score_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.selectCourse_comboBox = new System.Windows.Forms.ComboBox();
            this.addScore_button = new System.Windows.Forms.Button();
            this.studentID_TextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDSTD_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // score_textBox
            // 
            this.score_textBox.Location = new System.Drawing.Point(176, 160);
            this.score_textBox.Name = "score_textBox";
            this.score_textBox.Size = new System.Drawing.Size(180, 22);
            this.score_textBox.TabIndex = 1;
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(176, 209);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(180, 107);
            this.description_textBox.TabIndex = 2;
            // 
            // selectCourse_comboBox
            // 
            this.selectCourse_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCourse_comboBox.FormattingEnabled = true;
            this.selectCourse_comboBox.Location = new System.Drawing.Point(176, 108);
            this.selectCourse_comboBox.Name = "selectCourse_comboBox";
            this.selectCourse_comboBox.Size = new System.Drawing.Size(180, 24);
            this.selectCourse_comboBox.TabIndex = 3;
            // 
            // addScore_button
            // 
            this.addScore_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addScore_button.Location = new System.Drawing.Point(176, 349);
            this.addScore_button.Name = "addScore_button";
            this.addScore_button.Size = new System.Drawing.Size(180, 47);
            this.addScore_button.TabIndex = 4;
            this.addScore_button.Text = "Add Score";
            this.addScore_button.UseVisualStyleBackColor = true;
            this.addScore_button.Click += new System.EventHandler(this.addScore_button_Click);
            // 
            // studentID_TextBox
            // 
            this.studentID_TextBox.AutoSize = true;
            this.studentID_TextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentID_TextBox.Location = new System.Drawing.Point(53, 59);
            this.studentID_TextBox.Name = "studentID_TextBox";
            this.studentID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.studentID_TextBox.TabIndex = 6;
            this.studentID_TextBox.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Course:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 384);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // IDSTD_comboBox
            // 
            this.IDSTD_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDSTD_comboBox.FormattingEnabled = true;
            this.IDSTD_comboBox.Location = new System.Drawing.Point(176, 55);
            this.IDSTD_comboBox.Name = "IDSTD_comboBox";
            this.IDSTD_comboBox.Size = new System.Drawing.Size(180, 24);
            this.IDSTD_comboBox.TabIndex = 11;
            // 
            // addScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.IDSTD_comboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentID_TextBox);
            this.Controls.Add(this.addScore_button);
            this.Controls.Add(this.selectCourse_comboBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.score_textBox);
            this.Name = "addScoreForm";
            this.Text = "addScoreForm";
            this.Load += new System.EventHandler(this.addScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox score_textBox;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.ComboBox selectCourse_comboBox;
        private System.Windows.Forms.Button addScore_button;
        private System.Windows.Forms.Label studentID_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        protected internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox IDSTD_comboBox;
    }
}