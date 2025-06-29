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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OCMS.View
{
    public partial class ManageUsers : Form
    {
        private int userId;
        private string userRole;
        UserController controller = new UserController();

        public ManageUsers(int userId,string userRole)
        {
            InitializeComponent();
            LoadUsersToGrid();
            updatebutton.Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UseridtextBox.Enabled = false;
            rolecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            button2.Enabled = true;
            
            this.userId = userId;
            this.userRole = userRole;


        }
        private void LoadUsersToGrid()
        {
            dataGridView1.DataSource = controller.GetAllUsers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int selectedRowIndex = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex; 
            }
        }


        private void updatebutton_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (int.TryParse(UseridtextBox.Text, out int userId))
            {
                User user = new User
                {
                    UserId = userId,
                    Username = usernametextBox.Text,
                    Email = emailtextBox.Text,
                    Password = passwordtextBox.Text,
                    Role = rolecomboBox.SelectedItem?.ToString()
                };

                controller.UpdateUser(user);
                MessageBox.Show("User updated successfully.");
                LoadUsersToGrid();
                ClearFormFields();
            }
            else
            {
                MessageBox.Show("Invalid User ID");
            }
        }


        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];
                if (int.TryParse(row.Cells[0].Value?.ToString(), out int userId))
                {
                    User user = new User { UserId = userId };
                    controller.DeleteUser(user);
                    MessageBox.Show("User deleted successfully.");
                    LoadUsersToGrid();
                    ClearFormFields();

                    
                    selectedRowIndex = -1;
                }
                else
                {
                    MessageBox.Show("Invalid User ID in selected row.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }



        private void searchbutton_Click(object sender, EventArgs e)
        {
            string searchText = searchBox1.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                }
            }
        }



        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UseridtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rolecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (selectedRowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRowIndex];

                UseridtextBox.Text = row.Cells[0].Value?.ToString();
                usernametextBox.Text = row.Cells[1].Value?.ToString();
                emailtextBox.Text = row.Cells[3].Value?.ToString();
                passwordtextBox.Text = row.Cells[2].Value?.ToString();
                rolecomboBox.SelectedItem = row.Cells[4].Value?.ToString();

                updatebutton.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }


        private void ClearFormFields()
        {
            UseridtextBox.Clear();
            usernametextBox.Clear();
            emailtextBox.Clear();
            passwordtextBox.Clear();
            rolecomboBox.SelectedIndex = -1;
            updatebutton.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernametextBox.Text) ||
        string.IsNullOrWhiteSpace(emailtextBox.Text) ||
        string.IsNullOrWhiteSpace(passwordtextBox.Text) ||
        rolecomboBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User user = new User
            {
                Username = usernametextBox.Text,
                Email = emailtextBox.Text,
                Password = passwordtextBox.Text,
                Role = rolecomboBox.SelectedItem.ToString()
            };

            controller.AddUser(user); 
            MessageBox.Show("User added successfully.");
            LoadUsersToGrid();
            ClearFormFields();
        }

        private void searchBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            UseridtextBox.Clear();
            usernametextBox.Clear();
            emailtextBox.Clear();
            passwordtextBox.Clear();
            rolecomboBox.SelectedIndex = -1;
            searchBox1.Clear();
        }

        private void gobackbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard(userId, userRole);
            adminDashboard.Show();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
