using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewLogin.Course_Scores;

namespace NewLogin.Group
{
    internal class GROUP
    {
        MY_DB mydb=new MY_DB();
        public bool insertGROUP(int id, string name, int userid)
        {
            SqlCommand command= new SqlCommand("insert into groups(id, gr_name, userid) values(@ID, @Name, @uid)", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value=id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value=name;
            command.Parameters.Add("@uid", SqlDbType.Int).Value= userid;
            mydb.openConnection();
            if(command.ExecuteNonQuery()>0)
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
        public bool updateGROUP(int id, string name, int userid)
        {
            SqlCommand command = new SqlCommand("update groups set gr_name=@Name, userid=@uid where id=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            mydb.openConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool deleteGROUP(int id)
        {
            SqlCommand command = new SqlCommand("delete from groups where id=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() > 0)
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
        public bool checkID(int id, string name, string operation)
        {
            string query = "";
            if (operation == "add")
                query = "SELECT * FROM groups WHERE gr_name = @cName or id =@id";
            else if (operation == "edit")
                query = "SELECT * FROM groups WHERE gr_name = @cName and id <>@id";
            SqlCommand command = new SqlCommand(query, mydb.getConnection);//
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value =name;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                // neu phat hien 1 dong ton tai trong ten
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable getGRbyID(int hrID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM groups WHERE id = @id ", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = hrID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public DataTable getAllGR()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM groups", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
