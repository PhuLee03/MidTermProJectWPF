using NewLogin.Courses;
using NewLogin.SEMESTER;
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
using System.Xml.Linq;

namespace NewLogin
{
    public partial class Update_Student_Form : Form
    {
        public Update_Student_Form()
        {
            InitializeComponent();
        }
        STUDENTS student = new STUDENTS();
        private void Find_Button_Click(object sender, EventArgs e)
        {
            if (find_Combo_Box.Text == "Find With Id: ")
            {
                SqlCommand command = new SqlCommand("select * from students where id=@Id");
                command.Parameters.AddWithValue("@Id", Finding_Box_Type.Text);  
                //SqlCommand command = new SqlCommand("SELECT * FROM students WHERE CONCAT (id, fname, phone) like '% " + Finding_Box_Type.Text + " %' ");
                fill_Grid(command);
            }
            else if(find_Combo_Box.Text == "Find With Name: ")
            {

                SqlCommand command = new SqlCommand("select * from students where fname=@name or lname=@name");
                command.Parameters.AddWithValue("@name", Finding_Box_Type.Text);
                fill_Grid(command);
            }
            else if(find_Combo_Box.Text == "Find With Phone: ")
            {
                SqlCommand command = new SqlCommand("select * from students where phone=@PH");
                command.Parameters.AddWithValue("@PH", Finding_Box_Type.Text);
                fill_Grid(command);
            }
            else
                MessageBox.Show("Choose Your Search's Option", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*command.Parameters.AddWithValue("@Id", Id_TextBox.Text);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                Fname_TextBox.Text = table.Rows[0]["fname"].ToString();
                Lname_TextBox.Text = table.Rows[0]["lname"].ToString();
                BirthdateTimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                if (table.Rows[0]["gender"].ToString() == "Male")
                    Male_Button.Checked = true;
                else if (table.Rows[0]["gender"].ToString() == "Female")
                    Female_Button.Checked = true;
                else
                    Other_Button.Checked = true;
                Phone_TextBox.Text = table.Rows[0]["phone"].ToString();
                Address_TextBox.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                Picture_PBox.Image = Image.FromStream(picture);
            }
            else
                MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
            // }
            // else
            //     MessageBox.Show("Not Found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

            /*string id = Id_TextBox.Text;
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname, bdate, gender, phone, address, picture  FROM students WHERE Id= " + id);

            SqlCommand command = new SqlCommand("SELECT * FROM student WHERE CONCAT (Id, fname, lname, address) LIKE %" + Id_TextBox.Text + "%");
            fillGrid(command);*/
            //MessageBox.Show("ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Upload_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                Picture_PBox.Image = Image.FromFile(opf.FileName);
            }
        }
        public bool checkName(string x)
        {
            return Regex.IsMatch(x, "^[a-zA-Z]{1,20}$");
        }
        public bool checkPhone(string x)
        {
            return Regex.IsMatch(x, "^[0-9]{9,12}$");
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            string id =Id_TextBox.Text;
            string fname = Fname_TextBox.Text;
            string lname = Lname_TextBox.Text;
            DateTime bdate = BirthdateTimePicker1.Value;
            string phone = Phone_TextBox.Text;
            string address = Address_TextBox.Text;
            string major = Major_Box.Text;
            string school_year = Schoole_Year_Box.Text;
            string gender = "Male";
            if (Female_Button.Checked)
                gender = "Female";
            if (Other_Button.Checked)
                gender = "Other";
            MemoryStream pic = new MemoryStream();
            int born_year = BirthdateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            //Them gioi han do tuoi
            if (this_year - born_year < 18 || this_year - born_year > 100)
                MessageBox.Show("The Student Age Must Be Between 10 and 100", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            /*else if (!checkName(fname))
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
            }*/
            else if (verif())
            {
                Picture_PBox.Image.Save(pic, Picture_PBox.Image.RawFormat);
                if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, major, school_year, pic))
                    MessageBox.Show("Student Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty Fields", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        bool verif()
        {
            if (Fname_TextBox.Text.Trim() == ""
                || Lname_TextBox.Text.Trim() == ""
                || Address_TextBox.Text.Trim() == ""
                || Phone_TextBox.Text.Trim() == ""
                || Major_Box.Text.Trim() == ""
                || Schoole_Year_Box.Text.Trim() == ""
                || Picture_PBox.Image == null)
                return false;
            else
                return true;
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string stdID = Id_TextBox.Text;
                if(MessageBox.Show("Are you sure you want delete this student ?","Delete Student",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                if (student.deleteStudent(stdID))
                {
                    student.deleteStudent(stdID);
                        MessageBox.Show("Student Deleted","Delete Student",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Id_TextBox.Text = "";
                            Fname_TextBox.Text = "";
                            Lname_TextBox.Text = "";
                            BirthdateTimePicker1.Value= DateTime.Now;
                            Phone_TextBox.Text = "";
                            Major_Box.Text = "";
                            Schoole_Year_Box.Text = "";
                            Address_TextBox.Text = "";
                            Picture_PBox.Image = null;
                }
                else
                {
                    MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                }
                 catch
            {
                MessageBox.Show("Please Enter a Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Update_Student_Form_Load(object sender, EventArgs e)
        {
            fill_Grid(new SqlCommand("select * from students"));
        }
        public void fill_Grid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addCourseWITHSEMESTER  aCWS= new addCourseWITHSEMESTER();
            aCWS.ShowDialog();
        }
    }
}
