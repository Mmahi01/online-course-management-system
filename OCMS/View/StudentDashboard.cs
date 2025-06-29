using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCMS.Model;

namespace OCMS.View
{
    public partial class StudentDashboard : Form
    {
        private int userId;
        private string userRole;
        public StudentDashboard(int userId, string userRole)
        {
            InitializeComponent();
            panel3.Visible = false;
            this.userId = userId;
            LoadEnrollments();
            button2.Enabled = false;
            this.userRole = userRole;
        }

        private void LoadEnrollments()
        {
            EnrollmentModel model = new EnrollmentModel();
            DataTable dt = model.GetEnrollmentsByUserId(userId);
            dataGridView1.DataSource = dt;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnrollmentFrame enrollment = new EnrollmentFrame(userId, userRole);
            enrollment.UserId = userId;
            enrollment.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseContent courseContent = new CourseContent(userId, userRole);
            courseContent.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide(); ;
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(userId);
            profile.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCourses manageCourses = new ManageCourses(userId, userRole);
            manageCourses.Show();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
