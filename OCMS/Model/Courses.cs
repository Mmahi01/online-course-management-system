using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OCMS.Model
{
    public class Courses
    {
        SqlDBAccess sdba = new SqlDBAccess();

        public void AddCourse(Course course)
        {
            SqlCommand cmd = sdba.GetQuery("INSERT INTO Courses (Title, Description, InstructorID, CourseTime, CapacityLimit) VALUES (@title, @desc, @instructorId, @time, @limit)");
            cmd.Parameters.AddWithValue("@title", course.Title);
            cmd.Parameters.AddWithValue("@desc", course.Description);
            cmd.Parameters.AddWithValue("@instructorId", course.IntructorId);
            cmd.Parameters.AddWithValue("@time", course.Time);
            cmd.Parameters.AddWithValue("@limit", course.CapacityLimit);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        public List<Course> GetAllCourses()
        {
            SqlCommand cmd = sdba.GetQuery("SELECT * FROM Courses");
            return GetData(cmd);
        }

        public int GetTotalCourses()
        {
            SqlCommand cmd = sdba.GetQuery("SELECT COUNT(*) FROM Courses");
            cmd.Connection.Open();
            int count = (int)cmd.ExecuteScalar();
            cmd.Connection.Close();
            return count;
        }

        private List<Course> GetData(SqlCommand cmd)
        {
            List<Course> list = new List<Course>();
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Course c = new Course
                {
                    CourseId = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.GetString(2),
                    IntructorId = reader.GetInt32(3),
                    Time = reader.GetTimeSpan(4),
                    CapacityLimit = reader.GetInt32(5)
                };
                list.Add(c);
            }

            reader.Close();
            cmd.Connection.Close();
            return list;
        }

        public List<Course> GetCoursesByInstructorId(int instructorId)
        {
            List<Course> courseList = new List<Course>();

            SqlCommand cmd = sdba.GetQuery("SELECT * FROM Courses WHERE InstructorID = @InstructorID");
            cmd.Parameters.AddWithValue("@InstructorID", instructorId);

            
            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course course = new Course
                {
                    CourseId = Convert.ToInt32(reader["CourseId"]),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Time = TimeSpan.Parse(reader["CourseTime"].ToString()),
                    CapacityLimit = Convert.ToInt32(reader["CapacityLimit"]),
                    IntructorId = Convert.ToInt32(reader["InstructorID"])
                };
                courseList.Add(course);
            }

            reader.Close();
            cmd.Connection.Close(); 

            return courseList;
        }

        public void UpdateCourse(Course course)
        {
            SqlCommand cmd = sdba.GetQuery("UPDATE Courses SET Title = @title, Description = @desc, InstructorID = @instructorId, CourseTime = @time, CapacityLimit = @limit WHERE CourseId = @courseId");
            cmd.Parameters.AddWithValue("@title", course.Title);
            cmd.Parameters.AddWithValue("@desc", course.Description);
            cmd.Parameters.AddWithValue("@instructorId", course.IntructorId);
            cmd.Parameters.AddWithValue("@time", course.Time);
            cmd.Parameters.AddWithValue("@limit", course.CapacityLimit);
            cmd.Parameters.AddWithValue("@courseId", course.CourseId);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }


        public void DeleteCourse(int courseId)
        {
            SqlCommand cmd = sdba.GetQuery("DELETE FROM Courses WHERE CourseId = @courseId");
            cmd.Parameters.AddWithValue("@courseId", courseId);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }



    








    }
}
