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
    public partial class addCourseForm : Form
    {
        public addCourseForm()
        {
            InitializeComponent();
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            try
            {
                string Cid = id_TextBox.Text;
                string name = label_TextBox.Text;
                int hrs = Convert.ToInt32(period_TextBox.Text);
                string desc = discription_TextBox.Text;
                COURSE courses = new COURSE();         
                if (name.Trim() == "")
                    MessageBox.Show("Add A New Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (courses.checkCourseName(name, Cid))//, Cid
                {
                    if (courses.insertCourse(Cid, name, hrs, desc))
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Something Is Wrong", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
