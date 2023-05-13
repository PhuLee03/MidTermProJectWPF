using NewLogin.Courses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Course_Scores
{
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        
        int pos;

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            courseName_TextBox.DataSource = course.getAllCourse();
            courseName_TextBox.ValueMember = "id";
            courseName_TextBox.DisplayMember= "id";
            courseName_TextBox.SelectedItem = null;
            totalC_Label.Text = ("Total Courses: " + course.totalCourses());
        }
        public void showData(int index)
        {
            try
            {
                DataRow dr = course.getAllCourse().Rows[index];
                courseName_TextBox.SelectedIndex = index;
                id_TextBox.Text = dr.ItemArray[0].ToString();
                label_TextBox.Text = dr.ItemArray[1].ToString();
                numericUpDown1.Value = int.Parse(dr.ItemArray[2].ToString());
                dscpt_TextBox.Text = dr.ItemArray[3].ToString();
            }
            catch
            {
                MessageBox.Show("You Miss Your Click, Click Again Carefully Bro","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void add_Button_Click(object sender, EventArgs e)
        {
            string id=id_TextBox.Text;
            string label=label_TextBox.Text;
            int hrs = (int)numericUpDown1.Value;
            string dscpt=dscpt_TextBox.Text;
            
               
            if (label.Trim()=="")
            {
                MessageBox.Show("Add A Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
            }
            /*else if(course.checkID(id))
                MessageBox.Show("This ID Already Exit", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
            else if (course.checkCourseName(label, id))
            {
                    if (course.insertCourse(id, label, hrs, dscpt))
                    {
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    /*else
                    {
                        MessageBox.Show("", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }*/
            }
            else
            {
                MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            string name = label_TextBox.Text;
            int hrs = (int)numericUpDown1.Value;
            string descr = dscpt_TextBox.Text;
            string id = id_TextBox.Text;
/*            if(!course.checkID(id))
                MessageBox.Show("This ID Course Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);*/
            if (!course.checkCourseName(name, id))//, id_TextBox.Text
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (course.updateCourse(id, name, hrs, descr))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reloadListBoxData();
            }
            else
                MessageBox.Show("Course Not Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            pos = 0;    
        }

        private void remove_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string courseID = id_TextBox.Text;
                if((MessageBox.Show("Are You Sure You Want To Delete This Course", "Remove Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question))==DialogResult.Yes)
                {
                    if(course.deleteCourse(courseID))
                    {
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id_TextBox.Text= string.Empty;
                        label_TextBox.Text=string.Empty;
                        numericUpDown1.Value= 0;
                        dscpt_TextBox.Text= string.Empty;
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numberic ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos= 0;
        }

        private void courseName_TextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void courseName_TextBox_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)courseName_TextBox.SelectedItem;
            pos = courseName_TextBox.SelectedIndex;
            showData(pos);
        }

        private void first_Button_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void last_Button_Click(object sender, EventArgs e)
        {
            pos=course.getAllCourse().Rows.Count-1;
            showData(pos);
        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            if(pos>0)
            {
                pos--;
                showData(pos);
            }
        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            if(pos< course.getAllCourse().Rows.Count - 1)
            {
                pos++;
                showData(pos);
            }
        }

        private void courseName_TextBox_DoubleClick(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)courseName_TextBox.SelectedItem;
            int index = courseName_TextBox.SelectedIndex;
            DataRow dr = course.getAllCourse().Rows[index];
            courseName_TextBox.SelectedIndex = index;

            string courid = dr.ItemArray[0].ToString();
            string label = dr.ItemArray[1].ToString();
            stdWithCourseForm studentOfCourse = new stdWithCourseForm(courid, label);
            studentOfCourse.ShowDialog();
        }
    }
}
