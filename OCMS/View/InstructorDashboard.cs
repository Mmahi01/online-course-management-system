using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCMS.Controller;

namespace OCMS.View
{
    public partial class InstructorDashboard : Form
    {
        private int userId;
        private string userRole;
        public InstructorDashboard(int userId, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            CourseController controller = new CourseController();
            var courses = controller.GetCoursesByInstructorId(userId);
            dataGridView1.DataSource = courses;
            panel3.Visible = false;
            button2.Enabled = false;
            this.userRole = userRole;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void enrolledstudentbutton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrolledStudent enrolledStudent = new EnrolledStudent(userId, userRole);
            enrolledStudent.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(userId);
            profile.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); ;
            Login login = new Login();
            login.Show();
        }

        private void coursecontentbutton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageContent manageContent = new ManageContent(userId, userRole);
            manageContent.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCourses manageCourses = new ManageCourses(userId, userRole);
            manageCourses.Show();
        }
    }
}
