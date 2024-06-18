using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace School_Management_System
{
    public partial class AddTeachersForm : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AddTeachersForm()
        {
            InitializeComponent();
            teacherDisplayData();
        }

        public void teacherDisplayData()
        {
            AddTeachersData addTD = new AddTeachersData();
            teacherGridData.DataSource = addTD.teacherData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teacher_idField.Text)
                || string.IsNullOrWhiteSpace(teacher_nameField.Text)
                || string.IsNullOrWhiteSpace(teacher_genderField.Text)
                || string.IsNullOrWhiteSpace(teacher_addressField.Text)
                || string.IsNullOrWhiteSpace(teacher_statusField.Text)
                || teacher_image.Image == null
                || string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                string checkTeacherID = "SELECT COUNT(*) FROM teachers WHERE teacher_id = @teacherID";

                using (SqlCommand checkTID = new SqlCommand(checkTeacherID, connection))
                {
                    checkTID.Parameters.AddWithValue("@teacherID", teacher_idField.Text.Trim());
                    int count = (int)checkTID.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show("Teacher ID: " + teacher_idField.Text.Trim() + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                DateTime today = DateTime.Today;
                string insertData = "INSERT INTO teachers (teacher_id, teacher_name, teacher_gender, teacher_address, teacher_image, teacher_status, date_insert) VALUES" +
                                    "(@teacherID, @teacherName, @teacherGender, @teacherAddress, @teacherImage, @teacherStatus, @dateInsert)";

                string path = Path.Combine(@"C:\Users\amadi\Documents\WorldSkills\School Management System\School Management System\Teacher_Directory\", teacher_idField.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(imagePath, path, true);

                using (SqlCommand cmd = new SqlCommand(insertData, connection))
                {
                    cmd.Parameters.AddWithValue("@teacherID", teacher_idField.Text.Trim());
                    cmd.Parameters.AddWithValue("@teacherName", teacher_nameField.Text.Trim());
                    cmd.Parameters.AddWithValue("@teacherGender", teacher_genderField.Text.Trim());
                    cmd.Parameters.AddWithValue("@teacherAddress", teacher_addressField.Text.Trim());
                    cmd.Parameters.AddWithValue("@teacherImage", path);
                    cmd.Parameters.AddWithValue("@teacherStatus", teacher_statusField.Text.Trim());
                    cmd.Parameters.AddWithValue("@dateInsert", today.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Teacher added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    teacherDisplayData(); // Refresh the data grid
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
            teacher_idField.Text = string.Empty;
            teacher_nameField.Text = string.Empty;
            teacher_statusField.SelectedIndex = -1;
            teacher_addressField.Text = string.Empty;
            teacher_genderField.SelectedIndex = -1;
            teacher_image.Image = null;
            imagePath = string.Empty;

        }

        private string imagePath;

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image files (*.jpg; *.png)|*.jpg;*.png"
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;
                teacher_image.ImageLocation = imagePath;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teacher_idField.Text)
                || string.IsNullOrWhiteSpace(teacher_nameField.Text)
                || string.IsNullOrWhiteSpace(teacher_genderField.Text)
                || string.IsNullOrWhiteSpace(teacher_addressField.Text)
                || string.IsNullOrWhiteSpace(teacher_statusField.Text)
                || teacher_image.Image == null
                || string.IsNullOrWhiteSpace(imagePath))
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        DialogResult check = MessageBox.Show("Are you sure you want to UPDATE?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if(check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;
                            String updateData = "UPDATE teachers SET teacher_name = @teacherName, teacher_gender = @teacherGender, teacher_address = @teacherAddress,teacher_status = @teacherStatus, date_update = @dateUpdate WHERE teacher_id = @teacherID";


                            string path = Path.Combine(@"C:\Users\amadi\Documents\WorldSkills\School Management System\School Management System\Teacher_Directory\", teacher_idField.Text.Trim() + ".jpg");

                            

                            using (SqlCommand cmd = new SqlCommand(updateData, connection))
                            {
                                cmd.Parameters.AddWithValue("@teacherName", teacher_nameField.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherGender", teacher_genderField.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherAddress", teacher_addressField.Text.Trim());
                                cmd.Parameters.AddWithValue("@teacherStatus", teacher_statusField.Text.Trim());
                                cmd.Parameters.AddWithValue("@dateUpdate", today.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("teacherId", teacher_idField.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                teacherDisplayData(); // Refresh the data grid
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

        private void teacherGridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = teacherGridData.Rows[e.RowIndex];

                teacher_idField.Text = row.Cells[1].Value.ToString();
                teacher_nameField.Text = row.Cells[2].Value.ToString();
                teacher_genderField.Text = row.Cells[3].Value.ToString();
                teacher_addressField.Text = row.Cells[4].Value.ToString();

                imagePath = row.Cells[5].Value.ToString();


                string imageData = row.Cells[5].Value.ToString();

                if (imageData != null)
                {
                    teacher_image.Image = Image.FromFile(imagePath);

                }
                else
                {
                    teacher_image.Image = null;
                }
                teacher_statusField.Text = row.Cells[6].Value.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(teacher_idField.Text == "")
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
                            String deleteData = "UPDATE teachers SET date_delete = @dateDelete WHERE teacher_id = @teacherID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connection))
                            {
                                cmd.Parameters.AddWithValue("@dateDelete", today.ToString("yyyy-MM-dd"));
                                cmd.Parameters.AddWithValue("@teacherID", teacher_idField.Text.Trim());

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("DELETED successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                teacherDisplayData(); // Refresh the data grid
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
