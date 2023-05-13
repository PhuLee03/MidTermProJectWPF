using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin
{
    public partial class Student_List_Form : Form
    {
        public Student_List_Form()
        {
            InitializeComponent();
        }
        STUDENTS student = new STUDENTS();
        private void Student_List_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDBDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.myDBDataSet.students);
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname, bdate, gender, phone, address, major, schoolYear, picture FROM students");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Id, fname, lname, bdate, gender, phone, address, major, schoolYear, picture FROM students");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_Student_Form upstd = new Update_Student_Form();
            upstd.Id_TextBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            upstd.Fname_TextBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            upstd.Lname_TextBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            upstd.BirthdateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Male")
                upstd.Male_Button.Checked = true;
            else if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
                upstd.Female_Button.Checked = true;
            else
                upstd.Other_Button.Checked = true;
            upstd.Phone_TextBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            upstd.Address_TextBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            upstd.Major_Box.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            upstd.Schoole_Year_Box.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[9].Value;
            MemoryStream picture = new MemoryStream(pic);
            upstd.Picture_PBox.Image = Image.FromStream(picture);
            upstd.Show();
        }
    }

}