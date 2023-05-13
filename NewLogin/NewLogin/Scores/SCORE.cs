using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewLogin.Scores
{
    internal class SCORE
    {
        MY_DB mydb=new MY_DB();
        public bool insertScore(string studentID, string courseID, float scoreValue, string description)
        {
            
            SqlCommand command =new SqlCommand("insert into scores (student_ID, course_ID, student_Score, description) values (@sID, @cID, @sVl, @Desc) ",mydb.getConnection);
            command.Parameters.Add("@sID",SqlDbType.VarChar).Value= studentID;
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = courseID;
            command.Parameters.Add("@sVl", SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@Desc", SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if((command.ExecuteNonQuery()==1))
            {
                return true;
            }
            else
                return false;
        }
        public bool studentScoreExist(string studentID, string courseID)
        {
            SqlCommand command = new SqlCommand("select * from scores where student_ID=@sID and course_ID=@cID", mydb.getConnection);
            command.Parameters.Add("@sID",SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = courseID;
            SqlDataAdapter adapter= new SqlDataAdapter(command);
            DataTable table = new DataTable(); 
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText = "select courses.label as Course_Name, avg(scores.student_Score) as AverageGrade from courses , scores where courses.id=" +
                "scores.course_ID group by courses.label";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteScore(string studentID, string courseID)
        {
            SqlCommand command = new SqlCommand("delete from scores where student_ID = @sID and course_ID=@cID", mydb.getConnection);
            command.Parameters.Add("sID",SqlDbType.VarChar).Value=studentID;
            command.Parameters.Add("cID", SqlDbType.VarChar).Value = courseID;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
                return true;
            else
                return false;
        }
        public DataTable fillCommand(SqlCommand command)
        {           
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllScore()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM scores", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentOfCourse(string CourID)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT std.id, std.fname, std.lname FROM students std INNER JOIN scores ON std.id = scores.student_ID INNER JOIN courses ON scores.course_ID = courses.id WHERE courses.id = @CourID");
            command.Parameters.Add("@CourID", SqlDbType.VarChar).Value = CourID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
