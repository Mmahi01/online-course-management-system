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
    public partial class Profile : Form
    {
        private int userId;
        private string userRole;
        public Profile(int userId)
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
            useriductextBox4.Enabled = false;
            useridtextBox1.Enabled = false;
            emailtextBox3.Enabled = false;
            rolecomboBox1.Enabled = false;
            usernametextBox2.Enabled = false;
            this.userId = userId;
            LoadUserInfo();
            savebutton.Enabled = false;
        }

        private void LoadUserInfo()
        {
            UserController controller = new UserController();
            User user = controller.GetUserById(userId);

            if (user != null)
            {
                userRole = user.Role;
                useridtextBox1.Text = user.UserId.ToString();
                usernametextBox2.Text = user.Username;
                emailtextBox3.Text = user.Email;
                rolecomboBox1.Text = user.Role;
                useriductextBox4.Text = user.Username;
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usernametextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void useridtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rolecomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editbutton2_Click(object sender, EventArgs e)
        {
            usernametextBox2.Enabled = true;
            emailtextBox3.Enabled = true;
            savebutton.Enabled = true;
            editbutton2.Enabled = false;
        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (userRole == "Admin")
            {
                AdminDashboard admin = new AdminDashboard(userId, userRole);
                admin.Show();
            }
            else if (userRole == "Student")
            {
                StudentDashboard student = new StudentDashboard(userId, userRole);
                student.Show();
            }
            else if (userRole == "Instructor")
            {
                InstructorDashboard instructor = new InstructorDashboard(userId, userRole);
                instructor.Show();
            }
            else
            {
                MessageBox.Show("Unknown role. Can't redirect.");
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void useriductextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void changepasswordbutton3_Click(object sender, EventArgs e)
        {
            Fpassword changePass = new Fpassword(userId.ToString(), true);
            changePass.ShowDialog(); 
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();

            User updatedUser = new User
            {
                UserId = this.userId,
                Username = usernametextBox2.Text,
                Email = emailtextBox3.Text,
                Role = rolecomboBox1.Text,
                Password = "unchanged"
            };

            controller.UpdateUser(updatedUser);

            MessageBox.Show("Profile updated.");
            LoadUserInfo();
            usernametextBox2.Enabled = false;
            emailtextBox3.Enabled = false;
            rolecomboBox1.Enabled = false;
            editbutton2.Enabled = true;
            savebutton.Enabled = false;
        }
    }
}
