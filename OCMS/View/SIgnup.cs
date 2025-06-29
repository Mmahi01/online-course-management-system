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
    public partial class SIgnup : Form
    {
        public SIgnup()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 2;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;

            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            string role = comboBox1.SelectedItem?.ToString(); 

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            User user = new User
            {
                Username = username,
                Email = email,
                Password = password,
                Role = role
            };

            OCMS.Model.Signup signup = new OCMS.Model.Signup();
            string userId = signup.AddUser(user);

       
            if (!string.IsNullOrEmpty(userId))
            {
                MessageBox.Show($"Signup successful!\nYour User ID: {userId}");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedIndex = 2;

            }
            else
            {
                MessageBox.Show("Signup failed.");
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
