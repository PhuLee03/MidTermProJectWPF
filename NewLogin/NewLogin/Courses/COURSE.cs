using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Course_Scores
{
    internal class COURSE
    {
        MY_DB mydb = new MY_DB();
        public bool insertCourse(string Id, string courseName, int hoursNumber, string description)
        {

            SqlCommand command = new SqlCommand("INSERT INTO courses (id, label, period, description)" +
                " VALUES (@id, @name, @hrs, @descr)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

            try
            {
                mydb.openConnection();
                if ((command.ExecuteNonQuery() > 0))
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
            catch
            {
                MessageBox.Show("This ID Already Exit");
            }
            return false;
        }
        public bool updateCourse(string Id, string courseName, int hoursNumber, string description)
        {

            SqlCommand command = new SqlCommand("UPDATE courses SET label = @name, period =@hrs, description = @descr WHERE Id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

            try
            {
                mydb.openConnection();
                if ((command.ExecuteNonQuery() > 0))
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
            catch (Exception ex)
            {
                MessageBox.Show("No Successful implementation" + ex);
            }
            return false;
        }
        public bool deleteCourse(string Id)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM courses WHERE Id = @id", mydb.getConnection);
                //command.Parameters.AddWithValue("@Id", Finding_Box_Type.Text);
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = Id;
                //SqlCommand command = new SqlCommand("select * from students where id=@Id");
                //command.Parameters.AddWithValue("@Id", Finding_Box_Type.Text);
                mydb.openConnection();
                if ((command.ExecuteNonQuery() > 0))
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
            catch (Exception ex)
            {
                MessageBox.Show("No Successful implementation" + ex);
            }
            return false;
        }
        // tim course trung tam
        public bool checkCourseName(string courseName, string courseId)// string courseId
        {
            SqlCommand command = new SqlCommand("SELECT * FROM courses WHERE label = @cName AND id <>@id", mydb.getConnection);//
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = courseId;
            command.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                // neu phat hien 1 dong ton tai trong ten
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool checkID(string courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM courses WHERE id=@ID", mydb.getConnection);
            command.Parameters.Add("@ID", SqlDbType.VarChar).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                // neu phat hien 1 dong ton tai trong ten
                return false;
            }
            else
            {
                return true;
            }
        }
        public DataTable getAllCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM courses", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCoursebyID(string CourseId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM courses WHERE id = @id ", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.VarChar).Value = CourseId;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalCourses()
        {
            return execCount("SELECT COUNT(*) FROM courses");
        }
        public DataTable getCourses(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
