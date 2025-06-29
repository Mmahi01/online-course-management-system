namespace OCMS.View
{
    partial class ManageUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UseridtextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.editbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.gobackbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 375);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UseridtextBox
            // 
            this.UseridtextBox.Location = new System.Drawing.Point(100, 108);
            this.UseridtextBox.Name = "UseridtextBox";
            this.UseridtextBox.Size = new System.Drawing.Size(176, 22);
            this.UseridtextBox.TabIndex = 1;
            this.UseridtextBox.TextChanged += new System.EventHandler(this.UseridtextBox_TextChanged);
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(254, 187);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(176, 22);
            this.emailtextBox.TabIndex = 2;
            this.emailtextBox.TextChanged += new System.EventHandler(this.emailtextBox_TextChanged);
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(409, 109);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(176, 22);
            this.usernametextBox.TabIndex = 3;
            this.usernametextBox.TextChanged += new System.EventHandler(this.usernametextBox_TextChanged);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(787, 108);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(176, 22);
            this.passwordtextBox.TabIndex = 4;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Items.AddRange(new object[] {
            "Admin",
            "Instructor",
            "Student"});
            this.rolecomboBox.Location = new System.Drawing.Point(650, 187);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(176, 24);
            this.rolecomboBox.TabIndex = 5;
            this.rolecomboBox.SelectedIndexChanged += new System.EventHandler(this.rolecomboBox_SelectedIndexChanged);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(226, 263);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 6;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(662, 263);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(718, 333);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 8;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.ForeColor = System.Drawing.Color.White;
            this.UserID.Location = new System.Drawing.Point(26, 108);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(68, 22);
            this.UserID.TabIndex = 9;
            this.UserID.Text = "UserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(696, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(598, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role";
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(301, 333);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(393, 22);
            this.searchBox1.TabIndex = 14;
            this.searchBox1.TextChanged += new System.EventHandler(this.searchBox1_TextChanged);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(362, 263);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 15;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(516, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(798, 263);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 17;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gobackbutton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 71);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(360, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Manage Users";
            // 
            // gobackbutton1
            // 
            this.gobackbutton1.BackColor = System.Drawing.Color.Transparent;
            this.gobackbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gobackbutton1.BackgroundImage")));
            this.gobackbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gobackbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gobackbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gobackbutton1.Location = new System.Drawing.Point(10, 10);
            this.gobackbutton1.Name = "gobackbutton1";
            this.gobackbutton1.Size = new System.Drawing.Size(50, 50);
            this.gobackbutton1.TabIndex = 3;
            this.gobackbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.gobackbutton1.UseVisualStyleBackColor = false;
            this.gobackbutton1.Click += new System.EventHandler(this.gobackbutton1_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1070, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.searchBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.rolecomboBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.UseridtextBox);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox UseridtextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBox1;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button gobackbutton1;
    }
}