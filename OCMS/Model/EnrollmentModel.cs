using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using OCMS.Model;
using OCMS.Controller;

namespace OCMS.Model
{
    public class EnrollmentModel
    {
        SqlDBAccess sdba = new SqlDBAccess();

        public List<Enrollment> GetAvailableCourses()
        {
            SqlCommand cmd = sdba.GetQuery("SELECT CourseID, Title, Description, CourseTime, CapacityLimit FROM Courses");
            List<Enrollment> list = new List<Enrollment>();
            cmd.Connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                Enrollment course = new Enrollment
                {
                    CourseId = sdr.GetInt32(0),
                    Title = sdr.GetString(1),
                    Description = sdr.GetString(2),
                    Coursetime = sdr.GetTimeSpan(3),
                    Capacity = sdr.GetInt32(4)
                };
                list.Add(course);
            }

            sdr.Close();
            cmd.Connection.Close();
            return list;
        }

        public void DecreaseCapacity(int courseId)
        {
            SqlCommand cmd = sdba.GetQuery("UPDATE Courses SET CapacityLimit = CapacityLimit - 1 WHERE CourseID = @id AND CapacityLimit > 0");
            cmd.Parameters.AddWithValue("@id", courseId);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public int GetStudentCourseCount(int studentId)
        {
            SqlCommand cmd = sdba.GetQuery("SELECT COUNT(*) FROM Enrollments WHERE UserID = @sid");
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return count;
        }

        public void EnrollStudent(int studentId, int courseId)
        {
            SqlCommand cmd = sdba.GetQuery("INSERT INTO Enrollments (UserID, CourseID, EnrollmentDate) VALUES (@sid, @cid, @date)");
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Parameters.AddWithValue("@cid", courseId);
            cmd.Parameters.AddWithValue("@date", DateTime.Now); 

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            DecreaseCapacity(courseId);
        }

        public int GetTotalEnrollments()
        {
            SqlCommand cmd = sdba.GetQuery("SELECT COUNT(*) FROM Enrollments");
            cmd.Connection.Open();
            int total = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return total;
        }


        public DataTable GetEnrollmentsByUserId(int userId)
        {
            SqlDBAccess sdba = new SqlDBAccess();
            SqlCommand cmd = sdba.GetQuery(@"
    SELECT c.Title, c.Description, c.CourseTime, e.EnrollmentDate
    FROM Enrollments e
    INNER JOIN Courses c ON e.CourseID = c.CourseID
    WHERE e.UserID = @uid
");
            cmd.Parameters.AddWithValue("@uid", userId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }


        public DataTable GetEnrollmentsByUserId1(int userId)
        {
            SqlDBAccess sdba = new SqlDBAccess();
            SqlCommand cmd = sdba.GetQuery(@"
        SELECT e.CourseID, c.Title, c.Description, c.CourseTime, e.EnrollmentDate
        FROM Enrollments e
        INNER JOIN Courses c ON e.CourseID = c.CourseID
        WHERE e.UserID = @uid
    ");
            cmd.Parameters.AddWithValue("@uid", userId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }






        public DataTable GetEnrolledStudentsByInstructor(int instructorId)
        {
            SqlCommand cmd = sdba.GetQuery(@"
        SELECT DISTINCT u.UserId, u.Username, u.Email, c.Title AS CourseTitle
        FROM [User] u
        INNER JOIN Enrollments e ON u.UserId = e.UserID
        INNER JOIN Courses c ON e.CourseID = c.CourseID
        WHERE c.InstructorID = @InstructorID
    ");
            cmd.Parameters.AddWithValue("@InstructorID", instructorId);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }








    }
}
