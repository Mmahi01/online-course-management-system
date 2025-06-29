using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCMS.Model;

namespace OCMS.Controller
{
    public class EnrollmentController
    {
        EnrollmentModel model = new EnrollmentModel();

        public List<Enrollment> GetCourses()
        {
            return model.GetAvailableCourses();
        }

        public void EnrollStudentInCourse(int studentId, int courseId)
        {
            model.EnrollStudent(studentId, courseId);
        }

        public int GetStudentCourseCount(int studentId)
        {
            return model.GetStudentCourseCount(studentId);
        }

        public int GetTotalEnrollments()
        {
            return model.GetTotalEnrollments();
        }

        public DataTable GetEnrolledStudentsByInstructor(int instructorId)
        {
            return model.GetEnrolledStudentsByInstructor(instructorId);
        }







    }
}
