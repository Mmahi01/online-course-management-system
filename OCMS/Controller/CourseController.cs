using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCMS.Model;


namespace OCMS.Controller
{
    public class CourseController
    {
        Courses courseDB = new Courses();

        public void AddCourse(Course course)
        {
            courseDB.AddCourse(course);
        }

        public List<Course> GetAllCourses()
        {
            return courseDB.GetAllCourses();
        }

        public int GetTotalCourses()
        {
            return courseDB.GetTotalCourses();
        }

        public List<Course> GetCoursesByInstructorId(int instructorId)
        {
            return courseDB.GetCoursesByInstructorId(instructorId);
        }

        public void UpdateCourse(Course course)
        {
            courseDB.UpdateCourse(course);
        }

        public void DeleteCourse(int courseId)
        {
            courseDB.DeleteCourse(courseId);
        }
    }
}
