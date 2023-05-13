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
    public partial class manageScoreForm : Form
    {
        public manageScoreForm()
        {
            InitializeComponent();
        }
        SCORE score =new SCORE();
        private void manageScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from scores");
            fill_Grid(command);
            comboBox2.DataSource= score.getAllScore();
            comboBox2.DisplayMember = "course_ID";
            comboBox2.ValueMember= "course_ID";
        }
        public void fill_Grid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = score.fillCommand(command);           
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID_textBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox2.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Score_textBox.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            desc_textBox.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            addScoreForm aSF= new addScoreForm();
            aSF.ShowDialog();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            removeScoreForm rSF=new removeScoreForm();
            rSF.ShowDialog();
        }

        private void avgScore_button_Click(object sender, EventArgs e)
        {
            averageScoreForm aSF =new averageScoreForm();
            aSF.ShowDialog();
        }

        private void showSTD_button_Click(object sender, EventArgs e)
        {
            Student_List_Form sLF =new Student_List_Form();
            sLF.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
