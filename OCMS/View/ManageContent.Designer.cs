namespace OCMS.View
{
    partial class ManageContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageContent));
            this.selectbutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openbutton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.editbutton1 = new System.Windows.Forms.Button();
            this.courseidtextBox1 = new System.Windows.Forms.TextBox();
            this.titletextBox2 = new System.Windows.Forms.TextBox();
            this.contenttextBox3 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.savebutton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gobackbutton1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectbutton1
            // 
            this.selectbutton1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbutton1.Location = new System.Drawing.Point(82, 391);
            this.selectbutton1.Name = "selectbutton1";
            this.selectbutton1.Size = new System.Drawing.Size(149, 41);
            this.selectbutton1.TabIndex = 11;
            this.selectbutton1.Text = "Select";
            this.selectbutton1.UseVisualStyleBackColor = true;
            this.selectbutton1.Click += new System.EventHandler(this.selectbutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(310, 240);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Courses";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openbutton1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(711, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 345);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Content List";
            // 
            // openbutton1
            // 
            this.openbutton1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openbutton1.Location = new System.Drawing.Point(6, 298);
            this.openbutton1.Name = "openbutton1";
            this.openbutton1.Size = new System.Drawing.Size(307, 41);
            this.openbutton1.TabIndex = 9;
            this.openbutton1.Text = "Open";
            this.openbutton1.UseVisualStyleBackColor = true;
            this.openbutton1.Click += new System.EventHandler(this.openbutton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Book Antiqua", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(3, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 246);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // editbutton1
            // 
            this.editbutton1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton1.Location = new System.Drawing.Point(237, 391);
            this.editbutton1.Name = "editbutton1";
            this.editbutton1.Size = new System.Drawing.Size(155, 41);
            this.editbutton1.TabIndex = 13;
            this.editbutton1.Text = "Edit";
            this.editbutton1.UseVisualStyleBackColor = true;
            this.editbutton1.Click += new System.EventHandler(this.editbutton1_Click);
            // 
            // courseidtextBox1
            // 
            this.courseidtextBox1.Location = new System.Drawing.Point(102, 27);
            this.courseidtextBox1.Name = "courseidtextBox1";
            this.courseidtextBox1.Size = new System.Drawing.Size(97, 22);
            this.courseidtextBox1.TabIndex = 14;
            this.courseidtextBox1.TextChanged += new System.EventHandler(this.courseidtextBox1_TextChanged);
            // 
            // titletextBox2
            // 
            this.titletextBox2.Location = new System.Drawing.Point(430, 29);
            this.titletextBox2.Name = "titletextBox2";
            this.titletextBox2.Size = new System.Drawing.Size(161, 22);
            this.titletextBox2.TabIndex = 15;
            this.titletextBox2.TextChanged += new System.EventHandler(this.titletextBox2_TextChanged);
            // 
            // contenttextBox3
            // 
            this.contenttextBox3.Location = new System.Drawing.Point(288, 75);
            this.contenttextBox3.Name = "contenttextBox3";
            this.contenttextBox3.Size = new System.Drawing.Size(402, 22);
            this.contenttextBox3.TabIndex = 16;
            this.contenttextBox3.TextChanged += new System.EventHandler(this.contenttextBox3_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(776, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // savebutton1
            // 
            this.savebutton1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton1.Location = new System.Drawing.Point(406, 125);
            this.savebutton1.Name = "savebutton1";
            this.savebutton1.Size = new System.Drawing.Size(146, 38);
            this.savebutton1.TabIndex = 18;
            this.savebutton1.Text = "Save";
            this.savebutton1.UseVisualStyleBackColor = true;
            this.savebutton1.Click += new System.EventHandler(this.savebutton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gobackbutton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 71);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course Content";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "CourseID";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.label6);
            this.groupbox2.Controls.Add(this.label5);
            this.groupbox2.Controls.Add(this.savebutton1);
            this.groupbox2.Controls.Add(this.label4);
            this.groupbox2.Controls.Add(this.contenttextBox3);
            this.groupbox2.Controls.Add(this.label3);
            this.groupbox2.Controls.Add(this.dateTimePicker1);
            this.groupbox2.Controls.Add(this.courseidtextBox1);
            this.groupbox2.Controls.Add(this.titletextBox2);
            this.groupbox2.Location = new System.Drawing.Point(82, 486);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(942, 169);
            this.groupbox2.TabIndex = 21;
            this.groupbox2.TabStop = false;
            this.groupbox2.Enter += new System.EventHandler(this.groupbox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Content Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(718, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(202, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Content";
            // 
            // ManageContent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1070, 681);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editbutton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageContent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectbutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openbutton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button editbutton1;
        private System.Windows.Forms.TextBox courseidtextBox1;
        private System.Windows.Forms.TextBox titletextBox2;
        private System.Windows.Forms.TextBox contenttextBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button savebutton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button gobackbutton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}