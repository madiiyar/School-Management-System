using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    internal class AddStudentData
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; } //0
        public string StudentID { get; set; } //1
        public string StudentName { get; set; } //2
        public string StudentGender { get; set; } //3
        public string StudentAddress { get; set; } //4
        public string StudentGrade { get; set; } //5
        public string StudentSection { get; set; } //6
        public string StudentImage { get; set; } //7
        public string Status { get; set; } //8
        public string DateInsert { get; set; } //9

        public List<AddStudentData> studentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * FROM students WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addStudentsData = new AddStudentData();
                            addStudentsData.ID = (int)reader["id"];
                            addStudentsData.StudentID = reader["student_id"].ToString();
                            addStudentsData.StudentName = reader["student_name"].ToString();
                            addStudentsData.StudentGender = reader["student_gender"].ToString();
                            addStudentsData.StudentAddress = reader["student_address"].ToString();
                            addStudentsData.StudentGrade = reader["student_grade"].ToString();
                            addStudentsData.StudentSection = reader["student_section"].ToString();
                            addStudentsData.StudentImage = reader["student_image"].ToString();
                            addStudentsData.Status = reader["student_stutus"].ToString();
                            addStudentsData.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addStudentsData);
                        }
                        reader.Close();
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

            return listData;
        }



        public List<AddStudentData> dashboardStudentData()
        {
            List<AddStudentData> listData = new List<AddStudentData>();

            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM students WHERE date_insert = @date_insert AND date_delete  IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@date_insert", today.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addStudentsData = new AddStudentData();
                            addStudentsData.ID = (int)reader["id"];
                            addStudentsData.StudentID = reader["student_id"].ToString();
                            addStudentsData.StudentName = reader["student_name"].ToString();
                            addStudentsData.StudentGender = reader["student_gender"].ToString();
                            addStudentsData.StudentAddress = reader["student_address"].ToString();
                            addStudentsData.StudentGrade = reader["student_grade"].ToString();
                            addStudentsData.StudentSection = reader["student_section"].ToString();
                            addStudentsData.StudentImage = reader["student_image"].ToString();
                            addStudentsData.Status = reader["student_stutus"].ToString();
                            addStudentsData.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addStudentsData);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            return listData;
        }
    }
}
