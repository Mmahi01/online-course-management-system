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
    public partial class ManageContent : Form
    {
        private int userId;
        private string userRole;
        ContentController contentController = new ContentController();
        CourseController courseController = new CourseController();
        private List<Content> currentCourseContents = new List<Content>();
        public ManageContent(int userId, string userRole)
        {
            InitializeComponent();
            CourseController controller = new CourseController();
            var courses = controller.GetCoursesByInstructorId(userId);
            this.userId = userId;
            dataGridView1.DataSource = courses;
            groupbox2.Visible = false;
            this.userRole = userRole;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editbutton1_Click(object sender, EventArgs e)
        {
            groupbox2.Visible=true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int courseId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CourseID"].Value);
                courseidtextBox1.Text = courseId.ToString(); 
            }
            else
            {
                MessageBox.Show("Please select a course row first.");
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void courseidtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void titletextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contenttextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void savebutton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(courseidtextBox1.Text) ||
                string.IsNullOrWhiteSpace(titletextBox2.Text) ||
                string.IsNullOrWhiteSpace(contenttextBox3.Text))
            {
                MessageBox.Show("Please fill in all fields before saving.");
                return;
            }

            try
            {
                Content content = new Content
                {
                    CourseId = Convert.ToInt32(courseidtextBox1.Text),
                    ContentTitle = titletextBox2.Text,
                    ContentText = contenttextBox3.Text, 
                    UploadDate = dateTimePicker1.Value
                };

                contentController.AddContent(content);
                MessageBox.Show("Content saved successfully!");

                
                selectbutton1.PerformClick(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving content: " + ex.Message);
            }

            
            courseidtextBox1.Clear();
            titletextBox2.Clear();
            contenttextBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;


            groupbox2.Visible = false;
        

    }

        private void groupbox2_Enter(object sender, EventArgs e)
        {

        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InstructorDashboard instructorDashboard = new InstructorDashboard(userId,userRole);
            instructorDashboard.Show();
        }
    }
}
