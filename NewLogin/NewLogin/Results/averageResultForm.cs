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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewLogin.Results
{
    public partial class averageResultForm : Form
    {
        public averageResultForm()
        {
            InitializeComponent();
        }
        SCORE score =new SCORE();
        STUDENTS std =new STUDENTS();
        MY_DB my_db = new MY_DB();
        private string GetLabels()
        {
            // Tạo câu lệnh SQL để lấy tất cả các label trong bảng Course
            string sql = "SELECT label FROM courses";

            // Thực hiện câu lệnh SQL và lấy kết quả trả về
            System.Data.DataTable dt = GetData(sql);

            // Duyệt qua từng dòng trong DataTable để tạo các column tương ứng trên DataGridView
            string labels = "";
            foreach (DataRow row in dt.Rows)
            {
                string label = row["label"].ToString();
                labels += $"MAX(CASE WHEN courses.label = '{label}' THEN scores.student_Score ELSE NULL END) AS '{label}', ";
            }

            // Xóa ký tự ',' cuối cùng
            labels = labels.Remove(labels.Length - 2);

            return labels;
        }
        private System.Data.DataTable GetData(string sql)
        {
            // Tạo đối tượng SqlConnection để kết nối với database
            using (SqlConnection conn =
                   new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myDB;Integrated Security=True"))
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ database
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    // Tạo đối tượng DataTable để chứa dữ liệu trả về
                    System.Data.DataTable dt = new System.Data.DataTable();

                    // Mở kết nối tới database
                    conn.Open();

                    // Lấy dữ liệu từ database và đổ vào DataTable
                    da.Fill(dt);

                    // Đóng kết nối tới database
                    conn.Close();

                    // Trả về DataTable chứa dữ liệu trả về từ database
                    return dt;
                }
            }
        }
        private void averageResultForm_Load(object sender, EventArgs e)
        {
            string z= $"SELECT students.id, students.fname, students.lname, {GetLabels()}, AVG(scores.student_Score) AS AvgScore, " +
                         $"CASE WHEN AVG(scores.student_Score) >= 5 THEN 'Pass' ELSE 'Fail' END AS Result " +
                         $"FROM students " +
                         $"LEFT JOIN scores  ON students.id = scores.student_ID " +
                         $"LEFT JOIN courses  ON scores.course_ID = courses.id " +

                         $"GROUP BY students.id, students.fname, students.lname " +
                         $"ORDER BY students.id";
            //SqlCommand command = new SqlCommand("select Id, fname, lname, course_ID, student_Score from students inner join scores on students.Id=scores.student_ID");
            //SqlCommand command = new SqlCommand("select Id,course_ID, student_Score from students, scores where Id=student_ID");
            SqlCommand command= new SqlCommand(z);
            fill_Grid(command);
        }
        public void fill_Grid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = score.fillCommand(command);
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stdID_textBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            fname_textBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lname_textBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            scoreID_textBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            scoreName_textBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("select Id, fname, lname, course_ID, student_Score from students inner join scores on students.Id=scores.student_ID where students.Id=@Id");
            //SqlCommand command = new SqlCommand("select * from students where id=@Id");
            command.Parameters.AddWithValue("@Id", search_textBox.Text);
            //SqlCommand command = new SqlCommand("SELECT * FROM students WHERE CONCAT (id, fname, phone) like '% " + Finding_Box_Type.Text + " %' ");
            fill_Grid(command);
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void print_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (.docx)|.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(sfd.FileName);
                MessageBox.Show("Save Completed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Export_Data_To_Word(string filename)
        {
            // Create a new Word document
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var wordDoc = wordApp.Documents.Add();

            // Add a table with the same number of columns as the DataGridView
            var dataGridView = dataGridView1;
            var numColumns = dataGridView.ColumnCount;
            var numRows = dataGridView.RowCount + 1;
            var wordTable = wordDoc.Tables.Add(wordDoc.Range(), numRows, numColumns);
            wordTable.Borders.Enable = 1;

            // Copy the column headers from the DataGridView to the Word table
            for (var i = 0; i < numColumns; i++)
            {
                wordTable.Cell(1, i + 1).Range.Text = dataGridView.Columns[i].HeaderText;
            }

            // Copy the data from the DataGridView to the Word table
            for (var row = 0; row < dataGridView.RowCount; row++)
            {
                for (var col = 0; col < numColumns; col++)
                {
                    var value = dataGridView.Rows[row].Cells[col].Value;
                    wordTable.Cell(row + 2, col + 1).Range.Text = value != null ? value.ToString() : "";
                }
            }

            // Save the Word document
            wordDoc.SaveAs2(filename);
            wordApp.Quit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select Id, fname, lname, course_ID, student_Score from students inner join scores on students.Id=scores.student_ID");
            //SqlCommand command = new SqlCommand("select Id,course_ID, student_Score from students, scores where Id=student_ID");
            fill_Grid(command);
        }
    }
}
