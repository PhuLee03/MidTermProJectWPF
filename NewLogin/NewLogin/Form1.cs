using NewLogin.USER;
using NewLogin.Human_Resource;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace NewLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (student_Button.Checked==true)
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username=@Username AND password=@Password", db.getConnection);
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username_Text.Text;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password_Text.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                //MessageBox.Show("Ok bro!");
                {
                    this.Close();
                    MainForm mf = new MainForm();
                    mf.ShowDialog();
                    
                }
                else
                    MessageBox.Show("Not Ok bro!");
            }    
            else
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM HR WHERE username=@Username AND password=@Password", db.getConnection);
                command.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username_Text.Text;
                command.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password_Text.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    //MessageBox.Show("Ok bro!");
                    this.Close();
                    int userid = Convert.ToInt16(table.Rows[0][5].ToString());
                    GLOBAL.SetGlobalUserId(userid);
                    HR_form hr = new HR_form();
                    hr.ShowDialog();
                    
                }
                else
                    MessageBox.Show("Not Ok bro!");
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Register_Button_Click(object sender, EventArgs e)
        {
            if(student_Button.Checked == true)
            {
                createAccountForm cAF = new createAccountForm();
                cAF.ShowDialog();
            }
            else
            {
                createHRForm cHF=new createHRForm();
                cHF.ShowDialog();
            }
        }
        private void button_Show_Click(object sender, EventArgs e)
        {
            if (Password_Text.PasswordChar == '*')
            {
                button_Hide.BringToFront();
                Password_Text.PasswordChar = '\0';
            }
        }
        private void button_Hide_Click(object sender, EventArgs e)
        {
            if (Password_Text.PasswordChar == '\0')
            {
                button_Show.BringToFront();
                Password_Text.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
