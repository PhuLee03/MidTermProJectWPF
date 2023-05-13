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
    public partial class averageScoreForm : Form
    {
        public averageScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void averageScoreForm_Load(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("SELECT course_ID, AVG(student_Score) FROM scores GROUP BY course_ID;");
            dataGridView1.DataSource = score.getAvgScoreByCourse();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
