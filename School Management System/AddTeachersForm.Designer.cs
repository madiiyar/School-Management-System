namespace School_Management_System
{
    partial class AddTeachersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.teacher_statusField = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.teacher_image = new System.Windows.Forms.PictureBox();
            this.teacher_addressField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teacher_genderField = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher_nameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher_idField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teacherGridData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_image)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.teacher_statusField);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.deleteBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.updateBtn);
            this.panel2.Controls.Add(this.addBtn);
            this.panel2.Controls.Add(this.importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.teacher_addressField);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.teacher_genderField);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.teacher_nameField);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.teacher_idField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(22, 452);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 277);
            this.panel2.TabIndex = 3;
            // 
            // teacher_statusField
            // 
            this.teacher_statusField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_statusField.FormattingEnabled = true;
            this.teacher_statusField.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.teacher_statusField.Location = new System.Drawing.Point(672, 16);
            this.teacher_statusField.Name = "teacher_statusField";
            this.teacher_statusField.Size = new System.Drawing.Size(182, 28);
            this.teacher_statusField.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(604, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status:";
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
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.teacher_image);
            this.panel3.Location = new System.Drawing.Point(913, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 148);
            this.panel3.TabIndex = 14;
            // 
            // teacher_image
            // 
            this.teacher_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher_image.Location = new System.Drawing.Point(0, 0);
            this.teacher_image.Name = "teacher_image";
            this.teacher_image.Size = new System.Drawing.Size(131, 148);
            this.teacher_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teacher_image.TabIndex = 0;
            this.teacher_image.TabStop = false;
            // 
            // teacher_addressField
            // 
            this.teacher_addressField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_addressField.Location = new System.Drawing.Point(371, 13);
            this.teacher_addressField.Multiline = true;
            this.teacher_addressField.Name = "teacher_addressField";
            this.teacher_addressField.Size = new System.Drawing.Size(218, 79);
            this.teacher_addressField.TabIndex = 9;
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
            // teacher_genderField
            // 
            this.teacher_genderField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_genderField.FormattingEnabled = true;
            this.teacher_genderField.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.teacher_genderField.Location = new System.Drawing.Point(103, 118);
            this.teacher_genderField.Name = "teacher_genderField";
            this.teacher_genderField.Size = new System.Drawing.Size(182, 28);
            this.teacher_genderField.TabIndex = 7;
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
            // teacher_nameField
            // 
            this.teacher_nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_nameField.Location = new System.Drawing.Point(103, 65);
            this.teacher_nameField.Name = "teacher_nameField";
            this.teacher_nameField.Size = new System.Drawing.Size(182, 27);
            this.teacher_nameField.TabIndex = 5;
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
            // teacher_idField
            // 
            this.teacher_idField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacher_idField.Location = new System.Drawing.Point(103, 17);
            this.teacher_idField.Name = "teacher_idField";
            this.teacher_idField.Size = new System.Drawing.Size(129, 27);
            this.teacher_idField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teacher ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.teacherGridData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 397);
            this.panel1.TabIndex = 2;
            // 
            // teacherGridData
            // 
            this.teacherGridData.AllowUserToAddRows = false;
            this.teacherGridData.AllowUserToDeleteRows = false;
            this.teacherGridData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.teacherGridData.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherGridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.teacherGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teacherGridData.EnableHeadersVisualStyles = false;
            this.teacherGridData.Location = new System.Drawing.Point(21, 71);
            this.teacherGridData.Name = "teacherGridData";
            this.teacherGridData.ReadOnly = true;
            this.teacherGridData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.teacherGridData.RowHeadersVisible = false;
            this.teacherGridData.RowHeadersWidth = 51;
            this.teacherGridData.RowTemplate.Height = 24;
            this.teacherGridData.Size = new System.Drawing.Size(1023, 305);
            this.teacherGridData.TabIndex = 1;
            this.teacherGridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teacherGridData_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher\'s Data";
            // 
            // AddTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddTeachersForm";
            this.Size = new System.Drawing.Size(1114, 754);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherGridData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox teacher_addressField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox teacher_genderField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher_nameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacher_idField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView teacherGridData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox teacher_statusField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox teacher_image;
    }
}
