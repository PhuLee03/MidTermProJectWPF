using NewLogin.Course_Scores;
using NewLogin.Courses;
using NewLogin.Results;
using NewLogin.Scores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Student_Form addstdf=new Add_Student_Form();
            addstdf.ShowDialog(this);
        }
        private void studentsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_List_Form stdlist = new Student_List_Form();
            stdlist.ShowDialog(this);
        }
        private void stacticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Static_Form STF= new Static_Form();
            STF.ShowDialog(this);
        }
        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Student_Form upSTD = new Update_Student_Form();
            upSTD.ShowDialog();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print_Form prF = new Print_Form();
            prF.ShowDialog();
        }
        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm MNF= new ManageCourseForm();
            MNF.ShowDialog();
        }
        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCourseForm aCF = new addCourseForm();
            aCF.ShowDialog();
        }
        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCourseForm rCF = new removeCourseForm();
            rCF.ShowDialog();
        }
        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editCourseForm eCF = new editCourseForm();
            eCF.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            printCourseForm pCF = new printCourseForm();
            pCF.ShowDialog();
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addScoreForm aSF=new addScoreForm();
            aSF.ShowDialog();
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            averageScoreForm aSF = new averageScoreForm();
            aSF.ShowDialog();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeScoreForm rSF =new removeScoreForm();
            rSF.ShowDialog();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageScoreForm mSF = new manageScoreForm();
            mSF.ShowDialog();
        }

        private void averageResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            averageResultForm aRF = new averageResultForm();
            aRF.ShowDialog();
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staticResultForm sRF = new staticResultForm();
            sRF.ShowDialog();
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            printScoreForm pSF= new printScoreForm();
            pSF.ShowDialog();
        }
    }
}
