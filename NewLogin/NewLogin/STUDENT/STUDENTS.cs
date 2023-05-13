using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLogin
{
    internal class STUDENTS
    {
        MY_DB mydb=new MY_DB();
        public bool insertStudent(string Id,string fname,string lname, DateTime bdate, string gender, string phone, string address, string major, string schoolYear, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO students(id, fname, lname, bdate, gender, phone, address, major, schoolYear, picture)"
                + "VALUES(@id, @fn, @ln, @bd, @gd, @ph, @ad, @mj, @schy, @pic)", mydb.getConnection);
            command.Parameters.Add("@id",SqlDbType.VarChar).Value=Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ad", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@mj", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@schy", SqlDbType.VarChar).Value = schoolYear;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            mydb.openConnection();
            if((command.ExecuteNonQuery()==1))
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
        public bool updateStudent(string Id, string fname, string lname, DateTime bdate, string gender, string phone, string address, string major, string schoolYear, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE students SET fname=@fn, lname=@ln, bdate=@bd, gender=@gd, phone=@ph, address=@ad, major=@mj, schoolYear=@schy, picture=@pic WHERE id=@ID", mydb.getConnection);
           // SqlCommand command = new SqlCommand("UPDATE students(id, fname, lname, bdate, gender, phone, address, major, schoolYear, picture)"
           //     + "VALUES(@id, @fn, @ln, @bd, @gd, @ph, @ad, @mj, @schy, @pic)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bd", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@ad", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@mj", SqlDbType.VarChar).Value = major;
            command.Parameters.Add("@schy", SqlDbType.VarChar).Value = schoolYear;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
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
        //public bool deleteStudent()
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter= new SqlDataAdapter(command);
            DataTable table= new DataTable();
            adapter.Fill(table);
            return table;            
        }
        public DataTable getAllStudent()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM students", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        string exeCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);         
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM students");
        }
        public string totalMale()
        {
            return exeCount("SELECT COUNT(*) FROM students WHERE gender = 'Male'");
        }
        public string totalFemale() 
        {
            return exeCount("SELECT COUNT(*) FROM students WHERE gender = 'Female'");
        }
        public string totalOther()
        {
            return exeCount("SELECT COUNT(*) FROM students WHERE gender = 'Other'");
        }
        public bool deleteStudent(string id)
        {
            SqlCommand command = new SqlCommand("Delete from students where id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value=id;
            mydb.openConnection();
            if(command.ExecuteNonQuery()==1)
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
