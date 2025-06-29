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
using OCMS.Model;

namespace OCMS.View
{
    public partial class EnrolledStudent : Form
    {
        private int instructorId;
        private string userRole;
        public EnrolledStudent(int instructorId, string userRole)
        {
            InitializeComponent();
            this.instructorId = instructorId;
            this.userRole = userRole;
        }

        private void EnrolledStudent_Load(object sender, EventArgs e)
        {
            EnrollmentController controller = new EnrollmentController();
            dataGridView1.DataSource = controller.GetEnrolledStudentsByInstructor(this.instructorId);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorDashboard instructorDashboard = new InstructorDashboard(instructorId,userRole);
            instructorDashboard.Show();
        }
    }
}
