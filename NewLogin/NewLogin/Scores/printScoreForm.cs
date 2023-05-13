using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Scores
{
    public partial class printScoreForm : Form
    {
        public printScoreForm()
        {
            InitializeComponent();
        }
        SCORE score= new SCORE();
        private void printScoreForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from scores");
            fillGrid(command);
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = score.fillCommand(command);
            //picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
            // picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
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

        private void print_button_Click(object sender, EventArgs e)
        {
            PrintDialog prD = new PrintDialog();
            PrintDocument prDoc = new PrintDocument();
            prDoc.DocumentName = "Print Document";
            prD.Document = prDoc;
            prD.AllowSelection = true;
            prD.AllowSomePages = true;
            if (prD.ShowDialog() == DialogResult.OK)
                prDoc.Print();
        }

        private void save_button_Click(object sender, EventArgs e)
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

        private void finding_Button_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from scores where student_ID=@Id");
                command.Parameters.AddWithValue("@Id", finding_textBox.Text);
                //SqlCommand command = new SqlCommand("SELECT * FROM students WHERE CONCAT (id, fname, phone) like '% " + Finding_Box_Type.Text + " %' ");
                fillGrid(command);
            }
            catch
            {
                MessageBox.Show("Invalid ID", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
