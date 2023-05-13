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
    public partial class removeScoreForm : Form
    {
        public removeScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        private void removeScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from scores");
            dataGridView1.DataSource = score.fillCommand(command);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string stdID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string cID = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if ((MessageBox.Show("Are You Sure You Want To Delete This Score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (score.deleteScore(stdID, cID))
                    MessageBox.Show("Score Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Score Not Deleted", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from scores");
            dataGridView1.DataSource = score.fillCommand(command);
        }
    }
}
