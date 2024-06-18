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
    public partial class loginForm : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amadi\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheck.Checked)
            {
                passwordField.UseSystemPasswordChar = false;
            }else
            {
                passwordField.UseSystemPasswordChar =true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameField.Text == "" || passwordField.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                
                try
                {
                    connection.Open();
                    string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                    using(SqlCommand cmd = new SqlCommand(selectData, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", usernameField.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", passwordField.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Login Successfully  ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            mainForm main = new mainForm();
                            main.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Incorrect  username or password  ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }finally
                {
                    connection.Close();
                }
            }
        }
    }
}
