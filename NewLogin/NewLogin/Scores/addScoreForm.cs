using NewLogin.Course_Scores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Scores
{
    public partial class addScoreForm : Form
    {
        public addScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course = new COURSE();
        STUDENTS student = new STUDENTS();
        private void addScoreForm_Load(object sender, EventArgs e)
        {
            //SqlCommand command0=new SqlCommand("select Id from students");
            IDSTD_comboBox.DataSource = student.getAllStudent();
            IDSTD_comboBox.DisplayMember= "Id";
            IDSTD_comboBox.ValueMember= "Id";

            selectCourse_comboBox.DataSource = course.getAllCourse();
            selectCourse_comboBox.DisplayMember = "label";
            selectCourse_comboBox.ValueMember = "id";
            SqlCommand command = new SqlCommand("select Id, fname, lname from students");
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            IDSTD_comboBox.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void addScore_button_Click(object sender, EventArgs e)
        {
            try
            {
                string studentID = (string)IDSTD_comboBox.SelectedValue ;
                string courseID = (string)selectCourse_comboBox.SelectedValue;
                float scoreValue = float.Parse(score_textBox.Text);
                //scoreValue = float.Parse(scoreValue.ToString("0.0"));
                string desc = description_textBox.Text;
                if (scoreValue < 0 || scoreValue > 10)
                {
                    MessageBox.Show("Wrong Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!score.studentScoreExist(studentID,courseID))
                {
                    if(score.insertScore(studentID, courseID, scoreValue, desc))                
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
