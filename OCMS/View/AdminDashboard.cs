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

    public partial class AdminDashboard : Form
    {
        private int userId;
        private string userRole;
        UserController userController = new UserController();
        CourseController courseController = new CourseController(); 
        EnrollmentController enrollmentController = new EnrollmentController(); 
        

        public AdminDashboard(int userId,string userrole)
        {
            InitializeComponent();
            panel3.Visible = false;
            PopulateDashboardData();
            this.Load += AdminDashboard_Load;
            userBox1.Enabled = false;
            courseBox2.Enabled = false;
            studentBox3.Enabled = false;
            instructorBox4.Enabled = false;
            enrolementBox5.Enabled = false;
            this.userId = userId;
            this.userRole = userrole;
            button2.Enabled = false;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            PopulateDashboardData();
        }

        private void PopulateDashboardData()
        {
            try
            {
                userBox1.Text = userController.GetTotalUsers().ToString();
                studentBox3.Text = userController.GetTotalStudents().ToString();
                instructorBox4.Text = userController.GetTotalInstructors().ToString();
                courseBox2.Text = courseController.GetTotalCourses().ToString(); 
                enrolementBox5.Text = enrollmentController.GetTotalEnrollments().ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void courseBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructorBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void enrolementBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageUsers manageUsers = new ManageUsers(userId,userRole);
            manageUsers.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile(userId);
            profile.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();;
            Login login = new Login();
            login.Show();
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCourses manageCourses = new ManageCourses(userId,userRole);
            manageCourses.Show();
        }
    }
}
