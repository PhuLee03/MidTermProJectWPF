using Microsoft.Office.Interop.Word;
using NewLogin.Course_Scores;
using System;
using Word = Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NewLogin.Courses
{
    public partial class printCourseForm : Form
    {
        public printCourseForm()
        {
            InitializeComponent();
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            //DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = courses.getCourses(command);
            //picCol = (DataGridViewImageColumn)dataGridView1.Columns[3];
           // picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        COURSE courses= new COURSE();
        private void printCourseForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select id as Ma_Khoa_Hoc, label as Ten_Khoa_Hoc, period as So_Tiet_Hoc, description as Mo_Ta from courses");
            fillGrid(command);
        }
        public void Export_Data_To_Word( string filename)
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

        private void button2_Click(object sender, EventArgs e)
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

        private void print_Button_Click(object sender, EventArgs e)
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
    }
}
