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

namespace NewLogin
{
    public partial class Add_Student_Form : Form
    {
        public Add_Student_Form()
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
        private void Add_Button_Click(object sender, EventArgs e)
        {
            STUDENTS stu= new STUDENTS();
            string id = Studen_Id_Text.Text;
            string fname =Fname_Text.Text;
            string lname =Lname_Text.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = Phone_Text.Text;
            string address=Address_Text.Text;
            string major=Major_Box.Text;
            string school_year=SchYear_Box.Text;
            string gender = "Male";
            if (Female_Button.Checked)
                gender = "Female";
            if (Other_Button.Checked)
                gender = "Other";
            MemoryStream pic = new MemoryStream();
            int born_year =dateTimePicker1.Value.Year;
            int this_year=DateTime.Now.Year;
            //Them gioi han do tuoi
            if (this_year - born_year < 18 || this_year - born_year > 100)
                MessageBox.Show("The Student Age Must Be Between 10 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(!checkName(fname))
            {
                MessageBox.Show("Wrong First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkName(lname))
            {
                MessageBox.Show("Wrong Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkPhone(phone))
            {
                MessageBox.Show("Wrong Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                if (stu.insertStudent(id, fname, lname, bdate, gender, phone, address, major, school_year, pic))
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        bool verif()
        {
            if(Fname_Text.Text.Trim()==""
                ||Lname_Text.Text.Trim()==""
                ||Address_Text.Text.Trim()==""
                ||Phone_Text.Text.Trim()==""
                ||Major_Box.Text.Trim()==""
                ||SchYear_Box.Text.Trim()==""
                ||pictureBox1.Image==null)
                return false;
            else
                return true;    
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Upload_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf=new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(opf.FileName);
            }
        }

    }
}