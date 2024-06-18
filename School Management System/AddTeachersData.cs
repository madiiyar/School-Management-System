using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace School_Management_System
{
    internal class AddTeachersData
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public int ID { get; set; }
        public string TeacherID { get; set; } //1
        public string TeacherName { get; set; } //2
        public string TeacherGender { get; set; } //3
        public string TeacherAddress { get; set; } //4
        public string TeacherImage { get; set; } //5
        public string Status { get; set; } //6
        public string DateInsert { get; set; } //7

        public List<AddTeachersData> teacherData()
        {
            List<AddTeachersData> listData = new List<AddTeachersData>();
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddTeachersData addTeachersData = new AddTeachersData();
                            addTeachersData.ID = (int)reader["id"];
                            addTeachersData.TeacherID = reader["teacher_id"].ToString();
                            addTeachersData.TeacherName = reader["teacher_name"].ToString();
                            addTeachersData.TeacherGender = reader["teacher_gender"].ToString();
                            addTeachersData.TeacherAddress = reader["teacher_address"].ToString();
                            addTeachersData.TeacherImage = reader["teacher_image"].ToString();
                            addTeachersData.Status = reader["teacher_status"].ToString();
                            addTeachersData.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addTeachersData);
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
    }
}
