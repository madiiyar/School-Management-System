using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class DashboardForm : UserControl
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\Documents\school.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public DashboardForm()
        {
            InitializeComponent();
            displayTotalES();
            displayTotalTT();
            displayTotalGS();
            displayEnrolledStudentToday();
        }

        public void displayTotalES()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_stutus = 'Enrolled' AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempES = 0;
                        if (reader.Read())
                        {
                            tempES = Convert.ToInt32(reader[0]);
                            enrolledStudents.Text = tempES.ToString();
                        }
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


        public void displayTotalTT()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT COUNT(id) FROM teachers WHERE teacher_status = 'Active' AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempTT = 0;
                        if (reader.Read())
                        {
                            tempTT = Convert.ToInt32(reader[0]);
                            totalTeachers.Text = tempTT.ToString();
                        }
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

        public void displayTotalGS()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    string selectData = "SELECT COUNT(id) FROM students WHERE student_stutus = 'Graduated' AND date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        int tempGS = 0;
                        if (reader.Read())
                        {
                            tempGS = Convert.ToInt32(reader[0]);
                            graduatedStudents.Text = tempGS.ToString();
                        }
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


        public void displayEnrolledStudentToday()
        {
            AddStudentData data = new AddStudentData();

            DataGridView1.DataSource = data.dashboardStudentData();
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
