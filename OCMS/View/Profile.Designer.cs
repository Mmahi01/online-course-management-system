namespace OCMS.View
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.useriductextBox4 = new System.Windows.Forms.TextBox();
            this.changepasswordbutton3 = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.editbutton2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rolecomboBox1 = new System.Windows.Forms.ComboBox();
            this.emailtextBox3 = new System.Windows.Forms.TextBox();
            this.usernametextBox2 = new System.Windows.Forms.TextBox();
            this.useridtextBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gobackbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.useriductextBox4);
            this.splitContainer1.Panel1.Controls.Add(this.changepasswordbutton3);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer1.Panel2.Controls.Add(this.savebutton);
            this.splitContainer1.Panel2.Controls.Add(this.editbutton2);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.rolecomboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.emailtextBox3);
            this.splitContainer1.Panel2.Controls.Add(this.usernametextBox2);
            this.splitContainer1.Panel2.Controls.Add(this.useridtextBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1073, 681);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 1;
            // 
            // useriductextBox4
            // 
            this.useriductextBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.useriductextBox4.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useriductextBox4.Location = new System.Drawing.Point(53, 362);
            this.useriductextBox4.Multiline = true;
            this.useriductextBox4.Name = "useriductextBox4";
            this.useriductextBox4.Size = new System.Drawing.Size(250, 42);
            this.useriductextBox4.TabIndex = 2;
            this.useriductextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.useriductextBox4.TextChanged += new System.EventHandler(this.useriductextBox4_TextChanged);
            // 
            // changepasswordbutton3
            // 
            this.changepasswordbutton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.changepasswordbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changepasswordbutton3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changepasswordbutton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changepasswordbutton3.Location = new System.Drawing.Point(22, 606);
            this.changepasswordbutton3.Name = "changepasswordbutton3";
            this.changepasswordbutton3.Size = new System.Drawing.Size(313, 47);
            this.changepasswordbutton3.TabIndex = 1;
            this.changepasswordbutton3.Text = "Change Password";
            this.changepasswordbutton3.UseVisualStyleBackColor = false;
            this.changepasswordbutton3.Click += new System.EventHandler(this.changepasswordbutton3_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.White;
            this.savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebutton.Location = new System.Drawing.Point(321, 475);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // editbutton2
            // 
            this.editbutton2.BackColor = System.Drawing.Color.White;
            this.editbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editbutton2.Location = new System.Drawing.Point(226, 475);
            this.editbutton2.Name = "editbutton2";
            this.editbutton2.Size = new System.Drawing.Size(75, 23);
            this.editbutton2.TabIndex = 8;
            this.editbutton2.Text = "Edit";
            this.editbutton2.UseVisualStyleBackColor = false;
            this.editbutton2.Click += new System.EventHandler(this.editbutton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "UserID";
            // 
            // rolecomboBox1
            // 
            this.rolecomboBox1.FormattingEnabled = true;
            this.rolecomboBox1.Location = new System.Drawing.Point(390, 327);
            this.rolecomboBox1.Name = "rolecomboBox1";
            this.rolecomboBox1.Size = new System.Drawing.Size(173, 24);
            this.rolecomboBox1.TabIndex = 3;
            this.rolecomboBox1.SelectedIndexChanged += new System.EventHandler(this.rolecomboBox1_SelectedIndexChanged);
            // 
            // emailtextBox3
            // 
            this.emailtextBox3.Location = new System.Drawing.Point(47, 330);
            this.emailtextBox3.Name = "emailtextBox3";
            this.emailtextBox3.Size = new System.Drawing.Size(173, 22);
            this.emailtextBox3.TabIndex = 2;
            this.emailtextBox3.TextChanged += new System.EventHandler(this.emailtextBox3_TextChanged);
            // 
            // usernametextBox2
            // 
            this.usernametextBox2.Location = new System.Drawing.Point(390, 166);
            this.usernametextBox2.Name = "usernametextBox2";
            this.usernametextBox2.Size = new System.Drawing.Size(173, 22);
            this.usernametextBox2.TabIndex = 1;
            this.usernametextBox2.TextChanged += new System.EventHandler(this.usernametextBox2_TextChanged);
            // 
            // useridtextBox1
            // 
            this.useridtextBox1.Location = new System.Drawing.Point(47, 166);
            this.useridtextBox1.Name = "useridtextBox1";
            this.useridtextBox1.Size = new System.Drawing.Size(173, 22);
            this.useridtextBox1.TabIndex = 0;
            this.useridtextBox1.TextChanged += new System.EventHandler(this.useridtextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gobackbutton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 71);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "OCMS - User Profile";
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
            // Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1073, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gobackbutton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox rolecomboBox1;
        private System.Windows.Forms.TextBox emailtextBox3;
        private System.Windows.Forms.TextBox usernametextBox2;
        private System.Windows.Forms.TextBox useridtextBox1;
        private System.Windows.Forms.Button editbutton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button changepasswordbutton3;
        private System.Windows.Forms.TextBox useriductextBox4;
        private System.Windows.Forms.Button savebutton;
    }
}