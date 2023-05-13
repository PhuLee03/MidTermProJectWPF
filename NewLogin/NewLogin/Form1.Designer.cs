namespace NewLogin
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
            this.AccountLogin = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Username_Text = new System.Windows.Forms.TextBox();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.Register_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.student_Button = new System.Windows.Forms.RadioButton();
            this.HR_Button = new System.Windows.Forms.RadioButton();
            this.button_Show = new System.Windows.Forms.Button();
            this.button_Hide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountLogin
            // 
            this.AccountLogin.AutoSize = true;
            this.AccountLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AccountLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AccountLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLogin.Location = new System.Drawing.Point(306, 42);
            this.AccountLogin.Name = "AccountLogin";
            this.AccountLogin.Size = new System.Drawing.Size(286, 50);
            this.AccountLogin.TabIndex = 0;
            this.AccountLogin.Text = "Account Login";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(301, 112);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(137, 29);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username:";
            this.Username.UseMnemonic = false;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(301, 153);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(131, 29);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password:";
            this.Password.UseMnemonic = false;
            // 
            // Username_Text
            // 
            this.Username_Text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text.Location = new System.Drawing.Point(444, 117);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(148, 27);
            this.Username_Text.TabIndex = 3;
            // 
            // Password_Text
            // 
            this.Password_Text.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.Location = new System.Drawing.Point(444, 155);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.PasswordChar = '*';
            this.Password_Text.Size = new System.Drawing.Size(148, 27);
            this.Password_Text.TabIndex = 4;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.LightCoral;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(306, 220);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(139, 44);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseMnemonic = false;
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Azure;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(453, 220);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(139, 44);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login";
            this.Login.UseMnemonic = false;
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register_Button
            // 
            this.Register_Button.BackColor = System.Drawing.Color.Honeydew;
            this.Register_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Register_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_Button.Location = new System.Drawing.Point(513, 270);
            this.Register_Button.Name = "Register_Button";
            this.Register_Button.Size = new System.Drawing.Size(79, 34);
            this.Register_Button.TabIndex = 10;
            this.Register_Button.Text = "Register";
            this.Register_Button.UseMnemonic = false;
            this.Register_Button.UseVisualStyleBackColor = false;
            this.Register_Button.Click += new System.EventHandler(this.Register_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NewLogin.Properties.Resources.Avatar_UTE;
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // student_Button
            // 
            this.student_Button.AutoSize = true;
            this.student_Button.Checked = true;
            this.student_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_Button.Location = new System.Drawing.Point(12, 284);
            this.student_Button.Name = "student_Button";
            this.student_Button.Size = new System.Drawing.Size(94, 27);
            this.student_Button.TabIndex = 11;
            this.student_Button.TabStop = true;
            this.student_Button.Text = "Student";
            this.student_Button.UseVisualStyleBackColor = true;
            // 
            // HR_Button
            // 
            this.HR_Button.AutoSize = true;
            this.HR_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HR_Button.Location = new System.Drawing.Point(112, 284);
            this.HR_Button.Name = "HR_Button";
            this.HR_Button.Size = new System.Drawing.Size(169, 27);
            this.HR_Button.TabIndex = 12;
            this.HR_Button.Text = "Human Resource";
            this.HR_Button.UseVisualStyleBackColor = true;
            // 
            // button_Show
            // 
            this.button_Show.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show.Location = new System.Drawing.Point(517, 191);
            this.button_Show.Name = "button_Show";
            this.button_Show.Size = new System.Drawing.Size(75, 23);
            this.button_Show.TabIndex = 13;
            this.button_Show.Text = "Show";
            this.button_Show.UseVisualStyleBackColor = true;
            this.button_Show.Click += new System.EventHandler(this.button_Show_Click);
            // 
            // button_Hide
            // 
            this.button_Hide.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Hide.Location = new System.Drawing.Point(517, 191);
            this.button_Hide.Name = "button_Hide";
            this.button_Hide.Size = new System.Drawing.Size(75, 23);
            this.button_Hide.TabIndex = 14;
            this.button_Hide.Text = "Hide";
            this.button_Hide.UseVisualStyleBackColor = true;
            this.button_Hide.Click += new System.EventHandler(this.button_Hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(618, 340);
            this.Controls.Add(this.button_Show);
            this.Controls.Add(this.HR_Button);
            this.Controls.Add(this.student_Button);
            this.Controls.Add(this.Register_Button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Username_Text);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.AccountLogin);
            this.Controls.Add(this.button_Hide);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountLogin;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Username_Text;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Register_Button;
        private System.Windows.Forms.RadioButton student_Button;
        private System.Windows.Forms.RadioButton HR_Button;
        private System.Windows.Forms.Button button_Show;
        private System.Windows.Forms.Button button_Hide;
    }
}

