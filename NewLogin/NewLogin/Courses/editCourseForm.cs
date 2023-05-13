using NewLogin.Course_Scores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Courses
{
    public partial class editCourseForm : Form
    {
        public editCourseForm()
        {
            InitializeComponent();
        }
        COURSE courses= new COURSE();
        private void editCourseForm_Load(object sender, EventArgs e)
        {
            selectCourse_comboBox.DataSource = courses.getAllCourse();
            selectCourse_comboBox.DisplayMember= "id";
            selectCourse_comboBox.ValueMember = "id";
            selectCourse_comboBox.SelectedItem = null;
        }
        public void fillCombo(string index)
        {
            selectCourse_comboBox.DataSource = courses.getAllCourse();
            selectCourse_comboBox.DisplayMember = "id";
            selectCourse_comboBox.ValueMember = "id";
            selectCourse_comboBox.SelectedItem = index;
        }

        private void selectCourse_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string id = (string)selectCourse_comboBox.SelectedValue;
                DataTable table = new DataTable();
                table = courses.getCoursebyID(id);
                label_TextBox.Text = table.Rows[0][1].ToString();
                period_numericUpDown.Value = Int32.Parse(table.Rows[0][2].ToString());
                discription_textBox.Text = table.Rows[0][3].ToString();
            }
            catch { }
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            if(selectCourse_comboBox.SelectedItem == null)
            {
                MessageBox.Show("Choose A Course ID", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string name = label_TextBox.Text;
                int hrs = (int)period_numericUpDown.Value;
                string desc = discription_textBox.Text;
                string id = (string)(selectCourse_comboBox.SelectedValue);
                if (!courses.checkCourseName(name, id))
                {
                    MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (courses.updateCourse(id, name, hrs, desc))
                {
                    MessageBox.Show("Course Updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillCombo(selectCourse_comboBox.SelectedIndex.ToString());
                }
                else
                {
                    MessageBox.Show("Course Not Updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
