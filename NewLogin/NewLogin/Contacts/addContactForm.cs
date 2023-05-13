using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
using NewLogin.Group;
using System.Text.RegularExpressions;
using System.IO;

namespace NewLogin.Contacts
{
    public partial class addContactForm : Form
    {
        private int randomNumber;
        public addContactForm()
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
        GROUP gr = new GROUP();
        CONTACT contact=new CONTACT();
        public void button_send_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomNumber = rand.Next(1000, 9999);
            try
            {
                var serverEmail = new MailAddress("anhPhudeptraisieucapvjpPr0@gmail.com");
                const string passServerEmail = "fatrgfovhygzdtui";
                var clientEmail = new MailAddress(textBox_email.Text.Trim());
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(serverEmail.Address, passServerEmail),
                    Timeout = 20000,
                };
                using (var message = new MailMessage(serverEmail, clientEmail)
                {
                    Subject = "OTP Code",
                    Body = randomNumber.ToString()
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Email Sent Successful", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(randomNumber.ToString());
            if (Convert.ToInt32(textBox_otp.Text) != randomNumber)
            {
                MessageBox.Show("Email Sent Fail", "Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int iD = Convert.ToInt32(textBox_id.Text);
                string fName = textBox_fname.Text.Trim();
                string lName = textBox_lname.Text.Trim();
                string gr_ID = comboBox_gr.SelectedValue.ToString();
                string pHone = textBox_phone.Text.Trim();
                string email = textBox_email.Text.Trim();
                string addRess = textBox_address.Text.Trim();
                MemoryStream pic= new MemoryStream();
                if (textBox_fname.Text.Trim() == ""
                    || textBox_id.Text.Trim() == ""
                    || textBox_lname.Text.Trim() == ""
                    || comboBox_gr.SelectedValue == null
                    || textBox_phone.Text.Trim()==""
                    || textBox_email.Text.Trim()==""
                    || textBox_address.Text.Trim()=="")
                {
                    MessageBox.Show("Enter Value", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(contact.checkID(iD))
                    MessageBox.Show("This ID Already Exist", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!checkName(fName))
                    MessageBox.Show("Invalid First Name", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if(!checkName(lName))
                    MessageBox.Show("Invalid First Name", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if(!checkPhone(pHone))
                    MessageBox.Show("Invalid Phone Number", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (contact.insertContact(iD, fName, lName, gr_ID, pHone, email, addRess, pic, GLOBAL.GlobalUserId))
                        MessageBox.Show("New Contact Added", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Error", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void addContactForm_Load(object sender, EventArgs e)
        {
            comboBox_gr.DataSource = gr.getAllGR();
            comboBox_gr.DisplayMember = "gr_name";
            comboBox_gr.ValueMember = "id";
            comboBox_gr.SelectedItem = null;
        }

        private void comboBox_gr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox_gr.SelectedValue;
                DataTable table = new DataTable();
                //table = courses.getCoursebyID(id);
                table = gr.getGRbyID(id);
                /*label_TextBox.Text = table.Rows[0][1].ToString();
                period_numericUpDown.Value = Int32.Parse(table.Rows[0][2].ToString());
                discription_textBox.Text = table.Rows[0][3].ToString();*/
                //textBox_editGR.Text = table.Rows[0][1].ToString().Trim();
            }
            catch { }
        }
    }
}
