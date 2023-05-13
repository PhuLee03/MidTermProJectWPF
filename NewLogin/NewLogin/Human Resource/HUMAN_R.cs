using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLogin.Human_Resource
{
    internal class HUMAN_R
    {
        MY_DB mydb = new MY_DB();
        public DataTable getUserById(int userid)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM HR WHERE id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        string execCount(SqlCommand command)
        {
            /*SqlCommand command = new SqlCommand(query, mydb.getConnection);*/
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public bool checkUser(string userNAME, int ID)
        {
            //SqlCommand command = new SqlCommand("select count(*) from login where username=userNAME or id=ID", mydb.getConnection);
            SqlCommand command = new SqlCommand("select count(*) from HR where username=@user or id=@iD", mydb.getConnection);
            command.Parameters.AddWithValue("@id", ID);
            command.Parameters.AddWithValue("@user", userNAME);
            if (int.Parse(execCount(command)) > 0)
                return true;
            else
                return false;

        }
        public bool insertUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HR (id, fname, lname, username, password, picture)" + "VALUES (@id,@fn,@ln,@un,@pw,@fi)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fi", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM HR where username=@un ";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM HR where username=@un  AND id <> @uid";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public DataTable getAllHR()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HR", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updatetUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE HR SET fname = @fn, lname = @ln, username = @un, password = @pw, picture = @fi WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@fi", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() >0))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
    }
}
