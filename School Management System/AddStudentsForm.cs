using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class AddStudentsForm : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AddStudentsForm()
        {
            InitializeComponent();

            displayStudentData();
        }

        public void displayStudentData()
        {
            AddStudentData studentData = new AddStudentData();
            studentDataGrid.DataSource = studentData.studentData();
        }

        public string imagePath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image files (*.jpg; *.png)|*.jpg;*.png"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                student_image.ImageLocation = imagePath;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(student_id.Text)
               || string.IsNullOrWhiteSpace(student_name.Text)
               || string.IsNullOrWhiteSpace(student_gender.Text)
               || string.IsNullOrWhiteSpace(student_address.Text)
               || string.IsNullOrWhiteSpace(student_grade.Text)
               || string.IsNullOrWhiteSpace(student_section.Text)
               || string.IsNullOrWhiteSpace(student_status.Text)
               || student_image.Image == null
               || string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                string checkStudentID = "SELECT COUNT(*) FROM students WHERE student_id = @studentID";

                using (SqlCommand checkSID = new SqlCommand(checkStudentID, connection))
                {
                    checkSID.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                    int count = (int)checkSID.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show("Student ID: " + student_id.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DateTime today = DateTime.Today;
                string insertData = "INSERT INTO students (student_id, student_name, student_gender, student_address, student_grade, student_section, student_stutus, student_image, date_insert) VALUES" +
                                    "(@studentID, @studentName, @studentGender, @studentAddress, @studentGrade, @studentSection, @studentStatus, @studentImage, @dateInsert)";

                string path = Path.Combine(@"C:\Users\amadi\Documents\WorldSkills\School Management System\School Management System\Student_Directory\", student_id.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(imagePath, path, true);

                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                {
                    cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentGrade", student_grade.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                    cmd.Parameters.AddWithValue("@studentImage", path);
                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    displayStudentData(); // Refresh the data grid
                    clearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public void clearFields()
        {
            student_id.Text = string.Empty;
            student_name.Text = string.Empty;
            student_gender.SelectedIndex = -1;
            student_address.Text = string.Empty;
            student_grade.SelectedIndex = -1;
            student_section.SelectedIndex = -1;
            student_status.SelectedIndex = -1;
            student_image.Image = null;
            imagePath = string.Empty;

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(student_id.Text)
               || string.IsNullOrWhiteSpace(student_name.Text)
               || string.IsNullOrWhiteSpace(student_gender.Text)
               || string.IsNullOrWhiteSpace(student_address.Text)
               || string.IsNullOrWhiteSpace(student_grade.Text)
               || string.IsNullOrWhiteSpace(student_section.Text)
               || string.IsNullOrWhiteSpace(student_status.Text)
               || student_image.Image == null
               || string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to UPDATE?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;
                            String updateData = "UPDATE students SET student_name = @studentName, student_gender = @studentGender, student_address = @studentAddress, student_grade = @studentGrade, student_section = @studentSection,  student_stutus = @studentStatus, date_update = @dateUpdate WHERE student_id = @studentID";


                            string path = Path.Combine(@"C:\Users\amadi\Documents\WorldSkills\School Management System\School Management System\Student_Directory\", student_id.Text.Trim() + ".jpg");



                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentName", student_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGender", student_gender.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentAddress", student_address.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentGrade", student_grade.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentSection", student_section.Text.Trim());
                                cmd.Parameters.AddWithValue("@studentStatus", student_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString("yyyy-MM-dd"));


                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayStudentData(); // Refresh the data grid
                                clearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void studentDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = studentDataGrid.Rows[e.RowIndex];

                student_id.Text = row.Cells[1].Value.ToString();
                student_name.Text = row.Cells[2].Value.ToString();
                student_gender.Text = row.Cells[3].Value.ToString();
                student_address.Text = row.Cells[4].Value.ToString();
                student_grade.Text = row.Cells[5].Value.ToString();
                student_section.Text = row.Cells[6].Value.ToString();

                imagePath = row.Cells[7].Value.ToString();


                string imageData = row.Cells[7].Value.ToString();

                if (imageData != null)
                {
                    student_image.Image = Image.FromFile(imagePath);

                }
                else
                {
                    student_image.Image = null;
                }
                student_status.Text = row.Cells[8].Value.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (student_id.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to DELETE?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;
                            String deleteData = "UPDATE students SET date_delete = @dateDelete WHERE student_id = @studentID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connection))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@studentID", student_id.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("DELETED successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayStudentData(); // Refresh the data grid
                                clearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
