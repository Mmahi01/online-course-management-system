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
    public partial class Fpassword : Form
    {

        private string _userId = null;
        private bool _bypassVerification = false;

        public Fpassword()
        {
            InitializeComponent();
            textBox3.Visible = false;
            button2.Visible = false;
            label3.Visible = false;
        }

        public Fpassword(string userId, bool bypassVerification)
        {
            InitializeComponent();
            _userId = userId;
            _bypassVerification = bypassVerification;
            SetupInitialState();
        }

        private void SetupInitialState()
        {
            if (_bypassVerification)
            {
                
                textBox1.Visible = false; 
                textBox2.Visible = false; 
                label1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;

                
                textBox3.Visible = true;
                button2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                
                textBox3.Visible = false;
                button2.Visible = false;
                label3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userId = textBox1.Text;
            string password = textBox2.Text;

            Signup signup = new Signup();

            bool isValid = signup.VerifyUser(userId, password); 

            if (isValid)
            {
                MessageBox.Show("User verified. Please enter your new password.");
                textBox3.Visible = true;
                button2.Visible = true;
                label3.Visible = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid UserID or Password.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userId = _bypassVerification ? _userId : textBox1.Text;
            string newPassword = textBox3.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            Signup signup = new Signup();
            bool updated = signup.UpdatePassword(userId, newPassword);

            if (updated)
            {
                MessageBox.Show("Password updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Password update failed.");
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
