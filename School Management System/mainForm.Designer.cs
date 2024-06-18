namespace School_Management_System
{
    partial class mainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.addTeacherBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.dshboardBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardForm1 = new School_Management_System.DashboardForm();
            this.addStudentsForm1 = new School_Management_System.AddStudentsForm();
            this.addTeachersForm1 = new School_Management_System.AddTeachersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1375, 44);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1337, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 38);
            this.label3.TabIndex = 1;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "School Managment System | Main Form";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.addTeacherBtn);
            this.panel2.Controls.Add(this.addStudentBtn);
            this.panel2.Controls.Add(this.dshboardBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 754);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 703);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Logout";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::School_Management_System.Properties.Resources.icons8_logout_rounded_up_filled_35px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 694);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 48);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addTeacherBtn
            // 
            this.addTeacherBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTeacherBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.addTeacherBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.addTeacherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacherBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeacherBtn.ForeColor = System.Drawing.Color.White;
            this.addTeacherBtn.Image = global::School_Management_System.Properties.Resources.icons8_training_35px;
            this.addTeacherBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTeacherBtn.Location = new System.Drawing.Point(12, 392);
            this.addTeacherBtn.Name = "addTeacherBtn";
            this.addTeacherBtn.Size = new System.Drawing.Size(234, 51);
            this.addTeacherBtn.TabIndex = 4;
            this.addTeacherBtn.Text = "Add Teachers";
            this.addTeacherBtn.UseVisualStyleBackColor = true;
            this.addTeacherBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStudentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.addStudentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.addStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStudentBtn.ForeColor = System.Drawing.Color.White;
            this.addStudentBtn.Image = global::School_Management_System.Properties.Resources.icons8_student_35px;
            this.addStudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addStudentBtn.Location = new System.Drawing.Point(12, 323);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(234, 51);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add Students";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dshboardBtn
            // 
            this.dshboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dshboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.dshboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.dshboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dshboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dshboardBtn.ForeColor = System.Drawing.Color.White;
            this.dshboardBtn.Image = global::School_Management_System.Properties.Resources.icons8_dashboard_50px_2;
            this.dshboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dshboardBtn.Location = new System.Drawing.Point(12, 256);
            this.dshboardBtn.Name = "dshboardBtn";
            this.dshboardBtn.Size = new System.Drawing.Size(234, 51);
            this.dshboardBtn.TabIndex = 2;
            this.dshboardBtn.Text = "Dashboard";
            this.dshboardBtn.UseVisualStyleBackColor = true;
            this.dshboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::School_Management_System.Properties.Resources.icons8_School_80px_1;
            this.pictureBox1.Location = new System.Drawing.Point(67, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.addStudentsForm1);
            this.panel3.Controls.Add(this.addTeachersForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(261, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1114, 754);
            this.panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardForm1.Location = new System.Drawing.Point(0, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1114, 754);
            this.dashboardForm1.TabIndex = 2;
            // 
            // addStudentsForm1
            // 
            this.addStudentsForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentsForm1.Location = new System.Drawing.Point(0, 0);
            this.addStudentsForm1.Name = "addStudentsForm1";
            this.addStudentsForm1.Size = new System.Drawing.Size(1114, 754);
            this.addStudentsForm1.TabIndex = 1;
            // 
            // addTeachersForm1
            // 
            this.addTeachersForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeachersForm1.Location = new System.Drawing.Point(0, 0);
            this.addTeachersForm1.Name = "addTeachersForm1";
            this.addTeachersForm1.Size = new System.Drawing.Size(1114, 754);
            this.addTeachersForm1.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 798);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dshboardBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addTeacherBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private AddTeachersForm addTeachersForm1;
        private AddStudentsForm addStudentsForm1;
        private DashboardForm dashboardForm1;
    }
}