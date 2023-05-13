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
    public partial class removeCourseForm : Form
    {
        public removeCourseForm()
        {
            InitializeComponent();
        }

        private void remove_Button_Click(object sender, EventArgs e)
        {
            COURSE courses= new COURSE();
            try
            {
                string courseID=find_TextBox.Text;
                if((MessageBox.Show("Are You Sure You Want To Delete This Course","Remove Course", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes))
                {
                    if (courses.deleteCourse(courseID))
                        MessageBox.Show("Course Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }                  
            }
            catch
            {
                MessageBox.Show("Enter A Valid Numberic ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
