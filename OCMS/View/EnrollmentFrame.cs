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
    public partial class EnrollmentFrame : Form
    {
        private string userRole;
        public int UserId { get; set; }
        private EnrollmentController controller = new EnrollmentController();
        private int currentStudentId = 1;
        public EnrollmentFrame(int studentId, string userRole)
        {
            InitializeComponent();
            currentStudentId = studentId;
            Load += Enrollment_Load;
            this.userRole = userRole;
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn() { HeaderText = "Select", Width = 50 });
            dataGridView1.Columns.Add("Title", "Title");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("CourseTime", "Time");
            dataGridView1.Columns.Add("Capacity", "Available Seats");

            
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

            var courses = controller.GetCourses();

            foreach (var c in courses)
            {
                dataGridView1.Rows.Add(false, c.Title, c.Description, c.Coursetime, c.Capacity);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            List<int> selectedCourseIds = new List<int>();
            var allCourses = controller.GetCourses();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                bool selected = Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value);
                if (selected)
                {
                    selectedCourseIds.Add(allCourses[i].CourseId);
                }
            }

            int currentCount = controller.GetStudentCourseCount(currentStudentId);
            if (currentCount + selectedCourseIds.Count > 5)
            {
                MessageBox.Show("You can only take up to 5 courses.");
                return;
            }

            foreach (int cid in selectedCourseIds)
            {
                controller.EnrollStudentInCourse(currentStudentId, cid);
            }

            MessageBox.Show("Enrollment successful!");
            Enrollment_Load(sender, e); 
        }

        private void EnrollmentFrame_Load(object sender, EventArgs e)
        {

        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentDashboard studentDashboard = new StudentDashboard(UserId,userRole);
            studentDashboard.Show();
        }
    }
}
