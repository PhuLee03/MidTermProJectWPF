using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Linq;

namespace NewLogin.Contacts
{
    internal class CONTACT
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(int id, string fname, string lname, string group_id, string phone, string emai, string address, MemoryStream picture, int userid)
        {
            SqlCommand command = new SqlCommand("INSERT INTO contacts(id, fname, lname, group_id, phone, email, address,  picture, userid)"
                + "VALUES(@id, @fn, @ln, @gid, @ph, @em, @ad, @pic, @uid)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.VarChar).Value = group_id;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value=emai;
            command.Parameters.Add("@ad", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("uid", SqlDbType.Int).Value = userid;
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
        public bool updateContact(int id, string fname, string lname, string group_id, string phone, string emai, string address, MemoryStream picture, int userid)
        {
            SqlCommand command = new SqlCommand("update contacts set fname=@fn, lname=@ln, group_id=@gid, phone=@ph, email=@em, address=@ad,  picture=@pic, userid=@uid where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@gid", SqlDbType.VarChar).Value = group_id;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@em", SqlDbType.VarChar).Value = emai;
            command.Parameters.Add("@ad", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("uid", SqlDbType.Int).Value = userid;
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
        public bool deleteContact(int ID)
        {
            SqlCommand command = new SqlCommand("delete from contacts where id=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value=ID;
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
        public bool checkID(int iD)
        {
            SqlCommand command = new SqlCommand("select * from contacts where id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = iD;
            //command.Parameters.Add("@cName", SqlDbType.VarChar).Value = name;
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
        public DataTable getAllContact()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contacts", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getContactbyID(int CourseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM contacts WHERE id = @id ", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = CourseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
