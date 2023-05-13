using NewLogin.USER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Human_Resource
{
    public partial class createHRForm : Form
    {
        public createHRForm()
        {
            InitializeComponent();
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        HUMAN_R hr = new HUMAN_R();
        private void button_upload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            int id = Int32.Parse(textBox_ID.Text);
            string userNAME = textBox_uname.Text;
            string passWORD = textBox_pword.Text;
            string fNAME = textBox_fname.Text;
            string lNAME = textBox_lname.Text;
            MemoryStream pic = new MemoryStream();
            bool verif()
            {
                if (textBox_ID.Text.Trim() == ""
                    || textBox_fname.Text.Trim() == ""
                    || textBox_lname.Text.Trim() == ""
                    || textBox_uname.Text.Trim() == ""
                    || textBox_pword.Text.Trim() == ""
                    || pictureBox1.Image == null)
                    return false;
                else
                    return true;
            }
            if (!checkName(lNAME))
                MessageBox.Show("Invalid Last Name", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!checkName(fNAME))
                MessageBox.Show("Invalid Fisrt Name", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (hr.usernameExist(userNAME,"register", id))
                {
                    MessageBox.Show("This Username Or Id Already Existed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (hr.insertUser(id, fNAME, lNAME, userNAME, passWORD, pic))
                    {
                        MessageBox.Show("User Inserted", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Error", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }

}
