using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace NewLogin.USER
{
    public partial class createAccountForm : Form
    {
        public createAccountForm()
        {
            InitializeComponent();
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        USER user = new USER();
        private void button_Regis_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            int id = Int32.Parse(textBox_ID.Text);
            string userNAME = textBox_Uname.Text;
            string passWORD = textBox_Pword.Text;
            string fNAME = textBox_Fname.Text;
            string lNAME = textBox_Lname.Text;
            MemoryStream pic = new MemoryStream();
            bool verif()
            {
                if (textBox_ID.Text.Trim() == ""
                    || textBox_Fname.Text.Trim() == ""
                    || textBox_Lname.Text.Trim() == ""
                    || textBox_Uname.Text.Trim() == ""
                    || textBox_Pword.Text.Trim() == ""
                    || pictureBox1.Image == null)
                    return false;
                else
                    return true;
            }
            if(!checkName(lNAME))
                MessageBox.Show("Invalid Last Name", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!checkName(fNAME))
                MessageBox.Show("Invalid Fisrt Name", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (verif())
            {
                if (user.checkUser( userNAME, id))
                {
                    MessageBox.Show("This Username Or Id Already Existed", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (user.insertUser(id, fNAME, lNAME, userNAME, passWORD, pic))
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
        private void button_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
    }
}
