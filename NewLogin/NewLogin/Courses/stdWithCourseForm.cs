using System.Data.SqlClient;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using Microsoft.Office.Interop.Word;
using NewLogin.Scores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Courses
{
    public partial class stdWithCourseForm : Form
    {
        string courid;
        string label;
        SCORE score = new SCORE();
        public stdWithCourseForm(string courid, string label)
        {
            InitializeComponent();
            this.courid = courid;
            this.label = label;
        }

        private void stdWithCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentOfCourse(courid);
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
        private void button_save_Click(object sender, EventArgs e)
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
/*        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            
            
        }*/
    }
}
