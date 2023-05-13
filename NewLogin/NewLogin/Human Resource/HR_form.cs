using System;
using NewLogin;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NewLogin.Group;
using System.Windows.Forms.DataVisualization.Charting;
using NewLogin.Contacts;

namespace NewLogin.Human_Resource
{
    public partial class HR_form : Form
    {
        public HR_form()
        {
            InitializeComponent();
        }
        MY_DB mydb=new MY_DB();
        GROUP gr= new GROUP();
        CONTACT contact = new CONTACT();
        private void HR_form_Load(object sender, EventArgs e)
        {
            comboBox_gr.DataSource = gr.getAllGR();
            comboBox_gr.DisplayMember = "id";
            comboBox_gr.ValueMember = "id";
            comboBox_gr.SelectedItem = null;
            comboBox_removeGR.DataSource = gr.getAllGR();
            comboBox_removeGR.DisplayMember = "gr_name";
            comboBox_removeGR.ValueMember = "id";
            comboBox_removeGR.SelectedItem = null;
            comboBox_reContact.DataSource = contact.getAllContact();
            comboBox_reContact.DisplayMember = "id";
            comboBox_reContact.ValueMember="id";
            comboBox_reContact.SelectedItem = null;
            SqlDataAdapter adapter= new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select * from HR where id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            adapter.SelectCommand= command;
            adapter.Fill(table);
            if(table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picTure = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picTure);
                label_Welcome.Text = "Welcomback " + table.Rows[0]["username"].ToString();
            }
            else
                MessageBox.Show("Invalid Fisrt Name", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label_edit_Click(object sender, EventArgs e)
        {
            editHRForm eHF = new editHRForm();
            eHF.ShowDialog();
        }

        private void button_addGR_Click(object sender, EventArgs e)
        {
            if (textBox_addGr.Text.Trim() == "" || textBox_idGR.Text.Trim() == "")
                MessageBox.Show("Insert Value", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string grName = textBox_addGr.Text;
                int grID = Convert.ToInt32(textBox_idGR.Text);
                if (gr.checkID(grID, grName,"add"))
                    MessageBox.Show("This Group Name Or ID Already Exist", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (gr.insertGROUP(grID, grName, GLOBAL.GlobalUserId))
                        MessageBox.Show("Done", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something Wrong", "Insert Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_editGR_Click(object sender, EventArgs e)
        {
            if(textBox_editGR.Text.Trim()==""||comboBox_gr.SelectedValue==null)
                MessageBox.Show("Insert Value", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int editGrId = Convert.ToInt32(comboBox_gr.SelectedValue);
                string editGrName = textBox_editGR.Text;
                if (gr.checkID(editGrId, editGrName, "edit"))
                    MessageBox.Show("This Group Name Already Exist", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (gr.updateGROUP(editGrId, editGrName, GLOBAL.GlobalUserId))
                        MessageBox.Show("Done", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something Wrong", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int removeGrId = Convert.ToInt32(comboBox_removeGR.SelectedValue);
            if(comboBox_removeGR.SelectedValue==null)
                MessageBox.Show("Insert Value", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(gr.deleteGROUP(removeGrId))
                    MessageBox.Show("Done", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Something Wrong", "Remove Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           /* comboBox_removeGR.DataSource = gr.getAllGR();
            comboBox_removeGR.DisplayMember = "gr_name";
            comboBox_removeGR.ValueMember = "id";*/
        }

        private void comboBox_gr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)comboBox_gr.SelectedValue;
                DataTable table = new DataTable();
                //table = courses.getCoursebyID(id);
                table = gr.getGRbyID(id);
                /*label_TextBox.Text = table.Rows[0][1].ToString();
                period_numericUpDown.Value = Int32.Parse(table.Rows[0][2].ToString());
                discription_textBox.Text = table.Rows[0][3].ToString();*/
                textBox_editGR.Text = table.Rows[0][1].ToString().Trim();
            }
            catch { }
        }

        private void label_refresh_Click(object sender, EventArgs e)
        {
            comboBox_gr.DataSource = gr.getAllGR();
            comboBox_gr.DisplayMember = "id";
            comboBox_gr.ValueMember = "id";
            comboBox_gr.SelectedItem = null;
            if (comboBox_gr.SelectedItem == null)
                textBox_editGR.Text = "";
            comboBox_removeGR.DataSource = gr.getAllGR();
            comboBox_removeGR.DisplayMember = "gr_name";
            comboBox_removeGR.ValueMember = "id";
            comboBox_removeGR.SelectedItem = null;
            comboBox_reContact.DataSource = contact.getAllContact();
            comboBox_reContact.DisplayMember = "id";
            comboBox_reContact.ValueMember = "id";
            comboBox_reContact.SelectedItem = null;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("select * from HR where id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = GLOBAL.GlobalUserId;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picTure = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picTure);
                label_Welcome.Text = "Welcomback " + table.Rows[0]["username"].ToString();
            }
            else
                MessageBox.Show("Invalid Fisrt Name", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            addContactForm aCF = new addContactForm();
            aCF.ShowDialog();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            editContactForm eCF=new editContactForm();
            eCF.ShowDialog();
        }



        private void button_remove_Click_1(object sender, EventArgs e)
        {
            if(comboBox_reContact.SelectedItem==null)
                MessageBox.Show("Enter Value", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
               if(contact.deleteContact((int)comboBox_reContact.SelectedValue))
                    MessageBox.Show("Completed", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               else
                    MessageBox.Show("Fail To Delete", "Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {

        }
    }
}
