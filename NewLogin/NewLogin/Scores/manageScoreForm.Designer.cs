namespace NewLogin.Scores
{
    partial class manageScoreForm
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
            this.studentID_textBox = new System.Windows.Forms.TextBox();
            this.Score_textBox = new System.Windows.Forms.TextBox();
            this.desc_textBox = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.avgScore_button = new System.Windows.Forms.Button();
            this.showSTD_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Description_TextBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // studentID_textBox
            // 
            this.studentID_textBox.Location = new System.Drawing.Point(177, 65);
            this.studentID_textBox.Name = "studentID_textBox";
            this.studentID_textBox.ReadOnly = true;
            this.studentID_textBox.Size = new System.Drawing.Size(187, 22);
            this.studentID_textBox.TabIndex = 0;
            // 
            // Score_textBox
            // 
            this.Score_textBox.Location = new System.Drawing.Point(177, 184);
            this.Score_textBox.Name = "Score_textBox";
            this.Score_textBox.ReadOnly = true;
            this.Score_textBox.Size = new System.Drawing.Size(187, 22);
            this.Score_textBox.TabIndex = 1;
            // 
            // desc_textBox
            // 
            this.desc_textBox.Location = new System.Drawing.Point(177, 243);
            this.desc_textBox.Multiline = true;
            this.desc_textBox.Name = "desc_textBox";
            this.desc_textBox.ReadOnly = true;
            this.desc_textBox.Size = new System.Drawing.Size(187, 88);
            this.desc_textBox.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(12, 355);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 36);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_button.Location = new System.Drawing.Point(94, 355);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(114, 36);
            this.remove_button.TabIndex = 5;
            this.remove_button.Text = "REMOVE";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // avgScore_button
            // 
            this.avgScore_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgScore_button.Location = new System.Drawing.Point(214, 355);
            this.avgScore_button.Name = "avgScore_button";
            this.avgScore_button.Size = new System.Drawing.Size(150, 36);
            this.avgScore_button.TabIndex = 6;
            this.avgScore_button.Text = "Average Scores";
            this.avgScore_button.UseVisualStyleBackColor = true;
            this.avgScore_button.Click += new System.EventHandler(this.avgScore_button_Click);
            // 
            // showSTD_button
            // 
            this.showSTD_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSTD_button.Location = new System.Drawing.Point(27, 276);
            this.showSTD_button.Name = "showSTD_button";
            this.showSTD_button.Size = new System.Drawing.Size(129, 55);
            this.showSTD_button.TabIndex = 7;
            this.showSTD_button.Text = "Show Students";
            this.showSTD_button.UseVisualStyleBackColor = true;
            this.showSTD_button.Click += new System.EventHandler(this.showSTD_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(638, 326);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Course: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Score: ";
            // 
            // Description_TextBox
            // 
            this.Description_TextBox.AutoSize = true;
            this.Description_TextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description_TextBox.Location = new System.Drawing.Point(42, 245);
            this.Description_TextBox.Name = "Description_TextBox";
            this.Description_TextBox.Size = new System.Drawing.Size(114, 20);
            this.Description_TextBox.TabIndex = 13;
            this.Description_TextBox.Text = "Description: ";
            // 
            // manageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 408);
            this.Controls.Add(this.Description_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showSTD_button);
            this.Controls.Add(this.avgScore_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.desc_textBox);
            this.Controls.Add(this.Score_textBox);
            this.Controls.Add(this.studentID_textBox);
            this.Name = "manageScoreForm";
            this.Text = "manageScoreForm";
            this.Load += new System.EventHandler(this.manageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentID_textBox;
        private System.Windows.Forms.TextBox Score_textBox;
        private System.Windows.Forms.TextBox desc_textBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button avgScore_button;
        private System.Windows.Forms.Button showSTD_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Description_TextBox;
    }
}