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
    public partial class ManageCourses : Form
    {
        
        private int selectedRowIndex = -1;
        private CourseController controller = new CourseController();
        private UserController userController = new UserController();
        private int userId;
        private string userRole;



        public ManageCourses(int userId, string userRole)
        {
            InitializeComponent();
            this.Load += ManageCourses_Load;
            CourseIDtextBox2.ReadOnly = true;
            updatebutton.Visible = false;
            this.userId = userId;
            this.userRole = userRole;
            ApplyRoleBasedAccess();
        }
        private void ApplyRoleBasedAccess()
        {
            if (userRole == "Instructor")
            {
                deletebutton.Visible = false;
            }
            else if (userRole == "Student")
            {
                
                deletebutton.Visible = false;
                addbutton2.Visible = false;
                updatebutton.Visible = false;
                editbutton.Visible = false;
                CourseIDtextBox2.Visible = false;
                titletextBox.Visible = false;
                descriptiontextBox.Visible = false;
                dateTimePicker1.Visible = false;
                instructoridtextBox.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                UserID.Visible = false;
                label6.Visible = false;


                

            }
            
        }


        private void ManageCourses_Load(object sender, EventArgs e)
        {
            LoadCoursesToGrid();
        }

        private void LoadCoursesToGrid()
        {
            List<Course> courses = controller.GetAllCourses();
            DataTable dt = new DataTable();
            dt.Columns.Add("Course ID");
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            dt.Columns.Add("Instructor ID");
            dt.Columns.Add("Time");
            dt.Columns.Add("Capacity");

            foreach (Course c in courses)
            {
                dt.Rows.Add(c.CourseId, c.Title, c.Description, c.IntructorId, c.Time, c.CapacityLimit);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void titletextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptiontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void instructoridtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(instructoridtextBox.Text, out int instructorId))
            {
                MessageBox.Show("Instructor ID must be a number.");
                return;
            }

            if (!userController.IsValidInstructor(instructorId))
            {
                MessageBox.Show("Please enter a valid Instructor ID (Role must be 'Instructor').");
                return;
            }

            Course course = new Course
            {
                CourseId = int.Parse(CourseIDtextBox2.Text),
                Title = titletextBox.Text,
                Description = descriptiontextBox.Text,
                IntructorId = instructorId,
                Time = dateTimePicker1.Value.TimeOfDay,
                CapacityLimit = int.Parse(textBox1.Text)
            };

            controller.UpdateCourse(course);
            MessageBox.Show("Course updated successfully.");
            LoadCoursesToGrid();
            ClearFormFields();
        }



        private void editbutton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                CourseIDtextBox2.Text = row.Cells[0].Value.ToString();
                titletextBox.Text = row.Cells[1].Value.ToString();
                descriptiontextBox.Text = row.Cells[2].Value.ToString();
                instructoridtextBox.Text = row.Cells[3].Value.ToString();
                
                textBox1.Text = row.Cells[5].Value.ToString();
                if (TimeSpan.TryParse(row.Cells[4].Value.ToString(), out TimeSpan parsedTime))
                {
                    dateTimePicker1.Value = DateTime.Today.Add(parsedTime);  
                }

                updatebutton.Visible = true;
                addbutton2.Enabled = false;
                textBox1.Enabled = false;
                CourseIDtextBox2.Enabled = false;

            }
        }


        private void addbutton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titletextBox.Text) ||
                string.IsNullOrWhiteSpace(descriptiontextBox.Text) ||
                string.IsNullOrWhiteSpace(instructoridtextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(instructoridtextBox.Text, out int instructorId))
            {
                MessageBox.Show("Instructor ID must be a number.");
                return;
            }

            if (!userController.IsValidInstructor(instructorId))
            {
                MessageBox.Show("Please enter a valid Instructor ID (Role must be 'Instructor').");
                return;
            }

            Course course = new Course
            {
                Title = titletextBox.Text,
                Description = descriptiontextBox.Text,
                IntructorId = instructorId,
                Time = dateTimePicker1.Value.TimeOfDay,
                CapacityLimit = 40
                
            };

            controller.AddCourse(course);
            MessageBox.Show("Course added successfully.");
            LoadCoursesToGrid();
            ClearFormFields();
        }




        private void ClearFormFields()
        {
            CourseIDtextBox2.Clear();
            titletextBox.Clear();
            descriptiontextBox.Clear();
            instructoridtextBox.Clear();
            
            textBox1.Text = "40"; 
            searchBox1.Clear();
            updatebutton.Visible = false;
            addbutton2.Enabled = true;
            textBox1.Enabled = false; 
            dateTimePicker1.Value = DateTime.Now.Date; 

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectedRowIndex = e.RowIndex;
        }


        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                int courseId = int.Parse(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString());
                controller.DeleteCourse(courseId);  
                MessageBox.Show("Course deleted successfully.");
                LoadCoursesToGrid();
                ClearFormFields();
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchText = searchBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value?.ToString().ToLower().Contains(searchText) == true)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseIDtextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
           
            if (userRole == "Admin")
            {
                this.Hide();
                AdminDashboard adminDashboard = new AdminDashboard(userId, userRole);
                adminDashboard.Show();
            }
            else if (userRole == "Instructor")
            {
                this.Hide();
                InstructorDashboard instructorDashboard = new InstructorDashboard(userId, userRole);
                instructorDashboard.Show();
            }
            else if (userRole == "Student")
            {
                this.Hide();
                StudentDashboard studentDashboard = new StudentDashboard(userId, userRole);
                studentDashboard.Show();
            }
        }

        private void ManageCourses_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UserID_Click(object sender, EventArgs e)
        {

        }
    }
}
