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
    public partial class editHRForm : Form
    {
        public editHRForm()
        {
            InitializeComponent();
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        HUMAN_R hr = new HUMAN_R();
        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        public void fillCombo(int index)
        {
            comboBox_id.DataSource = hr.getAllHR();
            comboBox_id.DisplayMember = "id";
            comboBox_id.ValueMember = "id";
            comboBox_id.SelectedItem = index;
        }
        private void button_edit_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            if (comboBox_id.SelectedItem == null)
            {
                MessageBox.Show("Choose A Human Resource ID", "Update Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int ID = (int)comboBox_id.SelectedValue;
                string userNAME = textBox_uname.Text;
                string passWORD = textBox_pword.Text;
                string fNAME = textBox_fname.Text;
                string lNAME = textBox_lname.Text;
                MemoryStream pic = new MemoryStream();
                bool verif()
                {
                    if (
                         textBox_fname.Text.Trim() == ""
                        || textBox_lname.Text.Trim() == ""
                        || textBox_uname.Text.Trim() == ""
                        || textBox_pword.Text.Trim() == ""
                        || pictureBox1.Image == null)
                        return false;
                    else
                        return true;
                }
                if (!checkName(lNAME))
                    MessageBox.Show("Invalid Last Name", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (!checkName(fNAME))
                    MessageBox.Show("Invalid Fisrt Name", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (verif())
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (hr.usernameExist(userNAME,"edit", ID))
                    {
                        MessageBox.Show("This Username Or Id Already Existed", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (hr.updatetUser(ID, fNAME, lNAME, userNAME, passWORD, pic))
                        {
                            MessageBox.Show("User Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillCombo(comboBox_id.SelectedIndex);
                        }
                        else
                            MessageBox.Show("Error", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void editHRForm_Load(object sender, EventArgs e)
        {
            comboBox_id.DataSource = hr.getUserById(GLOBAL.GlobalUserId);
            comboBox_id.DisplayMember = "id";
            comboBox_id.ValueMember = "id";
            comboBox_id.SelectedItem = null;
        }

        private void comboBox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)comboBox_id.SelectedValue;
                DataTable table= new DataTable();
                table=hr.getUserById(ID);
                textBox_fname.Text = table.Rows[0][0].ToString().Trim();
                textBox_lname.Text = table.Rows[0][1].ToString().Trim(); 
                textBox_uname.Text = table.Rows[0][2].ToString().Trim();
                textBox_pword.Text = table.Rows[0][3].ToString().Trim();
                byte[] pic = (byte[])table.Rows[0][4];
                MemoryStream picTure = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picTure);
            }
            catch
            {
                
            }
        }
    }
}
