using NewLogin.Group;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Contacts
{
    public partial class editContactForm : Form
    {
        public editContactForm()
        {
            InitializeComponent();
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        public bool checkPhone(string x)
        {
            return Regex.IsMatch(x, "^[0-9]{9,12}$");
        }
        CONTACT contact= new CONTACT();
        GROUP group = new GROUP();
        private void editContactForm_Load(object sender, EventArgs e)
        {
            comboBox_ID.DataSource = contact.getAllContact();
            comboBox_ID.DisplayMember = "id";
            comboBox_ID.ValueMember = "id";
            comboBox_ID.SelectedItem = null;
            comboBox_gr.DataSource = group.getAllGR();
            comboBox_gr.DisplayMember = "name";
            comboBox_gr.ValueMember = "id";
            comboBox_gr.SelectedItem = null;
        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ContactID = (int)comboBox_ID.SelectedValue;
                DataTable table = new DataTable();
                table = contact.getContactbyID(ContactID);
                textBox_fname.Text = table.Rows[0][1].ToString().Trim();
                textBox_lname.Text = table.Rows[0][2].ToString().Trim();
                comboBox_gr.SelectedValue = table.Rows[0][3].ToString().Trim();
                textBox_phone.Text = table.Rows[0][4].ToString().Trim();
                textBox_email.Text = table.Rows[0][5].ToString().Trim();
                textBox_address.Text = table.Rows[0][6].ToString().Trim();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picTure = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picTure);
            }
            catch
            {

            }
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
                
                if (textBox_fname.Text.Trim() == ""
                    || comboBox_ID.SelectedValue==null
                    || textBox_lname.Text.Trim() == ""
                    || comboBox_gr.SelectedValue == null
                    || textBox_phone.Text.Trim() == ""
                    || textBox_email.Text.Trim() == ""
                    || textBox_address.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Value", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {   
                    int iD = Convert.ToInt32(comboBox_ID.SelectedValue);
                    string fName = textBox_fname.Text.Trim();
                    string lName = textBox_lname.Text.Trim();
                    string gr_ID = comboBox_gr.SelectedValue.ToString();
                    string pHone = textBox_phone.Text.Trim();
                    string email = textBox_email.Text.Trim();
                    string addRess = textBox_address.Text.Trim();
                    MemoryStream pic = new MemoryStream();
                    if (!checkName(fName))
                        MessageBox.Show("Invalid First Name", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (!checkName(lName))
                        MessageBox.Show("Invalid First Name", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (!checkPhone(pHone))
                        MessageBox.Show("Invalid Phone Number", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                        if (contact.updateContact(iD, fName, lName, gr_ID, pHone, email, addRess, pic, GLOBAL.GlobalUserId))
                            MessageBox.Show("New Contact Update", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                

        }
    }
}
