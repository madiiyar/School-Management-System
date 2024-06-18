namespace School_Management_System
{
    partial class AddStudentsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.student_section = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.student_grade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.student_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.student_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.student_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.student_image = new System.Windows.Forms.PictureBox();
            this.student_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.studentDataGrid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 397);
            this.panel1.TabIndex = 0;
            // 
            // studentDataGrid
            // 
            this.studentDataGrid.AllowUserToAddRows = false;
            this.studentDataGrid.AllowUserToDeleteRows = false;
            this.studentDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.studentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGrid.EnableHeadersVisualStyles = false;
            this.studentDataGrid.Location = new System.Drawing.Point(21, 71);
            this.studentDataGrid.Name = "studentDataGrid";
            this.studentDataGrid.ReadOnly = true;
            this.studentDataGrid.RowHeadersVisible = false;
            this.studentDataGrid.RowHeadersWidth = 51;
            this.studentDataGrid.RowTemplate.Height = 24;
            this.studentDataGrid.Size = new System.Drawing.Size(1023, 305);
            this.studentDataGrid.TabIndex = 1;
            this.studentDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student\'s Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.student_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.student_section);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.student_grade);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.student_address);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.student_gender);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.student_name);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.student_id);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(19, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 277);
            this.panel2.TabIndex = 1;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(710, 192);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(156, 49);
            this.deleteBtn.TabIndex = 19;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(519, 192);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(156, 49);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(331, 192);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(156, 49);
            this.updateBtn.TabIndex = 17;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(140, 192);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 49);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.importBtn.FlatAppearance.BorderSize = 0;
            this.importBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.importBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.importBtn.ForeColor = System.Drawing.Color.White;
            this.importBtn.Location = new System.Drawing.Point(913, 151);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(131, 39);
            this.importBtn.TabIndex = 15;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = false;
            this.importBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.student_image);
            this.panel3.Location = new System.Drawing.Point(913, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 148);
            this.panel3.TabIndex = 14;
            // 
            // student_section
            // 
            this.student_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_section.FormattingEnabled = true;
            this.student_section.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.student_section.Location = new System.Drawing.Point(688, 16);
            this.student_section.Name = "student_section";
            this.student_section.Size = new System.Drawing.Size(182, 28);
            this.student_section.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(620, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Section:";
            // 
            // student_grade
            // 
            this.student_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_grade.FormattingEnabled = true;
            this.student_grade.Items.AddRange(new object[] {
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6"});
            this.student_grade.Location = new System.Drawing.Point(371, 118);
            this.student_grade.Name = "student_grade";
            this.student_grade.Size = new System.Drawing.Size(218, 28);
            this.student_grade.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(301, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grade:";
            // 
            // student_address
            // 
            this.student_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_address.Location = new System.Drawing.Point(371, 13);
            this.student_address.Multiline = true;
            this.student_address.Name = "student_address";
            this.student_address.Size = new System.Drawing.Size(218, 79);
            this.student_address.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(299, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address:";
            // 
            // student_gender
            // 
            this.student_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_gender.FormattingEnabled = true;
            this.student_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.student_gender.Location = new System.Drawing.Point(103, 118);
            this.student_gender.Name = "student_gender";
            this.student_gender.Size = new System.Drawing.Size(182, 28);
            this.student_gender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender:";
            // 
            // student_name
            // 
            this.student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_name.Location = new System.Drawing.Point(103, 65);
            this.student_name.Name = "student_name";
            this.student_name.Size = new System.Drawing.Size(182, 27);
            this.student_name.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name:";
            // 
            // student_id
            // 
            this.student_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_id.Location = new System.Drawing.Point(103, 17);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(129, 27);
            this.student_id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID:";
            // 
            // student_image
            // 
            this.student_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.student_image.Location = new System.Drawing.Point(0, 0);
            this.student_image.Name = "student_image";
            this.student_image.Size = new System.Drawing.Size(131, 148);
            this.student_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.student_image.TabIndex = 0;
            this.student_image.TabStop = false;
            // 
            // student_status
            // 
            this.student_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.student_status.FormattingEnabled = true;
            this.student_status.Items.AddRange(new object[] {
            "Enrolled",
            "Pending",
            "Graduated"});
            this.student_status.Location = new System.Drawing.Point(688, 70);
            this.student_status.Name = "student_status";
            this.student_status.Size = new System.Drawing.Size(182, 28);
            this.student_status.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(620, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Status:";
            // 
            // AddStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudentsForm";
            this.Size = new System.Drawing.Size(1114, 754);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.student_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView studentDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox student_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox student_section;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox student_grade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox student_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox student_gender;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox student_image;
        private System.Windows.Forms.ComboBox student_status;
        private System.Windows.Forms.Label label8;
    }
}
