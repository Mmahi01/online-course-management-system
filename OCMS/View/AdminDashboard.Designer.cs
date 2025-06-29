namespace OCMS.View
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userBox1 = new System.Windows.Forms.TextBox();
            this.courseBox2 = new System.Windows.Forms.TextBox();
            this.studentBox3 = new System.Windows.Forms.TextBox();
            this.instructorBox4 = new System.Windows.Forms.TextBox();
            this.enrolementBox5 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 71);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "OCMS - Admin Dashboard";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 39);
            this.button1.TabIndex = 3;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 606);
            this.panel3.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.Location = new System.Drawing.Point(0, 550);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(272, 56);
            this.button7.TabIndex = 8;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 56);
            this.button5.TabIndex = 6;
            this.button5.Text = "Profile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "Manage Courses";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Manage Users";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Users";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Student";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(698, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Instructor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(731, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Course";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Enrolement";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // userBox1
            // 
            this.userBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBox1.Location = new System.Drawing.Point(485, 194);
            this.userBox1.Multiline = true;
            this.userBox1.Name = "userBox1";
            this.userBox1.Size = new System.Drawing.Size(100, 28);
            this.userBox1.TabIndex = 8;
            this.userBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userBox1.TextChanged += new System.EventHandler(this.userBox1_TextChanged);
            // 
            // courseBox2
            // 
            this.courseBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseBox2.Location = new System.Drawing.Point(883, 194);
            this.courseBox2.Multiline = true;
            this.courseBox2.Name = "courseBox2";
            this.courseBox2.Size = new System.Drawing.Size(100, 28);
            this.courseBox2.TabIndex = 9;
            this.courseBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.courseBox2.TextChanged += new System.EventHandler(this.courseBox2_TextChanged);
            // 
            // studentBox3
            // 
            this.studentBox3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBox3.Location = new System.Drawing.Point(485, 286);
            this.studentBox3.Multiline = true;
            this.studentBox3.Name = "studentBox3";
            this.studentBox3.Size = new System.Drawing.Size(100, 28);
            this.studentBox3.TabIndex = 10;
            this.studentBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.studentBox3.TextChanged += new System.EventHandler(this.studentBox3_TextChanged);
            // 
            // instructorBox4
            // 
            this.instructorBox4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorBox4.Location = new System.Drawing.Point(883, 286);
            this.instructorBox4.Multiline = true;
            this.instructorBox4.Name = "instructorBox4";
            this.instructorBox4.Size = new System.Drawing.Size(100, 28);
            this.instructorBox4.TabIndex = 11;
            this.instructorBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.instructorBox4.TextChanged += new System.EventHandler(this.instructorBox4_TextChanged);
            // 
            // enrolementBox5
            // 
            this.enrolementBox5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolementBox5.Location = new System.Drawing.Point(608, 439);
            this.enrolementBox5.Multiline = true;
            this.enrolementBox5.Name = "enrolementBox5";
            this.enrolementBox5.Size = new System.Drawing.Size(100, 28);
            this.enrolementBox5.TabIndex = 12;
            this.enrolementBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enrolementBox5.TextChanged += new System.EventHandler(this.enrolementBox5_TextChanged);
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 677);
            this.Controls.Add(this.enrolementBox5);
            this.Controls.Add(this.instructorBox4);
            this.Controls.Add(this.studentBox3);
            this.Controls.Add(this.courseBox2);
            this.Controls.Add(this.userBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userBox1;
        private System.Windows.Forms.TextBox courseBox2;
        private System.Windows.Forms.TextBox studentBox3;
        private System.Windows.Forms.TextBox instructorBox4;
        private System.Windows.Forms.TextBox enrolementBox5;
    }
}