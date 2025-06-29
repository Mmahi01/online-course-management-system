using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCMS.View;
using OCMS.Controller;
using OCMS.Model;

namespace OCMS
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(UserIDbox.Text);
                string password = passwordbox.Text;

                UserController userController = new UserController();
                User user = userController.SearchUser(userId, password);

                if (user != null)
                {
                    string role = user.Role;
                    if (user.UserId == userId && user.Password.Equals(password) && user.Role == "Admin")
                    {
                        MessageBox.Show("Welcome Admin");
                        this.Hide();
                        AdminDashboard adminHome = new AdminDashboard(userId, role);
                        adminHome.Show();
                        
                    }
                    else if (user.UserId == userId && user.Password.Equals(password) && user.Role == "Instructor")
                    {
                        MessageBox.Show("Welcome Instructor");
                        this.Hide();
                        InstructorDashboard instructorDashboard = new InstructorDashboard(userId, role);
                        instructorDashboard.Show();
                    }
                    else if (user.UserId == userId && user.Password.Equals(password) && user.Role == "Student")
                    {
                        MessageBox.Show("Welcome Student");
                        this.Hide();
                        StudentDashboard sdashboard = new StudentDashboard(userId, role);
                        sdashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric User ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordbox.UseSystemPasswordChar = false;

            }
            else
            {
                passwordbox.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SIgnup signupform = new SIgnup();
            signupform.Show();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Fpassword fpassword = new Fpassword();
            fpassword.Show();
            this.Hide();
        }

        private void Usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
