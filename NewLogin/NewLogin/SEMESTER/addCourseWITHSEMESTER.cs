using Microsoft.Office.Interop.Word;
using NewLogin.Course_Scores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewLogin.SEMESTER
{
    public partial class addCourseWITHSEMESTER : Form
    {
        public addCourseWITHSEMESTER()
        {
            InitializeComponent();
        }
        public int i = 0;
        public string[] arr = new string[50];
        COURSE courses = new COURSE();
        STUDENTS std=new STUDENTS();
        SEMESTER se=new SEMESTER();
        //DataTable table=new DataTable();
        private void addCourseWITHSEMESTER_Load(object sender, EventArgs e)
        {
            /*combobox1.DataSource = courses.getAllCourse();
            selectCourse_comboBox.DisplayMember = "id";
            selectCourse_comboBox.ValueMember = "id";
            selectCourse_comboBox.SelectedItem = null;*/
            listBox1.DataSource= courses.getAllCourse();
            listBox1.DisplayMember = "label";
            listBox1.ValueMember= "id";
            listBox1.SelectedItem = null;
            comboBox_id.DataSource = std.getAllStudent();
            comboBox_id.DisplayMember = "id";
            comboBox_id.ValueMember = "id";
            comboBox_id.SelectedItem = null;
            for (int i = 1; i <= 8; i++)
            {
                selectSemester_comboBox.Items.Add(i);
            }
           // listBox2.DisplayMember = "label";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.IndexOf(listBox1.SelectedValue) != -1)
            {
                MessageBox.Show("This Course Already Set", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // item does not exist in comboBox1
                listBox2.Items.Add(listBox1.SelectedValue);
                arr[i] = listBox1.SelectedValue.ToString();
                i++;
            }
            
        }

        private void selectSemester_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // listBox2.Items.Clear();
            arr[listBox2.SelectedIndex] = null;
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox2.Refresh();
            //Array.Copy(arr, listBox2.SelectedIndex + 1, arr, listBox2.SelectedIndex, arr.Length - listBox2.SelectedIndex - 1);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = -1;          
           // listBox1.SelectedIndex = MouseClick;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            //listBox2.SelectedIndex = 0;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            //int x = 0;
            for(int x=0;x<=i;x++)
            {
                if (arr[x] != null)
                {
                    se.insertSemester(comboBox_id.SelectedValue.ToString(), arr[x], selectSemester_comboBox.SelectedIndex+1);
                }
            }
            MessageBox.Show("Completed", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
