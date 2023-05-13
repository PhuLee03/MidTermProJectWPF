using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewLogin.SEMESTER
{
    public class SEMESTER
    {
        MY_DB mydb = new MY_DB();
        public bool insertSemester(string studentID, string courseID, int semesters)
        {

            SqlCommand command = new SqlCommand("insert into semesters (student_ID, course_ID, semester) values (@sID, @cID, @sem) ", mydb.getConnection);
            command.Parameters.Add("@sID", SqlDbType.VarChar).Value = studentID;
            command.Parameters.Add("@cID", SqlDbType.VarChar).Value = courseID;
            command.Parameters.Add("@sem", SqlDbType.Int).Value = semesters;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
                return false;
        }
    }
}
