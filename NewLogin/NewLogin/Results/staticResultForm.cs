using NewLogin.Scores;
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

namespace NewLogin.Results
{
    public partial class staticResultForm : Form
    {
        public staticResultForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        MY_DB mydb= new MY_DB();
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        private void staticResultForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAvgScoreByCourse();
            label5.Text = ("Total Courses Registered:  " + execCount("SELECT COUNT(*) FROM scores"));
            int total= int.Parse(execCount("SELECT COUNT(*) FROM scores"));
            float pass = int.Parse(execCount("SELECT COUNT(*) FROM scores where student_Score >= 5"));
            float fail = int.Parse(execCount("SELECT COUNT(*) FROM scores where student_Score < 5"));
            label3.Text = ("Pass: "+(pass / total) * 100 + "%");
            label4.Text = ("Fail: "+(fail / total) * 100 + "%");
        }


    }
}
