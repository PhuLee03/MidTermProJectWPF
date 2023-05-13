using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin
{
    public partial class Print_Form : Form
    {
        public Print_Form()
        {
            InitializeComponent();
        }
        STUDENTS student = new STUDENTS();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void Print_Form_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from students");
            fillGrid(command);
            if(No_Button.Checked)
            {
                dateTimePicker1.Enabled= false;
                dateTimePicker2.Enabled= false;
            }
        }

        private void Yes_Button_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void No_Button_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void check_Button_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            string query;
            if(Yes_Button.Checked)
            {
                string date1=dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string date2 = dateTimePicker2.Value.ToString("dd-MM-yyyy");
                if(male_Button.Checked)
                    query="select * from students where gender = 'Male' and bdate between '"+date1+"'and'"+date2+"'"; 
                else if(female_Button.Checked)
                    query = "select * from students where gender = 'Female' and bdate between '" + date1 + "'and'" + date2 + "'";
                else if(other_Button.Checked)
                    query = "select * from students where gender = 'Other' and bdate between '" + date1 + "'and'" + date2 + "'";
                else
                    query = "select * from students where bdate between '" + date1 + "'and'" + date2 + "'";
                command=new SqlCommand(query);
                fillGrid(command);
            }
            else
            {
                if(male_Button.Checked)
                    query = "select * from students where gender = 'Male'";
                else if(female_Button.Checked)
                    query = "select * from students where gender = 'Female'";
                else if(other_Button.Checked)
                    query = "select * from students where gender = 'Other'";
                else
                    query = "select * from students ";
                command=new SqlCommand(query);
                fillGrid(command);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                int RowCount = dataGridView1.Rows.Count;
                int ColumnCount = dataGridView1.Columns.Count;
                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                //dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                Object oMissing = System.Reflection.Missing.Value;
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";

                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        if (dataGridView1.Columns[c].ValueType == typeof(DateTime))
                        {
                            oTemp = oTemp + ((DateTime)dataGridView1.Rows[r].Cells[c].Value).ToShortDateString() + "\t";
                        }
                        else
                        {
                            oTemp = oTemp + dataGridView1.Rows[r].Cells[c].Value + "\t";
                        }
                    }
                    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara1.Range.Text = oTemp;
                    oPara1.Range.InsertParagraphAfter();
                    byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[9].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                   Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Paste();
                    oPara2.Range.InsertParagraphAfter();
                    //oTemp += "\n";
                }
                //save the file
                oDoc.SaveAs2(filename);
                for (int r = 0; r <= RowCount - 1; r++)
                {
                    oTemp = "";

                    for (int c = 0; c < ColumnCount - 1; c++)
                    {
                        if (dataGridView1.Columns[c].ValueType == typeof(DateTime))
                        {
                            oTemp = oTemp + ((DateTime)dataGridView1.Rows[r].Cells[c].Value).ToShortDateString() + "\t";
                        }
                        else
                        {
                            oTemp = oTemp + dataGridView1.Rows[r].Cells[c].Value + "\t";
                        }
                    }
                    byte[] imgbyte = (byte[])dataGridView1.Rows[r].Cells[9].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                   Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                }
            }
        }
       /* private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (.docx)|.docx";
            sfd.FileName = "export.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }

        }*/
        private void Save_To_Text_File_Button_Click(object sender, EventArgs e)
        {
            /*string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\students_list.txt";
            using (var writer=new StreamWriter(path))
            {
                if(!File.Exists(path))
                {
                    File.Create(path);
                    MessageBox.Show("Save Completed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DateTime bdate;
                for(int i=0;i<dataGridView1.RowCount;i++)
                {
                    for(int j=0;j<dataGridView1.ColumnCount-1;j++)
                    {
                        if(j==3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t"+bdate.ToString("dd-MM-yyyy")+"\t"+"|");
                        }
                        else if (j == dataGridView1.ColumnCount - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------------------------------------------");

                }
            }*/
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Word Documents (.docx)|.docx";
                sfd.FileName = "export.docx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Export_Data_To_Word(dataGridView1, sfd.FileName);
                    MessageBox.Show("Save Completed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                //MessageBox.Show("Something Wrong", "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void To_Printer_Button_Click(object sender, EventArgs e)
        {
            PrintDialog prD=new PrintDialog();
            PrintDocument prDoc=new PrintDocument();
            prDoc.DocumentName = "Print Document";
            prD.Document=prDoc;
            prD.AllowSelection= true;
            prD.AllowSomePages=true;
            if(prD.ShowDialog() == DialogResult.OK) 
                prDoc.Print();
        }

 
    }
}
