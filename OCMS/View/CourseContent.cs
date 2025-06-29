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
using OCMS.Controller;

namespace OCMS.View
{
    public partial class CourseContent: Form
    {
        private string userRole;
        ContentController contentController = new ContentController();
        
        private int userId;
        private List<Content> currentCourseContents = new List<Content>();

        public CourseContent(int userId, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            LoadEnrollments();
            this.userRole = userRole;


            
        }

        private void LoadEnrollments()
        {
            EnrollmentModel model = new EnrollmentModel();
            DataTable dt = model.GetEnrollmentsByUserId1(userId);
            dataGridView1.DataSource = dt;
        }






        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void selectbutton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);

                listBox1.Items.Clear();

                currentCourseContents = contentController.GetContentByCourseId(courseId); 

                foreach (var content in currentCourseContents)
                {
                    listBox1.Items.Add(content.ContentTitle);
                }
            }
            else
            {
                MessageBox.Show("Please select a course row first.");
            }
        }


        private void openbutton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                
                Content selectedContent = currentCourseContents[listBox1.SelectedIndex];

                
                string url = selectedContent.ContentText;

                try
                {
                    
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to open the link. " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a content item from the list.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
            if (userRole == "Instructor")
            {
                this.Hide();
                InstructorDashboard instructorDashboard = new InstructorDashboard(userId, userRole);
            }
            else
            {
                this.Hide();
                StudentDashboard studentDashboard = new StudentDashboard(userId, userRole);
                studentDashboard.Show();
            }
                
        }
    }
}
